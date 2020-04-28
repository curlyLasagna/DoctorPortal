Public Class historicalBill
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        HistoricalBillExample.Show()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        Bill_Info.Show()
        Me.Close()
    End Sub

    Private Sub show_histBill(sender As Object, e As EventArgs) Handles historical_bill_list.ItemActivate
        HistoricalBillExample.Show()
    End Sub
End Class