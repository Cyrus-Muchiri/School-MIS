Imports System.Data.OleDb
Public Class updatemarks
    Private maths, english, swahili, science, social, total As Integer

    Private RegNo As Integer
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
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
                NameLabel.Text = dr("StudentName").ToString
                classLabel.Text = dr("Class")
                StreamLabel.Text = dr("Stream")
                succes = True
            End While
            If (succes = False) Then
                MessageBox.Show("Record not found")
            End If

            Dim marksStrSQL As String
            marksStrSQL = "SELECT* FROM " & examtitleComboBox.Text & " WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim marksCommand As OleDbCommand = New OleDbCommand(marksStrSQL, connection)
            Dim marksNum As Integer = marksCommand.ExecuteNonQuery
            dr = marksCommand.ExecuteReader

            While dr.Read()
                mathTextBox.Text = dr("Maths").ToString
                englishTextBox.Text = dr("english").ToString
                kiswahiliTextBox.Text = dr("Kiswahili").ToString
                scienceTextBox.Text = dr("Science").ToString
                socialstudiesTextBox.Text = dr("SocialCre").ToString
                marksLabel.Text = dr("Total").ToString
                succes = True
            End While
            If (succes = False) Then
                MessageBox.Show("Record not found")
            End If


            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Record not found")
        End Try

        AcceptButton = calculateButton
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Try
            maths = Integer.Parse(mathTextBox.Text)
            english = Integer.Parse(englishTextBox.Text)
            swahili = Integer.Parse(kiswahiliTextBox.Text)
            science = Integer.Parse(scienceTextBox.Text)
            social = Integer.Parse(socialstudiesTextBox.Text)

            total = maths + english + swahili + science + social
            If total <= 500 Then
                marksLabel.Text = total.ToString
            Else
                MessageBox.Show("Total Marks cant be above 500")
            End If


        Catch
            MessageBox.Show("Ensure you entered correct values", "invalid")
        End Try

        AcceptButton = updateButton
    End Sub
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim examTitle As String
        examTitle = examtitleComboBox.Text

        maths = Integer.Parse(mathTextBox.Text)
        english = Integer.Parse(englishTextBox.Text)
        swahili = Integer.Parse(kiswahiliTextBox.Text)
        science = Integer.Parse(scienceTextBox.Text)
        social = Integer.Parse(socialstudiesTextBox.Text)



        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Try
            connection.Open()

            Dim strSQL As String




            strSQL = "UPDATE " & examTitle & " SET RegNo= '" & regNoTextBox.Text & "',Class='" & classLabel.Text & "',Stream='" & StreamLabel.Text & "',
                    Maths=" & maths & ",english=" & english & ",Kiswahili=" & swahili & ",Science=" & science & ",SocialCre=" & social & ",total=" & total & " WHERE RegNo='" & regNoTextBox.Text & "'"



            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)


            Dim num As Integer = command.ExecuteNonQuery

            connection.Close()

            If (num <> 0) Then
                MessageBox.Show("Record succesfully updated", "Success")

            End If

        Catch
            MessageBox.Show("Enter correct data", "warning")

            Me.Close()

        End Try
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class