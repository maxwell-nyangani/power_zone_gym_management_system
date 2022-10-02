Imports System.Data.OleDb
Public Class MainPageForm
    'DB connection variables
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PowerZoneGymDatabase.accdb")

    Private motherForm As LoginForm

    'Child forms
    Private addNewMemberForm As AddNewMemberForm
    Private addNewPackageForm As AddPackageForm
    Private addNewSubscriptionForm As AddSubscriptionForm

    'main form state variables
    Dim selectedMemberId As String = Nothing
    Dim selectedPackageId As String = Nothing
    Dim selectedSubscriptionId As String = Nothing

    'CUSTOM methods
    Public Sub initialize(motherForm As LoginForm)
        Me.motherForm = motherForm
        'Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
    End Sub

    Dim fetchMembersCommand As New OleDbCommand("SELECT * FROM member;", connection)
    Dim membersDataAdaptor As New OleDbDataAdapter
    Dim membersDataTable As New DataTable
    Public Sub bindMembersData()
        Me.membersDataAdaptor.SelectCommand = Me.fetchMembersCommand
        Me.membersDataTable.Clear()
        Me.membersDataAdaptor.Fill(Me.membersDataTable)
        Me.membersDtGrdVw.DataSource = Me.membersDataTable
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

    Dim fetchPackagesCommand As New OleDbCommand("SELECT * FROM package;", connection)
    Dim packagesDataAdaptor As New OleDbDataAdapter
    Dim packagesDataTable As New DataTable
    Public Sub bindPackagesData()
        Me.packagesDataAdaptor.SelectCommand = Me.fetchPackagesCommand
        Me.packagesDataTable.Clear()
        Me.packagesDataAdaptor.Fill(Me.packagesDataTable)
        packagesDtGrdVw.DataSource = Me.packagesDataTable


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
        'TODO: This line of code loads data into the 'PowerZoneGymDatabaseDataSet.admin_user' table. You can move, or remove it, as needed.
        Me.Admin_userTableAdapter.Fill(Me.PowerZoneGymDatabaseDataSet.admin_user)
        Me.CenterToScreen()
        Me.bindMembersData()
        Me.bindSubscriptionsData()
        Me.bindPackagesData()
    End Sub



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



        If Me.selectedMemberId = Nothing Or Me.selectedMemberId = -1 Then
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

                Me.selectedMemberId = Nothing
            End If

        End If
    End Sub

    Private Sub addNewPackageBtn_Click(sender As Object, e As EventArgs) Handles addNewPackageBtn.Click
        addNewPackageForm = New AddPackageForm
        addNewPackageForm.setDBConnection(Me.connection)
        addNewPackageForm.setIsCreateMode(True)
        addNewPackageForm.ShowDialog()
        Me.bindPackagesData() 'to refresh the table data after the add form is dismissed
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
        Me.membersDataAdaptor.SelectCommand = searchMembersCommand
        Me.membersDataTable.Clear()
        Me.membersDataAdaptor.Fill(membersDataTable)
        Me.membersDtGrdVw.DataSource = membersDataTable
    End Sub

    Private Sub deleteSelectedPackageBtn_Click(sender As Object, e As EventArgs) Handles deleteSelectedPackageBtn.Click
        If Me.selectedPackageId = Nothing Or Me.selectedPackageId = -1 Then
            'Nothing deletable is currently selected by the user
            MessageBox.Show("Please select a package to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Check if user is sure they want to delete the member
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this package?", "Warning", MessageBoxButtons.YesNo)

            If result = DialogResult.Cancel Or result = DialogResult.No Then
                'Do nothing 
            ElseIf result = DialogResult.Yes Then 'User really wants to delete package
                'delete the record from the DB
                Dim deletePackageCommand As New OleDbCommand("DELETE FROM package WHERE id = @packageId", Me.connection)
                deletePackageCommand.Parameters.AddWithValue("@packageId", Me.selectedPackageId)
                Me.connection.Open()
                deletePackageCommand.ExecuteNonQuery()
                Me.connection.Close()
                'Me.clearPackagesSearchBox()
                Me.bindPackagesData()

                Me.selectedPackageId = Nothing
            End If
        End If
    End Sub

    Private Sub packagesDtGrdVw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles packagesDtGrdVw.CellClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = Me.packagesDtGrdVw.Rows(rowIndex)
        selectedPackageId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view
    End Sub

    Private Sub packagesDtGrdVw_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles packagesDtGrdVw.CellDoubleClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = Me.packagesDtGrdVw.Rows(rowIndex)
        selectedPackageId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view

        Dim editPackageForm As New AddPackageForm
        editPackageForm.setIsCreateMode(False)
        editPackageForm.setDBConnection(Me.connection)
        editPackageForm.setIdOfRecordToEdit(selectedPackageId)

        editPackageForm.ShowDialog()
        Me.bindPackagesData()
    End Sub

    Private Sub searchPackageBtn_Click(sender As Object, e As EventArgs) Handles searchPackageBtn.Click
        Dim searchPackagesCommand As New OleDbCommand("SELECT * FROM package WHERE title LIKE '%' +@searchTerm+ '%' OR description LIKE '%' +@searchTerm+ '%' OR target_sex LIKE '%' +@searchTerm+ '%'", connection)
        searchPackagesCommand.Parameters.AddWithValue("@searchTerm", Me.searchPackagesTxtBx.Text)
        Me.packagesDataAdaptor.SelectCommand = searchPackagesCommand
        Me.packagesDataTable.Clear()
        Me.packagesDataAdaptor.Fill(packagesDataTable)
        Me.packagesDtGrdVw.DataSource = packagesDataTable
    End Sub

    Private Sub subscriptionsDtGrdVw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles subscriptionsDtGrdVw.CellClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = Me.subscriptionsDtGrdVw.Rows(rowIndex)
        Me.selectedSubscriptionId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view
    End Sub

    Private Sub subscriptionsDtGrdVw_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles subscriptionsDtGrdVw.CellDoubleClick
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex = -1 Then
            Exit Sub 'Heading cell clicked
        End If
        Dim selectedRow As DataGridViewRow = Me.subscriptionsDtGrdVw.Rows(rowIndex)
        Me.selectedSubscriptionId = selectedRow.Cells(0).Value.ToString 'we take 0 here because the ID is always first regardless of the order in the grid view

        Dim editSubscriptionForm As New AddSubscriptionForm
        editSubscriptionForm.setIsCreateMode(False)
        editSubscriptionForm.setDBConnection(Me.connection)
        editSubscriptionForm.setIdOfRecordToEdit(selectedSubscriptionId)
        editSubscriptionForm.ShowDialog()
        Me.bindSubscriptionsData()
    End Sub

    Private Sub deleteSelectedSubcriptionBtn_Click(sender As Object, e As EventArgs) Handles deleteSelectedSubcriptionBtn.Click
        If Me.selectedSubscriptionId = Nothing Or Me.selectedSubscriptionId = -1 Then
            'Nothing deletable is currently selected by the user
            MessageBox.Show("Please select a subscription to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Check if user is sure they want to delete the member
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this subscription?", "Warning", MessageBoxButtons.YesNo)

            If result = DialogResult.Cancel Or result = DialogResult.No Then
                'Do nothing 
            ElseIf result = DialogResult.Yes Then 'User really wants to delete package
                'delete the record from the DB
                Dim deleteSubscriptionCommand As New OleDbCommand("DELETE FROM subscription WHERE id = @subscriptionId", Me.connection)
                deleteSubscriptionCommand.Parameters.AddWithValue("@subscriptionId", Me.selectedSubscriptionId)
                Me.connection.Open()
                deleteSubscriptionCommand.ExecuteNonQuery()
                Me.connection.Close()
                'Me.clearSubscriptionsSearchBox()
                Me.bindSubscriptionsData()

                Me.selectedSubscriptionId = Nothing

            End If
        End If
    End Sub

    Private Sub searchSubscriptionBtn_Click(sender As Object, e As EventArgs) Handles searchSubscriptionBtn.Click
        Dim searchSubscriptionsCommand As New OleDbCommand("SELECT * FROM subscription WHERE member_id LIKE '%' +@searchTerm+ '%' OR package_id LIKE '%' +@searchTerm+ '%' OR start_date LIKE '%' +@searchTerm+ '%'", connection)
        searchSubscriptionsCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        Me.subscriptionsDataAdaptor.SelectCommand = searchSubscriptionsCommand
        Me.subscriptionsDataTable.Clear()
        Me.subscriptionsDataAdaptor.Fill(subscriptionsDataTable)
        Me.subscriptionsDtGrdVw.DataSource = subscriptionsDataTable
    End Sub

    Private Sub dashboardTabPage_Enter(sender As Object, e As EventArgs) Handles dashboardTabPage.Enter
        'executed when the visitor visits the dashboard page
        Dim membersByGenderDataAdaptor As New OleDbDataAdapter
        Dim membersByGenderDataTable As New DataTable
        Dim membersByGenderCommand As New OleDbCommand("SELECT sex AS gender, COUNT(ID) AS my_count FROM member GROUP BY  sex", connection)
        'membersByGenderCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        membersByGenderDataAdaptor.SelectCommand = membersByGenderCommand
        membersByGenderDataTable.Clear()
        membersByGenderDataAdaptor.Fill(membersByGenderDataTable)

        'load data into chart
        Me.membershipByGenderChart.Series("All").Points.Clear()
        For Each row As DataRow In membersByGenderDataTable.Rows
            Me.membershipByGenderChart.Series("All").Points.AddXY(row.Item("gender"), row.Item("my_count"))
        Next row


        Dim packageBySubscriptionCountDataAdaptor As New OleDbDataAdapter
        Dim packageBySubscriptionCountDataTable As New DataTable
        Dim packageBySubscriptionCountCommand As New OleDbCommand("SELECT p.title AS my_title, COUNT(s.ID) AS my_count FROM package p, subscription s WHERE s.package_id = p.id  GROUP BY  p.title", connection)
        'packageBySubscriptionCountCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        packageBySubscriptionCountDataAdaptor.SelectCommand = packageBySubscriptionCountCommand
        packageBySubscriptionCountDataTable.Clear()
        packageBySubscriptionCountDataAdaptor.Fill(packageBySubscriptionCountDataTable)

        Me.packageBySubscriptionCountChart.Series("All").Points.Clear()

        For Each row As DataRow In packageBySubscriptionCountDataTable.Rows
            Me.packageBySubscriptionCountChart.Series("All").Points.AddXY(row.Item("my_title"), row.Item("my_count"))
        Next row





        Dim revenueByMonthDataAdaptor00 As New OleDbDataAdapter
        Dim revenueByMonthDataTable00 As New DataTable
        Dim revenueByMonthCommand00 As New OleDbCommand("SELECT FORMAT(DateAdd(""m"", -3, Date()), 'yyyy_MM') AS my_month, SUM(p.price) AS my_sum FROM package p, subscription s WHERE s.package_id = p.id AND s.end_date > DateAdd(""m"", -3, Date()) AND s.start_date <= DateAdd(""m"",-4,Date()) GROUP BY FORMAT(DateAdd(""m"", -3, Date()), 'yyyy_MM')", connection)
        'revenueByMonthCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        revenueByMonthDataAdaptor00.SelectCommand = revenueByMonthCommand00
        revenueByMonthDataTable00.Clear()
        revenueByMonthDataAdaptor00.Fill(revenueByMonthDataTable00)

        Me.revenueByMonthChart.Series("All").Points.Clear()

        For Each row As DataRow In revenueByMonthDataTable00.Rows
            Me.revenueByMonthChart.Series("All").Points.AddXY(row.Item("my_month"), row.Item("my_sum"))
        Next row


        Dim revenueByMonthDataAdaptor0 As New OleDbDataAdapter
        Dim revenueByMonthDataTable0 As New DataTable
        Dim revenueByMonthCommand0 As New OleDbCommand("SELECT FORMAT(DateAdd(""m"", -2, Date()), 'yyyy_MM') AS my_month, SUM(p.price) AS my_sum FROM package p, subscription s WHERE s.package_id = p.id AND s.end_date > DateAdd(""m"", -2, Date()) AND s.start_date <= DateAdd(""m"",-3,Date()) GROUP BY FORMAT(DateAdd(""m"", -2, Date()), 'yyyy_MM')", connection)
        'revenueByMonthCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        revenueByMonthDataAdaptor0.SelectCommand = revenueByMonthCommand0
        revenueByMonthDataTable0.Clear()
        revenueByMonthDataAdaptor0.Fill(revenueByMonthDataTable0)

        'Me.revenueByMonthChart.Series("All").Points.Clear()

        For Each row As DataRow In revenueByMonthDataTable0.Rows
            Me.revenueByMonthChart.Series("All").Points.AddXY(row.Item("my_month"), row.Item("my_sum"))
        Next row

        Dim revenueByMonthDataAdaptor1 As New OleDbDataAdapter
        Dim revenueByMonthDataTable1 As New DataTable
        Dim revenueByMonthCommand1 As New OleDbCommand("SELECT FORMAT(DateAdd(""m"", -1, Date()), 'yyyy_MM') AS my_month, SUM(p.price) AS my_sum FROM package p, subscription s WHERE s.package_id = p.id AND s.end_date > DateAdd(""m"", -1, Date()) AND s.start_date <= DateAdd(""m"",-2,Date()) GROUP BY FORMAT(DateAdd(""m"", -1, Date()), 'yyyy_MM')", connection)
        'revenueByMonthCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        revenueByMonthDataAdaptor1.SelectCommand = revenueByMonthCommand1
        revenueByMonthDataTable1.Clear()
        revenueByMonthDataAdaptor1.Fill(revenueByMonthDataTable1)

        'Me.revenueByMonthChart.Series("All").Points.Clear()

        For Each row As DataRow In revenueByMonthDataTable1.Rows
            Me.revenueByMonthChart.Series("All").Points.AddXY(row.Item("my_month"), row.Item("my_sum"))
        Next row


        Dim revenueByMonthDataAdaptor As New OleDbDataAdapter
        Dim revenueByMonthDataTable As New DataTable
        Dim revenueByMonthCommand As New OleDbCommand("SELECT FORMAT(Date(), 'yyyy_MM') AS my_month, SUM(p.price) AS my_sum FROM package p, subscription s WHERE s.package_id = p.id AND s.end_date > Date() AND s.start_date <= Date() GROUP BY FORMAT(Date(), 'yyyy_MM')", connection)
        'revenueByMonthCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        revenueByMonthDataAdaptor.SelectCommand = revenueByMonthCommand
        revenueByMonthDataTable.Clear()
        revenueByMonthDataAdaptor.Fill(revenueByMonthDataTable)

        'Me.revenueByMonthChart.Series("All").Points.Clear()

        For Each row As DataRow In revenueByMonthDataTable.Rows
            Me.revenueByMonthChart.Series("All").Points.AddXY(row.Item("my_month"), row.Item("my_sum"))
        Next row


        Dim revenueByPackageDataAdaptor As New OleDbDataAdapter
        Dim revenueByPackageDataTable As New DataTable
        Dim revenueByPackageCommand As New OleDbCommand("SELECT p.title AS my_title, SUM(p.price) AS my_sum FROM package p, subscription s WHERE s.package_id = p.id AND s.end_date > Date() AND s.start_date <= Date() GROUP BY p.title", connection)
        'revenueByPackageCommand.Parameters.AddWithValue("@searchTerm", Me.subscriptionSearchTxtBx.Text)
        revenueByPackageDataAdaptor.SelectCommand = revenueByPackageCommand
        revenueByPackageDataTable.Clear()
        revenueByPackageDataAdaptor.Fill(revenueByPackageDataTable)

        Me.revenueByPackageChart.Series("All").Points.Clear()

        For Each row As DataRow In revenueByPackageDataTable.Rows
            Me.revenueByPackageChart.Series("All").Points.AddXY(row.Item("my_title"), row.Item("my_sum"))
        Next row



    End Sub


End Class