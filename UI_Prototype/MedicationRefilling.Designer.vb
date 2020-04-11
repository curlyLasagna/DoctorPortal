<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicationRefilling
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
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.amountLable = New System.Windows.Forms.Label()
        Me.reciptNumber = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.medicationListBox = New System.Windows.Forms.ListBox()
        Me.medicationList = New System.Windows.Forms.Label()
        Me.pharmacy = New System.Windows.Forms.Label()
        Me.doctor = New System.Windows.Forms.Label()
        Me.refill = New System.Windows.Forms.Label()
        Me.directions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(2, 632)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(92, 32)
        Me.previousBtn.TabIndex = 12
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'amountLable
        '
        Me.amountLable.AutoSize = True
        Me.amountLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.amountLable.Location = New System.Drawing.Point(220, 151)
        Me.amountLable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amountLable.Name = "amountLable"
        Me.amountLable.Size = New System.Drawing.Size(65, 20)
        Me.amountLable.TabIndex = 11
        Me.amountLable.Text = "Dosage"
        '
        'reciptNumber
        '
        Me.reciptNumber.AutoSize = True
        Me.reciptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.reciptNumber.Location = New System.Drawing.Point(333, 151)
        Me.reciptNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.reciptNumber.Name = "reciptNumber"
        Me.reciptNumber.Size = New System.Drawing.Size(33, 20)
        Me.reciptNumber.TabIndex = 10
        Me.reciptNumber.Text = "Qty"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dateLabel.Location = New System.Drawing.Point(18, 151)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(55, 20)
        Me.dateLabel.TabIndex = 8
        Me.dateLabel.Text = "Name "
        '
        'medicationListBox
        '
        Me.medicationListBox.FormattingEnabled = True
        Me.medicationListBox.ItemHeight = 20
        Me.medicationListBox.Items.AddRange(New Object() {"Ciprofloxacin                         100mg              30             5        " &
                "         Bechie                                CVS", "", "Pantoprazole                          40mg            120            10          " &
                "       Lewis                                  CVS"})
        Me.medicationListBox.Location = New System.Drawing.Point(18, 175)
        Me.medicationListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.medicationListBox.Name = "medicationListBox"
        Me.medicationListBox.Size = New System.Drawing.Size(770, 404)
        Me.medicationListBox.TabIndex = 7
        '
        'medicationList
        '
        Me.medicationList.AutoSize = True
        Me.medicationList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.medicationList.Location = New System.Drawing.Point(274, 14)
        Me.medicationList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.medicationList.Name = "medicationList"
        Me.medicationList.Size = New System.Drawing.Size(213, 32)
        Me.medicationList.TabIndex = 13
        Me.medicationList.Text = "Medication List "
        '
        'pharmacy
        '
        Me.pharmacy.AutoSize = True
        Me.pharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.pharmacy.Location = New System.Drawing.Point(669, 151)
        Me.pharmacy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pharmacy.Name = "pharmacy"
        Me.pharmacy.Size = New System.Drawing.Size(83, 20)
        Me.pharmacy.TabIndex = 14
        Me.pharmacy.Text = "Pharmacy "
        '
        'doctor
        '
        Me.doctor.AutoSize = True
        Me.doctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.doctor.Location = New System.Drawing.Point(482, 131)
        Me.doctor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(87, 40)
        Me.doctor.TabIndex = 15
        Me.doctor.Text = "Prescribing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Doctor"
        '
        'refill
        '
        Me.refill.AutoSize = True
        Me.refill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.refill.Location = New System.Drawing.Point(399, 131)
        Me.refill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.refill.Name = "refill"
        Me.refill.Size = New System.Drawing.Size(52, 40)
        Me.refill.TabIndex = 16
        Me.refill.Text = "Refills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Left"
        '
        'directions
        '
        Me.directions.AutoSize = True
        Me.directions.Location = New System.Drawing.Point(141, 82)
        Me.directions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.directions.Name = "directions"
        Me.directions.Size = New System.Drawing.Size(502, 20)
        Me.directions.TabIndex = 17
        Me.directions.Text = "Doubel left click on the medication you want to refill from the list below "
        '
        'MedicationRefilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 668)
        Me.Controls.Add(Me.directions)
        Me.Controls.Add(Me.refill)
        Me.Controls.Add(Me.doctor)
        Me.Controls.Add(Me.pharmacy)
        Me.Controls.Add(Me.medicationList)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.amountLable)
        Me.Controls.Add(Me.reciptNumber)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.medicationListBox)
        Me.Name = "MedicationRefilling"
        Me.Text = "Medication Refilling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents previousBtn As Button
    Friend WithEvents amountLable As Label
    Friend WithEvents reciptNumber As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents medicationListBox As ListBox
    Friend WithEvents medicationList As Label

    Private Sub dateLabel_Click(sender As Object, e As EventArgs) Handles dateLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles medicationList.Click

    End Sub

    Friend WithEvents pharmacy As Label
    Friend WithEvents doctor As Label

    Private Sub reciptNumber_Click(sender As Object, e As EventArgs) Handles reciptNumber.Click

    End Sub

    Friend WithEvents refill As Label
    Friend WithEvents directions As Label
End Class
