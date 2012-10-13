<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PortScanner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PortScanner))
        Me.btn_Ping = New System.Windows.Forms.Button()
        Me.txt_Eingabe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Stop = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.dgv_Ansicht = New System.Windows.Forms.DataGridView()
        Me.txt_PortStart = New System.Windows.Forms.TextBox()
        Me.txt_PortEnde = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Ping
        '
        Me.btn_Ping.Location = New System.Drawing.Point(167, 9)
        Me.btn_Ping.Name = "btn_Ping"
        Me.btn_Ping.Size = New System.Drawing.Size(75, 40)
        Me.btn_Ping.TabIndex = 0
        Me.btn_Ping.Text = "&Scan"
        Me.btn_Ping.UseVisualStyleBackColor = True
        '
        'txt_Eingabe
        '
        Me.txt_Eingabe.Location = New System.Drawing.Point(12, 29)
        Me.txt_Eingabe.Name = "txt_Eingabe"
        Me.txt_Eingabe.Size = New System.Drawing.Size(149, 20)
        Me.txt_Eingabe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Host / IP"
        '
        'btn_Stop
        '
        Me.btn_Stop.Location = New System.Drawing.Point(248, 9)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(75, 40)
        Me.btn_Stop.TabIndex = 3
        Me.btn_Stop.Text = "Stop"
        Me.btn_Stop.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(248, 536)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 45)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "&Schliessen"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'dgv_Ansicht
        '
        Me.dgv_Ansicht.AllowUserToAddRows = False
        Me.dgv_Ansicht.AllowUserToDeleteRows = False
        Me.dgv_Ansicht.AllowUserToResizeRows = False
        Me.dgv_Ansicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ansicht.Location = New System.Drawing.Point(12, 58)
        Me.dgv_Ansicht.MultiSelect = False
        Me.dgv_Ansicht.Name = "dgv_Ansicht"
        Me.dgv_Ansicht.Size = New System.Drawing.Size(311, 472)
        Me.dgv_Ansicht.TabIndex = 5
        '
        'txt_PortStart
        '
        Me.txt_PortStart.Location = New System.Drawing.Point(69, 3)
        Me.txt_PortStart.Name = "txt_PortStart"
        Me.txt_PortStart.Size = New System.Drawing.Size(43, 20)
        Me.txt_PortStart.TabIndex = 6
        Me.txt_PortStart.Text = "1"
        '
        'txt_PortEnde
        '
        Me.txt_PortEnde.Location = New System.Drawing.Point(118, 3)
        Me.txt_PortEnde.Name = "txt_PortEnde"
        Me.txt_PortEnde.Size = New System.Drawing.Size(43, 20)
        Me.txt_PortEnde.TabIndex = 7
        Me.txt_PortEnde.Text = "65535"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 584)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(333, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_Status
        '
        Me.tsl_Status.Name = "tsl_Status"
        Me.tsl_Status.Size = New System.Drawing.Size(0, 17)
        '
        'frm_PortScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 606)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txt_PortEnde)
        Me.Controls.Add(Me.txt_PortStart)
        Me.Controls.Add(Me.dgv_Ansicht)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Stop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Eingabe)
        Me.Controls.Add(Me.btn_Ping)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_PortScanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Port Scanner"
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Ping As System.Windows.Forms.Button
    Friend WithEvents txt_Eingabe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Stop As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents dgv_Ansicht As System.Windows.Forms.DataGridView
    Friend WithEvents txt_PortStart As System.Windows.Forms.TextBox
    Friend WithEvents txt_PortEnde As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsl_Status As System.Windows.Forms.ToolStripStatusLabel
End Class
