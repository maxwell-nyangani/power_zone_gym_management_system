<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPackageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPackageForm))
        Me.titleTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.descriptionTxtBx = New System.Windows.Forms.TextBox()
        Me.referenceCodeTxtBx = New System.Windows.Forms.TextBox()
        Me.saveCreatePackageBtn = New System.Windows.Forms.Button()
        Me.cancelCreatPackageBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.priceNumUpDwn = New System.Windows.Forms.NumericUpDown()
        Me.targetSexCBx = New System.Windows.Forms.ComboBox()
        Me.isActiveChkBx = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.priceNumUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleTxtBx
        '
        Me.titleTxtBx.Location = New System.Drawing.Point(223, 188)
        Me.titleTxtBx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.titleTxtBx.Name = "titleTxtBx"
        Me.titleTxtBx.Size = New System.Drawing.Size(322, 27)
        Me.titleTxtBx.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Target Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Is Active?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Reference code"
        '
        'descriptionTxtBx
        '
        Me.descriptionTxtBx.Location = New System.Drawing.Point(223, 223)
        Me.descriptionTxtBx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.descriptionTxtBx.Name = "descriptionTxtBx"
        Me.descriptionTxtBx.Size = New System.Drawing.Size(322, 27)
        Me.descriptionTxtBx.TabIndex = 8
        '
        'referenceCodeTxtBx
        '
        Me.referenceCodeTxtBx.Location = New System.Drawing.Point(223, 363)
        Me.referenceCodeTxtBx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.referenceCodeTxtBx.Name = "referenceCodeTxtBx"
        Me.referenceCodeTxtBx.Size = New System.Drawing.Size(322, 27)
        Me.referenceCodeTxtBx.TabIndex = 12
        '
        'saveCreatePackageBtn
        '
        Me.saveCreatePackageBtn.BackColor = System.Drawing.Color.Orange
        Me.saveCreatePackageBtn.ForeColor = System.Drawing.Color.White
        Me.saveCreatePackageBtn.Location = New System.Drawing.Point(506, 483)
        Me.saveCreatePackageBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.saveCreatePackageBtn.Name = "saveCreatePackageBtn"
        Me.saveCreatePackageBtn.Size = New System.Drawing.Size(84, 29)
        Me.saveCreatePackageBtn.TabIndex = 14
        Me.saveCreatePackageBtn.Text = "Save"
        Me.saveCreatePackageBtn.UseVisualStyleBackColor = False
        '
        'cancelCreatPackageBtn
        '
        Me.cancelCreatPackageBtn.BackColor = System.Drawing.Color.Orange
        Me.cancelCreatPackageBtn.ForeColor = System.Drawing.Color.White
        Me.cancelCreatPackageBtn.Location = New System.Drawing.Point(401, 483)
        Me.cancelCreatPackageBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancelCreatPackageBtn.Name = "cancelCreatPackageBtn"
        Me.cancelCreatPackageBtn.Size = New System.Drawing.Size(99, 29)
        Me.cancelCreatPackageBtn.TabIndex = 15
        Me.cancelCreatPackageBtn.Text = "Cancel"
        Me.cancelCreatPackageBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(219, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Error"
        '
        'priceNumUpDwn
        '
        Me.priceNumUpDwn.Location = New System.Drawing.Point(223, 258)
        Me.priceNumUpDwn.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.priceNumUpDwn.Name = "priceNumUpDwn"
        Me.priceNumUpDwn.Size = New System.Drawing.Size(277, 27)
        Me.priceNumUpDwn.TabIndex = 18
        '
        'targetSexCBx
        '
        Me.targetSexCBx.FormattingEnabled = True
        Me.targetSexCBx.Items.AddRange(New Object() {"Male", "Female", "Unisex"})
        Me.targetSexCBx.Location = New System.Drawing.Point(223, 297)
        Me.targetSexCBx.Name = "targetSexCBx"
        Me.targetSexCBx.Size = New System.Drawing.Size(121, 28)
        Me.targetSexCBx.TabIndex = 19
        '
        'isActiveChkBx
        '
        Me.isActiveChkBx.AutoSize = True
        Me.isActiveChkBx.Location = New System.Drawing.Point(223, 332)
        Me.isActiveChkBx.Name = "isActiveChkBx"
        Me.isActiveChkBx.Size = New System.Drawing.Size(108, 24)
        Me.isActiveChkBx.TabIndex = 20
        Me.isActiveChkBx.Text = "CheckBox1"
        Me.isActiveChkBx.UseVisualStyleBackColor = True
        '
        'AddPackageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 529)
        Me.Controls.Add(Me.isActiveChkBx)
        Me.Controls.Add(Me.targetSexCBx)
        Me.Controls.Add(Me.priceNumUpDwn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancelCreatPackageBtn)
        Me.Controls.Add(Me.saveCreatePackageBtn)
        Me.Controls.Add(Me.referenceCodeTxtBx)
        Me.Controls.Add(Me.descriptionTxtBx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.titleTxtBx)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddPackageForm"
        Me.Text = "Package Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.priceNumUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents descriptionTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents referenceCodeTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents saveCreatePackageBtn As System.Windows.Forms.Button
    Friend WithEvents cancelCreatPackageBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents priceNumUpDwn As System.Windows.Forms.NumericUpDown
    Friend WithEvents targetSexCBx As System.Windows.Forms.ComboBox
    Friend WithEvents isActiveChkBx As System.Windows.Forms.CheckBox
End Class
