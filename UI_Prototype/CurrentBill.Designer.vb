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
        Me.SuspendLayout()
        '
        'receiptItemListBox
        '
        Me.receiptItemListBox.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.medicalCode, Me.descriptonOfService, Me.quanityOfService, Me.rateOfService, Me.moneyTotal})
        Me.receiptItemListBox.HideSelection = False
        Me.receiptItemListBox.Location = New System.Drawing.Point(11, 296)
        Me.receiptItemListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.receiptItemListBox.Name = "receiptItemListBox"
        Me.receiptItemListBox.Size = New System.Drawing.Size(413, 136)
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
        Me.patientCityStateZip.Location = New System.Drawing.Point(8, 267)
        Me.patientCityStateZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientCityStateZip.Name = "patientCityStateZip"
        Me.patientCityStateZip.Size = New System.Drawing.Size(79, 13)
        Me.patientCityStateZip.TabIndex = 23
        Me.patientCityStateZip.Text = "City/State/ZIP:"
        '
        'patientStreetAddress
        '
        Me.patientStreetAddress.AutoSize = True
        Me.patientStreetAddress.Location = New System.Drawing.Point(8, 246)
        Me.patientStreetAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientStreetAddress.Name = "patientStreetAddress"
        Me.patientStreetAddress.Size = New System.Drawing.Size(79, 13)
        Me.patientStreetAddress.TabIndex = 22
        Me.patientStreetAddress.Text = "Street Address:"
        '
        'patientName
        '
        Me.patientName.AutoSize = True
        Me.patientName.Location = New System.Drawing.Point(8, 227)
        Me.patientName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientName.Name = "patientName"
        Me.patientName.Size = New System.Drawing.Size(38, 13)
        Me.patientName.TabIndex = 21
        Me.patientName.Text = "Name:"
        '
        'patientInformation
        '
        Me.patientInformation.AutoSize = True
        Me.patientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientInformation.Location = New System.Drawing.Point(8, 205)
        Me.patientInformation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.patientInformation.Name = "patientInformation"
        Me.patientInformation.Size = New System.Drawing.Size(118, 13)
        Me.patientInformation.TabIndex = 20
        Me.patientInformation.Text = "Patient Information:"
        '
        'officeCityStateZip
        '
        Me.officeCityStateZip.AutoSize = True
        Me.officeCityStateZip.Location = New System.Drawing.Point(8, 169)
        Me.officeCityStateZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.officeCityStateZip.Name = "officeCityStateZip"
        Me.officeCityStateZip.Size = New System.Drawing.Size(79, 13)
        Me.officeCityStateZip.TabIndex = 19
        Me.officeCityStateZip.Text = "City/State/ZIP:"
        '
        'officeAddress
        '
        Me.officeAddress.AutoSize = True
        Me.officeAddress.Location = New System.Drawing.Point(8, 149)
        Me.officeAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.officeAddress.Name = "officeAddress"
        Me.officeAddress.Size = New System.Drawing.Size(79, 13)
        Me.officeAddress.TabIndex = 18
        Me.officeAddress.Text = "Office Address:"
        '
        'licenseNumber
        '
        Me.licenseNumber.AutoSize = True
        Me.licenseNumber.Location = New System.Drawing.Point(8, 127)
        Me.licenseNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.licenseNumber.Name = "licenseNumber"
        Me.licenseNumber.Size = New System.Drawing.Size(87, 13)
        Me.licenseNumber.TabIndex = 17
        Me.licenseNumber.Text = "License Number:"
        '
        'doctorsName
        '
        Me.doctorsName.AutoSize = True
        Me.doctorsName.Location = New System.Drawing.Point(8, 107)
        Me.doctorsName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.doctorsName.Name = "doctorsName"
        Me.doctorsName.Size = New System.Drawing.Size(92, 13)
        Me.doctorsName.TabIndex = 16
        Me.doctorsName.Text = "Practitoner Name:"
        '
        'dateLable
        '
        Me.dateLable.AutoSize = True
        Me.dateLable.Location = New System.Drawing.Point(293, 70)
        Me.dateLable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dateLable.Name = "dateLable"
        Me.dateLable.Size = New System.Drawing.Size(33, 13)
        Me.dateLable.TabIndex = 15
        Me.dateLable.Text = "Date:"
        '
        'nameOfInstitution
        '
        Me.nameOfInstitution.AutoSize = True
        Me.nameOfInstitution.Location = New System.Drawing.Point(8, 87)
        Me.nameOfInstitution.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameOfInstitution.Name = "nameOfInstitution"
        Me.nameOfInstitution.Size = New System.Drawing.Size(138, 13)
        Me.nameOfInstitution.TabIndex = 14
        Me.nameOfInstitution.Text = "Name of Medical Institution:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(149, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 48)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Current Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Viewer"
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(11, 606)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 29
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'payNowBtn
        '
        Me.payNowBtn.Location = New System.Drawing.Point(178, 565)
        Me.payNowBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.payNowBtn.Name = "payNowBtn"
        Me.payNowBtn.Size = New System.Drawing.Size(95, 21)
        Me.payNowBtn.TabIndex = 30
        Me.payNowBtn.Text = "Pay Now "
        Me.payNowBtn.UseVisualStyleBackColor = True
        '
        'insurancePayment
        '
        Me.insurancePayment.AutoSize = True
        Me.insurancePayment.Location = New System.Drawing.Point(216, 506)
        Me.insurancePayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.insurancePayment.Name = "insurancePayment"
        Me.insurancePayment.Size = New System.Drawing.Size(110, 13)
        Me.insurancePayment.TabIndex = 37
        Me.insurancePayment.Text = "Insurance Payment: $"
        '
        'totalAmount
        '
        Me.totalAmount.AutoSize = True
        Me.totalAmount.Location = New System.Drawing.Point(283, 528)
        Me.totalAmount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(43, 13)
        Me.totalAmount.TabIndex = 36
        Me.totalAmount.Text = "Total: $"
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.Location = New System.Drawing.Point(268, 462)
        Me.subtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(58, 13)
        Me.subtotal.TabIndex = 35
        Me.subtotal.Text = "Subtotal: $"
        '
        'taxRate
        '
        Me.taxRate.AutoSize = True
        Me.taxRate.Location = New System.Drawing.Point(255, 484)
        Me.taxRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxRate.Name = "taxRate"
        Me.taxRate.Size = New System.Drawing.Size(71, 13)
        Me.taxRate.TabIndex = 34
        Me.taxRate.Text = "Tax Rate (%):"
        '
        'currentBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(429, 632)
        Me.Controls.Add(Me.insurancePayment)
        Me.Controls.Add(Me.totalAmount)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.taxRate)
        Me.Controls.Add(Me.payNowBtn)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.Label1)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "currentBill"
        Me.Text = "Current Bill"
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
End Class
