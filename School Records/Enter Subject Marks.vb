Imports System.Data.OleDb
Public Class Enter_Subject_Marks



    Dim myDataSet As New DataSet()
    Dim myDataTable As New DataTable()
    Dim tables As DataTableCollection = myDataSet.Tables
    Dim source As New BindingSource()
    Private Sub Enter_Subject_Marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim examtitle As String
        examtitle = examtitleComboBox.Text

        Dim connectionString As String = "provider=Microsoft.jet.OLEDB.4.0;" & "data source=schoolRecords.mdb;"
        Dim myConnection As New OleDbConnection(connectionString)
        Dim strSQL As String = "SELECT * FROM " & examtitle & ""
        Dim command As OleDbCommand = New OleDbCommand(strSQL, myConnection)
        Dim myDataAdapter As New OleDbDataAdapter(command)
        myConnection.Open()

        Try
            Dim view As New DataView(tables(0))
            myDataAdapter.Fill(myDataSet, "" & examtitle & "")
            myDataTable = myDataSet.Tables("" & examtitle & "")
            marksDataGridView.DataSource = myDataTable


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString, "Error")
        End Try
    End Sub
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        source.Filter = "[]"

    End Sub


End Class