Public Class appt_schedule
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles submit_appt_date.Click
        MsgBox("Your requested appointment date and time has been sent", MsgBoxStyle.OkOnly)
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub return_mainMenu(sender As Object, e As EventArgs) Handles previous_btn.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class