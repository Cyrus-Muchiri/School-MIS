<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newStudent
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.regNoTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.dobTextBox = New System.Windows.Forms.TextBox()
        Me.parentsmobileTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.genderComboBox = New System.Windows.Forms.ComboBox()
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.streamComboBox = New System.Windows.Forms.ComboBox()
        Me.dormComboBox = New System.Windows.Forms.ComboBox()
        Me.diningTableComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Student"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "D.O.B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Parents mobile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Class"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Dorm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Dining Table"
        '
        'regNoTextBox
        '
        Me.regNoTextBox.Location = New System.Drawing.Point(257, 66)
        Me.regNoTextBox.Name = "regNoTextBox"
        Me.regNoTextBox.Size = New System.Drawing.Size(190, 20)
        Me.regNoTextBox.TabIndex = 9
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(257, 97)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.nameTextBox.TabIndex = 10
        '
        'dobTextBox
        '
        Me.dobTextBox.Location = New System.Drawing.Point(257, 158)
        Me.dobTextBox.Name = "dobTextBox"
        Me.dobTextBox.Size = New System.Drawing.Size(190, 20)
        Me.dobTextBox.TabIndex = 12
        '
        'parentsmobileTextBox
        '
        Me.parentsmobileTextBox.Location = New System.Drawing.Point(257, 190)
        Me.parentsmobileTextBox.Name = "parentsmobileTextBox"
        Me.parentsmobileTextBox.Size = New System.Drawing.Size(190, 20)
        Me.parentsmobileTextBox.TabIndex = 13
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(60, 348)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(87, 22)
        Me.saveButton.TabIndex = 17
        Me.saveButton.Text = "&Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(495, 349)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(82, 21)
        Me.exitButton.TabIndex = 18
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Stream"
        '
        'genderComboBox
        '
        Me.genderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.genderComboBox.FormattingEnabled = True
        Me.genderComboBox.Items.AddRange(New Object() {"male", "female"})
        Me.genderComboBox.Location = New System.Drawing.Point(257, 129)
        Me.genderComboBox.Name = "genderComboBox"
        Me.genderComboBox.Size = New System.Drawing.Size(190, 21)
        Me.genderComboBox.TabIndex = 21
        '
        'classComboBox
        '
        Me.classComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Items.AddRange(New Object() {"PreUnit", "Nursery", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", ""})
        Me.classComboBox.Location = New System.Drawing.Point(257, 218)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(190, 21)
        Me.classComboBox.TabIndex = 22
        '
        'streamComboBox
        '
        Me.streamComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.streamComboBox.FormattingEnabled = True
        Me.streamComboBox.Items.AddRange(New Object() {"South", "North"})
        Me.streamComboBox.Location = New System.Drawing.Point(257, 251)
        Me.streamComboBox.Name = "streamComboBox"
        Me.streamComboBox.Size = New System.Drawing.Size(190, 21)
        Me.streamComboBox.TabIndex = 23
        '
        'dormComboBox
        '
        Me.dormComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.dormComboBox.FormattingEnabled = True
        Me.dormComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.dormComboBox.Location = New System.Drawing.Point(257, 278)
        Me.dormComboBox.Name = "dormComboBox"
        Me.dormComboBox.Size = New System.Drawing.Size(190, 21)
        Me.dormComboBox.TabIndex = 24
        '
        'diningTableComboBox
        '
        Me.diningTableComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.diningTableComboBox.FormattingEnabled = True
        Me.diningTableComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.diningTableComboBox.Location = New System.Drawing.Point(257, 308)
        Me.diningTableComboBox.Name = "diningTableComboBox"
        Me.diningTableComboBox.Size = New System.Drawing.Size(190, 21)
        Me.diningTableComboBox.TabIndex = 25
        '
        'newStudent
        '
        Me.AcceptButton = Me.saveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(620, 397)
        Me.Controls.Add(Me.diningTableComboBox)
        Me.Controls.Add(Me.dormComboBox)
        Me.Controls.Add(Me.streamComboBox)
        Me.Controls.Add(Me.classComboBox)
        Me.Controls.Add(Me.genderComboBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.parentsmobileTextBox)
        Me.Controls.Add(Me.dobTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.regNoTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newStudent"
        Me.Text = "class1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents regNoTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents dobTextBox As TextBox
    Friend WithEvents parentsmobileTextBox As TextBox
    Friend WithEvents saveButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents genderComboBox As ComboBox
    Friend WithEvents classComboBox As ComboBox
    Friend WithEvents streamComboBox As ComboBox
    Friend WithEvents dormComboBox As ComboBox
    Friend WithEvents diningTableComboBox As ComboBox
End Class
