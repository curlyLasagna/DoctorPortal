Public Class PaymentSystem
    Private Sub firstName_Click(sender As Object, e As EventArgs) Handles firstName.Click

    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        ReciptPage.Show()
        Bill_Info.Show()
        Me.Close()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        currentBill.Show()
        Me.Close()
    End Sub
End Class