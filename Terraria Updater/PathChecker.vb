Public Class PathChecker

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("This is to make sure you've placed the Terraria.exe and Terraria mods in the correct spot. it should read Terraria Updater.exe\Terraria\Terraria.exe for the game itself.")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Dir("Terraria\Terraria.exe") <> "" Then
            MsgBox("Everything's alright! Safe to run Terraria!")
        Else
            MsgBox("Nope! Not there!", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Checked for TerrariaInvEdit.exe...")
        If Dir("Terraria Mods\TerrariaInvEdit.exe") <> "" Then

            MsgBox("Success!")
        Else
            MsgBox("Failed")
        End If
        MsgBox("Checked for TerrariViewer.exe...")
        If Dir("Terraria Mods\TerrariViewer.exe") <> "" Then
        Else
            MsgBox("Failed, names are case sensitive.")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("Checking for Terraria beta...")
        If Dir("Terraria Extras\Terraria Beta\Terraria.exe") <> "" Then
            MsgBox("Everything looks to be alright for the beta!")
        Else
            MsgBox("It's not there. Make sure it's <installdir>\Terraria Updater\Terraria Extras\Terraria Beta\Terraria.exe")
        End If
        '
        MsgBox("Checking for Terraria Pre-Alpha")
        If Dir("Terraria Extras\Terraria Pre-Alpha\Terraria.exe") <> "" Then
            MsgBox("Alpha's in the right spot!")
        Else
            MsgBox("Alpha's not there, make sure the directory reads <installdir>\Terraria Updater\Terraria Extras\Terraria Pre-Alpha\Terraria.exe")
        End If
    End Sub
End Class