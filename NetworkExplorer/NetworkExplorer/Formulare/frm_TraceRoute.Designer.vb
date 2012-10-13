<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TraceRoute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TraceRoute))
        Me.btn_TraceRoute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Host = New System.Windows.Forms.TextBox()
        Me.dgv_Ansicht = New System.Windows.Forms.DataGridView()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_Datenanzahl = New System.Windows.Forms.Label()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_TraceRoute
        '
        Me.btn_TraceRoute.Location = New System.Drawing.Point(416, 13)
        Me.btn_TraceRoute.Name = "btn_TraceRoute"
        Me.btn_TraceRoute.Size = New System.Drawing.Size(98, 36)
        Me.btn_TraceRoute.TabIndex = 1
        Me.btn_TraceRoute.Text = "Adresse &Tracen"
        Me.btn_TraceRoute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Host / Name Adress:"
        '
        'txt_Host
        '
        Me.txt_Host.Location = New System.Drawing.Point(125, 22)
        Me.txt_Host.Name = "txt_Host"
        Me.txt_Host.Size = New System.Drawing.Size(283, 20)
        Me.txt_Host.TabIndex = 3
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
        Me.dgv_Ansicht.Location = New System.Drawing.Point(15, 55)
        Me.dgv_Ansicht.MultiSelect = False
        Me.dgv_Ansicht.Name = "dgv_Ansicht"
        Me.dgv_Ansicht.ReadOnly = True
        Me.dgv_Ansicht.Size = New System.Drawing.Size(499, 361)
        Me.dgv_Ansicht.TabIndex = 4
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.Location = New System.Drawing.Point(439, 422)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 36)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "&Schliessen"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'lbl_Datenanzahl
        '
        Me.lbl_Datenanzahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Datenanzahl.AutoSize = True
        Me.lbl_Datenanzahl.Location = New System.Drawing.Point(12, 434)
        Me.lbl_Datenanzahl.Name = "lbl_Datenanzahl"
        Me.lbl_Datenanzahl.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Datenanzahl.TabIndex = 6
        Me.lbl_Datenanzahl.Text = "Label2"
        '
        'frm_TraceRoute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 470)
        Me.Controls.Add(Me.lbl_Datenanzahl)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.dgv_Ansicht)
        Me.Controls.Add(Me.txt_Host)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_TraceRoute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_TraceRoute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trace Route"
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_TraceRoute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Host As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Ansicht As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents lbl_Datenanzahl As System.Windows.Forms.Label
End Class
