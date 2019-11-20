<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDogEssential
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gboType = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(17, 511)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gboType
        '
        Me.gboType.Location = New System.Drawing.Point(12, 12)
        Me.gboType.Name = "gboType"
        Me.gboType.Size = New System.Drawing.Size(504, 268)
        Me.gboType.TabIndex = 1
        Me.gboType.TabStop = False
        Me.gboType.Text = "GroupBox1"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = Global.MyBestFriend.My.Resources.Resources.nuhy
        Me.picLogo.Location = New System.Drawing.Point(827, -23)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(253, 247)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 2
        Me.picLogo.TabStop = False
        '
        'frmDogEssential
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.gboType)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDogEssential"
        Me.Text = "Dog Essential"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents gboType As GroupBox
    Friend WithEvents picLogo As PictureBox
End Class
