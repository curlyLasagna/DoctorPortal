<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(currentBill))
        Me.receiptItemListBox = New System.Windows.Forms.ListView()
        Me.medicalCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descriptonOfService = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quanityOfService = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rateOfService = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.moneyTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.patientCityStateZip = New System.Windows.Forms.Label()
        Me.patientStreetAddress = New System.Windows.Forms.Label()
        Me.patientName = New System.Windows.Forms.Label()
        Me.patientInformation = New System.Windows.Forms.Label()
        Me.officeCityStateZip = New System.Windows.Forms.Label()
        Me.officeAddress = New System.Windows.Forms.Label()
        Me.licenseNumber = New System.Windows.Forms.Label()
        Me.doctorsName = New System.Windows.Forms.Label()
        Me.dateLable = New System.Windows.Forms.Label()
        Me.nameOfInstitution = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.payNowBtn = New System.Windows.Forms.Button()
        Me.insurancePayment = New System.Windows.Forms.Label()
        Me.totalAmount = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.taxRate = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'receiptItemListBox
        '
        Me.receiptItemListBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.medicalCode, Me.descriptonOfService, Me.quanityOfService, Me.rateOfService, Me.moneyTotal})
        Me.receiptItemListBox.HideSelection = False
        Me.receiptItemListBox.Location = New System.Drawing.Point(16, 455)
        Me.receiptItemListBox.Name = "receiptItemListBox"
        Me.receiptItemListBox.Size = New System.Drawing.Size(618, 207)
        Me.receiptItemListBox.TabIndex = 24
        Me.receiptItemListBox.UseCompatibleStateImageBehavior = False
        Me.receiptItemListBox.View = System.Windows.Forms.View.Details
        '
        'medicalCode
        '
        Me.medicalCode.Text = "Code"
        Me.medicalCode.Width = 45
        '
        'descriptonOfService
        '
        Me.descriptonOfService.Text = "Descripton"
        Me.descriptonOfService.Width = 240
        '
        'quanityOfService
        '
        Me.quanityOfService.Text = "Qty"
        Me.quanityOfService.Width = 30
        '
        'rateOfService
        '
        Me.rateOfService.Text = "Rate"
        Me.rateOfService.Width = 45
        '
        'moneyTotal
        '
        Me.moneyTotal.Text = "Total"
        Me.moneyTotal.Width = 55
        '
        'patientCityStateZip
        '
        Me.patientCityStateZip.AutoSize = True
        Me.patientCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientCityStateZip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientCityStateZip.Location = New System.Drawing.Point(16, 397)
        Me.patientCityStateZip.Name = "patientCityStateZip"
        Me.patientCityStateZip.Size = New System.Drawing.Size(140, 25)
        Me.patientCityStateZip.TabIndex = 23
        Me.patientCityStateZip.Text = "City/State/ZIP:"
        '
        'patientStreetAddress
        '
        Me.patientStreetAddress.AutoSize = True
        Me.patientStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientStreetAddress.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientStreetAddress.Location = New System.Drawing.Point(16, 365)
        Me.patientStreetAddress.Name = "patientStreetAddress"
        Me.patientStreetAddress.Size = New System.Drawing.Size(148, 25)
        Me.patientStreetAddress.TabIndex = 22
        Me.patientStreetAddress.Text = "Street Address:"
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientName.Location = New System.Drawing.Point(16, 335)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(70, 25)
        Me.patientName.TabIndex = 21
        Me.patientName.Text = "Name:"
        '
        'patientInformation
        '
        Me.patientInformation.AutoSize = True
        Me.patientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInformation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientInformation.Location = New System.Drawing.Point(16, 302)
        Me.patientInformation.Name = "patientInformation"
        Me.patientInformation.Size = New System.Drawing.Size(179, 25)
        Me.patientInformation.TabIndex = 20
        Me.patientInformation.Text = "Patient Information:"
        '
        'officeCityStateZip
        '
        Me.officeCityStateZip.AutoSize = True
        Me.officeCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeCityStateZip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.officeCityStateZip.Location = New System.Drawing.Point(16, 246)
        Me.officeCityStateZip.Name = "officeCityStateZip"
        Me.officeCityStateZip.Size = New System.Drawing.Size(140, 25)
        Me.officeCityStateZip.TabIndex = 19
        Me.officeCityStateZip.Text = "City/State/ZIP:"
        '
        'officeAddress
        '
        Me.officeAddress.AutoSize = True
        Me.officeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeAddress.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.officeAddress.Location = New System.Drawing.Point(16, 215)
        Me.officeAddress.Name = "officeAddress"
        Me.officeAddress.Size = New System.Drawing.Size(147, 25)
        Me.officeAddress.TabIndex = 18
        Me.officeAddress.Text = "Office Address:"
        '
        'licenseNumber
        '
        Me.licenseNumber.AutoSize = True
        Me.licenseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.licenseNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.licenseNumber.Location = New System.Drawing.Point(16, 182)
        Me.licenseNumber.Name = "licenseNumber"
        Me.licenseNumber.Size = New System.Drawing.Size(160, 25)
        Me.licenseNumber.TabIndex = 17
        Me.licenseNumber.Text = "License Number:"
        '
        'doctorsName
        '
        Me.doctorsName.AutoSize = True
        Me.doctorsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorsName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.doctorsName.Location = New System.Drawing.Point(16, 151)
        Me.doctorsName.Name = "doctorsName"
        Me.doctorsName.Size = New System.Drawing.Size(168, 25)
        Me.doctorsName.TabIndex = 16
        Me.doctorsName.Text = "Practitoner Name:"
        '
        'dateLable
        '
        Me.dateLable.AutoSize = True
        Me.dateLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateLable.Location = New System.Drawing.Point(458, 120)
        Me.dateLable.Name = "dateLable"
        Me.dateLable.Size = New System.Drawing.Size(59, 25)
        Me.dateLable.TabIndex = 15
        Me.dateLable.Text = "Date:"
        '
        'nameOfInstitution
        '
        Me.nameOfInstitution.AutoSize = True
        Me.nameOfInstitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameOfInstitution.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.nameOfInstitution.Location = New System.Drawing.Point(16, 120)
        Me.nameOfInstitution.Name = "nameOfInstitution"
        Me.nameOfInstitution.Size = New System.Drawing.Size(251, 25)
        Me.nameOfInstitution.TabIndex = 14
        Me.nameOfInstitution.Text = "Name of Medical Institution:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(341, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 74)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Current Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Viewer"
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.previousBtn.ForeColor = System.Drawing.Color.Black
        Me.previousBtn.Location = New System.Drawing.Point(16, 923)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(92, 32)
        Me.previousBtn.TabIndex = 29
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'payNowBtn
        '
        Me.payNowBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.payNowBtn.ForeColor = System.Drawing.Color.Black
        Me.payNowBtn.Location = New System.Drawing.Point(268, 840)
        Me.payNowBtn.Name = "payNowBtn"
        Me.payNowBtn.Size = New System.Drawing.Size(142, 58)
        Me.payNowBtn.TabIndex = 30
        Me.payNowBtn.Text = "Pay Now "
        Me.payNowBtn.UseVisualStyleBackColor = False
        '
        'insurancePayment
        '
        Me.insurancePayment.AutoSize = True
        Me.insurancePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insurancePayment.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.insurancePayment.Location = New System.Drawing.Point(16, 777)
        Me.insurancePayment.Name = "insurancePayment"
        Me.insurancePayment.Size = New System.Drawing.Size(202, 25)
        Me.insurancePayment.TabIndex = 37
        Me.insurancePayment.Text = "Insurance Payment: $"
        '
        'totalAmount
        '
        Me.totalAmount.AutoSize = True
        Me.totalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.totalAmount.Location = New System.Drawing.Point(16, 814)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(78, 25)
        Me.totalAmount.TabIndex = 36
        Me.totalAmount.Text = "Total: $"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.subtotal.Location = New System.Drawing.Point(16, 709)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(106, 25)
        Me.subtotal.TabIndex = 35
        Me.subtotal.Text = "Subtotal: $"
        '
        'taxRate
        '
        Me.taxRate.AutoSize = True
        Me.taxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxRate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.taxRate.Location = New System.Drawing.Point(16, 743)
        Me.taxRate.Name = "taxRate"
        Me.taxRate.Size = New System.Drawing.Size(134, 25)
        Me.taxRate.TabIndex = 34
        Me.taxRate.Text = "Tax Rate (%):"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.02541!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.97459!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-2, -5)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(652, 105)
        Me.TableLayoutPanel1.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'currentBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(644, 972)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.insurancePayment)
        Me.Controls.Add(Me.totalAmount)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.taxRate)
        Me.Controls.Add(Me.payNowBtn)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.receiptItemListBox)
        Me.Controls.Add(Me.patientCityStateZip)
        Me.Controls.Add(Me.patientStreetAddress)
        Me.Controls.Add(Me.patientName)
        Me.Controls.Add(Me.patientInformation)
        Me.Controls.Add(Me.officeCityStateZip)
        Me.Controls.Add(Me.officeAddress)
        Me.Controls.Add(Me.licenseNumber)
        Me.Controls.Add(Me.doctorsName)
        Me.Controls.Add(Me.dateLable)
        Me.Controls.Add(Me.nameOfInstitution)
        Me.Name = "currentBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Bill"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents receiptItemListBox As ListView
    Friend WithEvents medicalCode As ColumnHeader
    Friend WithEvents descriptonOfService As ColumnHeader
    Friend WithEvents quanityOfService As ColumnHeader
    Friend WithEvents rateOfService As ColumnHeader
    Friend WithEvents moneyTotal As ColumnHeader
    Friend WithEvents patientCityStateZip As Label
    Friend WithEvents patientStreetAddress As Label
    Friend WithEvents patientName As Label
    Friend WithEvents patientInformation As Label
    Friend WithEvents officeCityStateZip As Label
    Friend WithEvents officeAddress As Label
    Friend WithEvents licenseNumber As Label
    Friend WithEvents doctorsName As Label
    Friend WithEvents dateLable As Label
    Friend WithEvents nameOfInstitution As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents previousBtn As Button
    Friend WithEvents payNowBtn As Button
    Friend WithEvents insurancePayment As Label
    Friend WithEvents totalAmount As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents taxRate As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
