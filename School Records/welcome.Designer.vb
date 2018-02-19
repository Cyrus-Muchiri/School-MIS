<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomeForm))
        Me.loginButton = New System.Windows.Forms.Button()
        Me.signUpButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.adminButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(24, 108)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(90, 23)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "Log In"
        Me.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'signUpButton
        '
        Me.signUpButton.Location = New System.Drawing.Point(24, 160)
        Me.signUpButton.Name = "signUpButton"
        Me.signUpButton.Size = New System.Drawing.Size(90, 23)
        Me.signUpButton.TabIndex = 2
        Me.signUpButton.Text = "New Teacher?"
        Me.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.signUpButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(415, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(629, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kerugoya Municipality Boarding Primary School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(541, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "School Management Information System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(181, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1107, 546)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(1168, 655)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'adminButton
        '
        Me.adminButton.Location = New System.Drawing.Point(24, 211)
        Me.adminButton.Name = "adminButton"
        Me.adminButton.Size = New System.Drawing.Size(90, 23)
        Me.adminButton.TabIndex = 3
        Me.adminButton.Text = "Administrator"
        Me.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adminButton.UseVisualStyleBackColor = True
        '
        'welcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 690)
        Me.Controls.Add(Me.adminButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signUpButton)
        Me.Controls.Add(Me.loginButton)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "welcomeForm"
        Me.Text = "Welcome to KMPBS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginButton As Button
    Friend WithEvents signUpButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents adminButton As Button
End Class
