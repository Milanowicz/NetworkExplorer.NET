Public Class frm_RouteTable

    Private Host As New cls_Host

#Region "Formular Events"

    Private Sub frm_RouteTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pRoutes() As String = Host.GetLocalRouteTable()
        For Each elem As String In pRoutes
            Me.ListBox.Items.Add(elem)
        Next
    End Sub


    Private Sub frm_RouteTable_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Host = Nothing
    End Sub

#End Region



End Class