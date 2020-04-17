Public Class appt_schedule
    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        appt_schedule_submit.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        appt_main.Show()
        Me.Close()
    End Sub
End Class