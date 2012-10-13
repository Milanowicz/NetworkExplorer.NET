<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetzwerkExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NetzwerkExplorer))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgrammToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetzwerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LANExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPAuflösenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnifferToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraceRouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetStatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RouteTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.list_Host = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammToolStripMenuItem, Me.NetzwerkToolStripMenuItem, Me.ComputerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgrammToolStripMenuItem
        '
        Me.ProgrammToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.ProgrammToolStripMenuItem.Name = "ProgrammToolStripMenuItem"
        Me.ProgrammToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ProgrammToolStripMenuItem.Text = "Programm"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'NetzwerkToolStripMenuItem
        '
        Me.NetzwerkToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LANExplorerToolStripMenuItem, Me.ScannerToolStripMenuItem, Me.IPAuflösenToolStripMenuItem, Me.PortScannerToolStripMenuItem, Me.SnifferToolStripMenuItem, Me.TraceRouteToolStripMenuItem})
        Me.NetzwerkToolStripMenuItem.Name = "NetzwerkToolStripMenuItem"
        Me.NetzwerkToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.NetzwerkToolStripMenuItem.Text = "Netzwerk"
        '
        'LANExplorerToolStripMenuItem
        '
        Me.LANExplorerToolStripMenuItem.Name = "LANExplorerToolStripMenuItem"
        Me.LANExplorerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LANExplorerToolStripMenuItem.Text = "LAN Explorer"
        '
        'ScannerToolStripMenuItem
        '
        Me.ScannerToolStripMenuItem.Name = "ScannerToolStripMenuItem"
        Me.ScannerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScannerToolStripMenuItem.Text = "IP Scanner"
        '
        'IPAuflösenToolStripMenuItem
        '
        Me.IPAuflösenToolStripMenuItem.Name = "IPAuflösenToolStripMenuItem"
        Me.IPAuflösenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IPAuflösenToolStripMenuItem.Text = "IP Auflösen"
        '
        'PortScannerToolStripMenuItem
        '
        Me.PortScannerToolStripMenuItem.Name = "PortScannerToolStripMenuItem"
        Me.PortScannerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PortScannerToolStripMenuItem.Text = "Port Scanner"
        '
        'SnifferToolStripMenuItem
        '
        Me.SnifferToolStripMenuItem.Name = "SnifferToolStripMenuItem"
        Me.SnifferToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SnifferToolStripMenuItem.Text = "Sniffer"
        Me.SnifferToolStripMenuItem.Visible = False
        '
        'TraceRouteToolStripMenuItem
        '
        Me.TraceRouteToolStripMenuItem.Name = "TraceRouteToolStripMenuItem"
        Me.TraceRouteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TraceRouteToolStripMenuItem.Text = "Trace Route"
        Me.TraceRouteToolStripMenuItem.Visible = False
        '
        'ComputerToolStripMenuItem
        '
        Me.ComputerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetStatToolStripMenuItem, Me.RouteTableToolStripMenuItem})
        Me.ComputerToolStripMenuItem.Name = "ComputerToolStripMenuItem"
        Me.ComputerToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ComputerToolStripMenuItem.Text = "Computer"
        '
        'NetStatToolStripMenuItem
        '
        Me.NetStatToolStripMenuItem.Name = "NetStatToolStripMenuItem"
        Me.NetStatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NetStatToolStripMenuItem.Text = "NetStat"
        '
        'RouteTableToolStripMenuItem
        '
        Me.RouteTableToolStripMenuItem.Name = "RouteTableToolStripMenuItem"
        Me.RouteTableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RouteTableToolStripMenuItem.Text = "Route Table"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 435)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(512, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsl_Status
        '
        Me.tsl_Status.Name = "tsl_Status"
        Me.tsl_Status.Size = New System.Drawing.Size(0, 17)
        '
        'list_Host
        '
        Me.list_Host.BackColor = System.Drawing.SystemColors.ControlLight
        Me.list_Host.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_Host.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_Host.FormattingEnabled = True
        Me.list_Host.ItemHeight = 20
        Me.list_Host.Location = New System.Drawing.Point(0, 24)
        Me.list_Host.Name = "list_Host"
        Me.list_Host.Size = New System.Drawing.Size(512, 411)
        Me.list_Host.TabIndex = 2
        '
        'NetzwerkExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 457)
        Me.Controls.Add(Me.list_Host)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "NetzwerkExplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Netzwerk Explorer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgrammToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetzwerkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsl_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents IPAuflösenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortScannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents list_Host As System.Windows.Forms.ListBox
    Friend WithEvents LANExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SnifferToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetStatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RouteTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraceRouteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
