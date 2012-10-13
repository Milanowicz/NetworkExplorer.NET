Public Class frm_IPScanner

    Dim Ping As New cls_PingIPv4

    Private Event Status(ByVal Text As String)

#Region "Formular Events"

    ' Formular Load
    Private Sub frm_Ping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FormatDGVAnsicht()
        Me.txt_Host.Text = "192.168.0.0"
    End Sub

    ' Formular Close
    Private Sub frm_Ping_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) _
                Handles Me.FormClosed
        Ping = Nothing
    End Sub


    Private Sub StatusText(ByVal Text As String) Handles Me.Status
        Me.tsl_Status.Text = Text
    End Sub

#End Region

#Region "Private Methoden"

    Private Sub FormatDGVAnsicht()

        With Me.dgv_Ansicht.Columns
            .Add("colHost", "Host")
            .Add("colZeit", "Zeit")
            .Add("colStatus", "Status")
        End With

        With Me.dgv_Ansicht
            .AutoResizeColumns()
            .AutoResizeRows()
        End With

    End Sub

#End Region

#Region "Formular Buttons"

    ' Ping Button
    Private Sub btn_PingIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PingIP.Click

        Dim pEingabe As String = Me.txt_Host.Text

        If IsNumeric(pEingabe) Then

            Dim EingabeTeile As String() = pEingabe.Split(".")

            Try
                If EingabeTeile(3).ToString() = String.Empty Then
                    RaiseEvent Status("Keine gültige IP Adresse eingeben !!!")

                ElseIf EingabeTeile(3).ToString() = "0" Then

                    If IsNumeric(Me.txt_IPStart.Text) And IsNumeric(Me.txt_IPEnde.Text) Then

                        Dim pStart As Integer = CType(Me.txt_IPStart.Text, Integer)
                        Dim pEnde As Integer = CType(Me.txt_IPEnde.Text, Integer)

                        If pStart >= IPv4HostIPStart And pStart <= IPv4HostIPEnd _
                            And pEnde >= IPv4HostIPStart And pEnde <= IPv4HostIPEnd Then

                            If pStart < pEnde Then

                                Ping.PingNetwork(Me.dgv_Ansicht, Me.tsl_Status, _
                                         pEingabe, pStart, pEnde)

                            Else
                                RaiseEvent Status("Sie haben die Zahlen vertauscht !!!")

                            End If

                        Else
                            RaiseEvent Status("Sie haben gültigen Host angegeben !!!")

                        End If



                    Else
                        RaiseEvent Status("Keine Zahl bei dem Host Scan eingetragen !!!")

                    End If


                Else
                    Ping.PingHost(Me.dgv_Ansicht, pEingabe, False, False)
                End If

            Catch ex As Exception
                RaiseEvent Status("Keine gültige IP Adresse eingeben !!!")

            End Try

        Else
            Ping.PingHost(Me.dgv_Ansicht, pEingabe, False, False)

        End If

    End Sub


    ' Ping Stop
    Private Sub btn_PingStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PingStop.Click
        Ping.PingStop = True
    End Sub


    ' DGV Leeren
    Private Sub btn_DGVLeeren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DGVLeeren.Click
        Me.dgv_Ansicht.Rows.Clear()
    End Sub


    ' Formular schliessen
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Ping.PingStop = True
        Me.Close()
    End Sub

#End Region

End Class
