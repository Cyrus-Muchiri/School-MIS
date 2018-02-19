Imports System.Data.OleDb
Public Class newStudent
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        ' Try
        connection.Open()
            Dim strSQL As String
            Dim StringSQL As String = "SELECT* FROM students WHERE (RegNo='" & regNoTextBox.Text & "')"
            Dim Selectcommand As OleDbCommand = New OleDbCommand(StringSQL, connection)
            Dim Selectnum As Integer = Selectcommand.ExecuteNonQuery
            Dim Classname As String = classComboBox.Text

            If Selectnum = 0 Then

                strSQL = "INSERT INTO Students(RegNo,StudentName,Gender,DOB,parentsMobile,Class,Stream,Dorm,DiningTable)
                VALUES('" & regNoTextBox.Text & "','" & nameTextBox.Text & "','" & genderComboBox.Text & "','" & dobTextBox.Text & "','" & parentsmobileTextBox.Text & "',
                        '" & classComboBox.Text & "','" & streamComboBox.Text & "','" & dormComboBox.Text & "','" & diningTableComboBox.Text & "')"

                Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)

                Dim num As Integer = command.ExecuteNonQuery
                connection.Close()
            ' inserting to class database
            Dim classConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=classes.mdb"
            Dim classconnection As New OleDbConnection(classConnectionString)
                'Try
                classconnection.Open()
            Dim classstrSQL As String = "INSERT INTO " & Classname & " (RegNo,StudentName,Gender,parentsMobile,Dorm,DiningTable,Stream)
                VALUES('" & regNoTextBox.Text & "','" & nameTextBox.Text & "','" & genderComboBox.Text & "','" & parentsmobileTextBox.Text & "'
                      ,'" & dormComboBox.Text & "','" & diningTableComboBox.Text & "', '" & streamComboBox.Text & "')"

            Dim classcommand As OleDbCommand = New OleDbCommand(classstrSQL, classconnection)

                Dim classnum As Integer = classcommand.ExecuteNonQuery


                If (num <> 0) Then
                    MessageBox.Show("Record succesfully added", "Add record")

                End If

            Else

                MessageBox.Show("Record already Exists", "Error")
            End If

        '    Catch
        MessageBox.Show("Ensure you Entered Correct Data", "warning")

            Me.Close()

        'End Try

    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub


End Class