Imports System.Data.OleDb
Public Class AddSubscriptionForm

    Private dbConnection As OleDbConnection
    Private isCreateMode As Boolean = True
    Private idOfRecordToEdit As String

    'members db access variables
    Dim fetchMembersCommand As New OleDbCommand
    Dim membersDataAdaptor As New OleDbDataAdapter
    Dim membersDataTable As New DataTable

    'packages db access variables
    Dim fetchPackagesCommand As New OleDbCommand
    Dim packagesDataAdaptor As New OleDbDataAdapter
    Dim packagesDataTable As New DataTable

    'GETTERS and SETTERS
    Public Sub setDBConnection(connection As OleDbConnection)
        Me.dbConnection = connection
    End Sub

    Public Sub setIsCreateMode(flag As Boolean)
        Me.isCreateMode = flag
    End Sub

    Public Sub setIdOfRecordToEdit(id As String)
        Me.idOfRecordToEdit = id
    End Sub


    Private Sub AddSubscriptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        'populate the members dropdown from the db
        Me.dbConnection.Open()
        Me.fetchMembersCommand = New OleDbCommand("SELECT * FROM member;", Me.dbConnection)
        Me.membersDataAdaptor.SelectCommand = Me.fetchMembersCommand
        Me.membersDataTable.Clear()
        Me.membersDataAdaptor.Fill(membersDataTable)
        Me.dbConnection.Close()

        'build combination display
        membersDataTable.Columns.Add("full_name", Type.GetType("System.String"))
        membersDataTable.Columns("full_name").Expression = "firstname + ' ' + lastname + ' ' + phone_number"


        membersCBx.DataSource = membersDataTable
        membersCBx.ValueMember = "ID"
        membersCBx.DisplayMember = "full_name"

        'populate the packages dropdown from the db
        Me.dbConnection.Open()
        Me.fetchPackagesCommand = New OleDbCommand("SELECT * FROM package;", Me.dbConnection)
        Me.packagesDataAdaptor.SelectCommand = Me.fetchPackagesCommand
        Me.packagesDataTable.Clear()
        Me.packagesDataAdaptor.Fill(packagesDataTable)
        Me.dbConnection.Close()
        packagesCBx.DataSource = packagesDataTable
        packagesCBx.ValueMember = "ID"
        packagesCBx.DisplayMember = "title"

    End Sub

End Class