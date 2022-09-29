Public Class loginForm
    Private Function checkUserCredentials(username As String, password As String)
        If True Then
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
            mainPageForm.Show()
            Me.Hide()
        Else
            'show error messgae
            loginErrorLable.Text = "Invalid username or passowrd. Please try again."
        End If

    End Sub

    Private Sub exitLoginBtn_Click(sender As Object, e As EventArgs) Handles exitLoginBtn.Click
        Me.Close() 'close the app
    End Sub
End Class
