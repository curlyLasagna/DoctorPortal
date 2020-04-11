<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historicalBill
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
        Me.historicalBillViewer = New System.Windows.Forms.Label()
        Me.reciptListBox = New System.Windows.Forms.ListBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.doctorName = New System.Windows.Forms.Label()
        Me.reciptNumber = New System.Windows.Forms.Label()
        Me.amountLable = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'historicalBillViewer
        '
        Me.historicalBillViewer.AutoSize = True
        Me.historicalBillViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.historicalBillViewer.Location = New System.Drawing.Point(136, 18)
        Me.historicalBillViewer.Name = "historicalBillViewer"
        Me.historicalBillViewer.Size = New System.Drawing.Size(120, 48)
        Me.historicalBillViewer.TabIndex = 0
        Me.historicalBillViewer.Text = "Historical Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Viewer"
        '
        'reciptListBox
        '
        Me.reciptListBox.FormattingEnabled = True
        Me.reciptListBox.Items.AddRange(New Object() {"04/07/2020      Bechie                RC56813A3                   $15,897.36"})
        Me.reciptListBox.Location = New System.Drawing.Point(23, 111)
        Me.reciptListBox.Name = "reciptListBox"
        Me.reciptListBox.Size = New System.Drawing.Size(344, 264)
        Me.reciptListBox.TabIndex = 1
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dateLabel.Location = New System.Drawing.Point(40, 95)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(30, 13)
        Me.dateLabel.TabIndex = 2
        Me.dateLabel.Text = "Date"
        '
        'doctorName
        '
        Me.doctorName.AutoSize = True
        Me.doctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.doctorName.Location = New System.Drawing.Point(107, 95)
        Me.doctorName.Name = "doctorName"
        Me.doctorName.Size = New System.Drawing.Size(39, 13)
        Me.doctorName.TabIndex = 3
        Me.doctorName.Text = "Doctor"
        '
        'reciptNumber
        '
        Me.reciptNumber.AutoSize = True
        Me.reciptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.reciptNumber.Location = New System.Drawing.Point(175, 95)
        Me.reciptNumber.Name = "reciptNumber"
        Me.reciptNumber.Size = New System.Drawing.Size(78, 13)
        Me.reciptNumber.TabIndex = 4
        Me.reciptNumber.Text = "Recipt Number"
        '
        'amountLable
        '
        Me.amountLable.AutoSize = True
        Me.amountLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.amountLable.Location = New System.Drawing.Point(307, 95)
        Me.amountLable.Name = "amountLable"
        Me.amountLable.Size = New System.Drawing.Size(43, 13)
        Me.amountLable.TabIndex = 5
        Me.amountLable.Text = "Amount"
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(11, 394)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 6
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'historicalBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 426)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.amountLable)
        Me.Controls.Add(Me.reciptNumber)
        Me.Controls.Add(Me.doctorName)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.reciptListBox)
        Me.Controls.Add(Me.historicalBillViewer)
        Me.Name = "historicalBill"
        Me.Text = "Historical Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents historicalBillViewer As Label
    Friend WithEvents reciptListBox As ListBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents doctorName As Label
    Friend WithEvents reciptNumber As Label
    Friend WithEvents amountLable As Label
    Friend WithEvents previousBtn As Button
End Class
