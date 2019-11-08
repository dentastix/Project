Public Class frmAnimal

    Private Sub frmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gboInsurance.Visible = False
        txtDescription.Visible = False
        btnContinue.Visible = False
        lblPrompt.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        gboInsurance.Visible = True
        txtDescription.Visible = True
        lblPrompt.Visible = True
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If radDog.Checked And radEssential.Checked Then
            Me.Visible = False
            frmDogEssential.Visible = True
        ElseIf radDog.Checked And radPremier.Checked Then
            Me.Visible = False
            frmDogPremier.Visible = True
        ElseIf radDog.Checked And radPlus.Checked Then
            Me.Visible = False
            frmDogPlus.Visible = True
        ElseIf radCat.Checked And radEssential.Checked Then
            Me.Visible = False
            frmCatEssential.Visible = True
        ElseIf radCat.Checked And radPremier.Checked Then
            Me.Visible = False
            frmCatPremier.Visible = True
        ElseIf radCat.Checked And radPlus.Checked Then
            Me.Visible = False
            frmCatPlus.Visible = True
        End If
    End Sub

    Private Sub radEssential_CheckedChanged(sender As Object, e As EventArgs) Handles radEssential.CheckedChanged
        If radEssential.Checked Then
            btnContinue.Visible = True
            txtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered accidental injuries per policy year."
            txtDescription.Text = txtDescription.Text & " Cover for each injury will continue for a maximum of 12 months from the date which the injury occurred,"
            txtDescription.Text = txtDescription.Text & " as long as you have paid the premium to keep the insurance in force."
            txtDescription.Text = txtDescription.Text & " Once the time limit is reached for an injury, there will be no more cover for it."
            txtDescription.Text = txtDescription.Text & " There is no cover for illness under this type of cover."
        End If
    End Sub

    Private Sub radPremier_CheckedChanged(sender As Object, e As EventArgs) Handles radPremier.CheckedChanged
        If radPremier.Checked Then
            btnContinue.Visible = True
            txtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year."
            txtDescription.Text = txtDescription.Text & " Cover for each condition will continue for a maximum of 12 months from the date which the condition first occurred or"
            txtDescription.Text = txtDescription.Text & " started showing clinical signs, as long as you have paid the premium to keep the insurance in force."
            txtDescription.Text = txtDescription.Text & " Once the time limit is reached for a condition, there will be no more cover for it."
        End If
    End Sub

    Private Sub radPlus_CheckedChanged(sender As Object, e As EventArgs) Handles radPlus.CheckedChanged
        If radPlus.Checked Then
            btnContinue.Visible = True
            txtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year."
            txtDescription.Text = txtDescription.Text & " As long as you have paid the premium to keep the insurance in force,"
            txtDescription.Text = txtDescription.Text & " cover will reinstate at renewal and all eligible conditions will continue to be covered up to the vet fee limit."
        End If
    End Sub

End Class