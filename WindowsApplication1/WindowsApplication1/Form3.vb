Imports System.Data.OleDb
Public Class AddNewMemberForm

    Private isCreateMode As Boolean = True
    Private dbConnection As OleDbConnection

    Private Sub memberCancelBtn_Click(sender As Object, e As EventArgs) Handles memberCancelBtn.Click
        Me.Close()
    End Sub

    Private Sub memberSaveBtn_Click(sender As Object, e As EventArgs) Handles memberSaveBtn.Click
        'collect user entered data into DB
        Dim saveQueryString As String = "INSERT INTO member(title,firstname,lastname,sex,date_of_birth,street_address,city,phone_number) VALUES (@title,@firstname,@lastname,@sex,@date_of_birth,@street_address,@city,@phone_number)"
        Dim insertCommand As New OleDbCommand(saveQueryString, dbConnection)

    End Sub

    Private Sub AddNewMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connect to the DB and fetch the data of the memeber if we are in edit mode or just show blank for if we are in create mode
        If Not Me.isCreateMode Then
            'connect to database to load memebr details

        End If
    End Sub

    'SETTERS ANG GETTERS
    Public Function getIsCreateMode()
        Return Me.isCreateMode
    End Function

    Public Function setIsCreateMode(flag As Boolean)
        Me.isCreateMode = flag
        Return Nothing
    End Function

    Public Function setDBConnection(connection As OleDbConnection)
        Me.dbConnection = connection
        Return Nothing
    End Function


End Class