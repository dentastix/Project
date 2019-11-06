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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
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
        Me.gboInsurance.Location = New System.Drawing.Point(12, 190)
        Me.gboInsurance.Name = "gboInsurance"
        Me.gboInsurance.Size = New System.Drawing.Size(294, 173)
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
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(13, 127)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(697, 397)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboInsurance)
        Me.Controls.Add(Me.gboAnimal)
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
End Class
