Imports System.Data.OleDb
Public Class MainPageForm
    'DB connection variables
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PowerZoneGymDatabase.accdb")

    Private motherForm As Form

    Private addNewMemberForm As AddNewMemberForm

    'CUSTOM methods
    Public Sub initialize(motherForm As Form)
        Me.motherForm = motherForm
        'Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
    End Sub

    Public Sub bindMembersData()
        Dim fetch_members_command As New OleDbCommand("SELECT * FROM member;", connection)
        Dim membersDataAdaptor As New OleDbDataAdapter
        membersDataAdaptor.SelectCommand = fetch_members_command
        Dim membersDataTable As New DataTable
        membersDataTable.Clear()
        membersDataAdaptor.Fill(membersDataTable)
        membersDtGrdVw.DataSource = membersDataTable


    End Sub

    Public Sub bindSubscriptionsData()
        Dim fetch_subscriptions_command As New OleDbCommand("SELECT * FROM subscription;", connection)
        Dim subscriptionsDataAdaptor As New OleDbDataAdapter
        subscriptionsDataAdaptor.SelectCommand = fetch_subscriptions_command
        Dim subscriptionsDataTable As New DataTable
        subscriptionsDataTable.Clear()
        subscriptionsDataAdaptor.Fill(subscriptionsDataTable)
        subscriptionsDtGrdVw.DataSource = subscriptionsDataTable


    End Sub

    Public Sub bindPackagesData()
        Dim fetch_packages_command As New OleDbCommand("SELECT * FROM package;", connection)
        Dim packagesDataAdaptor As New OleDbDataAdapter
        packagesDataAdaptor.SelectCommand = fetch_packages_command
        Dim packagesDataTable As New DataTable
        packagesDataTable.Clear()
        packagesDataAdaptor.Fill(packagesDataTable)
        packagesDtGrdVw.DataSource = packagesDataTable


    End Sub

    'EVENT handlers

    Private Sub addNewMemberBtn_Click(sender As Object, e As EventArgs) Handles addNewMemberBtn.Click
        addNewMemberForm = New AddNewMemberForm
        addNewMemberForm.setDBConnection(Me.connection)
        addNewMemberForm.setIsCreateMode(True)
        addNewMemberForm.ShowDialog()

    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.bindMembersData()
        Me.bindSubscriptionsData()
        Me.bindPackagesData()
    End Sub

End Class