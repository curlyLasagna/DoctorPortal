<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Monitoring
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
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.weightLabel = New System.Windows.Forms.Label()
        Me.bgLabel = New System.Windows.Forms.Label()
        Me.bpLabel = New System.Windows.Forms.Label()
        Me.bpTextBox = New System.Windows.Forms.TextBox()
        Me.bgTextBox = New System.Windows.Forms.TextBox()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateLabel.Location = New System.Drawing.Point(2, 20)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(45, 16)
        Me.dateLabel.TabIndex = 0
        Me.dateLabel.Text = "Date:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.timeLabel.Location = New System.Drawing.Point(297, 20)
        Me.timeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(47, 16)
        Me.timeLabel.TabIndex = 1
        Me.timeLabel.Text = "Time:"
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.weightLabel.Location = New System.Drawing.Point(81, 144)
        Me.weightLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(64, 16)
        Me.weightLabel.TabIndex = 4
        Me.weightLabel.Text = "Weight: "
        '
        'bgLabel
        '
        Me.bgLabel.AutoSize = True
        Me.bgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bgLabel.Location = New System.Drawing.Point(81, 108)
        Me.bgLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.bgLabel.Name = "bgLabel"
        Me.bgLabel.Size = New System.Drawing.Size(114, 16)
        Me.bgLabel.TabIndex = 5
        Me.bgLabel.Text = "Blood Glucose:"
        '
        'bpLabel
        '
        Me.bpLabel.AutoSize = True
        Me.bpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bpLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bpLabel.Location = New System.Drawing.Point(81, 71)
        Me.bpLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.bpLabel.Name = "bpLabel"
        Me.bpLabel.Size = New System.Drawing.Size(119, 16)
        Me.bpLabel.TabIndex = 6
        Me.bpLabel.Text = "Blood Pressure:"
        '
        'bpTextBox
        '
        Me.bpTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bpTextBox.Location = New System.Drawing.Point(200, 65)
        Me.bpTextBox.Name = "bpTextBox"
        Me.bpTextBox.Size = New System.Drawing.Size(173, 24)
        Me.bpTextBox.TabIndex = 9
        '
        'bgTextBox
        '
        Me.bgTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bgTextBox.Location = New System.Drawing.Point(200, 102)
        Me.bgTextBox.Name = "bgTextBox"
        Me.bgTextBox.Size = New System.Drawing.Size(173, 24)
        Me.bgTextBox.TabIndex = 10
        '
        'weightTextBox
        '
        Me.weightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightTextBox.Location = New System.Drawing.Point(200, 145)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(173, 24)
        Me.weightTextBox.TabIndex = 11
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(300, 194)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(99, 34)
        Me.submitButton.TabIndex = 12
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.Location = New System.Drawing.Point(84, 194)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(99, 34)
        Me.previousBtn.TabIndex = 13
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(51, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 22)
        Me.DateTimePicker1.TabIndex = 14
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(348, 11)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(125, 22)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Home_Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(489, 250)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.bgTextBox)
        Me.Controls.Add(Me.bpTextBox)
        Me.Controls.Add(Me.bpLabel)
        Me.Controls.Add(Me.bgLabel)
        Me.Controls.Add(Me.weightLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Home_Monitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Monitoring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents weightLabel As Label
    Friend WithEvents bgLabel As Label
    Friend WithEvents bpLabel As Label
    Friend WithEvents bpTextBox As TextBox
    Friend WithEvents bgTextBox As TextBox
    Friend WithEvents weightTextBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
