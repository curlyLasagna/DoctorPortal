Public Class appt_cancel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        appt_cancel_submit.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        appt_main.Show()
        Me.Close()
    End Sub
End Class