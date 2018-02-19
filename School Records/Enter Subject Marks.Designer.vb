<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_Subject_Marks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.streamComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.marksDataGridView = New System.Windows.Forms.DataGridView()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.examtitleComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.marksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Class"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select stream"
        '
        'classComboBox
        '
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Items.AddRange(New Object() {"preUnit", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.classComboBox.Location = New System.Drawing.Point(139, 66)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(79, 21)
        Me.classComboBox.TabIndex = 3
        '
        'streamComboBox
        '
        Me.streamComboBox.FormattingEnabled = True
        Me.streamComboBox.Items.AddRange(New Object() {"north", "south"})
        Me.streamComboBox.Location = New System.Drawing.Point(377, 66)
        Me.streamComboBox.Name = "streamComboBox"
        Me.streamComboBox.Size = New System.Drawing.Size(79, 21)
        Me.streamComboBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(524, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Individual Subject Marks Entry"
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(765, 66)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 23)
        Me.enterButton.TabIndex = 6
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'marksDataGridView
        '
        Me.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.marksDataGridView.Location = New System.Drawing.Point(139, 126)
        Me.marksDataGridView.Name = "marksDataGridView"
        Me.marksDataGridView.Size = New System.Drawing.Size(1048, 493)
        Me.marksDataGridView.TabIndex = 7
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(1112, 655)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Exam Title"
        '
        'examtitleComboBox
        '
        Me.examtitleComboBox.FormattingEnabled = True
        Me.examtitleComboBox.Items.AddRange(New Object() {"OpenerExams", "VisitingExams", "EndTerm", "CAT"})
        Me.examtitleComboBox.Location = New System.Drawing.Point(583, 66)
        Me.examtitleComboBox.Name = "examtitleComboBox"
        Me.examtitleComboBox.Size = New System.Drawing.Size(135, 21)
        Me.examtitleComboBox.TabIndex = 23
        '
        'Enter_Subject_Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 690)
        Me.Controls.Add(Me.examtitleComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.marksDataGridView)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.streamComboBox)
        Me.Controls.Add(Me.classComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Enter_Subject_Marks"
        Me.Text = "Enter_Subject_Marks"
        CType(Me.marksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents classComboBox As ComboBox
    Friend WithEvents streamComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents enterButton As Button
    Friend WithEvents marksDataGridView As DataGridView
    Friend WithEvents exitButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents examtitleComboBox As ComboBox
End Class
