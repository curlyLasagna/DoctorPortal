Public Class Bill_Info
    Private Sub currentBillBtn_Click(sender As Object, e As EventArgs) Handles currentBillBtn.Click
        currentBill.Show()
        Me.Close()
    End Sub

    Private Sub historicalBillBtn_Click(sender As Object, e As EventArgs) Handles historicalBillBtn.Click
        historicalBill.Show()
        Me.Close()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class