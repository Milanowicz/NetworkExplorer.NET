Imports System.Net
Imports System.Net.Sockets


Public Class cls_SniffenIPv4

    Private m_Socket As Socket         ' Ein Socket zum Sniffen.
    Private m_PacketBuffer As Buffer
    Private m_IPv4Adr

    Public Sub StartSniff()

        Try

            ' Einen neuen Socket zum Abhören erstellen.
            m_Socket = New Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP)
            ' Den Socket an die lokale IPv4-Adresse binden.
            m_Socket.Bind(New IPEndPoint(IPAddress.Parse(m_IPv4Adr), 0))
            ' Die Optionen des Sockets festlegen.
            m_Socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.HeaderIncluded, True)
            ' Betriebsmodi für den Socket festlegen.
            m_Socket.IOControl(IOControlCode.ReceiveAll, BitConverter.GetBytes(3), Nothing)

            ' Ein Packet asynchron lesen.
            ' m_Socket.BeginReceive(m_PacketBuffer, 0, m_PacketBuffer.Length, SocketFlags.None, New AsyncCallback(AddressOf OnReceive), Nothing)

        Catch ex As Exception
            StopSniff()
        End Try

    End Sub


    Public Sub StopSniff()

    End Sub

End Class
