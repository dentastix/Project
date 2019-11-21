Public Class frmUserDetails


    Private Sub btnProceed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when form loads only the necessary tools needed for the user appear
        gboBankDetails.Visible = False
        lstInvoice.Visible = False
        btnFinish.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProceedd.Click
        'When button is clicked the groupbox appears If all releveant fields are filled in

        If txtCustomerName.Text = "" Or mskAge.MaskCompleted = False Or txtStreetAddress.Text = "" Or
                txtTown.Text = "" Or cboCounty.Text = "" Or mskTelephone.Text = "" Then
            gboBankDetails.Visible = False
            MsgBox("Please Fill in required Fields and Try Again!")
            txtCustomerName.Focus()
        Else
            gboBankDetails.Visible = True
        End If
    End Sub

    Private Sub gboCustomerDetails_Enter(sender As Object, e As EventArgs) Handles gboCustomerDetails.Enter

    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        'When button is clicked the groupbox appears If all releveant fields are filled in
        If txtCardholderName.Text = "" Or cboPaymentType.Text = "" Or mskCardNumber.MaskCompleted = False Or mskCVV.MaskCompleted = False Or mskInsuranceDate.MaskCompleted = False Then
            lstInvoice.Visible = False
            MsgBox("Please Fill in required Fields and Try Again!")
            txtCardholderName.Focus()
        Else
            lstInvoice.Visible = True
        End If
        'When button is clicked then the items are added to the textbox

        lstInvoice.Items.Clear()
        lstInvoice.Items.Add("Policy Number: M1K389RT56XOX")
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Name Of recipient:" & "" & txtCustomerName.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Address Of recipient:" & "" & txtStreetAddress.Text)
        lstInvoice.Items.Add(txtTown.Text)
        lstInvoice.Items.Add(cboCounty.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Contact Info:" & mskTelephone.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Cost Per Day For the Insurance:  €" & ":" & frmAnimal.txtPricePerDay.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Cost Per Year For the Insurance:  €" & "" & frmAnimal.txtPricePerYear.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Start Date Of Insurance:" & "" & mskInsuranceDate.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Insurance Completed By:")
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Samual W Dent")
        lstInvoice.Items.Add("119401452")
        'When the button is clicked the final button appears
        btnFinish.Visible = True
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'Current form is hidden and final form appears
        Me.Visible = False
        frmEnd.Visible = True
    End Sub
End Class