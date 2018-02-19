<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balance
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.regNoTextBox = New System.Windows.Forms.TextBox()
        Me.studentsNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.payedFeesLabel = New System.Windows.Forms.Label()
        Me.balanceLabel = New System.Windows.Forms.Label()
        Me.feeRequiredLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.a = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fee Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Students Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fee Payed"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.regNoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.studentsNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 135)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'regNoTextBox
        '
        Me.regNoTextBox.Location = New System.Drawing.Point(158, 20)
        Me.regNoTextBox.Name = "regNoTextBox"
        Me.regNoTextBox.Size = New System.Drawing.Size(169, 20)
        Me.regNoTextBox.TabIndex = 4
        '
        'studentsNameTextBox
        '
        Me.studentsNameTextBox.Location = New System.Drawing.Point(157, 66)
        Me.studentsNameTextBox.Name = "studentsNameTextBox"
        Me.studentsNameTextBox.ReadOnly = True
        Me.studentsNameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.studentsNameTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.payedFeesLabel)
        Me.GroupBox2.Controls.Add(Me.balanceLabel)
        Me.GroupBox2.Controls.Add(Me.feeRequiredLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 172)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Balance Status"
        '
        'payedFeesLabel
        '
        Me.payedFeesLabel.AutoSize = True
        Me.payedFeesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payedFeesLabel.Location = New System.Drawing.Point(182, 29)
        Me.payedFeesLabel.Name = "payedFeesLabel"
        Me.payedFeesLabel.Size = New System.Drawing.Size(121, 24)
        Me.payedFeesLabel.TabIndex = 10
        Me.payedFeesLabel.Text = "Payed Fees"
        '
        'balanceLabel
        '
        Me.balanceLabel.AutoSize = True
        Me.balanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLabel.Location = New System.Drawing.Point(180, 100)
        Me.balanceLabel.Name = "balanceLabel"
        Me.balanceLabel.Size = New System.Drawing.Size(85, 24)
        Me.balanceLabel.TabIndex = 9
        Me.balanceLabel.Text = "Balance"
        '
        'feeRequiredLabel
        '
        Me.feeRequiredLabel.AutoSize = True
        Me.feeRequiredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeRequiredLabel.Location = New System.Drawing.Point(181, 66)
        Me.feeRequiredLabel.Name = "feeRequiredLabel"
        Me.feeRequiredLabel.Size = New System.Drawing.Size(149, 24)
        Me.feeRequiredLabel.TabIndex = 8
        Me.feeRequiredLabel.Text = "Required Fees"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fee Required"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(491, 359)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 25)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(412, 52)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(75, 23)
        Me.a.TabIndex = 6
        Me.a.Text = "&Search"
        Me.a.UseVisualStyleBackColor = True
        '
        'balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 408)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "balance"
        Me.Text = "balance"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents studentsNameTextBox As TextBox
    Friend WithEvents regNoTextBox As TextBox
    Friend WithEvents balanceLabel As Label
    Friend WithEvents feeRequiredLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents payedFeesLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents a As Button
End Class
