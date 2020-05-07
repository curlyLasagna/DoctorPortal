<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricalBillExample
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"304-X", "Detoxicity of Self", "2", "7,948.68", "15,897.36"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoricalBillExample))
        Me.insurancePayment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paymentMethod = New System.Windows.Forms.Label()
        Me.amountPaid = New System.Windows.Forms.Label()
        Me.totalAmount = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.taxRate = New System.Windows.Forms.Label()
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
        Me.recitptNumber = New System.Windows.Forms.Label()
        Me.nameOfInstitution = New System.Windows.Forms.Label()
        Me.medicalBillReceiptHeader = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insurancePayment
        '
        Me.insurancePayment.AutoSize = True
        Me.insurancePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insurancePayment.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.insurancePayment.Location = New System.Drawing.Point(5, 522)
        Me.insurancePayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.insurancePayment.Name = "insurancePayment"
        Me.insurancePayment.Size = New System.Drawing.Size(183, 15)
        Me.insurancePayment.TabIndex = 53
        Me.insurancePayment.Text = "Insurance Payment: $ 10,000.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(274, 499)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 15)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Card/Check No.: xxxx-xxxx-xxxx-035C"
        '
        'paymentMethod
        '
        Me.paymentMethod.AutoSize = True
        Me.paymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentMethod.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.paymentMethod.Location = New System.Drawing.Point(274, 475)
        Me.paymentMethod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.paymentMethod.Name = "paymentMethod"
        Me.paymentMethod.Size = New System.Drawing.Size(192, 15)
        Me.paymentMethod.TabIndex = 51
        Me.paymentMethod.Text = "Payment Merhod: Multiverse Card"
        '
        'amountPaid
        '
        Me.amountPaid.AutoSize = True
        Me.amountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountPaid.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.amountPaid.Location = New System.Drawing.Point(5, 573)
        Me.amountPaid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.amountPaid.Name = "amountPaid"
        Me.amountPaid.Size = New System.Drawing.Size(145, 15)
        Me.amountPaid.TabIndex = 50
        Me.amountPaid.Text = "Amount Paid: $15,897.36"
        '
        'totalAmount
        '
        Me.totalAmount.AutoSize = True
        Me.totalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.totalAmount.Location = New System.Drawing.Point(5, 548)
        Me.totalAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(102, 15)
        Me.totalAmount.TabIndex = 49
        Me.totalAmount.Text = "Total: $15,897.36"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.subtotal.Location = New System.Drawing.Point(5, 475)
        Me.subtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(120, 15)
        Me.subtotal.TabIndex = 48
        Me.subtotal.Text = "Subtotal: $15,897.36"
        '
        'taxRate
        '
        Me.taxRate.AutoSize = True
        Me.taxRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxRate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.taxRate.Location = New System.Drawing.Point(5, 499)
        Me.taxRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxRate.Name = "taxRate"
        Me.taxRate.Size = New System.Drawing.Size(91, 15)
        Me.taxRate.TabIndex = 47
        Me.taxRate.Text = "Tax Rate (%): 0"
        '
        'receiptItemListBox
        '
        Me.receiptItemListBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.medicalCode, Me.descriptonOfService, Me.quanityOfService, Me.rateOfService, Me.moneyTotal})
        Me.receiptItemListBox.HideSelection = False
        Me.receiptItemListBox.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.receiptItemListBox.Location = New System.Drawing.Point(8, 317)
        Me.receiptItemListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.receiptItemListBox.Name = "receiptItemListBox"
        Me.receiptItemListBox.Size = New System.Drawing.Size(481, 146)
        Me.receiptItemListBox.TabIndex = 46
        Me.receiptItemListBox.UseCompatibleStateImageBehavior = False
        Me.receiptItemListBox.View = System.Windows.Forms.View.Details
        '
        'medicalCode
        '
        Me.medicalCode.Text = "Code"
        Me.medicalCode.Width = 41
        '
        'descriptonOfService
        '
        Me.descriptonOfService.Text = "Descripton"
        Me.descriptonOfService.Width = 197
        '
        'quanityOfService
        '
        Me.quanityOfService.Text = "Qty"
        Me.quanityOfService.Width = 30
        '
        'rateOfService
        '
        Me.rateOfService.Text = "Rate"
        Me.rateOfService.Width = 62
        '
        'moneyTotal
        '
        Me.moneyTotal.Text = "Total"
        Me.moneyTotal.Width = 79
        '
        'patientCityStateZip
        '
        Me.patientCityStateZip.AutoSize = True
        Me.patientCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientCityStateZip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientCityStateZip.Location = New System.Drawing.Point(5, 288)
        Me.patientCityStateZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientCityStateZip.Name = "patientCityStateZip"
        Me.patientCityStateZip.Size = New System.Drawing.Size(211, 15)
        Me.patientCityStateZip.TabIndex = 45
        Me.patientCityStateZip.Text = "City/State/ZIP: Something, WA C500-A"
        '
        'patientStreetAddress
        '
        Me.patientStreetAddress.AutoSize = True
        Me.patientStreetAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientStreetAddress.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientStreetAddress.Location = New System.Drawing.Point(5, 266)
        Me.patientStreetAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientStreetAddress.Name = "patientStreetAddress"
        Me.patientStreetAddress.Size = New System.Drawing.Size(206, 15)
        Me.patientStreetAddress.TabIndex = 44
        Me.patientStreetAddress.Text = "Street Address: C-137 Multiverse Rd."
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientName.Location = New System.Drawing.Point(5, 245)
        Me.patientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(125, 15)
        Me.patientName.TabIndex = 43
        Me.patientName.Text = "Name: Rick Sanchez "
        '
        'patientInformation
        '
        Me.patientInformation.AutoSize = True
        Me.patientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInformation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.patientInformation.Location = New System.Drawing.Point(5, 222)
        Me.patientInformation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientInformation.Name = "patientInformation"
        Me.patientInformation.Size = New System.Drawing.Size(113, 15)
        Me.patientInformation.TabIndex = 42
        Me.patientInformation.Text = "Patient Information:"
        '
        'officeCityStateZip
        '
        Me.officeCityStateZip.AutoSize = True
        Me.officeCityStateZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeCityStateZip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.officeCityStateZip.Location = New System.Drawing.Point(5, 183)
        Me.officeCityStateZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.officeCityStateZip.Name = "officeCityStateZip"
        Me.officeCityStateZip.Size = New System.Drawing.Size(182, 15)
        Me.officeCityStateZip.TabIndex = 41
        Me.officeCityStateZip.Text = "City/State/ZIP: Tucson, AZ 85743"
        '
        'officeAddress
        '
        Me.officeAddress.AutoSize = True
        Me.officeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.officeAddress.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.officeAddress.Location = New System.Drawing.Point(5, 161)
        Me.officeAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.officeAddress.Name = "officeAddress"
        Me.officeAddress.Size = New System.Drawing.Size(204, 15)
        Me.officeAddress.TabIndex = 40
        Me.officeAddress.Text = "Office Address: 1235 Something Rd."
        '
        'licenseNumber
        '
        Me.licenseNumber.AutoSize = True
        Me.licenseNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.licenseNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.licenseNumber.Location = New System.Drawing.Point(5, 138)
        Me.licenseNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.licenseNumber.Name = "licenseNumber"
        Me.licenseNumber.Size = New System.Drawing.Size(146, 15)
        Me.licenseNumber.TabIndex = 39
        Me.licenseNumber.Text = "License Number: 123456"
        '
        'doctorsName
        '
        Me.doctorsName.AutoSize = True
        Me.doctorsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorsName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.doctorsName.Location = New System.Drawing.Point(5, 116)
        Me.doctorsName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.doctorsName.Name = "doctorsName"
        Me.doctorsName.Size = New System.Drawing.Size(147, 15)
        Me.doctorsName.TabIndex = 38
        Me.doctorsName.Text = "Practitoner Name: Bechie"
        '
        'dateLable
        '
        Me.dateLable.AutoSize = True
        Me.dateLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateLable.Location = New System.Drawing.Point(289, 116)
        Me.dateLable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dateLable.Name = "dateLable"
        Me.dateLable.Size = New System.Drawing.Size(101, 15)
        Me.dateLable.TabIndex = 37
        Me.dateLable.Text = "Date: 04/07/2020"
        '
        'recitptNumber
        '
        Me.recitptNumber.AutoSize = True
        Me.recitptNumber.Location = New System.Drawing.Point(493, -16)
        Me.recitptNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.recitptNumber.Name = "recitptNumber"
        Me.recitptNumber.Size = New System.Drawing.Size(100, 15)
        Me.recitptNumber.TabIndex = 36
        Me.recitptNumber.Text = "Receipt Number:"
        '
        'nameOfInstitution
        '
        Me.nameOfInstitution.AutoSize = True
        Me.nameOfInstitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameOfInstitution.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.nameOfInstitution.Location = New System.Drawing.Point(5, 95)
        Me.nameOfInstitution.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameOfInstitution.Name = "nameOfInstitution"
        Me.nameOfInstitution.Size = New System.Drawing.Size(218, 15)
        Me.nameOfInstitution.TabIndex = 35
        Me.nameOfInstitution.Text = "Name of Medical Institution: Pima 299 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'medicalBillReceiptHeader
        '
        Me.medicalBillReceiptHeader.AutoSize = True
        Me.medicalBillReceiptHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicalBillReceiptHeader.Location = New System.Drawing.Point(360, -47)
        Me.medicalBillReceiptHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.medicalBillReceiptHeader.Name = "medicalBillReceiptHeader"
        Me.medicalBillReceiptHeader.Size = New System.Drawing.Size(174, 24)
        Me.medicalBillReceiptHeader.TabIndex = 34
        Me.medicalBillReceiptHeader.Text = "Medical Bill Receipt"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(230, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Medical Bill Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(289, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 15)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Receipt Number:  RC56813A3  "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80914!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.19086!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 75)
        Me.TableLayoutPanel1.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'HistoricalBillExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(503, 673)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.insurancePayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.paymentMethod)
        Me.Controls.Add(Me.amountPaid)
        Me.Controls.Add(Me.totalAmount)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.taxRate)
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
        Me.Controls.Add(Me.recitptNumber)
        Me.Controls.Add(Me.nameOfInstitution)
        Me.Controls.Add(Me.medicalBillReceiptHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "HistoricalBillExample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipt"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents insurancePayment As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents paymentMethod As Label
    Friend WithEvents amountPaid As Label
    Friend WithEvents totalAmount As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents taxRate As Label
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
    Friend WithEvents recitptNumber As Label
    Friend WithEvents nameOfInstitution As Label
    Friend WithEvents medicalBillReceiptHeader As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
