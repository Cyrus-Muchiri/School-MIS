Public Class Administrator_Login
    Private Sub adminLoginButton_Click(sender As Object, e As EventArgs) Handles adminLoginButton.Click
        Dim password As String

        password = passwordTextBox.Text
        If (password = "root" Or password = "ROOT" Or password = "Root") Then
            Administrator_Panel.Show()
            Close()
        Else
            MessageBox.Show("Wrong Password", "Try again")
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Close()
    End Sub
End Class