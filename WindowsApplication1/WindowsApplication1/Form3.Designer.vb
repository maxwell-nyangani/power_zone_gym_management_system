<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewMemberForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewMemberForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.titleCBx = New System.Windows.Forms.ComboBox()
        Me.firstNamestxtBx = New System.Windows.Forms.TextBox()
        Me.lastNameTxtBx = New System.Windows.Forms.TextBox()
        Me.sexCBx = New System.Windows.Forms.ComboBox()
        Me.dobDTPckr = New System.Windows.Forms.DateTimePicker()
        Me.addressRTxtBx = New System.Windows.Forms.RichTextBox()
        Me.emailTxtBx = New System.Windows.Forms.TextBox()
        Me.phoneTxtBx = New System.Windows.Forms.TextBox()
        Me.memberSaveBtn = New System.Windows.Forms.Button()
        Me.memberCancelBtn = New System.Windows.Forms.Button()
        Me.memberErrorTxtBx = New System.Windows.Forms.Label()
        Me.cityTxtBx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(667, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Birth day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address"
        '
        'titleCBx
        '
        Me.titleCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.titleCBx.FormattingEnabled = True
        Me.titleCBx.Items.AddRange(New Object() {"Dr", "Prof", "Hon", "Mr", "Mrs", "Miss", "Ms", "Your Excellency", "Sir", "Dame", "Duke", "Duchess"})
        Me.titleCBx.Location = New System.Drawing.Point(151, 160)
        Me.titleCBx.Name = "titleCBx"
        Me.titleCBx.Size = New System.Drawing.Size(222, 31)
        Me.titleCBx.TabIndex = 9
        '
        'firstNamestxtBx
        '
        Me.firstNamestxtBx.Location = New System.Drawing.Point(151, 197)
        Me.firstNamestxtBx.Name = "firstNamestxtBx"
        Me.firstNamestxtBx.Size = New System.Drawing.Size(483, 30)
        Me.firstNamestxtBx.TabIndex = 10
        '
        'lastNameTxtBx
        '
        Me.lastNameTxtBx.Location = New System.Drawing.Point(151, 233)
        Me.lastNameTxtBx.Name = "lastNameTxtBx"
        Me.lastNameTxtBx.Size = New System.Drawing.Size(483, 30)
        Me.lastNameTxtBx.TabIndex = 11
        '
        'sexCBx
        '
        Me.sexCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexCBx.FormattingEnabled = True
        Me.sexCBx.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        Me.sexCBx.Location = New System.Drawing.Point(151, 269)
        Me.sexCBx.Name = "sexCBx"
        Me.sexCBx.Size = New System.Drawing.Size(222, 31)
        Me.sexCBx.TabIndex = 12
        '
        'dobDTPckr
        '
        Me.dobDTPckr.CustomFormat = "MM/dd/yyyy"
        Me.dobDTPckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dobDTPckr.Location = New System.Drawing.Point(151, 306)
        Me.dobDTPckr.Name = "dobDTPckr"
        Me.dobDTPckr.Size = New System.Drawing.Size(331, 30)
        Me.dobDTPckr.TabIndex = 13
        '
        'addressRTxtBx
        '
        Me.addressRTxtBx.Location = New System.Drawing.Point(151, 414)
        Me.addressRTxtBx.Name = "addressRTxtBx"
        Me.addressRTxtBx.Size = New System.Drawing.Size(483, 55)
        Me.addressRTxtBx.TabIndex = 14
        Me.addressRTxtBx.Text = ""
        '
        'emailTxtBx
        '
        Me.emailTxtBx.Location = New System.Drawing.Point(151, 342)
        Me.emailTxtBx.Name = "emailTxtBx"
        Me.emailTxtBx.Size = New System.Drawing.Size(483, 30)
        Me.emailTxtBx.TabIndex = 15
        '
        'phoneTxtBx
        '
        Me.phoneTxtBx.Location = New System.Drawing.Point(151, 378)
        Me.phoneTxtBx.Name = "phoneTxtBx"
        Me.phoneTxtBx.Size = New System.Drawing.Size(483, 30)
        Me.phoneTxtBx.TabIndex = 16
        '
        'memberSaveBtn
        '
        Me.memberSaveBtn.BackColor = System.Drawing.Color.Orange
        Me.memberSaveBtn.ForeColor = System.Drawing.Color.White
        Me.memberSaveBtn.Location = New System.Drawing.Point(531, 590)
        Me.memberSaveBtn.Name = "memberSaveBtn"
        Me.memberSaveBtn.Size = New System.Drawing.Size(135, 36)
        Me.memberSaveBtn.TabIndex = 17
        Me.memberSaveBtn.Text = "Save"
        Me.memberSaveBtn.UseVisualStyleBackColor = False
        '
        'memberCancelBtn
        '
        Me.memberCancelBtn.BackColor = System.Drawing.Color.Orange
        Me.memberCancelBtn.ForeColor = System.Drawing.Color.White
        Me.memberCancelBtn.Location = New System.Drawing.Point(380, 590)
        Me.memberCancelBtn.Name = "memberCancelBtn"
        Me.memberCancelBtn.Size = New System.Drawing.Size(145, 36)
        Me.memberCancelBtn.TabIndex = 18
        Me.memberCancelBtn.Text = "Cancel"
        Me.memberCancelBtn.UseVisualStyleBackColor = False
        '
        'memberErrorTxtBx
        '
        Me.memberErrorTxtBx.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberErrorTxtBx.ForeColor = System.Drawing.Color.Red
        Me.memberErrorTxtBx.Location = New System.Drawing.Point(147, 517)
        Me.memberErrorTxtBx.Name = "memberErrorTxtBx"
        Me.memberErrorTxtBx.Size = New System.Drawing.Size(487, 58)
        Me.memberErrorTxtBx.TabIndex = 19
        Me.memberErrorTxtBx.Text = "Error: "
        '
        'cityTxtBx
        '
        Me.cityTxtBx.Location = New System.Drawing.Point(151, 475)
        Me.cityTxtBx.Name = "cityTxtBx"
        Me.cityTxtBx.Size = New System.Drawing.Size(483, 30)
        Me.cityTxtBx.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(103, 482)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 23)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "City"
        '
        'AddNewMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 637)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cityTxtBx)
        Me.Controls.Add(Me.memberErrorTxtBx)
        Me.Controls.Add(Me.memberCancelBtn)
        Me.Controls.Add(Me.memberSaveBtn)
        Me.Controls.Add(Me.phoneTxtBx)
        Me.Controls.Add(Me.emailTxtBx)
        Me.Controls.Add(Me.addressRTxtBx)
        Me.Controls.Add(Me.dobDTPckr)
        Me.Controls.Add(Me.sexCBx)
        Me.Controls.Add(Me.lastNameTxtBx)
        Me.Controls.Add(Me.firstNamestxtBx)
        Me.Controls.Add(Me.titleCBx)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddNewMemberForm"
        Me.Text = "Add New Member"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents titleCBx As System.Windows.Forms.ComboBox
    Friend WithEvents firstNamestxtBx As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents sexCBx As System.Windows.Forms.ComboBox
    Friend WithEvents dobDTPckr As System.Windows.Forms.DateTimePicker
    Friend WithEvents addressRTxtBx As System.Windows.Forms.RichTextBox
    Friend WithEvents emailTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents phoneTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents memberSaveBtn As System.Windows.Forms.Button
    Friend WithEvents memberCancelBtn As System.Windows.Forms.Button
    Friend WithEvents memberErrorTxtBx As System.Windows.Forms.Label
    Friend WithEvents cityTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
