Public Class cls_PingIPv4

    Inherits System.Net.NetworkInformation.Ping

    Private pAnsichtFall As Integer
    Private pPingStop As Boolean
    Private pPingErfolg As Boolean

    WriteOnly Property PingStop
        Set(ByVal value)
            pPingStop = value
        End Set
    End Property

    Private Enum enumPingAusgabe
        IPScanner = 1
        Explorer = 2
        PortScanner = 3
    End Enum

#Region "init Dictionary"

    Private Function ScanServerPorts() As Dictionary(Of Integer, String)

        Dim dictPorts As New Dictionary(Of Integer, String)

        With dictPorts
            .Add(enumTCPPort.FTPControl, "FTP")
            .Add(enumTCPPort.SSH, "SSH")
            .Add(enumTCPPort.Telnet, "Telnet")
            .Add(enumTCPPort.SMTP, "Mail")
            .Add(enumTCPPort.DNS, "DNS")
            .Add(enumTCPPort.DHCPServer, "DHCP")
            .Add(enumTCPPort.TFTP, "TFTP")
            .Add(enumTCPPort.MSSQL, "MSSQL")
            .Add(enumTCPPort.MySQL, "MySQL")
            .Add(enumTCPPort.NetBIOSSession, "NetBIOS")
            .Add(enumTCPPort.Oracle, "Oracle")
            .Add(enumTCPPort.VPN, "VPN")
            .Add(enumTCPPort.IMAP, "IMAP")
            .Add(enumTCPPort.IPSec, "IPSec")
            .Add(enumTCPPort.LDAP, "LDAP")
            .Add(enumTCPPort.PostgresSQL, "PostgresSQL")
            .Add(enumTCPPort.SFTP, "SFTP")
            .Add(enumTCPPort.WINS, "WINS")
            .Add(enumTCPPort.MSADSMB, "MS AD SMB")
        End With

        ScanServerPorts = dictPorts
        dictPorts = Nothing

    End Function


    Private Function ScanAllServices() As Dictionary(Of Integer, String)

        Dim dictPorts As New Dictionary(Of Integer, String)

        dictPorts = ScanServerPorts()

        With dictPorts
            .Add(enumTCPPort.HTTP, "HTTP")
            .Add(enumTCPPort.HTTPS, "HTTPS")
            .Add(enumTCPPort.POP3, "POP3")
            .Add(enumTCPPort.Daytime, "Daytime")
            .Add(enumTCPPort.IRC, "IRC")
            .Add(enumTCPPort.NetBIOSName, "NetBIOS Name")
        End With

        ScanAllServices = dictPorts
        dictPorts = Nothing

    End Function


    Private Function ScanAllPorts() As Dictionary(Of Integer, String)
        Dim dictPorts As New Dictionary(Of Integer, String)

        With dictPorts
            .Add(enumTCPPort.ARPA, "ARPA")
            .Add(enumTCPPort.Daytime, "Daytime")
            .Add(enumTCPPort.DHCPServer, "DHCP v4 Server")
            .Add(enumTCPPort.DHCPClient, "DHCP v4 Client")
            .Add(enumTCPPort.DCHPv6Server, "DHCP v6 Server")
            .Add(enumTCPPort.DHCPv6Client, "DHCP v6 Client")
            .Add(enumTCPPort.Discard, "Discard")
            .Add(enumTCPPort.DNS, "DNS Server")
            .Add(enumTCPPort.Echo, "Echo")
            .Add(enumTCPPort.Finger, "Finger")
            .Add(enumTCPPort.FTPControl, "FTP Control")
            .Add(enumTCPPort.FTPData, "FTP Data")
            .Add(enumTCPPort.FTPSControl, "FTPS Control")
            .Add(enumTCPPort.FTPSData, "FTPS Data")
            .Add(enumTCPPort.HTTP, "HTTP")
            .Add(enumTCPPort.HTTPS, "HTTPS")
            .Add(enumTCPPort.IMAP, "IMAP")
            .Add(enumTCPPort.IMAPS, "IMAPS")
            .Add(enumTCPPort.IMAPv3, "IMAPS v3")
            .Add(enumTCPPort.IPSec, "IPSec")
            .Add(enumTCPPort.IRC, "IRC Server")
            .Add(enumTCPPort.LDAP, "LDAP Server")
            .Add(enumTCPPort.MSADSMB, "MS AD SMB")
            .Add(enumTCPPort.MSP, "MSP")
            .Add(enumTCPPort.MSSQL, "MS SQL Server")
            .Add(enumTCPPort.MySQL, "MySQL Server")
            .Add(enumTCPPort.NAS, "Netnews Administration Sytstem")
            .Add(enumTCPPort.NetBIOSDatagram, "NetBIOS Datagram")
            .Add(enumTCPPort.NetBIOSName, "NetBIOS Name")
            .Add(enumTCPPort.NetBIOSSession, "NetBIOS Session")
            .Add(enumTCPPort.Netstat, "Netstat")
            .Add(enumTCPPort.Oracle, "Oracle")
            .Add(enumTCPPort.POP2, "POP2")
            .Add(enumTCPPort.POP3, "POP3")
            .Add(enumTCPPort.POP3S, "POP3S")
            .Add(enumTCPPort.PostgresSQL, "PostgresSQL")
            .Add(enumTCPPort.radacct, "radacct")
            .Add(enumTCPPort.radius, "Radius")
            .Add(enumTCPPort.RDP, "RDP Server")
            .Add(enumTCPPort.rh, "rh")
            .Add(enumTCPPort.SambaSWAT, "Samba SWAT Config")
            .Add(enumTCPPort.SFTP, "SFTP Server")
            .Add(enumTCPPort.SMTP, "Mail Server")
            .Add(enumTCPPort.SMTPoverSSL, "SMTP over SSL")
            .Add(enumTCPPort.SSH, "SSH")
            .Add(enumTCPPort.SQL, "SQL")
            .Add(enumTCPPort.Telnet, "Telnet Dienst")
            .Add(enumTCPPort.TelnetSSL, "Telnet over SSL")
            .Add(enumTCPPort.Time, "Time")
            .Add(enumTCPPort.TFTP, "TFTP Server")
            .Add(enumTCPPort.VMwareRemoteConsole, "VMware Remote Console")
            .Add(enumTCPPort.VMwareServerConsole, "VMware Server Console")
            .Add(enumTCPPort.VPN, "VPN Dienst")
            .Add(enumTCPPort.WHOIS, "WHOIS")
            .Add(enumTCPPort.WINS, "WINS Server")
        End With

        ScanAllPorts = dictPorts
        dictPorts = Nothing

    End Function

