Imports System.Data.OleDb
Public Class searchStudent
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader
        Dim succes As Boolean = False
        connection.Open()

        Try
            Dim strSQL As String
            strSQL = "SELECT* FROM Students WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery
            dr = command.ExecuteReader

            While dr.Read()
                nameLabel.Text = dr("StudentName").ToString
                genderLabel.Text = dr("Gender").ToString
                dobLabel.Text = dr("DOB").ToString
                parentsMobileLabel.Text = dr("parentsMobile").ToString
                classLabel.Text = dr("Class").ToString
                streamLabel.Text = dr("Stream").ToString
                dormLabel.Text = dr("Dorm").ToString
                diningTableLabel.Text = dr("DiningTable").ToString

                succes = True
            End While
            If (succes = False) Then
                MessageBox.Show("Record not found")
            End If

            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Record not found")
        End Try

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub


End Class