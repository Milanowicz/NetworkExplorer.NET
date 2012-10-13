Public Class frm_LANExplorer

    Dim Ping As New cls_PingIPv4
    Dim DNS As New cls_DNS

    Private Event Status(ByVal Text As String)

#Region "Formular Events"

    Private Sub frm_LANExplorer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Ping = Nothing
        DNS = Nothing
    End Sub

    Private Sub frm_LANExplorer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txt_NetworkStart.Text = "192.168.0.0"

        With Me.cmb_SuchOptionen.Items
            .Clear()

            .Add("Alle Ports")
            .Add("Server Ports")
            .Add("Alle Services")
            .Add("Alle Standard Ports")
        End With

        Me.cmb_SuchOptionen.SelectedIndex = 0

        FormatDGVAnsicht()

    End Sub


    Private Sub cmb_SuchOptionen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_SuchOptionen.SelectedIndexChanged
        If Me.cmb_SuchOptionen.SelectedIndex <> 0 Then
            Me.txt_PortStart.Enabled = False
            Me.txt_PortEnde.Enabled = False
        Else
            Me.txt_PortStart.Enabled = True
            Me.txt_PortEnde.Enabled = True
        End If
    End Sub


    Private Sub StatusText(ByVal Text As String) Handles Me.Status
        Me.tsl_Status.Text = Text
    End Sub

#End Region

#Region "Formular Buttons"

    ' Button Ping
    Private Sub btn_PingIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PingIP.Click

        Dim pEingabe1 As String = Me.txt_NetworkStart.Text
        Dim pEingabe2 As String = Me.txt_NetworkEnde.Text
        Dim EingabeTeile As String() = pEingabe1.Split(".")
        Dim pCheckNetwork As Boolean = False
        Dim pCheckMsgBox As New MsgBoxResult

        If Me.cmb_SuchOptionen.SelectedIndex <> -1 Then

            Try
                If Ping.isIP(Me.txt_NetworkStart.Text) = True Then

                    If Me.txt_NetworkEnde.Text <> String.Empty Then
                        If Ping.isIP(Me.txt_NetworkEnde.Text) = True Then

                            ' Mehere Netzwerke durch Scannnen
                            Dim pStart As Integer = CType(Me.txt_NetworkStart.Text, Integer)
                            Dim pEnde As Integer = CType(Me.txt_NetworkEnde.Text, Integer)


                            If pStart < pEnde Then

                                ' Prüfen ob es ein Privates Netzwerk ist
                                If Ping.isPrivateNetwork(Me.txt_NetworkStart.Text) = True _
                                Or Ping.isPrivateNetwork(Me.txt_NetworkEnde.Text) = True Then
                                    pCheckNetwork = True
                                Else
                                    pCheckMsgBox = MsgBox("! Achtung !" & vbCrLf & "Sie Scannen kein Privates Netzwerk !!" _
                                                          & vbCrLf & "Wollen Sie trotz dessen fortfahren ???" _
                                                          , MsgBoxStyle.OkCancel, "Kein Privates Netzwerk")
                                    If pCheckMsgBox = MsgBoxResult.Ok Then
                                        pCheckNetwork = True
                                    End If
                                End If


                                If pCheckNetwork = True Then

                                    Ping.ExploreNetwork(Me.dgv_Ansicht, Me.tsl_Status, Me.cmb_SuchOptionen.SelectedValue, _
                                                    pEingabe1, pEingabe2, Me.txt_PortStart.Text, Me.txt_PortEnde.Text)

                                    RaiseEvent Status("Netzwerk Scan ist fertig")

                                Else
                                    RaiseEvent Status("Netzwerk Scan wurde abgebrochen !!!")
                                End If

                            Else
                                RaiseEvent Status("Sie haben die Zahlen vertauscht !!!")

                            End If

                        Else
                            RaiseEvent Status("Keine gültige IP Adresse beim Ende Host / Netzwerk eingetragen !!!")

                        End If


                    ElseIf EingabeTeile(3).ToString() = "0" Then
                        ' Ein Netzwerk durch Scannen

                        ' Prüfen ob es ein Privates Netzwerk ist
                        If Ping.isPrivateNetwork(Me.txt_NetworkStart.Text) = True Then
                            pCheckNetwork = True
                        Else
                            pCheckMsgBox = MsgBox("! Achtung !" & vbCrLf & "Sie Scannen kein Privates Netzwerk !!" _
                                                  & vbCrLf & "Wollen Sie trotz dessen fortfahren ???" _
                                                  , MsgBoxStyle.OkCancel, "Kein Privates Netzwerk")
                            If pCheckMsgBox = MsgBoxResult.Ok Then
                                pCheckNetwork = True
                            End If
                        End If

                        If pCheckNetwork = True Then
                            ' Ein Netzwerk durch Scannen
                            Ping.ExploreNetwork(Me.dgv_Ansicht, Me.tsl_Status, Me.cmb_SuchOptionen.SelectedIndex, _
                                                pEingabe1, String.Empty, Me.txt_PortStart.Text, Me.txt_PortEnde.Text)

                            RaiseEvent Status("Netzwerk Scan ist fertig")

                        Else
                            RaiseEvent Status("Netzwerk Scan wurde abgebrochen !!!")
                        End If
                        

                    Else
                        ' Einen Host Scannen

                        ' Prüfen ob es ein Privates Netzwerk ist
                        If Ping.isPrivateNetwork(Me.txt_NetworkStart.Text) = True Then
                            pCheckNetwork = True
                        Else
                            pCheckMsgBox = MsgBox("! Achtung !" & vbCrLf & "Sie Scannen kein Privates Netzwerk !!" _
                                                  & vbCrLf & "Wollen Sie trotz dessen fortfahren ???" _
                                                  , MsgBoxStyle.OkCancel, "Kein Privates Netzwerk")
                            If pCheckMsgBox = MsgBoxResult.Ok Then
                                pCheckNetwork = True
                            End If
                        End If

                        If pCheckNetwork = True Then
                            Ping.ExploreNetwork(Me.dgv_Ansicht, Me.tsl_Status, Me.cmb_SuchOptionen.SelectedIndex, _
                                                pEingabe1, String.Empty, Me.txt_PortStart.Text, Me.txt_PortEnde.Text)

                            RaiseEvent Status("Scan fertig")

                        Else
                            RaiseEvent Status("Netzwerk Scan wurde abgebrochen !!!")
                        End If
                        
                    End If

                Else
                    RaiseEvent Status("Keine gültige IP Adresse beim Start Host / Netzwerk eingetragen !!!")

                End If


            Catch ex As Exception
                RaiseEvent Status("Fehler: " & ex.Message)

            End Try


        Else
            RaiseEvent Status("Bitte wählen die Combobox aus !!!!")

        End If
    End Sub

    Private Sub btn_PingStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PingStop.Click
        Ping.PingStop = True
    End Sub


    Private Sub btn_DGVLeeren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DGVLeeren.Click
        Me.dgv_Ansicht.Rows.Clear()
        Me.dgv_Ansicht.Refresh()
    End Sub


    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

#End Region

#Region "Private Methoden"

    Private Sub FormatDGVAnsicht()

        With Me.dgv_Ansicht.Columns
            .Add("colHost", "Host")
            .Add("colZeit", "Zeit")
            .Add("colStatus", "Name")
            .Add("colPort", "Port")
        End With

        With Me.dgv_Ansicht
            .AutoResizeColumns()
            .AutoResizeRows()
        End With

    End Sub

#End Region
    
    
End Class