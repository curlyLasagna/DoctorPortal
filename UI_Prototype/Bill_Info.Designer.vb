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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill_Info))
        Me.questionOpener = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currentBillBtn = New System.Windows.Forms.Button()
        Me.historicalBillBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'questionOpener
        '
        Me.questionOpener.AutoSize = True
        Me.questionOpener.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionOpener.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.questionOpener.Location = New System.Drawing.Point(64, 62)
        Me.questionOpener.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.questionOpener.Name = "questionOpener"
        Me.questionOpener.Size = New System.Drawing.Size(213, 20)
        Me.questionOpener.TabIndex = 0
        Me.questionOpener.Text = "What would  you like to view?"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bill Information "
        '
        'currentBillBtn
        '
        Me.currentBillBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.currentBillBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentBillBtn.Location = New System.Drawing.Point(68, 95)
        Me.currentBillBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.currentBillBtn.Name = "currentBillBtn"
        Me.currentBillBtn.Size = New System.Drawing.Size(89, 23)
        Me.currentBillBtn.TabIndex = 2
        Me.currentBillBtn.Text = "Current Bill "
        Me.currentBillBtn.UseVisualStyleBackColor = False
        '
        'historicalBillBtn
        '
        Me.historicalBillBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.historicalBillBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historicalBillBtn.Location = New System.Drawing.Point(187, 95)
        Me.historicalBillBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.historicalBillBtn.Name = "historicalBillBtn"
        Me.historicalBillBtn.Size = New System.Drawing.Size(89, 23)
        Me.historicalBillBtn.TabIndex = 3
        Me.historicalBillBtn.Text = "Historical Bill "
        Me.historicalBillBtn.UseVisualStyleBackColor = False
        '
        'previousBtn
        '
        Me.previousBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousBtn.Location = New System.Drawing.Point(135, 128)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(74, 23)
        Me.previousBtn.TabIndex = 4
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.3523!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.6477!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(329, 59)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Bill_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(329, 162)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.historicalBillBtn)
        Me.Controls.Add(Me.currentBillBtn)
        Me.Controls.Add(Me.questionOpener)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Bill_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill Info"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents questionOpener As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents currentBillBtn As Button
    Friend WithEvents historicalBillBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
