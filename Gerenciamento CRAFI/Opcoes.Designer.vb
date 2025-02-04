<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_opcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_opcoes))
        Me.OpcoesTabControl = New System.Windows.Forms.TabControl()
        Me.SistemaTabPage = New System.Windows.Forms.TabPage()
        Me.rdo_servidor2 = New System.Windows.Forms.RadioButton()
        Me.rdo_servidor1 = New System.Windows.Forms.RadioButton()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.OpcoesTabControl.SuspendLayout()
        Me.SistemaTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpcoesTabControl
        '
        Me.OpcoesTabControl.Controls.Add(Me.SistemaTabPage)
        Me.OpcoesTabControl.Location = New System.Drawing.Point(1, 0)
        Me.OpcoesTabControl.Name = "OpcoesTabControl"
        Me.OpcoesTabControl.SelectedIndex = 0
        Me.OpcoesTabControl.Size = New System.Drawing.Size(290, 120)
        Me.OpcoesTabControl.TabIndex = 0
        '
        'SistemaTabPage
        '
        Me.SistemaTabPage.Controls.Add(Me.rdo_servidor2)
        Me.SistemaTabPage.Controls.Add(Me.rdo_servidor1)
        Me.SistemaTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SistemaTabPage.Name = "SistemaTabPage"
        Me.SistemaTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SistemaTabPage.Size = New System.Drawing.Size(282, 94)
        Me.SistemaTabPage.TabIndex = 1
        Me.SistemaTabPage.Text = "Sistema"
        Me.SistemaTabPage.UseVisualStyleBackColor = True
        '
        'rdo_servidor2
        '
        Me.rdo_servidor2.AutoSize = True
        Me.rdo_servidor2.Location = New System.Drawing.Point(7, 29)
        Me.rdo_servidor2.Name = "rdo_servidor2"
        Me.rdo_servidor2.Size = New System.Drawing.Size(73, 17)
        Me.rdo_servidor2.TabIndex = 1
        Me.rdo_servidor2.TabStop = True
        Me.rdo_servidor2.Text = "Servidor 2"
        Me.rdo_servidor2.UseVisualStyleBackColor = True
        '
        'rdo_servidor1
        '
        Me.rdo_servidor1.AutoSize = True
        Me.rdo_servidor1.Checked = True
        Me.rdo_servidor1.Location = New System.Drawing.Point(7, 6)
        Me.rdo_servidor1.Name = "rdo_servidor1"
        Me.rdo_servidor1.Size = New System.Drawing.Size(73, 17)
        Me.rdo_servidor1.TabIndex = 0
        Me.rdo_servidor1.TabStop = True
        Me.rdo_servidor1.Text = "Servidor 1"
        Me.rdo_servidor1.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(204, 126)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(123, 126)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 6
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'form_opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(291, 159)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.OpcoesTabControl)
        Me.Controls.Add(Me.btn_ok)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_opcoes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opções"
        Me.OpcoesTabControl.ResumeLayout(False)
        Me.SistemaTabPage.ResumeLayout(False)
        Me.SistemaTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpcoesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents SistemaTabPage As System.Windows.Forms.TabPage
    Friend WithEvents rdo_servidor2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_servidor1 As System.Windows.Forms.RadioButton
End Class
