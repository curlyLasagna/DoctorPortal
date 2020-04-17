Public Class MedicalReleasePrintableForm
    Private Sub cancel_Button_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class