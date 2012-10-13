<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_IPAufloesen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_IPAufloesen))
        Me.btn_Suchen = New System.Windows.Forms.Button()
        Me.txt_Eingabe = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Ergebnis = New System.Windows.Forms.TextBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Suchen
        '
        Me.btn_Suchen.Location = New System.Drawing.Point(226, 22)
        Me.btn_Suchen.Name = "btn_Suchen"
        Me.btn_Suchen.Size = New System.Drawing.Size(75, 23)
        Me.btn_Suchen.TabIndex = 0
        Me.btn_Suchen.Text = "&Auflösen"
        Me.btn_Suchen.UseVisualStyleBackColor = True
        '
        'txt_Eingabe
        '
        Me.txt_Eingabe.Location = New System.Drawing.Point(12, 25)
        Me.txt_Eingabe.Name = "txt_Eingabe"
        Me.txt_Eingabe.Size = New System.Drawing.Size(208, 20)
        Me.txt_Eingabe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP / DNS"
        '
        'txt_Ergebnis
        '
        Me.txt_Ergebnis.Location = New System.Drawing.Point(12, 85)
        Me.txt_Ergebnis.Name = "txt_Ergebnis"
        Me.txt_Ergebnis.Size = New System.Drawing.Size(289, 20)
        Me.txt_Ergebnis.TabIndex = 3
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(224, 121)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 40)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "&Schliessen"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ergebnis"
        '
        'frm_IPAufloesen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 173)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.txt_Ergebnis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Eingabe)
        Me.Controls.Add(Me.btn_Suchen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_IPAufloesen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IP / DNS Auflösen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Suchen As System.Windows.Forms.Button
    Friend WithEvents txt_Eingabe As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Ergebnis As System.Windows.Forms.TextBox
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
