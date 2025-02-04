<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class form_login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_configurar_servidor = New System.Windows.Forms.Button()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.LogEntradaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogEntradaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.LogEntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QueriesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter()
        Me.PegarFuncoesLoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.pegarFuncoesLoginTableAdapter()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogEntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 20)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(162, 75)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(180, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(180, 55)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(182, 32)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(182, 75)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(206, 116)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 6
        Me.OK.Text = "&OK"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(306, 116)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(94, 23)
        Me.btn_sair.TabIndex = 7
        Me.btn_sair.Text = "&Sair"
        '
        'btn_configurar_servidor
        '
        Me.btn_configurar_servidor.Location = New System.Drawing.Point(93, 116)
        Me.btn_configurar_servidor.Name = "btn_configurar_servidor"
        Me.btn_configurar_servidor.Size = New System.Drawing.Size(107, 23)
        Me.btn_configurar_servidor.TabIndex = 8
        Me.btn_configurar_servidor.Text = "&Configurar Servidor"
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'LogEntradaTableAdapter
        '
        Me.LogEntradaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Me.LogEntradaTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogEntradaBindingSource
        '
        Me.LogEntradaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        Me.LogEntradaBindingSource.Position = 0
        '
        'PegarFuncoesLoginTableAdapter
        '
        Me.PegarFuncoesLoginTableAdapter.ClearBeforeFill = True
        '
        'form_login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(416, 151)
        Me.Controls.Add(Me.btn_configurar_servidor)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogEntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents LogEntradaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LogEntradaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogEntradaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents btn_configurar_servidor As System.Windows.Forms.Button
    Friend WithEvents QueriesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents PegarFuncoesLoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.pegarFuncoesLoginTableAdapter

End Class
