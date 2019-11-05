Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Password = BIS")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strPassword As String = ""
        strPassword = txtPassword.Text
        If strPassword = "BIS" Then
            MsgBox("Welcome User, You have successfully logged in!")
            Me.Visible = False
            frmAnimal.Visible = True
        Else
            MsgBox("Password Incorrect! Please Try Again :)")
            Me.Visible = True
            frmAnimal.Visible = False
        End If
    End Sub
End Class
