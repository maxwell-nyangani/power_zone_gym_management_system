Imports System.Data.OleDb
Public Class AddPackageForm

    Private dbConnection As OleDbConnection
    Private isCreateMode As Boolean = True
    Private idOfRecordToEdit As String

    'GETTERS AND SETTERS
    Public Sub setDBConnection(connection As OleDbConnection)
        Me.dbConnection = connection
    End Sub
    Public Sub setIsCreateMode(flag As Boolean)
        Me.isCreateMode = flag
    End Sub

    Public Sub setIdOfRecordToEdit(id As String)
        Me.idOfRecordToEdit = id
    End Sub

    Private Sub AddPackageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        'check if the form is opened in edit mode
        If Me.isCreateMode = False Then
            'connect to database to load package details
            Me.dbConnection.Open()
            Dim selectCommand As New OleDbCommand("SELECT * FROM package WHERE id =" & Me.idOfRecordToEdit & "", Me.dbConnection)
            Dim packageReader As OleDbDataReader
            packageReader = selectCommand.ExecuteReader
            packageReader.Read()

            Me.titleTxtBx.Text = packageReader("title")
            Me.descriptionTxtBx.Text = packageReader("description")
            Me.priceNumUpDwn.Value = packageReader("price")
            Me.targetSexCBx.Text = packageReader("target_sex")
            Me.isActiveChkBx.Checked = packageReader("is_active")
            Me.referenceCodeTxtBx.Text = packageReader("ref_code")

            Me.dbConnection.Close()
        End If
    End Sub

    
    Private Sub saveCreatePackageBtn_Click(sender As Object, e As EventArgs) Handles saveCreatePackageBtn.Click
        If Me.isCreateMode Then
            'save new record in the packages table
            Dim saveQueryString As String = "INSERT INTO package(title,description,price,target_sex,is_active,ref_code) VALUES (@title,@description,@price,@target_sex,@is_active,@ref_code) "
            Dim insertCommand As New OleDbCommand(saveQueryString, dbConnection)
            insertCommand.Parameters.AddWithValue("@title", Me.titleTxtBx.Text)
            insertCommand.Parameters.AddWithValue("@description", Me.descriptionTxtBx.Text)
            insertCommand.Parameters.AddWithValue("@price", Me.priceNumUpDwn.Value)
            insertCommand.Parameters.AddWithValue("@target_sex", Me.targetSexCBx.Text)
            insertCommand.Parameters.AddWithValue("@is_active", Me.isActiveChkBx.Checked)
            insertCommand.Parameters.AddWithValue("@ref_code", Me.referenceCodeTxtBx.Text)

            dbConnection.Open()
            insertCommand.ExecuteNonQuery()
            dbConnection.Close()

            Me.Close()
        Else
            'update an already existing record in the packages table
            Dim updateQueryString As String = "UPDATE  package SET title='" & Me.titleTxtBx.Text & "', description='" & Me.descriptionTxtBx.Text & "', price=" & Me.priceNumUpDwn.Value & ", target_sex='" & Me.targetSexCBx.Text & "', is_active=" & Me.isActiveChkBx.Checked & ", ref_code='" & Me.referenceCodeTxtBx.Text & "' WHERE id=" & idOfRecordToEdit & ""
            'MessageBox.Show(updateQueryString)
            Dim updateCommand As New OleDbCommand(updateQueryString, dbConnection)
            dbConnection.Open()
            updateCommand.ExecuteNonQuery()
            dbConnection.Close()

            Me.Close()
        End If
    End Sub

    Private Sub cancelCreatPackageBtn_Click(sender As Object, e As EventArgs) Handles cancelCreatPackageBtn.Click
        Me.Close()
    End Sub

End Class