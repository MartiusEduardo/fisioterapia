<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_sobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sobre))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(742, 75)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(12, 94)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(89, 13)
        Me.LabelProductName.TabIndex = 1
        Me.LabelProductName.Text = "Nome do produto"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(12, 121)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(40, 13)
        Me.LabelVersion.TabIndex = 2
        Me.LabelVersion.Text = "Versão"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(12, 147)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(51, 13)
        Me.LabelCopyright.TabIndex = 3
        Me.LabelCopyright.Text = "Copyright"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(12, 172)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(94, 13)
        Me.LabelCompanyName.TabIndex = 4
        Me.LabelCompanyName.Text = "Nome da Empresa"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(230, 81)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(500, 109)
        Me.TextBoxDescription.TabIndex = 5
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(655, 197)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 6
        Me.OKButton.Text = "&OK"
        '
        'form_sobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(742, 232)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.LabelCompanyName)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.LabelProductName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_sobre"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
