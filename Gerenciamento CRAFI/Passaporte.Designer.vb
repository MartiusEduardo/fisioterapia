<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_passaporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_passaporte))
        Me.wbPassaporte = New System.Windows.Forms.WebBrowser()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'wbPassaporte
        '
        Me.wbPassaporte.Location = New System.Drawing.Point(0, 0)
        Me.wbPassaporte.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbPassaporte.Name = "wbPassaporte"
        Me.wbPassaporte.Size = New System.Drawing.Size(586, 429)
        Me.wbPassaporte.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(12, 435)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 39)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(451, 435)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(119, 39)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'form_passaporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 486)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.wbPassaporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_passaporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passaporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbPassaporte As System.Windows.Forms.WebBrowser
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
