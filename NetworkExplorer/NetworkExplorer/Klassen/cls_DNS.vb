Imports System.Net

Public Class cls_DNS

    Public Function IP2DNS(ByVal IPAdresse As String) As String
        Dim hostEintrag As IPHostEntry = Dns.GetHostEntry(IPAdresse)
        Return hostEintrag.HostName
    End Function

    Public Function DNS2IP(ByVal Hostname As String) As String
        Dim hostEintrag As IPHostEntry = Dns.GetHostEntry(Hostname)
        Return hostEintrag.AddressList(0).ToString()
    End Function

End Class
