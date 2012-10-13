Public Class frm_SnifferOverview

    Private Sniffer As New cls_SniffenIPv4

#Region "Formular Events"


    Private Sub frm_SnifferOverview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub frm_SnifferOverview_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Sniffer = Nothing
    End Sub


#End Region





End Class