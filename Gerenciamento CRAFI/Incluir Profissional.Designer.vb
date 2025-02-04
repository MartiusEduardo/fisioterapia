<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_profissional
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
        Dim NumRegistroOrgaoClasseLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim NacionalidadeLabel As System.Windows.Forms.Label
        Dim TituloDiplomaCertificadoLabel As System.Windows.Forms.Label
        Dim InstituicaoLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EspecialidadesLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim CodigoProLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_profissional))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ProfissionaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarProfissionalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ProfissionaisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarProfissionalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NumRegistroOrgaoClasseTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexoMRadioButton = New System.Windows.Forms.RadioButton()
        Me.SexoFRadioButton = New System.Windows.Forms.RadioButton()
        Me.GrupoSexoProfissional = New System.Windows.Forms.GroupBox()
        Me.NacionalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.TituloDiplomaCertificadoTextBox = New System.Windows.Forms.TextBox()
        Me.InstituicaoTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialidadesTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.CodigoProTextBox = New System.Windows.Forms.TextBox()
        NumRegistroOrgaoClasseLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        NacionalidadeLabel = New System.Windows.Forms.Label()
        TituloDiplomaCertificadoLabel = New System.Windows.Forms.Label()
        InstituicaoLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EspecialidadesLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        CodigoProLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfissionaisBindingNavigator.SuspendLayout()
        Me.GrupoSexoProfissional.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumRegistroOrgaoClasseLabel
        '
        NumRegistroOrgaoClasseLabel.AutoSize = True
        NumRegistroOrgaoClasseLabel.Location = New System.Drawing.Point(12, 64)
        NumRegistroOrgaoClasseLabel.Name = "NumRegistroOrgaoClasseLabel"
        NumRegistroOrgaoClasseLabel.Size = New System.Drawing.Size(147, 13)
        NumRegistroOrgaoClasseLabel.TabIndex = 1
        NumRegistroOrgaoClasseLabel.Text = "Registro em Órgão de Classe:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(121, 90)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(52, 119)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataNascimentoLabel.TabIndex = 5
        DataNascimentoLabel.Text = "Data de Nascimento:"
        '
        'NacionalidadeLabel
        '
        NacionalidadeLabel.AutoSize = True
        NacionalidadeLabel.Location = New System.Drawing.Point(81, 200)
        NacionalidadeLabel.Name = "NacionalidadeLabel"
        NacionalidadeLabel.Size = New System.Drawing.Size(78, 13)
        NacionalidadeLabel.TabIndex = 11
        NacionalidadeLabel.Text = "Nacionalidade:"
        '
        'TituloDiplomaCertificadoLabel
        '
        TituloDiplomaCertificadoLabel.AutoSize = True
        TituloDiplomaCertificadoLabel.Location = New System.Drawing.Point(23, 226)
        TituloDiplomaCertificadoLabel.Name = "TituloDiplomaCertificadoLabel"
        TituloDiplomaCertificadoLabel.Size = New System.Drawing.Size(136, 13)
        TituloDiplomaCertificadoLabel.TabIndex = 12
        TituloDiplomaCertificadoLabel.Text = "Título/Diploma/Certificado:"
        '
        'InstituicaoLabel
        '
        InstituicaoLabel.AutoSize = True
        InstituicaoLabel.Location = New System.Drawing.Point(101, 332)
        InstituicaoLabel.Name = "InstituicaoLabel"
        InstituicaoLabel.Size = New System.Drawing.Size(58, 13)
        InstituicaoLabel.TabIndex = 13
        InstituicaoLabel.Text = "Instituição:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(103, 438)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 14
        EnderecoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(122, 464)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 16
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(271, 464)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 18
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(116, 490)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 20
        EstadoLabel.Text = "Estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(284, 490)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 13)
        PaisLabel.TabIndex = 22
        PaisLabel.Text = "País:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(107, 516)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 24
        TelefoneLabel.Text = "Telefone:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(272, 516)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 26
        CelularLabel.Text = "Celular:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(121, 542)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 28
        EmailLabel.Text = "E-mail:"
        '
        'EspecialidadesLabel
        '
        EspecialidadesLabel.AutoSize = True
        EspecialidadesLabel.Location = New System.Drawing.Point(78, 568)
        EspecialidadesLabel.Name = "EspecialidadesLabel"
        EspecialidadesLabel.Size = New System.Drawing.Size(81, 13)
        EspecialidadesLabel.TabIndex = 30
        EspecialidadesLabel.Text = "Especialidades:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(86, 674)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 32
        ObservacoesLabel.Text = "Observações:"
        '
        'CodigoProLabel
        '
        CodigoProLabel.AutoSize = True
        CodigoProLabel.Location = New System.Drawing.Point(45, 38)
        CodigoProLabel.Name = "CodigoProLabel"
        CodigoProLabel.Size = New System.Drawing.Size(114, 13)
        CodigoProLabel.TabIndex = 34
        CodigoProLabel.Text = "Código do Profissional:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfissionaisBindingSource
        '
        Me.ProfissionaisBindingSource.DataMember = "Profissionais"
        Me.ProfissionaisBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ProfissionaisTableAdapter
        '
        Me.ProfissionaisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Nothing
        Me.TableAdapterManager.ConveniosTableAdapter = Nothing
        Me.TableAdapterManager.CustoFixoTableAdapter = Nothing
        Me.TableAdapterManager.CustoVariavelTableAdapter = Nothing
        Me.TableAdapterManager.DespesaFixaTableAdapter = Nothing
        Me.TableAdapterManager.DespesaVariavelTableAdapter = Nothing
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Nothing
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Me.ProfissionaisTableAdapter
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfissionaisBindingNavigator
        '
        Me.ProfissionaisBindingNavigator.AddNewItem = Nothing
        Me.ProfissionaisBindingNavigator.BindingSource = Me.ProfissionaisBindingSource
        Me.ProfissionaisBindingNavigator.CountItem = Nothing
        Me.ProfissionaisBindingNavigator.DeleteItem = Nothing
        Me.ProfissionaisBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ProfissionaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarProfissionalToolStripButton, Me.ProfissionaisBindingNavigatorSaveItem, Me.CancelarProfissionalToolStripButton})
        Me.ProfissionaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfissionaisBindingNavigator.MoveFirstItem = Nothing
        Me.ProfissionaisBindingNavigator.MoveLastItem = Nothing
        Me.ProfissionaisBindingNavigator.MoveNextItem = Nothing
        Me.ProfissionaisBindingNavigator.MovePreviousItem = Nothing
        Me.ProfissionaisBindingNavigator.Name = "ProfissionaisBindingNavigator"
        Me.ProfissionaisBindingNavigator.PositionItem = Nothing
        Me.ProfissionaisBindingNavigator.Size = New System.Drawing.Size(438, 25)
        Me.ProfissionaisBindingNavigator.TabIndex = 0
        Me.ProfissionaisBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarProfissionalToolStripButton
        '
        Me.AdicionarProfissionalToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarProfissionalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarProfissionalToolStripButton.Name = "AdicionarProfissionalToolStripButton"
        Me.AdicionarProfissionalToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarProfissionalToolStripButton.Text = "Adicionar"
        '
        'ProfissionaisBindingNavigatorSaveItem
        '
        Me.ProfissionaisBindingNavigatorSaveItem.Enabled = False
        Me.ProfissionaisBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfissionaisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfissionaisBindingNavigatorSaveItem.Name = "ProfissionaisBindingNavigatorSaveItem"
        Me.ProfissionaisBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ProfissionaisBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarProfissionalToolStripButton
        '
        Me.CancelarProfissionalToolStripButton.Enabled = False
        Me.CancelarProfissionalToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarProfissionalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarProfissionalToolStripButton.Name = "CancelarProfissionalToolStripButton"
        Me.CancelarProfissionalToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarProfissionalToolStripButton.Text = "Cancelar"
        '
        'NumRegistroOrgaoClasseTextBox
        '
        Me.NumRegistroOrgaoClasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "NumRegistroOrgaoClasse", True))
        Me.NumRegistroOrgaoClasseTextBox.Enabled = False
        Me.NumRegistroOrgaoClasseTextBox.Location = New System.Drawing.Point(165, 61)
        Me.NumRegistroOrgaoClasseTextBox.Name = "NumRegistroOrgaoClasseTextBox"
        Me.NumRegistroOrgaoClasseTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NumRegistroOrgaoClasseTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(165, 87)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(255, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfissionaisBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Enabled = False
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(165, 113)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(255, 20)
        Me.DataNascimentoDateTimePicker.TabIndex = 6
        '
        'SexoMRadioButton
        '
        Me.SexoMRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProfissionaisBindingSource, "SexoM", True))
        Me.SexoMRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.SexoMRadioButton.Name = "SexoMRadioButton"
        Me.SexoMRadioButton.Size = New System.Drawing.Size(76, 24)
        Me.SexoMRadioButton.TabIndex = 8
        Me.SexoMRadioButton.TabStop = True
        Me.SexoMRadioButton.Text = "Masculino"
        Me.SexoMRadioButton.UseVisualStyleBackColor = True
        '
        'SexoFRadioButton
        '
        Me.SexoFRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProfissionaisBindingSource, "SexoF", True))
        Me.SexoFRadioButton.Location = New System.Drawing.Point(88, 19)
        Me.SexoFRadioButton.Name = "SexoFRadioButton"
        Me.SexoFRadioButton.Size = New System.Drawing.Size(69, 24)
        Me.SexoFRadioButton.TabIndex = 10
        Me.SexoFRadioButton.TabStop = True
        Me.SexoFRadioButton.Text = "Feminino"
        Me.SexoFRadioButton.UseVisualStyleBackColor = True
        '
        'GrupoSexoProfissional
        '
        Me.GrupoSexoProfissional.Controls.Add(Me.SexoMRadioButton)
        Me.GrupoSexoProfissional.Controls.Add(Me.SexoFRadioButton)
        Me.GrupoSexoProfissional.Enabled = False
        Me.GrupoSexoProfissional.Location = New System.Drawing.Point(165, 139)
        Me.GrupoSexoProfissional.Name = "GrupoSexoProfissional"
        Me.GrupoSexoProfissional.Size = New System.Drawing.Size(163, 52)
        Me.GrupoSexoProfissional.TabIndex = 11
        Me.GrupoSexoProfissional.TabStop = False
        Me.GrupoSexoProfissional.Text = "Sexo"
        '
        'NacionalidadeTextBox
        '
        Me.NacionalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Nacionalidade", True))
        Me.NacionalidadeTextBox.Enabled = False
        Me.NacionalidadeTextBox.Location = New System.Drawing.Point(165, 197)
        Me.NacionalidadeTextBox.Name = "NacionalidadeTextBox"
        Me.NacionalidadeTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NacionalidadeTextBox.TabIndex = 12
        '
        'TituloDiplomaCertificadoTextBox
        '
        Me.TituloDiplomaCertificadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "TituloDiplomaCertificado", True))
        Me.TituloDiplomaCertificadoTextBox.Enabled = False
        Me.TituloDiplomaCertificadoTextBox.Location = New System.Drawing.Point(165, 223)
        Me.TituloDiplomaCertificadoTextBox.Multiline = True
        Me.TituloDiplomaCertificadoTextBox.Name = "TituloDiplomaCertificadoTextBox"
        Me.TituloDiplomaCertificadoTextBox.Size = New System.Drawing.Size(255, 100)
        Me.TituloDiplomaCertificadoTextBox.TabIndex = 13
        '
        'InstituicaoTextBox
        '
        Me.InstituicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Instituicao", True))
        Me.InstituicaoTextBox.Enabled = False
        Me.InstituicaoTextBox.Location = New System.Drawing.Point(165, 329)
        Me.InstituicaoTextBox.Multiline = True
        Me.InstituicaoTextBox.Name = "InstituicaoTextBox"
        Me.InstituicaoTextBox.Size = New System.Drawing.Size(255, 100)
        Me.InstituicaoTextBox.TabIndex = 14
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Location = New System.Drawing.Point(165, 435)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(255, 20)
        Me.EnderecoTextBox.TabIndex = 15
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Bairro", True))
        Me.BairroTextBox.Enabled = False
        Me.BairroTextBox.Location = New System.Drawing.Point(165, 461)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BairroTextBox.TabIndex = 17
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Location = New System.Drawing.Point(320, 461)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CidadeTextBox.TabIndex = 19
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(165, 487)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 21
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Pais", True))
        Me.PaisTextBox.Enabled = False
        Me.PaisTextBox.Location = New System.Drawing.Point(320, 487)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 23
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Enabled = False
        Me.TelefoneTextBox.Location = New System.Drawing.Point(165, 513)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneTextBox.TabIndex = 25
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Celular", True))
        Me.CelularTextBox.Enabled = False
        Me.CelularTextBox.Location = New System.Drawing.Point(320, 513)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 27
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(165, 539)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(255, 20)
        Me.EmailTextBox.TabIndex = 29
        '
        'EspecialidadesTextBox
        '
        Me.EspecialidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Especialidades", True))
        Me.EspecialidadesTextBox.Enabled = False
        Me.EspecialidadesTextBox.Location = New System.Drawing.Point(165, 565)
        Me.EspecialidadesTextBox.Multiline = True
        Me.EspecialidadesTextBox.Name = "EspecialidadesTextBox"
        Me.EspecialidadesTextBox.Size = New System.Drawing.Size(255, 100)
        Me.EspecialidadesTextBox.TabIndex = 31
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Enabled = False
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(165, 671)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(255, 100)
        Me.ObservacoesTextBox.TabIndex = 33
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'CodigoProTextBox
        '
        Me.CodigoProTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "CodigoPro", True))
        Me.CodigoProTextBox.Enabled = False
        Me.CodigoProTextBox.Location = New System.Drawing.Point(165, 35)
        Me.CodigoProTextBox.Name = "CodigoProTextBox"
        Me.CodigoProTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoProTextBox.TabIndex = 35
        Me.CodigoProTextBox.Tag = "N"
        '
        'form_incluir_profissional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(455, 314)
        Me.Controls.Add(CodigoProLabel)
        Me.Controls.Add(Me.CodigoProTextBox)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(EspecialidadesLabel)
        Me.Controls.Add(Me.EspecialidadesTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(InstituicaoLabel)
        Me.Controls.Add(Me.InstituicaoTextBox)
        Me.Controls.Add(TituloDiplomaCertificadoLabel)
        Me.Controls.Add(Me.TituloDiplomaCertificadoTextBox)
        Me.Controls.Add(NacionalidadeLabel)
        Me.Controls.Add(Me.NacionalidadeTextBox)
        Me.Controls.Add(Me.GrupoSexoProfissional)
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(NumRegistroOrgaoClasseLabel)
        Me.Controls.Add(Me.NumRegistroOrgaoClasseTextBox)
        Me.Controls.Add(Me.ProfissionaisBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_profissional"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Profissional"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfissionaisBindingNavigator.ResumeLayout(False)
        Me.ProfissionaisBindingNavigator.PerformLayout()
        Me.GrupoSexoProfissional.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfissionaisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ProfissionaisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NumRegistroOrgaoClasseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SexoMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SexoFRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GrupoSexoProfissional As System.Windows.Forms.GroupBox
    Friend WithEvents NacionalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloDiplomaCertificadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarProfissionalToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarProfissionalToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents InstituicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecialidadesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents CodigoProTextBox As System.Windows.Forms.TextBox
End Class
