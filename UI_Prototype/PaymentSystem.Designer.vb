<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentSystem
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
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.firstName = New System.Windows.Forms.Label()
        Me.addressTwo = New System.Windows.Forms.Label()
        Me.addressOne = New System.Windows.Forms.Label()
        Me.middleIntial = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.firstNameTB = New System.Windows.Forms.TextBox()
        Me.lastNameTB = New System.Windows.Forms.TextBox()
        Me.middleInitialTB = New System.Windows.Forms.TextBox()
        Me.addressOneTB = New System.Windows.Forms.TextBox()
        Me.addressTwoTB = New System.Windows.Forms.TextBox()
        Me.zipCode = New System.Windows.Forms.Label()
        Me.state = New System.Windows.Forms.Label()
        Me.stateComboBox = New System.Windows.Forms.ComboBox()
        Me.firstHalfZipTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.secondHalfZipTB = New System.Windows.Forms.TextBox()
        Me.cardNumber = New System.Windows.Forms.Label()
        Me.firstCardNumberTB = New System.Windows.Forms.TextBox()
        Me.secondCardNumberTB = New System.Windows.Forms.TextBox()
        Me.thirdCardNumberTB = New System.Windows.Forms.TextBox()
        Me.fourthCardNumberTB = New System.Windows.Forms.TextBox()
        Me.cardExpDate = New System.Windows.Forms.Label()
        Me.firstExpDateTB = New System.Windows.Forms.TextBox()
        Me.secondExpDateTB = New System.Windows.Forms.TextBox()
        Me.ccvNumber = New System.Windows.Forms.Label()
        Me.ccvTB = New System.Windows.Forms.TextBox()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.city = New System.Windows.Forms.Label()
        Me.cityTB = New System.Windows.Forms.TextBox()
        Me.dashNull = New System.Windows.Forms.Label()
        Me.dashNull5 = New System.Windows.Forms.Label()
        Me.dashNull2 = New System.Windows.Forms.Label()
        Me.dashNull4 = New System.Windows.Forms.Label()
        Me.dashNull3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(2, 276)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 0
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(17, 12)
        Me.firstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(55, 13)
        Me.firstName.TabIndex = 2
        Me.firstName.Text = "First name"
        '
        'addressTwo
        '
        Me.addressTwo.AutoSize = True
        Me.addressTwo.Location = New System.Drawing.Point(12, 98)
        Me.addressTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addressTwo.Name = "addressTwo"
        Me.addressTwo.Size = New System.Drawing.Size(54, 13)
        Me.addressTwo.TabIndex = 3
        Me.addressTwo.Text = "Address 2"
        '
        'addressOne
        '
        Me.addressOne.AutoSize = True
        Me.addressOne.Location = New System.Drawing.Point(11, 66)
        Me.addressOne.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addressOne.Name = "addressOne"
        Me.addressOne.Size = New System.Drawing.Size(54, 13)
        Me.addressOne.TabIndex = 4
        Me.addressOne.Text = "Address 1"
        '
        'middleIntial
        '
        Me.middleIntial.AutoSize = True
        Me.middleIntial.Location = New System.Drawing.Point(50, 38)
        Me.middleIntial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.middleIntial.Name = "middleIntial"
        Me.middleIntial.Size = New System.Drawing.Size(25, 13)
        Me.middleIntial.TabIndex = 5
        Me.middleIntial.Text = "M.I."
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(187, 12)
        Me.lastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(56, 13)
        Me.lastName.TabIndex = 6
        Me.lastName.Text = "Last name"
        '
        'firstNameTB
        '
        Me.firstNameTB.Location = New System.Drawing.Point(75, 8)
        Me.firstNameTB.Margin = New System.Windows.Forms.Padding(2)
        Me.firstNameTB.Name = "firstNameTB"
        Me.firstNameTB.Size = New System.Drawing.Size(111, 20)
        Me.firstNameTB.TabIndex = 7
        '
        'lastNameTB
        '
        Me.lastNameTB.Location = New System.Drawing.Point(244, 8)
        Me.lastNameTB.Margin = New System.Windows.Forms.Padding(2)
        Me.lastNameTB.Name = "lastNameTB"
        Me.lastNameTB.Size = New System.Drawing.Size(118, 20)
        Me.lastNameTB.TabIndex = 8
        '
        'middleInitialTB
        '
        Me.middleInitialTB.Location = New System.Drawing.Point(75, 34)
        Me.middleInitialTB.Margin = New System.Windows.Forms.Padding(2)
        Me.middleInitialTB.Name = "middleInitialTB"
        Me.middleInitialTB.Size = New System.Drawing.Size(39, 20)
        Me.middleInitialTB.TabIndex = 9
        '
        'addressOneTB
        '
        Me.addressOneTB.Location = New System.Drawing.Point(75, 62)
        Me.addressOneTB.Margin = New System.Windows.Forms.Padding(2)
        Me.addressOneTB.Name = "addressOneTB"
        Me.addressOneTB.Size = New System.Drawing.Size(232, 20)
        Me.addressOneTB.TabIndex = 10
        '
        'addressTwoTB
        '
        Me.addressTwoTB.Location = New System.Drawing.Point(75, 96)
        Me.addressTwoTB.Margin = New System.Windows.Forms.Padding(2)
        Me.addressTwoTB.Name = "addressTwoTB"
        Me.addressTwoTB.Size = New System.Drawing.Size(233, 20)
        Me.addressTwoTB.TabIndex = 11
        '
        'zipCode
        '
        Me.zipCode.AutoSize = True
        Me.zipCode.Location = New System.Drawing.Point(143, 157)
        Me.zipCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipCode.Name = "zipCode"
        Me.zipCode.Size = New System.Drawing.Size(50, 13)
        Me.zipCode.TabIndex = 12
        Me.zipCode.Text = "Zip Code"
        '
        'state
        '
        Me.state.AutoSize = True
        Me.state.Location = New System.Drawing.Point(28, 157)
        Me.state.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(32, 13)
        Me.state.TabIndex = 13
        Me.state.Text = "State"
        '
        'stateComboBox
        '
        Me.stateComboBox.FormattingEnabled = True
        Me.stateComboBox.Location = New System.Drawing.Point(75, 151)
        Me.stateComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.stateComboBox.Name = "stateComboBox"
        Me.stateComboBox.Size = New System.Drawing.Size(45, 21)
        Me.stateComboBox.TabIndex = 14
        '
        'firstHalfZipTB
        '
        Me.firstHalfZipTB.Location = New System.Drawing.Point(196, 155)
        Me.firstHalfZipTB.Margin = New System.Windows.Forms.Padding(2)
        Me.firstHalfZipTB.Name = "firstHalfZipTB"
        Me.firstHalfZipTB.Size = New System.Drawing.Size(46, 20)
        Me.firstHalfZipTB.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "-"
        '
        'secondHalfZipTB
        '
        Me.secondHalfZipTB.Location = New System.Drawing.Point(258, 155)
        Me.secondHalfZipTB.Margin = New System.Windows.Forms.Padding(2)
        Me.secondHalfZipTB.Name = "secondHalfZipTB"
        Me.secondHalfZipTB.Size = New System.Drawing.Size(49, 20)
        Me.secondHalfZipTB.TabIndex = 18
        '
        'cardNumber
        '
        Me.cardNumber.AutoSize = True
        Me.cardNumber.Location = New System.Drawing.Point(-1, 188)
        Me.cardNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cardNumber.Name = "cardNumber"
        Me.cardNumber.Size = New System.Drawing.Size(69, 13)
        Me.cardNumber.TabIndex = 19
        Me.cardNumber.Text = "Card Number"
        '
        'firstCardNumberTB
        '
        Me.firstCardNumberTB.Location = New System.Drawing.Point(75, 188)
        Me.firstCardNumberTB.Margin = New System.Windows.Forms.Padding(2)
        Me.firstCardNumberTB.Name = "firstCardNumberTB"
        Me.firstCardNumberTB.Size = New System.Drawing.Size(46, 20)
        Me.firstCardNumberTB.TabIndex = 20
        '
        'secondCardNumberTB
        '
        Me.secondCardNumberTB.Location = New System.Drawing.Point(137, 188)
        Me.secondCardNumberTB.Margin = New System.Windows.Forms.Padding(2)
        Me.secondCardNumberTB.Name = "secondCardNumberTB"
        Me.secondCardNumberTB.Size = New System.Drawing.Size(46, 20)
        Me.secondCardNumberTB.TabIndex = 21
        '
        'thirdCardNumberTB
        '
        Me.thirdCardNumberTB.Location = New System.Drawing.Point(199, 188)
        Me.thirdCardNumberTB.Margin = New System.Windows.Forms.Padding(2)
        Me.thirdCardNumberTB.Name = "thirdCardNumberTB"
        Me.thirdCardNumberTB.Size = New System.Drawing.Size(46, 20)
        Me.thirdCardNumberTB.TabIndex = 22
        '
        'fourthCardNumberTB
        '
        Me.fourthCardNumberTB.Location = New System.Drawing.Point(261, 188)
        Me.fourthCardNumberTB.Margin = New System.Windows.Forms.Padding(2)
        Me.fourthCardNumberTB.Name = "fourthCardNumberTB"
        Me.fourthCardNumberTB.Size = New System.Drawing.Size(46, 20)
        Me.fourthCardNumberTB.TabIndex = 23
        '
        'cardExpDate
        '
        Me.cardExpDate.AutoSize = True
        Me.cardExpDate.Location = New System.Drawing.Point(12, 222)
        Me.cardExpDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cardExpDate.Name = "cardExpDate"
        Me.cardExpDate.Size = New System.Drawing.Size(54, 13)
        Me.cardExpDate.TabIndex = 27
        Me.cardExpDate.Text = "Exp. Date"
        '
        'firstExpDateTB
        '
        Me.firstExpDateTB.Location = New System.Drawing.Point(73, 220)
        Me.firstExpDateTB.Margin = New System.Windows.Forms.Padding(2)
        Me.firstExpDateTB.Name = "firstExpDateTB"
        Me.firstExpDateTB.Size = New System.Drawing.Size(27, 20)
        Me.firstExpDateTB.TabIndex = 28
        '
        'secondExpDateTB
        '
        Me.secondExpDateTB.Location = New System.Drawing.Point(117, 220)
        Me.secondExpDateTB.Margin = New System.Windows.Forms.Padding(2)
        Me.secondExpDateTB.Name = "secondExpDateTB"
        Me.secondExpDateTB.Size = New System.Drawing.Size(27, 20)
        Me.secondExpDateTB.TabIndex = 30
        '
        'ccvNumber
        '
        Me.ccvNumber.AutoSize = True
        Me.ccvNumber.Location = New System.Drawing.Point(159, 224)
        Me.ccvNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ccvNumber.Name = "ccvNumber"
        Me.ccvNumber.Size = New System.Drawing.Size(28, 13)
        Me.ccvNumber.TabIndex = 31
        Me.ccvNumber.Text = "CCV"
        '
        'ccvTB
        '
        Me.ccvTB.Location = New System.Drawing.Point(191, 220)
        Me.ccvTB.Margin = New System.Windows.Forms.Padding(2)
        Me.ccvTB.Name = "ccvTB"
        Me.ccvTB.Size = New System.Drawing.Size(33, 20)
        Me.ccvTB.TabIndex = 32
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(146, 252)
        Me.submitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(69, 21)
        Me.submitBtn.TabIndex = 33
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'city
        '
        Me.city.AutoSize = True
        Me.city.Location = New System.Drawing.Point(35, 125)
        Me.city.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(24, 13)
        Me.city.TabIndex = 34
        Me.city.Text = "City"
        '
        'cityTB
        '
        Me.cityTB.Location = New System.Drawing.Point(75, 123)
        Me.cityTB.Margin = New System.Windows.Forms.Padding(2)
        Me.cityTB.Name = "cityTB"
        Me.cityTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cityTB.Size = New System.Drawing.Size(234, 20)
        Me.cityTB.TabIndex = 35
        '
        'dashNull
        '
        Me.dashNull.AutoSize = True
        Me.dashNull.Location = New System.Drawing.Point(245, 157)
        Me.dashNull.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dashNull.Name = "dashNull"
        Me.dashNull.Size = New System.Drawing.Size(10, 13)
        Me.dashNull.TabIndex = 36
        Me.dashNull.Text = "-"
        '
        'dashNull5
        '
        Me.dashNull5.AutoSize = True
        Me.dashNull5.Location = New System.Drawing.Point(103, 222)
        Me.dashNull5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dashNull5.Name = "dashNull5"
        Me.dashNull5.Size = New System.Drawing.Size(10, 13)
        Me.dashNull5.TabIndex = 37
        Me.dashNull5.Text = "-"
        '
        'dashNull2
        '
        Me.dashNull2.AutoSize = True
        Me.dashNull2.Location = New System.Drawing.Point(245, 190)
        Me.dashNull2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dashNull2.Name = "dashNull2"
        Me.dashNull2.Size = New System.Drawing.Size(10, 13)
        Me.dashNull2.TabIndex = 37
        Me.dashNull2.Text = "-"
        '
        'dashNull4
        '
        Me.dashNull4.AutoSize = True
        Me.dashNull4.Location = New System.Drawing.Point(124, 188)
        Me.dashNull4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dashNull4.Name = "dashNull4"
        Me.dashNull4.Size = New System.Drawing.Size(10, 13)
        Me.dashNull4.TabIndex = 38
        Me.dashNull4.Text = "-"
        '
        'dashNull3
        '
        Me.dashNull3.AutoSize = True
        Me.dashNull3.Location = New System.Drawing.Point(186, 190)
        Me.dashNull3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dashNull3.Name = "dashNull3"
        Me.dashNull3.Size = New System.Drawing.Size(10, 13)
        Me.dashNull3.TabIndex = 38
        Me.dashNull3.Text = "-"
        '
        'PaymentSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 300)
        Me.Controls.Add(Me.dashNull3)
        Me.Controls.Add(Me.dashNull4)
        Me.Controls.Add(Me.dashNull2)
        Me.Controls.Add(Me.dashNull5)
        Me.Controls.Add(Me.dashNull)
        Me.Controls.Add(Me.cityTB)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.ccvTB)
        Me.Controls.Add(Me.ccvNumber)
        Me.Controls.Add(Me.secondExpDateTB)
        Me.Controls.Add(Me.firstExpDateTB)
        Me.Controls.Add(Me.cardExpDate)
        Me.Controls.Add(Me.fourthCardNumberTB)
        Me.Controls.Add(Me.thirdCardNumberTB)
        Me.Controls.Add(Me.secondCardNumberTB)
        Me.Controls.Add(Me.firstCardNumberTB)
        Me.Controls.Add(Me.cardNumber)
        Me.Controls.Add(Me.secondHalfZipTB)
        Me.Controls.Add(Me.firstHalfZipTB)
        Me.Controls.Add(Me.stateComboBox)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.zipCode)
        Me.Controls.Add(Me.addressTwoTB)
        Me.Controls.Add(Me.addressOneTB)
        Me.Controls.Add(Me.middleInitialTB)
        Me.Controls.Add(Me.lastNameTB)
        Me.Controls.Add(Me.firstNameTB)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.middleIntial)
        Me.Controls.Add(Me.addressOne)
        Me.Controls.Add(Me.addressTwo)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.previousBtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PaymentSystem"
        Me.Text = "Payment System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents previousBtn As Button
    Friend WithEvents firstName As Label
    Friend WithEvents addressTwo As Label
    Friend WithEvents addressOne As Label
    Friend WithEvents middleIntial As Label
    Friend WithEvents lastName As Label
    Friend WithEvents firstNameTB As TextBox
    Friend WithEvents lastNameTB As TextBox
    Friend WithEvents middleInitialTB As TextBox
    Friend WithEvents addressOneTB As TextBox
    Friend WithEvents addressTwoTB As TextBox
    Friend WithEvents zipCode As Label
    Friend WithEvents state As Label
    Friend WithEvents stateComboBox As ComboBox
    Friend WithEvents firstHalfZipTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents secondHalfZipTB As TextBox
    Friend WithEvents cardNumber As Label
    Friend WithEvents firstCardNumberTB As TextBox
    Friend WithEvents secondCardNumberTB As TextBox
    Friend WithEvents thirdCardNumberTB As TextBox
    Friend WithEvents fourthCardNumberTB As TextBox
    Friend WithEvents cardExpDate As Label
    Friend WithEvents firstExpDateTB As TextBox
    Friend WithEvents secondExpDateTB As TextBox
    Friend WithEvents ccvNumber As Label
    Friend WithEvents ccvTB As TextBox
    Friend WithEvents submitBtn As Button
    Friend WithEvents city As Label
    Friend WithEvents cityTB As TextBox
    Friend WithEvents dashNull As Label
    Friend WithEvents dashNull5 As Label
    Friend WithEvents dashNull2 As Label
    Friend WithEvents dashNull4 As Label
    Friend WithEvents dashNull3 As Label
End Class
