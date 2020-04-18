<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historicalBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historicalBill))
        Me.historicalBillViewer = New System.Windows.Forms.Label()
        Me.reciptListBox = New System.Windows.Forms.ListBox()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.doctorName = New System.Windows.Forms.Label()
        Me.reciptNumber = New System.Windows.Forms.Label()
        Me.amountLable = New System.Windows.Forms.Label()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'historicalBillViewer
        '
        Me.historicalBillViewer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.historicalBillViewer.AutoSize = True
        Me.historicalBillViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historicalBillViewer.Location = New System.Drawing.Point(255, 20)
        Me.historicalBillViewer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.historicalBillViewer.Name = "historicalBillViewer"
        Me.historicalBillViewer.Size = New System.Drawing.Size(209, 74)
        Me.historicalBillViewer.TabIndex = 0
        Me.historicalBillViewer.Text = "Historical Bill " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Viewer"
        '
        'reciptListBox
        '
        Me.reciptListBox.FormattingEnabled = True
        Me.reciptListBox.ItemHeight = 20
        Me.reciptListBox.Items.AddRange(New Object() {"04/07/2020      Bechie                RC56813A3                   $15,897.36"})
        Me.reciptListBox.Location = New System.Drawing.Point(18, 171)
        Me.reciptListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reciptListBox.Name = "reciptListBox"
        Me.reciptListBox.Size = New System.Drawing.Size(514, 404)
        Me.reciptListBox.TabIndex = 1
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dateLabel.Location = New System.Drawing.Point(18, 146)
        Me.dateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(57, 25)
        Me.dateLabel.TabIndex = 2
        Me.dateLabel.Text = "Date"
        '
        'doctorName
        '
        Me.doctorName.AutoSize = True
        Me.doctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctorName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.doctorName.Location = New System.Drawing.Point(136, 146)
        Me.doctorName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.doctorName.Name = "doctorName"
        Me.doctorName.Size = New System.Drawing.Size(75, 25)
        Me.doctorName.TabIndex = 3
        Me.doctorName.Text = "Doctor"
        '
        'reciptNumber
        '
        Me.reciptNumber.AutoSize = True
        Me.reciptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reciptNumber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.reciptNumber.Location = New System.Drawing.Point(258, 146)
        Me.reciptNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.reciptNumber.Name = "reciptNumber"
        Me.reciptNumber.Size = New System.Drawing.Size(153, 25)
        Me.reciptNumber.TabIndex = 4
        Me.reciptNumber.Text = "Recipt Number"
        '
        'amountLable
        '
        Me.amountLable.AutoSize = True
        Me.amountLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountLable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.amountLable.Location = New System.Drawing.Point(430, 146)
        Me.amountLable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amountLable.Name = "amountLable"
        Me.amountLable.Size = New System.Drawing.Size(86, 25)
        Me.amountLable.TabIndex = 5
        Me.amountLable.Text = "Amount"
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(16, 606)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(92, 32)
        Me.previousBtn.TabIndex = 6
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57393!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42606!))
        Me.TableLayoutPanel1.Controls.Add(Me.historicalBillViewer, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-2, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(555, 114)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'historicalBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(548, 655)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.amountLable)
        Me.Controls.Add(Me.reciptNumber)
        Me.Controls.Add(Me.doctorName)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.reciptListBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "historicalBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historical Bill"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents historicalBillViewer As Label
    Friend WithEvents reciptListBox As ListBox
    Friend WithEvents dateLabel As Label
    Friend WithEvents doctorName As Label
    Friend WithEvents reciptNumber As Label
    Friend WithEvents amountLable As Label
    Friend WithEvents previousBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
