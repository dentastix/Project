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
        Me.btnContinueDog = New System.Windows.Forms.Button()
        Me.lblOtherDog = New System.Windows.Forms.Label()
        Me.txtOtherDog = New System.Windows.Forms.TextBox()
        Me.cboMixedDog = New System.Windows.Forms.ComboBox()
        Me.cboCrossbreedDog = New System.Windows.Forms.ComboBox()
        Me.cboPedigreeDog = New System.Windows.Forms.ComboBox()
        Me.radMixedDog = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedDog = New System.Windows.Forms.RadioButton()
        Me.radPedigreeDog = New System.Windows.Forms.RadioButton()
        Me.gboBreedCat = New System.Windows.Forms.GroupBox()
        Me.btnContinueCat = New System.Windows.Forms.Button()
        Me.lblOtherCat = New System.Windows.Forms.Label()
        Me.txtOtherCat = New System.Windows.Forms.TextBox()
        Me.cboMixedCat = New System.Windows.Forms.ComboBox()
        Me.cboCrossbreedCat = New System.Windows.Forms.ComboBox()
        Me.cboPedigreeCat = New System.Windows.Forms.ComboBox()
        Me.radMixedCat = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedCat = New System.Windows.Forms.RadioButton()
        Me.radPedigreeCat = New System.Windows.Forms.RadioButton()
        Me.gboOptionsCat = New System.Windows.Forms.GroupBox()
        Me.radMediumCatHouse = New System.Windows.Forms.RadioButton()
        Me.radSmallCatHouse = New System.Windows.Forms.RadioButton()
        Me.radMediumCatGrooming = New System.Windows.Forms.RadioButton()
        Me.radSmallCatGrooming = New System.Windows.Forms.RadioButton()
        Me.radHouseCat = New System.Windows.Forms.RadioButton()
        Me.radGroomingCat = New System.Windows.Forms.RadioButton()
        Me.gboOptionsDog = New System.Windows.Forms.GroupBox()
        Me.radLargeDogHouse = New System.Windows.Forms.RadioButton()
        Me.radMediumDogHouse = New System.Windows.Forms.RadioButton()
        Me.radSmallDogHouse = New System.Windows.Forms.RadioButton()
        Me.radLargeDogLong = New System.Windows.Forms.RadioButton()
        Me.radMediumDogLong = New System.Windows.Forms.RadioButton()
        Me.radSmallDogLong = New System.Windows.Forms.RadioButton()
        Me.radLargeDogShort = New System.Windows.Forms.RadioButton()
        Me.radMediumDogShort = New System.Windows.Forms.RadioButton()
        Me.radSmallDogShort = New System.Windows.Forms.RadioButton()
        Me.cboGroomingDog = New System.Windows.Forms.ComboBox()
        Me.radHouseDog = New System.Windows.Forms.RadioButton()
        Me.radGroomingDog = New System.Windows.Forms.RadioButton()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.gboAnimal.SuspendLayout()
        CType(Me.picInsurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboInsurance.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboBreedDog.SuspendLayout()
        Me.gboBreedCat.SuspendLayout()
        Me.gboOptionsCat.SuspendLayout()
        Me.gboOptionsDog.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimal.Location = New System.Drawing.Point(8, 20)
        Me.lblAnimal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnimal.Name = "lblAnimal"
        Me.lblAnimal.Size = New System.Drawing.Size(297, 23)
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
        Me.gboAnimal.Location = New System.Drawing.Point(16, 15)
        Me.gboAnimal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboAnimal.Name = "gboAnimal"
        Me.gboAnimal.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboAnimal.Size = New System.Drawing.Size(801, 192)
        Me.gboAnimal.TabIndex = 1
        Me.gboAnimal.TabStop = False
        Me.gboAnimal.Text = "Pet Selection"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(17, 156)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 28)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picInsurance
        '
        Me.picInsurance.Image = Global.MyBestFriend.My.Resources.Resources.p
        Me.picInsurance.Location = New System.Drawing.Point(192, 44)
        Me.picInsurance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picInsurance.Name = "picInsurance"
        Me.picInsurance.Size = New System.Drawing.Size(585, 140)
        Me.picInsurance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInsurance.TabIndex = 3
        Me.picInsurance.TabStop = False
        '
        'radDog
        '
        Me.radDog.AutoSize = True
        Me.radDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDog.Location = New System.Drawing.Point(17, 112)
        Me.radDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radDog.Name = "radDog"
        Me.radDog.Size = New System.Drawing.Size(59, 24)
        Me.radDog.TabIndex = 2
        Me.radDog.TabStop = True
        Me.radDog.Text = "&Dog"
        Me.radDog.UseVisualStyleBackColor = True
        '
        'radCat
        '
        Me.radCat.AutoSize = True
        Me.radCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCat.Location = New System.Drawing.Point(17, 64)
        Me.radCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radCat.Name = "radCat"
        Me.radCat.Size = New System.Drawing.Size(52, 24)
        Me.radCat.TabIndex = 1
        Me.radCat.TabStop = True
        Me.radCat.Text = "&Cat"
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
        Me.gboInsurance.Location = New System.Drawing.Point(16, 234)
        Me.gboInsurance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboInsurance.Name = "gboInsurance"
        Me.gboInsurance.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboInsurance.Size = New System.Drawing.Size(385, 160)
        Me.gboInsurance.TabIndex = 2
        Me.gboInsurance.TabStop = False
        Me.gboInsurance.Text = "Insurance Type"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(8, 23)
        Me.lblInsurance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(339, 23)
        Me.lblInsurance.TabIndex = 3
        Me.lblInsurance.Text = "Step 2: Choose your insurance cover type"
        '
        'radPlus
        '
        Me.radPlus.AutoSize = True
        Me.radPlus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPlus.Location = New System.Drawing.Point(12, 122)
        Me.radPlus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPlus.Name = "radPlus"
        Me.radPlus.Size = New System.Drawing.Size(301, 24)
        Me.radPlus.TabIndex = 2
        Me.radPlus.TabStop = True
        Me.radPlus.Text = "P&remier Plus Cover (Accident and Illness):"
        Me.radPlus.UseVisualStyleBackColor = True
        '
        'radPremier
        '
        Me.radPremier.AutoSize = True
        Me.radPremier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPremier.Location = New System.Drawing.Point(12, 91)
        Me.radPremier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPremier.Name = "radPremier"
        Me.radPremier.Size = New System.Drawing.Size(271, 24)
        Me.radPremier.TabIndex = 1
        Me.radPremier.TabStop = True
        Me.radPremier.Text = "&Premier Cover (Accident and Illness):"
        Me.radPremier.UseVisualStyleBackColor = True
        '
        'radEssential
        '
        Me.radEssential.AutoSize = True
        Me.radEssential.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEssential.Location = New System.Drawing.Point(12, 60)
        Me.radEssential.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radEssential.Name = "radEssential"
        Me.radEssential.Size = New System.Drawing.Size(238, 24)
        Me.radEssential.TabIndex = 0
        Me.radEssential.TabStop = True
        Me.radEssential.Text = "&Essential Cover (Accident Only):"
        Me.radEssential.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.MyBestFriend.My.Resources.Resources.nuhy
        Me.picLogo.Location = New System.Drawing.Point(825, -18)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(253, 247)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 3
        Me.picLogo.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(500, 250)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(528, 173)
        Me.txtDescription.TabIndex = 4
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(301, 395)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 28)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "C&ontinue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(500, 226)
        Me.lblPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(62, 20)
        Me.lblPrompt.TabIndex = 6
        Me.lblPrompt.Text = "Prompt"
        '
        'gboBreedDog
        '
        Me.gboBreedDog.BackColor = System.Drawing.Color.Transparent
        Me.gboBreedDog.Controls.Add(Me.btnContinueDog)
        Me.gboBreedDog.Controls.Add(Me.lblOtherDog)
        Me.gboBreedDog.Controls.Add(Me.txtOtherDog)
        Me.gboBreedDog.Controls.Add(Me.cboMixedDog)
        Me.gboBreedDog.Controls.Add(Me.cboCrossbreedDog)
        Me.gboBreedDog.Controls.Add(Me.cboPedigreeDog)
        Me.gboBreedDog.Controls.Add(Me.radMixedDog)
        Me.gboBreedDog.Controls.Add(Me.radCrossbreedDog)
        Me.gboBreedDog.Controls.Add(Me.radPedigreeDog)
        Me.gboBreedDog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBreedDog.Location = New System.Drawing.Point(16, 431)
        Me.gboBreedDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboBreedDog.Name = "gboBreedDog"
        Me.gboBreedDog.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboBreedDog.Size = New System.Drawing.Size(1013, 133)
        Me.gboBreedDog.TabIndex = 7
        Me.gboBreedDog.TabStop = False
        Me.gboBreedDog.Text = "Step 3: Select your breed of Dog"
        '
        'btnContinueDog
        '
        Me.btnContinueDog.BackColor = System.Drawing.Color.White
        Me.btnContinueDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueDog.Location = New System.Drawing.Point(809, 65)
        Me.btnContinueDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnContinueDog.Name = "btnContinueDog"
        Me.btnContinueDog.Size = New System.Drawing.Size(100, 28)
        Me.btnContinueDog.TabIndex = 9
        Me.btnContinueDog.Text = "Co&ntinue"
        Me.btnContinueDog.UseVisualStyleBackColor = False
        Me.btnContinueDog.Visible = False
        '
        'lblOtherDog
        '
        Me.lblOtherDog.AutoSize = True
        Me.lblOtherDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherDog.Location = New System.Drawing.Point(484, 23)
        Me.lblOtherDog.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtherDog.Name = "lblOtherDog"
        Me.lblOtherDog.Size = New System.Drawing.Size(54, 20)
        Me.lblOtherDog.TabIndex = 7
        Me.lblOtherDog.Text = "Other:"
        Me.lblOtherDog.Visible = False
        '
        'txtOtherDog
        '
        Me.txtOtherDog.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDog.Location = New System.Drawing.Point(484, 43)
        Me.txtOtherDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOtherDog.Multiline = True
        Me.txtOtherDog.Name = "txtOtherDog"
        Me.txtOtherDog.Size = New System.Drawing.Size(225, 78)
        Me.txtOtherDog.TabIndex = 6
        Me.txtOtherDog.Text = "Type of Breed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Breed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Weight:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtOtherDog.Visible = False
        '
        'cboMixedDog
        '
        Me.cboMixedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMixedDog.FormattingEnabled = True
        Me.cboMixedDog.Items.AddRange(New Object() {"Small Mongrel (Up to 10kgs)", "Medium Mongrel (10kgs - 20kgs)", "Large Mongrel (Greater than 20kgs)"})
        Me.cboMixedDog.Location = New System.Drawing.Point(237, 95)
        Me.cboMixedDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMixedDog.Name = "cboMixedDog"
        Me.cboMixedDog.Size = New System.Drawing.Size(209, 28)
        Me.cboMixedDog.TabIndex = 5
        Me.cboMixedDog.Visible = False
        '
        'cboCrossbreedDog
        '
        Me.cboCrossbreedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCrossbreedDog.FormattingEnabled = True
        Me.cboCrossbreedDog.Items.AddRange(New Object() {"Small Crossbreed (Up to 10kgs)", "Medium Crossbreed (10kgs - 20kgs)", "Large Crossbreed (Greater than 20kgs)"})
        Me.cboCrossbreedDog.Location = New System.Drawing.Point(237, 62)
        Me.cboCrossbreedDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCrossbreedDog.Name = "cboCrossbreedDog"
        Me.cboCrossbreedDog.Size = New System.Drawing.Size(209, 28)
        Me.cboCrossbreedDog.TabIndex = 4
        Me.cboCrossbreedDog.Visible = False
        '
        'cboPedigreeDog
        '
        Me.cboPedigreeDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedigreeDog.FormattingEnabled = True
        Me.cboPedigreeDog.Items.AddRange(New Object() {"African Hairless", "Boxer", "Chihuahua", "Dalmatian", "Eskimo Dog", "Farm Collie", "Grey Hound", "Husky", "Irish Setter", "Jack Russell Terrier", "King Charles Spaniel", "Labrador Retriever", "Maltese", "Pug", "Rottweiler", "St Bernard", "Tibetan Mastiff", "Working Sheep Dog", "Yorkshire Terrier", "Other"})
        Me.cboPedigreeDog.Location = New System.Drawing.Point(237, 27)
        Me.cboPedigreeDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPedigreeDog.Name = "cboPedigreeDog"
        Me.cboPedigreeDog.Size = New System.Drawing.Size(209, 28)
        Me.cboPedigreeDog.TabIndex = 3
        Me.cboPedigreeDog.Visible = False
        '
        'radMixedDog
        '
        Me.radMixedDog.AutoSize = True
        Me.radMixedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMixedDog.Location = New System.Drawing.Point(12, 98)
        Me.radMixedDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMixedDog.Name = "radMixedDog"
        Me.radMixedDog.Size = New System.Drawing.Size(147, 24)
        Me.radMixedDog.TabIndex = 2
        Me.radMixedDog.TabStop = True
        Me.radMixedDog.Text = "Mixed Breed Dog"
        Me.radMixedDog.UseVisualStyleBackColor = True
        '
        'radCrossbreedDog
        '
        Me.radCrossbreedDog.AutoSize = True
        Me.radCrossbreedDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrossbreedDog.Location = New System.Drawing.Point(12, 65)
        Me.radCrossbreedDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radCrossbreedDog.Name = "radCrossbreedDog"
        Me.radCrossbreedDog.Size = New System.Drawing.Size(137, 24)
        Me.radCrossbreedDog.TabIndex = 1
        Me.radCrossbreedDog.TabStop = True
        Me.radCrossbreedDog.Text = "Crossbreed Dog"
        Me.radCrossbreedDog.UseVisualStyleBackColor = True
        '
        'radPedigreeDog
        '
        Me.radPedigreeDog.AutoSize = True
        Me.radPedigreeDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPedigreeDog.Location = New System.Drawing.Point(12, 31)
        Me.radPedigreeDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPedigreeDog.Name = "radPedigreeDog"
        Me.radPedigreeDog.Size = New System.Drawing.Size(121, 24)
        Me.radPedigreeDog.TabIndex = 0
        Me.radPedigreeDog.TabStop = True
        Me.radPedigreeDog.Text = "Pedigree Dog"
        Me.radPedigreeDog.UseVisualStyleBackColor = True
        '
        'gboBreedCat
        '
        Me.gboBreedCat.BackColor = System.Drawing.Color.White
        Me.gboBreedCat.Controls.Add(Me.btnContinueCat)
        Me.gboBreedCat.Controls.Add(Me.lblOtherCat)
        Me.gboBreedCat.Controls.Add(Me.txtOtherCat)
        Me.gboBreedCat.Controls.Add(Me.cboMixedCat)
        Me.gboBreedCat.Controls.Add(Me.cboCrossbreedCat)
        Me.gboBreedCat.Controls.Add(Me.cboPedigreeCat)
        Me.gboBreedCat.Controls.Add(Me.radMixedCat)
        Me.gboBreedCat.Controls.Add(Me.radCrossbreedCat)
        Me.gboBreedCat.Controls.Add(Me.radPedigreeCat)
        Me.gboBreedCat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboBreedCat.Location = New System.Drawing.Point(16, 431)
        Me.gboBreedCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboBreedCat.Name = "gboBreedCat"
        Me.gboBreedCat.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboBreedCat.Size = New System.Drawing.Size(1013, 133)
        Me.gboBreedCat.TabIndex = 8
        Me.gboBreedCat.TabStop = False
        Me.gboBreedCat.Text = "Step 3: Select your breed of Cat"
        '
        'btnContinueCat
        '
        Me.btnContinueCat.BackColor = System.Drawing.Color.White
        Me.btnContinueCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinueCat.Location = New System.Drawing.Point(809, 65)
        Me.btnContinueCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnContinueCat.Name = "btnContinueCat"
        Me.btnContinueCat.Size = New System.Drawing.Size(100, 28)
        Me.btnContinueCat.TabIndex = 9
        Me.btnContinueCat.Text = "Co&ntinue"
        Me.btnContinueCat.UseVisualStyleBackColor = False
        Me.btnContinueCat.Visible = False
        '
        'lblOtherCat
        '
        Me.lblOtherCat.AutoSize = True
        Me.lblOtherCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherCat.Location = New System.Drawing.Point(484, 25)
        Me.lblOtherCat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtherCat.Name = "lblOtherCat"
        Me.lblOtherCat.Size = New System.Drawing.Size(54, 20)
        Me.lblOtherCat.TabIndex = 7
        Me.lblOtherCat.Text = "Other:"
        Me.lblOtherCat.Visible = False
        '
        'txtOtherCat
        '
        Me.txtOtherCat.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherCat.Location = New System.Drawing.Point(484, 47)
        Me.txtOtherCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOtherCat.Multiline = True
        Me.txtOtherCat.Name = "txtOtherCat"
        Me.txtOtherCat.Size = New System.Drawing.Size(225, 78)
        Me.txtOtherCat.TabIndex = 6
        Me.txtOtherCat.Text = "Type of Breed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Breed:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Weight:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtOtherCat.Visible = False
        '
        'cboMixedCat
        '
        Me.cboMixedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMixedCat.FormattingEnabled = True
        Me.cboMixedCat.Items.AddRange(New Object() {"Moggie", "Domestic Longhair", "Domestic Shorthair", "Foreign Shorthairs", "Other"})
        Me.cboMixedCat.Location = New System.Drawing.Point(237, 96)
        Me.cboMixedCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMixedCat.Name = "cboMixedCat"
        Me.cboMixedCat.Size = New System.Drawing.Size(209, 28)
        Me.cboMixedCat.TabIndex = 5
        Me.cboMixedCat.Visible = False
        '
        'cboCrossbreedCat
        '
        Me.cboCrossbreedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCrossbreedCat.FormattingEnabled = True
        Me.cboCrossbreedCat.Items.AddRange(New Object() {"American Curl", "Blue Tabby", "Cornish Rex", "Exotic Shorthair", "Maine Coon", "Scottish Folds", "Snow Leopard Bengal", "Cat", "Turkish Van Cat", "Other"})
        Me.cboCrossbreedCat.Location = New System.Drawing.Point(237, 62)
        Me.cboCrossbreedCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCrossbreedCat.Name = "cboCrossbreedCat"
        Me.cboCrossbreedCat.Size = New System.Drawing.Size(209, 28)
        Me.cboCrossbreedCat.TabIndex = 4
        Me.cboCrossbreedCat.Visible = False
        '
        'cboPedigreeCat
        '
        Me.cboPedigreeCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedigreeCat.FormattingEnabled = True
        Me.cboPedigreeCat.Items.AddRange(New Object() {"Angora", "Burmese", "Cymric", "Devon Rex", "Egyptian Mau", "Forest Cat", "Havana", "Japanese Bobtail", "Korat", "Manx", "Nebelung", "Oriental", "Persian", "Ragdoll", "Siamese", "Tiffany", "Other"})
        Me.cboPedigreeCat.Location = New System.Drawing.Point(237, 27)
        Me.cboPedigreeCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPedigreeCat.Name = "cboPedigreeCat"
        Me.cboPedigreeCat.Size = New System.Drawing.Size(209, 28)
        Me.cboPedigreeCat.TabIndex = 3
        Me.cboPedigreeCat.Visible = False
        '
        'radMixedCat
        '
        Me.radMixedCat.AutoSize = True
        Me.radMixedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMixedCat.Location = New System.Drawing.Point(12, 100)
        Me.radMixedCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMixedCat.Name = "radMixedCat"
        Me.radMixedCat.Size = New System.Drawing.Size(140, 24)
        Me.radMixedCat.TabIndex = 2
        Me.radMixedCat.TabStop = True
        Me.radMixedCat.Text = "Mixed Breed Cat"
        Me.radMixedCat.UseVisualStyleBackColor = True
        '
        'radCrossbreedCat
        '
        Me.radCrossbreedCat.AutoSize = True
        Me.radCrossbreedCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCrossbreedCat.Location = New System.Drawing.Point(12, 65)
        Me.radCrossbreedCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radCrossbreedCat.Name = "radCrossbreedCat"
        Me.radCrossbreedCat.Size = New System.Drawing.Size(130, 24)
        Me.radCrossbreedCat.TabIndex = 1
        Me.radCrossbreedCat.TabStop = True
        Me.radCrossbreedCat.Text = "Crossbreed Cat"
        Me.radCrossbreedCat.UseVisualStyleBackColor = True
        '
        'radPedigreeCat
        '
        Me.radPedigreeCat.AutoSize = True
        Me.radPedigreeCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPedigreeCat.Location = New System.Drawing.Point(12, 31)
        Me.radPedigreeCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radPedigreeCat.Name = "radPedigreeCat"
        Me.radPedigreeCat.Size = New System.Drawing.Size(114, 24)
        Me.radPedigreeCat.TabIndex = 0
        Me.radPedigreeCat.TabStop = True
        Me.radPedigreeCat.Text = "Pedigree Cat"
        Me.radPedigreeCat.UseVisualStyleBackColor = True
        '
        'gboOptionsCat
        '
        Me.gboOptionsCat.BackColor = System.Drawing.Color.Transparent
        Me.gboOptionsCat.Controls.Add(Me.radMediumCatHouse)
        Me.gboOptionsCat.Controls.Add(Me.radSmallCatHouse)
        Me.gboOptionsCat.Controls.Add(Me.radMediumCatGrooming)
        Me.gboOptionsCat.Controls.Add(Me.radSmallCatGrooming)
        Me.gboOptionsCat.Controls.Add(Me.radHouseCat)
        Me.gboOptionsCat.Controls.Add(Me.radGroomingCat)
        Me.gboOptionsCat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboOptionsCat.Location = New System.Drawing.Point(16, 596)
        Me.gboOptionsCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboOptionsCat.Name = "gboOptionsCat"
        Me.gboOptionsCat.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboOptionsCat.Size = New System.Drawing.Size(1013, 151)
        Me.gboOptionsCat.TabIndex = 9
        Me.gboOptionsCat.TabStop = False
        Me.gboOptionsCat.Text = "Step 4: Additional Options (Optional)"
        '
        'radMediumCatHouse
        '
        Me.radMediumCatHouse.AutoSize = True
        Me.radMediumCatHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMediumCatHouse.Location = New System.Drawing.Point(441, 90)
        Me.radMediumCatHouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMediumCatHouse.Name = "radMediumCatHouse"
        Me.radMediumCatHouse.Size = New System.Drawing.Size(113, 24)
        Me.radMediumCatHouse.TabIndex = 14
        Me.radMediumCatHouse.TabStop = True
        Me.radMediumCatHouse.Text = "Medium €14"
        Me.radMediumCatHouse.UseVisualStyleBackColor = True
        Me.radMediumCatHouse.Visible = False
        '
        'radSmallCatHouse
        '
        Me.radSmallCatHouse.AutoSize = True
        Me.radSmallCatHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallCatHouse.Location = New System.Drawing.Point(441, 44)
        Me.radSmallCatHouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmallCatHouse.Name = "radSmallCatHouse"
        Me.radSmallCatHouse.Size = New System.Drawing.Size(95, 24)
        Me.radSmallCatHouse.TabIndex = 13
        Me.radSmallCatHouse.TabStop = True
        Me.radSmallCatHouse.Text = "Small €14"
        Me.radSmallCatHouse.UseVisualStyleBackColor = True
        Me.radSmallCatHouse.Visible = False
        '
        'radMediumCatGrooming
        '
        Me.radMediumCatGrooming.AutoSize = True
        Me.radMediumCatGrooming.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMediumCatGrooming.Location = New System.Drawing.Point(441, 90)
        Me.radMediumCatGrooming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMediumCatGrooming.Name = "radMediumCatGrooming"
        Me.radMediumCatGrooming.Size = New System.Drawing.Size(113, 24)
        Me.radMediumCatGrooming.TabIndex = 12
        Me.radMediumCatGrooming.TabStop = True
        Me.radMediumCatGrooming.Text = "Medium €25"
        Me.radMediumCatGrooming.UseVisualStyleBackColor = True
        Me.radMediumCatGrooming.Visible = False
        '
        'radSmallCatGrooming
        '
        Me.radSmallCatGrooming.AutoSize = True
        Me.radSmallCatGrooming.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallCatGrooming.Location = New System.Drawing.Point(441, 44)
        Me.radSmallCatGrooming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmallCatGrooming.Name = "radSmallCatGrooming"
        Me.radSmallCatGrooming.Size = New System.Drawing.Size(95, 24)
        Me.radSmallCatGrooming.TabIndex = 10
        Me.radSmallCatGrooming.TabStop = True
        Me.radSmallCatGrooming.Text = "Small €20"
        Me.radSmallCatGrooming.UseVisualStyleBackColor = True
        Me.radSmallCatGrooming.Visible = False
        '
        'radHouseCat
        '
        Me.radHouseCat.AutoSize = True
        Me.radHouseCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHouseCat.Location = New System.Drawing.Point(12, 90)
        Me.radHouseCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radHouseCat.Name = "radHouseCat"
        Me.radHouseCat.Size = New System.Drawing.Size(187, 24)
        Me.radHouseCat.TabIndex = 1
        Me.radHouseCat.TabStop = True
        Me.radHouseCat.Text = "House Training Seminar"
        Me.radHouseCat.UseVisualStyleBackColor = True
        '
        'radGroomingCat
        '
        Me.radGroomingCat.AutoSize = True
        Me.radGroomingCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGroomingCat.Location = New System.Drawing.Point(12, 44)
        Me.radGroomingCat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radGroomingCat.Name = "radGroomingCat"
        Me.radGroomingCat.Size = New System.Drawing.Size(154, 24)
        Me.radGroomingCat.TabIndex = 0
        Me.radGroomingCat.TabStop = True
        Me.radGroomingCat.Text = "Grooming Services"
        Me.radGroomingCat.UseVisualStyleBackColor = True
        '
        'gboOptionsDog
        '
        Me.gboOptionsDog.BackColor = System.Drawing.Color.Transparent
        Me.gboOptionsDog.Controls.Add(Me.btnPrice)
        Me.gboOptionsDog.Controls.Add(Me.radLargeDogHouse)
        Me.gboOptionsDog.Controls.Add(Me.radMediumDogHouse)
        Me.gboOptionsDog.Controls.Add(Me.radSmallDogHouse)
        Me.gboOptionsDog.Controls.Add(Me.radLargeDogLong)
        Me.gboOptionsDog.Controls.Add(Me.radMediumDogLong)
        Me.gboOptionsDog.Controls.Add(Me.radSmallDogLong)
        Me.gboOptionsDog.Controls.Add(Me.radLargeDogShort)
        Me.gboOptionsDog.Controls.Add(Me.radMediumDogShort)
        Me.gboOptionsDog.Controls.Add(Me.radSmallDogShort)
        Me.gboOptionsDog.Controls.Add(Me.cboGroomingDog)
        Me.gboOptionsDog.Controls.Add(Me.radHouseDog)
        Me.gboOptionsDog.Controls.Add(Me.radGroomingDog)
        Me.gboOptionsDog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboOptionsDog.Location = New System.Drawing.Point(16, 596)
        Me.gboOptionsDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboOptionsDog.Name = "gboOptionsDog"
        Me.gboOptionsDog.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboOptionsDog.Size = New System.Drawing.Size(1013, 151)
        Me.gboOptionsDog.TabIndex = 10
        Me.gboOptionsDog.TabStop = False
        Me.gboOptionsDog.Text = "Step 4: Additional Options (Optional)"
        '
        'radLargeDogHouse
        '
        Me.radLargeDogHouse.AutoSize = True
        Me.radLargeDogHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLargeDogHouse.Location = New System.Drawing.Point(640, 98)
        Me.radLargeDogHouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLargeDogHouse.Name = "radLargeDogHouse"
        Me.radLargeDogHouse.Size = New System.Drawing.Size(95, 24)
        Me.radLargeDogHouse.TabIndex = 11
        Me.radLargeDogHouse.TabStop = True
        Me.radLargeDogHouse.Text = "Large €28"
        Me.radLargeDogHouse.UseVisualStyleBackColor = True
        Me.radLargeDogHouse.Visible = False
        '
        'radMediumDogHouse
        '
        Me.radMediumDogHouse.AutoSize = True
        Me.radMediumDogHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMediumDogHouse.Location = New System.Drawing.Point(640, 65)
        Me.radMediumDogHouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMediumDogHouse.Name = "radMediumDogHouse"
        Me.radMediumDogHouse.Size = New System.Drawing.Size(113, 24)
        Me.radMediumDogHouse.TabIndex = 10
        Me.radMediumDogHouse.TabStop = True
        Me.radMediumDogHouse.Text = "Medium €22"
        Me.radMediumDogHouse.UseVisualStyleBackColor = True
        Me.radMediumDogHouse.Visible = False
        '
        'radSmallDogHouse
        '
        Me.radSmallDogHouse.AutoSize = True
        Me.radSmallDogHouse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallDogHouse.Location = New System.Drawing.Point(640, 33)
        Me.radSmallDogHouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmallDogHouse.Name = "radSmallDogHouse"
        Me.radSmallDogHouse.Size = New System.Drawing.Size(95, 24)
        Me.radSmallDogHouse.TabIndex = 9
        Me.radSmallDogHouse.TabStop = True
        Me.radSmallDogHouse.Text = "Small €18"
        Me.radSmallDogHouse.UseVisualStyleBackColor = True
        Me.radSmallDogHouse.Visible = False
        '
        'radLargeDogLong
        '
        Me.radLargeDogLong.AutoSize = True
        Me.radLargeDogLong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLargeDogLong.Location = New System.Drawing.Point(640, 98)
        Me.radLargeDogLong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLargeDogLong.Name = "radLargeDogLong"
        Me.radLargeDogLong.Size = New System.Drawing.Size(95, 24)
        Me.radLargeDogLong.TabIndex = 8
        Me.radLargeDogLong.TabStop = True
        Me.radLargeDogLong.Text = "Large €55"
        Me.radLargeDogLong.UseVisualStyleBackColor = True
        Me.radLargeDogLong.Visible = False
        '
        'radMediumDogLong
        '
        Me.radMediumDogLong.AutoSize = True
        Me.radMediumDogLong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMediumDogLong.Location = New System.Drawing.Point(640, 68)
        Me.radMediumDogLong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMediumDogLong.Name = "radMediumDogLong"
        Me.radMediumDogLong.Size = New System.Drawing.Size(113, 24)
        Me.radMediumDogLong.TabIndex = 7
        Me.radMediumDogLong.TabStop = True
        Me.radMediumDogLong.Text = "Medium €50"
        Me.radMediumDogLong.UseVisualStyleBackColor = True
        Me.radMediumDogLong.Visible = False
        '
        'radSmallDogLong
        '
        Me.radSmallDogLong.AutoSize = True
        Me.radSmallDogLong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallDogLong.Location = New System.Drawing.Point(640, 33)
        Me.radSmallDogLong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmallDogLong.Name = "radSmallDogLong"
        Me.radSmallDogLong.Size = New System.Drawing.Size(95, 24)
        Me.radSmallDogLong.TabIndex = 6
        Me.radSmallDogLong.TabStop = True
        Me.radSmallDogLong.Text = "Small €45"
        Me.radSmallDogLong.UseVisualStyleBackColor = True
        Me.radSmallDogLong.Visible = False
        '
        'radLargeDogShort
        '
        Me.radLargeDogShort.AutoSize = True
        Me.radLargeDogShort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLargeDogShort.Location = New System.Drawing.Point(640, 98)
        Me.radLargeDogShort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLargeDogShort.Name = "radLargeDogShort"
        Me.radLargeDogShort.Size = New System.Drawing.Size(95, 24)
        Me.radLargeDogShort.TabIndex = 5
        Me.radLargeDogShort.TabStop = True
        Me.radLargeDogShort.Text = "Large €35"
        Me.radLargeDogShort.UseVisualStyleBackColor = True
        Me.radLargeDogShort.Visible = False
        '
        'radMediumDogShort
        '
        Me.radMediumDogShort.AutoSize = True
        Me.radMediumDogShort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMediumDogShort.Location = New System.Drawing.Point(640, 68)
        Me.radMediumDogShort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radMediumDogShort.Name = "radMediumDogShort"
        Me.radMediumDogShort.Size = New System.Drawing.Size(113, 24)
        Me.radMediumDogShort.TabIndex = 4
        Me.radMediumDogShort.TabStop = True
        Me.radMediumDogShort.Text = "Medium €30"
        Me.radMediumDogShort.UseVisualStyleBackColor = True
        Me.radMediumDogShort.Visible = False
        '
        'radSmallDogShort
        '
        Me.radSmallDogShort.AutoSize = True
        Me.radSmallDogShort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmallDogShort.Location = New System.Drawing.Point(640, 33)
        Me.radSmallDogShort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSmallDogShort.Name = "radSmallDogShort"
        Me.radSmallDogShort.Size = New System.Drawing.Size(95, 24)
        Me.radSmallDogShort.TabIndex = 3
        Me.radSmallDogShort.TabStop = True
        Me.radSmallDogShort.Text = "Small €25"
        Me.radSmallDogShort.UseVisualStyleBackColor = True
        Me.radSmallDogShort.Visible = False
        '
        'cboGroomingDog
        '
        Me.cboGroomingDog.FormattingEnabled = True
        Me.cboGroomingDog.Items.AddRange(New Object() {"Short / Smooth", "Long / Heavy / Curly"})
        Me.cboGroomingDog.Location = New System.Drawing.Point(355, 41)
        Me.cboGroomingDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboGroomingDog.Name = "cboGroomingDog"
        Me.cboGroomingDog.Size = New System.Drawing.Size(160, 29)
        Me.cboGroomingDog.TabIndex = 2
        Me.cboGroomingDog.Visible = False
        '
        'radHouseDog
        '
        Me.radHouseDog.AutoSize = True
        Me.radHouseDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHouseDog.Location = New System.Drawing.Point(8, 90)
        Me.radHouseDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radHouseDog.Name = "radHouseDog"
        Me.radHouseDog.Size = New System.Drawing.Size(187, 24)
        Me.radHouseDog.TabIndex = 1
        Me.radHouseDog.TabStop = True
        Me.radHouseDog.Text = "House Training Seminar"
        Me.radHouseDog.UseVisualStyleBackColor = True
        '
        'radGroomingDog
        '
        Me.radGroomingDog.AutoSize = True
        Me.radGroomingDog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGroomingDog.Location = New System.Drawing.Point(9, 44)
        Me.radGroomingDog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radGroomingDog.Name = "radGroomingDog"
        Me.radGroomingDog.Size = New System.Drawing.Size(154, 24)
        Me.radGroomingDog.TabIndex = 0
        Me.radGroomingDog.TabStop = True
        Me.radGroomingDog.Text = "Grooming Services"
        Me.radGroomingDog.UseVisualStyleBackColor = True
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(931, 121)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnPrice.TabIndex = 12
        Me.btnPrice.Text = "Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(1067, 844)
        Me.Controls.Add(Me.gboOptionsDog)
        Me.Controls.Add(Me.gboBreedCat)
        Me.Controls.Add(Me.gboOptionsCat)
        Me.Controls.Add(Me.gboBreedDog)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboInsurance)
        Me.Controls.Add(Me.gboAnimal)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.gboOptionsCat.ResumeLayout(False)
        Me.gboOptionsCat.PerformLayout()
        Me.gboOptionsDog.ResumeLayout(False)
        Me.gboOptionsDog.PerformLayout()
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
    Friend WithEvents lblOtherDog As Label
    Friend WithEvents txtOtherDog As TextBox
    Friend WithEvents txtOtherCat As TextBox
    Friend WithEvents lblOtherCat As Label
    Friend WithEvents btnContinueDog As Button
    Friend WithEvents btnContinueCat As Button
    Friend WithEvents gboOptionsCat As GroupBox
    Friend WithEvents radHouseCat As RadioButton
    Friend WithEvents radGroomingCat As RadioButton
    Friend WithEvents gboOptionsDog As GroupBox
    Friend WithEvents radHouseDog As RadioButton
    Friend WithEvents radGroomingDog As RadioButton
    Friend WithEvents radLargeDogShort As RadioButton
    Friend WithEvents radMediumDogShort As RadioButton
    Friend WithEvents radSmallDogShort As RadioButton
    Friend WithEvents cboGroomingDog As ComboBox
    Friend WithEvents radLargeDogLong As RadioButton
    Friend WithEvents radMediumDogLong As RadioButton
    Friend WithEvents radSmallDogLong As RadioButton
    Friend WithEvents radLargeDogHouse As RadioButton
    Friend WithEvents radMediumDogHouse As RadioButton
    Friend WithEvents radSmallDogHouse As RadioButton
    Friend WithEvents radMediumCatGrooming As RadioButton
    Friend WithEvents radSmallCatGrooming As RadioButton
    Friend WithEvents radMediumCatHouse As RadioButton
    Friend WithEvents radSmallCatHouse As RadioButton
    Friend WithEvents btnPrice As Button
End Class
