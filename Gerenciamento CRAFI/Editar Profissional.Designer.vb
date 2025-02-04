<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_profissional
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
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim EspecialidadesLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim InstituicaoLabel As System.Windows.Forms.Label
        Dim TituloDiplomaCertificadoLabel As System.Windows.Forms.Label
        Dim NacionalidadeLabel As System.Windows.Forms.Label
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CodigoProLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_profissional))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.ProfissionaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ProfissionaisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirProfissionalToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NumRegistroOrgaoClasseTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        Me.EspecialidadesTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.InstituicaoTextBox = New System.Windows.Forms.TextBox()
        Me.TituloDiplomaCertificadoTextBox = New System.Windows.Forms.TextBox()
        Me.NacionalidadeTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoSexoProfissional = New System.Windows.Forms.GroupBox()
        Me.SexoMRadioButton = New System.Windows.Forms.RadioButton()
        Me.SexoFRadioButton = New System.Windows.Forms.RadioButton()
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.CodigoProTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissionalPanel = New System.Windows.Forms.Panel()
        NumRegistroOrgaoClasseLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        EspecialidadesLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        InstituicaoLabel = New System.Windows.Forms.Label()
        TituloDiplomaCertificadoLabel = New System.Windows.Forms.Label()
        NacionalidadeLabel = New System.Windows.Forms.Label()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CodigoProLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfissionaisBindingNavigator.SuspendLayout()
        Me.GrupoSexoProfissional.SuspendLayout()
        Me.ProfissionalPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumRegistroOrgaoClasseLabel
        '
        NumRegistroOrgaoClasseLabel.AutoSize = True
        NumRegistroOrgaoClasseLabel.Location = New System.Drawing.Point(3, 41)
        NumRegistroOrgaoClasseLabel.Name = "NumRegistroOrgaoClasseLabel"
        NumRegistroOrgaoClasseLabel.Size = New System.Drawing.Size(147, 13)
        NumRegistroOrgaoClasseLabel.TabIndex = 1
        NumRegistroOrgaoClasseLabel.Text = "Registro em Órgão de Classe:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(77, 651)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 63
        ObservacoesLabel.Text = "Observações:"
        '
        'EspecialidadesLabel
        '
        EspecialidadesLabel.AutoSize = True
        EspecialidadesLabel.Location = New System.Drawing.Point(69, 545)
        EspecialidadesLabel.Name = "EspecialidadesLabel"
        EspecialidadesLabel.Size = New System.Drawing.Size(81, 13)
        EspecialidadesLabel.TabIndex = 61
        EspecialidadesLabel.Text = "Especialidades:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(112, 519)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 13)
        EmailLabel.TabIndex = 59
        EmailLabel.Text = "E-mail:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(263, 493)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(42, 13)
        CelularLabel.TabIndex = 57
        CelularLabel.Text = "Celular:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(98, 493)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 55
        TelefoneLabel.Text = "Telefone:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(275, 467)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(32, 13)
        PaisLabel.TabIndex = 53
        PaisLabel.Text = "País:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Location = New System.Drawing.Point(107, 467)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(43, 13)
        EstadoLabel.TabIndex = 51
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Location = New System.Drawing.Point(262, 441)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(43, 13)
        CidadeLabel.TabIndex = 49
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(113, 441)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 47
        BairroLabel.Text = "Bairro:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(94, 415)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 44
        EnderecoLabel.Text = "Endereço:"
        '
        'InstituicaoLabel
        '
        InstituicaoLabel.AutoSize = True
        InstituicaoLabel.Location = New System.Drawing.Point(92, 309)
        InstituicaoLabel.Name = "InstituicaoLabel"
        InstituicaoLabel.Size = New System.Drawing.Size(58, 13)
        InstituicaoLabel.TabIndex = 42
        InstituicaoLabel.Text = "Instituição:"
        '
        'TituloDiplomaCertificadoLabel
        '
        TituloDiplomaCertificadoLabel.AutoSize = True
        TituloDiplomaCertificadoLabel.Location = New System.Drawing.Point(14, 203)
        TituloDiplomaCertificadoLabel.Name = "TituloDiplomaCertificadoLabel"
        TituloDiplomaCertificadoLabel.Size = New System.Drawing.Size(136, 13)
        TituloDiplomaCertificadoLabel.TabIndex = 40
        TituloDiplomaCertificadoLabel.Text = "Título/Diploma/Certificado:"
        '
        'NacionalidadeLabel
        '
        NacionalidadeLabel.AutoSize = True
        NacionalidadeLabel.Location = New System.Drawing.Point(72, 177)
        NacionalidadeLabel.Name = "NacionalidadeLabel"
        NacionalidadeLabel.Size = New System.Drawing.Size(78, 13)
        NacionalidadeLabel.TabIndex = 38
        NacionalidadeLabel.Text = "Nacionalidade:"
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(43, 96)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(107, 13)
        DataNascimentoLabel.TabIndex = 36
        DataNascimentoLabel.Text = "Data de Nascimento:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(112, 67)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 34
        NomeLabel.Text = "Nome:"
        '
        'CodigoProLabel
        '
        CodigoProLabel.AutoSize = True
        CodigoProLabel.Location = New System.Drawing.Point(36, 15)
        CodigoProLabel.Name = "CodigoProLabel"
        CodigoProLabel.Size = New System.Drawing.Size(114, 13)
        CodigoProLabel.TabIndex = 64
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
        Me.ProfissionaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfissionaisBindingNavigatorSaveItem, Me.ImprimirToolStripSeparator, Me.ImprimirProfissionalToolStripButton})
        Me.ProfissionaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfissionaisBindingNavigator.MoveFirstItem = Nothing
        Me.ProfissionaisBindingNavigator.MoveLastItem = Nothing
        Me.ProfissionaisBindingNavigator.MoveNextItem = Nothing
        Me.ProfissionaisBindingNavigator.MovePreviousItem = Nothing
        Me.ProfissionaisBindingNavigator.Name = "ProfissionaisBindingNavigator"
        Me.ProfissionaisBindingNavigator.PositionItem = Nothing
        Me.ProfissionaisBindingNavigator.Size = New System.Drawing.Size(455, 25)
        Me.ProfissionaisBindingNavigator.TabIndex = 0
        Me.ProfissionaisBindingNavigator.Text = "BindingNavigator1"
        '
        'ProfissionaisBindingNavigatorSaveItem
        '
        Me.ProfissionaisBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfissionaisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfissionaisBindingNavigatorSaveItem.Name = "ProfissionaisBindingNavigatorSaveItem"
        Me.ProfissionaisBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.ProfissionaisBindingNavigatorSaveItem.Text = "Salvar"
        '
        'ImprimirToolStripSeparator
        '
        Me.ImprimirToolStripSeparator.Name = "ImprimirToolStripSeparator"
        Me.ImprimirToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirProfissionalToolStripButton
        '
        Me.ImprimirProfissionalToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirProfissionalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirProfissionalToolStripButton.Name = "ImprimirProfissionalToolStripButton"
        Me.ImprimirProfissionalToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirProfissionalToolStripButton.Text = "Imprimir"
        '
        'NumRegistroOrgaoClasseTextBox
        '
        Me.NumRegistroOrgaoClasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "NumRegistroOrgaoClasse", True))
        Me.NumRegistroOrgaoClasseTextBox.Location = New System.Drawing.Point(156, 38)
        Me.NumRegistroOrgaoClasseTextBox.Name = "NumRegistroOrgaoClasseTextBox"
        Me.NumRegistroOrgaoClasseTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NumRegistroOrgaoClasseTextBox.TabIndex = 2
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(156, 648)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(255, 100)
        Me.ObservacoesTextBox.TabIndex = 64
        '
        'EspecialidadesTextBox
        '
        Me.EspecialidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Especialidades", True))
        Me.EspecialidadesTextBox.Location = New System.Drawing.Point(156, 542)
        Me.EspecialidadesTextBox.Multiline = True
        Me.EspecialidadesTextBox.Name = "EspecialidadesTextBox"
        Me.EspecialidadesTextBox.Size = New System.Drawing.Size(255, 100)
        Me.EspecialidadesTextBox.TabIndex = 62
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(156, 516)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(255, 20)
        Me.EmailTextBox.TabIndex = 60
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(311, 490)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CelularTextBox.TabIndex = 58
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(156, 490)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneTextBox.TabIndex = 56
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(311, 464)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaisTextBox.TabIndex = 54
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(156, 464)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EstadoTextBox.TabIndex = 52
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Cidade", True))
        Me.CidadeTextBox.Location = New System.Drawing.Point(311, 438)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CidadeTextBox.TabIndex = 50
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(156, 438)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BairroTextBox.TabIndex = 48
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(156, 412)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(255, 20)
        Me.EnderecoTextBox.TabIndex = 46
        '
        'InstituicaoTextBox
        '
        Me.InstituicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Instituicao", True))
        Me.InstituicaoTextBox.Location = New System.Drawing.Point(156, 306)
        Me.InstituicaoTextBox.Multiline = True
        Me.InstituicaoTextBox.Name = "InstituicaoTextBox"
        Me.InstituicaoTextBox.Size = New System.Drawing.Size(255, 100)
        Me.InstituicaoTextBox.TabIndex = 45
        '
        'TituloDiplomaCertificadoTextBox
        '
        Me.TituloDiplomaCertificadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "TituloDiplomaCertificado", True))
        Me.TituloDiplomaCertificadoTextBox.Location = New System.Drawing.Point(156, 200)
        Me.TituloDiplomaCertificadoTextBox.Multiline = True
        Me.TituloDiplomaCertificadoTextBox.Name = "TituloDiplomaCertificadoTextBox"
        Me.TituloDiplomaCertificadoTextBox.Size = New System.Drawing.Size(255, 100)
        Me.TituloDiplomaCertificadoTextBox.TabIndex = 43
        '
        'NacionalidadeTextBox
        '
        Me.NacionalidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Nacionalidade", True))
        Me.NacionalidadeTextBox.Location = New System.Drawing.Point(156, 174)
        Me.NacionalidadeTextBox.Name = "NacionalidadeTextBox"
        Me.NacionalidadeTextBox.Size = New System.Drawing.Size(163, 20)
        Me.NacionalidadeTextBox.TabIndex = 41
        '
        'GrupoSexoProfissional
        '
        Me.GrupoSexoProfissional.Controls.Add(Me.SexoMRadioButton)
        Me.GrupoSexoProfissional.Controls.Add(Me.SexoFRadioButton)
        Me.GrupoSexoProfissional.Location = New System.Drawing.Point(156, 116)
        Me.GrupoSexoProfissional.Name = "GrupoSexoProfissional"
        Me.GrupoSexoProfissional.Size = New System.Drawing.Size(163, 52)
        Me.GrupoSexoProfissional.TabIndex = 39
        Me.GrupoSexoProfissional.TabStop = False
        Me.GrupoSexoProfissional.Text = "Sexo"
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
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProfissionaisBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(156, 90)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(255, 20)
        Me.DataNascimentoDateTimePicker.TabIndex = 37
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(156, 64)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(255, 20)
        Me.NomeTextBox.TabIndex = 35
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'CodigoProTextBox
        '
        Me.CodigoProTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfissionaisBindingSource, "CodigoPro", True))
        Me.CodigoProTextBox.Enabled = False
        Me.CodigoProTextBox.Location = New System.Drawing.Point(156, 12)
        Me.CodigoProTextBox.Name = "CodigoProTextBox"
        Me.CodigoProTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoProTextBox.TabIndex = 65
        '
        'ProfissionalPanel
        '
        Me.ProfissionalPanel.AutoScroll = True
        Me.ProfissionalPanel.Controls.Add(NumRegistroOrgaoClasseLabel)
        Me.ProfissionalPanel.Controls.Add(CodigoProLabel)
        Me.ProfissionalPanel.Controls.Add(Me.NumRegistroOrgaoClasseTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.CodigoProTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.NomeTextBox)
        Me.ProfissionalPanel.Controls.Add(ObservacoesLabel)
        Me.ProfissionalPanel.Controls.Add(NomeLabel)
        Me.ProfissionalPanel.Controls.Add(Me.ObservacoesTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.ProfissionalPanel.Controls.Add(EspecialidadesLabel)
        Me.ProfissionalPanel.Controls.Add(DataNascimentoLabel)
        Me.ProfissionalPanel.Controls.Add(Me.EspecialidadesTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.GrupoSexoProfissional)
        Me.ProfissionalPanel.Controls.Add(EmailLabel)
        Me.ProfissionalPanel.Controls.Add(Me.NacionalidadeTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.EmailTextBox)
        Me.ProfissionalPanel.Controls.Add(NacionalidadeLabel)
        Me.ProfissionalPanel.Controls.Add(CelularLabel)
        Me.ProfissionalPanel.Controls.Add(Me.TituloDiplomaCertificadoTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.CelularTextBox)
        Me.ProfissionalPanel.Controls.Add(TituloDiplomaCertificadoLabel)
        Me.ProfissionalPanel.Controls.Add(TelefoneLabel)
        Me.ProfissionalPanel.Controls.Add(Me.InstituicaoTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.TelefoneTextBox)
        Me.ProfissionalPanel.Controls.Add(InstituicaoLabel)
        Me.ProfissionalPanel.Controls.Add(PaisLabel)
        Me.ProfissionalPanel.Controls.Add(Me.EnderecoTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.PaisTextBox)
        Me.ProfissionalPanel.Controls.Add(EnderecoLabel)
        Me.ProfissionalPanel.Controls.Add(EstadoLabel)
        Me.ProfissionalPanel.Controls.Add(Me.BairroTextBox)
        Me.ProfissionalPanel.Controls.Add(Me.EstadoTextBox)
        Me.ProfissionalPanel.Controls.Add(BairroLabel)
        Me.ProfissionalPanel.Controls.Add(CidadeLabel)
        Me.ProfissionalPanel.Controls.Add(Me.CidadeTextBox)
        Me.ProfissionalPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfissionalPanel.Location = New System.Drawing.Point(0, 25)
        Me.ProfissionalPanel.Name = "ProfissionalPanel"
        Me.ProfissionalPanel.Size = New System.Drawing.Size(455, 227)
        Me.ProfissionalPanel.TabIndex = 66
        '
        'form_editar_profissional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(455, 252)
        Me.Controls.Add(Me.ProfissionalPanel)
        Me.Controls.Add(Me.ProfissionaisBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_profissional"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Profissional"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfissionaisBindingNavigator.ResumeLayout(False)
        Me.ProfissionaisBindingNavigator.PerformLayout()
        Me.GrupoSexoProfissional.ResumeLayout(False)
        Me.ProfissionalPanel.ResumeLayout(False)
        Me.ProfissionalPanel.PerformLayout()
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
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecialidadesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CelularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InstituicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloDiplomaCertificadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NacionalidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoSexoProfissional As System.Windows.Forms.GroupBox
    Friend WithEvents SexoMRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SexoFRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImprimirToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirProfissionalToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents CodigoProTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissionalPanel As System.Windows.Forms.Panel
End Class