#End Region

#Region "Private Methoden"

    Private Sub Ausgabe(ByVal DGV As DataGridView, ByVal Host As String, _
                        ByVal Port As Integer, ByVal Zeit As Integer, ByVal Status As String)

        Application.DoEvents()

        If pAnsichtFall = enumPingAusgabe.IPScanner Then

            DGV.Rows.Add(Host, Zeit & " ms", Status)
            DGV.Refresh()
            DGV.AutoResizeColumns()

        ElseIf pAnsichtFall = enumPingAusgabe.Explorer Then

            DGV.Rows.Add(Host, Zeit & " ms", Status, Port)
            DGV.Refresh()
            DGV.AutoResizeColumns()

        ElseIf pAnsichtFall = enumPingAusgabe.PortScanner Then

            DGV.Rows.Add(Port, Status)
            DGV.Refresh()
            DGV.AutoResizeColumns()

        End If

        If Not IsNothing(DGV.CurrentCell) Then
            DGV.CurrentCell = DGV.Item(0, DGV.Rows.Count - 1)
        End If

        Application.DoEvents()

    End Sub


    Private Function PingPort(ByVal Host As String, ByVal Port As Integer) As Boolean

        Try

            Dim tryVerbindung As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient(Host, Port)
            PingPort = True
            tryVerbindung = Nothing

        Catch ex As Exception

            PingPort = False
        End Try

    End Function

#End Region

