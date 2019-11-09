Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Informing the User what the password is
        MsgBox("Password = BIS")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Declaring the Password as String
        Dim strPassword As String = ""
        strPassword = txtPassword.Text
        'If the correct password is entered, then the sign in is successful and proceed into next form
        If strPassword = "BIS" Then
            MsgBox("Welcome User, You have successfully logged in!")
            'When button clicked go from this form to the next form
            Me.Visible = False
            frmAnimal.Visible = True
        Else
            'If the password entered is incorrect then redirected back to login page to try again
            MsgBox("Password Incorrect! Please Try Again :)")
            'Clear the previous incorrect password
            txtPassword.Text = ""
            'Cursor goes straight back to where password is entered for ease of use
            txtPassword.Focus()
        End If
    End Sub
End Class
