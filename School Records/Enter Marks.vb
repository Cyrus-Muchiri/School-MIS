'author Cyrus Muchiri Chomba
'date 9th july 2017

Imports System.Data.OleDb
Public Class Enter_Marks
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

        AcceptButton = saveButton
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        Dim examTitle As String
        examTitle = examtitleComboBox.Text

        maths = Integer.Parse(mathTextBox.Text)
        english = Integer.Parse(englishTextBox.Text)
        swahili = Integer.Parse(kiswahiliTextBox.Text)
        science = Integer.Parse(scienceTextBox.Text)
        social = Integer.Parse(socialstudiesTextBox.Text)



        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=F:\vbprojects\School Records\databases\schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Try
            connection.Open()

            Dim strSQL As String




            strSQL = "INSERT INTO " & examTitle & " (RegNo,Class,Stream,Maths,English,Kiswahili,Science,SocialCre,total)
                VALUES('" & regNoTextBox.Text & "','" & classLabel.Text & "','" & StreamLabel.Text & "'," & maths & "," & english & "," & swahili & "," & science & ",
                        " & social & "," & total & ")"

            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)


            Dim num As Integer = command.ExecuteNonQuery


            connection.Close()


            If (num <> 0) Then
                MessageBox.Show("Record succesfully added", "Add record")

            End If



        Catch
            MessageBox.Show("Marks already added", "warning")

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