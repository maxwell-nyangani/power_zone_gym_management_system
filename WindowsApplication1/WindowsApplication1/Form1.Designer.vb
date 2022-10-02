<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.loginLogoPictBx = New System.Windows.Forms.PictureBox()
        Me.loginWelcomeLabel = New System.Windows.Forms.Label()
        Me.loginUsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.loginPasswordTxtBx = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.loginUsernameLabel = New System.Windows.Forms.Label()
        Me.loginPasswordLabel = New System.Windows.Forms.Label()
        Me.loginErrorLable = New System.Windows.Forms.Label()
        Me.PowerZoneGymDatabaseDataSet = New WindowsApplication1.PowerZoneGymDatabaseDataSet()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.memberTableAdapter()
        CType(Me.loginLogoPictBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerZoneGymDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginLogoPictBx
        '
        Me.loginLogoPictBx.Image = CType(resources.GetObject("loginLogoPictBx.Image"), System.Drawing.Image)
        Me.loginLogoPictBx.Location = New System.Drawing.Point(75, 122)
        Me.loginLogoPictBx.Name = "loginLogoPictBx"
        Me.loginLogoPictBx.Size = New System.Drawing.Size(530, 109)
        Me.loginLogoPictBx.TabIndex = 0
        Me.loginLogoPictBx.TabStop = False
        '
        'loginWelcomeLabel
        '
        Me.loginWelcomeLabel.AutoSize = True
        Me.loginWelcomeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginWelcomeLabel.Location = New System.Drawing.Point(253, 82)
        Me.loginWelcomeLabel.Name = "loginWelcomeLabel"
        Me.loginWelcomeLabel.Size = New System.Drawing.Size(112, 28)
        Me.loginWelcomeLabel.TabIndex = 1
        Me.loginWelcomeLabel.Text = "Welcome! "
        '
        'loginUsernameTxtBx
        '
        Me.loginUsernameTxtBx.Location = New System.Drawing.Point(225, 292)
        Me.loginUsernameTxtBx.Name = "loginUsernameTxtBx"
        Me.loginUsernameTxtBx.Size = New System.Drawing.Size(238, 27)
        Me.loginUsernameTxtBx.TabIndex = 2
        '
        'loginPasswordTxtBx
        '
        Me.loginPasswordTxtBx.Location = New System.Drawing.Point(225, 345)
        Me.loginPasswordTxtBx.Name = "loginPasswordTxtBx"
        Me.loginPasswordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPasswordTxtBx.Size = New System.Drawing.Size(238, 27)
        Me.loginPasswordTxtBx.TabIndex = 3
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Orange
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(224, 389)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(239, 39)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'loginUsernameLabel
        '
        Me.loginUsernameLabel.AutoSize = True
        Me.loginUsernameLabel.Location = New System.Drawing.Point(220, 269)
        Me.loginUsernameLabel.Name = "loginUsernameLabel"
        Me.loginUsernameLabel.Size = New System.Drawing.Size(80, 20)
        Me.loginUsernameLabel.TabIndex = 6
        Me.loginUsernameLabel.Text = "Username"
        '
        'loginPasswordLabel
        '
        Me.loginPasswordLabel.AutoSize = True
        Me.loginPasswordLabel.Location = New System.Drawing.Point(221, 322)
        Me.loginPasswordLabel.Name = "loginPasswordLabel"
        Me.loginPasswordLabel.Size = New System.Drawing.Size(76, 20)
        Me.loginPasswordLabel.TabIndex = 7
        Me.loginPasswordLabel.Text = "Password"
        '
        'loginErrorLable
        '
        Me.loginErrorLable.AutoSize = True
        Me.loginErrorLable.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginErrorLable.ForeColor = System.Drawing.Color.Red
        Me.loginErrorLable.Location = New System.Drawing.Point(220, 457)
        Me.loginErrorLable.Name = "loginErrorLable"
        Me.loginErrorLable.Size = New System.Drawing.Size(0, 20)
        Me.loginErrorLable.TabIndex = 8
        '
        'PowerZoneGymDatabaseDataSet
        '
        Me.PowerZoneGymDatabaseDataSet.DataSetName = "PowerZoneGymDatabaseDataSet"
        Me.PowerZoneGymDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.PowerZoneGymDatabaseDataSet
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 576)
        Me.Controls.Add(Me.loginErrorLable)
        Me.Controls.Add(Me.loginPasswordLabel)
        Me.Controls.Add(Me.loginUsernameLabel)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.loginPasswordTxtBx)
        Me.Controls.Add(Me.loginUsernameTxtBx)
        Me.Controls.Add(Me.loginWelcomeLabel)
        Me.Controls.Add(Me.loginLogoPictBx)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "Login"
        CType(Me.loginLogoPictBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerZoneGymDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginLogoPictBx As System.Windows.Forms.PictureBox
    Friend WithEvents loginWelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents loginUsernameTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents loginPasswordTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents loginUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents loginPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents loginErrorLable As System.Windows.Forms.Label
    Friend WithEvents PowerZoneGymDatabaseDataSet As WindowsApplication1.PowerZoneGymDatabaseDataSet
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberTableAdapter As WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.memberTableAdapter

End Class
