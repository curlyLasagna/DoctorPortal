<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Thursday, April 22, 2020", "Saturday, April 25, 2020", "10:30 am", "Dr. Mabuse", "Pending"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "Friday, May 22, 2020", "Thursday, May 28, 2020", "1:00 pm", "Dr. Norbauer", "Accepted"}, -1)
        Me.AboutMe_Button = New System.Windows.Forms.Button()
        Me.med_record = New System.Windows.Forms.Button()
        Me.prescription_btn = New System.Windows.Forms.Button()
        Me.homeMonitoring_btn = New System.Windows.Forms.Button()
        Me.billing_btn = New System.Windows.Forms.Button()
        Me.AboutMeSubMenu = New System.Windows.Forms.Panel()
        Me.client_info = New System.Windows.Forms.Label()
        Me.ins_info = New System.Windows.Forms.Label()
        Me.phar_info = New System.Windows.Forms.Label()
        Me.med_history_label = New System.Windows.Forms.Label()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.appointment_label = New System.Windows.Forms.Label()
        Me.add_apt_btn = New System.Windows.Forms.Button()
        Me.delete_appt_btn = New System.Windows.Forms.Button()
        Me.appt_listView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.currentBill_label = New System.Windows.Forms.Label()
        Me.historicalBill_label = New System.Windows.Forms.Label()
        Me.billing_panel = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AboutMeSubMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.billing_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AboutMe_Button
        '
        Me.AboutMe_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AboutMe_Button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AboutMe_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.AboutMe_Button.FlatAppearance.BorderSize = 3
        Me.AboutMe_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutMe_Button.Location = New System.Drawing.Point(716, 22)
        Me.AboutMe_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.AboutMe_Button.Name = "AboutMe_Button"
        Me.AboutMe_Button.Size = New System.Drawing.Size(117, 30)
        Me.AboutMe_Button.TabIndex = 3
        Me.AboutMe_Button.Text = "About me ( ͡❛ ͜ʖ ͡❛)"
        Me.AboutMe_Button.UseVisualStyleBackColor = False
        '
        'med_record
        '
        Me.med_record.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.med_record.BackColor = System.Drawing.Color.WhiteSmoke
        Me.med_record.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.med_record.FlatAppearance.BorderSize = 3
        Me.med_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.med_record.Location = New System.Drawing.Point(207, 22)
        Me.med_record.Margin = New System.Windows.Forms.Padding(2)
        Me.med_record.Name = "med_record"
        Me.med_record.Size = New System.Drawing.Size(117, 30)
        Me.med_record.TabIndex = 5
        Me.med_record.Text = "Medical Record 📚" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.med_record.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.med_record.UseVisualStyleBackColor = False
        '
        'prescription_btn
        '
        Me.prescription_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prescription_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.prescription_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.prescription_btn.FlatAppearance.BorderSize = 3
        Me.prescription_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prescription_btn.Location = New System.Drawing.Point(332, 22)
        Me.prescription_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.prescription_btn.Name = "prescription_btn"
        Me.prescription_btn.Size = New System.Drawing.Size(117, 30)
        Me.prescription_btn.TabIndex = 6
        Me.prescription_btn.Text = "Prescriptions 💊"
        Me.prescription_btn.UseVisualStyleBackColor = False
        '
        'homeMonitoring_btn
        '
        Me.homeMonitoring_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.homeMonitoring_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.homeMonitoring_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.homeMonitoring_btn.FlatAppearance.BorderSize = 3
        Me.homeMonitoring_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeMonitoring_btn.Location = New System.Drawing.Point(458, 22)
        Me.homeMonitoring_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.homeMonitoring_btn.Name = "homeMonitoring_btn"
        Me.homeMonitoring_btn.Size = New System.Drawing.Size(117, 30)
        Me.homeMonitoring_btn.TabIndex = 7
        Me.homeMonitoring_btn.Text = "Home Monitoring 💻"
        Me.homeMonitoring_btn.UseVisualStyleBackColor = False
        '
        'billing_btn
        '
        Me.billing_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.billing_btn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.billing_btn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.billing_btn.FlatAppearance.BorderSize = 3
        Me.billing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.billing_btn.Location = New System.Drawing.Point(586, 22)
        Me.billing_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.billing_btn.Name = "billing_btn"
        Me.billing_btn.Size = New System.Drawing.Size(117, 30)
        Me.billing_btn.TabIndex = 8
        Me.billing_btn.Text = "Billing 💲"
        Me.billing_btn.UseVisualStyleBackColor = False
        '
        'AboutMeSubMenu
        '
        Me.AboutMeSubMenu.BackColor = System.Drawing.Color.White
        Me.AboutMeSubMenu.Controls.Add(Me.client_info)
        Me.AboutMeSubMenu.Controls.Add(Me.ins_info)
        Me.AboutMeSubMenu.Controls.Add(Me.phar_info)
        Me.AboutMeSubMenu.Controls.Add(Me.med_history_label)
        Me.AboutMeSubMenu.Location = New System.Drawing.Point(716, 70)
        Me.AboutMeSubMenu.Name = "AboutMeSubMenu"
        Me.AboutMeSubMenu.Size = New System.Drawing.Size(126, 0)
        Me.AboutMeSubMenu.TabIndex = 11
        '
        'client_info
        '
        Me.client_info.AutoSize = True
        Me.client_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.client_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.client_info.Location = New System.Drawing.Point(3, 82)
        Me.client_info.Name = "client_info"
        Me.client_info.Size = New System.Drawing.Size(54, 13)
        Me.client_info.TabIndex = 3
        Me.client_info.Text = "Client Info"
        '
        'ins_info
        '
        Me.ins_info.AutoSize = True
        Me.ins_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ins_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_info.Location = New System.Drawing.Point(3, 56)
        Me.ins_info.Name = "ins_info"
        Me.ins_info.Size = New System.Drawing.Size(75, 13)
        Me.ins_info.TabIndex = 2
        Me.ins_info.Text = "Insurance Info"
        '
        'phar_info
        '
        Me.phar_info.AutoSize = True
        Me.phar_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.phar_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phar_info.Location = New System.Drawing.Point(3, 30)
        Me.phar_info.Name = "phar_info"
        Me.phar_info.Size = New System.Drawing.Size(75, 13)
        Me.phar_info.TabIndex = 1
        Me.phar_info.Text = "Pharmacy Info"
        '
        'med_history_label
        '
        Me.med_history_label.AutoSize = True
        Me.med_history_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.med_history_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.med_history_label.Location = New System.Drawing.Point(3, 4)
        Me.med_history_label.Name = "med_history_label"
        Me.med_history_label.Size = New System.Drawing.Size(79, 13)
        Me.med_history_label.TabIndex = 0
        Me.med_history_label.Text = "Medical History"
        '
        'exit_button
        '
        Me.exit_button.BackColor = System.Drawing.Color.WhiteSmoke
        Me.exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.exit_button.FlatAppearance.BorderSize = 3
        Me.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_button.Location = New System.Drawing.Point(622, 307)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(85, 30)
        Me.exit_button.TabIndex = 12
        Me.exit_button.Text = "Exit"
        Me.exit_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("DejaVu Sans Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Vindicator's Patient Portal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.79904!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.20096!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.prescription_btn, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AboutMe_Button, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.med_record, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.homeMonitoring_btn, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.billing_btn, 5, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, -2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(840, 74)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'appointment_label
        '
        Me.appointment_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.appointment_label.BackColor = System.Drawing.Color.RoyalBlue
        Me.appointment_label.Font = New System.Drawing.Font("DejaVu Sans Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appointment_label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.appointment_label.Location = New System.Drawing.Point(17, 91)
        Me.appointment_label.Name = "appointment_label"
        Me.appointment_label.Size = New System.Drawing.Size(501, 35)
        Me.appointment_label.TabIndex = 14
        Me.appointment_label.Text = "Upcoming appointments"
        Me.appointment_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'add_apt_btn
        '
        Me.add_apt_btn.BackColor = System.Drawing.Color.MidnightBlue
        Me.add_apt_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_apt_btn.FlatAppearance.BorderSize = 0
        Me.add_apt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_apt_btn.Font = New System.Drawing.Font("DejaVu Sans Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_apt_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.add_apt_btn.Location = New System.Drawing.Point(513, 91)
        Me.add_apt_btn.Name = "add_apt_btn"
        Me.add_apt_btn.Size = New System.Drawing.Size(194, 35)
        Me.add_apt_btn.TabIndex = 16
        Me.add_apt_btn.Text = "Request Appointment +"
        Me.add_apt_btn.UseVisualStyleBackColor = False
        '
        'delete_appt_btn
        '
        Me.delete_appt_btn.BackColor = System.Drawing.Color.DarkRed
        Me.delete_appt_btn.FlatAppearance.BorderSize = 0
        Me.delete_appt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete_appt_btn.Font = New System.Drawing.Font("DejaVu Sans Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_appt_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.delete_appt_btn.Location = New System.Drawing.Point(17, 307)
        Me.delete_appt_btn.Name = "delete_appt_btn"
        Me.delete_appt_btn.Size = New System.Drawing.Size(85, 30)
        Me.delete_appt_btn.TabIndex = 18
        Me.delete_appt_btn.Text = "Delete 🗑️"
        Me.delete_appt_btn.UseVisualStyleBackColor = False
        '
        'appt_listView
        '
        Me.appt_listView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.appt_listView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.appt_listView.BackColor = System.Drawing.Color.Gainsboro
        Me.appt_listView.CheckBoxes = True
        Me.appt_listView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.appt_listView.HideSelection = False
        ListViewItem1.StateImageIndex = 0
        ListViewItem1.Tag = ""
        ListViewItem2.StateImageIndex = 0
        Me.appt_listView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.appt_listView.Location = New System.Drawing.Point(17, 126)
        Me.appt_listView.Name = "appt_listView"
        Me.appt_listView.Size = New System.Drawing.Size(690, 175)
        Me.appt_listView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.appt_listView.TabIndex = 19
        Me.appt_listView.UseCompatibleStateImageBehavior = False
        Me.appt_listView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Select"
        Me.ColumnHeader1.Width = 66
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Request Date"
        Me.ColumnHeader2.Width = 137
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 127
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Time"
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Provider"
        Me.ColumnHeader5.Width = 171
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        Me.ColumnHeader6.Width = 81
        '
        'currentBill_label
        '
        Me.currentBill_label.AutoSize = True
        Me.currentBill_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentBill_label.Location = New System.Drawing.Point(3, 4)
        Me.currentBill_label.Name = "currentBill_label"
        Me.currentBill_label.Size = New System.Drawing.Size(62, 13)
        Me.currentBill_label.TabIndex = 0
        Me.currentBill_label.Text = "Current Bills"
        Me.currentBill_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'historicalBill_label
        '
        Me.historicalBill_label.AutoSize = True
        Me.historicalBill_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historicalBill_label.Location = New System.Drawing.Point(3, 30)
        Me.historicalBill_label.Name = "historicalBill_label"
        Me.historicalBill_label.Size = New System.Drawing.Size(55, 13)
        Me.historicalBill_label.TabIndex = 1
        Me.historicalBill_label.Text = "Bill History"
        '
        'billing_panel
        '
        Me.billing_panel.BackColor = System.Drawing.Color.White
        Me.billing_panel.Controls.Add(Me.currentBill_label)
        Me.billing_panel.Controls.Add(Me.historicalBill_label)
        Me.billing_panel.Location = New System.Drawing.Point(586, 72)
        Me.billing_panel.Name = "billing_panel"
        Me.billing_panel.Size = New System.Drawing.Size(117, 0)
        Me.billing_panel.TabIndex = 21
        '
        'Timer2
        '
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.exit_button
        Me.ClientSize = New System.Drawing.Size(839, 385)
        Me.Controls.Add(Me.billing_panel)
        Me.Controls.Add(Me.appt_listView)
        Me.Controls.Add(Me.delete_appt_btn)
        Me.Controls.Add(Me.add_apt_btn)
        Me.Controls.Add(Me.appointment_label)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.AboutMeSubMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.AboutMeSubMenu.ResumeLayout(False)
        Me.AboutMeSubMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.billing_panel.ResumeLayout(False)
        Me.billing_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AboutMe_Button As Button
    Friend WithEvents med_record As Button
    Friend WithEvents prescription_btn As Button
    Friend WithEvents homeMonitoring_btn As Button
    Friend WithEvents billing_btn As Button
    Friend WithEvents AboutMeSubMenu As Panel
    Friend WithEvents exit_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents med_history_label As Label
    Friend WithEvents client_info As Label
    Friend WithEvents ins_info As Label
    Friend WithEvents phar_info As Label
    Friend WithEvents appointment_label As Label
    Friend WithEvents add_apt_btn As Button
    Friend WithEvents delete_appt_btn As Button
    Friend WithEvents appt_listView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents currentBill_label As Label
    Friend WithEvents historicalBill_label As Label
    Friend WithEvents billing_panel As Panel
    Friend WithEvents Timer2 As Timer
End Class
