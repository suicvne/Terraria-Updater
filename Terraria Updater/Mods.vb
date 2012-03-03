Public Class Mods

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Dir("Terraria Mods\") <> "" Then
            System.Diagnostics.Process.Start("Terraria Mods\")
        Else
            'Do nothing...again
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Download Started")
        If Dir("Terraria Mods\TerrariaInvEdit.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("Terraria Mods\TerrariaInvEdit.exe")
        End If
        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/TerrariaInvEdit.exe", "Terraria Mods\TerrariaInvEdit.exe")
        MsgBox("Download Complete")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("This application has an auto update feature in it; Please update through there.")
    End Sub
End Class