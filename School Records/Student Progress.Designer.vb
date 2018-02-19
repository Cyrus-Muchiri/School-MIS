<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Progress
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.graphChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.progressButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.openerLabel4 = New System.Windows.Forms.Label()
        Me.visitingLabel5 = New System.Windows.Forms.Label()
        Me.catLabel6 = New System.Windows.Forms.Label()
        Me.endTermLabel7 = New System.Windows.Forms.Label()
        Me.endtermLabel = New System.Windows.Forms.Label()
        Me.catLabel = New System.Windows.Forms.Label()
        Me.visitingLabel = New System.Windows.Forms.Label()
        Me.openerLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.regNoTextBox = New System.Windows.Forms.TextBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.graphChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'graphChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.graphChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.graphChart.Legends.Add(Legend2)
        Me.graphChart.Location = New System.Drawing.Point(372, 92)
        Me.graphChart.Name = "graphChart"
        Me.graphChart.Size = New System.Drawing.Size(605, 353)
        Me.graphChart.TabIndex = 0
        Me.graphChart.Text = "Chart1"
        '
        'progressButton
        '
        Me.progressButton.Location = New System.Drawing.Point(85, 329)
        Me.progressButton.Name = "progressButton"
        Me.progressButton.Size = New System.Drawing.Size(85, 23)
        Me.progressButton.TabIndex = 1
        Me.progressButton.Text = "View Progess"
        Me.progressButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(259, 73)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(64, 23)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student Progress"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reg No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name :"
        '
        'openerLabel4
        '
        Me.openerLabel4.AutoSize = True
        Me.openerLabel4.Location = New System.Drawing.Point(82, 178)
        Me.openerLabel4.Name = "openerLabel4"
        Me.openerLabel4.Size = New System.Drawing.Size(48, 13)
        Me.openerLabel4.TabIndex = 6
        Me.openerLabel4.Text = "Opener :"
        '
        'visitingLabel5
        '
        Me.visitingLabel5.AutoSize = True
        Me.visitingLabel5.Location = New System.Drawing.Point(82, 216)
        Me.visitingLabel5.Name = "visitingLabel5"
        Me.visitingLabel5.Size = New System.Drawing.Size(46, 13)
        Me.visitingLabel5.TabIndex = 7
        Me.visitingLabel5.Text = "Visiting :"
        '
        'catLabel6
        '
        Me.catLabel6.AutoSize = True
        Me.catLabel6.Location = New System.Drawing.Point(82, 252)
        Me.catLabel6.Name = "catLabel6"
        Me.catLabel6.Size = New System.Drawing.Size(29, 13)
        Me.catLabel6.TabIndex = 8
        Me.catLabel6.Text = "Cat :"
        '
        'endTermLabel7
        '
        Me.endTermLabel7.AutoSize = True
        Me.endTermLabel7.Location = New System.Drawing.Point(82, 286)
        Me.endTermLabel7.Name = "endTermLabel7"
        Me.endTermLabel7.Size = New System.Drawing.Size(59, 13)
        Me.endTermLabel7.TabIndex = 9
        Me.endTermLabel7.Text = "End Term :"
        '
        'endtermLabel
        '
        Me.endtermLabel.AutoSize = True
        Me.endtermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endtermLabel.Location = New System.Drawing.Point(187, 286)
        Me.endtermLabel.Name = "endtermLabel"
        Me.endtermLabel.Size = New System.Drawing.Size(0, 16)
        Me.endtermLabel.TabIndex = 14
        '
        'catLabel
        '
        Me.catLabel.AutoSize = True
        Me.catLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catLabel.Location = New System.Drawing.Point(187, 252)
        Me.catLabel.Name = "catLabel"
        Me.catLabel.Size = New System.Drawing.Size(0, 16)
        Me.catLabel.TabIndex = 13
        '
        'visitingLabel
        '
        Me.visitingLabel.AutoSize = True
        Me.visitingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitingLabel.Location = New System.Drawing.Point(187, 216)
        Me.visitingLabel.Name = "visitingLabel"
        Me.visitingLabel.Size = New System.Drawing.Size(0, 16)
        Me.visitingLabel.TabIndex = 12
        '
        'openerLabel
        '
        Me.openerLabel.AutoSize = True
        Me.openerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openerLabel.Location = New System.Drawing.Point(187, 178)
        Me.openerLabel.Name = "openerLabel"
        Me.openerLabel.Size = New System.Drawing.Size(0, 16)
        Me.openerLabel.TabIndex = 11
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(187, 136)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 16)
        Me.nameLabel.TabIndex = 10
        '
        'regNoTextBox
        '
        Me.regNoTextBox.Location = New System.Drawing.Point(132, 76)
        Me.regNoTextBox.Name = "regNoTextBox"
        Me.regNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.regNoTextBox.TabIndex = 15
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(902, 516)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 16
        Me.exitButton.Text = "exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Graph"
        '
        'Student_Progress
        '
        Me.AcceptButton = Me.searchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(1023, 551)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.regNoTextBox)
        Me.Controls.Add(Me.endtermLabel)
        Me.Controls.Add(Me.catLabel)
        Me.Controls.Add(Me.visitingLabel)
        Me.Controls.Add(Me.openerLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.endTermLabel7)
        Me.Controls.Add(Me.catLabel6)
        Me.Controls.Add(Me.visitingLabel5)
        Me.Controls.Add(Me.openerLabel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.progressButton)
        Me.Controls.Add(Me.graphChart)
        Me.Name = "Student_Progress"
        Me.Text = "Student_Progress"
        CType(Me.graphChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents graphChart As DataVisualization.Charting.Chart
    Friend WithEvents progressButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents openerLabel4 As Label
    Friend WithEvents visitingLabel5 As Label
    Friend WithEvents catLabel6 As Label
    Friend WithEvents endTermLabel7 As Label
    Friend WithEvents endtermLabel As Label
    Friend WithEvents catLabel As Label
    Friend WithEvents visitingLabel As Label
    Friend WithEvents openerLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents regNoTextBox As TextBox
    Friend WithEvents exitButton As Button
    Friend WithEvents Label8 As Label
End Class
