<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.loginLogoPictBx = New System.Windows.Forms.PictureBox()
        Me.loginWelcomeLabel = New System.Windows.Forms.Label()
        Me.loginUsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.loginPasswordTxtBx = New System.Windows.Forms.TextBox()
        Me.exitLoginBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.loginUsernameLabel = New System.Windows.Forms.Label()
        Me.loginPasswordLabel = New System.Windows.Forms.Label()
        Me.loginErrorLable = New System.Windows.Forms.Label()
        CType(Me.loginLogoPictBx, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.loginUsernameTxtBx.Location = New System.Drawing.Point(230, 292)
        Me.loginUsernameTxtBx.Name = "loginUsernameTxtBx"
        Me.loginUsernameTxtBx.Size = New System.Drawing.Size(233, 27)
        Me.loginUsernameTxtBx.TabIndex = 2
        '
        'loginPasswordTxtBx
        '
        Me.loginPasswordTxtBx.Location = New System.Drawing.Point(230, 365)
        Me.loginPasswordTxtBx.Name = "loginPasswordTxtBx"
        Me.loginPasswordTxtBx.Size = New System.Drawing.Size(233, 27)
        Me.loginPasswordTxtBx.TabIndex = 3
        '
        'exitLoginBtn
        '
        Me.exitLoginBtn.BackColor = System.Drawing.Color.Orange
        Me.exitLoginBtn.Location = New System.Drawing.Point(206, 438)
        Me.exitLoginBtn.Name = "exitLoginBtn"
        Me.exitLoginBtn.Size = New System.Drawing.Size(122, 51)
        Me.exitLoginBtn.TabIndex = 4
        Me.exitLoginBtn.Text = "Exit"
        Me.exitLoginBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Orange
        Me.loginBtn.Location = New System.Drawing.Point(334, 438)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(129, 50)
        Me.loginBtn.TabIndex = 5
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'loginUsernameLabel
        '
        Me.loginUsernameLabel.AutoSize = True
        Me.loginUsernameLabel.Location = New System.Drawing.Point(230, 269)
        Me.loginUsernameLabel.Name = "loginUsernameLabel"
        Me.loginUsernameLabel.Size = New System.Drawing.Size(80, 20)
        Me.loginUsernameLabel.TabIndex = 6
        Me.loginUsernameLabel.Text = "Username"
        '
        'loginPasswordLabel
        '
        Me.loginPasswordLabel.AutoSize = True
        Me.loginPasswordLabel.Location = New System.Drawing.Point(230, 342)
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
        Me.loginErrorLable.Location = New System.Drawing.Point(164, 537)
        Me.loginErrorLable.Name = "loginErrorLable"
        Me.loginErrorLable.Size = New System.Drawing.Size(44, 20)
        Me.loginErrorLable.TabIndex = 8
        Me.loginErrorLable.Text = "error"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 631)
        Me.Controls.Add(Me.loginErrorLable)
        Me.Controls.Add(Me.loginPasswordLabel)
        Me.Controls.Add(Me.loginUsernameLabel)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.exitLoginBtn)
        Me.Controls.Add(Me.loginPasswordTxtBx)
        Me.Controls.Add(Me.loginUsernameTxtBx)
        Me.Controls.Add(Me.loginWelcomeLabel)
        Me.Controls.Add(Me.loginLogoPictBx)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "loginForm"
        Me.Text = "Login"
        CType(Me.loginLogoPictBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginLogoPictBx As System.Windows.Forms.PictureBox
    Friend WithEvents loginWelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents loginUsernameTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents loginPasswordTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents exitLoginBtn As System.Windows.Forms.Button
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents loginUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents loginPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents loginErrorLable As System.Windows.Forms.Label

End Class
