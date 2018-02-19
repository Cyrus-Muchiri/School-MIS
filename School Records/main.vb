Public Class main

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        updateStudent.Show()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        newStudent.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete_Student.Show()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        searchStudent.Show()
    End Sub

    Private Sub PayUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayUpdateToolStripMenuItem.Click
        payfees.Show()
    End Sub

    Private Sub CheckBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckBalanceToolStripMenuItem.Click
        balance.Show()
    End Sub

    Private Sub UpdateMarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMarksToolStripMenuItem.Click
        updatemarks.Show()
    End Sub

    Private Sub IndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem.Click
        Individual_Results.Show()
    End Sub

    Private Sub adminpanelButton_Click(sender As Object, e As EventArgs) Handles adminpanelButton.Click
        Administrator_Login.Show()
    End Sub
    Private Sub EnterMarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterMarksToolStripMenuItem.Click
        Enter_Marks.Show()

    End Sub

    Private Sub IndividualStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualStudentsToolStripMenuItem.Click
        Student_Progress.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim buttonDialogResult As DialogResult = MessageBox.Show("Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If buttonDialogResult = DialogResult.Yes Then
            Me.Close()

        End If
    End Sub


End Class