Public Class frm_PortScanner

    Dim Ping As New cls_PingIPv4

    Private Event Status(ByVal Text As String)

#Region "Formular Events"

    Private Sub frm_PortScanner_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Ping = Nothing
    End Sub

    Private Sub frm_PortScanner_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me.dgv_Ansicht.Columns
            .Add("colHost", "Port")
            .Add("colStatus", "Status")
        End With

        With Me.dgv_Ansicht
            .AutoResizeColumns()
            .AutoResizeRows()
        End With
        Me.txt_Eingabe.Text = "192.168.0.1"
    End Sub


    Private Sub StatusText(ByVal Text As String) Handles Me.Status
        Me.tsl_Status.Text = Text
    End Sub

#End Region

#Region "Formular Buttons"

    Private Sub btn_Ping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ping.Click

        Me.dgv_Ansicht.Rows.Clear()

        If IsNumeric(Me.txt_PortStart.Text) And IsNumeric(Me.txt_PortEnde.Text) Then

            Dim pStart As Integer = CType(Me.txt_PortStart.Text, Integer)
            Dim pEnde As Integer = CType(Me.txt_PortEnde.Text, Integer)

            If pStart >= IPv4PortStart And pStart <= IPv4PortEnd And _
                pEnde >= IPv4PortStart And pEnde <= IPv4PortEnd Then

                If pStart <= pEnde Then
                    Ping.PingPorts(Me.dgv_Ansicht, Me.tsl_Status, Me.txt_Eingabe.Text, pStart, pEnde)
                Else
                    RaiseEvent Status("Sie haben die Zahlen Start Port mit End Port vertauscht !?!?!")
                End If

            Else
                RaiseEvent Status("Portnummern falsch !!!")

            End If

            

        Else
            Me.tsl_Status.Text = "Sie keine gültigen Port Nummer angegeben !!!"
        End If

    End Sub


    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        Ping.PingStop = True
    End Sub


    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Ping.PingStop = True
        Me.Close()
    End Sub

#End Region

End Class