Imports System.Data.OleDb
Public Class LoginForm
    'DB connection variables
    Dim dbConnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PowerZoneGymDatabase.accdb")

    Private Function checkUserCredentials(username As String, password As String)
        Dim fetchUserCommand As New OleDbCommand
        Dim usersDataAdaptor As New OleDbDataAdapter
        Dim usersDataTable As New DataTable

        Me.dbConnection.Open()
        fetchUserCommand = New OleDbCommand("SELECT * FROM admin_user WHERE username='" & Me.loginUsernameTxtBx.Text & "' AND password='" & Me.loginPasswordTxtBx.Text & "' ;", Me.dbConnection)
        usersDataAdaptor.SelectCommand = fetchUserCommand
        usersDataTable.Clear()
        usersDataAdaptor.Fill(usersDataTable)
        Me.dbConnection.Close()



        If usersDataTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        'check if the user is in the DB, if they are in the DB send them to the main page, if not show error message

        'DB check
        If checkUserCredentials(loginUsernameTxtBx.Text, loginPasswordTxtBx.Text) Then
            Dim mainPageForm As New MainPageForm()
            mainPageForm.initialize(Me)
            Me.Hide()
            mainPageForm.ShowDialog()
            Me.Close()
        Else
            'show error messgae
            loginErrorLable.Text = "Invalid username or passowrd. Please try again."
        End If

    End Sub

    Private Sub exitLoginBtn_Click(sender As Object, e As EventArgs)
        Me.Close() 'close the app
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'connect to the database
    End Sub

End Class
