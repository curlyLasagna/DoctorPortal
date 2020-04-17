Public Class MedRecordRequest
    Private Sub OpenReleaseFormButton_Click(sender As Object, e As EventArgs) Handles openReleaseFormButton.Click
        MedicalReleasePrintableForm.Show()
        Me.Close()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class