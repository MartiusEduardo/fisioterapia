<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_paciente
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
        Dim TelefoneResidencialAnteriorLabel As System.Windows.Forms.Label
        Dim TelefoneResidencialLabel As System.Windows.Forms.Label
        Dim CodigoPacienteLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim ReferenciadoPorLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim TransporteLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PlanosSaudeLabel As System.Windows.Forms.Label
        Dim StatusAltaTipoLabel As System.Windows.Forms.Label
        Dim PaisAnteriorLabel As System.Windows.Forms.Label
        Dim EstadoAnteriorLabel As System.Windows.Forms.Label
        Dim CidadeAnteriorLabel As System.Windows.Forms.Label
        Dim BairroAnteriorLabel As System.Windows.Forms.Label
        Dim EnderecoAnteriorLabel As System.Windows.Forms.Label
        Dim CEPAnteriorLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim NacionalidadeLabel As System.Windows.Forms.Label
        Dim NaturalidadeLabel As System.Windows.Forms.Label
        Dim LocalTrabalhoLabel As System.Windows.Forms.Label
        Dim ProfissaoAnteriorLabel As System.Windows.Forms.Label
        Dim ProfissaoActualLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim EtniaLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_paciente))
        Me.PacientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.PacientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirPacientesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PacientesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.TelefoneResidencialAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneResidencialTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPacienteTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciadoPorTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.TransporteTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PlanosSaudeTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoStatus = New System.Windows.Forms.GroupBox()
        Me.StatusAltaCheckBox = New System.Windows.Forms.CheckBox()
        Me.StatusAltaTipoComboBox = New System.Windows.Forms.ComboBox()
        Me.GrupoRegistro = New System.Windows.Forms.GroupBox()
        Me.RegistroAtivoRadioButton = New System.Windows.Forms.RadioButton()
        Me.RegistroInativoRadioButton = New System.Windows.Forms.RadioButton()
        Me.PaisAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.BairroAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.CEPAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.NaturalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.LocalTrabalhoTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissaoAnteriorTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissaoActualTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoCivilTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoSexo = New System.Windows.Forms.GroupBox()
        Me.SexoMRadioButton = New System.Windows.Forms.RadioButton()
        Me.SexoFRadioButton = New System.Windows.Forms.RadioButton()
        Me.EtniaTextBox = New System.Windows.Forms.TextBox()
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.PacientePanel = New System.Windows.Forms.Panel()
        TelefoneResidencialAnteriorLabel = New System.Windows.Forms.Label()
        TelefoneResidencialLabel = New System.Windows.Forms.Label()
        CodigoPacienteLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        ReferenciadoPorLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        TransporteLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PlanosSaudeLabel = New System.Windows.Forms.Label()
        StatusAltaTipoLabel = New System.Windows.Forms.Label()
        PaisAnteriorLabel = New System.Windows.Forms.Label()
        EstadoAnteriorLabel = New System.Windows.Forms.Label()
        CidadeAnteriorLabel = New System.Windows.Forms.Label()
        BairroAnteriorLabel = New System.Windows.Forms.Label()
        EnderecoAnteriorLabel = New System.Windows.Forms.Label()
        CEPAnteriorLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        NacionalidadeLabel = New System.Windows.Forms.Label()
        NaturalidadeLabel = New System.Windows.Forms.Label()
        LocalTrabalhoLabel = New System.Windows.Forms.Label()
        ProfissaoAnteriorLabel = New System.Windows.Forms.Label()
        ProfissaoActualLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        EtniaLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacientesBindingNavigator.SuspendLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoStatus.SuspendLayout()
        Me.GrupoRegistro.SuspendLayout()
        Me.GrupoSexo.SuspendLayout()
        Me.PacientePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TelefoneResidencialAnteriorLabel
        '
        TelefoneResidencialAnteriorLabel.AutoSize = True
        TelefoneResidencialAnteriorLabel.Location = New System.Drawing.Point(225, 411)
        TelefoneResidencialAnteriorLabel.Name = "TelefoneResidencialAnteriorLabel"
        TelefoneResidencialAnteriorLabel.Size = New System.Drawing.Size(92, 13)
        TelefoneResidencialAnteriorLabel.TabIndex = 133
        TelefoneResidencialAnteriorLabel.Text = "Tel. Res. Anterior:"
        '
        'TelefoneResidencialLabel
        '
        TelefoneResidencialLabel.AutoSize = True
        TelefoneResidencialLabel.Location = New System.Drawing.Point(3, 333)
        TelefoneResidencialLabel.Name = "TelefoneResidencialLabel"
        TelefoneResidencialLabel.Size = New System.Drawing.Size(110, 13)
        TelefoneResidencialLabel.TabIndex = 131
        TelefoneResidencialLabel.Text = "Telefone Residencial:"
        '
        'CodigoPacienteLabel
        '
        CodigoPacienteLabel.AutoSize = True
        CodigoPacienteLabel.Location = New System.Drawing.Point(10, 9)
        CodigoPacienteLabel.Name = "CodigoPacienteLabel"
        CodigoPacienteLabel.Size = New System.Drawing.Size(103, 13)
        CodigoPacienteLabel.TabIndex = 129
        CodigoPacienteLabel.Text = "Código do Paciente:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(424, 171)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 127
        ObservacaoLabel.Text = "Observação:"
        '
        'ReferenciadoPorLabel
        '
        ReferenciadoPorLabel.AutoSize = True
        ReferenciadoPorLabel.Location = New System.Drawing.Point(20, 567)
        ReferenciadoPorLabel.Name = "ReferenciadoPorLabel"
        ReferenciadoPorLabel.Size = New System.Drawing.Size(93, 13)
        ReferenciadoPorLabel.TabIndex = 123
        ReferenciadoPorLabel.Text = "Referenciado Por:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(248, 177)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 124
        CelularLabel.Text = "Celular:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(12, 177)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(101, 13)
        TelefoneLabel.TabIndex = 121
        TelefoneLabel.Text = "Telefone Comercial:"
        '
        'TransporteLabel
        '
        TransporteLabel.AutoSize = True
        TransporteLabel.Location = New System.Drawing.Point(426, 290)
        TransporteLabel.Name = "TransporteLabel"
        TransporteLabel.Size = New System.Drawing.Size(174, 13)
        TransporteLabel.TabIndex = 119
        TransporteLabel.Text = "Como foi o seu transporte até aqui?"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(75, 541)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 117
        EmailLabel.Text = "E-mail:"
        '
        'PlanosSaudeLabel
        '
        PlanosSaudeLabel.AutoSize = True
        PlanosSaudeLabel.Location = New System.Drawing.Point(225, 515)
        PlanosSaudeLabel.Name = "PlanosSaudeLabel"
        PlanosSaudeLabel.Size = New System.Drawing.Size(86, 13)
        PlanosSaudeLabel.TabIndex = 116
        PlanosSaudeLabel.Text = "Plano de Saúde:"
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
        'PaisAnteriorLabel
        '
        PaisAnteriorLabel.AutoSize = True
        PaisAnteriorLabel.Location = New System.Drawing.Point(44, 515)
        PaisAnteriorLabel.Name = "PaisAnteriorLabel"
        PaisAnteriorLabel.Size = New System.Drawing.Size(71, 13)
        PaisAnteriorLabel.TabIndex = 114
        PaisAnteriorLabel.Text = "País Anterior:"
        '
        'EstadoAnteriorLabel
        '
        EstadoAnteriorLabel.AutoSize = True
        EstadoAnteriorLabel.Location = New System.Drawing.Point(233, 489)
        EstadoAnteriorLabel.Name = "EstadoAnteriorLabel"
        EstadoAnteriorLabel.Size = New System.Drawing.Size(82, 13)
        EstadoAnteriorLabel.TabIndex = 112
        EstadoAnteriorLabel.Text = "Estado Anterior:"
        '
        'CidadeAnteriorLabel
        '
        CidadeAnteriorLabel.AutoSize = True
        CidadeAnteriorLabel.Location = New System.Drawing.Point(31, 489)
        CidadeAnteriorLabel.Name = "CidadeAnteriorLabel"
        CidadeAnteriorLabel.Size = New System.Drawing.Size(82, 13)
        CidadeAnteriorLabel.TabIndex = 109
        CidadeAnteriorLabel.Text = "Cidade Anterior:"
        '
        'BairroAnteriorLabel
        '
        BairroAnteriorLabel.AutoSize = True
        BairroAnteriorLabel.Location = New System.Drawing.Point(37, 463)
        BairroAnteriorLabel.Name = "BairroAnteriorLabel"
        BairroAnteriorLabel.Size = New System.Drawing.Size(76, 13)
        BairroAnteriorLabel.TabIndex = 107
        BairroAnteriorLabel.Text = "Bairro Anterior:"
        '
        'EnderecoAnteriorLabel
        '
        EnderecoAnteriorLabel.AutoSize = True
        EnderecoAnteriorLabel.Location = New System.Drawing.Point(18, 437)
        EnderecoAnteriorLabel.Name = "EnderecoAnteriorLabel"
        EnderecoAnteriorLabel.Size = New System.Drawing.Size(95, 13)
        EnderecoAnteriorLabel.TabIndex = 105
        EnderecoAnteriorLabel.Text = "Endereço Anterior:"
        '
        'CEPAnteriorLabel
        '
        CEPAnteriorLabel.AutoSize = True
        CEPAnteriorLabel.Location = New System.Drawing.Point(245, 463)
        CEPAnteriorLabel.Name = "CEPAnteriorLabel"
        CEPAnteriorLabel.Size = New System.Drawing.Size(70, 13)
        CEPAnteriorLabel.TabIndex = 104
        CEPAnteriorLabel.Text = "CEP Anterior:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(83, 411)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 13)
        PaisLabel.TabIndex = 102
        PaisLabel.Text = "País:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(250, 385)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 100
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(70, 385)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 98
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(256, 333)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 96
        BairroLabel.Text = "Bairro:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(57, 359)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 94
        EnderecoLabel.Text = "Endereço:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(284, 307)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 91
        CEPLabel.Text = "CEP:"
        '
        'NacionalidadeLabel
        '
        NacionalidadeLabel.AutoSize = True
        NacionalidadeLabel.Location = New System.Drawing.Point(35, 307)
        NacionalidadeLabel.Name = "NacionalidadeLabel"
        NacionalidadeLabel.Size = New System.Drawing.Size(78, 13)
        NacionalidadeLabel.TabIndex = 88
        NacionalidadeLabel.Text = "Nacionalidade:"
        '
        'NaturalidadeLabel
        '
        NaturalidadeLabel.AutoSize = True
        NaturalidadeLabel.Location = New System.Drawing.Point(245, 281)
        NaturalidadeLabel.Name = "NaturalidadeLabel"
        NaturalidadeLabel.Size = New System.Drawing.Size(70, 13)
        NaturalidadeLabel.TabIndex = 85
        NaturalidadeLabel.Text = "Naturalidade:"
        '
        'LocalTrabalhoLabel
        '
        LocalTrabalhoLabel.AutoSize = True
        LocalTrabalhoLabel.Location = New System.Drawing.Point(17, 281)
        LocalTrabalhoLabel.Name = "LocalTrabalhoLabel"
        LocalTrabalhoLabel.Size = New System.Drawing.Size(96, 13)
        LocalTrabalhoLabel.TabIndex = 83
        LocalTrabalhoLabel.Text = "Local de Trabalho:"
        '
        'ProfissaoAnteriorLabel
        '
        ProfissaoAnteriorLabel.AutoSize = True
        ProfissaoAnteriorLabel.Location = New System.Drawing.Point(21, 255)
        ProfissaoAnteriorLabel.Name = "ProfissaoAnteriorLabel"
        ProfissaoAnteriorLabel.Size = New System.Drawing.Size(92, 13)
        ProfissaoAnteriorLabel.TabIndex = 79
        ProfissaoAnteriorLabel.Text = "Profissão Anterior:"
        '
        'ProfissaoActualLabel
        '
        ProfissaoActualLabel.AutoSize = True
        ProfissaoActualLabel.Location = New System.Drawing.Point(27, 229)
        ProfissaoActualLabel.Name = "ProfissaoActualLabel"
        ProfissaoActualLabel.Size = New System.Drawing.Size(86, 13)
        ProfissaoActualLabel.TabIndex = 78
        ProfissaoActualLabel.Text = "Profissão Actual:"
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.Location = New System.Drawing.Point(225, 203)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(64, 13)
        EstadoCivilLabel.TabIndex = 77
        EstadoCivilLabel.Text = "Estado civil:"
        '
        'EtniaLabel
        '
        EtniaLabel.AutoSize = True
        EtniaLabel.Location = New System.Drawing.Point(79, 203)
        EtniaLabel.Name = "EtniaLabel"
        EtniaLabel.Size = New System.Drawing.Size(34, 13)
        EtniaLabel.TabIndex = 75
        EtniaLabel.Text = "Etnia:"
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(5, 90)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(108, 13)
        DataNascimentoLabel.TabIndex = 72
        DataNascimentoLabel.Text = "Data  de nascimento:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(75, 61)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 70
        NomeLabel.Text = "Nome:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(83, 35)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 68
        CPFLabel.Text = "CPF:"
        '
        'PacientesBindingNavigator
        '
        Me.PacientesBindingNavigator.AddNewItem = Nothing
        Me.PacientesBindingNavigator.BindingSource = Me.PacientesBindingSource
        Me.PacientesBindingNavigator.CountItem = Nothing
        Me.PacientesBindingNavigator.DeleteItem = Nothing
        Me.PacientesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PacientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesBindingNavigatorSaveItem, Me.ImprimirToolStripSeparator, Me.ImprimirPacientesToolStripButton})
        Me.PacientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PacientesBindingNavigator.MoveFirstItem = Nothing
        Me.PacientesBindingNavigator.MoveLastItem = Nothing
        Me.PacientesBindingNavigator.MoveNextItem = Nothing
        Me.PacientesBindingNavigator.MovePreviousItem = Nothing
        Me.PacientesBindingNavigator.Name = "PacientesBindingNavigator"
        Me.PacientesBindingNavigator.PositionItem = Nothing
        Me.PacientesBindingNavigator.Size = New System.Drawing.Size(694, 25)
        Me.PacientesBindingNavigator.TabIndex = 0
        Me.PacientesBindingNavigator.Text = "BindingNavigator1"
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesBindingNavigatorSaveItem
        '
        Me.PacientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PacientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PacientesBindingNavigatorSaveItem.Name = "PacientesBindingNavigatorSaveItem"
        Me.PacientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.PacientesBindingNavigatorSaveItem.Text = "Salvar"
        '
        'ImprimirToolStripSeparator
        '
        Me.ImprimirToolStripSeparator.Name = "ImprimirToolStripSeparator"
        Me.ImprimirToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirPacientesToolStripButton
        '
        Me.ImprimirPacientesToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirPacientesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirPacientesToolStripButton.Name = "ImprimirPacientesToolStripButton"
        Me.ImprimirPacientesToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirPacientesToolStripButton.Text = "Imprimir"
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
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
        'TelefoneResidencialAnteriorTextBox
        '
        Me.TelefoneResidencialAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneResidencialAnterior", True))
        Me.TelefoneResidencialAnteriorTextBox.Location = New System.Drawing.Point(323, 408)
        Me.TelefoneResidencialAnteriorTextBox.Name = "TelefoneResidencialAnteriorTextBox"
        Me.TelefoneResidencialAnteriorTextBox.Size = New System.Drawing.Size(98, 20)
        Me.TelefoneResidencialAnteriorTextBox.TabIndex = 134
        '
        'TelefoneResidencialTextBox
        '
        Me.TelefoneResidencialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneResidencial", True))
        Me.TelefoneResidencialTextBox.Location = New System.Drawing.Point(119, 330)
        Me.TelefoneResidencialTextBox.Name = "TelefoneResidencialTextBox"
        Me.TelefoneResidencialTextBox.Size = New System.Drawing.Size(120, 20)
        Me.TelefoneResidencialTextBox.TabIndex = 132
        '
        'CodigoPacienteTextBox
        '
        Me.CodigoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CodigoPaciente", True))
        Me.CodigoPacienteTextBox.Enabled = False
        Me.CodigoPacienteTextBox.Location = New System.Drawing.Point(119, 6)
        Me.CodigoPacienteTextBox.Name = "CodigoPacienteTextBox"
        Me.CodigoPacienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoPacienteTextBox.TabIndex = 130
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Observacao", True))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(427, 187)
        Me.ObservacaoTextBox.Multiline = True
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(235, 100)
        Me.ObservacaoTextBox.TabIndex = 128
        '
        'ReferenciadoPorTextBox
        '
        Me.ReferenciadoPorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ReferenciadoPor", True))
        Me.ReferenciadoPorTextBox.Location = New System.Drawing.Point(119, 564)
        Me.ReferenciadoPorTextBox.Name = "ReferenciadoPorTextBox"
        Me.ReferenciadoPorTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ReferenciadoPorTextBox.TabIndex = 126
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(296, 174)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CelularTextBox.TabIndex = 81
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "TelefoneComercial", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(119, 174)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(123, 20)
        Me.TelefoneTextBox.TabIndex = 80
        '
        'TransporteTextBox
        '
        Me.TransporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Transporte", True))
        Me.TransporteTextBox.Location = New System.Drawing.Point(427, 306)
        Me.TransporteTextBox.Multiline = True
        Me.TransporteTextBox.Name = "TransporteTextBox"
        Me.TransporteTextBox.Size = New System.Drawing.Size(235, 100)
        Me.TransporteTextBox.TabIndex = 122
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(119, 538)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EmailTextBox.TabIndex = 120
        '
        'PlanosSaudeTextBox
        '
        Me.PlanosSaudeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "PlanosSaude", True))
        Me.PlanosSaudeTextBox.Location = New System.Drawing.Point(317, 512)
        Me.PlanosSaudeTextBox.Name = "PlanosSaudeTextBox"
        Me.PlanosSaudeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PlanosSaudeTextBox.TabIndex = 118
        '
        'GrupoStatus
        '
        Me.GrupoStatus.Controls.Add(Me.StatusAltaCheckBox)
        Me.GrupoStatus.Controls.Add(StatusAltaTipoLabel)
        Me.GrupoStatus.Controls.Add(Me.StatusAltaTipoComboBox)
        Me.GrupoStatus.Location = New System.Drawing.Point(427, 87)
        Me.GrupoStatus.Name = "GrupoStatus"
        Me.GrupoStatus.Size = New System.Drawing.Size(235, 81)
        Me.GrupoStatus.TabIndex = 125
        Me.GrupoStatus.TabStop = False
        Me.GrupoStatus.Text = "Status"
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
        'StatusAltaTipoComboBox
        '
        Me.StatusAltaTipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "StatusAltaTipo", True))
        Me.StatusAltaTipoComboBox.FormattingEnabled = True
        Me.StatusAltaTipoComboBox.Items.AddRange(New Object() {"Completo Restabelecimento", "Abandono", "Impossibilidade Terapêutica", "Intercorrência"})
        Me.StatusAltaTipoComboBox.Location = New System.Drawing.Point(43, 43)
        Me.StatusAltaTipoComboBox.Name = "StatusAltaTipoComboBox"
        Me.StatusAltaTipoComboBox.Size = New System.Drawing.Size(180, 21)
        Me.StatusAltaTipoComboBox.TabIndex = 60
        '
        'GrupoRegistro
        '
        Me.GrupoRegistro.Controls.Add(Me.RegistroAtivoRadioButton)
        Me.GrupoRegistro.Controls.Add(Me.RegistroInativoRadioButton)
        Me.GrupoRegistro.Location = New System.Drawing.Point(290, 113)
        Me.GrupoRegistro.Name = "GrupoRegistro"
        Me.GrupoRegistro.Size = New System.Drawing.Size(131, 55)
        Me.GrupoRegistro.TabIndex = 76
        Me.GrupoRegistro.TabStop = False
        Me.GrupoRegistro.Text = "Registro"
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
        'PaisAnteriorTextBox
        '
        Me.PaisAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "PaisAnterior", True))
        Me.PaisAnteriorTextBox.Location = New System.Drawing.Point(119, 512)
        Me.PaisAnteriorTextBox.Name = "PaisAnteriorTextBox"
        Me.PaisAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisAnteriorTextBox.TabIndex = 115
        '
        'EstadoAnteriorTextBox
        '
        Me.EstadoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EstadoAnterior", True))
        Me.EstadoAnteriorTextBox.Location = New System.Drawing.Point(321, 486)
        Me.EstadoAnteriorTextBox.Name = "EstadoAnteriorTextBox"
        Me.EstadoAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoAnteriorTextBox.TabIndex = 113
        '
        'CidadeAnteriorTextBox
        '
        Me.CidadeAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CidadeAnterior", True))
        Me.CidadeAnteriorTextBox.Location = New System.Drawing.Point(119, 486)
        Me.CidadeAnteriorTextBox.Name = "CidadeAnteriorTextBox"
        Me.CidadeAnteriorTextBox.Size = New System.Drawing.Size(108, 20)
        Me.CidadeAnteriorTextBox.TabIndex = 111
        '
        'BairroAnteriorTextBox
        '
        Me.BairroAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "BairroAnterior", True))
        Me.BairroAnteriorTextBox.Location = New System.Drawing.Point(119, 460)
        Me.BairroAnteriorTextBox.Name = "BairroAnteriorTextBox"
        Me.BairroAnteriorTextBox.Size = New System.Drawing.Size(120, 20)
        Me.BairroAnteriorTextBox.TabIndex = 108
        '
        'EnderecoAnteriorTextBox
        '
        Me.EnderecoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EnderecoAnterior", True))
        Me.EnderecoAnteriorTextBox.Location = New System.Drawing.Point(119, 434)
        Me.EnderecoAnteriorTextBox.Name = "EnderecoAnteriorTextBox"
        Me.EnderecoAnteriorTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EnderecoAnteriorTextBox.TabIndex = 106
        '
        'CEPAnteriorTextBox
        '
        Me.CEPAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CEPAnterior", True))
        Me.CEPAnteriorTextBox.Location = New System.Drawing.Point(321, 460)
        Me.CEPAnteriorTextBox.Name = "CEPAnteriorTextBox"
        Me.CEPAnteriorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPAnteriorTextBox.TabIndex = 110
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(119, 408)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 103
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(299, 382)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(122, 20)
        Me.EstadoTextBox.TabIndex = 101
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(119, 382)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CidadeTextBox.TabIndex = 99
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(299, 330)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(122, 20)
        Me.BairroTextBox.TabIndex = 97
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(119, 356)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(302, 20)
        Me.EnderecoTextBox.TabIndex = 95
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(321, 304)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPTextBox.TabIndex = 93
        '
        'NacionalidadeTextBox
        '
        Me.NacionalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nacionalidade", True))
        Me.NacionalidadeTextBox.Location = New System.Drawing.Point(119, 304)
        Me.NacionalidadeTextBox.Name = "NacionalidadeTextBox"
        Me.NacionalidadeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NacionalidadeTextBox.TabIndex = 92
        '
        'NaturalidadeTextBox
        '
        Me.NaturalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Naturalidade", True))
        Me.NaturalidadeTextBox.Location = New System.Drawing.Point(321, 278)
        Me.NaturalidadeTextBox.Name = "NaturalidadeTextBox"
        Me.NaturalidadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NaturalidadeTextBox.TabIndex = 90
        '
        'LocalTrabalhoTextBox
        '
        Me.LocalTrabalhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "LocalTrabalho", True))
        Me.LocalTrabalhoTextBox.Location = New System.Drawing.Point(119, 278)
        Me.LocalTrabalhoTextBox.Name = "LocalTrabalhoTextBox"
        Me.LocalTrabalhoTextBox.Size = New System.Drawing.Size(120, 20)
        Me.LocalTrabalhoTextBox.TabIndex = 89
        '
        'ProfissaoAnteriorTextBox
        '
        Me.ProfissaoAnteriorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ProfissaoAnterior", True))
        Me.ProfissaoAnteriorTextBox.Location = New System.Drawing.Point(119, 252)
        Me.ProfissaoAnteriorTextBox.Name = "ProfissaoAnteriorTextBox"
        Me.ProfissaoAnteriorTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ProfissaoAnteriorTextBox.TabIndex = 87
        '
        'ProfissaoActualTextBox
        '
        Me.ProfissaoActualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ProfissaoActual", True))
        Me.ProfissaoActualTextBox.Location = New System.Drawing.Point(119, 226)
        Me.ProfissaoActualTextBox.Name = "ProfissaoActualTextBox"
        Me.ProfissaoActualTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ProfissaoActualTextBox.TabIndex = 86
        '
        'EstadoCivilTextBox
        '
        Me.EstadoCivilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "EstadoCivil", True))
        Me.EstadoCivilTextBox.Location = New System.Drawing.Point(296, 200)
        Me.EstadoCivilTextBox.Name = "EstadoCivilTextBox"
        Me.EstadoCivilTextBox.Size = New System.Drawing.Size(125, 20)
        Me.EstadoCivilTextBox.TabIndex = 84
        '
        'GrupoSexo
        '
        Me.GrupoSexo.Controls.Add(Me.SexoMRadioButton)
        Me.GrupoSexo.Controls.Add(Me.SexoFRadioButton)
        Me.GrupoSexo.Location = New System.Drawing.Point(119, 110)
        Me.GrupoSexo.Name = "GrupoSexo"
        Me.GrupoSexo.Size = New System.Drawing.Size(165, 58)
        Me.GrupoSexo.TabIndex = 74
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
        'EtniaTextBox
        '
        Me.EtniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Etnia", True))
        Me.EtniaTextBox.Location = New System.Drawing.Point(119, 200)
        Me.EtniaTextBox.Name = "EtniaTextBox"
        Me.EtniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EtniaTextBox.TabIndex = 82
        '
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.CustomFormat = ""
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(119, 84)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(212, 20)
        Me.DataNascimentoDateTimePicker.TabIndex = 73
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(119, 58)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(302, 20)
        Me.NomeTextBox.TabIndex = 71
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "CPF", True))
        Me.CPFTextBox.Location = New System.Drawing.Point(119, 32)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFTextBox.TabIndex = 69
        '
        'PacientePanel
        '
        Me.PacientePanel.AutoScroll = True
        Me.PacientePanel.Controls.Add(CodigoPacienteLabel)
        Me.PacientePanel.Controls.Add(TelefoneResidencialAnteriorLabel)
        Me.PacientePanel.Controls.Add(Me.CPFTextBox)
        Me.PacientePanel.Controls.Add(Me.TelefoneResidencialAnteriorTextBox)
        Me.PacientePanel.Controls.Add(CPFLabel)
        Me.PacientePanel.Controls.Add(TelefoneResidencialLabel)
        Me.PacientePanel.Controls.Add(Me.NomeTextBox)
        Me.PacientePanel.Controls.Add(Me.TelefoneResidencialTextBox)
        Me.PacientePanel.Controls.Add(NomeLabel)
        Me.PacientePanel.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.PacientePanel.Controls.Add(Me.CodigoPacienteTextBox)
        Me.PacientePanel.Controls.Add(DataNascimentoLabel)
        Me.PacientePanel.Controls.Add(ObservacaoLabel)
        Me.PacientePanel.Controls.Add(Me.EtniaTextBox)
        Me.PacientePanel.Controls.Add(Me.ObservacaoTextBox)
        Me.PacientePanel.Controls.Add(EtniaLabel)
        Me.PacientePanel.Controls.Add(ReferenciadoPorLabel)
        Me.PacientePanel.Controls.Add(Me.GrupoSexo)
        Me.PacientePanel.Controls.Add(Me.ReferenciadoPorTextBox)
        Me.PacientePanel.Controls.Add(Me.EstadoCivilTextBox)
        Me.PacientePanel.Controls.Add(CelularLabel)
        Me.PacientePanel.Controls.Add(EstadoCivilLabel)
        Me.PacientePanel.Controls.Add(Me.CelularTextBox)
        Me.PacientePanel.Controls.Add(Me.ProfissaoActualTextBox)
        Me.PacientePanel.Controls.Add(TelefoneLabel)
        Me.PacientePanel.Controls.Add(ProfissaoActualLabel)
        Me.PacientePanel.Controls.Add(Me.TelefoneTextBox)
        Me.PacientePanel.Controls.Add(Me.ProfissaoAnteriorTextBox)
        Me.PacientePanel.Controls.Add(TransporteLabel)
        Me.PacientePanel.Controls.Add(ProfissaoAnteriorLabel)
        Me.PacientePanel.Controls.Add(Me.TransporteTextBox)
        Me.PacientePanel.Controls.Add(Me.LocalTrabalhoTextBox)
        Me.PacientePanel.Controls.Add(EmailLabel)
        Me.PacientePanel.Controls.Add(LocalTrabalhoLabel)
        Me.PacientePanel.Controls.Add(Me.EmailTextBox)
        Me.PacientePanel.Controls.Add(Me.NaturalidadeTextBox)
        Me.PacientePanel.Controls.Add(PlanosSaudeLabel)
        Me.PacientePanel.Controls.Add(NaturalidadeLabel)
        Me.PacientePanel.Controls.Add(Me.PlanosSaudeTextBox)
        Me.PacientePanel.Controls.Add(Me.NacionalidadeTextBox)
        Me.PacientePanel.Controls.Add(Me.GrupoStatus)
        Me.PacientePanel.Controls.Add(NacionalidadeLabel)
        Me.PacientePanel.Controls.Add(Me.GrupoRegistro)
        Me.PacientePanel.Controls.Add(Me.CEPTextBox)
        Me.PacientePanel.Controls.Add(PaisAnteriorLabel)
        Me.PacientePanel.Controls.Add(CEPLabel)
        Me.PacientePanel.Controls.Add(Me.PaisAnteriorTextBox)
        Me.PacientePanel.Controls.Add(Me.EnderecoTextBox)
        Me.PacientePanel.Controls.Add(EstadoAnteriorLabel)
        Me.PacientePanel.Controls.Add(EnderecoLabel)
        Me.PacientePanel.Controls.Add(Me.EstadoAnteriorTextBox)
        Me.PacientePanel.Controls.Add(Me.BairroTextBox)
        Me.PacientePanel.Controls.Add(CidadeAnteriorLabel)
        Me.PacientePanel.Controls.Add(BairroLabel)
        Me.PacientePanel.Controls.Add(Me.CidadeAnteriorTextBox)
        Me.PacientePanel.Controls.Add(Me.CidadeTextBox)
        Me.PacientePanel.Controls.Add(BairroAnteriorLabel)
        Me.PacientePanel.Controls.Add(CidadeLabel)
        Me.PacientePanel.Controls.Add(Me.BairroAnteriorTextBox)
        Me.PacientePanel.Controls.Add(Me.EstadoTextBox)
        Me.PacientePanel.Controls.Add(EnderecoAnteriorLabel)
        Me.PacientePanel.Controls.Add(EstadoLabel)
        Me.PacientePanel.Controls.Add(Me.EnderecoAnteriorTextBox)
        Me.PacientePanel.Controls.Add(Me.PaisTextBox)
        Me.PacientePanel.Controls.Add(CEPAnteriorLabel)
        Me.PacientePanel.Controls.Add(PaisLabel)
        Me.PacientePanel.Controls.Add(Me.CEPAnteriorTextBox)
        Me.PacientePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PacientePanel.Location = New System.Drawing.Point(0, 25)
        Me.PacientePanel.Name = "PacientePanel"
        Me.PacientePanel.Size = New System.Drawing.Size(694, 262)
        Me.PacientePanel.TabIndex = 135
        '
        'form_editar_paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(694, 287)
        Me.Controls.Add(Me.PacientePanel)
        Me.Controls.Add(Me.PacientesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_paciente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Paciente"
        CType(Me.PacientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacientesBindingNavigator.ResumeLayout(False)
        Me.PacientesBindingNavigator.PerformLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoStatus.ResumeLayout(False)
        Me.GrupoStatus.PerformLayout()
        Me.GrupoRegistro.ResumeLayout(False)
        Me.GrupoSexo.ResumeLayout(False)
        Me.PacientePanel.ResumeLayout(False)
        Me.PacientePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PacientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents PacientesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImprimirToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirPacientesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents TelefoneResidencialAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneResidencialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciadoPorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlanosSaudeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoStatus As System.Windows.Forms.GroupBox
    Friend WithEvents StatusAltaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StatusAltaTipoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GrupoRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents RegistroAtivoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RegistroInativoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PaisAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NacionalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NaturalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalTrabalhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissaoAnteriorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissaoActualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoCivilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoSexo As System.Windows.Forms.GroupBox
    Friend WithEvents SexoMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SexoFRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EtniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PacientePanel As System.Windows.Forms.Panel
End Class
