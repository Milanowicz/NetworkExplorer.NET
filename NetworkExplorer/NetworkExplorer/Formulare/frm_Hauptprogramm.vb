Public Class NetzwerkExplorer

#Region "Formular Events"

    Dim Host As New cls_Host


    Private Sub frm_Hauptprogramm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim IPs As String() = Host.GetLocalIPs()


        Me.list_Host.Items.Add("")
        Me.list_Host.Items.Add("PC Internet Adressen")
        Me.list_Host.Items.Add("")

        For Each IP As String In IPs
            Me.list_Host.Items.Add(IP)
        Next

        Me.list_Host.Items.Add("")
        Me.list_Host.Items.Add("Netzwerk Schnitstellen")
        Me.list_Host.Items.Add("")

        Host.GetLocalInterfaces(Me.list_Host)

    End Sub

    Private Sub frm_Hauptprogramm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Host = Nothing
    End Sub

#End Region

#Region "Programm Menü"

#Region "Programm"

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

#End Region

#Region "Netzwerk"

    Private Sub LANExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LANExplorerToolStripMenuItem.Click
        Dim Explorer As New frm_LANExplorer
        Explorer.Show()
        Explorer = Nothing
    End Sub

    Private Sub ScannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScannerToolStripMenuItem.Click
        Dim Scanner As New frm_IPScanner
        Scanner.Show()
        Scanner = Nothing
    End Sub

    Private Sub IPAuflösenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPAuflösenToolStripMenuItem.Click
        Dim DNS As New frm_IPAufloesen
        DNS.Show()
        DNS = Nothing
    End Sub

    Private Sub PortScannerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortScannerToolStripMenuItem.Click
        Dim Scanner As New frm_PortScanner
        Scanner.Show()
        Scanner = Nothing
    End Sub

    Private Sub SnifferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SnifferToolStripMenuItem.Click
        Dim Sniffer As New frm_SnifferOverview
        Sniffer.Show()
        Sniffer = Nothing
    End Sub

    ' Trace Route
    Private Sub TraceRouteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraceRouteToolStripMenuItem.Click
        Dim TR As New frm_TraceRoute
        TR.Show()
        TR = Nothing
    End Sub
#End Region

#Region "Computer"

    ' netstat
    Private Sub NetStatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetStatToolStripMenuItem.Click
        Dim netstat As New frm_NetStat
        netstat.Show()
        netstat = Nothing
    End Sub

    ' Route Tabelle
    Private Sub RouteTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RouteTableToolStripMenuItem.Click
        Dim RouteTable As New frm_RouteTable
        RouteTable.Show()
        RouteTable = Nothing
    End Sub

#End Region

#End Region

End Class