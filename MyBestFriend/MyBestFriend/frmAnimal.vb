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
    Public decOtherP As Decimal = 1.55D
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
    Public decOtherPP As Decimal = 1.79D

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

    Private Sub frmAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When Form loads hide everything except from the necessary tools for the user 
        gboInsurance.Visible = False
        txtDescription.Visible = False
        btnContinue.Visible = False
        lblPrompt.Visible = False
        gboBreedDog.Visible = False
        gboBreedCat.Visible = False
        gboOptionsCat.Visible = False
        gboOptionsDog.Visible = False
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

        If radPedigreeDog.Checked And cboPedigreeDog.Text <> "" Then
            btnContinueDog.Visible = True
        End If
    End Sub

    Private Sub cboPedigreeCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPedigreeCat.SelectedIndexChanged
        If cboPedigreeCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If
        If radPedigreeCat.Checked And cboPedigreeCat.Text <> "" Then
            btnContinueCat.Visible = True
        End If
    End Sub

    Private Sub cboCrossbreedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCrossbreedCat.SelectedIndexChanged
        If cboCrossbreedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If

        If radCrossbreedCat.Checked And cboCrossbreedCat.Text <> "" Then
            btnContinueCat.Visible = True
        End If
    End Sub

    Private Sub cboMixedCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMixedCat.SelectedIndexChanged
        If cboMixedCat.Text = "Other" Then
            txtOtherCat.Visible = True
            lblOtherCat.Visible = True
        End If

        If radMixedCat.Checked And cboMixedCat.Text <> "" Then
            btnContinueCat.Visible = True
        End If
    End Sub

    Private Sub cboCrossbreedDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCrossbreedDog.SelectedIndexChanged
        If radCrossbreedDog.Checked And cboCrossbreedDog.Text <> "" Then
            btnContinueDog.Visible = True
        End If
    End Sub

    Private Sub cboMixedDog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMixedDog.SelectedIndexChanged
        If radMixedDog.Checked And cboMixedDog.Text <> "" Then
            btnContinueDog.Visible = True
        End If
    End Sub

    Private Sub btnContinueCat_Click(sender As Object, e As EventArgs) Handles btnContinueCat.Click
        gboOptionsCat.Visible = True

    End Sub

    Private Sub btnContinueDog_Click(sender As Object, e As EventArgs) Handles btnContinueDog.Click
        gboOptionsDog.Visible = True

    End Sub

    Private Sub gboOptionsDog_Enter(sender As Object, e As EventArgs) Handles gboOptionsDog.Enter
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

    End Sub

    Private Sub radGroomingDog_CheckedChanged(sender As Object, e As EventArgs) Handles radGroomingDog.CheckedChanged
        If radGroomingDog.Checked Then
            cboGroomingDog.Visible = True
        Else
            cboGroomingDog.Visible = False
        End If
    End Sub

    Private Sub gboOptionsCat_Enter(sender As Object, e As EventArgs) Handles gboOptionsCat.Enter
        radSmallCatGrooming.Visible = False
        radMediumCatGrooming.Visible = False
        radSmallCatHouse.Visible = False
        radMediumCatHouse.Visible = False
    End Sub

    Private Sub radGroomingCat_CheckedChanged(sender As Object, e As EventArgs) Handles radGroomingCat.CheckedChanged
        If radGroomingCat.Checked Then
            radSmallCatGrooming.Visible = True
            radMediumCatGrooming.Visible = True
        Else
            radSmallCatGrooming.Visible = False
            radMediumCatGrooming.Visible = False
        End If

    End Sub

    Private Sub radHouseCat_CheckedChanged(sender As Object, e As EventArgs) Handles radHouseCat.CheckedChanged
        If radHouseCat.Checked Then
            radSmallCatHouse.Visible = True
            radMediumCatHouse.Visible = True
        Else
            radSmallCatHouse.Visible = False
            radMediumCatHouse.Visible = False
        End If

    End Sub

End Class