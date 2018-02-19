<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payfees
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
        Me.registrationNumberTextBox = New System.Windows.Forms.TextBox()
        Me.receiptNumberTextBox = New System.Windows.Forms.TextBox()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Fees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Receipt Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount"
        '
        'registrationNumberTextBox
        '
        Me.registrationNumberTextBox.Location = New System.Drawing.Point(280, 75)
        Me.registrationNumberTextBox.Name = "registrationNumberTextBox"
        Me.registrationNumberTextBox.Size = New System.Drawing.Size(132, 20)
        Me.registrationNumberTextBox.TabIndex = 4
        '
        'receiptNumberTextBox
        '
        Me.receiptNumberTextBox.Location = New System.Drawing.Point(280, 117)
        Me.receiptNumberTextBox.Name = "receiptNumberTextBox"
        Me.receiptNumberTextBox.Size = New System.Drawing.Size(131, 20)
        Me.receiptNumberTextBox.TabIndex = 5
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(280, 159)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(132, 20)
        Me.amountTextBox.TabIndex = 6
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(56, 343)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 7
        Me.saveButton.Text = "&Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(510, 343)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'payfees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 408)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.receiptNumberTextBox)
        Me.Controls.Add(Me.registrationNumberTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "payfees"
        Me.Text = "payfees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents registrationNumberTextBox As TextBox
    Friend WithEvents receiptNumberTextBox As TextBox
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents saveButton As Button
    Friend WithEvents exitButton As Button
End Class
