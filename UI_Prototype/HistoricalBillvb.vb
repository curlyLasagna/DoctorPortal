Public Class historicalBill
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles reciptListBox.SelectedIndexChanged
        HistoricalBillExample.Show()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Bill_Info.Show()
        Me.Close()
    End Sub
End Class