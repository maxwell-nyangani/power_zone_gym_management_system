Imports System.Data.OleDb
Public Class AddSubscriptionForm

    Private dbConnection As OleDbConnection
    Private isCreateMode As Boolean = True

    'GETTERS and SETTERS
    Public Sub setDBConnection(connection As OleDbConnection)
        Me.dbConnection = connection
    End Sub

    Public Sub setIsCreateMode(flag As Boolean)
        Me.isCreateMode = flag
    End Sub


    Private Sub AddSubscriptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

End Class