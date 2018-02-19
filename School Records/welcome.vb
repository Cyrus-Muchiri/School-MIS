Public Class welcomeForm


    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        LoginForm.Show()
    End Sub

    Private Sub signUpButton_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        SignUpForm.Show()
    End Sub

    Private Sub adminButton_Click(sender As Object, e As EventArgs) Handles adminButton.Click
        Administrator_Login.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub


End Class
