Public Class recoveryForm
    Private Sub shipIt(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub closeOnEsc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar.Equals(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub keypressed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' The keypressed method uses the KeyChar Property To check 
        ' whether the ENTER key Is pressed. 
        ' If the ENTER key Is pressed, the Handled property Is set to true, 
        ' to indicate the event Is handled.
        If e.KeyChar.Equals(Keys.Return) Then
            Me.Close()
        End If
    End Sub

End Class