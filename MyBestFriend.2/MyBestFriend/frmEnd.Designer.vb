<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnd
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
        Me.picJack = New System.Windows.Forms.PictureBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        CType(Me.picJack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picJack
        '
        Me.picJack.Image = Global.MyBestFriend.My.Resources.Resources.jack2
        Me.picJack.Location = New System.Drawing.Point(217, 32)
        Me.picJack.Name = "picJack"
        Me.picJack.Size = New System.Drawing.Size(373, 359)
        Me.picJack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJack.TabIndex = 0
        Me.picJack.TabStop = False
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblEnd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(250, 9)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(303, 20)
        Me.lblEnd.TabIndex = 1
        Me.lblEnd.Text = "Congratulations, You made it to the END!!"
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.White
        Me.btnEnd.Location = New System.Drawing.Point(217, 397)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(373, 41)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'frmEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MyBestFriend.My.Resources.Resources.white_mint_gradient_background_vector_8346120
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.picJack)
        Me.Name = "frmEnd"
        Me.Text = "End"
        CType(Me.picJack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picJack As PictureBox
    Friend WithEvents lblEnd As Label
    Friend WithEvents btnEnd As Button
End Class
