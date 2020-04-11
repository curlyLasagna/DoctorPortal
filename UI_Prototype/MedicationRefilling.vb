Public Class MedicationRefilling
    Private Sub medicationListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medicationListBox.SelectedIndexChanged
        MedicationRefillingSubmit.Show()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class