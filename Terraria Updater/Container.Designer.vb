<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Container
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Container))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CheckForClientUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TroubleshootingGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinRarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadAndInstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewMenu, Me.WindowsMenu, Me.WinRarToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(996, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForClientUpdatesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TroubleshootingGuideToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 696)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(996, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(996, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'CheckForClientUpdatesToolStripMenuItem
        '
        Me.CheckForClientUpdatesToolStripMenuItem.Image = CType(resources.GetObject("CheckForClientUpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CheckForClientUpdatesToolStripMenuItem.Name = "CheckForClientUpdatesToolStripMenuItem"
        Me.CheckForClientUpdatesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CheckForClientUpdatesToolStripMenuItem.Text = "Check for Client Updates"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Main Form"
        '
        'TroubleshootingGuideToolStripMenuItem
        '
        Me.TroubleshootingGuideToolStripMenuItem.Image = CType(resources.GetObject("TroubleshootingGuideToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TroubleshootingGuideToolStripMenuItem.Name = "TroubleshootingGuideToolStripMenuItem"
        Me.TroubleshootingGuideToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TroubleshootingGuideToolStripMenuItem.Text = "Troubleshooting Guide"
        '
        'WinRarToolStripMenuItem
        '
        Me.WinRarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadAndInstallToolStripMenuItem})
        Me.WinRarToolStripMenuItem.Name = "WinRarToolStripMenuItem"
        Me.WinRarToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.WinRarToolStripMenuItem.Text = "WinRar"
        '
        'DownloadAndInstallToolStripMenuItem
        '
        Me.DownloadAndInstallToolStripMenuItem.Image = CType(resources.GetObject("DownloadAndInstallToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadAndInstallToolStripMenuItem.Name = "DownloadAndInstallToolStripMenuItem"
        Me.DownloadAndInstallToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DownloadAndInstallToolStripMenuItem.Text = "Download and Install"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Terraria Mods"
        '
        'Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 718)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Container"
        Me.Text = "Container"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CheckForClientUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TroubleshootingGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WinRarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadAndInstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton

End Class
