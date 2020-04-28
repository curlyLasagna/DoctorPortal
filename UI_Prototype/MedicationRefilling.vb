Public Class MedicationRefilling
    Private Sub medicationListBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        MedicationRefillingSubmit.Show()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub confirm_refill(sender As Object, e As EventArgs) Handles med_ListView.ItemActivate
        MedicationRefillingSubmit.Show()
    End Sub
End Class