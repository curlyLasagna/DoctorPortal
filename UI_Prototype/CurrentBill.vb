Public Class currentBill
    Private Sub payNowBtn_Click(sender As Object, e As EventArgs) Handles payNowBtn.Click
        PaymentSystem.Show()
        Me.Close()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Bill_Info.Show()
        Me.Close()
    End Sub
End Class