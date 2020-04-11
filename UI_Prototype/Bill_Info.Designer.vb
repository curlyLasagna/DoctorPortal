<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bill_Info
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
        Me.questionOpener = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currentBillBtn = New System.Windows.Forms.Button()
        Me.historicalBillBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'questionOpener
        '
        Me.questionOpener.AutoSize = True
        Me.questionOpener.Location = New System.Drawing.Point(170, 50)
        Me.questionOpener.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.questionOpener.Name = "questionOpener"
        Me.questionOpener.Size = New System.Drawing.Size(137, 13)
        Me.questionOpener.TabIndex = 0
        Me.questionOpener.Text = "What would  you like view?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(169, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bill Information "
        '
        'currentBillBtn
        '
        Me.currentBillBtn.Location = New System.Drawing.Point(190, 72)
        Me.currentBillBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.currentBillBtn.Name = "currentBillBtn"
        Me.currentBillBtn.Size = New System.Drawing.Size(89, 20)
        Me.currentBillBtn.TabIndex = 2
        Me.currentBillBtn.Text = "Current Bill "
        Me.currentBillBtn.UseVisualStyleBackColor = True
        '
        'historicalBillBtn
        '
        Me.historicalBillBtn.Location = New System.Drawing.Point(190, 105)
        Me.historicalBillBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.historicalBillBtn.Name = "historicalBillBtn"
        Me.historicalBillBtn.Size = New System.Drawing.Size(89, 20)
        Me.historicalBillBtn.TabIndex = 3
        Me.historicalBillBtn.Text = "Historical Bill "
        Me.historicalBillBtn.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(8, 133)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 4
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'Bill_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 162)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.historicalBillBtn)
        Me.Controls.Add(Me.currentBillBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.questionOpener)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Bill_Info"
        Me.Text = "Bill Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents questionOpener As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents currentBillBtn As Button
    Friend WithEvents historicalBillBtn As Button
    Friend WithEvents previousBtn As Button
End Class
