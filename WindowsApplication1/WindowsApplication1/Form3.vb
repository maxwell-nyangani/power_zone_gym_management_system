Imports System.Data.OleDb
Public Class AddNewMemberForm

    Private isCreateMode As Boolean = True
    Private dbConnection As OleDbConnection
    Private idOfRecordToEdit As String = Nothing

    Private Sub memberCancelBtn_Click(sender As Object, e As EventArgs) Handles memberCancelBtn.Click
        Me.Close()
    End Sub

    Private Sub memberSaveBtn_Click(sender As Object, e As EventArgs) Handles memberSaveBtn.Click
        If Me.isCreateMode Then

            'collect user entered data into DB
            Dim saveQueryString As String = "INSERT INTO member(title,firstname,lastname,sex,street_address,city,phone_number) VALUES (@title,@firstname,@lastname,@sex,@street_address,@city,@phone_number)"
            Dim insertCommand As New OleDbCommand(saveQueryString, dbConnection)
            insertCommand.Parameters.AddWithValue("@title", Me.titleCBx.Text)
            insertCommand.Parameters.AddWithValue("@firstname", Me.firstNamestxtBx.Text)
            insertCommand.Parameters.AddWithValue("@lastname", Me.lastNameTxtBx.Text)
            insertCommand.Parameters.AddWithValue("@sex", Me.sexCBx.Text)
            'insertCommand.Parameters.AddWithValue("@date_of_birth", Me.dobDTPckr.Text)
            insertCommand.Parameters.AddWithValue("@street_address", Me.addressRTxtBx.Text)
            insertCommand.Parameters.AddWithValue("@city", Me.cityTxtBx.Text)
            insertCommand.Parameters.AddWithValue("@phone_number", Me.phoneTxtBx.Text)

            dbConnection.Open()
            insertCommand.ExecuteNonQuery()
            dbConnection.Close()
        Else
            'update the old record in DB
            Dim updateQueryString As String = "UPDATE  member SET title='" & Me.titleCBx.Text & "', firstname='" & Me.firstNamestxtBx.Text & "', lastname='" & Me.lastNameTxtBx.Text & "', sex='" & Me.sexCBx.Text & "', street_address='" & Me.addressRTxtBx.Text & "', city='" & Me.cityTxtBx.Text & "', phone_number='" & Me.phoneTxtBx.Text & "' WHERE ID=" & Me.idOfRecordToEdit & ""
            'MessageBox.Show(updateQueryString)
            Dim updateCommand As New OleDbCommand(updateQueryString, dbConnection)
            dbConnection.Open()
            updateCommand.ExecuteNonQuery()
            dbConnection.Close()

        End If
        Me.Close()

    End Sub

    Private Sub AddNewMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        'connect to the DB and fetch the data of the memeber if we are in edit mode or just show blank for if we are in create mode
        If Not Me.isCreateMode Then
            'connect to database to load memebr details
            Me.dbConnection.Open()
            Dim selectCommand As New OleDbCommand("SELECT * FROM member WHERE id =" & Me.idOfRecordToEdit & "", Me.dbConnection)
            Dim memberReader As OleDbDataReader
            memberReader = selectCommand.ExecuteReader
            memberReader.Read()

            Me.titleCBx.Text = memberReader("title")
            Me.firstNamestxtBx.Text = memberReader("firstname")
            Me.lastNameTxtBx.Text = memberReader("lastname")
            Me.sexCBx.Text = memberReader("sex")
            'Me.dobDTPckr.Text = memberReader("date_of_birth")
            Me.addressRTxtBx.Text = memberReader("street_address")
            Me.cityTxtBx.Text = memberReader("city")
            Me.phoneTxtBx.Text = memberReader("phone_number")
            Me.dbConnection.Close()
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

    Public Function setIdOfRecordToEdit(recordId As String)
        Me.idOfRecordToEdit = recordId
        Return Nothing
    End Function

End Class