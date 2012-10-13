Public Class frm_TraceRoute

    Private TR As New cls_TraceRoute

#Region "Formular Events"

    ' Formular Lord
    Private Sub frm_TraceRoute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.lbl_Datenanzahl.Text = String.Empty
        Me.txt_Host.Text = "web.de"

        With Me.dgv_Ansicht
            .Columns.Add("colHost", "Host")
            .Columns.Add("colDNS", "DNS")
            .Columns.Add("colTime", "Zeit")
            .Columns.Add("colStatus", "Status")
        End With


    End Sub

    ' Formular schliessen
    Private Sub frm_TraceRoute_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TR = Nothing
    End Sub

#End Region

#Region "Formular Buttons"

    ' Trace Route
    Private Sub btn_TraceRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TraceRoute.Click

        Me.dgv_Ansicht.Rows.Clear()
        Application.DoEvents()

        TR.TraceRT(Me.txt_Host.Text)

        Application.DoEvents()

        For Each elem As cls_TraceRoute.TraceRTArgs In TR.RouteList()
            Me.dgv_Ansicht.Rows.Add(elem.IPAddress, elem.DNSName, elem.RoundTripTime, elem.Status)
        Next

        Me.lbl_Datenanzahl.Text = "Anzahl: " & Me.dgv_Ansicht.Rows.Count

        Me.dgv_Ansicht.AutoResizeColumns()

    End Sub

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

#End Region
    
End Class