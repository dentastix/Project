Public Class frmDogEssential
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'When the back button is clicked then the user will be brought back to the previous form
        Me.Visible = False
        frmAnimal.Visible = True
    End Sub

End Class