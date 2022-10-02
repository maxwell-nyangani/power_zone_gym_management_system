<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSubscriptionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSubscriptionForm))
        Me.addSubscriptionErrorLable = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cancelSubscriptionBtn = New System.Windows.Forms.Button()
        Me.saveSubscriptionBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.membersCBx = New System.Windows.Forms.ComboBox()
        Me.packagesCBx = New System.Windows.Forms.ComboBox()
        Me.startDateDtTmPckr = New System.Windows.Forms.DateTimePicker()
        Me.endDateDtTmPckr = New System.Windows.Forms.DateTimePicker()
        Me.isActiveChkBx = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addSubscriptionErrorLable
        '
        Me.addSubscriptionErrorLable.AutoSize = True
        Me.addSubscriptionErrorLable.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSubscriptionErrorLable.ForeColor = System.Drawing.Color.Red
        Me.addSubscriptionErrorLable.Location = New System.Drawing.Point(252, 447)
        Me.addSubscriptionErrorLable.Name = "addSubscriptionErrorLable"
        Me.addSubscriptionErrorLable.Size = New System.Drawing.Size(44, 20)
        Me.addSubscriptionErrorLable.TabIndex = 35
        Me.addSubscriptionErrorLable.Text = "Error"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(695, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'cancelSubscriptionBtn
        '
        Me.cancelSubscriptionBtn.BackColor = System.Drawing.Color.Orange
        Me.cancelSubscriptionBtn.ForeColor = System.Drawing.Color.White
        Me.cancelSubscriptionBtn.Location = New System.Drawing.Point(440, 489)
        Me.cancelSubscriptionBtn.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cancelSubscriptionBtn.Name = "cancelSubscriptionBtn"
        Me.cancelSubscriptionBtn.Size = New System.Drawing.Size(111, 36)
        Me.cancelSubscriptionBtn.TabIndex = 33
        Me.cancelSubscriptionBtn.Text = "Cancel"
        Me.cancelSubscriptionBtn.UseVisualStyleBackColor = False
        '
        'saveSubscriptionBtn
        '
        Me.saveSubscriptionBtn.BackColor = System.Drawing.Color.Orange
        Me.saveSubscriptionBtn.ForeColor = System.Drawing.Color.White
        Me.saveSubscriptionBtn.Location = New System.Drawing.Point(557, 489)
        Me.saveSubscriptionBtn.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.saveSubscriptionBtn.Name = "saveSubscriptionBtn"
        Me.saveSubscriptionBtn.Size = New System.Drawing.Size(94, 36)
        Me.saveSubscriptionBtn.TabIndex = 32
        Me.saveSubscriptionBtn.Text = "Save"
        Me.saveSubscriptionBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Is Active?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Member"
        '
        'membersCBx
        '
        Me.membersCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.membersCBx.FormattingEnabled = True
        Me.membersCBx.Location = New System.Drawing.Point(256, 214)
        Me.membersCBx.Name = "membersCBx"
        Me.membersCBx.Size = New System.Drawing.Size(362, 28)
        Me.membersCBx.TabIndex = 36
        '
        'packagesCBx
        '
        Me.packagesCBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.packagesCBx.FormattingEnabled = True
        Me.packagesCBx.Location = New System.Drawing.Point(256, 258)
        Me.packagesCBx.Name = "packagesCBx"
        Me.packagesCBx.Size = New System.Drawing.Size(362, 28)
        Me.packagesCBx.TabIndex = 37
        '
        'startDateDtTmPckr
        '
        Me.startDateDtTmPckr.CustomFormat = "MM/dd/yyyy"
        Me.startDateDtTmPckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDateDtTmPckr.Location = New System.Drawing.Point(256, 299)
        Me.startDateDtTmPckr.Name = "startDateDtTmPckr"
        Me.startDateDtTmPckr.Size = New System.Drawing.Size(362, 27)
        Me.startDateDtTmPckr.TabIndex = 38
        '
        'endDateDtTmPckr
        '
        Me.endDateDtTmPckr.CustomFormat = "MM/dd/yyyy"
        Me.endDateDtTmPckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDateDtTmPckr.Location = New System.Drawing.Point(256, 343)
        Me.endDateDtTmPckr.Name = "endDateDtTmPckr"
        Me.endDateDtTmPckr.Size = New System.Drawing.Size(362, 27)
        Me.endDateDtTmPckr.TabIndex = 39
        '
        'isActiveChkBx
        '
        Me.isActiveChkBx.AutoSize = True
        Me.isActiveChkBx.Location = New System.Drawing.Point(256, 394)
        Me.isActiveChkBx.Name = "isActiveChkBx"
        Me.isActiveChkBx.Size = New System.Drawing.Size(125, 24)
        Me.isActiveChkBx.TabIndex = 40
        Me.isActiveChkBx.Text = "Check if (Yes)"
        Me.isActiveChkBx.UseVisualStyleBackColor = True
        '
        'AddSubscriptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 541)
        Me.Controls.Add(Me.isActiveChkBx)
        Me.Controls.Add(Me.endDateDtTmPckr)
        Me.Controls.Add(Me.startDateDtTmPckr)
        Me.Controls.Add(Me.packagesCBx)
        Me.Controls.Add(Me.membersCBx)
        Me.Controls.Add(Me.addSubscriptionErrorLable)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancelSubscriptionBtn)
        Me.Controls.Add(Me.saveSubscriptionBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "AddSubscriptionForm"
        Me.Text = "Subscription Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addSubscriptionErrorLable As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cancelSubscriptionBtn As System.Windows.Forms.Button
    Friend WithEvents saveSubscriptionBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents membersCBx As System.Windows.Forms.ComboBox
    Friend WithEvents packagesCBx As System.Windows.Forms.ComboBox
    Friend WithEvents startDateDtTmPckr As System.Windows.Forms.DateTimePicker
    Friend WithEvents endDateDtTmPckr As System.Windows.Forms.DateTimePicker
    Friend WithEvents isActiveChkBx As System.Windows.Forms.CheckBox
End Class
