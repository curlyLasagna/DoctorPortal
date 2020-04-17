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
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.timeTextBox = New System.Windows.Forms.TextBox()
        Me.bpTextBox = New System.Windows.Forms.TextBox()
        Me.bgTextBox = New System.Windows.Forms.TextBox()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dateLabel.Location = New System.Drawing.Point(30, 17)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(33, 13)
        Me.dateLabel.TabIndex = 0
        Me.dateLabel.Text = "Date:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.timeLabel.Location = New System.Drawing.Point(29, 73)
        Me.timeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(33, 13)
        Me.timeLabel.TabIndex = 1
        Me.timeLabel.Text = "Time:"
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.weightLabel.Location = New System.Drawing.Point(29, 271)
        Me.weightLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(47, 13)
        Me.weightLabel.TabIndex = 4
        Me.weightLabel.Text = "Weight: "
        '
        'bgLabel
        '
        Me.bgLabel.AutoSize = True
        Me.bgLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.bgLabel.Location = New System.Drawing.Point(30, 199)
        Me.bgLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.bgLabel.Name = "bgLabel"
        Me.bgLabel.Size = New System.Drawing.Size(79, 13)
        Me.bgLabel.TabIndex = 5
        Me.bgLabel.Text = "Blood Glucose:"
        '
        'bpLabel
        '
        Me.bpLabel.AutoSize = True
        Me.bpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.bpLabel.Location = New System.Drawing.Point(30, 137)
        Me.bpLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.bpLabel.Name = "bpLabel"
        Me.bpLabel.Size = New System.Drawing.Size(81, 13)
        Me.bpLabel.TabIndex = 6
        Me.bpLabel.Text = "Blood Pressure:"
        '
        'dateTextBox
        '
        Me.dateTextBox.Location = New System.Drawing.Point(177, 17)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(136, 29)
        Me.dateTextBox.TabIndex = 7
        '
        'timeTextBox
        '
        Me.timeTextBox.Location = New System.Drawing.Point(177, 73)
        Me.timeTextBox.Name = "timeTextBox"
        Me.timeTextBox.Size = New System.Drawing.Size(136, 29)
        Me.timeTextBox.TabIndex = 8
        '
        'bpTextBox
        '
        Me.bpTextBox.Location = New System.Drawing.Point(177, 137)
        Me.bpTextBox.Name = "bpTextBox"
        Me.bpTextBox.Size = New System.Drawing.Size(136, 29)
        Me.bpTextBox.TabIndex = 9
        '
        'bgTextBox
        '
        Me.bgTextBox.Location = New System.Drawing.Point(177, 199)
        Me.bgTextBox.Name = "bgTextBox"
        Me.bgTextBox.Size = New System.Drawing.Size(136, 29)
        Me.bgTextBox.TabIndex = 10
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(176, 271)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(136, 29)
        Me.weightTextBox.TabIndex = 11
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.submitButton.Location = New System.Drawing.Point(361, 323)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(135, 42)
        Me.submitButton.TabIndex = 12
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.previousBtn.Location = New System.Drawing.Point(11, 345)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 13
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'Home_Monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(508, 377)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.bgTextBox)
        Me.Controls.Add(Me.bpTextBox)
        Me.Controls.Add(Me.timeTextBox)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.bpLabel)
        Me.Controls.Add(Me.bgLabel)
        Me.Controls.Add(Me.weightLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Home_Monitoring"
        Me.Text = "Home Monitoring"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateLabel As Label
    Friend WithEvents timeLabel As Label
    Friend WithEvents weightLabel As Label
    Friend WithEvents bgLabel As Label
    Friend WithEvents bpLabel As Label
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents timeTextBox As TextBox
    Friend WithEvents bpTextBox As TextBox
    Friend WithEvents bgTextBox As TextBox
    Friend WithEvents weightTextBox As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents previousBtn As Button
End Class
