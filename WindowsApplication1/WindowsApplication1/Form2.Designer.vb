<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPageForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPageForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.homeTabPage = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.membersTabPage = New System.Windows.Forms.TabPage()
        Me.deleteSelectedMemberBtn = New System.Windows.Forms.Button()
        Me.searchMembersBtn = New System.Windows.Forms.Button()
        Me.membersSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.addNewMemberBtn = New System.Windows.Forms.Button()
        Me.membersDtGrdVw = New System.Windows.Forms.DataGridView()
        Me.packagesTabPage = New System.Windows.Forms.TabPage()
        Me.searchPackagesTxtBx = New System.Windows.Forms.TextBox()
        Me.searchPackageBtn = New System.Windows.Forms.Button()
        Me.deleteSelectedPackageBtn = New System.Windows.Forms.Button()
        Me.addNewPackageBtn = New System.Windows.Forms.Button()
        Me.packagesDtGrdVw = New System.Windows.Forms.DataGridView()
        Me.subscriptionsTabPage = New System.Windows.Forms.TabPage()
        Me.deleteSelectedSubcriptionBtn = New System.Windows.Forms.Button()
        Me.addNewSubscriptionBtn = New System.Windows.Forms.Button()
        Me.searchSubscriptionBtn = New System.Windows.Forms.Button()
        Me.subscriptionSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.subscriptionsDtGrdVw = New System.Windows.Forms.DataGridView()
        Me.dashboardTabPage = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.settingTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PowerZoneGymDatabaseDataSet = New WindowsApplication1.PowerZoneGymDatabaseDataSet()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.memberTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PackageTableAdapter = New WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.packageTableAdapter()
        Me.SubscriptionTableAdapter = New WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.subscriptionTableAdapter()
        Me.SubscriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.homeTabPage.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.membersTabPage.SuspendLayout()
        CType(Me.membersDtGrdVw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.packagesTabPage.SuspendLayout()
        CType(Me.packagesDtGrdVw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subscriptionsTabPage.SuspendLayout()
        CType(Me.subscriptionsDtGrdVw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardTabPage.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingTabPage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PowerZoneGymDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubscriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(790, 114)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.homeTabPage)
        Me.TabControl1.Controls.Add(Me.membersTabPage)
        Me.TabControl1.Controls.Add(Me.packagesTabPage)
        Me.TabControl1.Controls.Add(Me.subscriptionsTabPage)
        Me.TabControl1.Controls.Add(Me.dashboardTabPage)
        Me.TabControl1.Controls.Add(Me.settingTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(14, 136)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 518)
        Me.TabControl1.TabIndex = 1
        '
        'homeTabPage
        '
        Me.homeTabPage.BackColor = System.Drawing.Color.White
        Me.homeTabPage.Controls.Add(Me.PictureBox5)
        Me.homeTabPage.Controls.Add(Me.PictureBox4)
        Me.homeTabPage.Controls.Add(Me.PictureBox3)
        Me.homeTabPage.Controls.Add(Me.PictureBox2)
        Me.homeTabPage.Controls.Add(Me.Label8)
        Me.homeTabPage.Controls.Add(Me.Label7)
        Me.homeTabPage.Controls.Add(Me.Label6)
        Me.homeTabPage.Controls.Add(Me.Label5)
        Me.homeTabPage.Controls.Add(Me.Label4)
        Me.homeTabPage.Controls.Add(Me.Label3)
        Me.homeTabPage.Controls.Add(Me.Label2)
        Me.homeTabPage.Controls.Add(Me.Label1)
        Me.homeTabPage.Location = New System.Drawing.Point(4, 29)
        Me.homeTabPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.homeTabPage.Name = "homeTabPage"
        Me.homeTabPage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.homeTabPage.Size = New System.Drawing.Size(799, 485)
        Me.homeTabPage.TabIndex = 0
        Me.homeTabPage.Text = "Home"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(437, 224)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(236, 139)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(63, 224)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(217, 139)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(437, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(216, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(67, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(394, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 61)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Get support on how to use the app. Reach out easily to the developers for support" & _
    "."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(33, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 76)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Get the most up to date insights into your gym data. Helps to make good decisions" & _
    "."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(414, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 59)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Easy to add new joiners to your system. Streamlined experience."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(33, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 59)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Easily manage your gym members in an intuitive way!"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(490, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Support"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(58, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Analysis and Insights"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(490, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subscriptions"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(89, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Memberships"
        '
        'membersTabPage
        '
        Me.membersTabPage.Controls.Add(Me.deleteSelectedMemberBtn)
        Me.membersTabPage.Controls.Add(Me.searchMembersBtn)
        Me.membersTabPage.Controls.Add(Me.membersSearchTxtBx)
        Me.membersTabPage.Controls.Add(Me.addNewMemberBtn)
        Me.membersTabPage.Controls.Add(Me.membersDtGrdVw)
        Me.membersTabPage.Location = New System.Drawing.Point(4, 29)
        Me.membersTabPage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.membersTabPage.Name = "membersTabPage"
        Me.membersTabPage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.membersTabPage.Size = New System.Drawing.Size(799, 485)
        Me.membersTabPage.TabIndex = 1
        Me.membersTabPage.Text = "Members"
        Me.membersTabPage.UseVisualStyleBackColor = True
        '
        'deleteSelectedMemberBtn
        '
        Me.deleteSelectedMemberBtn.BackColor = System.Drawing.Color.Orange
        Me.deleteSelectedMemberBtn.ForeColor = System.Drawing.Color.White
        Me.deleteSelectedMemberBtn.Location = New System.Drawing.Point(627, 64)
        Me.deleteSelectedMemberBtn.Name = "deleteSelectedMemberBtn"
        Me.deleteSelectedMemberBtn.Size = New System.Drawing.Size(166, 29)
        Me.deleteSelectedMemberBtn.TabIndex = 4
        Me.deleteSelectedMemberBtn.Text = "Delete selected"
        Me.deleteSelectedMemberBtn.UseVisualStyleBackColor = False
        '
        'searchMembersBtn
        '
        Me.searchMembersBtn.BackColor = System.Drawing.Color.Orange
        Me.searchMembersBtn.ForeColor = System.Drawing.Color.White
        Me.searchMembersBtn.Location = New System.Drawing.Point(324, 64)
        Me.searchMembersBtn.Name = "searchMembersBtn"
        Me.searchMembersBtn.Size = New System.Drawing.Size(75, 29)
        Me.searchMembersBtn.TabIndex = 3
        Me.searchMembersBtn.Text = "Search"
        Me.searchMembersBtn.UseVisualStyleBackColor = False
        '
        'membersSearchTxtBx
        '
        Me.membersSearchTxtBx.Location = New System.Drawing.Point(6, 66)
        Me.membersSearchTxtBx.Name = "membersSearchTxtBx"
        Me.membersSearchTxtBx.Size = New System.Drawing.Size(312, 27)
        Me.membersSearchTxtBx.TabIndex = 2
        '
        'addNewMemberBtn
        '
        Me.addNewMemberBtn.BackColor = System.Drawing.Color.Orange
        Me.addNewMemberBtn.ForeColor = System.Drawing.Color.White
        Me.addNewMemberBtn.Location = New System.Drawing.Point(627, 3)
        Me.addNewMemberBtn.Name = "addNewMemberBtn"
        Me.addNewMemberBtn.Size = New System.Drawing.Size(169, 40)
        Me.addNewMemberBtn.TabIndex = 1
        Me.addNewMemberBtn.Text = "Add New Member"
        Me.addNewMemberBtn.UseVisualStyleBackColor = False
        '
        'membersDtGrdVw
        '
        Me.membersDtGrdVw.AllowUserToAddRows = False
        Me.membersDtGrdVw.AllowUserToOrderColumns = True
        Me.membersDtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.membersDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.membersDtGrdVw.Location = New System.Drawing.Point(6, 99)
        Me.membersDtGrdVw.Name = "membersDtGrdVw"
        Me.membersDtGrdVw.RowTemplate.Height = 24
        Me.membersDtGrdVw.Size = New System.Drawing.Size(787, 379)
        Me.membersDtGrdVw.TabIndex = 0
        '
        'packagesTabPage
        '
        Me.packagesTabPage.Controls.Add(Me.searchPackagesTxtBx)
        Me.packagesTabPage.Controls.Add(Me.searchPackageBtn)
        Me.packagesTabPage.Controls.Add(Me.deleteSelectedPackageBtn)
        Me.packagesTabPage.Controls.Add(Me.addNewPackageBtn)
        Me.packagesTabPage.Controls.Add(Me.packagesDtGrdVw)
        Me.packagesTabPage.Location = New System.Drawing.Point(4, 29)
        Me.packagesTabPage.Name = "packagesTabPage"
        Me.packagesTabPage.Size = New System.Drawing.Size(799, 485)
        Me.packagesTabPage.TabIndex = 5
        Me.packagesTabPage.Text = "Packages"
        Me.packagesTabPage.UseVisualStyleBackColor = True
        '
        'searchPackagesTxtBx
        '
        Me.searchPackagesTxtBx.Location = New System.Drawing.Point(3, 55)
        Me.searchPackagesTxtBx.Name = "searchPackagesTxtBx"
        Me.searchPackagesTxtBx.Size = New System.Drawing.Size(269, 27)
        Me.searchPackagesTxtBx.TabIndex = 4
        '
        'searchPackageBtn
        '
        Me.searchPackageBtn.BackColor = System.Drawing.Color.Orange
        Me.searchPackageBtn.ForeColor = System.Drawing.Color.White
        Me.searchPackageBtn.Location = New System.Drawing.Point(278, 53)
        Me.searchPackageBtn.Name = "searchPackageBtn"
        Me.searchPackageBtn.Size = New System.Drawing.Size(75, 31)
        Me.searchPackageBtn.TabIndex = 3
        Me.searchPackageBtn.Text = "Search"
        Me.searchPackageBtn.UseVisualStyleBackColor = False
        '
        'deleteSelectedPackageBtn
        '
        Me.deleteSelectedPackageBtn.BackColor = System.Drawing.Color.Orange
        Me.deleteSelectedPackageBtn.ForeColor = System.Drawing.Color.White
        Me.deleteSelectedPackageBtn.Location = New System.Drawing.Point(635, 53)
        Me.deleteSelectedPackageBtn.Name = "deleteSelectedPackageBtn"
        Me.deleteSelectedPackageBtn.Size = New System.Drawing.Size(161, 36)
        Me.deleteSelectedPackageBtn.TabIndex = 2
        Me.deleteSelectedPackageBtn.Text = "Delete Selected"
        Me.deleteSelectedPackageBtn.UseVisualStyleBackColor = False
        '
        'addNewPackageBtn
        '
        Me.addNewPackageBtn.BackColor = System.Drawing.Color.Orange
        Me.addNewPackageBtn.ForeColor = System.Drawing.Color.White
        Me.addNewPackageBtn.Location = New System.Drawing.Point(637, 3)
        Me.addNewPackageBtn.Name = "addNewPackageBtn"
        Me.addNewPackageBtn.Size = New System.Drawing.Size(159, 38)
        Me.addNewPackageBtn.TabIndex = 1
        Me.addNewPackageBtn.Text = "Add New Package"
        Me.addNewPackageBtn.UseVisualStyleBackColor = False
        '
        'packagesDtGrdVw
        '
        Me.packagesDtGrdVw.AllowUserToAddRows = False
        Me.packagesDtGrdVw.AllowUserToOrderColumns = True
        Me.packagesDtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.packagesDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.packagesDtGrdVw.Location = New System.Drawing.Point(3, 95)
        Me.packagesDtGrdVw.Name = "packagesDtGrdVw"
        Me.packagesDtGrdVw.RowTemplate.Height = 24
        Me.packagesDtGrdVw.Size = New System.Drawing.Size(793, 387)
        Me.packagesDtGrdVw.TabIndex = 0
        '
        'subscriptionsTabPage
        '
        Me.subscriptionsTabPage.Controls.Add(Me.deleteSelectedSubcriptionBtn)
        Me.subscriptionsTabPage.Controls.Add(Me.addNewSubscriptionBtn)
        Me.subscriptionsTabPage.Controls.Add(Me.searchSubscriptionBtn)
        Me.subscriptionsTabPage.Controls.Add(Me.subscriptionSearchTxtBx)
        Me.subscriptionsTabPage.Controls.Add(Me.subscriptionsDtGrdVw)
        Me.subscriptionsTabPage.Location = New System.Drawing.Point(4, 29)
        Me.subscriptionsTabPage.Name = "subscriptionsTabPage"
        Me.subscriptionsTabPage.Size = New System.Drawing.Size(799, 485)
        Me.subscriptionsTabPage.TabIndex = 2
        Me.subscriptionsTabPage.Text = "Subscriptions"
        Me.subscriptionsTabPage.UseVisualStyleBackColor = True
        '
        'deleteSelectedSubcriptionBtn
        '
        Me.deleteSelectedSubcriptionBtn.BackColor = System.Drawing.Color.Orange
        Me.deleteSelectedSubcriptionBtn.ForeColor = System.Drawing.Color.White
        Me.deleteSelectedSubcriptionBtn.Location = New System.Drawing.Point(608, 53)
        Me.deleteSelectedSubcriptionBtn.Name = "deleteSelectedSubcriptionBtn"
        Me.deleteSelectedSubcriptionBtn.Size = New System.Drawing.Size(188, 30)
        Me.deleteSelectedSubcriptionBtn.TabIndex = 4
        Me.deleteSelectedSubcriptionBtn.Text = "Delete Selected"
        Me.deleteSelectedSubcriptionBtn.UseVisualStyleBackColor = False
        '
        'addNewSubscriptionBtn
        '
        Me.addNewSubscriptionBtn.BackColor = System.Drawing.Color.Orange
        Me.addNewSubscriptionBtn.ForeColor = System.Drawing.Color.White
        Me.addNewSubscriptionBtn.Location = New System.Drawing.Point(608, 3)
        Me.addNewSubscriptionBtn.Name = "addNewSubscriptionBtn"
        Me.addNewSubscriptionBtn.Size = New System.Drawing.Size(188, 34)
        Me.addNewSubscriptionBtn.TabIndex = 3
        Me.addNewSubscriptionBtn.Text = "Add New Subscription"
        Me.addNewSubscriptionBtn.UseVisualStyleBackColor = False
        '
        'searchSubscriptionBtn
        '
        Me.searchSubscriptionBtn.BackColor = System.Drawing.Color.Orange
        Me.searchSubscriptionBtn.ForeColor = System.Drawing.Color.White
        Me.searchSubscriptionBtn.Location = New System.Drawing.Point(281, 54)
        Me.searchSubscriptionBtn.Name = "searchSubscriptionBtn"
        Me.searchSubscriptionBtn.Size = New System.Drawing.Size(75, 29)
        Me.searchSubscriptionBtn.TabIndex = 2
        Me.searchSubscriptionBtn.Text = "Search"
        Me.searchSubscriptionBtn.UseVisualStyleBackColor = False
        '
        'subscriptionSearchTxtBx
        '
        Me.subscriptionSearchTxtBx.Location = New System.Drawing.Point(3, 55)
        Me.subscriptionSearchTxtBx.Name = "subscriptionSearchTxtBx"
        Me.subscriptionSearchTxtBx.Size = New System.Drawing.Size(272, 27)
        Me.subscriptionSearchTxtBx.TabIndex = 1
        '
        'subscriptionsDtGrdVw
        '
        Me.subscriptionsDtGrdVw.AllowUserToAddRows = False
        Me.subscriptionsDtGrdVw.AllowUserToOrderColumns = True
        Me.subscriptionsDtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subscriptionsDtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subscriptionsDtGrdVw.Location = New System.Drawing.Point(3, 89)
        Me.subscriptionsDtGrdVw.Name = "subscriptionsDtGrdVw"
        Me.subscriptionsDtGrdVw.RowTemplate.Height = 24
        Me.subscriptionsDtGrdVw.Size = New System.Drawing.Size(793, 393)
        Me.subscriptionsDtGrdVw.TabIndex = 0
        '
        'dashboardTabPage
        '
        Me.dashboardTabPage.Controls.Add(Me.Chart1)
        Me.dashboardTabPage.Location = New System.Drawing.Point(4, 29)
        Me.dashboardTabPage.Name = "dashboardTabPage"
        Me.dashboardTabPage.Size = New System.Drawing.Size(799, 485)
        Me.dashboardTabPage.TabIndex = 3
        Me.dashboardTabPage.Text = "Dashboard"
        Me.dashboardTabPage.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(15, 36)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(425, 263)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'settingTabPage
        '
        Me.settingTabPage.Controls.Add(Me.GroupBox4)
        Me.settingTabPage.Controls.Add(Me.GroupBox3)
        Me.settingTabPage.Controls.Add(Me.GroupBox2)
        Me.settingTabPage.Controls.Add(Me.GroupBox1)
        Me.settingTabPage.Location = New System.Drawing.Point(4, 29)
        Me.settingTabPage.Name = "settingTabPage"
        Me.settingTabPage.Size = New System.Drawing.Size(799, 485)
        Me.settingTabPage.TabIndex = 4
        Me.settingTabPage.Text = "Settings"
        Me.settingTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(388, 242)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 179)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(16, 242)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 179)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(388, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(66, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.memberTableAdapter = Me.MemberTableAdapter
        Me.TableAdapterManager.packageTableAdapter = Me.PackageTableAdapter
        Me.TableAdapterManager.subscriptionTableAdapter = Me.SubscriptionTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'SubscriptionTableAdapter
        '
        Me.SubscriptionTableAdapter.ClearBeforeFill = True
        '
        'SubscriptionBindingSource
        '
        Me.SubscriptionBindingSource.DataMember = "subscription"
        Me.SubscriptionBindingSource.DataSource = Me.PowerZoneGymDatabaseDataSet
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "package"
        Me.PackageBindingSource.DataSource = Me.PowerZoneGymDatabaseDataSet
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 667)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainPageForm"
        Me.Text = "Power Zone Gym"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.homeTabPage.ResumeLayout(False)
        Me.homeTabPage.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.membersTabPage.ResumeLayout(False)
        Me.membersTabPage.PerformLayout()
        CType(Me.membersDtGrdVw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.packagesTabPage.ResumeLayout(False)
        Me.packagesTabPage.PerformLayout()
        CType(Me.packagesDtGrdVw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subscriptionsTabPage.ResumeLayout(False)
        Me.subscriptionsTabPage.PerformLayout()
        CType(Me.subscriptionsDtGrdVw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardTabPage.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingTabPage.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PowerZoneGymDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubscriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents homeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents membersTabPage As System.Windows.Forms.TabPage
    Friend WithEvents subscriptionsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents dashboardTabPage As System.Windows.Forms.TabPage
    Friend WithEvents settingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PowerZoneGymDatabaseDataSet As WindowsApplication1.PowerZoneGymDatabaseDataSet
    Friend WithEvents MemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberTableAdapter As WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.memberTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubscriptionTableAdapter As WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.subscriptionTableAdapter
    Friend WithEvents SubscriptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PackageTableAdapter As WindowsApplication1.PowerZoneGymDatabaseDataSetTableAdapters.packageTableAdapter
    Friend WithEvents PackageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents deleteSelectedMemberBtn As System.Windows.Forms.Button
    Friend WithEvents searchMembersBtn As System.Windows.Forms.Button
    Friend WithEvents membersSearchTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents addNewMemberBtn As System.Windows.Forms.Button
    Friend WithEvents membersDtGrdVw As System.Windows.Forms.DataGridView
    Friend WithEvents subscriptionsDtGrdVw As System.Windows.Forms.DataGridView
    Friend WithEvents packagesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents packagesDtGrdVw As System.Windows.Forms.DataGridView
    Friend WithEvents searchPackagesTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents searchPackageBtn As System.Windows.Forms.Button
    Friend WithEvents deleteSelectedPackageBtn As System.Windows.Forms.Button
    Friend WithEvents addNewPackageBtn As System.Windows.Forms.Button
    Friend WithEvents deleteSelectedSubcriptionBtn As System.Windows.Forms.Button
    Friend WithEvents addNewSubscriptionBtn As System.Windows.Forms.Button
    Friend WithEvents searchSubscriptionBtn As System.Windows.Forms.Button
    Friend WithEvents subscriptionSearchTxtBx As System.Windows.Forms.TextBox
End Class
