Imports UpdateVB
Public Class Update

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Dir("C:\Temp\update.exe") <> "" Then
            My.Computer.FileSystem.DeleteFile("C:\Temp\update.exe")
        End If

        My.Computer.Network.DownloadFile("http://dl.dropbox.com/u/41587981/update.exe", "C:\Temp\update.exe")
        If Dir("C:\Temp\update.exe") <> "" Then
            System.Diagnostics.Process.Start("C:\Temp\update.exe")
            End
        Else
            MsgBox("Update download failed, disable firewall or check internet connection")
            'Up to date
        End If
    End Sub

    Private Sub Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.CreateDirectory("C:\Temp\")
        Call ReadText()
    End Sub
    Private Sub ReadText()
        TextBox12.Text = My.Computer.FileSystem.ReadAllText("C:\Temp\changelog.txt")
    End Sub

    Private Sub TextBox12_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.MouseMove

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub
End Class