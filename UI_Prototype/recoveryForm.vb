Public Class recoveryForm
    Private Sub shipIt(sender As Object, e As EventArgs) Handles Button1.Click
        login_form.Show()
        Me.Close()
    End Sub

    Private Sub goto_login(sender As Object, e As EventArgs) Handles CancelForm.Click
        login_form.Show()
        Me.Close()
    End Sub
End Class