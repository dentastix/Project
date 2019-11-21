Public Class frmEnd
    Private Sub lblEnd_Click(sender As Object, e As EventArgs) Handles lblEnd.Click

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        'Brings the User Back to the beggining
        Me.Visible = False
        MsgBox("Password = BIS")
        frmLogin.Visible = True
        frmLogin.txtPassword.Text = ""
        frmLogin.txtPassword.Focus()
    End Sub
End Class