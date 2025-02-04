<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_pacientes
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
        Dim CPFLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim EtniaLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim ProfissaoActualLabel As System.Windows.Forms.Label
        Dim ProfissaoAnteriorLabel As System.Windows.Forms.Label
        Dim LocalTrabalhoLabel As System.Windows.Forms.Label
        Dim NaturalidadeLabel As System.Windows.Forms.Label
        Dim NacionalidadeLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim CEPAnteriorLabel As System.Windows.Forms.Label
        Dim EnderecoAnteriorLabel As System.Windows.Forms.Label
        Dim BairroAnteriorLabel As System.Windows.Forms.Label
        Dim CidadeAnteriorLabel As System.Windows.Forms.Label
        Dim EstadoAnteriorLabel As System.Windows.Forms.Label
        Dim PaisAnteriorLabel As System.Windows.Forms.Label
        Dim StatusAltaTipoLabel As System.Windows.Forms.Label
        Dim PlanosSaudeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TransporteLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim ReferenciadoPorLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim CodigoPacienteLabel As System.Windows.Forms.Label
        Dim TelefoneResidencialLabel As System.Windows.Forms.Label
        Dim TelefoneResidencialAnteriorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_pacientes))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.PacientesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter()
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarPacienteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PacientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarPacienteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirPacientesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EtniaTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoSexo = New System.Windows.Forms.GroupBox()
        Me.SexoMRadioButton = New System.Windows.Forms.RadioButton()
        Me.SexoFRadioButton = New System.Windows.Forms.RadioButton()
        Me.EstadoCivilTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissaoActualTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissaoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.LocalTrabalhoTextBox = New System.Windows.Forms.TextBox()
        Me.NaturalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.CEPAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.BairroAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.PaisAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.RegistroAtivoRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegistroInativoRadioButton = New System.Windows.Forms.RadioButton()
        Me.StatusAltaCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoRegistro = New System.Windows.Forms.GroupBox()
        Me.StatusAltaTipoComboBox = New System.Windows.Forms.ComboBox()
        Me.GrupoStatus = New System.Windows.Forms.GroupBox()
        Me.PlanosSaudeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TransporteTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciadoPorTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPacienteTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneResidencialTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneResidencialAnteriorTextBox = New System.Windows.Forms.TextBox()
        CPFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        EtniaLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        ProfissaoActualLabel = New System.Windows.Forms.Label()
        ProfissaoAnteriorLabel = New System.Windows.Forms.Label()
        LocalTrabalhoLabel = New System.Windows.Forms.Label()
        NaturalidadeLabel = New System.Windows.Forms.Label()
        NacionalidadeLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        CEPAnteriorLabel = New System.Windows.Forms.Label()
        EnderecoAnteriorLabel = New System.Windows.Forms.Label()
        BairroAnteriorLabel = New System.Windows.Forms.Label()
        CidadeAnteriorLabel = New System.Windows.Forms.Label()
        EstadoAnteriorLabel = New System.Windows.Forms.Label()
        PaisAnteriorLabel = New System.Windows.Forms.Label()
        StatusAltaTipoLabel = New System.Windows.Forms.Label()
        PlanosSaudeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TransporteLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        ReferenciadoPorLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        CodigoPacienteLabel = New System.Windows.Forms.Label()
        TelefoneResidencialLabel = New System.Windows.Forms.Label()
        TelefoneResidencialAnteriorLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        Me.GrupoSexo.SuspendLayout()
        Me.GrupoRegistro.SuspendLayout()
        Me.GrupoStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(92, 61)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(84, 87)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(14, 116)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(108, 13)
        DataNascimentoLabel.TabIndex = 5
        DataNascimentoLabel.Text = "Data  de nascimento:"
        '
        'EtniaLabel
        '
        EtniaLabel.AutoSize = True
        EtniaLabel.Location = New System.Drawing.Point(88, 229)
        EtniaLabel.Name = "EtniaLabel"
        EtniaLabel.Size = New System.Drawing.Size(34, 13)
        EtniaLabel.TabIndex = 10
        EtniaLabel.Text = "Etnia:"
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.Location = New System.Drawing.Point(234, 229)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(64, 13)
        EstadoCivilLabel.TabIndex = 12
        EstadoCivilLabel.Text = "Estado civil:"
        '
        'ProfissaoActualLabel
        '
        ProfissaoActualLabel.AutoSize = True
        ProfissaoActualLabel.Location = New System.Drawing.Point(36, 255)
        ProfissaoActualLabel.Name = "ProfissaoActualLabel"
        ProfissaoActualLabel.Size = New System.Drawing.Size(86, 13)
        ProfissaoActualLabel.TabIndex = 13
        ProfissaoActualLabel.Text = "Profissão Actual:"
        '
        'ProfissaoAnteriorLabel
        '
        ProfissaoAnteriorLabel.AutoSize = True
        ProfissaoAnteriorLabel.Location = New System.Drawing.Point(30, 281)
        ProfissaoAnteriorLabel.Name = "ProfissaoAnteriorLabel"
        ProfissaoAnteriorLabel.Size = New System.Drawing.Size(92, 13)
        ProfissaoAnteriorLabel.TabIndex = 14
        ProfissaoAnteriorLabel.Text = "Profissão Anterior:"
        '
        'LocalTrabalhoLabel
        '
        LocalTrabalhoLabel.AutoSize = True
        LocalTrabalhoLabel.Location = New System.Drawing.Point(26, 307)
        LocalTrabalhoLabel.Name = "LocalTrabalhoLabel"
        LocalTrabalhoLabel.Size = New System.Drawing.Size(96, 13)
        LocalTrabalhoLabel.TabIndex = 16
        LocalTrabalhoLabel.Text = "Local de Trabalho:"
        '
        'NaturalidadeLabel
        '
        NaturalidadeLabel.AutoSize = True
        NaturalidadeLabel.Location = New System.Drawing.Point(254, 307)
        NaturalidadeLabel.Name = "NaturalidadeLabel"
        NaturalidadeLabel.Size = New System.Drawing.Size(70, 13)
        NaturalidadeLabel.TabIndex = 18
        NaturalidadeLabel.Text = "Naturalidade:"
        '
        'NacionalidadeLabel
        '
        NacionalidadeLabel.AutoSize = True
        NacionalidadeLabel.Location = New System.Drawing.Point(44, 333)
        NacionalidadeLabel.Name = "NacionalidadeLabel"
        NacionalidadeLabel.Size = New System.Drawing.Size(78, 13)
        NacionalidadeLabel.TabIndex = 20
        NacionalidadeLabel.Text = "Nacionalidade:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(293, 333)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 22
        CEPLabel.Text = "CEP:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(66, 385)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 24
        EnderecoLabel.Text = "Endereço:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(265, 359)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 26
        BairroLabel.Text = "Bairro:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(79, 411)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 28
        CidadeLabel.Text = "Cidade:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(259, 411)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 30
        EstadoLabel.Text = "Estado:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(92, 437)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 13)
        PaisLabel.TabIndex = 32
        PaisLabel.Text = "País:"
        '
        'CEPAnteriorLabel
        '
        CEPAnteriorLabel.AutoSize = True
        CEPAnteriorLabel.Location = New System.Drawing.Point(254, 489)
        CEPAnteriorLabel.Name = "CEPAnteriorLabel"
        CEPAnteriorLabel.Size = New System.Drawing.Size(70, 13)
        CEPAnteriorLabel.TabIndex = 34
        CEPAnteriorLabel.Text = "CEP Anterior:"
        '
        'EnderecoAnteriorLabel
        '
        EnderecoAnteriorLabel.AutoSize = True
        EnderecoAnteriorLabel.Location = New System.Drawing.Point(27, 463)
        EnderecoAnteriorLabel.Name = "EnderecoAnteriorLabel"
        EnderecoAnteriorLabel.Size = New System.Drawing.Size(95, 13)
        EnderecoAnteriorLabel.TabIndex = 36
        EnderecoAnteriorLabel.Text = "Endereço Anterior:"
        '
        'BairroAnteriorLabel
        '
        BairroAnteriorLabel.AutoSize = True
        BairroAnteriorLabel.Location = New System.Drawing.Point(46, 489)
        BairroAnteriorLabel.Name = "BairroAnteriorLabel"
        BairroAnteriorLabel.Size = New System.Drawing.Size(76, 13)
        BairroAnteriorLabel.TabIndex = 38
        BairroAnteriorLabel.Text = "Bairro Anterior:"
        '
        'CidadeAnteriorLabel
        '
        CidadeAnteriorLabel.AutoSize = True
        CidadeAnteriorLabel.Location = New System.Drawing.Point(40, 515)
        CidadeAnteriorLabel.Name = "CidadeAnteriorLabel"
        CidadeAnteriorLabel.Size = New System.Drawing.Size(82, 13)
        CidadeAnteriorLabel.TabIndex = 40
        CidadeAnteriorLabel.Text = "Cidade Anterior:"
        '
        'EstadoAnteriorLabel
        '
        EstadoAnteriorLabel.AutoSize = True
        EstadoAnteriorLabel.Location = New System.Drawing.Point(242, 515)
        EstadoAnteriorLabel.Name = "EstadoAnteriorLabel"
        EstadoAnteriorLabel.Size = New System.Drawing.Size(82, 13)
        EstadoAnteriorLabel.TabIndex = 42
        EstadoAnteriorLabel.Text = "Estado Anterior:"
        '
        'PaisAnteriorLabel
        '
        PaisAnteriorLabel.AutoSize = True
        PaisAnteriorLabel.Location = New System.Drawing.Point(53, 541)
        PaisAnteriorLabel.Name = "PaisAnteriorLabel"
        PaisAnteriorLabel.Size = New System.Drawing.Size(71, 13)
        PaisAnteriorLabel.TabIndex = 44
        PaisAnteriorLabel.Text = "País Anterior:"
        '
        'StatusAltaTipoLabel
        '
        StatusAltaTipoLabel.AutoSize = True
        StatusAltaTipoLabel.Location = New System.Drawing.Point(6, 46)
        StatusAltaTipoLabel.Name = "StatusAltaTipoLabel"
        StatusAltaTipoLabel.Size = New System.Drawing.Size(31, 13)
        StatusAltaTipoLabel.TabIndex = 52
        StatusAltaTipoLabel.Text = "Tipo:"
        '
        'PlanosSaudeLabel
        '
        PlanosSaudeLabel.AutoSize = True
        PlanosSaudeLabel.Location = New System.Drawing.Point(234, 541)
        PlanosSaudeLabel.Name = "PlanosSaudeLabel"
        PlanosSaudeLabel.Size = New System.Drawing.Size(86, 13)
        PlanosSaudeLabel.TabIndex = 54
        PlanosSaudeLabel.Text = "Plano de Saúde:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(84, 567)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 55
        EmailLabel.Text = "E-mail:"
        '
        'TransporteLabel
        '
        TransporteLabel.AutoSize = True
        TransporteLabel.Location = New System.Drawing.Point(435, 316)
        TransporteLabel.Name = "TransporteLabel"
        TransporteLabel.Size = New System.Drawing.Size(174, 13)
        TransporteLabel.TabIndex = 56
        TransporteLabel.Text = "Como foi o seu transporte até aqui?"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(21, 203)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(101, 13)
        TelefoneLabel.TabIndex = 57
        TelefoneLabel.Text = "Telefone Comercial:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(257, 203)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 58
        CelularLabel.Text = "Celular:"
        '
        'ReferenciadoPorLabel
        '
        ReferenciadoPorLabel.AutoSize = True
        ReferenciadoPorLabel.Location = New System.Drawing.Point(29, 593)
        ReferenciadoPorLabel.Name = "ReferenciadoPorLabel"
        ReferenciadoPorLabel.Size = New System.Drawing.Size(93, 13)
        ReferenciadoPorLabel.TabIndex = 58
        ReferenciadoPorLabel.Text = "Referenciado Por:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(433, 197)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 60
        ObservacaoLabel.Text = "Observação:"
        '
        'CodigoPacienteLabel
        '
        CodigoPacienteLabel.AutoSize = True
        CodigoPacienteLabel.Location = New System.Drawing.Point(19, 35)
        CodigoPacienteLabel.Name = "CodigoPacienteLabel"
        CodigoPacienteLabel.Size = New System.Drawing.Size(103, 13)
        CodigoPacienteLabel.TabIndex = 62
        CodigoPacienteLabel.Text = "Código do Paciente:"
        '
        'TelefoneResidencialLabel
        '
        TelefoneResidencialLabel.AutoSize = True
        TelefoneResidencialLabel.Location = New System.Drawing.Point(12, 359)
        TelefoneResidencialLabel.Name = "TelefoneResidencialLabel"
        TelefoneResidencialLabel.Size = New System.Drawing.Size(110, 13)
        TelefoneResidencialLabel.TabIndex = 64
        TelefoneResidencialLabel.Text = "Telefone Residencial:"
        '
        'TelefoneResidencialAnteriorLabel
        '
        TelefoneResidencialAnteriorLabel.AutoSize = True
        TelefoneResidencialAnteriorLabel.Location = New System.Drawing.Point(234, 437)
        TelefoneResidencialAnteriorLabel.Name = "TelefoneResidencialAnteriorLabel"
        TelefoneResidencialAnteriorLabel.Size = New System.Drawing.Size(92, 13)
        TelefoneResidencialAnteriorLabel.TabIndex = 66
        TelefoneResidencialAnteriorLabel.Text = "Tel. Res. Anterior:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
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
        Me.TableAdapterManager.LogControleTableAdapter = Me.LogControleTableAdapter
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
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
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'PacientesBindingNavigator
        '
        Me.PacientesBindingNavigator.AddNewItem = Nothing
        Me.PacientesBindingNavigator.BindingSource = Me.PacientesBindingSource
        Me.PacientesBindingNavigator.CountItem = Nothing
        Me.PacientesBindingNavigator.DeleteItem = Nothing
        Me.PacientesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarPacienteToolStripButton, Me.PacientesBindingNavigatorSaveItem, Me.CancelarPacienteToolStripButton, Me.ToolStripSeparator1, Me.ImprimirPacientesToolStripButton})
        Me.PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacientesBindingNavigator.MoveFirstItem = Nothing
        Me.PacientesBindingNavigator.MoveLastItem = Nothing
        Me.PacientesBindingNavigator.MoveNextItem = Nothing
        Me.PacientesBindingNavigator.MovePreviousItem = Nothing
        Me.PacientesBindingNavigator.Name = "PacientesBindingNavigator"
        Me.PacientesBindingNavigator.PositionItem = Nothing
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(717, 25)
        Me.PacientesBindingNavigator.TabIndex = 0
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarPacienteToolStripButton
        '
        Me.AdicionarPacienteToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarPacienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarPacienteToolStripButton.Name = "AdicionarPacienteToolStripButton"
        Me.AdicionarPacienteToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarPacienteToolStripButton.Text = "Adicionar"
        '
        'PacientesBindingNavigatorSaveItem
        '
        Me.PacientesBindingNavigatorSaveItem.Enabled = False
        Me.PacientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PacientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PacientesBindingNavigatorSaveItem.Name = "PacientesBindingNavigatorSaveItem"
        Me.PacientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.PacientesBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarPacienteToolStripButton
        '
        Me.CancelarPacienteToolStripButton.Enabled = False
        Me.CancelarPacienteToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarPacienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarPacienteToolStripButton.Name = "CancelarPacienteToolStripButton"
        Me.CancelarPacienteToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarPacienteToolStripButton.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirPacientesToolStripButton
        '
        Me.ImprimirPacientesToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirPacientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirPacientesToolStripButton.Name = "ImprimirPacientesToolStripButton"
        Me.ImprimirPacientesToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirPacientesToolStripButton.Text = "Imprimir"
        Me.ImprimirPacientesToolStripButton.Visible = False
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CPF", True))
        Me.CPFTextBox.Enabled = False
        Me.CPFTextBox.Location = New System.Drawing.Point(128, 58)
        Me.CPFTextBox.MaxLength = 50
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(128, 84)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(302, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.CustomFormat = ""
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Enabled = False
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(128, 110)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(212, 20)
        Me.DataNascimentoDateTimePicker.TabIndex = 6
        '
        'EtniaTextBox
        '
        Me.EtniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Etnia", True))
        Me.EtniaTextBox.Enabled = False
        Me.EtniaTextBox.Location = New System.Drawing.Point(128, 226)
        Me.EtniaTextBox.Name = "EtniaTextBox"
        Me.EtniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EtniaTextBox.TabIndex = 16
        '
        'GrupoSexo
        '
        Me.GrupoSexo.Controls.Add(Me.SexoMRadioButton)
        Me.GrupoSexo.Controls.Add(Me.SexoFRadioButton)
        Me.GrupoSexo.Enabled = False
        Me.GrupoSexo.Location = New System.Drawing.Point(128, 136)
        Me.GrupoSexo.Name = "GrupoSexo"
        Me.GrupoSexo.Size = New System.Drawing.Size(165, 58)
        Me.GrupoSexo.TabIndex = 8
        Me.GrupoSexo.TabStop = False
        Me.GrupoSexo.Text = "Sexo"
        '
        'SexoMRadioButton
        '
        Me.SexoMRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PacientesBindingSource, "SexoM", True))
        Me.SexoMRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.SexoMRadioButton.Name = "SexoMRadioButton"
        Me.SexoMRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.SexoMRadioButton.TabIndex = 9
        Me.SexoMRadioButton.TabStop = True
        Me.SexoMRadioButton.Text = "Masculino"
        Me.SexoMRadioButton.UseVisualStyleBackColor = True
        '
        'SexoFRadioButton
        '
        Me.SexoFRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PacientesBindingSource, "SexoF", True))
        Me.SexoFRadioButton.Location = New System.Drawing.Point(85, 19)
        Me.SexoFRadioButton.Name = "SexoFRadioButton"
        Me.SexoFRadioButton.Size = New System.Drawing.Size(67, 24)
        Me.SexoFRadioButton.TabIndex = 10
        Me.SexoFRadioButton.TabStop = True
        Me.SexoFRadioButton.Text = "Feminino"
        Me.SexoFRadioButton.UseVisualStyleBackColor = True
        '
        'EstadoCivilTextBox
        '
        Me.EstadoCivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EstadoCivil", True))
        Me.EstadoCivilTextBox.Enabled = False
        Me.EstadoCivilTextBox.Location = New System.Drawing.Point(305, 226)
        Me.EstadoCivilTextBox.Name = "EstadoCivilTextBox"
        Me.EstadoCivilTextBox.Size = New System.Drawing.Size(125, 20)
        Me.EstadoCivilTextBox.TabIndex = 17
        '
        'ProfissaoActualTextBox
        '
        Me.ProfissaoActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ProfissaoActual", True))
        Me.ProfissaoActualTextBox.Enabled = False
        Me.ProfissaoActualTextBox.Location = New System.Drawing.Point(128, 252)
        Me.ProfissaoActualTextBox.Name = "ProfissaoActualTextBox"
        Me.ProfissaoActualTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ProfissaoActualTextBox.TabIndex = 18
        '
        'ProfissaoAnteriorTextBox
        '
        Me.ProfissaoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ProfissaoAnterior", True))
        Me.ProfissaoAnteriorTextBox.Enabled = False
        Me.ProfissaoAnteriorTextBox.Location = New System.Drawing.Point(128, 278)
        Me.ProfissaoAnteriorTextBox.Name = "ProfissaoAnteriorTextBox"
        Me.ProfissaoAnteriorTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ProfissaoAnteriorTextBox.TabIndex = 19
        '
        'LocalTrabalhoTextBox
        '
        Me.LocalTrabalhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "LocalTrabalho", True))
        Me.LocalTrabalhoTextBox.Enabled = False
        Me.LocalTrabalhoTextBox.Location = New System.Drawing.Point(128, 304)
        Me.LocalTrabalhoTextBox.Name = "LocalTrabalhoTextBox"
        Me.LocalTrabalhoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.LocalTrabalhoTextBox.TabIndex = 20
        '
        'NaturalidadeTextBox
        '
        Me.NaturalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Naturalidade", True))
        Me.NaturalidadeTextBox.Enabled = False
        Me.NaturalidadeTextBox.Location = New System.Drawing.Point(330, 304)
        Me.NaturalidadeTextBox.Name = "NaturalidadeTextBox"
        Me.NaturalidadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NaturalidadeTextBox.TabIndex = 21
        '
        'NacionalidadeTextBox
        '
        Me.NacionalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nacionalidade", True))
        Me.NacionalidadeTextBox.Enabled = False
        Me.NacionalidadeTextBox.Location = New System.Drawing.Point(128, 330)
        Me.NacionalidadeTextBox.Name = "NacionalidadeTextBox"
        Me.NacionalidadeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NacionalidadeTextBox.TabIndex = 22
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CEP", True))
        Me.CEPTextBox.Enabled = False
        Me.CEPTextBox.Location = New System.Drawing.Point(330, 330)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPTextBox.TabIndex = 23
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Location = New System.Drawing.Point(128, 382)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EnderecoTextBox.TabIndex = 25
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Bairro", True))
        Me.BairroTextBox.Enabled = False
        Me.BairroTextBox.Location = New System.Drawing.Point(308, 356)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(122, 20)
        Me.BairroTextBox.TabIndex = 27
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Location = New System.Drawing.Point(128, 408)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CidadeTextBox.TabIndex = 29
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Estado", True))
        Me.EstadoTextBox.Enabled = False
        Me.EstadoTextBox.Location = New System.Drawing.Point(308, 408)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(122, 20)
        Me.EstadoTextBox.TabIndex = 31
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Pais", True))
        Me.PaisTextBox.Enabled = False
        Me.PaisTextBox.Location = New System.Drawing.Point(128, 434)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 33
        '
        'CEPAnteriorTextBox
        '
        Me.CEPAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CEPAnterior", True))
        Me.CEPAnteriorTextBox.Enabled = False
        Me.CEPAnteriorTextBox.Location = New System.Drawing.Point(330, 486)
        Me.CEPAnteriorTextBox.Name = "CEPAnteriorTextBox"
        Me.CEPAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPAnteriorTextBox.TabIndex = 40
        '
        'EnderecoAnteriorTextBox
        '
        Me.EnderecoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EnderecoAnterior", True))
        Me.EnderecoAnteriorTextBox.Enabled = False
        Me.EnderecoAnteriorTextBox.Location = New System.Drawing.Point(128, 460)
        Me.EnderecoAnteriorTextBox.Name = "EnderecoAnteriorTextBox"
        Me.EnderecoAnteriorTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EnderecoAnteriorTextBox.TabIndex = 37
        '
        'BairroAnteriorTextBox
        '
        Me.BairroAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "BairroAnterior", True))
        Me.BairroAnteriorTextBox.Enabled = False
        Me.BairroAnteriorTextBox.Location = New System.Drawing.Point(128, 486)
        Me.BairroAnteriorTextBox.Name = "BairroAnteriorTextBox"
        Me.BairroAnteriorTextBox.Size = New System.Drawing.Size(120, 20)
        Me.BairroAnteriorTextBox.TabIndex = 39
        '
        'CidadeAnteriorTextBox
        '
        Me.CidadeAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CidadeAnterior", True))
        Me.CidadeAnteriorTextBox.Enabled = False
        Me.CidadeAnteriorTextBox.Location = New System.Drawing.Point(128, 512)
        Me.CidadeAnteriorTextBox.Name = "CidadeAnteriorTextBox"
        Me.CidadeAnteriorTextBox.Size = New System.Drawing.Size(108, 20)
        Me.CidadeAnteriorTextBox.TabIndex = 41
        '
        'EstadoAnteriorTextBox
        '
        Me.EstadoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EstadoAnterior", True))
        Me.EstadoAnteriorTextBox.Enabled = False
        Me.EstadoAnteriorTextBox.Location = New System.Drawing.Point(330, 512)
        Me.EstadoAnteriorTextBox.Name = "EstadoAnteriorTextBox"
        Me.EstadoAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoAnteriorTextBox.TabIndex = 43
        '
        'PaisAnteriorTextBox
        '
        Me.PaisAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "PaisAnterior", True))
        Me.PaisAnteriorTextBox.Enabled = False
        Me.PaisAnteriorTextBox.Location = New System.Drawing.Point(128, 538)
        Me.PaisAnteriorTextBox.Name = "PaisAnteriorTextBox"
        Me.PaisAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisAnteriorTextBox.TabIndex = 45
        '
        'RegistroAtivoRadioButton
        '
        Me.RegistroAtivoRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PacientesBindingSource, "RegistroAtivo", True))
        Me.RegistroAtivoRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.RegistroAtivoRadioButton.Name = "RegistroAtivoRadioButton"
        Me.RegistroAtivoRadioButton.Size = New System.Drawing.Size(54, 24)
        Me.RegistroAtivoRadioButton.TabIndex = 12
        Me.RegistroAtivoRadioButton.TabStop = True
        Me.RegistroAtivoRadioButton.Text = "Ativo"
        Me.RegistroAtivoRadioButton.UseVisualStyleBackColor = True
        '
        'RegistroInativoRadioButton
        '
        Me.RegistroInativoRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.PacientesBindingSource, "RegistroInativo", True))
        Me.RegistroInativoRadioButton.Location = New System.Drawing.Point(66, 19)
        Me.RegistroInativoRadioButton.Name = "RegistroInativoRadioButton"
        Me.RegistroInativoRadioButton.Size = New System.Drawing.Size(59, 24)
        Me.RegistroInativoRadioButton.TabIndex = 13
        Me.RegistroInativoRadioButton.TabStop = True
        Me.RegistroInativoRadioButton.Text = "Inativo"
        Me.RegistroInativoRadioButton.UseVisualStyleBackColor = True
        '
        'StatusAltaCheckBox
        '
        Me.StatusAltaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PacientesBindingSource, "StatusAlta", True))
        Me.StatusAltaCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.StatusAltaCheckBox.Name = "StatusAltaCheckBox"
        Me.StatusAltaCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.StatusAltaCheckBox.TabIndex = 59
        Me.StatusAltaCheckBox.Text = "Alta"
        Me.StatusAltaCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoRegistro
        '
        Me.GrupoRegistro.Controls.Add(Me.RegistroAtivoRadioButton)
        Me.GrupoRegistro.Controls.Add(Me.RegistroInativoRadioButton)
        Me.GrupoRegistro.Enabled = False
        Me.GrupoRegistro.Location = New System.Drawing.Point(299, 139)
        Me.GrupoRegistro.Name = "GrupoRegistro"
        Me.GrupoRegistro.Size = New System.Drawing.Size(131, 55)
        Me.GrupoRegistro.TabIndex = 11
        Me.GrupoRegistro.TabStop = False
        Me.GrupoRegistro.Text = "Registro"
        '
        'StatusAltaTipoComboBox
        '
        Me.StatusAltaTipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "StatusAltaTipo", True))
        Me.StatusAltaTipoComboBox.Enabled = False
        Me.StatusAltaTipoComboBox.FormattingEnabled = True
        Me.StatusAltaTipoComboBox.Items.AddRange(New Object() {"Completo Restabelecimento", "Abandono", "Impossibilidade Terapêutica", "Intercorrência"})
        Me.StatusAltaTipoComboBox.Location = New System.Drawing.Point(43, 43)
        Me.StatusAltaTipoComboBox.Name = "StatusAltaTipoComboBox"
        Me.StatusAltaTipoComboBox.Size = New System.Drawing.Size(180, 21)
        Me.StatusAltaTipoComboBox.TabIndex = 60
        '
        'GrupoStatus
        '
        Me.GrupoStatus.Controls.Add(Me.StatusAltaCheckBox)
        Me.GrupoStatus.Controls.Add(StatusAltaTipoLabel)
        Me.GrupoStatus.Controls.Add(Me.StatusAltaTipoComboBox)
        Me.GrupoStatus.Enabled = False
        Me.GrupoStatus.Location = New System.Drawing.Point(436, 113)
        Me.GrupoStatus.Name = "GrupoStatus"
        Me.GrupoStatus.Size = New System.Drawing.Size(235, 81)
        Me.GrupoStatus.TabIndex = 58
        Me.GrupoStatus.TabStop = False
        Me.GrupoStatus.Text = "Status"
        '
        'PlanosSaudeTextBox
        '
        Me.PlanosSaudeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "PlanosSaude", True))
        Me.PlanosSaudeTextBox.Enabled = False
        Me.PlanosSaudeTextBox.Location = New System.Drawing.Point(326, 538)
        Me.PlanosSaudeTextBox.Name = "PlanosSaudeTextBox"
        Me.PlanosSaudeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PlanosSaudeTextBox.TabIndex = 55
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(128, 564)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EmailTextBox.TabIndex = 56
        '
        'TransporteTextBox
        '
        Me.TransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Transporte", True))
        Me.TransporteTextBox.Enabled = False
        Me.TransporteTextBox.Location = New System.Drawing.Point(436, 332)
        Me.TransporteTextBox.Multiline = True
        Me.TransporteTextBox.Name = "TransporteTextBox"
        Me.TransporteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TransporteTextBox.Size = New System.Drawing.Size(235, 100)
        Me.TransporteTextBox.TabIndex = 57
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneComercial", True))
        Me.TelefoneTextBox.Enabled = False
        Me.TelefoneTextBox.Location = New System.Drawing.Point(128, 200)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(123, 20)
        Me.TelefoneTextBox.TabIndex = 14
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Celular", True))
        Me.CelularTextBox.Enabled = False
        Me.CelularTextBox.Location = New System.Drawing.Point(305, 200)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CelularTextBox.TabIndex = 15
        '
        'ReferenciadoPorTextBox
        '
        Me.ReferenciadoPorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ReferenciadoPor", True))
        Me.ReferenciadoPorTextBox.Enabled = False
        Me.ReferenciadoPorTextBox.Location = New System.Drawing.Point(128, 590)
        Me.ReferenciadoPorTextBox.MaxLength = 200
        Me.ReferenciadoPorTextBox.Multiline = True
        Me.ReferenciadoPorTextBox.Name = "ReferenciadoPorTextBox"
        Me.ReferenciadoPorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ReferenciadoPorTextBox.Size = New System.Drawing.Size(302, 50)
        Me.ReferenciadoPorTextBox.TabIndex = 59
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Enabled = False
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(436, 213)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(235, 100)
        Me.ObservacaoTextBox.TabIndex = 61
        '
        'CodigoPacienteTextBox
        '
        Me.CodigoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CodigoPaciente", True))
        Me.CodigoPacienteTextBox.Enabled = False
        Me.CodigoPacienteTextBox.Location = New System.Drawing.Point(128, 32)
        Me.CodigoPacienteTextBox.Name = "CodigoPacienteTextBox"
        Me.CodigoPacienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoPacienteTextBox.TabIndex = 63
        Me.CodigoPacienteTextBox.Tag = "N"
        '
        'TelefoneResidencialTextBox
        '
        Me.TelefoneResidencialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneResidencial", True))
        Me.TelefoneResidencialTextBox.Enabled = False
        Me.TelefoneResidencialTextBox.Location = New System.Drawing.Point(128, 356)
        Me.TelefoneResidencialTextBox.Name = "TelefoneResidencialTextBox"
        Me.TelefoneResidencialTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TelefoneResidencialTextBox.TabIndex = 65
        '
        'TelefoneResidencialAnteriorTextBox
        '
        Me.TelefoneResidencialAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneResidencialAnterior", True))
        Me.TelefoneResidencialAnteriorTextBox.Enabled = False
        Me.TelefoneResidencialAnteriorTextBox.Location = New System.Drawing.Point(332, 434)
        Me.TelefoneResidencialAnteriorTextBox.Name = "TelefoneResidencialAnteriorTextBox"
        Me.TelefoneResidencialAnteriorTextBox.Size = New System.Drawing.Size(98, 20)
        Me.TelefoneResidencialAnteriorTextBox.TabIndex = 67
        '
        'form_incluir_pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(734, 317)
        Me.Controls.Add(TelefoneResidencialAnteriorLabel)
        Me.Controls.Add(Me.TelefoneResidencialAnteriorTextBox)
        Me.Controls.Add(TelefoneResidencialLabel)
        Me.Controls.Add(Me.TelefoneResidencialTextBox)
        Me.Controls.Add(CodigoPacienteLabel)
        Me.Controls.Add(Me.CodigoPacienteTextBox)
        Me.Controls.Add(ObservacaoLabel)
        Me.Controls.Add(Me.ObservacaoTextBox)
        Me.Controls.Add(ReferenciadoPorLabel)
        Me.Controls.Add(Me.ReferenciadoPorTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(TransporteLabel)
        Me.Controls.Add(Me.TransporteTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PlanosSaudeLabel)
        Me.Controls.Add(Me.PlanosSaudeTextBox)
        Me.Controls.Add(Me.GrupoStatus)
        Me.Controls.Add(Me.GrupoRegistro)
        Me.Controls.Add(PaisAnteriorLabel)
        Me.Controls.Add(Me.PaisAnteriorTextBox)
        Me.Controls.Add(EstadoAnteriorLabel)
        Me.Controls.Add(Me.EstadoAnteriorTextBox)
        Me.Controls.Add(CidadeAnteriorLabel)
        Me.Controls.Add(Me.CidadeAnteriorTextBox)
        Me.Controls.Add(BairroAnteriorLabel)
        Me.Controls.Add(Me.BairroAnteriorTextBox)
        Me.Controls.Add(EnderecoAnteriorLabel)
        Me.Controls.Add(Me.EnderecoAnteriorTextBox)
        Me.Controls.Add(CEPAnteriorLabel)
        Me.Controls.Add(Me.CEPAnteriorTextBox)
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
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(NacionalidadeLabel)
        Me.Controls.Add(Me.NacionalidadeTextBox)
        Me.Controls.Add(NaturalidadeLabel)
        Me.Controls.Add(Me.NaturalidadeTextBox)
        Me.Controls.Add(LocalTrabalhoLabel)
        Me.Controls.Add(Me.LocalTrabalhoTextBox)
        Me.Controls.Add(ProfissaoAnteriorLabel)
        Me.Controls.Add(Me.ProfissaoAnteriorTextBox)
        Me.Controls.Add(ProfissaoActualLabel)
        Me.Controls.Add(Me.ProfissaoActualTextBox)
        Me.Controls.Add(EstadoCivilLabel)
        Me.Controls.Add(Me.EstadoCivilTextBox)
        Me.Controls.Add(Me.GrupoSexo)
        Me.Controls.Add(EtniaLabel)
        Me.Controls.Add(Me.EtniaTextBox)
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFTextBox)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_pacientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        Me.GrupoSexo.ResumeLayout(False)
        Me.GrupoRegistro.ResumeLayout(False)
        Me.GrupoStatus.ResumeLayout(False)
        Me.GrupoStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents PacientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EtniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoSexo As System.Windows.Forms.GroupBox
    Friend WithEvents EstadoCivilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissaoActualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissaoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalTrabalhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NaturalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NacionalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistroAtivoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RegistroInativoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StatusAltaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents StatusAltaTipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GrupoStatus As System.Windows.Forms.GroupBox
    Friend WithEvents PlanosSaudeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarPacienteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarPacienteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents ReferenciadoPorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneResidencialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneResidencialAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SexoFRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirPacientesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PacientesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter

End Class
