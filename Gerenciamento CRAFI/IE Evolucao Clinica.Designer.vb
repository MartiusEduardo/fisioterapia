<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_evolucao_clinica
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
        Dim DataLabel As System.Windows.Forms.Label
        Dim QueixaPrincipalLabel As System.Windows.Forms.Label
        Dim HistoriaDoencaAtualLabel As System.Windows.Forms.Label
        Dim ExameFisicoLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim CIDLabel As System.Windows.Forms.Label
        Dim TratamentoLabel As System.Windows.Forms.Label
        Dim CodigoEvolucaoClinicaLabel As System.Windows.Forms.Label
        Dim NumRegistroProfissionalLabel As System.Windows.Forms.Label
        Dim NumeroProntuarioLabel As System.Windows.Forms.Label
        Dim ProfissionalLabel As System.Windows.Forms.Label
        Dim AssinaturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_evolucao_clinica))
        Me.EvolucaoClinicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.EvolucaoClinicaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.EvolucaoClinicaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarECToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EvolucaoClinicaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarECToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirEvolucaoClinicaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.QueixaPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaDoencaAtualTextBox = New System.Windows.Forms.TextBox()
        Me.ExameFisicoTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.TratamentoTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.CodigoEvolucaoClinicaTextBox = New System.Windows.Forms.TextBox()
        Me.NumRegistroProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumeroProntuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.ProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.AssinaturaTextBox = New System.Windows.Forms.TextBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        CPFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        QueixaPrincipalLabel = New System.Windows.Forms.Label()
        HistoriaDoencaAtualLabel = New System.Windows.Forms.Label()
        ExameFisicoLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        CIDLabel = New System.Windows.Forms.Label()
        TratamentoLabel = New System.Windows.Forms.Label()
        CodigoEvolucaoClinicaLabel = New System.Windows.Forms.Label()
        NumRegistroProfissionalLabel = New System.Windows.Forms.Label()
        NumeroProntuarioLabel = New System.Windows.Forms.Label()
        ProfissionalLabel = New System.Windows.Forms.Label()
        AssinaturaLabel = New System.Windows.Forms.Label()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvolucaoClinicaBindingNavigator.SuspendLayout()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(97, 150)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(90, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF do Paciente:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(149, 176)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(154, 205)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'QueixaPrincipalLabel
        '
        QueixaPrincipalLabel.AutoSize = True
        QueixaPrincipalLabel.Location = New System.Drawing.Point(101, 228)
        QueixaPrincipalLabel.Name = "QueixaPrincipalLabel"
        QueixaPrincipalLabel.Size = New System.Drawing.Size(86, 13)
        QueixaPrincipalLabel.TabIndex = 7
        QueixaPrincipalLabel.Text = "Queixa Principal:"
        '
        'HistoriaDoencaAtualLabel
        '
        HistoriaDoencaAtualLabel.AutoSize = True
        HistoriaDoencaAtualLabel.Location = New System.Drawing.Point(59, 334)
        HistoriaDoencaAtualLabel.Name = "HistoriaDoencaAtualLabel"
        HistoriaDoencaAtualLabel.Size = New System.Drawing.Size(128, 13)
        HistoriaDoencaAtualLabel.TabIndex = 9
        HistoriaDoencaAtualLabel.Text = "História da Doença Atual:"
        '
        'ExameFisicoLabel
        '
        ExameFisicoLabel.AutoSize = True
        ExameFisicoLabel.Location = New System.Drawing.Point(115, 440)
        ExameFisicoLabel.Name = "ExameFisicoLabel"
        ExameFisicoLabel.Size = New System.Drawing.Size(74, 13)
        ExameFisicoLabel.TabIndex = 11
        ExameFisicoLabel.Text = "Exame Físico:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(152, 546)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(35, 13)
        CIFLabel.TabIndex = 13
        CIFLabel.Text = "C.I.F.:"
        '
        'CIDLabel
        '
        CIDLabel.AutoSize = True
        CIDLabel.Location = New System.Drawing.Point(150, 572)
        CIDLabel.Name = "CIDLabel"
        CIDLabel.Size = New System.Drawing.Size(37, 13)
        CIDLabel.TabIndex = 15
        CIDLabel.Text = "C.I.D.:"
        '
        'TratamentoLabel
        '
        TratamentoLabel.AutoSize = True
        TratamentoLabel.Location = New System.Drawing.Point(123, 598)
        TratamentoLabel.Name = "TratamentoLabel"
        TratamentoLabel.Size = New System.Drawing.Size(64, 13)
        TratamentoLabel.TabIndex = 17
        TratamentoLabel.Text = "Tratamento:"
        '
        'CodigoEvolucaoClinicaLabel
        '
        CodigoEvolucaoClinicaLabel.AutoSize = True
        CodigoEvolucaoClinicaLabel.Location = New System.Drawing.Point(45, 44)
        CodigoEvolucaoClinicaLabel.Name = "CodigoEvolucaoClinicaLabel"
        CodigoEvolucaoClinicaLabel.Size = New System.Drawing.Size(142, 13)
        CodigoEvolucaoClinicaLabel.TabIndex = 19
        CodigoEvolucaoClinicaLabel.Text = "Código da Evolução Clínica:"
        '
        'NumRegistroProfissionalLabel
        '
        NumRegistroProfissionalLabel.AutoSize = True
        NumRegistroProfissionalLabel.Location = New System.Drawing.Point(12, 70)
        NumRegistroProfissionalLabel.Name = "NumRegistroProfissionalLabel"
        NumRegistroProfissionalLabel.Size = New System.Drawing.Size(175, 13)
        NumRegistroProfissionalLabel.TabIndex = 21
        NumRegistroProfissionalLabel.Text = "Número de Registro do Profissional:"
        '
        'NumeroProntuarioLabel
        '
        NumeroProntuarioLabel.AutoSize = True
        NumeroProntuarioLabel.Location = New System.Drawing.Point(74, 124)
        NumeroProntuarioLabel.Name = "NumeroProntuarioLabel"
        NumeroProntuarioLabel.Size = New System.Drawing.Size(113, 13)
        NumeroProntuarioLabel.TabIndex = 25
        NumeroProntuarioLabel.Text = "Número do Prontuário:"
        '
        'ProfissionalLabel
        '
        ProfissionalLabel.AutoSize = True
        ProfissionalLabel.Location = New System.Drawing.Point(78, 97)
        ProfissionalLabel.Name = "ProfissionalLabel"
        ProfissionalLabel.Size = New System.Drawing.Size(109, 13)
        ProfissionalLabel.TabIndex = 26
        ProfissionalLabel.Text = "Nome do Profissional:"
        '
        'AssinaturaLabel
        '
        AssinaturaLabel.AutoSize = True
        AssinaturaLabel.Location = New System.Drawing.Point(128, 704)
        AssinaturaLabel.Name = "AssinaturaLabel"
        AssinaturaLabel.Size = New System.Drawing.Size(59, 13)
        AssinaturaLabel.TabIndex = 27
        AssinaturaLabel.Text = "Assinatura:"
        '
        'EvolucaoClinicaBindingSource
        '
        Me.EvolucaoClinicaBindingSource.DataMember = "EvolucaoClinica"
        Me.EvolucaoClinicaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvolucaoClinicaTableAdapter
        '
        Me.EvolucaoClinicaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EvolucaoClinicaTableAdapter = Me.EvolucaoClinicaTableAdapter
        Me.TableAdapterManager.ExamesComplementaresTableAdapter = Nothing
        Me.TableAdapterManager.ImpostosSobreVendasTableAdapter = Nothing
        Me.TableAdapterManager.LogControleTableAdapter = Nothing
        Me.TableAdapterManager.LogEntradaTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.ProfissionaisTableAdapter = Nothing
        Me.TableAdapterManager.ReceitaTableAdapter = Nothing
        Me.TableAdapterManager.ServicosConveniosTableAdapter = Nothing
        Me.TableAdapterManager.ServicosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EvolucaoClinicaBindingNavigator
        '
        Me.EvolucaoClinicaBindingNavigator.AddNewItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.BindingSource = Me.EvolucaoClinicaBindingSource
        Me.EvolucaoClinicaBindingNavigator.CountItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.DeleteItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EvolucaoClinicaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarECToolStripButton, Me.EvolucaoClinicaBindingNavigatorSaveItem, Me.CancelarECToolStripButton, Me.ToolStripSeparator1, Me.ImprimirEvolucaoClinicaToolStripButton})
        Me.EvolucaoClinicaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EvolucaoClinicaBindingNavigator.MoveFirstItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MoveLastItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MoveNextItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MovePreviousItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.Name = "EvolucaoClinicaBindingNavigator"
        Me.EvolucaoClinicaBindingNavigator.PositionItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.Size = New System.Drawing.Size(473, 25)
        Me.EvolucaoClinicaBindingNavigator.TabIndex = 0
        Me.EvolucaoClinicaBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarECToolStripButton
        '
        Me.AdicionarECToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarECToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarECToolStripButton.Name = "AdicionarECToolStripButton"
        Me.AdicionarECToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarECToolStripButton.Text = "Adicionar"
        '
        'EvolucaoClinicaBindingNavigatorSaveItem
        '
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Enabled = False
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EvolucaoClinicaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Name = "EvolucaoClinicaBindingNavigatorSaveItem"
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarECToolStripButton
        '
        Me.CancelarECToolStripButton.Enabled = False
        Me.CancelarECToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarECToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarECToolStripButton.Name = "CancelarECToolStripButton"
        Me.CancelarECToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarECToolStripButton.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirEvolucaoClinicaToolStripButton
        '
        Me.ImprimirEvolucaoClinicaToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirEvolucaoClinicaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirEvolucaoClinicaToolStripButton.Name = "ImprimirEvolucaoClinicaToolStripButton"
        Me.ImprimirEvolucaoClinicaToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirEvolucaoClinicaToolStripButton.Text = "Imprimir"
        Me.ImprimirEvolucaoClinicaToolStripButton.Visible = False
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CPF", True))
        Me.CPFTextBox.Enabled = False
        Me.CPFTextBox.Location = New System.Drawing.Point(193, 147)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CPFTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Location = New System.Drawing.Point(193, 173)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EvolucaoClinicaBindingSource, "Data", True))
        Me.DataDateTimePicker.Enabled = False
        Me.DataDateTimePicker.Location = New System.Drawing.Point(193, 199)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(250, 20)
        Me.DataDateTimePicker.TabIndex = 6
        '
        'QueixaPrincipalTextBox
        '
        Me.QueixaPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "QueixaPrincipal", True))
        Me.QueixaPrincipalTextBox.Enabled = False
        Me.QueixaPrincipalTextBox.Location = New System.Drawing.Point(193, 225)
        Me.QueixaPrincipalTextBox.Multiline = True
        Me.QueixaPrincipalTextBox.Name = "QueixaPrincipalTextBox"
        Me.QueixaPrincipalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.QueixaPrincipalTextBox.Size = New System.Drawing.Size(250, 100)
        Me.QueixaPrincipalTextBox.TabIndex = 8
        '
        'HistoriaDoencaAtualTextBox
        '
        Me.HistoriaDoencaAtualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "HistoriaDoencaAtual", True))
        Me.HistoriaDoencaAtualTextBox.Enabled = False
        Me.HistoriaDoencaAtualTextBox.Location = New System.Drawing.Point(193, 331)
        Me.HistoriaDoencaAtualTextBox.Multiline = True
        Me.HistoriaDoencaAtualTextBox.Name = "HistoriaDoencaAtualTextBox"
        Me.HistoriaDoencaAtualTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HistoriaDoencaAtualTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaDoencaAtualTextBox.TabIndex = 10
        '
        'ExameFisicoTextBox
        '
        Me.ExameFisicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "ExameFisico", True))
        Me.ExameFisicoTextBox.Enabled = False
        Me.ExameFisicoTextBox.Location = New System.Drawing.Point(193, 437)
        Me.ExameFisicoTextBox.Multiline = True
        Me.ExameFisicoTextBox.Name = "ExameFisicoTextBox"
        Me.ExameFisicoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ExameFisicoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.ExameFisicoTextBox.TabIndex = 12
        '
        'CIFTextBox
        '
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CIF", True))
        Me.CIFTextBox.Enabled = False
        Me.CIFTextBox.Location = New System.Drawing.Point(193, 543)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.Size = New System.Drawing.Size(250, 20)
        Me.CIFTextBox.TabIndex = 14
        '
        'CIDTextBox
        '
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CID", True))
        Me.CIDTextBox.Enabled = False
        Me.CIDTextBox.Location = New System.Drawing.Point(193, 569)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(250, 20)
        Me.CIDTextBox.TabIndex = 16
        '
        'TratamentoTextBox
        '
        Me.TratamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Tratamento", True))
        Me.TratamentoTextBox.Enabled = False
        Me.TratamentoTextBox.Location = New System.Drawing.Point(193, 595)
        Me.TratamentoTextBox.Multiline = True
        Me.TratamentoTextBox.Name = "TratamentoTextBox"
        Me.TratamentoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TratamentoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.TratamentoTextBox.TabIndex = 18
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'CodigoEvolucaoClinicaTextBox
        '
        Me.CodigoEvolucaoClinicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "codigoEvolucaoClinica", True))
        Me.CodigoEvolucaoClinicaTextBox.Enabled = False
        Me.CodigoEvolucaoClinicaTextBox.Location = New System.Drawing.Point(193, 41)
        Me.CodigoEvolucaoClinicaTextBox.Name = "CodigoEvolucaoClinicaTextBox"
        Me.CodigoEvolucaoClinicaTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CodigoEvolucaoClinicaTextBox.TabIndex = 20
        Me.CodigoEvolucaoClinicaTextBox.Tag = "N"
        '
        'NumRegistroProfissionalComboBox
        '
        Me.NumRegistroProfissionalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NumRegistroProfissionalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NumRegistroProfissionalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "NumRegistroProfissional", True))
        Me.NumRegistroProfissionalComboBox.DataSource = Me.ProfissionaisBindingSource
        Me.NumRegistroProfissionalComboBox.DisplayMember = "NumRegistroOrgaoClasse"
        Me.NumRegistroProfissionalComboBox.Enabled = False
        Me.NumRegistroProfissionalComboBox.FormattingEnabled = True
        Me.NumRegistroProfissionalComboBox.Location = New System.Drawing.Point(193, 67)
        Me.NumRegistroProfissionalComboBox.Name = "NumRegistroProfissionalComboBox"
        Me.NumRegistroProfissionalComboBox.Size = New System.Drawing.Size(125, 21)
        Me.NumRegistroProfissionalComboBox.TabIndex = 22
        Me.NumRegistroProfissionalComboBox.ValueMember = "NumRegistroOrgaoClasse"
        '
        'ProfissionaisBindingSource
        '
        Me.ProfissionaisBindingSource.DataMember = "Profissionais"
        Me.ProfissionaisBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'NumeroProntuarioTextBox
        '
        Me.NumeroProntuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "NumeroProntuario", True))
        Me.NumeroProntuarioTextBox.Enabled = False
        Me.NumeroProntuarioTextBox.Location = New System.Drawing.Point(193, 121)
        Me.NumeroProntuarioTextBox.Name = "NumeroProntuarioTextBox"
        Me.NumeroProntuarioTextBox.Size = New System.Drawing.Size(125, 20)
        Me.NumeroProntuarioTextBox.TabIndex = 26
        Me.NumeroProntuarioTextBox.Tag = "N"
        '
        'ProfissionaisTableAdapter
        '
        Me.ProfissionaisTableAdapter.ClearBeforeFill = True
        '
        'ProfissionalComboBox
        '
        Me.ProfissionalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProfissionalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProfissionalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Profissional", True))
        Me.ProfissionalComboBox.DataSource = Me.ProfissionaisBindingSource
        Me.ProfissionalComboBox.DisplayMember = "Nome"
        Me.ProfissionalComboBox.Enabled = False
        Me.ProfissionalComboBox.FormattingEnabled = True
        Me.ProfissionalComboBox.Location = New System.Drawing.Point(193, 94)
        Me.ProfissionalComboBox.Name = "ProfissionalComboBox"
        Me.ProfissionalComboBox.Size = New System.Drawing.Size(250, 21)
        Me.ProfissionalComboBox.TabIndex = 27
        Me.ProfissionalComboBox.ValueMember = "Nome"
        '
        'AssinaturaTextBox
        '
        Me.AssinaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Assinatura", True))
        Me.AssinaturaTextBox.Enabled = False
        Me.AssinaturaTextBox.Location = New System.Drawing.Point(193, 701)
        Me.AssinaturaTextBox.Name = "AssinaturaTextBox"
        Me.AssinaturaTextBox.Size = New System.Drawing.Size(250, 20)
        Me.AssinaturaTextBox.TabIndex = 28
        Me.AssinaturaTextBox.Tag = "N"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'form_incluir_evolucao_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(490, 314)
        Me.Controls.Add(AssinaturaLabel)
        Me.Controls.Add(Me.AssinaturaTextBox)
        Me.Controls.Add(ProfissionalLabel)
        Me.Controls.Add(Me.ProfissionalComboBox)
        Me.Controls.Add(NumeroProntuarioLabel)
        Me.Controls.Add(Me.NumeroProntuarioTextBox)
        Me.Controls.Add(NumRegistroProfissionalLabel)
        Me.Controls.Add(Me.NumRegistroProfissionalComboBox)
        Me.Controls.Add(CodigoEvolucaoClinicaLabel)
        Me.Controls.Add(Me.CodigoEvolucaoClinicaTextBox)
        Me.Controls.Add(TratamentoLabel)
        Me.Controls.Add(Me.TratamentoTextBox)
        Me.Controls.Add(CIDLabel)
        Me.Controls.Add(Me.CIDTextBox)
        Me.Controls.Add(CIFLabel)
        Me.Controls.Add(Me.CIFTextBox)
        Me.Controls.Add(ExameFisicoLabel)
        Me.Controls.Add(Me.ExameFisicoTextBox)
        Me.Controls.Add(HistoriaDoencaAtualLabel)
        Me.Controls.Add(Me.HistoriaDoencaAtualTextBox)
        Me.Controls.Add(QueixaPrincipalLabel)
        Me.Controls.Add(Me.QueixaPrincipalTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFTextBox)
        Me.Controls.Add(Me.EvolucaoClinicaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_evolucao_clinica"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evolução Clínica"
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvolucaoClinicaBindingNavigator.ResumeLayout(False)
        Me.EvolucaoClinicaBindingNavigator.PerformLayout()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents EvolucaoClinicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvolucaoClinicaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvolucaoClinicaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarECToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EvolucaoClinicaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarECToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents QueixaPrincipalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaDoencaAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExameFisicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TratamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents CodigoEvolucaoClinicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumRegistroProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumeroProntuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents ProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AssinaturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirEvolucaoClinicaToolStripButton As System.Windows.Forms.ToolStripButton
End Class
