<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NetStat
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_NetStat))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_Staus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgv_Ansicht = New System.Windows.Forms.DataGridView()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.lbl_Datenanzahl = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Staus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 571)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(616, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_Staus
        '
        Me.tsl_Staus.Name = "tsl_Staus"
        Me.tsl_Staus.Size = New System.Drawing.Size(0, 17)
        '
        'dgv_Ansicht
        '
        Me.dgv_Ansicht.AllowUserToAddRows = False
        Me.dgv_Ansicht.AllowUserToDeleteRows = False
        Me.dgv_Ansicht.AllowUserToResizeColumns = False
        Me.dgv_Ansicht.AllowUserToResizeRows = False
        Me.dgv_Ansicht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Ansicht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Ansicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Ansicht.Location = New System.Drawing.Point(12, 12)
        Me.dgv_Ansicht.Name = "dgv_Ansicht"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Ansicht.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Ansicht.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Ansicht.Size = New System.Drawing.Size(592, 514)
        Me.dgv_Ansicht.TabIndex = 2
        '
        'btn_Exit
        '
        Me.btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exit.Location = New System.Drawing.Point(529, 532)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 36)
        Me.btn_Exit.TabIndex = 3
        Me.btn_Exit.Text = "&Schliessen"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Refresh.Location = New System.Drawing.Point(426, 532)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(97, 36)
        Me.btn_Refresh.TabIndex = 4
        Me.btn_Refresh.Text = "&Aktualisieren"
        Me.btn_Refresh.UseVisualStyleBackColor = True
        '
        'lbl_Datenanzahl
        '
        Me.lbl_Datenanzahl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Datenanzahl.AutoSize = True
        Me.lbl_Datenanzahl.Location = New System.Drawing.Point(9, 544)
        Me.lbl_Datenanzahl.Name = "lbl_Datenanzahl"
        Me.lbl_Datenanzahl.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Datenanzahl.TabIndex = 5
        Me.lbl_Datenanzahl.Text = "Label1"
        '
        'frm_NetStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 593)
        Me.Controls.Add(Me.lbl_Datenanzahl)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.dgv_Ansicht)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_NetStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetStat"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv_Ansicht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsl_Staus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgv_Ansicht As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents lbl_Datenanzahl As System.Windows.Forms.Label
End Class
