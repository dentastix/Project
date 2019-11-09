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
        Me.gboAnimal.SuspendLayout()
        CType(Me.picInsurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboInsurance.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gboAnimal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboAnimal.Location = New System.Drawing.Point(16, 15)
        Me.gboAnimal.Margin = New System.Windows.Forms.Padding(4)
        Me.gboAnimal.Name = "gboAnimal"
        Me.gboAnimal.Padding = New System.Windows.Forms.Padding(4)
        Me.gboAnimal.Size = New System.Drawing.Size(801, 192)
        Me.gboAnimal.TabIndex = 1
        Me.gboAnimal.TabStop = False
        Me.gboAnimal.Text = "Pet Selection"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(17, 156)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
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
        Me.picInsurance.Margin = New System.Windows.Forms.Padding(4)
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
        Me.radDog.Margin = New System.Windows.Forms.Padding(4)
        Me.radDog.Name = "radDog"
        Me.radDog.Size = New System.Drawing.Size(59, 24)
        Me.radDog.TabIndex = 2
        Me.radDog.TabStop = True
        Me.radDog.Text = "Dog"
        Me.radDog.UseVisualStyleBackColor = True
        '
        'radCat
        '
        Me.radCat.AutoSize = True
        Me.radCat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCat.Location = New System.Drawing.Point(17, 64)
        Me.radCat.Margin = New System.Windows.Forms.Padding(4)
        Me.radCat.Name = "radCat"
        Me.radCat.Size = New System.Drawing.Size(52, 24)
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
        Me.gboInsurance.Location = New System.Drawing.Point(16, 234)
        Me.gboInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.gboInsurance.Name = "gboInsurance"
        Me.gboInsurance.Padding = New System.Windows.Forms.Padding(4)
        Me.gboInsurance.Size = New System.Drawing.Size(392, 213)
        Me.gboInsurance.TabIndex = 2
        Me.gboInsurance.TabStop = False
        Me.gboInsurance.Text = "Insurance Type"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(12, 39)
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
        Me.radPlus.Location = New System.Drawing.Point(12, 166)
        Me.radPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.radPlus.Name = "radPlus"
        Me.radPlus.Size = New System.Drawing.Size(301, 24)
        Me.radPlus.TabIndex = 2
        Me.radPlus.TabStop = True
        Me.radPlus.Text = "Premier Plus Cover (Accident and Illness):"
        Me.radPlus.UseVisualStyleBackColor = True
        '
        'radPremier
        '
        Me.radPremier.AutoSize = True
        Me.radPremier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPremier.Location = New System.Drawing.Point(12, 121)
        Me.radPremier.Margin = New System.Windows.Forms.Padding(4)
        Me.radPremier.Name = "radPremier"
        Me.radPremier.Size = New System.Drawing.Size(271, 24)
        Me.radPremier.TabIndex = 1
        Me.radPremier.TabStop = True
        Me.radPremier.Text = "Premier Cover (Accident and Illness):"
        Me.radPremier.UseVisualStyleBackColor = True
        '
        'radEssential
        '
        Me.radEssential.AutoSize = True
        Me.radEssential.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEssential.Location = New System.Drawing.Point(12, 76)
        Me.radEssential.Margin = New System.Windows.Forms.Padding(4)
        Me.radEssential.Name = "radEssential"
        Me.radEssential.Size = New System.Drawing.Size(238, 24)
        Me.radEssential.TabIndex = 0
        Me.radEssential.TabStop = True
        Me.radEssential.Text = "Essential Cover (Accident Only):"
        Me.radEssential.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.MyBestFriend.My.Resources.Resources.nuhy
        Me.picLogo.Location = New System.Drawing.Point(825, -18)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(4)
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
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(528, 198)
        Me.txtDescription.TabIndex = 4
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(929, 471)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 28)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "&Continue"
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
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(1067, 528)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboInsurance)
        Me.Controls.Add(Me.gboAnimal)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAnimal"
        Me.Text = "Animal Details"
        Me.gboAnimal.ResumeLayout(False)
        Me.gboAnimal.PerformLayout()
        CType(Me.picInsurance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboInsurance.ResumeLayout(False)
        Me.gboInsurance.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
