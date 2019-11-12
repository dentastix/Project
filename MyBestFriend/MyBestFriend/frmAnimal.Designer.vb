<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnimal
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
        Me.lblAnimal = New System.Windows.Forms.Label()
        Me.gboAnimal = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picInsurance = New System.Windows.Forms.PictureBox()
        Me.radDog = New System.Windows.Forms.RadioButton()
        Me.radCat = New System.Windows.Forms.RadioButton()
        Me.gboInsurance = New System.Windows.Forms.GroupBox()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.radPlus = New System.Windows.Forms.RadioButton()
        Me.radPremier = New System.Windows.Forms.RadioButton()
        Me.radEssential = New System.Windows.Forms.RadioButton()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.gboBreedDog = New System.Windows.Forms.GroupBox()
        Me.cboMixedDog = New System.Windows.Forms.ComboBox()
        Me.cboCrossbreedDog = New System.Windows.Forms.ComboBox()
        Me.cboPedigreeDog = New System.Windows.Forms.ComboBox()
        Me.radMixedDog = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedDog = New System.Windows.Forms.RadioButton()
        Me.radPedigreeDog = New System.Windows.Forms.RadioButton()
        Me.gboBreedCat = New System.Windows.Forms.GroupBox()
        Me.radPedigreeCat = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedCat = New System.Windows.Forms.RadioButton()
        Me.radMixedCat = New System.Windows.Forms.RadioButton()
        Me.cboPedigreeCat = New System.Windows.Forms.ComboBox()
        Me.cboCrossbreedCat = New System.Windows.Forms.ComboBox()
        Me.cboMixedCat = New System.Windows.Forms.ComboBox()
        Me.gboAnimal.SuspendLayout()
        CType(Me.picInsurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboInsurance.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboBreedDog.SuspendLayout()
        Me.gboBreedCat.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimal.Location = New System.Drawing.Point(6, 16)
        Me.lblAnimal.Name = "lblAnimal"
        Me.lblAnimal.Size = New System.Drawing.Size(228, 17)
        Me.lblAnimal.TabIndex = 0
        Me.lblAnimal.Text = "Step 1: Select your animal of choice"
        '
        'gboAnimal
        '
        Me.gboAnimal.BackColor = System.Drawing.Color.Transparent
        Me.gboAnimal.Controls.Add(Me.btnNext)
        Me.gboAnimal.Controls.Add(Me.picInsurance)
        Me.gboAnimal.Controls.Add(Me.radDog)
        Me.gboAnimal.Controls.Add(Me.radCat)
        Me.gboAnimal.Controls.Add(Me.lblAnimal)
        Me.gboAnimal.Location = New System.Drawing.Point(12, 12)
        Me.gboAnimal.Name = "gboAnimal"
        Me.gboAnimal.Size = New System.Drawing.Size(601, 156)
        Me.gboAnimal.TabIndex = 1
        Me.gboAnimal.TabStop = False
        Me.gboAnimal.Text = "Pet Selection"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(13, 127)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picInsurance
        '
        Me.picInsurance.Image = Global.MyBestFriend.My.Resources.Resources.p
        Me.picInsurance.Location = New System.Drawing.Point(144, 36)
        Me.picInsurance.Name = "picInsurance"
        Me.picInsurance.Size = New System.Drawing.Size(439, 114)
        Me.picInsurance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInsurance.TabIndex = 3
        Me.picInsurance.TabStop = False
        '
        'radDog
        '
        Me.radDog.AutoSize = True
        Me.radDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDog.Location = New System.Drawing.Point(13, 91)
        Me.radDog.Name = "radDog"
        Me.radDog.Size = New System.Drawing.Size(47, 19)
        Me.radDog.TabIndex = 2
        Me.radDog.TabStop = True
        Me.radDog.Text = "Dog"
        Me.radDog.UseVisualStyleBackColor = True
        '
        'radCat
        '
        Me.radCat.AutoSize = True
        Me.radCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCat.Location = New System.Drawing.Point(13, 52)
        Me.radCat.Name = "radCat"
        Me.radCat.Size = New System.Drawing.Size(43, 19)
        Me.radCat.TabIndex = 1
        Me.radCat.TabStop = True
        Me.radCat.Text = "Cat"
        Me.radCat.UseVisualStyleBackColor = True
        '
        'gboInsurance
        '
        Me.gboInsurance.BackColor = System.Drawing.Color.Transparent
        Me.gboInsurance.Controls.Add(Me.lblInsurance)
        Me.gboInsurance.Controls.Add(Me.radPlus)
        Me.gboInsurance.Controls.Add(Me.radPremier)
        Me.gboInsurance.Controls.Add(Me.radEssential)
        Me.gboInsurance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboInsurance.Location = New System.Drawing.Point(12, 190)
        Me.gboInsurance.Name = "gboInsurance"
        Me.gboInsurance.Size = New System.Drawing.Size(289, 167)
        Me.gboInsurance.TabIndex = 2
        Me.gboInsurance.TabStop = False
        Me.gboInsurance.Text = "Insurance Type"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(9, 32)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(262, 17)
        Me.lblInsurance.TabIndex = 3
        Me.lblInsurance.Text = "Step 2: Choose your insurance cover type"
        '
        'radPlus
        '
        Me.radPlus.AutoSize = True
        Me.radPlus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlus.Location = New System.Drawing.Point(9, 135)
        Me.radPlus.Name = "radPlus"
        Me.radPlus.Size = New System.Drawing.Size(244, 19)
        Me.radPlus.TabIndex = 2
        Me.radPlus.TabStop = True
        Me.radPlus.Text = "Premier Plus Cover (Accident and Illness):"
        Me.radPlus.UseVisualStyleBackColor = True
        '
        'radPremier
        '
        Me.radPremier.AutoSize = True
        Me.radPremier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPremier.Location = New System.Drawing.Point(9, 98)
        Me.radPremier.Name = "radPremier"
        Me.radPremier.Size = New System.Drawing.Size(219, 19)
        Me.radPremier.TabIndex = 1
        Me.radPremier.TabStop = True
        Me.radPremier.Text = "Premier Cover (Accident and Illness):"
        Me.radPremier.UseVisualStyleBackColor = True
        '
        'radEssential
        '
        Me.radEssential.AutoSize = True
        Me.radEssential.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEssential.Location = New System.Drawing.Point(9, 62)
        Me.radEssential.Name = "radEssential"
        Me.radEssential.Size = New System.Drawing.Size(193, 19)
        Me.radEssential.TabIndex = 0
        Me.radEssential.TabStop = True
        Me.radEssential.Text = "Essential Cover (Accident Only):"
        Me.radEssential.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.MyBestFriend.My.Resources.Resources.nuhy
        Me.picLogo.Location = New System.Drawing.Point(619, -15)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(190, 201)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(375, 203)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(397, 162)
        Me.txtDescription.TabIndex = 4
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(697, 371)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(375, 184)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(49, 15)
        Me.lblPrompt.TabIndex = 6
        Me.lblPrompt.Text = "Prompt"
        '
        'gboBreedDog
        '
        Me.gboBreedDog.BackColor = System.Drawing.Color.Transparent
        Me.gboBreedDog.Controls.Add(Me.cboMixedDog)
        Me.gboBreedDog.Controls.Add(Me.cboCrossbreedDog)
        Me.gboBreedDog.Controls.Add(Me.cboPedigreeDog)
        Me.gboBreedDog.Controls.Add(Me.radMixedDog)
        Me.gboBreedDog.Controls.Add(Me.radCrossbreedDog)
        Me.gboBreedDog.Controls.Add(Me.radPedigreeDog)
        Me.gboBreedDog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBreedDog.Location = New System.Drawing.Point(12, 400)
        Me.gboBreedDog.Name = "gboBreedDog"
        Me.gboBreedDog.Size = New System.Drawing.Size(760, 108)
        Me.gboBreedDog.TabIndex = 7
        Me.gboBreedDog.TabStop = False
        Me.gboBreedDog.Text = "Step 3: Select your breed of Dog"
        '
        'cboMixedDog
        '
        Me.cboMixedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMixedDog.FormattingEnabled = True
        Me.cboMixedDog.Items.AddRange(New Object() {"Small Mongrel (Up to 10kgs)", "Medium Mongrel (10kgs - 20kgs)", "Large Mongrel (Greater than 20kgs)"})
        Me.cboMixedDog.Location = New System.Drawing.Point(178, 77)
        Me.cboMixedDog.Name = "cboMixedDog"
        Me.cboMixedDog.Size = New System.Drawing.Size(158, 23)
        Me.cboMixedDog.TabIndex = 5
        Me.cboMixedDog.Visible = False
        '
        'cboCrossbreedDog
        '
        Me.cboCrossbreedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCrossbreedDog.FormattingEnabled = True
        Me.cboCrossbreedDog.Items.AddRange(New Object() {"Small Crossbreed (Up to 10kgs)", "Medium Crossbreed (10kgs - 20kgs)", "Large Crossbreed (Greater than 20kgs)"})
        Me.cboCrossbreedDog.Location = New System.Drawing.Point(178, 50)
        Me.cboCrossbreedDog.Name = "cboCrossbreedDog"
        Me.cboCrossbreedDog.Size = New System.Drawing.Size(158, 23)
        Me.cboCrossbreedDog.TabIndex = 4
        Me.cboCrossbreedDog.Visible = False
        '
        'cboPedigreeDog
        '
        Me.cboPedigreeDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedigreeDog.FormattingEnabled = True
        Me.cboPedigreeDog.Items.AddRange(New Object() {"African Hairless", "Boxer", "Chihuahua", "Dalmatian", "Eskimo Dog", "Farm Collie", "Grey Hound", "Husky", "Irish Setter", "Jack Russell Terrier", "King Charles Spaniel", "Labrador Retriever", "Maltese", "Pug", "Rottweiler", "St Bernard", "Tibetan Mastiff", "Working Sheep Dog", "Yorkshire Terrier", "Other"})
        Me.cboPedigreeDog.Location = New System.Drawing.Point(178, 22)
        Me.cboPedigreeDog.Name = "cboPedigreeDog"
        Me.cboPedigreeDog.Size = New System.Drawing.Size(158, 23)
        Me.cboPedigreeDog.TabIndex = 3
        Me.cboPedigreeDog.Visible = False
        '
        'radMixedDog
        '
        Me.radMixedDog.AutoSize = True
        Me.radMixedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMixedDog.Location = New System.Drawing.Point(9, 80)
        Me.radMixedDog.Name = "radMixedDog"
        Me.radMixedDog.Size = New System.Drawing.Size(115, 19)
        Me.radMixedDog.TabIndex = 2
        Me.radMixedDog.TabStop = True
        Me.radMixedDog.Text = "Mixed Breed Dog"
        Me.radMixedDog.UseVisualStyleBackColor = True
        '
        'radCrossbreedDog
        '
        Me.radCrossbreedDog.AutoSize = True
        Me.radCrossbreedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrossbreedDog.Location = New System.Drawing.Point(9, 53)
        Me.radCrossbreedDog.Name = "radCrossbreedDog"
        Me.radCrossbreedDog.Size = New System.Drawing.Size(109, 19)
        Me.radCrossbreedDog.TabIndex = 1
        Me.radCrossbreedDog.TabStop = True
        Me.radCrossbreedDog.Text = "Crossbreed Dog"
        Me.radCrossbreedDog.UseVisualStyleBackColor = True
        '
        'radPedigreeDog
        '
        Me.radPedigreeDog.AutoSize = True
        Me.radPedigreeDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPedigreeDog.Location = New System.Drawing.Point(9, 25)
        Me.radPedigreeDog.Name = "radPedigreeDog"
        Me.radPedigreeDog.Size = New System.Drawing.Size(96, 19)
        Me.radPedigreeDog.TabIndex = 0
        Me.radPedigreeDog.TabStop = True
        Me.radPedigreeDog.Text = "Pedigree Dog"
        Me.radPedigreeDog.UseVisualStyleBackColor = True
        '
        'gboBreedCat
        '
        Me.gboBreedCat.BackColor = System.Drawing.Color.Transparent
        Me.gboBreedCat.Controls.Add(Me.cboMixedCat)
        Me.gboBreedCat.Controls.Add(Me.cboCrossbreedCat)
        Me.gboBreedCat.Controls.Add(Me.cboPedigreeCat)
        Me.gboBreedCat.Controls.Add(Me.radMixedCat)
        Me.gboBreedCat.Controls.Add(Me.radCrossbreedCat)
        Me.gboBreedCat.Controls.Add(Me.radPedigreeCat)
        Me.gboBreedCat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBreedCat.Location = New System.Drawing.Point(12, 527)
        Me.gboBreedCat.Name = "gboBreedCat"
        Me.gboBreedCat.Size = New System.Drawing.Size(760, 108)
        Me.gboBreedCat.TabIndex = 8
        Me.gboBreedCat.TabStop = False
        Me.gboBreedCat.Text = "Step 3: Select your breed of Cat"
        '
        'radPedigreeCat
        '
        Me.radPedigreeCat.AutoSize = True
        Me.radPedigreeCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPedigreeCat.Location = New System.Drawing.Point(9, 25)
        Me.radPedigreeCat.Name = "radPedigreeCat"
        Me.radPedigreeCat.Size = New System.Drawing.Size(92, 19)
        Me.radPedigreeCat.TabIndex = 0
        Me.radPedigreeCat.TabStop = True
        Me.radPedigreeCat.Text = "Pedigree Cat"
        Me.radPedigreeCat.UseVisualStyleBackColor = True
        '
        'radCrossbreedCat
        '
        Me.radCrossbreedCat.AutoSize = True
        Me.radCrossbreedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrossbreedCat.Location = New System.Drawing.Point(9, 53)
        Me.radCrossbreedCat.Name = "radCrossbreedCat"
        Me.radCrossbreedCat.Size = New System.Drawing.Size(105, 19)
        Me.radCrossbreedCat.TabIndex = 1
        Me.radCrossbreedCat.TabStop = True
        Me.radCrossbreedCat.Text = "Crossbreed Cat"
        Me.radCrossbreedCat.UseVisualStyleBackColor = True
        '
        'radMixedCat
        '
        Me.radMixedCat.AutoSize = True
        Me.radMixedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMixedCat.Location = New System.Drawing.Point(9, 81)
        Me.radMixedCat.Name = "radMixedCat"
        Me.radMixedCat.Size = New System.Drawing.Size(111, 19)
        Me.radMixedCat.TabIndex = 2
        Me.radMixedCat.TabStop = True
        Me.radMixedCat.Text = "Mixed Breed Cat"
        Me.radMixedCat.UseVisualStyleBackColor = True
        '
        'cboPedigreeCat
        '
        Me.cboPedigreeCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedigreeCat.FormattingEnabled = True
        Me.cboPedigreeCat.Items.AddRange(New Object() {"Angora", "Burmese", "Cymric", "Devon Rex", "Egyptian Mau", "Forest Cat", "Havana", "Japanese Bobtail", "Korat", "Manx", "Nebelung", "Oriental", "Persian", "Ragdoll", "Siamese", "Tiffany", "Other"})
        Me.cboPedigreeCat.Location = New System.Drawing.Point(178, 22)
        Me.cboPedigreeCat.Name = "cboPedigreeCat"
        Me.cboPedigreeCat.Size = New System.Drawing.Size(158, 23)
        Me.cboPedigreeCat.TabIndex = 3
        Me.cboPedigreeCat.Visible = False
        '
        'cboCrossbreedCat
        '
        Me.cboCrossbreedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCrossbreedCat.FormattingEnabled = True
        Me.cboCrossbreedCat.Items.AddRange(New Object() {"American Curl", "Blue Tabby", "Cornish Rex", "Exotic Shorthair", "Maine Coon", "Scottish Folds", "Snow Leopard Bengal", "Cat", "Turkish Van Cat", "Other"})
        Me.cboCrossbreedCat.Location = New System.Drawing.Point(178, 50)
        Me.cboCrossbreedCat.Name = "cboCrossbreedCat"
        Me.cboCrossbreedCat.Size = New System.Drawing.Size(158, 23)
        Me.cboCrossbreedCat.TabIndex = 4
        Me.cboCrossbreedCat.Visible = False
        '
        'cboMixedCat
        '
        Me.cboMixedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMixedCat.FormattingEnabled = True
        Me.cboMixedCat.Items.AddRange(New Object() {"Moggie", "Domestic Longhair", "Domestic Shorthair", "Foreign Shorthairs", "Other"})
        Me.cboMixedCat.Location = New System.Drawing.Point(178, 78)
        Me.cboMixedCat.Name = "cboMixedCat"
        Me.cboMixedCat.Size = New System.Drawing.Size(158, 23)
        Me.cboMixedCat.TabIndex = 5
        Me.cboMixedCat.Visible = False
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(800, 686)
        Me.Controls.Add(Me.gboBreedCat)
        Me.Controls.Add(Me.gboBreedDog)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboInsurance)
        Me.Controls.Add(Me.gboAnimal)
        Me.Name = "frmAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animal Details"
        Me.gboAnimal.ResumeLayout(False)
        Me.gboAnimal.PerformLayout()
        CType(Me.picInsurance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboInsurance.ResumeLayout(False)
        Me.gboInsurance.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboBreedDog.ResumeLayout(False)
        Me.gboBreedDog.PerformLayout()
        Me.gboBreedCat.ResumeLayout(False)
        Me.gboBreedCat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAnimal As Label
    Friend WithEvents gboAnimal As GroupBox
    Friend WithEvents radDog As RadioButton
    Friend WithEvents radCat As RadioButton
    Friend WithEvents gboInsurance As GroupBox
    Friend WithEvents picInsurance As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblInsurance As Label
    Friend WithEvents radPlus As RadioButton
    Friend WithEvents radPremier As RadioButton
    Friend WithEvents radEssential As RadioButton
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents gboBreedDog As GroupBox
    Friend WithEvents cboMixedDog As ComboBox
    Friend WithEvents cboCrossbreedDog As ComboBox
    Friend WithEvents cboPedigreeDog As ComboBox
    Friend WithEvents radMixedDog As RadioButton
    Friend WithEvents radCrossbreedDog As RadioButton
    Friend WithEvents radPedigreeDog As RadioButton
    Friend WithEvents gboBreedCat As GroupBox
    Friend WithEvents radMixedCat As RadioButton
    Friend WithEvents radCrossbreedCat As RadioButton
    Friend WithEvents radPedigreeCat As RadioButton
    Friend WithEvents cboPedigreeCat As ComboBox
    Friend WithEvents cboMixedCat As ComboBox
    Friend WithEvents cboCrossbreedCat As ComboBox
End Class