#Region "Public Methoden"

    Public Function isIP(ByVal Network As String) As Boolean

        Dim pNetPart As String() = Network.Split(".")
        Dim pResult As Boolean = False
        Dim pNumber As Integer = pNetPart(0)

        If pNumber > 0 And pNumber < 255 Then
            pNumber = pNetPart(1)

            If pNumber >= 0 And pNumber <= 255 Then
                pNumber = pNetPart(2)

                If pNumber >= 0 And pNumber <= 255 Then
                    pNumber = pNetPart(3)

                    If pNumber >= 0 And pNumber <= 255 Then
                        pResult = True
                    End If
                End If
            End If

        Else
            pResult = False

        End If

        isIP = pResult

    End Function


    Public Function isPrivateNetwork(ByVal Network As String) As Boolean

        Dim pNetPart As String() = Network.Split(".")
        Dim pResult As Boolean = False
        Dim pNumber As Integer = pNetPart(0)

        ' Netzwerk Class A 10.0.0.0/8
        If pNumber = 10 Then
            pNumber = pNetPart(1)

            If pNumber >= 0 And pNumber <= 255 Then
                pNumber = pNetPart(2)

                If pNumber >= 0 And pNumber <= 255 Then
                    pNumber = pNetPart(3)

                    If pNumber >= 0 And pNumber <= 255 Then
                        pResult = True
                    End If
                End If
            End If

            ' Netzwerk Class B 169.254.0.0/16
        ElseIf pNumber = 169 Then
            pNumber = pNetPart(1)

            If pNumber = 254 Then
                pNumber = pNetPart(2)

                If pNumber >= 0 And pNumber <= 255 Then
                    pNumber = pNetPart(3)

                    If pNumber >= 0 And pNumber <= 255 Then
                        pResult = True
                    End If
                End If
            End If

            ' Netzwerk Class B 172.16.0.0/12
        ElseIf pNumber = 172 Then
            pNumber = pNetPart(1)

            If pNumber >= 16 And pNumber <= 31 Then
                pNumber = pNetPart(2)

                If pNumber >= 0 And pNumber <= 255 Then
                    pNumber = pNetPart(3)

                    If pNumber >= 0 And pNumber <= 255 Then
                        pResult = True
                    End If
                End If
            End If

            ' Netzwerk Class C 192.168.0.0/16
        ElseIf pNumber = 192 Then
            pNumber = pNetPart(1)

            If pNumber = 168 Then
                pNumber = pNetPart(2)

                If pNumber >= 0 And pNumber <= 255 Then
                    pNumber = pNetPart(3)

                    If pNumber >= 0 And pNumber <= 255 Then
                        pResult = True
                    End If
                End If
            End If

        Else
            pResult = False

        End If

        isPrivateNetwork = pResult

    End Function


    ' LAN Explorer
    Public Sub ExploreNetwork(ByVal DGV As DataGridView, ByVal Status As ToolStripStatusLabel, _
                              ByVal ScanModus As Integer, ByVal StartNetwork As String, ByVal EndeNetwork As String, _
                              ByVal PortStart As Integer, ByVal PortEnde As Integer)

        ' Deklaration
        Dim pHost As String = String.Empty
        Dim dictPorts As New Dictionary(Of Integer, String)
        Dim pNetworkTeilStart As String() = StartNetwork.Split(".")

        ' Klassen Variablen
        pAnsichtFall = enumPingAusgabe.Explorer
        pPingStop = False


        If EndeNetwork = String.Empty Then
            If pNetworkTeilStart(3).ToString() = "0" Then
                EndeNetwork = pNetworkTeilStart(0) & "." & pNetworkTeilStart(1) & "." & pNetworkTeilStart(2) & ".254"
            Else
                EndeNetwork = StartNetwork
            End If
        End If

        Dim pNetworkTeilEnde As String() = EndeNetwork.Split(".")

        ' Ports initialisieren
        If ScanModus = enumScanModus.ScanServer Then
            dictPorts = ScanServerPorts()
        ElseIf ScanModus = enumScanModus.AllServices Then
            dictPorts = ScanAllServices()
        ElseIf ScanModus = enumScanModus.AllStandardsPorts Then
            dictPorts = ScanAllPorts()
        End If


        ' Netzwerk durchsuchen
        For Host2 As Integer = pNetworkTeilStart(1) To pNetworkTeilEnde(1)
            For Host3 As Integer = pNetworkTeilStart(2) To pNetworkTeilEnde(2)
                For Host4 As Integer = pNetworkTeilStart(3) To pNetworkTeilEnde(3)

                    Application.DoEvents()

                    If Host4 = 0 Then
                        Host4 += 1
                    End If

                    pHost = pNetworkTeilStart(0) & "." & Host2 & "." & Host3 & "." & Host4

                    PingHost(DGV, pHost, False, True)

                    If pPingErfolg = True Then
                        Status.Text = "Scan " & pHost & " erfolgreich !"
                    Else
                        Status.Text = "Scan " & pHost
                    End If


                    Application.DoEvents()

                    If pPingStop = True Then
                        Exit For
                    End If

                    If pPingErfolg = True Then

                        If ScanModus = enumScanModus.AllPort Then

                            For i As Integer = PortStart To PortEnde

                                Application.DoEvents()
                                Status.Text = pHost & ":" & i
                                Application.DoEvents()

                                If PingPort(pHost, i) = True Then
                                    Ausgabe(DGV, pHost, i, Nothing, "")
                                End If

                                Application.DoEvents()

                                If pPingStop = True Then
                                    i = PortEnde
                                End If
                            Next

                        Else

                            For Each Port As KeyValuePair(Of Integer, String) In dictPorts

                                Application.DoEvents()
                                Status.Text = pHost & ":" & Port.Key
                                Application.DoEvents()

                                If PingPort(pHost, Port.Key) = True Then

                                    Ausgabe(DGV, pHost, Port.Key, Nothing, Port.Value)

                                End If

                                Application.DoEvents()

                                If pPingStop = True Then
                                    Exit For
                                End If
                            Next

                        End If

                    End If

                Next
            Next
        Next

        dictPorts = Nothing

    End Sub


    ' IP Scanner 
    Public Sub PingNetwork(ByVal DGV As DataGridView, ByVal Status As ToolStripStatusLabel, _
                           ByVal Network As String, ByVal IPStart As Integer, ByVal IPEnde As Integer)

        pAnsichtFall = enumPingAusgabe.IPScanner

        Dim pNetworkTeil As String() = Network.Split(".")

        PingStop = False

        If IsNumeric(pNetworkTeil(0)) = True _
            And IsNumeric(pNetworkTeil(1)) = True _
            And IsNumeric(pNetworkTeil(2)) = True Then

            Dim pNet As String = pNetworkTeil(0) & "." & pNetworkTeil(1) & "." & pNetworkTeil(3) & "."

            For i As Integer = IPStart To IPEnde

                If pPingStop = True Then
                    i = 999
                End If

                PingHost(DGV, pNet & i, True, True)

                Status.Text = pNet & i & " von " & pNet & IPEnde

                Application.DoEvents()

            Next

            Status.Text = "Netzwerk Scan fertig"

        End If

    End Sub


    ' Einen Host anpingen
    Public Sub PingHost(ByVal DGV As DataGridView, ByVal Host As String, _
                        ByVal ShowAllResults As Boolean, ByVal FastScan As Boolean)

        Dim pResult As System.Net.NetworkInformation.PingReply
        pPingErfolg = False

        If FastScan = True Then
            pResult = Send(Host, 100)
        Else
            pResult = Send(Host)
        End If

        If pResult.Status = System.Net.NetworkInformation.IPStatus.Success _
            Or ShowAllResults = True Then

            pPingErfolg = True

            Ausgabe(DGV, Host, 7, pResult.RoundtripTime, pResult.Status)

        End If


        pResult = Nothing

    End Sub


    ' Host Port Scanner
    Public Sub PingPorts(ByVal DGV As DataGridView, ByVal Status As ToolStripStatusLabel, _
                         ByVal Host As String, ByVal PortStart As Integer, ByVal PortEnde As Integer)

        pPingStop = False
        pAnsichtFall = enumPingAusgabe.PortScanner

        For pPort As Integer = PortStart To PortEnde

            Try

                Dim tryVerbindung As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient(Host, pPort)

                Application.DoEvents()

                Status.Text = pPort & " von " & PortEnde

                Ausgabe(DGV, Nothing, pPort, Nothing, "Erfolgreich")

                Application.DoEvents()
                tryVerbindung = Nothing

            Catch ex As Exception

                Application.DoEvents()
                Status.Text = pPort & " von " & PortEnde
                Application.DoEvents()

            End Try



            Application.DoEvents()

            If pPingStop = True Then
                pPort = 9999999
            End If

        Next

        Status.Text = "Port Scan fertig"

    End Sub

#End Region

End Class
