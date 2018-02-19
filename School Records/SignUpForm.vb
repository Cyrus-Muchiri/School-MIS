Imports System.Data.OleDb
Public Class SignUpForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim cpassword As String = confirmPasswordTextBox.Text

        If password = cpassword Then

            Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
            Dim connection As New OleDbConnection(ConnectionString)
            ' Try
            connection.Open()
                Dim strSQL As String
            strSQL = "UPDATE login SET MyPassword='" & PasswordTextBox.Text & "' WHERE UserName='" & UsernameTextBox.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)

                Dim num As Integer = command.ExecuteNonQuery
                connection.Close()


                If (num <> 0) Then
                MessageBox.Show("User succesfully added", "Add User")
                Close()
            Else
                MessageBox.Show("Unsuccessful. Ensure you enter the username provided by admin", "Add User Error")
            End If

            ' Catch
            'MessageBox.Show("data mismatch", "warning")

            'Close()

            ' End Try
        Else
            MessageBox.Show("Passwords don't Match", "Warning")
        End If


    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
