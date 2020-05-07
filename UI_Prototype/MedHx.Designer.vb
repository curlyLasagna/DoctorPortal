<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedHx
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.diagnosisLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.statusTxtBox2 = New System.Windows.Forms.TextBox()
        Me.diagnosisTxtBox2 = New System.Windows.Forms.TextBox()
        Me.statusTxtBox1 = New System.Windows.Forms.TextBox()
        Me.diagnosisTxtBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.allergySeverityLabel = New System.Windows.Forms.Label()
        Me.allergiesLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AllergySeverityTxtBox2 = New System.Windows.Forms.TextBox()
        Me.allergyTxtBox2 = New System.Windows.Forms.TextBox()
        Me.allergySeverityTxtBox1 = New System.Windows.Forms.TextBox()
        Me.allergyTxtBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.immunizationStatusTxtBox2 = New System.Windows.Forms.TextBox()
        Me.immunizationTxtBox2 = New System.Windows.Forms.TextBox()
        Me.immunizationStatusTxtBox1 = New System.Windows.Forms.TextBox()
        Me.immunizationTxtBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.immunizationStatusLabel = New System.Windows.Forms.Label()
        Me.immunizationLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.medStatusTxtBox2 = New System.Windows.Forms.TextBox()
        Me.medTxtBox2 = New System.Windows.Forms.TextBox()
        Me.medStatusTxtBox1 = New System.Windows.Forms.TextBox()
        Me.medTxtBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.statusLabel)
        Me.Panel1.Controls.Add(Me.diagnosisLabel)
        Me.Panel1.Location = New System.Drawing.Point(21, 56)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 38)
        Me.Panel1.TabIndex = 1
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.statusLabel.Location = New System.Drawing.Point(436, 11)
        Me.statusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(60, 24)
        Me.statusLabel.TabIndex = 1
        Me.statusLabel.Text = "Status"
        '
        'diagnosisLabel
        '
        Me.diagnosisLabel.AutoSize = True
        Me.diagnosisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.diagnosisLabel.Location = New System.Drawing.Point(16, 11)
        Me.diagnosisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.diagnosisLabel.Name = "diagnosisLabel"
        Me.diagnosisLabel.Size = New System.Drawing.Size(92, 24)
        Me.diagnosisLabel.TabIndex = 0
        Me.diagnosisLabel.Text = "Diagnosis"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.statusTxtBox2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.diagnosisTxtBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.statusTxtBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.diagnosisTxtBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(21, 109)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(874, 44)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'statusTxtBox2
        '
        Me.statusTxtBox2.Location = New System.Drawing.Point(439, 24)
        Me.statusTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.statusTxtBox2.Name = "statusTxtBox2"
        Me.statusTxtBox2.ReadOnly = True
        Me.statusTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.statusTxtBox2.TabIndex = 3
        Me.statusTxtBox2.Text = "Inactive"
        '
        'diagnosisTxtBox2
        '
        Me.diagnosisTxtBox2.Location = New System.Drawing.Point(2, 24)
        Me.diagnosisTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.diagnosisTxtBox2.Name = "diagnosisTxtBox2"
        Me.diagnosisTxtBox2.ReadOnly = True
        Me.diagnosisTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.diagnosisTxtBox2.TabIndex = 2
        Me.diagnosisTxtBox2.Text = "Pneumonia"
        '
        'statusTxtBox1
        '
        Me.statusTxtBox1.Location = New System.Drawing.Point(439, 2)
        Me.statusTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.statusTxtBox1.Name = "statusTxtBox1"
        Me.statusTxtBox1.ReadOnly = True
        Me.statusTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.statusTxtBox1.TabIndex = 1
        Me.statusTxtBox1.Text = "ACTIVE"
        '
        'diagnosisTxtBox1
        '
        Me.diagnosisTxtBox1.Location = New System.Drawing.Point(2, 2)
        Me.diagnosisTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.diagnosisTxtBox1.Name = "diagnosisTxtBox1"
        Me.diagnosisTxtBox1.ReadOnly = True
        Me.diagnosisTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.diagnosisTxtBox1.TabIndex = 0
        Me.diagnosisTxtBox1.Text = "COPD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.allergySeverityLabel)
        Me.Panel2.Controls.Add(Me.allergiesLabel)
        Me.Panel2.Location = New System.Drawing.Point(21, 170)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 38)
        Me.Panel2.TabIndex = 2
        '
        'allergySeverityLabel
        '
        Me.allergySeverityLabel.AutoSize = True
        Me.allergySeverityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.allergySeverityLabel.Location = New System.Drawing.Point(436, 11)
        Me.allergySeverityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.allergySeverityLabel.Name = "allergySeverityLabel"
        Me.allergySeverityLabel.Size = New System.Drawing.Size(155, 24)
        Me.allergySeverityLabel.TabIndex = 1
        Me.allergySeverityLabel.Text = "Reaction Severity"
        '
        'allergiesLabel
        '
        Me.allergiesLabel.AutoSize = True
        Me.allergiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.allergiesLabel.Location = New System.Drawing.Point(16, 11)
        Me.allergiesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.allergiesLabel.Name = "allergiesLabel"
        Me.allergiesLabel.Size = New System.Drawing.Size(83, 24)
        Me.allergiesLabel.TabIndex = 0
        Me.allergiesLabel.Text = "Allergies"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AllergySeverityTxtBox2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.allergyTxtBox2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.allergySeverityTxtBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.allergyTxtBox1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(21, 224)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(874, 44)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'AllergySeverityTxtBox2
        '
        Me.AllergySeverityTxtBox2.Location = New System.Drawing.Point(439, 24)
        Me.AllergySeverityTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.AllergySeverityTxtBox2.Name = "AllergySeverityTxtBox2"
        Me.AllergySeverityTxtBox2.ReadOnly = True
        Me.AllergySeverityTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.AllergySeverityTxtBox2.TabIndex = 3
        Me.AllergySeverityTxtBox2.Text = "Mild rash, itchiness, localized"
        '
        'allergyTxtBox2
        '
        Me.allergyTxtBox2.Location = New System.Drawing.Point(2, 24)
        Me.allergyTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.allergyTxtBox2.Name = "allergyTxtBox2"
        Me.allergyTxtBox2.ReadOnly = True
        Me.allergyTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.allergyTxtBox2.TabIndex = 2
        Me.allergyTxtBox2.Text = "Iodine"
        '
        'allergySeverityTxtBox1
        '
        Me.allergySeverityTxtBox1.Location = New System.Drawing.Point(439, 2)
        Me.allergySeverityTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.allergySeverityTxtBox1.Name = "allergySeverityTxtBox1"
        Me.allergySeverityTxtBox1.ReadOnly = True
        Me.allergySeverityTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.allergySeverityTxtBox1.TabIndex = 1
        Me.allergySeverityTxtBox1.Text = "Anaphylaxis"
        '
        'allergyTxtBox1
        '
        Me.allergyTxtBox1.Location = New System.Drawing.Point(2, 2)
        Me.allergyTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.allergyTxtBox1.Name = "allergyTxtBox1"
        Me.allergyTxtBox1.ReadOnly = True
        Me.allergyTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.allergyTxtBox1.TabIndex = 0
        Me.allergyTxtBox1.Text = "Penicillin"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.immunizationStatusTxtBox2, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.immunizationTxtBox2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.immunizationStatusTxtBox1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.immunizationTxtBox1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(21, 338)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(874, 44)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'immunizationStatusTxtBox2
        '
        Me.immunizationStatusTxtBox2.Location = New System.Drawing.Point(439, 24)
        Me.immunizationStatusTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.immunizationStatusTxtBox2.Name = "immunizationStatusTxtBox2"
        Me.immunizationStatusTxtBox2.ReadOnly = True
        Me.immunizationStatusTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.immunizationStatusTxtBox2.TabIndex = 3
        Me.immunizationStatusTxtBox2.Text = "Needed"
        '
        'immunizationTxtBox2
        '
        Me.immunizationTxtBox2.Location = New System.Drawing.Point(2, 24)
        Me.immunizationTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.immunizationTxtBox2.Name = "immunizationTxtBox2"
        Me.immunizationTxtBox2.ReadOnly = True
        Me.immunizationTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.immunizationTxtBox2.TabIndex = 2
        Me.immunizationTxtBox2.Text = "MMR"
        '
        'immunizationStatusTxtBox1
        '
        Me.immunizationStatusTxtBox1.Location = New System.Drawing.Point(439, 2)
        Me.immunizationStatusTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.immunizationStatusTxtBox1.Name = "immunizationStatusTxtBox1"
        Me.immunizationStatusTxtBox1.ReadOnly = True
        Me.immunizationStatusTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.immunizationStatusTxtBox1.TabIndex = 1
        Me.immunizationStatusTxtBox1.Text = "Administered 3/10/19"
        '
        'immunizationTxtBox1
        '
        Me.immunizationTxtBox1.Location = New System.Drawing.Point(2, 2)
        Me.immunizationTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.immunizationTxtBox1.Name = "immunizationTxtBox1"
        Me.immunizationTxtBox1.ReadOnly = True
        Me.immunizationTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.immunizationTxtBox1.TabIndex = 0
        Me.immunizationTxtBox1.Text = "TDAP"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.immunizationStatusLabel)
        Me.Panel3.Controls.Add(Me.immunizationLabel)
        Me.Panel3.Location = New System.Drawing.Point(21, 284)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(874, 38)
        Me.Panel3.TabIndex = 4
        '
        'immunizationStatusLabel
        '
        Me.immunizationStatusLabel.AutoSize = True
        Me.immunizationStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.immunizationStatusLabel.Location = New System.Drawing.Point(436, 11)
        Me.immunizationStatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.immunizationStatusLabel.Name = "immunizationStatusLabel"
        Me.immunizationStatusLabel.Size = New System.Drawing.Size(60, 24)
        Me.immunizationStatusLabel.TabIndex = 1
        Me.immunizationStatusLabel.Text = "Status"
        '
        'immunizationLabel
        '
        Me.immunizationLabel.AutoSize = True
        Me.immunizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.immunizationLabel.Location = New System.Drawing.Point(16, 11)
        Me.immunizationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.immunizationLabel.Name = "immunizationLabel"
        Me.immunizationLabel.Size = New System.Drawing.Size(130, 24)
        Me.immunizationLabel.TabIndex = 0
        Me.immunizationLabel.Text = "Immunizations"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.medStatusTxtBox2, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.medTxtBox2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.medStatusTxtBox1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.medTxtBox1, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(21, 458)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(874, 44)
        Me.TableLayoutPanel4.TabIndex = 7
        '
        'medStatusTxtBox2
        '
        Me.medStatusTxtBox2.Location = New System.Drawing.Point(439, 24)
        Me.medStatusTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.medStatusTxtBox2.Name = "medStatusTxtBox2"
        Me.medStatusTxtBox2.ReadOnly = True
        Me.medStatusTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.medStatusTxtBox2.TabIndex = 3
        Me.medStatusTxtBox2.Text = "Currently Prescribed"
        '
        'medTxtBox2
        '
        Me.medTxtBox2.Location = New System.Drawing.Point(2, 24)
        Me.medTxtBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.medTxtBox2.Name = "medTxtBox2"
        Me.medTxtBox2.ReadOnly = True
        Me.medTxtBox2.Size = New System.Drawing.Size(433, 20)
        Me.medTxtBox2.TabIndex = 2
        Me.medTxtBox2.Text = "Salmeterol"
        '
        'medStatusTxtBox1
        '
        Me.medStatusTxtBox1.Location = New System.Drawing.Point(439, 2)
        Me.medStatusTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.medStatusTxtBox1.Name = "medStatusTxtBox1"
        Me.medStatusTxtBox1.ReadOnly = True
        Me.medStatusTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.medStatusTxtBox1.TabIndex = 1
        Me.medStatusTxtBox1.Text = "Completed on 5/20/19"
        '
        'medTxtBox1
        '
        Me.medTxtBox1.Location = New System.Drawing.Point(2, 2)
        Me.medTxtBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.medTxtBox1.Name = "medTxtBox1"
        Me.medTxtBox1.ReadOnly = True
        Me.medTxtBox1.Size = New System.Drawing.Size(433, 20)
        Me.medTxtBox1.TabIndex = 0
        Me.medTxtBox1.Text = "Cephalaxin"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(21, 404)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(874, 38)
        Me.Panel4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(436, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Medications"
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(21, 518)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(97, 21)
        Me.previousBtn.TabIndex = 8
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(396, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medical History"
        '
        'MedHx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(913, 546)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MedHx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents diagnosisLabel As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents statusTxtBox2 As TextBox
    Friend WithEvents diagnosisTxtBox2 As TextBox
    Friend WithEvents statusTxtBox1 As TextBox
    Friend WithEvents diagnosisTxtBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents allergiesLabel As Label
    Friend WithEvents allergySeverityLabel As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AllergySeverityTxtBox2 As TextBox
    Friend WithEvents allergyTxtBox2 As TextBox
    Friend WithEvents allergySeverityTxtBox1 As TextBox
    Friend WithEvents allergyTxtBox1 As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents immunizationStatusTxtBox2 As TextBox
    Friend WithEvents immunizationTxtBox2 As TextBox
    Friend WithEvents immunizationStatusTxtBox1 As TextBox
    Friend WithEvents immunizationTxtBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents immunizationStatusLabel As Label
    Friend WithEvents immunizationLabel As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents medStatusTxtBox2 As TextBox
    Friend WithEvents medTxtBox2 As TextBox
    Friend WithEvents medStatusTxtBox1 As TextBox
    Friend WithEvents medTxtBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents previousBtn As Button
    Friend WithEvents Label1 As Label
End Class
