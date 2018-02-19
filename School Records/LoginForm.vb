Imports System.Data.OleDb
Public Class LoginForm
    Dim Passkey, password As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader
        Dim succes As Boolean = False
        connection.Open()
        Try
            Dim strSQL As String
            strSQL = "SELECT* FROM login WHERE (UserName='" & UsernameTextBox.Text & "')"
            password = PasswordTextBox.Text
            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery
            dr = command.ExecuteReader

            While dr.Read()
                Passkey = dr("MyPassword").ToString

            End While

            If password = Passkey And password IsNot "" Then
                main.Show()

                Close()
            Else
                MessageBox.Show("Wrong Username or Password", "authentication")
            End If
        Catch
            MessageBox.Show("Wrong Username or Password", "authentication")
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
