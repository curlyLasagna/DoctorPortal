<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicationRefillingSubmit
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
        Me.yesBtn = New System.Windows.Forms.Button()
        Me.areYouSureLabel = New System.Windows.Forms.Label()
        Me.noBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'yesBtn
        '
        Me.yesBtn.Location = New System.Drawing.Point(103, 68)
        Me.yesBtn.Name = "yesBtn"
        Me.yesBtn.Size = New System.Drawing.Size(75, 23)
        Me.yesBtn.TabIndex = 0
        Me.yesBtn.Text = "Yes"
        Me.yesBtn.UseVisualStyleBackColor = True
        '
        'areYouSureLabel
        '
        Me.areYouSureLabel.AutoSize = True
        Me.areYouSureLabel.Location = New System.Drawing.Point(77, 35)
        Me.areYouSureLabel.Name = "areYouSureLabel"
        Me.areYouSureLabel.Size = New System.Drawing.Size(214, 13)
        Me.areYouSureLabel.TabIndex = 1
        Me.areYouSureLabel.Text = "Are you sure you want to refill Ciprofloxacin?"
        '
        'noBtn
        '
        Me.noBtn.Location = New System.Drawing.Point(184, 68)
        Me.noBtn.Name = "noBtn"
        Me.noBtn.Size = New System.Drawing.Size(75, 23)
        Me.noBtn.TabIndex = 2
        Me.noBtn.Text = "No"
        Me.noBtn.UseVisualStyleBackColor = True
        '
        'MedicationRefillingSubmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(359, 117)
        Me.Controls.Add(Me.noBtn)
        Me.Controls.Add(Me.areYouSureLabel)
        Me.Controls.Add(Me.yesBtn)
        Me.Name = "MedicationRefillingSubmit"
        Me.Text = "Medication Refilling Submit"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yesBtn As Button
    Friend WithEvents areYouSureLabel As Label
    Friend WithEvents noBtn As Button
End Class
