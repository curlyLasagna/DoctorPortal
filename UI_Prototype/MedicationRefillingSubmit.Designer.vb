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
        Me.yesBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.yesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesBtn.Location = New System.Drawing.Point(56, 68)
        Me.yesBtn.Name = "yesBtn"
        Me.yesBtn.Size = New System.Drawing.Size(75, 23)
        Me.yesBtn.TabIndex = 0
        Me.yesBtn.Text = "Yes"
        Me.yesBtn.UseVisualStyleBackColor = False
        '
        'areYouSureLabel
        '
        Me.areYouSureLabel.AutoSize = True
        Me.areYouSureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.areYouSureLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.areYouSureLabel.Location = New System.Drawing.Point(21, 31)
        Me.areYouSureLabel.Name = "areYouSureLabel"
        Me.areYouSureLabel.Size = New System.Drawing.Size(299, 18)
        Me.areYouSureLabel.TabIndex = 1
        Me.areYouSureLabel.Text = "Are you sure you want to refill Ciprofloxacin?"
        '
        'noBtn
        '
        Me.noBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.noBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noBtn.Location = New System.Drawing.Point(215, 68)
        Me.noBtn.Name = "noBtn"
        Me.noBtn.Size = New System.Drawing.Size(75, 23)
        Me.noBtn.TabIndex = 2
        Me.noBtn.Text = "No"
        Me.noBtn.UseVisualStyleBackColor = False
        '
        'MedicationRefillingSubmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(359, 117)
        Me.Controls.Add(Me.noBtn)
        Me.Controls.Add(Me.areYouSureLabel)
        Me.Controls.Add(Me.yesBtn)
        Me.Name = "MedicationRefillingSubmit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medication Refilling Submit"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yesBtn As Button
    Friend WithEvents areYouSureLabel As Label
    Friend WithEvents noBtn As Button
End Class
