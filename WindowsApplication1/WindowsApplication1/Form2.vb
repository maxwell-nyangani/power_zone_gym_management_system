Imports System.Data.OleDb
Public Class MainPageForm
    'DB connection variables
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PowerZoneGymDatabase.accdb")

    Private motherForm As LoginForm

    Private addNewMemberForm As AddNewMemberForm
    Private addNewPackageForm As AddPackageForm
    Private addNewSubscriptionForm As AddSubscriptionForm

    'CUSTOM methods
    Public Sub initialize(motherForm As LoginForm)
        Me.motherForm = motherForm
        'Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
    End Sub

    Dim fetch_members_command As New OleDbCommand("SELECT * FROM member;", connection)
    Dim membersDataAdaptor As New OleDbDataAdapter
    Dim membersDataTable As New DataTable
    Public Sub bindMembersData()
        membersDataAdaptor.SelectCommand = fetch_members_command
        membersDataTable.Clear()
        membersDataAdaptor.Fill(membersDataTable)
        membersDtGrdVw.DataSource = membersDataTable


    End Sub
    Private Sub clearMembersSearchBox()
        Me.membersSearchTxtBx.Text = Nothing
    End Sub

    Dim fetch_subscriptions_command As New OleDbCommand("SELECT * FROM subscription;", connection)
    Dim subscriptionsDataAdaptor As New OleDbDataAdapter
    Dim subscriptionsDataTable As New DataTable
    Public Sub bindSubscriptionsData()
        subscriptionsDataAdaptor.SelectCommand = fetch_subscriptions_command
        subscriptionsDataTable.Clear()
        subscriptionsDataAdaptor.Fill(subscriptionsDataTable)
        subscriptionsDtGrdVw.DataSource = subscriptionsDataTable


    End Sub

    Dim fetch_packages_command As New OleDbCommand("SELECT * FROM package;", connection)
    Dim packagesDataAdaptor As New OleDbDataAdapter
    Dim packagesDataTable As New DataTable
    Public Sub bindPackagesData()
        packagesDataAdaptor.SelectCommand = fetch_packages_command
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
        Me.bindMembersData()


    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.bindMembersData()
        Me.bindSubscriptionsData()
        Me.bindPackagesData()
    End Sub

    Dim selectedMemberId As String = Nothing

    Private Sub membersDtGrdVw_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles membersDtGrdVw.CellMouseClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = membersDtGrdVw.Rows(rowIndex)
        selectedMemberId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view
    End Sub
    Private Sub membersDtGrdVw_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles membersDtGrdVw.CellMouseDoubleClick
        'load the edit member form
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = membersDtGrdVw.Rows(rowIndex)
        selectedMemberId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view

        Dim editMemberForm As New AddNewMemberForm
        editMemberForm.setDBConnection(Me.connection)
        editMemberForm.setIsCreateMode(False)
        editMemberForm.setIdOfRecordToEdit(selectedMemberId)

        editMemberForm.ShowDialog()
        Me.bindMembersData()
    End Sub



    Private Sub deleteSelectedMemberBtn_Click(sender As Object, e As EventArgs) Handles deleteSelectedMemberBtn.Click
        'Try
        '    Dim scb = New OleDbCommandBuilder(membersDataAdaptor)
        '    membersDataAdaptor.Update(membersDataTable)
        '    MessageBox.Show("OK!")
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try



        If Me.selectedMemberId = Nothing Then
            'Warn user to select a row in the grid
            MessageBox.Show("Please select a member to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Check if user is sure they want to delete the member
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Warning", MessageBoxButtons.YesNo)

            If result = DialogResult.Cancel Or result = DialogResult.No Then
                'Do nothing 
            ElseIf result = DialogResult.Yes Then 'User really wants to delete member
                Dim deleteMemberCommand As New OleDbCommand("DELETE FROM member WHERE id = @memberId", Me.connection)
                deleteMemberCommand.Parameters.AddWithValue("@memberId", selectedMemberId)
                Me.connection.Open()
                deleteMemberCommand.ExecuteNonQuery()
                Me.connection.Close()
                Me.clearMembersSearchBox()
                Me.bindMembersData()
                'Me.searchMembersBtn.PerformClick()
            End If
            
        End If
    End Sub

    Private Sub addNewPackageBtn_Click(sender As Object, e As EventArgs) Handles addNewPackageBtn.Click
        addNewPackageForm = New AddPackageForm
        addNewPackageForm.setDBConnection(Me.connection)
        addNewPackageForm.setIsCreateMode(True)
        addNewPackageForm.ShowDialog()
        Me.bindPackagesData()
    End Sub

    Private Sub addNewSubscriptionBtn_Click(sender As Object, e As EventArgs) Handles addNewSubscriptionBtn.Click
        addNewSubscriptionForm = New AddSubscriptionForm
        addNewSubscriptionForm.setDBConnection(Me.connection)
        addNewSubscriptionForm.setIsCreateMode(True)
        addNewSubscriptionForm.ShowDialog()
        Me.bindSubscriptionsData()
    End Sub

    Private Sub searchMembersBtn_Click(sender As Object, e As EventArgs) Handles searchMembersBtn.Click
        Dim searchMembersCommand As New OleDbCommand("SELECT * FROM member WHERE firstname LIKE '%' +@searchTerm+ '%' OR lastname LIKE '%' +@searchTerm+ '%' OR phone_number LIKE '%' +@searchTerm+ '%'", connection)
        searchMembersCommand.Parameters.AddWithValue("@searchTerm", membersSearchTxtBx.Text)
        membersDataAdaptor.SelectCommand = searchMembersCommand
        membersDataTable.Clear()
        membersDataAdaptor.Fill(membersDataTable)
        membersDtGrdVw.DataSource = membersDataTable
    End Sub
End Class