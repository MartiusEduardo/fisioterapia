<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_ie_contatos
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
        Me.components = New System.ComponentModel.Container()
        Dim CodigoContatoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim TelefoneResidencialLabel As System.Windows.Forms.Label
        Dim TelefoneTrabalhoLabel As System.Windows.Forms.Label
        Dim TelefoneCelularLabel As System.Windows.Forms.Label
        Dim CnpjCpfLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_ie_contatos))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ContatosTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ContatosTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.ContatosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ContatosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ContatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CodigoContatoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneResidencialTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTrabalhoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneCelularTextBox = New System.Windows.Forms.TextBox()
        Me.CnpjCpfTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoTelefone = New System.Windows.Forms.GroupBox()
        CodigoContatoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        TelefoneResidencialLabel = New System.Windows.Forms.Label()
        TelefoneTrabalhoLabel = New System.Windows.Forms.Label()
        TelefoneCelularLabel = New System.Windows.Forms.Label()
        CnpjCpfLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContatosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContatosBindingNavigator.SuspendLayout()
        CType(Me.ContatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoTelefone.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoContatoLabel
        '
        CodigoContatoLabel.AutoSize = True
        CodigoContatoLabel.Location = New System.Drawing.Point(42, 49)
        CodigoContatoLabel.Name = "CodigoContatoLabel"
        CodigoContatoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoContatoLabel.TabIndex = 1
        CodigoContatoLabel.Text = "Código:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(47, 75)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'TelefoneResidencialLabel
        '
        TelefoneResidencialLabel.AutoSize = True
        TelefoneResidencialLabel.Location = New System.Drawing.Point(5, 22)
        TelefoneResidencialLabel.Name = "TelefoneResidencialLabel"
        TelefoneResidencialLabel.Size = New System.Drawing.Size(65, 13)
        TelefoneResidencialLabel.TabIndex = 5
        TelefoneResidencialLabel.Text = "Residencial:"
        '
        'TelefoneTrabalhoLabel
        '
        TelefoneTrabalhoLabel.AutoSize = True
        TelefoneTrabalhoLabel.Location = New System.Drawing.Point(18, 48)
        TelefoneTrabalhoLabel.Name = "TelefoneTrabalhoLabel"
        TelefoneTrabalhoLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneTrabalhoLabel.TabIndex = 7
        TelefoneTrabalhoLabel.Text = "Trabalho:"
        '
        'TelefoneCelularLabel
        '
        TelefoneCelularLabel.AutoSize = True
        TelefoneCelularLabel.Location = New System.Drawing.Point(28, 74)
        TelefoneCelularLabel.Name = "TelefoneCelularLabel"
        TelefoneCelularLabel.Size = New System.Drawing.Size(42, 13)
        TelefoneCelularLabel.TabIndex = 9
        TelefoneCelularLabel.Text = "Celular:"
        '
        'CnpjCpfLabel
        '
        CnpjCpfLabel.AutoSize = True
        CnpjCpfLabel.Location = New System.Drawing.Point(17, 101)
        CnpjCpfLabel.Name = "CnpjCpfLabel"
        CnpjCpfLabel.Size = New System.Drawing.Size(68, 13)
        CnpjCpfLabel.TabIndex = 11
        CnpjCpfLabel.Text = "CNPJ / CPF:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(29, 127)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 13
        EnderecoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(48, 153)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 15
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(42, 179)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 17
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(42, 205)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 19
        EstadoLabel.Text = "Estado:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(54, 231)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 21
        CEPLabel.Text = "CEP:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(50, 257)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "Email:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(36, 283)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        WebsiteLabel.TabIndex = 25
        WebsiteLabel.Text = "Website:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(12, 309)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 27
        ObservacoesLabel.Text = "Observações:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContatosTableAdapter
        '
        Me.ContatosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Me.ContatosTableAdapter
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Me.LogControleTableAdapter
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'ContatosBindingNavigator
        '
        Me.ContatosBindingNavigator.AddNewItem = Nothing
        Me.ContatosBindingNavigator.CountItem = Nothing
        Me.ContatosBindingNavigator.DeleteItem = Nothing
        Me.ContatosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ContatosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarToolStripButton, Me.ContatosBindingNavigatorSaveItem, Me.CancelarToolStripButton})
        Me.ContatosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContatosBindingNavigator.MoveFirstItem = Nothing
        Me.ContatosBindingNavigator.MoveLastItem = Nothing
        Me.ContatosBindingNavigator.MoveNextItem = Nothing
        Me.ContatosBindingNavigator.MovePreviousItem = Nothing
        Me.ContatosBindingNavigator.Name = "ContatosBindingNavigator"
        Me.ContatosBindingNavigator.PositionItem = Nothing
        Me.ContatosBindingNavigator.Size = New System.Drawing.Size(543, 25)
        Me.ContatosBindingNavigator.TabIndex = 0
        Me.ContatosBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarToolStripButton
        '
        Me.AdicionarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._6141_32x32
        Me.AdicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarToolStripButton.Name = "AdicionarToolStripButton"
        Me.AdicionarToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarToolStripButton.Text = "Adicionar"
        '
        'ContatosBindingNavigatorSaveItem
        '
        Me.ContatosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ContatosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ContatosBindingNavigatorSaveItem.Name = "ContatosBindingNavigatorSaveItem"
        Me.ContatosBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ContatosBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarToolStripButton
        '
        Me.CancelarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarToolStripButton.Name = "CancelarToolStripButton"
        Me.CancelarToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarToolStripButton.Text = "Cancelar"
        '
        'ContatosBindingSource
        '
        Me.ContatosBindingSource.DataMember = "Contatos"
        Me.ContatosBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'CodigoContatoTextBox
        '
        Me.CodigoContatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "codigoContato", True))
        Me.CodigoContatoTextBox.Enabled = False
        Me.CodigoContatoTextBox.Location = New System.Drawing.Point(91, 46)
        Me.CodigoContatoTextBox.Name = "CodigoContatoTextBox"
        Me.CodigoContatoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoContatoTextBox.TabIndex = 2
        Me.CodigoContatoTextBox.Tag = "N"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(91, 72)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'TelefoneResidencialTextBox
        '
        Me.TelefoneResidencialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "TelefoneResidencial", True))
        Me.TelefoneResidencialTextBox.Location = New System.Drawing.Point(76, 19)
        Me.TelefoneResidencialTextBox.Name = "TelefoneResidencialTextBox"
        Me.TelefoneResidencialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneResidencialTextBox.TabIndex = 6
        '
        'TelefoneTrabalhoTextBox
        '
        Me.TelefoneTrabalhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "TelefoneTrabalho", True))
        Me.TelefoneTrabalhoTextBox.Location = New System.Drawing.Point(76, 45)
        Me.TelefoneTrabalhoTextBox.Name = "TelefoneTrabalhoTextBox"
        Me.TelefoneTrabalhoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneTrabalhoTextBox.TabIndex = 8
        '
        'TelefoneCelularTextBox
        '
        Me.TelefoneCelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "TelefoneCelular", True))
        Me.TelefoneCelularTextBox.Location = New System.Drawing.Point(76, 71)
        Me.TelefoneCelularTextBox.Name = "TelefoneCelularTextBox"
        Me.TelefoneCelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneCelularTextBox.TabIndex = 10
        '
        'CnpjCpfTextBox
        '
        Me.CnpjCpfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "CnpjCpf", True))
        Me.CnpjCpfTextBox.Location = New System.Drawing.Point(91, 98)
        Me.CnpjCpfTextBox.Name = "CnpjCpfTextBox"
        Me.CnpjCpfTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CnpjCpfTextBox.TabIndex = 12
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(91, 124)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.EnderecoTextBox.TabIndex = 14
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(91, 150)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(150, 20)
        Me.BairroTextBox.TabIndex = 16
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(91, 176)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CidadeTextBox.TabIndex = 18
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(91, 202)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(150, 20)
        Me.EstadoTextBox.TabIndex = 20
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(91, 228)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(91, 254)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(250, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(91, 280)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(250, 20)
        Me.WebsiteTextBox.TabIndex = 26
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContatosBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(91, 306)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(250, 100)
        Me.ObservacoesTextBox.TabIndex = 28
        '
        'GrupoTelefone
        '
        Me.GrupoTelefone.Controls.Add(TelefoneResidencialLabel)
        Me.GrupoTelefone.Controls.Add(Me.TelefoneResidencialTextBox)
        Me.GrupoTelefone.Controls.Add(Me.TelefoneTrabalhoTextBox)
        Me.GrupoTelefone.Controls.Add(Me.TelefoneCelularTextBox)
        Me.GrupoTelefone.Controls.Add(TelefoneCelularLabel)
        Me.GrupoTelefone.Controls.Add(TelefoneTrabalhoLabel)
        Me.GrupoTelefone.Location = New System.Drawing.Point(347, 46)
        Me.GrupoTelefone.Name = "GrupoTelefone"
        Me.GrupoTelefone.Size = New System.Drawing.Size(187, 101)
        Me.GrupoTelefone.TabIndex = 29
        Me.GrupoTelefone.TabStop = False
        Me.GrupoTelefone.Text = "Telefone"
        '
        'form_ie_contatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(543, 416)
        Me.Controls.Add(Me.GrupoTelefone)
        Me.Controls.Add(CodigoContatoLabel)
        Me.Controls.Add(Me.CodigoContatoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CnpjCpfLabel)
        Me.Controls.Add(Me.CnpjCpfTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(WebsiteLabel)
        Me.Controls.Add(Me.WebsiteTextBox)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(Me.ContatosBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_ie_contatos"
        Me.ShowIcon = False
        Me.Text = "Contatos"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContatosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContatosBindingNavigator.ResumeLayout(False)
        Me.ContatosBindingNavigator.PerformLayout()
        CType(Me.ContatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoTelefone.ResumeLayout(False)
        Me.GrupoTelefone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ContatosTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ContatosTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContatosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ContatosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdicionarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents ContatosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CodigoContatoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneResidencialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTrabalhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneCelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CnpjCpfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoTelefone As System.Windows.Forms.GroupBox
End Class
