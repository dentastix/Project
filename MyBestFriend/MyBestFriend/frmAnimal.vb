Public Class frmAnimal

    Private Sub frmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When Form loads hide everything except from the necessary tools for the user 
        gboInsurance.Visible = False
        txtDescription.Visible = False
        btnContinue.Visible = False
        lblPrompt.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        radEssential.Focus()
        gboInsurance.Visible = True
        txtDescription.Visible = True
        lblPrompt.Visible = True
        btnContinue.Enabled = False
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If radCat.Checked Then
            gboBreedCat.Visible = True
            gboBreedDog.Visible = False
        ElseIf radDog.Checked Then
            gboBreedDog.Visible = True
            gboBreedCat.Visible = False
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
        btnContinue.Enabled = True
    End Sub

    Private Sub radPremier_CheckedChanged(sender As Object, e As EventArgs) Handles radPremier.CheckedChanged
        If radPremier.Checked Then
            btnContinue.Visible = True
            txtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year."
            txtDescription.Text = txtDescription.Text & " Cover for each condition will continue for a maximum of 12 months from the date which the condition first occurred or"
            txtDescription.Text = txtDescription.Text & " started showing clinical signs, as long as you have paid the premium to keep the insurance in force."
            txtDescription.Text = txtDescription.Text & " Once the time limit is reached for a condition, there will be no more cover for it."
        End If
        btnContinue.Enabled = True
    End Sub

    Private Sub radPlus_CheckedChanged(sender As Object, e As EventArgs) Handles radPlus.CheckedChanged
        If radPlus.Checked Then
            btnContinue.Visible = True
            txtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year."
            txtDescription.Text = txtDescription.Text & " As long as you have paid the premium to keep the insurance in force,"
            txtDescription.Text = txtDescription.Text & " cover will reinstate at renewal and all eligible conditions will continue to be covered up to the vet fee limit."
        End If
        btnContinue.Enabled = True
    End Sub

    Private Sub gboBreed_Enter(sender As Object, e As EventArgs) Handles gboBreedDog.Enter
        cboMixedDog.Visible = False
        cboCrossbreedDog.Visible = False
        cboPedigreeDog.Visible = False
        txtOtherDog.Visible = False
        lblOtherDog.Visible = False
    End Sub

    Private Sub radPedigree_CheckedChanged(sender As Object, e As EventArgs) Handles radPedigreeDog.CheckedChanged
        cboPedigreeDog.Visible = True
        cboMixedDog.Visible = False
        cboCrossbreedDog.Visible = False
    End Sub

    Private Sub radCrossbreed_CheckedChanged(sender As Object, e As EventArgs) Handles radCrossbreedDog.CheckedChanged
        cboCrossbreedDog.Visible = True
        cboMixedDog.Visible = False
        cboPedigreeDog.Visible = False
    End Sub

    Private Sub radMixed_CheckedChanged(sender As Object, e As EventArgs) Handles radMixedDog.CheckedChanged
        cboMixedDog.Visible = True
        cboCrossbreedDog.Visible = False
        cboPedigreeDog.Visible = False
    End Sub

    Private Sub gboBreedCat_Enter(sender As Object, e As EventArgs) Handles gboBreedCat.Enter
        cboCrossbreedCat.Visible = False
        cboMixedCat.Visible = False
        cboPedigreeCat.Visible = False
        lblOtherCat.Visible = False

    End Sub

    Private Sub radPedigreeCat_CheckedChanged(sender As Object, e As EventArgs) Handles radPedigreeCat.CheckedChanged
        lblOtherCat.Visible = False
        txtOtherCat.Visible = False
        cboPedigreeCat.Visible = True
        cboCrossbreedCat.Visible = False
        cboMixedCat.Visible = False
    End Sub

    Private Sub radCrossbreedCat_CheckedChanged(sender As Object, e As EventArgs) Handles radCrossbreedCat.CheckedChanged
        lblOtherCat.Visible = False
        txtOtherCat.Visible = False
        cboCrossbreedCat.Visible = True
        cboPedigreeCat.Visible = False
        cboMixedCat.Visible = False
    End Sub

    Private Sub radMixedCat_CheckedChanged(sender As Object, e As EventArgs) Handles radMixedCat.CheckedChanged
        lblOtherCat.Visible = False
        txtOtherCat.Visible = False
        cboMixedCat.Visible = True
        cboCrossbreedCat.Visible = False
        cboPedigreeCat.Visible = False
    End Sub

    Private Sub radCat_CheckedChanged(sender As Object, e As EventArgs) Handles radCat.CheckedChanged
        'If user changes from Dog to Cat then everything clears and user starts from beginning
        gboInsurance.Visible = False
        lblPrompt.Visible = False
        txtDescription.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
        btnContinue.Visible = False
    End Sub

    Private Sub radDog_CheckedChanged(sender As Object, e As EventArgs) Handles radDog.CheckedChanged
        'If user changes from Cat to Dog then everything clears and user starts from beginning
        gboInsurance.Visible = False
        lblPrompt.Visible = False
        txtDescription.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
        btnContinue.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOtherDog.TextChanged

    End Sub

    Private Sub cboPedigreeDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedigreeDog.SelectedIndexChanged
        If cboPedigreeDog.Text = "Other" Then
            txtOtherDog.Visible = True
            lblOtherDog.Visible = True
        End If
    End Sub

    Private Sub cboPedigreeCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedigreeCat.SelectedIndexChanged
        If cboPedigreeCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If
    End Sub

    Private Sub cboCrossbreedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCrossbreedCat.SelectedIndexChanged
        If cboCrossbreedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If
    End Sub

    Private Sub cboMixedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMixedCat.SelectedIndexChanged
        If cboMixedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If
    End Sub
End Class