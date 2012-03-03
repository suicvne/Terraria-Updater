Imports updatevb

Public Class Main
    Public updater As New updatevb.updatevb

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        End

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click

        'When Show menu clicks, it will show the form:

        Me.Show()
        'Me.WindowState = FormWindowState.Normal

        'Show in the task bar:

        Me.ShowInTaskbar = True

        'Disable the Context Menu:

        ContextMenuStrip1.Enabled = False

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'MsgBox("The application will open a browser window that will download the newest Terraria version", MsgBoxStyle.Information)

        'System.Diagnostics.Process.Start("http://dl.dropbox.com/u/41587981/Terraria.rar")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("Program initialized successfully")
        Console.ReadLine()
        
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim open As New OpenFileDialog
        Dim res As String
        Dim names
        open.ShowDialog()
        open.Filter = "Executable Files(Terraria.exe)|*.exe|All Files(*.*)|*.*"
        names = open.FileName
        If IO.File.Exists(names) Then
            'MsgBox("You have selected:" + names, MsgBoxStyle.Information)
            res = MsgBox("Are you sure this is Terraria? It will launch.", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If res = vbYes Then
                System.Diagnostics.Process.Start(names)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call LaunchTerraria()
    End Sub

    Private Sub LinkLabel1_LinkClicked_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Console.WriteLine("Checking the directory....")
        If Dir("TerrariaGame\") <> "" Then
            Console.WriteLine("Directory exists!")
            System.Diagnostics.Process.Start("TerrariaGame\")
        Else
            Console.WriteLine("Directory doesn't exist!")
            Console.Read()
            'Do nothing
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("The download will now start. The program may freeze as the Terraria rar is a large file.", MsgBoxStyle.Information)
        Console.WriteLine()
        If Dir("TerrariaGame\Terraria.rar") <> "" Then
            My.Computer.FileSystem.DeleteFile("TerrariaGame\Terraria.rar")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/Terraria.rar", "TerrariaGame\Terraria.rar")

        MsgBox("The download has completed. Please extract files to the Terraria folder. The folder will open now.", MsgBoxStyle.OkOnly)


        System.Diagnostics.Process.Start("TerrariaGame\")
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oForm As Changelog
        oForm = New Changelog()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oForm As AboutBox1
        oForm = New AboutBox1()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("This application has an auto update feature in it; Please update through there.")
    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Download Started")
        If Dir("Terraria Mods\TerrariaInvEdit.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("Terraria Mods\TerrariaInvEdit.exe")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/TerrariaInvEdit.exe", "Terraria Mods\TerrariaInvEdit.exe")
        MsgBox("Download Complete")

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call InvEdit()
    End Sub
    Private Sub InvEdit()
        If Dir("Terraria Mods\TerrariaInvEdit.exe") <> "" Then
            System.Diagnostics.Process.Start("Terraria Mods\TerrariaInvEdit.exe")
        Else
            MsgBox("The system cannot find the file specified. Download the exe or rename the newest InvEdit exe to TerrariaInvEdit", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MsgBox("This application has an auto update feature in it; Please update through there.")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox("Download Started")
        If Dir("Terraria Mods\TerrariViewer.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("TerrariViewer.exe")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/TerrariViewer.exe", "Terraria Mods\TerrariViewer.exe")
        MsgBox("Download Complete")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'This checks if the directory exists before launching so there's no random exception statement
        Call TerrariViewer()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CheckforUpdates()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Dir("TerrariaGame\gMod.rar") <> "" Then
            My.Computer.FileSystem.DeleteFile("TerrariaGame\gMod.rar")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/gMod.rar", "TerrariaGame\gMod.rar")
        MsgBox("Download completed. Please use Winrar's extract here function to put all the files into the terraria directory.")
        System.Diagnostics.Process.Start("Terraria Updater\Terraria\")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MsgBox("W.I.P.!")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Call gMod()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Dir("Terraria Mods\") <> "" Then
            System.Diagnostics.Process.Start("Terraria Mods\")
        Else
            'Do nothing...again
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Dir("TerrariaGame\Content Loader.rar") <> "" Then
            My.Computer.FileSystem.DeleteFile("TerrariaGame\Content Loader.rar")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/Content%20Loader.rar", "Terraria\Content Loader.rar")
        MsgBox("Download complete. Please put all of its files right into the Terraria Folder; folder will now open.")
        System.Diagnostics.Process.Start("TerrariaGame\Content Loader.rar")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Call ContentLoader()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        MsgBox("Still working on a good system for this!")
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim oForm As ContentHowTo
        oForm = New ContentHowTo()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Code to be called for later in the program

    Private Sub TerrariViewer()
        If Dir("Terraria Mods\TerrariViewer.exe") <> "" Then
            System.Diagnostics.Process.Start("Terraria Mods\TerrariViewer.exe")
        Else
            MsgBox("The system cannot find the file specified. Download the exe or rename to TerrariViewer", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub gMod()
        If Dir("TerrariaGame\gMod.exe") <> "" Then
            System.Diagnostics.Process.Start("TerrariaGame\gMod.exe")
        Else
            MsgBox("Couldn't find the file specified. Make sure gMod.exe and all its files are in the Terraria folder", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ContentLoader()
        If Dir("TerrariaGame\TerrariaCustomContentLoader.exe") <> "" Then
            System.Diagnostics.Process.Start("TerrariaGame\TerrariaCustomContentLoader.exe")
        Else
            MsgBox("Program cannot find the file specified; make sure that all the files are where they belong. See troubleshooting for details", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LaunchTerraria()
        If Dir("TerrariaGame\Terraria.exe") <> "" Then
            System.Diagnostics.Process.Start("TerrariaGame\Terraria.exe")
        Else
            MsgBox("System cannot find the file specified. Download Terraria or extract it if already downloaded.", MsgBoxStyle.Critical)
        End If
    End Sub


    
    Private Sub CheckforUpdates()
        updater.checkinternet()
        updater.checkversion("http://dl.dropbox.com/u/41587981/version.txt", "1.3.1")
        If updater.updateavailable = True Then
            If Dir("C:\Temp\changelog.txt") <> "" Then
                My.Computer.FileSystem.DeleteFile("C:\Temp\changelog.txt")
            End If
            My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/changelog.txt", "C:\Temp\changelog.txt")
            Dim oForm As Update
            oForm = New Update()
            oForm.Show()
            oForm = Nothing

        Else
            MsgBox("You have the latest client version", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub LaunchTerrariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaunchTerrariaToolStripMenuItem.Click
        Call LaunchTerraria()
    End Sub

    Private Sub TerrariaInvEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrariaInvEditToolStripMenuItem.Click
        Call InvEdit()
    End Sub

    Private Sub TerrariaViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrariaViewerToolStripMenuItem.Click
        Call TerrariViewer()
    End Sub

    Private Sub GModToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GModToolStripMenuItem.Click
        Call gMod()
    End Sub

    Private Sub ContentLoaderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentLoaderToolStripMenuItem.Click
        Call ContentLoader()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://www.luigifanshack.webs.com")
    End Sub

    

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("https://bitbucket.org/Luigifan/terraria-updater/downloads/Terraria%20Updater%20Source%20Code_12.rar")
    End Sub

    

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub CheckForClientUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForClientUpdatesToolStripMenuItem.Click
        Call CheckforUpdates()
    End Sub

    Private Sub DownloadAndInstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadAndInstallToolStripMenuItem.Click
        If Dir("C:\Temp\winrar.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("C:\Temp\winrar.exe")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/winrar.exe", "C:\Temp\winrar.exe")
        MsgBox("WinRAR has been successfully downloaded. The installer will now launch")
        System.Diagnostics.Process.Start("C:\Temp\winrar.exe")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As TroubleShootingGuide
        oForm = New TroubleShootingGuide()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim oForm As AboutBox1
        oForm = New AboutBox1()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser2.Visible = True
        WebBrowser2.Navigate("http://www.luigifanshack.webs.com")
        Button3.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub CheckForCorrectPathsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckForCorrectPathsToolStripMenuItem.Click
        Dim oForm As New PathChecker
        oForm = New PathChecker()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub NPCHousingGuideToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NPCHousingGuideToolStripMenuItem.Click
        Dim oForm As New npcs
        oForm = New npcs()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Dim oForm As New Tut
        oForm = New Tut
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        MsgBox("Download started")
        If Dir("Terraria Extras\Terraria Beta and Pre-Alpha.rar") <> "" Then
            My.Computer.FileSystem.DeleteFile("Terraria Extras\Terraria Beta and Pre-Alpha.rar")
        Else
            'Nothing
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/Terraria%20Beta%20and%20Pre-Alpha.rar", "Terraria Extras\Terraria Beta and Pre-Alpha.rar")

        MsgBox("Download complete; Be warned, Terraria Beta actually uses a directory so backup your old saves before playing. Terraria Alpha generates a world for you so be patient")
        System.Diagnostics.Process.Start("Terraria Extras\")
    End Sub

    Private Sub TerrariaAlphaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrariaAlphaToolStripMenuItem.Click
        If Dir("Terraria Extras\Terraria Pre-Alpha\Terraria.exe") <> "" Then
            System.Diagnostics.Process.Start("Terraria Extras\Terraria Pre-Alpha\Terraria.exe")
        Else
            MsgBox("Can't locate the Pre-Alpha executable!")
        End If
    End Sub

    Private Sub TerrariaBetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerrariaBetaToolStripMenuItem.Click
        If Dir("Terraria Extras\Terraria Beta\Terraria.exe") <> "" Then
            System.Diagnostics.Process.Start("Terraria Extras\Terraria Beta\Terraria.exe")
        Else
            MsgBox("Can't locate the Beta executable!")
        End If
    End Sub

    Private Sub Button19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        MsgBox("Download started")
        If Dir("TerrariaGame\Itemaria.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("Terraria\Itemaria.exe")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/Itemaria.exe", "Terraria\Itemaria.exe")
        MsgBox("Download complete")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If Dir("TerrariaGame\Itemaria.exe") <> "" Then
            System.Diagnostics.Process.Start("Terraria\Itemaria.exe")
        Else
            MsgBox("Failed to find Itemaria.exe. Check that it's in the same directory as Terraria", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
