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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicationRefilling))
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(22, 685)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(92, 32)
        Me.previousBtn.TabIndex = 12
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'amountLable
        '
        Me.amountLable.AutoSize = True
        Me.amountLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.amountLable.Location = New System.Drawing.Point(198, 215)
        Me.amountLable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amountLable.Name = "amountLable"
        Me.amountLable.Size = New System.Drawing.Size(97, 29)
        Me.amountLable.TabIndex = 11
        Me.amountLable.Text = "Dosage"
        '
        'reciptNumber
        '
        Me.reciptNumber.AutoSize = True
        Me.reciptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reciptNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.reciptNumber.Location = New System.Drawing.Point(352, 215)
        Me.reciptNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.reciptNumber.Name = "reciptNumber"
        Me.reciptNumber.Size = New System.Drawing.Size(49, 29)
        Me.reciptNumber.TabIndex = 10
        Me.reciptNumber.Text = "Qty"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateLabel.Location = New System.Drawing.Point(18, 215)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(84, 29)
        Me.dateLabel.TabIndex = 8
        Me.dateLabel.Text = "Name "
        '
        'medicationListBox
        '
        Me.medicationListBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.medicationListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.medicationListBox.ColumnWidth = 2
        Me.medicationListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicationListBox.FormattingEnabled = True
        Me.medicationListBox.ItemHeight = 25
        Me.medicationListBox.Items.AddRange(New Object() {"Ciprofloxacin            100mg              30           5                   Bech" &
                "ie                CVS", "", "Pantoprazole             40mg              120          10                  Lewis" &
                "                  CVS"})
        Me.medicationListBox.Location = New System.Drawing.Point(22, 248)
        Me.medicationListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.medicationListBox.Name = "medicationListBox"
        Me.medicationListBox.Size = New System.Drawing.Size(758, 352)
        Me.medicationListBox.TabIndex = 7
        '
        'medicationList
        '
        Me.medicationList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.medicationList.AutoSize = True
        Me.medicationList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicationList.Location = New System.Drawing.Point(343, 26)
        Me.medicationList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.medicationList.Name = "medicationList"
        Me.medicationList.Size = New System.Drawing.Size(308, 47)
        Me.medicationList.TabIndex = 13
        Me.medicationList.Text = "Medication List "
        '
        'pharmacy
        '
        Me.pharmacy.AutoSize = True
        Me.pharmacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pharmacy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.pharmacy.Location = New System.Drawing.Point(674, 215)
        Me.pharmacy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pharmacy.Name = "pharmacy"
        Me.pharmacy.Size = New System.Drawing.Size(125, 29)
        Me.pharmacy.TabIndex = 14
        Me.pharmacy.Text = "Pharmacy "
        '
        'doctor
        '
        Me.doctor.AutoSize = True
        Me.doctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.doctor.Location = New System.Drawing.Point(534, 188)
        Me.doctor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.doctor.Name = "doctor"
        Me.doctor.Size = New System.Drawing.Size(136, 58)
        Me.doctor.TabIndex = 15
        Me.doctor.Text = "Prescribing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Doctor"
        '
        'refill
        '
        Me.refill.AutoSize = True
        Me.refill.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refill.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.refill.Location = New System.Drawing.Point(426, 188)
        Me.refill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.refill.Name = "refill"
        Me.refill.Size = New System.Drawing.Size(80, 58)
        Me.refill.TabIndex = 16
        Me.refill.Text = "Refills" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Left"
        '
        'directions
        '
        Me.directions.AutoSize = True
        Me.directions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.directions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.directions.Location = New System.Drawing.Point(18, 132)
        Me.directions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.directions.Name = "directions"
        Me.directions.Size = New System.Drawing.Size(764, 29)
        Me.directions.TabIndex = 17
        Me.directions.Text = "Double left click on the medication you want to refill from the list below "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.1911!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.80891!))
        Me.TableLayoutPanel1.Controls.Add(Me.medicationList, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(808, 100)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'MedicationRefilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(800, 734)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.directions)
        Me.Controls.Add(Me.refill)
        Me.Controls.Add(Me.doctor)
        Me.Controls.Add(Me.pharmacy)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.amountLable)
        Me.Controls.Add(Me.reciptNumber)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.medicationListBox)
        Me.Name = "MedicationRefilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medication Refilling"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
