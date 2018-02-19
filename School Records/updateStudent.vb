Imports System.Data.OleDb
Public Class updateStudent

    Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
    Dim connection As New OleDbConnection(ConnectionString)
    Dim dr As OleDbDataReader
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

        Dim succes As Boolean = False
        connection.Open()
        Try
            Dim strSQL As String
            strSQL = "SELECT* FROM Students WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery
            dr = command.ExecuteReader

            While dr.Read()
                nameTextBox.Text = dr("StudentName").ToString
                genderTextBox.Text = dr("Gender").ToString
                dobTextBox.Text = dr("DOB").ToString
                parentsmobileTextBox.Text = dr("parentsMobile").ToString
                classTextBox.Text = dr("Class").ToString
                streamTextBox.Text = dr("Stream").ToString
                dormTextBox.Text = dr("Dorm").ToString
                diningTableTextBox.Text = dr("DiningTable").ToString

                succes = True
            End While
            If (succes = False) Then
                MessageBox.Show("Record not found")
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Record not found")
        End Try
        AcceptButton = updateButton
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        Try
            connection.Open()
            regNoTextBox.ReadOnly = True
            Dim strSQL As String
            strSQL = "UPDATE Students  SET RegNo='" & regNoTextBox.Text & "', StudentName='" & nameTextBox.Text & "', Gender='" & genderTextBox.Text & "', DOB='" & dobTextBox.Text & "',
        parentsMobile='" & parentsmobileTextBox.Text & "' ,Class='" & classTextBox.Text & "', Stream='" & streamTextBox.Text & "', Dorm='" & dormTextBox.Text & "',
        DiningTable='" & diningTableTextBox.Text & "' WHERE RegNo='" & regNoTextBox.Text & "'"



            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery()

            If num <> 0 Then
                MessageBox.Show("Record successfully updated")
            End If
        Catch
            MessageBox.Show("An error occurred while updating", "error")

            connection.Close()
        End Try
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class