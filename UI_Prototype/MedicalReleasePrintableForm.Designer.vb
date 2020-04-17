<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicalReleasePrintableForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicalReleasePrintableForm))
        Me.ptNameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.releaseToLabel = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.emptyTxtBox1 = New System.Windows.Forms.TextBox()
        Me.emptyTxtBox2 = New System.Windows.Forms.TextBox()
        Me.emptyTxtBox3 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.submit_Button = New System.Windows.Forms.Button()
        Me.cancel_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ptNameLabel
        '
        Me.ptNameLabel.AutoSize = True
        Me.ptNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ptNameLabel.Location = New System.Drawing.Point(11, 19)
        Me.ptNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ptNameLabel.Name = "ptNameLabel"
        Me.ptNameLabel.Size = New System.Drawing.Size(101, 18)
        Me.ptNameLabel.TabIndex = 0
        Me.ptNameLabel.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(11, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(11, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Patient Signature:"
        '
        'releaseToLabel
        '
        Me.releaseToLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.releaseToLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.releaseToLabel.Location = New System.Drawing.Point(11, 70)
        Me.releaseToLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.releaseToLabel.Name = "releaseToLabel"
        Me.releaseToLabel.Size = New System.Drawing.Size(121, 49)
        Me.releaseToLabel.TabIndex = 4
        Me.releaseToLabel.Text = "Release Medical Records To:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.RichTextBox2.Location = New System.Drawing.Point(14, 214)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(500, 160)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'emptyTxtBox1
        '
        Me.emptyTxtBox1.Location = New System.Drawing.Point(190, 19)
        Me.emptyTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.emptyTxtBox1.Name = "emptyTxtBox1"
        Me.emptyTxtBox1.Size = New System.Drawing.Size(324, 20)
        Me.emptyTxtBox1.TabIndex = 7
        '
        'emptyTxtBox2
        '
        Me.emptyTxtBox2.Location = New System.Drawing.Point(190, 141)
        Me.emptyTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.emptyTxtBox2.Name = "emptyTxtBox2"
        Me.emptyTxtBox2.Size = New System.Drawing.Size(324, 20)
        Me.emptyTxtBox2.TabIndex = 8
        '
        'emptyTxtBox3
        '
        Me.emptyTxtBox3.Location = New System.Drawing.Point(190, 176)
        Me.emptyTxtBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.emptyTxtBox3.Name = "emptyTxtBox3"
        Me.emptyTxtBox3.Size = New System.Drawing.Size(324, 20)
        Me.emptyTxtBox3.TabIndex = 9
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(190, 70)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(324, 51)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'submit_Button
        '
        Me.submit_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.submit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_Button.Location = New System.Drawing.Point(382, 386)
        Me.submit_Button.Name = "submit_Button"
        Me.submit_Button.Size = New System.Drawing.Size(132, 32)
        Me.submit_Button.TabIndex = 11
        Me.submit_Button.Text = "Print"
        Me.submit_Button.UseVisualStyleBackColor = False
        '
        'cancel_Button
        '
        Me.cancel_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_Button.Location = New System.Drawing.Point(14, 386)
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(132, 31)
        Me.cancel_Button.TabIndex = 12
        Me.cancel_Button.Text = "Cancel"
        Me.cancel_Button.UseVisualStyleBackColor = False
        '
        'MedicalReleasePrintableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(538, 430)
        Me.Controls.Add(Me.cancel_Button)
        Me.Controls.Add(Me.submit_Button)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.emptyTxtBox3)
        Me.Controls.Add(Me.emptyTxtBox2)
        Me.Controls.Add(Me.emptyTxtBox1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.releaseToLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ptNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MedicalReleasePrintableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical Release Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents releaseToLabel As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents emptyTxtBox1 As TextBox
    Friend WithEvents emptyTxtBox2 As TextBox
    Friend WithEvents emptyTxtBox3 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents submit_Button As Button
    Friend WithEvents cancel_Button As Button
End Class
