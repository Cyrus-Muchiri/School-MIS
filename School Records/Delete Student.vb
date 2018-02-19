Imports System.Data.OleDb
Public Class Delete_Student
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader
        connection.Open()

        Dim studentname As String

        Dim strSQL As String
            strSQL = "SELECT* FROM Students WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim namecommand As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim namenum As Integer = namecommand.ExecuteNonQuery
            dr = namecommand.ExecuteReader

            While dr.Read()
            studentname = dr("StudentName").ToString
        End While
        Dim buttondialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete " & studentname, "Deleterecord",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If buttondialogResult = DialogResult.Yes Then



                Try
                strSQL = "DELETE FROM Students WHERE RegNo='" & regNoTextBox.Text & "'"

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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class