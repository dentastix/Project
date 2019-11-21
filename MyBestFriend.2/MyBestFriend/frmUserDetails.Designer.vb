<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblStep7 = New System.Windows.Forms.Label()
        Me.gboCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.btnProceedd = New System.Windows.Forms.Button()
        Me.mskTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.mskAge = New System.Windows.Forms.MaskedTextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.gboBankDetails = New System.Windows.Forms.GroupBox()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.mskInsuranceDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblInsuranceStartDate = New System.Windows.Forms.Label()
        Me.mskCVV = New System.Windows.Forms.MaskedTextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblCardNumberr = New System.Windows.Forms.Label()
        Me.cboPaymentType = New System.Windows.Forms.ComboBox()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.txtCardholderName = New System.Windows.Forms.TextBox()
        Me.lblCardholdersName = New System.Windows.Forms.Label()
        Me.picLaser = New System.Windows.Forms.PictureBox()
        Me.picAmex = New System.Windows.Forms.PictureBox()
        Me.picMasterCard = New System.Windows.Forms.PictureBox()
        Me.picVisaa = New System.Windows.Forms.PictureBox()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboCustomerDetails.SuspendLayout()
        Me.gboBankDetails.SuspendLayout()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAmex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMasterCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisaa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.MyBestFriend.My.Resources.Resources.nuhy
        Me.picLogo.Location = New System.Drawing.Point(626, -14)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(190, 201)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblStep7
        '
        Me.lblStep7.AutoSize = True
        Me.lblStep7.BackColor = System.Drawing.Color.Transparent
        Me.lblStep7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep7.Location = New System.Drawing.Point(13, 13)
        Me.lblStep7.Name = "lblStep7"
        Me.lblStep7.Size = New System.Drawing.Size(264, 17)
        Me.lblStep7.TabIndex = 1
        Me.lblStep7.Text = "Step 7: Input Your Personal Details Below"
        '
        'gboCustomerDetails
        '
        Me.gboCustomerDetails.BackColor = System.Drawing.Color.Transparent
        Me.gboCustomerDetails.Controls.Add(Me.btnProceedd)
        Me.gboCustomerDetails.Controls.Add(Me.mskTelephone)
        Me.gboCustomerDetails.Controls.Add(Me.lblTelephoneNumber)
        Me.gboCustomerDetails.Controls.Add(Me.lblCounty)
        Me.gboCustomerDetails.Controls.Add(Me.cboCounty)
        Me.gboCustomerDetails.Controls.Add(Me.txtTown)
        Me.gboCustomerDetails.Controls.Add(Me.lblTown)
        Me.gboCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.gboCustomerDetails.Controls.Add(Me.txtStreetAddress)
        Me.gboCustomerDetails.Controls.Add(Me.lblStreetAddress)
        Me.gboCustomerDetails.Controls.Add(Me.mskAge)
        Me.gboCustomerDetails.Controls.Add(Me.lblAge)
        Me.gboCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.gboCustomerDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboCustomerDetails.Location = New System.Drawing.Point(16, 43)
        Me.gboCustomerDetails.Name = "gboCustomerDetails"
        Me.gboCustomerDetails.Size = New System.Drawing.Size(354, 273)
        Me.gboCustomerDetails.TabIndex = 2
        Me.gboCustomerDetails.TabStop = False
        Me.gboCustomerDetails.Text = "Customer Details"
        '
        'btnProceedd
        '
        Me.btnProceedd.BackColor = System.Drawing.Color.White
        Me.btnProceedd.Location = New System.Drawing.Point(273, 244)
        Me.btnProceedd.Name = "btnProceedd"
        Me.btnProceedd.Size = New System.Drawing.Size(75, 23)
        Me.btnProceedd.TabIndex = 13
        Me.btnProceedd.Text = "&Proceed"
        Me.btnProceedd.UseVisualStyleBackColor = False
        '
        'mskTelephone
        '
        Me.mskTelephone.Location = New System.Drawing.Point(198, 204)
        Me.mskTelephone.Mask = "(999) 000-0000"
        Me.mskTelephone.Name = "mskTelephone"
        Me.mskTelephone.Size = New System.Drawing.Size(100, 23)
        Me.mskTelephone.TabIndex = 12
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.AutoSize = True
        Me.lblTelephoneNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(13, 206)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(117, 15)
        Me.lblTelephoneNumber.TabIndex = 11
        Me.lblTelephoneNumber.Text = "Telephone Number:"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounty.Location = New System.Drawing.Point(81, 168)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(49, 15)
        Me.lblCounty.TabIndex = 10
        Me.lblCounty.Text = "County:"
        '
        'cboCounty
        '
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Cork", "Derry ", "Donegal", "Down", "Dooblin", "Fermanagh", "Galway", "Kerry ", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick ", "Longford", "Louth", "Garlic Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow "})
        Me.cboCounty.Location = New System.Drawing.Point(198, 166)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(121, 23)
        Me.cboCounty.TabIndex = 9
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(198, 127)
        Me.txtTown.MaxLength = 15
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(100, 23)
        Me.txtTown.TabIndex = 8
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTown.Location = New System.Drawing.Point(64, 129)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(66, 15)
        Me.lblTown.TabIndex = 7
        Me.lblTown.Text = "Town/City:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(198, 19)
        Me.txtCustomerName.MaxLength = 20
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerName.TabIndex = 6
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(198, 90)
        Me.txtStreetAddress.MaxLength = 50
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(100, 23)
        Me.txtStreetAddress.TabIndex = 5
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreetAddress.Location = New System.Drawing.Point(37, 92)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(93, 15)
        Me.lblStreetAddress.TabIndex = 4
        Me.lblStreetAddress.Text = "Street Address:"
        '
        'mskAge
        '
        Me.mskAge.Location = New System.Drawing.Point(198, 55)
        Me.mskAge.Mask = "00"
        Me.mskAge.Name = "mskAge"
        Me.mskAge.Size = New System.Drawing.Size(20, 23)
        Me.mskAge.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(98, 57)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 15)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(30, 21)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(100, 15)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'gboBankDetails
        '
        Me.gboBankDetails.BackColor = System.Drawing.Color.Transparent
        Me.gboBankDetails.Controls.Add(Me.btnInvoice)
        Me.gboBankDetails.Controls.Add(Me.mskInsuranceDate)
        Me.gboBankDetails.Controls.Add(Me.lblInsuranceStartDate)
        Me.gboBankDetails.Controls.Add(Me.mskCVV)
        Me.gboBankDetails.Controls.Add(Me.lblCVV)
        Me.gboBankDetails.Controls.Add(Me.mskCardNumber)
        Me.gboBankDetails.Controls.Add(Me.lblCardNumberr)
        Me.gboBankDetails.Controls.Add(Me.cboPaymentType)
        Me.gboBankDetails.Controls.Add(Me.lblPaymentType)
        Me.gboBankDetails.Controls.Add(Me.txtCardholderName)
        Me.gboBankDetails.Controls.Add(Me.lblCardholdersName)
        Me.gboBankDetails.Controls.Add(Me.picLaser)
        Me.gboBankDetails.Controls.Add(Me.picAmex)
        Me.gboBankDetails.Controls.Add(Me.picMasterCard)
        Me.gboBankDetails.Controls.Add(Me.picVisaa)
        Me.gboBankDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBankDetails.Location = New System.Drawing.Point(16, 322)
        Me.gboBankDetails.Name = "gboBankDetails"
        Me.gboBankDetails.Size = New System.Drawing.Size(421, 221)
        Me.gboBankDetails.TabIndex = 3
        Me.gboBankDetails.TabStop = False
        Me.gboBankDetails.Text = "BankDetails"
        '
        'btnInvoice
        '
        Me.btnInvoice.BackColor = System.Drawing.Color.White
        Me.btnInvoice.Location = New System.Drawing.Point(357, 192)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(59, 23)
        Me.btnInvoice.TabIndex = 16
        Me.btnInvoice.Text = "&Invoice"
        Me.btnInvoice.UseVisualStyleBackColor = False
        '
        'mskInsuranceDate
        '
        Me.mskInsuranceDate.Location = New System.Drawing.Point(219, 184)
        Me.mskInsuranceDate.Mask = "00/00/0000"
        Me.mskInsuranceDate.Name = "mskInsuranceDate"
        Me.mskInsuranceDate.Size = New System.Drawing.Size(100, 23)
        Me.mskInsuranceDate.TabIndex = 15
        Me.mskInsuranceDate.ValidatingType = GetType(Date)
        '
        'lblInsuranceStartDate
        '
        Me.lblInsuranceStartDate.AutoSize = True
        Me.lblInsuranceStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsuranceStartDate.Location = New System.Drawing.Point(32, 187)
        Me.lblInsuranceStartDate.Name = "lblInsuranceStartDate"
        Me.lblInsuranceStartDate.Size = New System.Drawing.Size(125, 15)
        Me.lblInsuranceStartDate.TabIndex = 14
        Me.lblInsuranceStartDate.Text = "Inital Insurance Date:"
        '
        'mskCVV
        '
        Me.mskCVV.Location = New System.Drawing.Point(219, 156)
        Me.mskCVV.Mask = "000"
        Me.mskCVV.Name = "mskCVV"
        Me.mskCVV.Size = New System.Drawing.Size(25, 23)
        Me.mskCVV.TabIndex = 13
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.Location = New System.Drawing.Point(124, 159)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(33, 15)
        Me.lblCVV.TabIndex = 12
        Me.lblCVV.Text = "CVV:"
        '
        'mskCardNumber
        '
        Me.mskCardNumber.Location = New System.Drawing.Point(219, 127)
        Me.mskCardNumber.Mask = "00000000"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(60, 23)
        Me.mskCardNumber.TabIndex = 11
        '
        'lblCardNumberr
        '
        Me.lblCardNumberr.AutoSize = True
        Me.lblCardNumberr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumberr.Location = New System.Drawing.Point(3, 130)
        Me.lblCardNumberr.Name = "lblCardNumberr"
        Me.lblCardNumberr.Size = New System.Drawing.Size(154, 15)
        Me.lblCardNumberr.TabIndex = 10
        Me.lblCardNumberr.Text = "Credit/DebitCard Number:"
        '
        'cboPaymentType
        '
        Me.cboPaymentType.FormattingEnabled = True
        Me.cboPaymentType.Items.AddRange(New Object() {"Visa", "Mastercard", "Laser", "AmEx"})
        Me.cboPaymentType.Location = New System.Drawing.Point(219, 95)
        Me.cboPaymentType.Name = "cboPaymentType"
        Me.cboPaymentType.Size = New System.Drawing.Size(121, 23)
        Me.cboPaymentType.TabIndex = 9
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.Location = New System.Drawing.Point(69, 98)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(88, 15)
        Me.lblPaymentType.TabIndex = 8
        Me.lblPaymentType.Text = "Payment Type:"
        '
        'txtCardholderName
        '
        Me.txtCardholderName.Location = New System.Drawing.Point(219, 66)
        Me.txtCardholderName.MaxLength = 35
        Me.txtCardholderName.Name = "txtCardholderName"
        Me.txtCardholderName.Size = New System.Drawing.Size(100, 23)
        Me.txtCardholderName.TabIndex = 7
        '
        'lblCardholdersName
        '
        Me.lblCardholdersName.AutoSize = True
        Me.lblCardholdersName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardholdersName.Location = New System.Drawing.Point(45, 69)
        Me.lblCardholdersName.Name = "lblCardholdersName"
        Me.lblCardholdersName.Size = New System.Drawing.Size(112, 15)
        Me.lblCardholdersName.TabIndex = 4
        Me.lblCardholdersName.Text = "Cardholders Name:"
        '
        'picLaser
        '
        Me.picLaser.Image = Global.MyBestFriend.My.Resources.Resources.laser
        Me.picLaser.Location = New System.Drawing.Point(199, 22)
        Me.picLaser.Name = "picLaser"
        Me.picLaser.Size = New System.Drawing.Size(80, 30)
        Me.picLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaser.TabIndex = 3
        Me.picLaser.TabStop = False
        '
        'picAmex
        '
        Me.picAmex.Image = Global.MyBestFriend.My.Resources.Resources.amex
        Me.picAmex.Location = New System.Drawing.Point(302, 22)
        Me.picAmex.Name = "picAmex"
        Me.picAmex.Size = New System.Drawing.Size(80, 30)
        Me.picAmex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAmex.TabIndex = 2
        Me.picAmex.TabStop = False
        '
        'picMasterCard
        '
        Me.picMasterCard.Image = Global.MyBestFriend.My.Resources.Resources.Mastercard
        Me.picMasterCard.Location = New System.Drawing.Point(101, 22)
        Me.picMasterCard.Name = "picMasterCard"
        Me.picMasterCard.Size = New System.Drawing.Size(80, 30)
        Me.picMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMasterCard.TabIndex = 1
        Me.picMasterCard.TabStop = False
        '
        'picVisaa
        '
        Me.picVisaa.Image = Global.MyBestFriend.My.Resources.Resources.Visa
        Me.picVisaa.Location = New System.Drawing.Point(6, 22)
        Me.picVisaa.Name = "picVisaa"
        Me.picVisaa.Size = New System.Drawing.Size(80, 30)
        Me.picVisaa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisaa.TabIndex = 0
        Me.picVisaa.TabStop = False
        '
        'lstInvoice
        '
        Me.lstInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 15
        Me.lstInvoice.Location = New System.Drawing.Point(452, 193)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(336, 304)
        Me.lstInvoice.TabIndex = 4
        '
        'btnFinish
        '
        Me.btnFinish.BackColor = System.Drawing.Color.White
        Me.btnFinish.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(673, 509)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(115, 34)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "&Finish"
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'frmUserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(800, 555)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboBankDetails)
        Me.Controls.Add(Me.gboCustomerDetails)
        Me.Controls.Add(Me.lblStep7)
        Me.Name = "frmUserDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Details "
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboCustomerDetails.ResumeLayout(False)
        Me.gboCustomerDetails.PerformLayout()
        Me.gboBankDetails.ResumeLayout(False)
        Me.gboBankDetails.PerformLayout()
        CType(Me.picLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAmex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMasterCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisaa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblStep7 As Label
    Friend WithEvents gboCustomerDetails As GroupBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents mskAge As MaskedTextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblCounty As Label
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents lblTown As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents mskTelephone As MaskedTextBox
    Friend WithEvents lblTelephoneNumber As Label
    Friend WithEvents gboBankDetails As GroupBox
    Friend WithEvents btnProceedd As Button
    Friend WithEvents picVisaa As PictureBox
    Friend WithEvents picLaser As PictureBox
    Friend WithEvents picAmex As PictureBox
    Friend WithEvents picMasterCard As PictureBox
    Friend WithEvents txtCardholderName As TextBox
    Friend WithEvents lblCardholdersName As Label
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents lblCardNumberr As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents lblInsuranceStartDate As Label
    Friend WithEvents mskCVV As MaskedTextBox
    Friend WithEvents btnInvoice As Button
    Friend WithEvents mskInsuranceDate As MaskedTextBox
    Friend WithEvents lstInvoice As ListBox
    Friend WithEvents btnFinish As Button
End Class
