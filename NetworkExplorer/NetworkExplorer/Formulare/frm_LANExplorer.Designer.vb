<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LANExplorer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LANExplorer))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgv_Ansicht = New System.Windows.Forms.DataGridView()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_PingStop = New System.Windows.Forms.Button()
        Me.btn_DGVLeeren = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NetworkStart = New System.Windows.Forms.TextBox()
        Me.btn_PingIP = New System.Windows.Forms.Button()
        Me.txt_PortEnde = New System.Windows.Forms.TextBox()
        Me.txt_PortStart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_NetworkEnde = New System.Windows.Forms.TextBox()
        Me.cmb_SuchOptionen = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(606, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_Status
        '
        Me.tsl_Status.Name = "tsl_Status"
        Me.tsl_Status.Size = New System.Drawing.Size(0, 17)
        '
        'dgv_Ansicht
        '
        Me.dgv_Ansicht.AllowUserToAddRows = False
        Me.dgv_Ansicht.AllowUserToDeleteRows = False
        Me.dgv_Ansicht.AllowUserToResizeRows = False
        Me.dgv_Ansicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Ansicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ansicht.Location = New System.Drawing.Point(12, 12)
        Me.dgv_Ansicht.Name = "dgv_Ansicht"
        Me.dgv_Ansicht.RowHeadersVisible = False
        Me.dgv_Ansicht.Size = New System.Drawing.Size(582, 456)
        Me.dgv_Ansicht.TabIndex = 1
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.Location = New System.Drawing.Point(519, 531)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 36)
        Me.btn_Exit.TabIndex = 2
        Me.btn_Exit.Text = "&Schliessen"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_PingStop
        '
        Me.btn_PingStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_PingStop.Location = New System.Drawing.Point(325, 531)
        Me.btn_PingStop.Name = "btn_PingStop"
        Me.btn_PingStop.Size = New System.Drawing.Size(61, 36)
        Me.btn_PingStop.TabIndex = 14
        Me.btn_PingStop.Text = "&Stop"
        Me.btn_PingStop.UseVisualStyleBackColor = True
        '
        'btn_DGVLeeren
        '
        Me.btn_DGVLeeren.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DGVLeeren.Location = New System.Drawing.Point(392, 531)
        Me.btn_DGVLeeren.Name = "btn_DGVLeeren"
        Me.btn_DGVLeeren.Size = New System.Drawing.Size(104, 36)
        Me.btn_DGVLeeren.TabIndex = 13
        Me.btn_DGVLeeren.Text = "Ergebnis &leeren"
        Me.btn_DGVLeeren.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Start: Host / Netzwerk"
        '
        'txt_NetworkStart
        '
        Me.txt_NetworkStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_NetworkStart.Location = New System.Drawing.Point(12, 497)
        Me.txt_NetworkStart.Name = "txt_NetworkStart"
        Me.txt_NetworkStart.Size = New System.Drawing.Size(166, 20)
        Me.txt_NetworkStart.TabIndex = 11
        '
        'btn_PingIP
        '
        Me.btn_PingIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_PingIP.Location = New System.Drawing.Point(325, 481)
        Me.btn_PingIP.Name = "btn_PingIP"
        Me.btn_PingIP.Size = New System.Drawing.Size(61, 36)
        Me.btn_PingIP.TabIndex = 10
        Me.btn_PingIP.Text = "&Ping"
        Me.btn_PingIP.UseVisualStyleBackColor = True
        '
        'txt_PortEnde
        '
        Me.txt_PortEnde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_PortEnde.Location = New System.Drawing.Point(267, 497)
        Me.txt_PortEnde.Name = "txt_PortEnde"
        Me.txt_PortEnde.Size = New System.Drawing.Size(43, 20)
        Me.txt_PortEnde.TabIndex = 19
        Me.txt_PortEnde.Text = "65535"
        '
        'txt_PortStart
        '
        Me.txt_PortStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_PortStart.Location = New System.Drawing.Point(208, 497)
        Me.txt_PortStart.Name = "txt_PortStart"
        Me.txt_PortStart.Size = New System.Drawing.Size(43, 20)
        Me.txt_PortStart.TabIndex = 18
        Me.txt_PortStart.Text = "1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 523)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Ende: Host / Netzwerk"
        '
        'txt_NetworkEnde
        '
        Me.txt_NetworkEnde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_NetworkEnde.Location = New System.Drawing.Point(12, 540)
        Me.txt_NetworkEnde.Name = "txt_NetworkEnde"
        Me.txt_NetworkEnde.Size = New System.Drawing.Size(166, 20)
        Me.txt_NetworkEnde.TabIndex = 20
        '
        'cmb_SuchOptionen
        '
        Me.cmb_SuchOptionen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_SuchOptionen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SuchOptionen.FormattingEnabled = True
        Me.cmb_SuchOptionen.Location = New System.Drawing.Point(189, 540)
        Me.cmb_SuchOptionen.Name = "cmb_SuchOptionen"
        Me.cmb_SuchOptionen.Size = New System.Drawing.Size(121, 21)
        Me.cmb_SuchOptionen.TabIndex = 22
        '
        'frm_LANExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 597)
        Me.Controls.Add(Me.cmb_SuchOptionen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_NetworkEnde)
        Me.Controls.Add(Me.txt_PortEnde)
        Me.Controls.Add(Me.txt_PortStart)
        Me.Controls.Add(Me.btn_PingStop)
        Me.Controls.Add(Me.btn_DGVLeeren)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_NetworkStart)
        Me.Controls.Add(Me.btn_PingIP)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.dgv_Ansicht)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_LANExplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAN Explorer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsl_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgv_Ansicht As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_PingStop As System.Windows.Forms.Button
    Friend WithEvents btn_DGVLeeren As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_NetworkStart As System.Windows.Forms.TextBox
    Friend WithEvents btn_PingIP As System.Windows.Forms.Button
    Friend WithEvents txt_PortEnde As System.Windows.Forms.TextBox
    Friend WithEvents txt_PortStart As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_NetworkEnde As System.Windows.Forms.TextBox
    Friend WithEvents cmb_SuchOptionen As System.Windows.Forms.ComboBox
End Class
