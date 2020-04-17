Public Class MainMenu
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        appt_main.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MedHx.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Home_Monitoring.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MedRecordRequest.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MedicationRefilling.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Bill_Info.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ins_main.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        pharm_main.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub AboutMe_Click(sender As Object, e As EventArgs) Handles AboutMe_Button.Click
        Timer1.Start()
        If Not AboutMeSubMenu.Height = 0 Then
            AboutMeSubMenu.Height = 0
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AboutMeSubMenu.Height = 211
        Timer1.Stop()
    End Sub

    Private Sub closeApp(sender As Object, e As EventArgs) Handles exit_button.Click
        Me.Close()
    End Sub

    Private Sub goto_AccountInfo(sender As Object, e As EventArgs) Handles clientInfo_Button.Click
        AccountInfo.Show()
        Me.Hide()
    End Sub
End Class
