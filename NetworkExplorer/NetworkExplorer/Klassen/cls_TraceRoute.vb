Option Explicit On
Option Strict On
Imports System.Net

''' <summary>
''' Die Klasse stellt eine TraceRoute Zielsuche zur Verfügung.
''' </summary>
''' <remarks>
''' VB.Net 2005 Klassenmodul
''' Diese Klasse stellt eine TraceRoute Internet Zielsuche zur
''' Verfügung. Die Routenverfolgung wird dabei über die Ping
''' Klasse aus System.Net.NetworkInformation realisiert. Dabei
''' wird in einer Schleife die TTL (Time To Live) Eigenschaft
''' aus den PingOptions jeweils um eins erhöht, bis der Zielhost
''' erreicht, oder MaxHops überschritten wird.
''' 
''' Juli 2006 - VB-Power.net
''' http://www.vb-power.net
''' </remarks>
Public Class cls_TraceRoute

    ''' <summary>
    ''' Datenklasse - enthält ein Knoten der Zielsuche.
    ''' </summary>
    Class TraceRTArgs
        Implements ICloneable

        Friend IPAddress As String
        Friend DNSName As String
        Friend RoundTripTime As Long
        Friend Buffer As Byte()
        Friend Status As String

        ''' <summary>
        ''' Erstellt eine Kopie der Datenklasse.
        ''' </summary>
        Public Function Clone() As Object Implements System.ICloneable.Clone
            Return Me.MemberwiseClone
        End Function
    End Class

    ' Buffer-Konstante
    Private Const sBuffer As String = "ReturnToSenderClassTraceRoute"

    ' Private Variablen der Klasse
    Private m_Buffer() As Byte = System.Text.Encoding.Default.GetBytes(sBuffer)
    Private m_MaxHops As Integer = 30
    Private m_Timeout As Integer = 500
    Private m_RouteList As New List(Of TraceRTArgs)

    ' Events der Klasse
    Public Event ReturnRouteNode(ByVal HopNum As Integer, _
      ByVal e As TraceRTArgs, ByRef Cancel As Boolean)

    Public Event TraceRTDone(ByVal HostReached As Boolean, _
      ByVal RouteList As List(Of TraceRTArgs))

    Public Event HostInfo(ByVal HostName As String, _
      ByVal IPAddress As String)


    ''' <summary>
    ''' Setzt den Ping-Reply Buffer, oder liest ihn aus.
    ''' </summary>
    Public Property Buffer() As Byte()
        Get
            Return m_Buffer
        End Get
        Set(ByVal value As Byte())
            Try
                m_Buffer = value
            Catch ex As Exception
                Throw ex
            End Try
        End Set
    End Property

    ''' <summary>
    ''' Legt die max. Anzahl von Knoten bei der Zielsuche fest.
    ''' </summary>
    Public Property MaxHops() As Integer
        Get
            Return m_MaxHops
        End Get
        Set(ByVal value As Integer)
            m_MaxHops = value
        End Set
    End Property

    ''' <summary>
    ''' Setzt den Timeout für die Knoten bei der Zielsuche.
    ''' </summary>
    Public Property Timeout() As Integer
        Get
            Return m_Timeout
        End Get
        Set(ByVal value As Integer)
            m_Timeout = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Route der Zielsuche zurück.
    ''' </summary>
    Public ReadOnly Property RouteList() As List(Of TraceRTArgs)
        Get
            Return m_RouteList
        End Get
    End Property

    ''' <summary>
    ''' Startet die Zielsuche zum angegebenen Host.
    ''' </summary>
    ''' <param name="Host">Die IP-Adresse oder der DNS-Name des Ziels</param>
    Public Sub TraceRT(ByVal Host As String)
        Me.TraceRoute(Host, True)
    End Sub

    ''' <summary>
    ''' Startet die Zielsuche zum angegebenen Host.
    ''' </summary>
    ''' <param name="Host">Die IP-Adresse oder der DNS-Name des Ziels</param>
    ''' <param name="ResolveDNS">Bestimmt, ob der DNS-Name der Knoten
    ''' ermittelt werden soll.</param>
    Public Sub TraceRT(ByVal Host As String, ByVal ResolveDNS As Boolean)
        Me.TraceRoute(Host, ResolveDNS)
    End Sub

    ''' <summary>
    ''' Die eigentliche Zielsuche
    ''' </summary>
    Private Sub TraceRoute(ByVal Host As String, ByVal ResolveDNS As Boolean)
        Dim Ping, P1 As New NetworkInformation.Ping
        Dim PingOption As New NetworkInformation.PingOptions
        Dim PingReply, R1 As NetworkInformation.PingReply
        Dim isHostReached As Boolean = False

        Try
            ' Die IP-Addresse des Zielhosts ermitteln
            Dim i As IPHostEntry = Dns.GetHostEntry(Host)
            Dim ip As IPAddress = i.AddressList(0)

            ' Event HostInfo in die aufrufende Form feuern.
            RaiseEvent HostInfo(i.HostName, i.AddressList(0).ToString)

            ' RouteList löschen
            m_RouteList.Clear()

            ' Schleife über die max. Anzahl von
            ' Knoten bei der Zielsuche.
            For x As Integer = 1 To m_MaxHops
                Dim isCancel As Boolean = False
                Dim Ret As New TraceRTArgs

                ' Ping-Optionen setzen und Ping auslösen
                PingOption.Ttl = x
                PingOption.DontFragment = False
                PingReply = Ping.Send(ip, m_Timeout, m_Buffer, PingOption)

                ' Konnte ein Knoten erreicht werden?
                If Not PingReply.Address Is Nothing Then

                    ' Die Return-Klasse(TraceRTArgs) füllen
                    With Ret
                        .Buffer = PingReply.Buffer
                        .IPAddress = PingReply.Address.ToString
                        .Status = PingReply.Status.ToString

                        ' Prüfen, ob der letzte Knoten den Ping Aufgrund
                        ' des TTL (Time To Live) Werts verworfen hat.
                        If .Status.ToUpper.Equals("TTLEXPIRED") Then
                            Try
                                ' Benötigte Zeit bis zum letzten Knoten ermitteln
                                R1 = P1.Send(.IPAddress, m_Timeout)
                                .RoundTripTime = R1.RoundtripTime
                            Catch : End Try
                        Else
                            .RoundTripTime = PingReply.RoundtripTime
                        End If

                        ' DNS-Name des letzten Knoten ermitteln
                        If ResolveDNS Then
                            Try
                                Dim d As IPHostEntry = Dns.GetHostEntry(PingReply.Address.ToString)
                                .DNSName = d.HostName
                            Catch ex As Exception
                                .DNSName = "unresolved"
                            End Try
                        End If
                    End With

                    ' Return Klasse(TraceRTArgs) in die List(Of) schieben
                    m_RouteList.Add(CType(Ret.Clone, TraceRTArgs))

                    ' Event in die aufrufende Form feuern. Dabei wird die
                    ' letzte Knotennummer, die Return-Klasse und die
                    ' Abbruchbedingung übergeben.
                    RaiseEvent ReturnRouteNode(x, Ret, isCancel)
                    Application.DoEvents()

                    ' Wurde der Zielhost erreicht? Wenn Ja, dann Schleife verlassen.
                    If PingReply.Status.ToString.ToUpper.Equals("SUCCESS") Then
                        isHostReached = True
                        Exit For
                    End If

                    ' User-Abbruchbedingung prüfen und ggf. Schleife verlassen.
                    If isCancel Then
                        isHostReached = False
                        Exit For
                    End If
                Else
                    ' Der letzte Knoten konnte nicht erreicht werden.
                    Ret.Status = PingReply.Status.ToString
                    m_RouteList.Add(CType(Ret.Clone, TraceRTArgs))
                    RaiseEvent ReturnRouteNode(x, Ret, isCancel)
                    Application.DoEvents()

                    If isCancel Then
                        isHostReached = False
                        Exit For
                    End If
                End If
            Next

            ' Schleifendurchlauf beendet. Event feuern und dabei
            ' die RouteList zurückgeben.
            RaiseEvent TraceRTDone(isHostReached, m_RouteList)

        Catch ex As NetworkInformation.PingException
            Throw ex
        Catch ex As Sockets.SocketException
            Throw ex
        Catch ex As Exception
            Throw ex
        Finally
            Ping.Dispose()
            P1.Dispose()
        End Try
    End Sub
End Class