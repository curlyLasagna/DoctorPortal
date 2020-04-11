<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedRecordRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedRecordRequest))
        Me.MedicalReleaseInfoText = New System.Windows.Forms.RichTextBox()
        Me.openReleaseFormButton = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MedicalReleaseInfoText
        '
        Me.MedicalReleaseInfoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MedicalReleaseInfoText.Location = New System.Drawing.Point(35, 39)
        Me.MedicalReleaseInfoText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MedicalReleaseInfoText.Name = "MedicalReleaseInfoText"
        Me.MedicalReleaseInfoText.Size = New System.Drawing.Size(542, 65)
        Me.MedicalReleaseInfoText.TabIndex = 0
        Me.MedicalReleaseInfoText.Text = resources.GetString("MedicalReleaseInfoText.Text")
        '
        'openReleaseFormButton
        '
        Me.openReleaseFormButton.Location = New System.Drawing.Point(101, 176)
        Me.openReleaseFormButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.openReleaseFormButton.Name = "openReleaseFormButton"
        Me.openReleaseFormButton.Size = New System.Drawing.Size(369, 49)
        Me.openReleaseFormButton.TabIndex = 1
        Me.openReleaseFormButton.Text = "Open Medical Release Form"
        Me.openReleaseFormButton.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(2, 232)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 5
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'MedRecordRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 254)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.openReleaseFormButton)
        Me.Controls.Add(Me.MedicalReleaseInfoText)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MedRecordRequest"
        Me.Text = "Medical Release Request"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MedicalReleaseInfoText As RichTextBox
    Friend WithEvents openReleaseFormButton As Button
    Friend WithEvents previousBtn As Button
End Class
