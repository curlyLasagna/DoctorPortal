Public Class appt_main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        appt_schedule.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        appt_upcoming.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        appt_cancel.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class
