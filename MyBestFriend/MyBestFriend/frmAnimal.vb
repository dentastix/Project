Public Class frmAnimal
    Const decAfricanE As Decimal = 1.14D
    Const decBoxerE As Decimal = 0.86D
    Const decChihuahuaE As Decimal = 1.83D
    Const decDalmatianE As Decimal = 0.65D
    Const decEskimoDogE As Decimal = 1.14D
    Const decFarmE As Decimal = 0.95D
    Const decGreyE As Decimal = 1.99D
    Const decHuskyE As Decimal = 1.85D
    Const decIrishE As Decimal = 0.65D
    Const decJackE As Decimal = 1.77D
    Const decKingE As Decimal = 1.02D
    Const decLabradorE As Decimal = 1.74D
    Const decMalteseE As Decimal = 1.47D
    Const decPugE As Decimal = 1.31D
    Const decRottE As Decimal = 2.17D
    Const decStBernardE As Decimal = 1.63D
    Const decTibetanE As Decimal = 1.15D
    Const decWorkingSheepE As Decimal = 0.75D
    Const decYorkshireE As Decimal = 0.88D
    Const decOtherE As Decimal = 1.22D

    Const decAfricanP As Decimal = 1.24D
    Const decBoxerP As Decimal = 0.94D
    Const decChihuahuaP As Decimal = 1.99D
    Const decDalmatianP As Decimal = 0.79D
    Const decEskimoDogP As Decimal = 1.25D
    Const decFarmP As Decimal = 1.02D
    Const decGreyP As Decimal = 2.14D
    Const decHuskyP As Decimal = 2.08D
    Const decIrishP As Decimal = 0.8D
    Const decJackP As Decimal = 1.98D
    Const decKingP As Decimal = 1.22D
    Const decLabradorP As Decimal = 1.98D
    Const decMalteseP As Decimal = 1.66D
    Const decPugP As Decimal = 1.61D
    Const decRottP As Decimal = 2.55D
    Const decStBernardP As Decimal = 1.82D
    Const decTibetanP As Decimal = 1.3D
    Const decWorkingSheepP As Decimal = 0.88D
    Const decYorkshireP As Decimal = 1.11D
    Const decOtherP As Decimal = 1.55D

    Const decAfricanPP As Decimal = 1.35D
    Const decBoxerPP As Decimal = 1.26D
    Const decChihuahuaPP As Decimal = 2.04D
    Const decDalmatianPP As Decimal = 1D
    Const decEskimoDogPP As Decimal = 1.56D
    Const decFarmPP As Decimal = 1.3D
    Const decGreyPP As Decimal = 2.38D
    Const decHuskyPP As Decimal = 2.25D
    Const decIrishPP As Decimal = 1.15D
    Const decJackPP As Decimal = 2.12D
    Const decKingPP As Decimal = 1.56D
    Const decLabradorPP As Decimal = 2.11D
    Const decMaltesePP As Decimal = 1.99D
    Const decPugPP As Decimal = 1.89D
    Const decRottPP As Decimal = 2.99D
    Const decStBernardPP As Decimal = 2.02D
    Const decTibetanPP As Decimal = 1.61D
    Const decWorkingSheepPP As Decimal = 1.11D
    Const decYorkshirePP As Decimal = 1.48D
    Const decOtherPP As Decimal = 1.79D

    Const decSmallCrossbreedE As Decimal = 1.17D
    Const decMedCrossbreedE As Decimal = 1.17 * 1.1D
    Const decLargeCrossbreedE As Decimal = 1.17 * 1.2D

    Const decSmallCrossbreedP As Decimal = 1.38D
    Const decMedCrossbreedP As Decimal = 1.38 * 1.1D
    Const decLargeCrossbreedP As Decimal = 1.38 * 1.2D

    Const decSmallCrossbreedPP As Decimal = 1.45D
    Const decMedCrossbreedPP As Decimal = 1.45 * 1.1D
    Const decLargeCrossbreedPP As Decimal = 1.45 * 1.2D

    Const decSmallMongrelE As Decimal = 0.99D
    Const decMedMongrelE As Decimal = 0.99 * 1.1D
    Const decLargeMongrelE As Decimal = 0.99 * 1.2D

    Const decSmallMongrelP As Decimal = 1.09D
    Const decMedMongrelP As Decimal = 1.09 * 1.1D
    Const decLargeMongrelP As Decimal = 1.09 * 1.2D

    Const decSmallMongrelPP As Decimal = 1.29D
    Const decMedMongrelPP As Decimal = 1.29 * 1.1D
    Const decLargeMongrelPP As Decimal = 1.29 * 1.2D


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
        'Once the Next button is clicked then, the necessary items for the user to complete the next step become available
        radEssential.Focus()
        gboInsurance.Visible = True
        txtDescription.Visible = True
        lblPrompt.Visible = True
        'Disable the ability to continue until the step is completed
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
        lblOtherDog.Visible = False
        txtOtherDog.Visible = False
    End Sub

    Private Sub radMixed_CheckedChanged(sender As Object, e As EventArgs) Handles radMixedDog.CheckedChanged
        cboMixedDog.Visible = True
        cboCrossbreedDog.Visible = False
        cboPedigreeDog.Visible = False
        lblOtherDog.Visible = False
        txtOtherDog.Visible = False
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