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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ciprofloxacin", "100mg", "30", "5", "Bechie", "CVS"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Pantoprazole", "40mg", "120", "10", "Lewis", "Walgreens"}, -1)
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.medicationList = New System.Windows.Forms.Label()
        Me.directions = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.med_ListView = New System.Windows.Forms.ListView()
        Me.Med_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Med_Dosage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Med_Qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Med_refill = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Med_Doc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Med_Pharmacy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(15, 445)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(61, 21)
        Me.previousBtn.TabIndex = 12
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'medicationList
        '
        Me.medicationList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.medicationList.AutoSize = True
        Me.medicationList.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medicationList.Location = New System.Drawing.Point(231, 17)
        Me.medicationList.Name = "medicationList"
        Me.medicationList.Size = New System.Drawing.Size(202, 31)
        Me.medicationList.TabIndex = 13
        Me.medicationList.Text = "Medication List "
        '
        'directions
        '
        Me.directions.AutoSize = True
        Me.directions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.directions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.directions.Location = New System.Drawing.Point(12, 86)
        Me.directions.Name = "directions"
        Me.directions.Size = New System.Drawing.Size(471, 18)
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(539, 65)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'med_ListView
        '
        Me.med_ListView.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.med_ListView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.med_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.med_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Med_Name, Me.Med_Dosage, Me.Med_Qty, Me.Med_refill, Me.Med_Doc, Me.Med_Pharmacy})
        Me.med_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.med_ListView.HideSelection = False
        Me.med_ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.med_ListView.Location = New System.Drawing.Point(15, 134)
        Me.med_ListView.MultiSelect = False
        Me.med_ListView.Name = "med_ListView"
        Me.med_ListView.Size = New System.Drawing.Size(468, 296)
        Me.med_ListView.TabIndex = 19
        Me.med_ListView.UseCompatibleStateImageBehavior = False
        Me.med_ListView.View = System.Windows.Forms.View.Details
        '
        'Med_Name
        '
        Me.Med_Name.Text = "Name"
        Me.Med_Name.Width = 109
        '
        'Med_Dosage
        '
        Me.Med_Dosage.Text = "Dosage"
        Me.Med_Dosage.Width = 67
        '
        'Med_Qty
        '
        Me.Med_Qty.Text = "Quantity"
        Me.Med_Qty.Width = 64
        '
        'Med_refill
        '
        Me.Med_refill.Text = "Refills"
        Me.Med_refill.Width = 51
        '
        'Med_Doc
        '
        Me.Med_Doc.Text = "Doctor"
        Me.Med_Doc.Width = 91
        '
        'Med_Pharmacy
        '
        Me.Med_Pharmacy.Text = "Pharmacy"
        Me.Med_Pharmacy.Width = 80
        '
        'MedicationRefilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(533, 477)
        Me.Controls.Add(Me.med_ListView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.directions)
        Me.Controls.Add(Me.previousBtn)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents medicationList As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles medicationList.Click

    End Sub

    Friend WithEvents directions As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents med_ListView As ListView
    Friend WithEvents Med_Name As ColumnHeader
    Friend WithEvents Med_Dosage As ColumnHeader
    Friend WithEvents Med_Qty As ColumnHeader
    Friend WithEvents Med_refill As ColumnHeader
    Friend WithEvents Med_Doc As ColumnHeader
    Friend WithEvents Med_Pharmacy As ColumnHeader
End Class
