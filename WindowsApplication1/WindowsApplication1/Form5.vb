Imports System.Data.OleDb
Public Class AddSubscriptionForm

    Private dbConnection As OleDbConnection
    Private isCreateMode As Boolean = True
    Private idOfRecordToEdit As String
    Private currentUserId As Integer = 1

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

        If Not Me.isCreateMode Then
            'connect to database to load subscription details
            Me.dbConnection.Open()
            Dim selectCommand As New OleDbCommand("SELECT * FROM subscription WHERE id =" & Me.idOfRecordToEdit & "", Me.dbConnection)
            Dim subscriptionReader As OleDbDataReader
            subscriptionReader = selectCommand.ExecuteReader
            subscriptionReader.Read()

            Me.membersCBx.SelectedValue = subscriptionReader("member_id")
            Me.packagesCBx.SelectedValue = subscriptionReader("package_id")
            Me.startDateDtTmPckr.Text = subscriptionReader("start_date")
            Me.endDateDtTmPckr.Text = subscriptionReader("end_date")
            Me.isActiveChkBx.Checked = subscriptionReader("is_active")

            Me.dbConnection.Close()
        End If

    End Sub

    Private Sub cancelSubscriptionBtn_Click(sender As Object, e As EventArgs) Handles cancelSubscriptionBtn.Click
        Me.Close()
    End Sub

    Private Sub saveSubscriptionBtn_Click(sender As Object, e As EventArgs) Handles saveSubscriptionBtn.Click
        If Me.isCreateMode Then
            'save new record to database
            Dim saveQueryString As String = "INSERT INTO subscription(member_id,package_id,start_date,end_date,is_active,created_by) VALUES (@member_id,@package_id,@start_date,@end_date,@is_active,@created_by)"
            Dim insertCommand As New OleDbCommand(saveQueryString, dbConnection)
            insertCommand.Parameters.AddWithValue("@member_id", Me.membersCBx.SelectedValue)
            insertCommand.Parameters.AddWithValue("@package_id", Me.packagesCBx.SelectedValue)
            insertCommand.Parameters.AddWithValue("@start_date", OleDbType.Date).Value = Me.startDateDtTmPckr.Value.ToString
            insertCommand.Parameters.AddWithValue("@end_date", OleDbType.Date).Value = Me.endDateDtTmPckr.Value.ToString
            insertCommand.Parameters.AddWithValue("@is_active", Me.isActiveChkBx.Checked)
            insertCommand.Parameters.AddWithValue("@created_by", Me.currentUserId)

            Me.dbConnection.Open()
            insertCommand.ExecuteNonQuery()
            Me.dbConnection.Close()

            Me.Close()
        Else
            'update the old record in DB
            Dim updateQueryString As String = "UPDATE subscription SET member_id='" & Me.membersCBx.SelectedValue & "', package_id='" & Me.packagesCBx.SelectedValue & "', start_date='" & Me.startDateDtTmPckr.Text & "', end_date='" & Me.endDateDtTmPckr.Text & "', is_active=" & Me.isActiveChkBx.Checked & ""
            'MessageBox.Show(updateQueryString)
            Dim updateCommand As New OleDbCommand(updateQueryString, dbConnection)
            Me.dbConnection.Open()
            updateCommand.ExecuteNonQuery()
            Me.dbConnection.Close()

            Me.Close()

        End If
    End Sub
End Class