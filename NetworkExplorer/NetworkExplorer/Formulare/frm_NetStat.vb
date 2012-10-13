Public Class frm_NetStat

    Private Host As New cls_Host
    Private Event Status(ByVal Text As String)


#Region "Formular Events"

    ' Formular Laden
    Private Sub frm_NetStat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        showStats()

    End Sub

    ' Formular Schliessen
    Private Sub frm_NetStat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Host = Nothing
    End Sub

    ' Status Ausgabe
    Private Sub StatusAusgabe(ByVal Text As String) Handles Me.Status
        Me.tsl_Staus.Text = Text
    End Sub

#End Region

#Region "Formular Buttons"

    ' Fresh Button
    Private Sub btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh.Click
        showStats()
    End Sub

    ' Schliessen
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

#End Region

#Region "Private Methoden"

    Private Sub showStats()

        With Me.dgv_Ansicht
            .DataSource = Host.GetLocalOpenPorts()

            .AutoResizeColumns()

            Me.lbl_Datenanzahl.Text = "Anzahl: " & .Rows.Count

        End With

        Me.Width = Me.dgv_Ansicht.Width + 100

        RaiseEvent Status("Daten geladen")

    End Sub

#End Region

   
End Class