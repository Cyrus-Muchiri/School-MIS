Imports System.Data.OleDb
Public Class Administrator_Panel
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub addTeacherSaveButton_Click(sender As Object, e As EventArgs) Handles addTeacherSaveButton.Click
        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        ' Try
        connection.Open()
        Dim strSQL As String
        strSQL = "INSERT INTO login(UserName,TeachersName) VALUES('" & userNameTextBox.Text & "','" & teachersNameTextBox.Text & "')"
        Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)

        Dim num As Integer = command.ExecuteNonQuery
        connection.Close()


        If (num <> 0) Then
            MessageBox.Show("User succesfully added", "Add User")
            Close()
        Else
            MessageBox.Show("User not added", "Add User error")
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click


        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader
        Dim name As String
        Dim nameSQL As String
        Dim strSQL As String
        Dim success As Boolean
        connection.Open()

        nameSQL = "SELECT *  FROM login WHERE UserName='" & userTextBox.Text & "'"
        Dim namecommand As OleDbCommand = New OleDbCommand(nameSQL, connection)
        dr = namecommand.ExecuteReader

        While dr.Read()
            name = dr("TeachersName").ToString
            success = False
        End While


        Dim buttondialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete " & name, "Deleterecord",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If buttondialogResult = DialogResult.Yes Then



            Try
                strSQL = "DELETE FROM login WHERE UserName='" & userTextBox.Text & "'"
                Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)

                Dim num As Integer = command.ExecuteNonQuery



                command.ExecuteNonQuery()
                command.Dispose()

                connection.Close()

                If num <> 0 Then
                    MessageBox.Show("Record successfully deleted", "confirmation")
                Else
                    MessageBox.Show("Record not found hence not deleted", "error")
                End If

            Catch
                MessageBox.Show("error deleting record")
            End Try

        End If


    End Sub
End Class