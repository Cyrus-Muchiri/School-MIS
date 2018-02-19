Imports System.Data.OleDb

Public Class Student_Progress
    Dim progressnum As Integer
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader

        connection.Open()
        Try
            'name
            Dim strSQL As String
            strSQL = "SELECT* FROM Students WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery
            dr = command.ExecuteReader

            While dr.Read()
                nameLabel.Text = dr("StudentName").ToString

            End While

            'openers
            Dim openersStrSQL As String
            openersStrSQL = "SELECT* FROM OpenerExams WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim openerscommand As OleDbCommand = New OleDbCommand(openersStrSQL, connection)
            Dim openersnum As Integer = openerscommand.ExecuteNonQuery
            dr = openerscommand.ExecuteReader

            While dr.Read()
                openerLabel.Text = dr("Total").ToString

            End While


            'visiting
            Dim visitingStrSQL As String
            visitingStrSQL = "SELECT* FROM VisitingExams WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim visitingcommand As OleDbCommand = New OleDbCommand(visitingStrSQL, connection)
            Dim visitingnum As Integer = visitingcommand.ExecuteNonQuery
            dr = visitingcommand.ExecuteReader

            While dr.Read()
                visitingLabel.Text = dr("Total").ToString

            End While
            'Cat
            Dim CatStrSQL As String
            CatStrSQL = "SELECT* FROM CAT WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim Catcommand As OleDbCommand = New OleDbCommand(CatStrSQL, connection)
            Dim Catnum As Integer = Catcommand.ExecuteNonQuery
            dr = Catcommand.ExecuteReader

            While dr.Read()
                catLabel.Text = dr("Total").ToString

            End While
            'endterm
            Dim endTermStrSQL As String
            endTermStrSQL = "SELECT* FROM EndTerm WHERE (RegNo='" & regNoTextBox.Text & "')"

            Dim endTermcommand As OleDbCommand = New OleDbCommand(endTermStrSQL, connection)
            Dim endTermnum As Integer = endTermcommand.ExecuteNonQuery
            dr = endTermcommand.ExecuteReader

            While dr.Read()
                endtermLabel.Text = dr("Total").ToString

            End While
            Try
                Dim opener, visiting, cat, endterm As Integer
                opener = Integer.Parse(openerLabel.Text)
                visiting = Integer.Parse(visitingLabel.Text)
                cat = Integer.Parse(catLabel.Text)
                endterm = Integer.Parse(endtermLabel.Text)
                'declaring arrays
                '  Dim labels() As String = {openerLabel4.Text, visitingLabel5.Text, catLabel6.Text, endTermLabel7.Text}
                'Dim markslabels() As Integer = {opener, visiting, cat, endterm}
                'Dim count As Integer = 0
                'for statement
                ' For count = 0 To count < 4

                ' this is a very poor algorithim . dont worry i will correct it with time. the for statemnt refused to work
                'oopener




                Dim insertStrSQl = "INSERT INTO progressTable (Examtype,Marks)
                    VALUES('" & openerLabel4.Text & "'," & opener & ")"
                Dim progresscommand As OleDbCommand = New OleDbCommand(insertStrSQl, connection)

                progresscommand.ExecuteNonQuery()
                'visiting
                Dim insert2StrSQl = "INSERT INTO progressTable (Examtype,Marks)
                    VALUES('" & visitingLabel5.Text & "'," & visiting & ")"
                Dim progress2command As OleDbCommand = New OleDbCommand(insert2StrSQl, connection)

                progress2command.ExecuteNonQuery()
                'cat
                Dim insert3StrSQl = "INSERT INTO progressTable (Examtype,Marks)
                    VALUES('" & catLabel6.Text & "'," & cat & ")"
                Dim progress3command As OleDbCommand = New OleDbCommand(insert3StrSQl, connection)

                progress3command.ExecuteNonQuery()
                'endterm
                Dim insert4StrSQl = "INSERT INTO progressTable (Examtype,Marks)
                    VALUES('" & endTermLabel7.Text & "'," & endterm & ")"
                Dim progress4command As OleDbCommand = New OleDbCommand(insert4StrSQl, connection)

                progress4command.ExecuteNonQuery()



                ' Next count
                connection.Close()
                If (progressnum <> 0) Then
                    MessageBox.Show("Record succesfully added", "Add record")

                End If
                connection.Close()
            Catch
                MessageBox.Show("Record Was previously added just go on and view progress", "Affirmation")

            End Try
        Catch ex As Exception
            MessageBox.Show(" All Records Were not found")
        End Try
        AcceptButton = progressButton

    End Sub

    Private Sub progressButton_Click(sender As Object, e As EventArgs) Handles progressButton.Click

        Try


            graphChart.Series.Add("progressTable")
            graphChart.Series("progressTable").ChartType = DataVisualization.Charting.SeriesChartType.Line

            Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=F:\vbprojects\School Records\schoolRecords.mdb"
            Dim connection As New OleDbConnection(ConnectionString)
            Dim dr As OleDbDataReader

            connection.Open()
            Dim strSQL As String = "SELECT [ExamType],[Marks]  FROM  [progressTable]"
            Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
            Dim num As Integer = command.ExecuteNonQuery
            dr = command.ExecuteReader

            While dr.Read()
                graphChart.Series("progressTable").Points.AddXY(dr("ExamType").ToString, dr("Marks").ToString)

            End While
            dr.Close()
            command.Dispose()
        Catch ex As Exception
            MessageBox.Show("Exit first before you load graph of another student", "Affirmation")
        End Try


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim ConnectionString = "provider=Microsoft.jet.OlEDB.4.0; Data Source=schoolRecords.mdb"
        Dim connection As New OleDbConnection(ConnectionString)
        Dim dr As OleDbDataReader
        connection.Open()
        Dim strSQL As String = "DELETE FROM progressTable"

        Dim command As OleDbCommand = New OleDbCommand(strSQL, connection)
        Dim num As Integer = command.ExecuteNonQuery

        command.ExecuteNonQuery()
        command.Dispose()

        connection.Close()

        Close()

    End Sub
End Class