Public Class frmAnimal
    'Decalring Contants for the Essential cost for each Pedigree Dog
    Public decAfricanE As Decimal = 1.14D
    Public decBoxerE As Decimal = 0.86D
    Public decChihuahuaE As Decimal = 1.83D
    Public decDalmatianE As Decimal = 0.65D
    Public decEskimoDogE As Decimal = 1.14D
    Public decFarmE As Decimal = 0.95D
    Public decGreyE As Decimal = 1.99D
    Public decHuskyE As Decimal = 1.85D
    Public decIrishE As Decimal = 0.65D
    Public decJackE As Decimal = 1.77D
    Public decKingE As Decimal = 1.02D
    Public decLabradorE As Decimal = 1.74D
    Public decMalteseE As Decimal = 1.47D
    Public decPugE As Decimal = 1.31D
    Public decRottE As Decimal = 2.17D
    Public decStBernardE As Decimal = 1.63D
    Public decTibetanE As Decimal = 1.15D
    Public decWorkingSheepE As Decimal = 0.75D
    Public decYorkshireE As Decimal = 0.88D
    Public decOtherDogE As Decimal = 1.22D
    'Decalring Contants for the Premier cost for each Pedigree Dog
    Public decAfricanP As Decimal = 1.24D
    Public decBoxerP As Decimal = 0.94D
    Public decChihuahuaP As Decimal = 1.99D
    Public decDalmatianP As Decimal = 0.79D
    Public decEskimoDogP As Decimal = 1.25D
    Public decFarmP As Decimal = 1.02D
    Public decGreyP As Decimal = 2.14D
    Public decHuskyP As Decimal = 2.08D
    Public decIrishP As Decimal = 0.8D
    Public decJackP As Decimal = 1.98D
    Public decKingP As Decimal = 1.22D
    Public decLabradorP As Decimal = 1.98D
    Public decMalteseP As Decimal = 1.66D
    Public decPugP As Decimal = 1.61D
    Public decRottP As Decimal = 2.55D
    Public decStBernardP As Decimal = 1.82D
    Public decTibetanP As Decimal = 1.3D
    Public decWorkingSheepP As Decimal = 0.88D
    Public decYorkshireP As Decimal = 1.11D
    Public decOtherDogP As Decimal = 1.55D
    'Decalring Contants for the Premier Plus cost for each Pedigree Dog
    Public decAfricanPP As Decimal = 1.35D
    Public decBoxerPP As Decimal = 1.26D
    Public decChihuahuaPP As Decimal = 2.04D
    Public decDalmatianPP As Decimal = 1D
    Public decEskimoDogPP As Decimal = 1.56D
    Public decFarmPP As Decimal = 1.3D
    Public decGreyPP As Decimal = 2.38D
    Public decHuskyPP As Decimal = 2.25D
    Public decIrishPP As Decimal = 1.15D
    Public decJackPP As Decimal = 2.12D
    Public decKingPP As Decimal = 1.56D
    Public decLabradorPP As Decimal = 2.11D
    Public decMaltesePP As Decimal = 1.99D
    Public decPugPP As Decimal = 1.89D
    Public decRottPP As Decimal = 2.99D
    Public decStBernardPP As Decimal = 2.02D
    Public decTibetanPP As Decimal = 1.61D
    Public decWorkingSheepPP As Decimal = 1.11D
    Public decYorkshirePP As Decimal = 1.48D
    Public decOtherDogPP As Decimal = 1.79D

    'Decalring Contants for the Essential cost for each Crossbreed Dog
    Public decSmallCrossbreedE As Decimal = 1.17D
    Public decMedCrossbreedE As Decimal = 1.17 * 1.1D
    Public decLargeCrossbreedE As Decimal = 1.17 * 1.2D
    'Decalring Contants for the Premier cost for each Crossbreed Dog
    Public decSmallCrossbreedP As Decimal = 1.38D
    Public decMedCrossbreedP As Decimal = 1.38 * 1.1D
    Public decLargeCrossbreedP As Decimal = 1.38 * 1.2D
    'Decalring Contants for the Premier Plus cost for each Crossbreed Dog
    Public decSmallCrossbreedPP As Decimal = 1.45D
    Public decMedCrossbreedPP As Decimal = 1.45 * 1.1D
    Public decLargeCrossbreedPP As Decimal = 1.45 * 1.2D

    'Decalring Contants for the Essential cost for each Mixed breed Dog
    Public decSmallMongrelE As Decimal = 0.99D
    Public decMedMongrelE As Decimal = 0.99 * 1.1D
    Public decLargeMongrelE As Decimal = 0.99 * 1.2D
    'Decalring Contants for the Premier cost for each Mixed Breed Dog
    Public decSmallMongrelP As Decimal = 1.09D
    Public decMedMongrelP As Decimal = 1.09 * 1.1D
    Public decLargeMongrelP As Decimal = 1.09 * 1.2D
    'Decalring Contants for the Premier Plus cost for each Mixed Breed Dog
    Public decSmallMongrelPP As Decimal = 1.29D
    Public decMedMongrelPP As Decimal = 1.29 * 1.1D
    Public decLargeMongrelPP As Decimal = 1.29 * 1.2D

    'Decalring Contants for the Essential cost for each Pedigree Cat
    Public decAngoraE As Decimal = 0.72D
    Public decBurmeseE As Decimal = 0.77D
    Public decCymricE As Decimal = 1.01D
    Public decDevonE As Decimal = 0.74D
    Public decEgyptianE As Decimal = 1.1D
    Public decForestE As Decimal = 0.95D
    Public decHavanaE As Decimal = 0.87D
    Public decJapaneseE As Decimal = 1.05D
    Public decKoratE As Decimal = 0.65D
    Public decManxE As Decimal = 0.68D
    Public decNebelungE As Decimal = 1.21D
    Public decOrientalE As Decimal = 0.88D
    Public decPersianE As Decimal = 1.47D
    Public decRagdollE As Decimal = 0.98D
    Public decSiameseE As Decimal = 1.33D
    Public decTiffanyE As Decimal = 1.38D
    Public decOtherPedigreeCatE As Decimal = 2.25D
    'Decalring Contants for the Premier cost for each Pedigree Cat
    Public decAngoraP As Decimal = 1.14D
    Public decBurmeseP As Decimal = 0.94D
    Public decCymricP As Decimal = 1.17D
    Public decDevonP As Decimal = 1.08D
    Public decEgyptianP As Decimal = 1.25D
    Public decForestP As Decimal = 1.02D
    Public decHavanaP As Decimal = 1.04D
    Public decJapaneseP As Decimal = 1.2D
    Public decKoratP As Decimal = 0.8D
    Public decManxP As Decimal = 0.83D
    Public decNebelungP As Decimal = 1.45D
    Public decOrientalP As Decimal = 1.08D
    Public decPersianP As Decimal = 1.66D
    Public decRagdollP As Decimal = 1.02D
    Public decSiameseP As Decimal = 1.77D
    Public decTiffanyP As Decimal = 1.82D
    Public decOtherPedigreeCatP As Decimal = 2.4D
    'Decalring Contants for the Premier Plus cost for each Pedigree Cat
    Public decAngoraPP As Decimal = 1.48D
    Public decBurmesePP As Decimal = 1.19D
    Public decCymricPP As Decimal = 1.52D
    Public decDevonPP As Decimal = 1D
    Public decEgyptianPP As Decimal = 1.56D
    Public decForestPP As Decimal = 1.3D
    Public decHavanaPP As Decimal = 1.39D
    Public decJapanesePP As Decimal = 1.44D
    Public decKoratPP As Decimal = 1.15D
    Public decManxPP As Decimal = 1.18D
    Public decNebelungPP As Decimal = 1.87D
    Public decOrientalPP As Decimal = 1.33D
    Public decPersianPP As Decimal = 1.99D
    Public decRagdollPP As Decimal = 1.21D
    Public decSiamesePP As Decimal = 2.01D
    Public decTiffanyPP As Decimal = 2.05D
    Public decOtherPedigreeCatPP As Decimal = 2.89D

    'Decalring Contants for the Essential cost for each CrossBreed Cat
    Public decAmericanE As Decimal = 1.17D
    Public decBlueTabbyE As Decimal = 0.81D
    Public decCornishE As Decimal = 0.38D
    Public decExoticE As Decimal = 1.11D
    Public decMaineCoonE As Decimal = 0.69D
    Public decScottishE As Decimal = 1.37D
    Public decSnowLeopardE As Decimal = 0.67D
    Public decTurkishE As Decimal = 1.15D
    Public decOtherCrossbreedCatE As Decimal = 1.84D
    'Decalring Contants for the Premier cost for each CrossBreed Cat
    Public decAmericanP As Decimal = 1.17 * 1.1D
    Public decBlueTabbyP As Decimal = 0.81 * 1.1D
    Public decCornishP As Decimal = 0.38 * 1.1D
    Public decExoticP As Decimal = 1.11 * 1.1D
    Public decMaineCoonP As Decimal = 0.69 * 1.1D
    Public decScottishP As Decimal = 1.37 * 1.1D
    Public decSnowLeopardP As Decimal = 0.67 * 1.1D
    Public decTurkishP As Decimal = 1.15 * 1.1D
    Public decOtherCrossbreedCatP As Decimal = 1.84 * 1.1D
    'Decalring Contants for the Premier Plus cost for each CrossBreed Cat
    Public decAmericanPP As Decimal = 1.17 * 1.2D
    Public decBlueTabbyPP As Decimal = 0.8 * 1.21D
    Public decCornishPP As Decimal = 0.38 * 1.2D
    Public decExoticPP As Decimal = 1.11 * 1.2D
    Public decMaineCoonPP As Decimal = 0.69 * 1.2D
    Public decScottishPP As Decimal = 1.37 * 1.2D
    Public decSnowLeopardPP As Decimal = 0.67 * 1.2D
    Public decTurkishPP As Decimal = 1.15 * 1.2D
    Public decOtherCrossbreedCatPP As Decimal = 1.84 * 1.2D

    'Decalring Contants for the Essential cost for each Mixed Breed Cat
    Public decMoggieE As Decimal = 0.84D
    Public decDomesticLonghairE As Decimal = 1.06D
    Public decDomesticShorthairE As Decimal = 1.04D
    Public decForeignShorthairE As Decimal = 1.09D
    Public decOtherMixedBreedCatE As Decimal = 1.18D
    'Decalring Contants for the Premier cost for each Mixed Breed Cat
    Public decMoggieP As Decimal = 0.84 * 1.1D
    Public decDomesticLonghairP As Decimal = 1.06 * 1.1D
    Public decDomesticShorthairP As Decimal = 1.04 * 1.1D
    Public decForeignShorthairP As Decimal = 1.09 * 1.1D
    Public decOtherMixedBreedCatP As Decimal = 1.18 * 1.1D
    'Decalring Contants for the Premier PLus cost for each Mixed Breed Cat
    Public decMoggiePP As Decimal = 0.84 * 1.2D
    Public decDomesticLonghairPP As Decimal = 1.06 * 1.2D
    Public decDomesticShorthairPP As Decimal = 1.04 * 1.2D
    Public decForeignShorthairPP As Decimal = 1.09 * 1.2D
    Public decOtherMixedBreedCatPP As Decimal = 1.18 * 1.2D

    Public decPricePerDay As Decimal
    Public decPricePerYear As Decimal

    Private Sub frmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When Form loads hide everything except from the necessary tools for the user 
        gboInsurance.Visible = False
        txtDescription.Visible = False
        btnContinue.Visible = False
        lblPrompt.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
        gboAddOnCat.Visible = False
        gboAddOnDog.Visible = False
        gboCost.Visible = False
        gboAddOns2.Visible = False
        gboAddOnsDog.Visible = False
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
        btnContinueDog.Visible = False


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
        btnContinueCat.Visible = False

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
        gboAddOns2.Visible = False
        gboCost.Visible = False
        gboAddOnsDog.Visible = False
    End Sub

    Private Sub radDog_CheckedChanged(sender As Object, e As EventArgs) Handles radDog.CheckedChanged
        'If user changes from Cat to Dog then everything clears and user starts from beginning
        gboInsurance.Visible = False
        lblPrompt.Visible = False
        txtDescription.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
        btnContinue.Visible = False
        gboAddOnCat.Visible = False
        gboAddOns2.Visible = False
        gboCost.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOtherDog.TextChanged

    End Sub

    Private Sub cboPedigreeDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedigreeDog.SelectedIndexChanged
        If cboPedigreeDog.Text = "Other" Then
            txtOtherDog.Visible = True
            lblOtherDog.Visible = True
        End If

        If radPedigreeDog.Checked And cboPedigreeDog.Text <> "" Then
            btnContinueDog.Visible = True
        Else
            btnContinue.Visible = False
        End If
    End Sub

    Private Sub cboPedigreeCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedigreeCat.SelectedIndexChanged
        If cboPedigreeCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If
        If radPedigreeCat.Checked And cboPedigreeCat.Text <> "" Then
            btnContinueCat.Visible = True
        Else
            btnContinue.Visible = False
        End If
    End Sub

    Private Sub cboCrossbreedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCrossbreedCat.SelectedIndexChanged
        If cboCrossbreedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        Else
            btnContinue.Visible = False
        End If

        If radCrossbreedCat.Checked And cboCrossbreedCat.Text <> "" Then
            btnContinueCat.Visible = True
        End If
    End Sub

    Private Sub cboMixedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMixedCat.SelectedIndexChanged
        If cboMixedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        Else
            btnContinue.Visible = False
        End If

        If radMixedCat.Checked And cboMixedCat.Text <> "" Then
            btnContinueCat.Visible = True
        End If
    End Sub

    Private Sub cboCrossbreedDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCrossbreedDog.SelectedIndexChanged
        If radCrossbreedDog.Checked And cboCrossbreedDog.Text <> "" Then
            btnContinueDog.Visible = True
        Else
            btnContinue.Visible = False
        End If
    End Sub

    Private Sub cboMixedDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMixedDog.SelectedIndexChanged
        If radMixedDog.Checked And cboMixedDog.Text <> "" Then
            btnContinueDog.Visible = True
        Else
            btnContinue.Visible = False
        End If
    End Sub

    Private Sub btnContinueCat_Click(sender As Object, e As EventArgs) Handles btnContinueCat.Click
        gboAddOnCat.Visible = True

    End Sub

    Private Sub btnContinueDog_Click(sender As Object, e As EventArgs) Handles btnContinueDog.Click
        gboAddOnsDog.Visible = True

    End Sub

    Private Sub gboOptionsDog_Enter(sender As Object, e As EventArgs) Handles gboAddOnDog.Enter
        cboGroomingDog.Visible = False
        radSmallDogShort.Visible = False
        radMediumDogShort.Visible = False
        radLargeDogShort.Visible = False
        radSmallDogLong.Visible = False
        radMediumDogLong.Visible = False
        radLargeDogLong.Visible = False
        radSmallDogHouse.Visible = False
        radMediumDogHouse.Visible = False
        radLargeDogHouse.Visible = False
        btnNextDog.Enabled = False
    End Sub

    Private Sub cboGroomingDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroomingDog.SelectedIndexChanged
        If cboGroomingDog.Text = "Short / Smooth" Then
            radSmallDogShort.Visible = True And radMediumDogShort.Visible = True And radLargeDogShort.Visible = True
        Else
            radSmallDogShort.Visible = False And radMediumDogShort.Visible = False And radLargeDogShort.Visible = False
        End If

        If cboGroomingDog.Text = "Long / Heavy / Curly" Then
            radSmallDogLong.Visible = True And radMediumDogLong.Visible = True And radLargeDogLong.Visible = True
        Else
            radSmallDogLong.Visible = False And radMediumDogLong.Visible = False And radLargeDogLong.Visible = False
        End If

    End Sub

    Private Sub radHouseDog_CheckedChanged(sender As Object, e As EventArgs) Handles radHouseDog.CheckedChanged
        If radHouseDog.Checked Then
            radSmallDogHouse.Visible = True
            radMediumDogHouse.Visible = True
            radLargeDogHouse.Visible = True
        Else
            radSmallDogHouse.Visible = False
            radMediumDogHouse.Visible = False
            radLargeDogHouse.Visible = False
        End If

        If radHouseDog.Checked Then
            btnNextDog.Enabled = True
        Else
            btnNextDog.Enabled = False
        End If
    End Sub

    Private Sub radGroomingDog_CheckedChanged(sender As Object, e As EventArgs) Handles radGroomingDog.CheckedChanged
        If radGroomingDog.Checked Then
            cboGroomingDog.Visible = True
        Else
            cboGroomingDog.Visible = False
        End If

        If radHouseDog.Checked Then
            btnNextDog.Enabled = True
        Else
            btnNextDog.Enabled = False
        End If
    End Sub

    Private Sub gboOptionsCat_Enter(sender As Object, e As EventArgs) Handles gboAddOnCat.Enter
        radSmallCatGrooming.Visible = False
        radMediumCatGrooming.Visible = False
        radSmallCatHouse.Visible = False
        radMediumCatHouse.Visible = False
        gboGrooming.Visible = False
        gboHouse.Visible = False
    End Sub

    Private Sub radGroomingCat_CheckedChanged(sender As Object, e As EventArgs) Handles radGroomingCat.CheckedChanged
        gboGrooming.Visible = True
        gboHouse.Visible = False
    End Sub

    Private Sub radHouseCat_CheckedChanged(sender As Object, e As EventArgs) Handles radHouseCat.CheckedChanged
        gboHouse.Visible = True
        gboGrooming.Visible = False
    End Sub

    Private Sub btnCostDog_Click(sender As Object, e As EventArgs) Handles btnNextDog.Click
        gboAddOns2.Visible = True
    End Sub

    Private Sub btnCostCat_Click(sender As Object, e As EventArgs) Handles btnNextCat.Click
        gboAddOns2.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrice.Click

        gboCost.Visible = True

        If radEssential.Checked And cboPedigreeCat.Text = "Angora" Then
            decPricePerDay = decAngoraE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Angora" Then
            decPricePerDay = decAngoraP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Angora" Then
            decPricePerDay = decAngoraPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Burmese" Then
            decPricePerDay = decBurmeseE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Burmese" Then
            decPricePerDay = decBurmeseP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Burmese" Then
            decPricePerDay = decBurmesePP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Cymric" Then
            decPricePerDay = decCymricE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Cymric" Then
            decPricePerDay = decCymricP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Cymric" Then
            decPricePerDay = decCymricPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Devon Rex" Then
            decPricePerDay = decDevonE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Devon Rex" Then
            decPricePerDay = decDevonP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Devon Rex" Then
            decPricePerDay = decDevonPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Egyptian Mau" Then
            decPricePerDay = decEgyptianE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Egyptian Mau" Then
            decPricePerDay = decEgyptianP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Egyptian Mau" Then
            decPricePerDay = decEgyptianPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Forest Cat" Then
            decPricePerDay = decForestE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Forest Cat" Then
            decPricePerDay = decForestP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Forest Cat" Then
            decPricePerDay = decForestPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Havana" Then
            decPricePerDay = decHavanaE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Havana" Then
            decPricePerDay = decHavanaP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Havana" Then
            decPricePerDay = decHavanaPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Japanese Bobtail" Then
            decPricePerDay = decHavanaE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Japanese Bobtail" Then
            decPricePerDay = decHavanaP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Japanese Bobtail" Then
            decPricePerDay = decHavanaPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Korat" Then
            decPricePerDay = decKoratE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Korat" Then
            decPricePerDay = decKoratP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Korat" Then
            decPricePerDay = decKoratPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Manx" Then
            decPricePerDay = decManxE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Manx" Then
            decPricePerDay = decManxP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Manx" Then
            decPricePerDay = decManxPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Nebelung" Then
            decPricePerDay = decNebelungE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Nebelung" Then
            decPricePerDay = decNebelungP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Nebelung" Then
            decPricePerDay = decNebelungPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Oriental" Then
            decPricePerDay = decOrientalE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Oriental" Then
            decPricePerDay = decOrientalP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Oriental" Then
            decPricePerDay = decOrientalPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Persian" Then
            decPricePerDay = decPersianE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Persian" Then
            decPricePerDay = decPersianP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Persian" Then
            decPricePerDay = decPersianPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Ragdoll" Then
            decPricePerDay = decRagdollE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Ragdoll" Then
            decPricePerDay = decRagdollP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Ragdoll" Then
            decPricePerDay = decRagdollPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Siamese" Then
            decPricePerDay = decSiameseE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Siamese" Then
            decPricePerDay = decSiameseP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Siamese" Then
            decPricePerDay = decSiamesePP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Tiffany" Then
            decPricePerDay = decTiffanyE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Tiffany" Then
            decPricePerDay = decTiffanyP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Tiffany" Then
            decPricePerDay = decTiffanyPP
        ElseIf radEssential.Checked And cboPedigreeCat.Text = "Other" Then
            decPricePerDay = decOtherPedigreeCatE
        ElseIf radPremier.Checked And cboPedigreeCat.Text = "Other" Then
            decPricePerDay = decOtherPedigreeCatP
        ElseIf radPlus.Checked And cboPedigreeCat.Text = "Other" Then
            decPricePerDay = decOtherPedigreeCatPP

        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "American Curl" Then
            decPricePerDay = decAmericanE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "American Curl" Then
            decPricePerDay = decAmericanP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "American Curl" Then
            decPricePerDay = decAmericanPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Blue Tabby" Then
            decPricePerDay = decBlueTabbyE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Blue Tabby" Then
            decPricePerDay = decBlueTabbyP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Blue Tabby" Then
            decPricePerDay = decBlueTabbyPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Cornish Rex" Then
            decPricePerDay = decCornishE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Cornish Rex" Then
            decPricePerDay = decCornishP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Cornish Rex" Then
            decPricePerDay = decCornishPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Exotic Shorthair" Then
            decPricePerDay = decExoticE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Exotic Shorthair" Then
            decPricePerDay = decExoticP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Exotic Shorthair" Then
            decPricePerDay = decExoticPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Maine Coon" Then
            decPricePerDay = decMaineCoonE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Maine Coon" Then
            decPricePerDay = decMaineCoonP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Maine Coon" Then
            decPricePerDay = decMaineCoonPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Scottish Folds" Then
            decPricePerDay = decScottishE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Scottish Folds" Then
            decPricePerDay = decScottishP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Scottish Folds" Then
            decPricePerDay = decScottishPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Snow Leopard Bengal Cat" Then
            decPricePerDay = decSnowLeopardE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Snow Leopard Bengal Cat" Then
            decPricePerDay = decSnowLeopardP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Snow Leopard Bengal Cat" Then
            decPricePerDay = decSnowLeopardPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Turkish Van Cat" Then
            decPricePerDay = decTurkishE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Turkish Van Cat" Then
            decPricePerDay = decTurkishP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Turkish Van Cat" Then
            decPricePerDay = decTurkishPP
        ElseIf radEssential.Checked And cboCrossbreedCat.Text = "Other" Then
            decPricePerDay = decOtherCrossbreedCatE
        ElseIf radPremier.Checked And cboCrossbreedCat.Text = "Other" Then
            decPricePerDay = decOtherCrossbreedCatP
        ElseIf radPlus.Checked And cboCrossbreedCat.Text = "Other" Then
            decPricePerDay = decOtherCrossbreedCatPP

        ElseIf radEssential.Checked And cboMixedCat.Text = "Moggie" Then
            decPricePerDay = decMoggieE
        ElseIf radPremier.Checked And cboMixedCat.Text = "Moggie" Then
            decPricePerDay = decMoggieP
        ElseIf radPlus.Checked And cboMixedCat.Text = "Moggie" Then
            decPricePerDay = decMoggiePP
        ElseIf radEssential.Checked And cboMixedCat.Text = "Domestic Longhair" Then
            decPricePerDay = decDomesticLonghairE
        ElseIf radPremier.Checked And cboMixedCat.Text = "Domestic Longhair" Then
            decPricePerDay = decDomesticLonghairP
        ElseIf radPlus.Checked And cboMixedCat.Text = "Domestic Longhair" Then
            decPricePerDay = decDomesticLonghairPP
        ElseIf radEssential.Checked And cboMixedCat.Text = "Domestic Shorthair" Then
            decPricePerDay = decDomesticShorthairE
        ElseIf radPremier.Checked And cboMixedCat.Text = "Domestic Shorthair" Then
            decPricePerDay = decDomesticShorthairP
        ElseIf radPlus.Checked And cboMixedCat.Text = "Domestic Shorthair" Then
            decPricePerDay = decDomesticShorthairPP
        ElseIf radEssential.Checked And cboMixedCat.Text = "Foreign Shorthairs" Then
            decPricePerDay = decForeignShorthairE
        ElseIf radPremier.Checked And cboMixedCat.Text = "Foreign Shorthairs" Then
            decPricePerDay = decForeignShorthairP
        ElseIf radPlus.Checked And cboMixedCat.Text = "Foreign Shorthairs" Then
            decPricePerDay = decForeignShorthairPP
        ElseIf radEssential.Checked And cboMixedCat.Text = "Other" Then
            decPricePerDay = decOtherMixedBreedCatE
        ElseIf radPremier.Checked And cboMixedCat.Text = "Other" Then
            decPricePerDay = decOtherMixedBreedCatP
        ElseIf radPlus.Checked And cboMixedCat.Text = "Other" Then
            decPricePerDay = decOtherMixedBreedCatPP

        ElseIf radEssential.Checked And cboPedigreeDog.Text = "African Hairless" Then
            decPricePerDay = decAfricanE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "African Hairless" Then
            decPricePerDay = decAfricanP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "African Hairless" Then
            decPricePerDay = decAfricanPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Boxer" Then
            decPricePerDay = decBoxerE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Boxer" Then
            decPricePerDay = decBoxerP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Boxer" Then
            decPricePerDay = decBoxerPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Chihuahua" Then
            decPricePerDay = decChihuahuaE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Chihuahua" Then
            decPricePerDay = decChihuahuaP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Chihuahua" Then
            decPricePerDay = decChihuahuaPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Dalmatian" Then
            decPricePerDay = decDalmatianE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Dalmatian" Then
            decPricePerDay = decDalmatianP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Dalmatian" Then
            decPricePerDay = decDalmatianPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Eskimo Dog" Then
            decPricePerDay = decEskimoDogE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Eskimo Dog" Then
            decPricePerDay = decEskimoDogP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Eskimo Dog" Then
            decPricePerDay = decEskimoDogPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Farm Collie" Then
            decPricePerDay = decFarmE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Farm Collie" Then
            decPricePerDay = decFarmP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Farm Collie" Then
            decPricePerDay = decFarmPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "GreyHound" Then
            decPricePerDay = decGreyE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "GreyHound" Then
            decPricePerDay = decGreyP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "GreyHound" Then
            decPricePerDay = decGreyPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Husky" Then
            decPricePerDay = decHuskyE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Husky" Then
            decPricePerDay = decHuskyP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Husky" Then
            decPricePerDay = decHuskyPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Irish Setter" Then
            decPricePerDay = decIrishE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Irish Setter" Then
            decPricePerDay = decIrishP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Irish Setter" Then
            decPricePerDay = decIrishPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Jack Russell Terrier" Then
            decPricePerDay = decJackE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Jack Russell Terrier" Then
            decPricePerDay = decJackP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Jack Russell Terrier" Then
            decPricePerDay = decJackPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "King Charles Spaniel" Then
            decPricePerDay = decKingE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "King Charles Spaniel" Then
            decPricePerDay = decKingP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "King Charles Spaniel" Then
            decPricePerDay = decKingPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Labrador Retriever" Then
            decPricePerDay = decLabradorE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Labrador Retriever" Then
            decPricePerDay = decLabradorP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Labrador Retriever" Then
            decPricePerDay = decLabradorPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Maltese" Then
            decPricePerDay = decMalteseE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Maltese" Then
            decPricePerDay = decMalteseP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Maltese" Then
            decPricePerDay = decMaltesePP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Pug" Then
            decPricePerDay = decPugE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Pug" Then
            decPricePerDay = decPugP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Pug" Then
            decPricePerDay = decPugPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Rottweiler" Then
            decPricePerDay = decRottE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Rottweiler" Then
            decPricePerDay = decRottP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Rottweiler" Then
            decPricePerDay = decRottPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "St Bernard" Then
            decPricePerDay = decStBernardE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "St Bernard" Then
            decPricePerDay = decStBernardP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "St Bernard" Then
            decPricePerDay = decStBernardPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Tibetan Mastiff" Then
            decPricePerDay = decTibetanE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Tibetan Mastiff" Then
            decPricePerDay = decTibetanP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Tibetan Mastiff" Then
            decPricePerDay = decTibetanPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Working Sheep Dog" Then
            decPricePerDay = decWorkingSheepE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Working Sheep Dog" Then
            decPricePerDay = decWorkingSheepP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Working Sheep Dog" Then
            decPricePerDay = decWorkingSheepPP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Yorkshire Terrier" Then
            decPricePerDay = decYorkshireE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Yorkshire Terrier" Then
            decPricePerDay = decYorkshireP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Yorkshire Terrier" Then
            decPricePerDay = decYorkshirePP
        ElseIf radEssential.Checked And cboPedigreeDog.Text = "Other" Then
            decPricePerDay = decOtherDogE
        ElseIf radPremier.Checked And cboPedigreeDog.Text = "Other" Then
            decPricePerDay = decOtherDogP
        ElseIf radPlus.Checked And cboPedigreeDog.Text = "Other" Then
            decPricePerDay = decOtherDogPP

        ElseIf radEssential.Checked And cboCrossbreedDog.Text = "Small Crossbreed (Up to 10kgs)" Then
            decPricePerDay = decSmallCrossbreedE
        ElseIf radPremier.Checked And cboCrossbreedDog.Text = "Small Crossbreed (Up to 10kgs)" Then
            decPricePerDay = decSmallCrossbreedP
        ElseIf radPlus.Checked And cboCrossbreedDog.Text = "Small Crossbreed (Up to 10kgs)" Then
            decPricePerDay = decSmallCrossbreedPP
        ElseIf radEssential.Checked And cboCrossbreedDog.Text = "Medium Crossbreed (10kgs - 20kgs)" Then
            decPricePerDay = decMedCrossbreedE
        ElseIf radPremier.Checked And cboCrossbreedDog.Text = "Medium Crossbreed (10kgs - 20kgs)" Then
            decPricePerDay = decMedCrossbreedP
        ElseIf radPlus.Checked And cboCrossbreedDog.Text = "Medium Crossbreed (10kgs - 20kgs)" Then
            decPricePerDay = decMedCrossbreedPP
        ElseIf radEssential.Checked And cboCrossbreedDog.Text = "Large Crossbreed (Greater than 20kgs)" Then
            decPricePerDay = decLargeCrossbreedE
        ElseIf radPremier.Checked And cboCrossbreedDog.Text = "Large Crossbreed (Greater than 20kgs)" Then
            decPricePerDay = decLargeCrossbreedP
        ElseIf radPlus.Checked And cboCrossbreedDog.Text = "Large Crossbreed (Greater than 20kgs)" Then
            decPricePerDay = decLargeCrossbreedPP

        ElseIf radEssential.Checked And cboMixedDog.Text = "Small Mongrel (Up to 10kgs)" Then
            decPricePerDay = decSmallMongrelE
        ElseIf radPremier.Checked And cboMixedDog.Text = "Small Mongrel (Up to 10kgs)" Then
            decPricePerDay = decSmallMongrelP
        ElseIf radPlus.Checked And cboMixedDog.Text = "Small Mongrel (Up to 10kgs)" Then
            decPricePerDay = decSmallMongrelPP
        ElseIf radEssential.Checked And cboMixedDog.Text = "Medium Mongrel (10kgs - 20kgs)" Then
            decPricePerDay = decMedMongrelE
        ElseIf radPremier.Checked And cboMixedDog.Text = "Medium Mongrel (10kgs - 20kgs)" Then
            decPricePerDay = decMedMongrelP
        ElseIf radPlus.Checked And cboMixedDog.Text = "Medium Mongrel (10kgs - 20kgs)" Then
            decPricePerDay = decMedMongrelPP
        ElseIf radEssential.Checked And cboMixedDog.Text = "Large Mongrel (Greater than 20kgs)" Then
            decPricePerDay = decLargeMongrelE
        ElseIf radPremier.Checked And cboMixedDog.Text = "Large Mongrel (Greater than 20kgs)" Then
            decPricePerDay = decLargeMongrelP
        ElseIf radPlus.Checked And cboMixedDog.Text = "Large Mongrel (Greater than 20kgs)" Then
            decPricePerDay = decLargeMongrelPP
        End If

        txtPricePerDay.Clear()
        txtPricePerYear.Clear()
        txtPricePerDay.Text = decPricePerDay
        txtPricePerYear.Text = decPricePerDay * 365
        If radGroomingCat.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 20
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radMediumCatGrooming.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 25
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radSmallCatHouse.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 14
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radMediumCatHouse.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 14
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If chkEU.Checked Then
            decPricePerDay = decPricePerDay + 1
            txtPricePerYear.Text = (decPricePerDay * 365)
        Else
            decPricePerDay = decPricePerDay
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If chkNonEU.Checked Then
            decPricePerDay = decPricePerDay + 1.25
            txtPricePerYear.Text = (decPricePerDay * 365)
        Else
            decPricePerDay = decPricePerDay
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If chkInjury.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) * 1.25
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If chkDental.Checked Then
            txtPricePerYear.Text = decPricePerDay * 365 + 35
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If txtPromo.Text = "Bestie" Then
            txtPricePerYear.Text = decPricePerDay * 365 * 1.15
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radSmallDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 45
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radMediumDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 50
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radLargeDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 55
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radSmallGroomingDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 25
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radMediumGroomingDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 30
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radLargeDogGrooming.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 35
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radSmallHouseDog2.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 18
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radMediumHouseDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 22
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If

        If radLargeHouseDog.Checked Then
            txtPricePerYear.Text = (decPricePerDay * 365) + 28
        Else
            txtPricePerYear.Text = decPricePerDay * 365
        End If
    End Sub

    Private Sub gboCost_Enter(sender As Object, e As EventArgs) Handles gboCost.Enter
        txtPricePerDay.Text = decPricePerDay
    End Sub

    Private Sub cboGrooming_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboGrooming.Text = "Short / Smooth" Then
            gboGroomingDogShort.Visible = True
        Else
            gboGroomingDogShort.Visible = False
        End If


        If cboGrooming.Text = "Long / Heavy / Curly" Then
            gboGroomingDogLong.Visible = True
        Else
            gboGroomingDogLong.Visible = False
        End If


    End Sub

    Private Sub gboAddOnsDog_Enter(sender As Object, e As EventArgs)
        gboGroomingDogLong.Visible = False
        gboGroomingDogShort.Visible = False
        gboHouseDog.Visible = False
    End Sub

    Private Sub radGroomingDog2_CheckedChanged(sender As Object, e As EventArgs)
        cboGrooming.Visible = True
        gboHouseDog.Visible = False

    End Sub

    Private Sub radHouseDog2_CheckedChanged(sender As Object, e As EventArgs)
        cboGrooming.Visible = False
        gboGroomingDogLong.Visible = False
        gboGroomingDogShort.Visible = False
        gboHouseDog.Visible = True
    End Sub

    Private Sub btnNextDog2_Click(sender As Object, e As EventArgs)
        gboAddOns2.Visible = True
    End Sub

    Private Sub radGroomingDog2_CheckedChanged_1(sender As Object, e As EventArgs) Handles radGroomingDog2.CheckedChanged
        cboGrooming.Visible = True
        gboHouseDog.Visible = False
    End Sub

    Private Sub cboGrooming_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboGrooming.SelectedIndexChanged
        If cboGrooming.Text = "Short / Smooth" Then
            gboGroomingDogShort.Visible = True
        Else
            gboGroomingDogShort.Visible = False
        End If

        If cboGrooming.Text = "Long / Heavy / Curly" Then
            gboGroomingDogLong.Visible = True
        Else
            gboGroomingDogLong.Visible = False
        End If
    End Sub

    Private Sub radHouseDog2_CheckedChanged_1(sender As Object, e As EventArgs) Handles radHouseDog2.CheckedChanged
        gboHouseDog.Visible = True
        gboGroomingDogLong.Visible = False
        gboGroomingDogShort.Visible = False
    End Sub

    Private Sub btnNextDog2_Click_1(sender As Object, e As EventArgs) Handles btnNextDog2.Click
        gboAddOns2.Visible = True
    End Sub
End Class