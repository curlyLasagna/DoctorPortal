<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login_form
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.signIn_button = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username_TextBox = New System.Windows.Forms.TextBox()
        Me.showPassword_chkbox = New System.Windows.Forms.CheckBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, -1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 194)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(173, 86)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'signIn_button
        '
        Me.signIn_button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.signIn_button.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.signIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signIn_button.Location = New System.Drawing.Point(174, 145)
        Me.signIn_button.Name = "signIn_button"
        Me.signIn_button.Size = New System.Drawing.Size(94, 23)
        Me.signIn_button.TabIndex = 4
        Me.signIn_button.Text = "S&ign in"
        Me.signIn_button.UseVisualStyleBackColor = False
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PasswordLabel.Location = New System.Drawing.Point(171, 66)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.Cancel.FlatAppearance.BorderSize = 2
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Location = New System.Drawing.Point(297, 145)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "E&xit"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UsernameLabel.Location = New System.Drawing.Point(171, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Email"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(297, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Trouble signing in?"
        '
        'username_TextBox
        '
        Me.username_TextBox.Location = New System.Drawing.Point(173, 29)
        Me.username_TextBox.Name = "username_TextBox"
        Me.username_TextBox.Size = New System.Drawing.Size(220, 20)
        Me.username_TextBox.TabIndex = 1
        '
        'showPassword_chkbox
        '
        Me.showPassword_chkbox.AutoSize = True
        Me.showPassword_chkbox.Location = New System.Drawing.Point(174, 112)
        Me.showPassword_chkbox.Name = "showPassword_chkbox"
        Me.showPassword_chkbox.Size = New System.Drawing.Size(101, 17)
        Me.showPassword_chkbox.TabIndex = 7
        Me.showPassword_chkbox.Text = "Show password"
        Me.showPassword_chkbox.UseVisualStyleBackColor = True
        '
        'login_form
        '
        Me.AcceptButton = Me.signIn_button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 190)
        Me.Controls.Add(Me.showPassword_chkbox)
        Me.Controls.Add(Me.username_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.signIn_button)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login_form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents signIn_button As Button
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents username_TextBox As TextBox
    Friend WithEvents showPassword_chkbox As CheckBox
End Class
