<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator_Panel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addTeacherSaveButton = New System.Windows.Forms.Button()
        Me.userNameTextBox = New System.Windows.Forms.TextBox()
        Me.teachersNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.termComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.termInfoSaveButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.userTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.examInfoSaveButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.termFeesSaveButton = New System.Windows.Forms.Button()
        Me.bordersFeesTextBox = New System.Windows.Forms.TextBox()
        Me.dayShoolersTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.outgoingClassDeleteButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(515, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administrator Panel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.addTeacherSaveButton)
        Me.GroupBox1.Controls.Add(Me.userNameTextBox)
        Me.GroupBox1.Controls.Add(Me.teachersNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Users/Teachers"
        '
        'addTeacherSaveButton
        '
        Me.addTeacherSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherSaveButton.Location = New System.Drawing.Point(226, 221)
        Me.addTeacherSaveButton.Name = "addTeacherSaveButton"
        Me.addTeacherSaveButton.Size = New System.Drawing.Size(104, 24)
        Me.addTeacherSaveButton.TabIndex = 4
        Me.addTeacherSaveButton.Text = "save"
        Me.addTeacherSaveButton.UseVisualStyleBackColor = True
        '
        'userNameTextBox
        '
        Me.userNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameTextBox.Location = New System.Drawing.Point(167, 110)
        Me.userNameTextBox.Name = "userNameTextBox"
        Me.userNameTextBox.Size = New System.Drawing.Size(153, 20)
        Me.userNameTextBox.TabIndex = 3
        '
        'teachersNameTextBox
        '
        Me.teachersNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teachersNameTextBox.Location = New System.Drawing.Point(167, 61)
        Me.teachersNameTextBox.Name = "teachersNameTextBox"
        Me.teachersNameTextBox.Size = New System.Drawing.Size(153, 20)
        Me.teachersNameTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Set User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Teachers Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.termComboBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.termInfoSaveButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(522, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Term Information"
        '
        'termComboBox
        '
        Me.termComboBox.FormattingEnabled = True
        Me.termComboBox.Items.AddRange(New Object() {"Term 1", "Term 2", "Term 3"})
        Me.termComboBox.Location = New System.Drawing.Point(169, 43)
        Me.termComboBox.Name = "termComboBox"
        Me.termComboBox.Size = New System.Drawing.Size(121, 23)
        Me.termComboBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Select Term"
        '
        'termInfoSaveButton
        '
        Me.termInfoSaveButton.Location = New System.Drawing.Point(246, 222)
        Me.termInfoSaveButton.Name = "termInfoSaveButton"
        Me.termInfoSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.termInfoSaveButton.TabIndex = 0
        Me.termInfoSaveButton.Text = "Save"
        Me.termInfoSaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.deleteButton)
        Me.GroupBox3.Controls.Add(Me.userTextBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(59, 387)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Delete Users/Teachers"
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(226, 183)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(82, 28)
        Me.deleteButton.TabIndex = 8
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'userTextBox
        '
        Me.userTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTextBox.Location = New System.Drawing.Point(177, 59)
        Me.userTextBox.Name = "userTextBox"
        Me.userTextBox.Size = New System.Drawing.Size(153, 20)
        Me.userTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "UserName to Delete"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.examInfoSaveButton)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(972, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Exam Information"
        '
        'examInfoSaveButton
        '
        Me.examInfoSaveButton.Location = New System.Drawing.Point(243, 221)
        Me.examInfoSaveButton.Name = "examInfoSaveButton"
        Me.examInfoSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.examInfoSaveButton.TabIndex = 2
        Me.examInfoSaveButton.Text = "Save"
        Me.examInfoSaveButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"opener", "Visiting", "Closing", "Continuos Assessment Tests"})
        Me.ComboBox1.Location = New System.Drawing.Point(197, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Exam Title"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.termFeesSaveButton)
        Me.GroupBox5.Controls.Add(Me.bordersFeesTextBox)
        Me.GroupBox5.Controls.Add(Me.dayShoolersTextBox)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(522, 387)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fees For Semester"
        '
        'termFeesSaveButton
        '
        Me.termFeesSaveButton.Location = New System.Drawing.Point(246, 222)
        Me.termFeesSaveButton.Name = "termFeesSaveButton"
        Me.termFeesSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.termFeesSaveButton.TabIndex = 4
        Me.termFeesSaveButton.Text = "Save"
        Me.termFeesSaveButton.UseVisualStyleBackColor = True
        '
        'bordersFeesTextBox
        '
        Me.bordersFeesTextBox.Location = New System.Drawing.Point(203, 103)
        Me.bordersFeesTextBox.Name = "bordersFeesTextBox"
        Me.bordersFeesTextBox.Size = New System.Drawing.Size(100, 21)
        Me.bordersFeesTextBox.TabIndex = 3
        '
        'dayShoolersTextBox
        '
        Me.dayShoolersTextBox.Location = New System.Drawing.Point(203, 60)
        Me.dayShoolersTextBox.Name = "dayShoolersTextBox"
        Me.dayShoolersTextBox.Size = New System.Drawing.Size(100, 21)
        Me.dayShoolersTextBox.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Borders Fees"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DaySchoolers Fees"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.outgoingClassDeleteButton)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(972, 387)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(354, 265)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Delete Outgoing Class"
        '
        'outgoingClassDeleteButton
        '
        Me.outgoingClassDeleteButton.Location = New System.Drawing.Point(243, 222)
        Me.outgoingClassDeleteButton.Name = "outgoingClassDeleteButton"
        Me.outgoingClassDeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.outgoingClassDeleteButton.TabIndex = 1
        Me.outgoingClassDeleteButton.Text = "Delete"
        Me.outgoingClassDeleteButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 30)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Is it end of year? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Delete outgoing Class (  class  8 )"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(1202, 658)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Administrator_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 690)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Administrator_Panel"
        Me.Text = "Administrator_Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents addTeacherSaveButton As Button
    Friend WithEvents userNameTextBox As TextBox
    Friend WithEvents teachersNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents termComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents termInfoSaveButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents userTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bordersFeesTextBox As TextBox
    Friend WithEvents dayShoolersTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents examInfoSaveButton As Button
    Friend WithEvents outgoingClassDeleteButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents termFeesSaveButton As Button
    Friend WithEvents exitButton As Button
End Class
