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
        Me.openReleaseFormButton = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'openReleaseFormButton
        '
        Me.openReleaseFormButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.openReleaseFormButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.openReleaseFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openReleaseFormButton.Location = New System.Drawing.Point(297, 173)
        Me.openReleaseFormButton.Margin = New System.Windows.Forms.Padding(2)
        Me.openReleaseFormButton.Name = "openReleaseFormButton"
        Me.openReleaseFormButton.Size = New System.Drawing.Size(136, 52)
        Me.openReleaseFormButton.TabIndex = 1
        Me.openReleaseFormButton.Text = "Open Medical Release Form"
        Me.openReleaseFormButton.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.Location = New System.Drawing.Point(130, 173)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(136, 52)
        Me.previousBtn.TabIndex = 5
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 135)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MedRecordRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(583, 254)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.openReleaseFormButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MedRecordRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Release Request"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openReleaseFormButton As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents Label1 As Label
End Class
