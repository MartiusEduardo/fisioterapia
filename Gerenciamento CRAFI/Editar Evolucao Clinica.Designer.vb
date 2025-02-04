<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_editar_evolucao_clinica
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
        Dim TratamentoLabel As System.Windows.Forms.Label
        Dim CIDLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim ExameFisicoLabel As System.Windows.Forms.Label
        Dim HistoriaDoencaAtualLabel As System.Windows.Forms.Label
        Dim QueixaPrincipalLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim NumeroProntuarioLabel As System.Windows.Forms.Label
        Dim CodigoPacienteLabel As System.Windows.Forms.Label
        Dim NumRegistroProfissionalLabel As System.Windows.Forms.Label
        Dim ProfissionalLabel As System.Windows.Forms.Label
        Dim AssinaturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_editar_evolucao_clinica))
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.EvolucaoClinicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EvolucaoClinicaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.EvolucaoClinicaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.EvolucaoClinicaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirEvolucaoClinicaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.TratamentoTextBox = New System.Windows.Forms.TextBox()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.ExameFisicoTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaDoencaAtualTextBox = New System.Windows.Forms.TextBox()
        Me.QueixaPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.NumeroProntuarioTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPacienteTextBox = New System.Windows.Forms.TextBox()
        Me.NumRegistroProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.ProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.AssinaturaTextBox = New System.Windows.Forms.TextBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.EvolucaoClinicaPanel = New System.Windows.Forms.Panel()
        CPFLabel = New System.Windows.Forms.Label()
        TratamentoLabel = New System.Windows.Forms.Label()
        CIDLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        ExameFisicoLabel = New System.Windows.Forms.Label()
        HistoriaDoencaAtualLabel = New System.Windows.Forms.Label()
        QueixaPrincipalLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        NumeroProntuarioLabel = New System.Windows.Forms.Label()
        CodigoPacienteLabel = New System.Windows.Forms.Label()
        NumRegistroProfissionalLabel = New System.Windows.Forms.Label()
        ProfissionalLabel = New System.Windows.Forms.Label()
        AssinaturaLabel = New System.Windows.Forms.Label()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvolucaoClinicaBindingNavigator.SuspendLayout()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EvolucaoClinicaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(148, 117)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'TratamentoLabel
        '
        TratamentoLabel.AutoSize = True
        TratamentoLabel.Location = New System.Drawing.Point(114, 565)
        TratamentoLabel.Name = "TratamentoLabel"
        TratamentoLabel.Size = New System.Drawing.Size(64, 13)
        TratamentoLabel.TabIndex = 33
        TratamentoLabel.Text = "Tratamento:"
        '
        'CIDLabel
        '
        CIDLabel.AutoSize = True
        CIDLabel.Location = New System.Drawing.Point(141, 539)
        CIDLabel.Name = "CIDLabel"
        CIDLabel.Size = New System.Drawing.Size(37, 13)
        CIDLabel.TabIndex = 31
        CIDLabel.Text = "C.I.D.:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(143, 513)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(35, 13)
        CIFLabel.TabIndex = 29
        CIFLabel.Text = "C.I.F.:"
        '
        'ExameFisicoLabel
        '
        ExameFisicoLabel.AutoSize = True
        ExameFisicoLabel.Location = New System.Drawing.Point(106, 407)
        ExameFisicoLabel.Name = "ExameFisicoLabel"
        ExameFisicoLabel.Size = New System.Drawing.Size(74, 13)
        ExameFisicoLabel.TabIndex = 27
        ExameFisicoLabel.Text = "Exame Físico:"
        '
        'HistoriaDoencaAtualLabel
        '
        HistoriaDoencaAtualLabel.AutoSize = True
        HistoriaDoencaAtualLabel.Location = New System.Drawing.Point(50, 301)
        HistoriaDoencaAtualLabel.Name = "HistoriaDoencaAtualLabel"
        HistoriaDoencaAtualLabel.Size = New System.Drawing.Size(128, 13)
        HistoriaDoencaAtualLabel.TabIndex = 25
        HistoriaDoencaAtualLabel.Text = "História da Doença Atual:"
        '
        'QueixaPrincipalLabel
        '
        QueixaPrincipalLabel.AutoSize = True
        QueixaPrincipalLabel.Location = New System.Drawing.Point(92, 195)
        QueixaPrincipalLabel.Name = "QueixaPrincipalLabel"
        QueixaPrincipalLabel.Size = New System.Drawing.Size(86, 13)
        QueixaPrincipalLabel.TabIndex = 23
        QueixaPrincipalLabel.Text = "Queixa Principal:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(145, 172)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 21
        DataLabel.Text = "Data:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(140, 143)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 19
        NomeLabel.Text = "Nome:"
        '
        'NumeroProntuarioLabel
        '
        NumeroProntuarioLabel.AutoSize = True
        NumeroProntuarioLabel.Location = New System.Drawing.Point(32, 11)
        NumeroProntuarioLabel.Name = "NumeroProntuarioLabel"
        NumeroProntuarioLabel.Size = New System.Drawing.Size(146, 13)
        NumeroProntuarioLabel.TabIndex = 34
        NumeroProntuarioLabel.Text = "Número da Evolução Clínica:"
        '
        'CodigoPacienteLabel
        '
        CodigoPacienteLabel.AutoSize = True
        CodigoPacienteLabel.Location = New System.Drawing.Point(75, 37)
        CodigoPacienteLabel.Name = "CodigoPacienteLabel"
        CodigoPacienteLabel.Size = New System.Drawing.Size(103, 13)
        CodigoPacienteLabel.TabIndex = 35
        CodigoPacienteLabel.Text = "Código do Paciente:"
        '
        'NumRegistroProfissionalLabel
        '
        NumRegistroProfissionalLabel.AutoSize = True
        NumRegistroProfissionalLabel.Location = New System.Drawing.Point(3, 63)
        NumRegistroProfissionalLabel.Name = "NumRegistroProfissionalLabel"
        NumRegistroProfissionalLabel.Size = New System.Drawing.Size(175, 13)
        NumRegistroProfissionalLabel.TabIndex = 36
        NumRegistroProfissionalLabel.Text = "Número de Registro do Profissional:"
        '
        'ProfissionalLabel
        '
        ProfissionalLabel.AutoSize = True
        ProfissionalLabel.Location = New System.Drawing.Point(69, 90)
        ProfissionalLabel.Name = "ProfissionalLabel"
        ProfissionalLabel.Size = New System.Drawing.Size(109, 13)
        ProfissionalLabel.TabIndex = 37
        ProfissionalLabel.Text = "Nome do Profissional:"
        '
        'AssinaturaLabel
        '
        AssinaturaLabel.AutoSize = True
        AssinaturaLabel.Location = New System.Drawing.Point(119, 671)
        AssinaturaLabel.Name = "AssinaturaLabel"
        AssinaturaLabel.Size = New System.Drawing.Size(59, 13)
        AssinaturaLabel.TabIndex = 38
        AssinaturaLabel.Text = "Assinatura:"
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EvolucaoClinicaBindingSource
        '
        Me.EvolucaoClinicaBindingSource.DataMember = "EvolucaoClinica"
        Me.EvolucaoClinicaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
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
        Me.EvolucaoClinicaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EvolucaoClinicaBindingNavigatorSaveItem, Me.ImprimirToolStripSeparator, Me.ImprimirEvolucaoClinicaToolStripButton})
        Me.EvolucaoClinicaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EvolucaoClinicaBindingNavigator.MoveFirstItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MoveLastItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MoveNextItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.MovePreviousItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.Name = "EvolucaoClinicaBindingNavigator"
        Me.EvolucaoClinicaBindingNavigator.PositionItem = Nothing
        Me.EvolucaoClinicaBindingNavigator.Size = New System.Drawing.Size(457, 25)
        Me.EvolucaoClinicaBindingNavigator.TabIndex = 0
        Me.EvolucaoClinicaBindingNavigator.Text = "BindingNavigator1"
        '
        'EvolucaoClinicaBindingNavigatorSaveItem
        '
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Image = CType(resources.GetObject("EvolucaoClinicaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Name = "EvolucaoClinicaBindingNavigatorSaveItem"
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.EvolucaoClinicaBindingNavigatorSaveItem.Text = "Salvar"
        '
        'ImprimirToolStripSeparator
        '
        Me.ImprimirToolStripSeparator.Name = "ImprimirToolStripSeparator"
        Me.ImprimirToolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirEvolucaoClinicaToolStripButton
        '
        Me.ImprimirEvolucaoClinicaToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirEvolucaoClinicaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirEvolucaoClinicaToolStripButton.Name = "ImprimirEvolucaoClinicaToolStripButton"
        Me.ImprimirEvolucaoClinicaToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirEvolucaoClinicaToolStripButton.Text = "Imprimir"
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CPF", True))
        Me.CPFTextBox.Location = New System.Drawing.Point(184, 114)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CPFTextBox.TabIndex = 2
        '
        'TratamentoTextBox
        '
        Me.TratamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Tratamento", True))
        Me.TratamentoTextBox.Location = New System.Drawing.Point(184, 562)
        Me.TratamentoTextBox.Multiline = True
        Me.TratamentoTextBox.Name = "TratamentoTextBox"
        Me.TratamentoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.TratamentoTextBox.TabIndex = 34
        '
        'CIDTextBox
        '
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CID", True))
        Me.CIDTextBox.Location = New System.Drawing.Point(184, 536)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(250, 20)
        Me.CIDTextBox.TabIndex = 32
        '
        'CIFTextBox
        '
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CIF", True))
        Me.CIFTextBox.Location = New System.Drawing.Point(184, 510)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.Size = New System.Drawing.Size(250, 20)
        Me.CIFTextBox.TabIndex = 30
        '
        'ExameFisicoTextBox
        '
        Me.ExameFisicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "ExameFisico", True))
        Me.ExameFisicoTextBox.Location = New System.Drawing.Point(184, 404)
        Me.ExameFisicoTextBox.Multiline = True
        Me.ExameFisicoTextBox.Name = "ExameFisicoTextBox"
        Me.ExameFisicoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.ExameFisicoTextBox.TabIndex = 28
        '
        'HistoriaDoencaAtualTextBox
        '
        Me.HistoriaDoencaAtualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "HistoriaDoencaAtual", True))
        Me.HistoriaDoencaAtualTextBox.Location = New System.Drawing.Point(184, 298)
        Me.HistoriaDoencaAtualTextBox.Multiline = True
        Me.HistoriaDoencaAtualTextBox.Name = "HistoriaDoencaAtualTextBox"
        Me.HistoriaDoencaAtualTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaDoencaAtualTextBox.TabIndex = 26
        '
        'QueixaPrincipalTextBox
        '
        Me.QueixaPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "QueixaPrincipal", True))
        Me.QueixaPrincipalTextBox.Location = New System.Drawing.Point(184, 192)
        Me.QueixaPrincipalTextBox.Multiline = True
        Me.QueixaPrincipalTextBox.Name = "QueixaPrincipalTextBox"
        Me.QueixaPrincipalTextBox.Size = New System.Drawing.Size(250, 100)
        Me.QueixaPrincipalTextBox.TabIndex = 24
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EvolucaoClinicaBindingSource, "Data", True))
        Me.DataDateTimePicker.Enabled = False
        Me.DataDateTimePicker.Location = New System.Drawing.Point(184, 166)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(250, 20)
        Me.DataDateTimePicker.TabIndex = 22
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(184, 140)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NomeTextBox.TabIndex = 20
        '
        'LogControleTableAdapter
        '
        Me.LogControleTableAdapter.ClearBeforeFill = True
        '
        'NumeroProntuarioTextBox
        '
        Me.NumeroProntuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "NumeroProntuario", True))
        Me.NumeroProntuarioTextBox.Enabled = False
        Me.NumeroProntuarioTextBox.Location = New System.Drawing.Point(184, 8)
        Me.NumeroProntuarioTextBox.Name = "NumeroProntuarioTextBox"
        Me.NumeroProntuarioTextBox.Size = New System.Drawing.Size(125, 20)
        Me.NumeroProntuarioTextBox.TabIndex = 35
        '
        'CodigoPacienteTextBox
        '
        Me.CodigoPacienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "CodigoPaciente", True))
        Me.CodigoPacienteTextBox.Enabled = False
        Me.CodigoPacienteTextBox.Location = New System.Drawing.Point(184, 34)
        Me.CodigoPacienteTextBox.Name = "CodigoPacienteTextBox"
        Me.CodigoPacienteTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CodigoPacienteTextBox.TabIndex = 36
        '
        'NumRegistroProfissionalComboBox
        '
        Me.NumRegistroProfissionalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NumRegistroProfissionalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NumRegistroProfissionalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "NumRegistroProfissional", True))
        Me.NumRegistroProfissionalComboBox.DataSource = Me.ProfissionaisBindingSource
        Me.NumRegistroProfissionalComboBox.DisplayMember = "NumRegistroOrgaoClasse"
        Me.NumRegistroProfissionalComboBox.FormattingEnabled = True
        Me.NumRegistroProfissionalComboBox.Location = New System.Drawing.Point(184, 60)
        Me.NumRegistroProfissionalComboBox.Name = "NumRegistroProfissionalComboBox"
        Me.NumRegistroProfissionalComboBox.Size = New System.Drawing.Size(125, 21)
        Me.NumRegistroProfissionalComboBox.TabIndex = 37
        Me.NumRegistroProfissionalComboBox.ValueMember = "NumRegistroOrgaoClasse"
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
        'ProfissionalComboBox
        '
        Me.ProfissionalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProfissionalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProfissionalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Profissional", True))
        Me.ProfissionalComboBox.DataSource = Me.ProfissionaisBindingSource
        Me.ProfissionalComboBox.DisplayMember = "Nome"
        Me.ProfissionalComboBox.FormattingEnabled = True
        Me.ProfissionalComboBox.Location = New System.Drawing.Point(184, 87)
        Me.ProfissionalComboBox.Name = "ProfissionalComboBox"
        Me.ProfissionalComboBox.Size = New System.Drawing.Size(250, 21)
        Me.ProfissionalComboBox.TabIndex = 38
        Me.ProfissionalComboBox.ValueMember = "Nome"
        '
        'AssinaturaTextBox
        '
        Me.AssinaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EvolucaoClinicaBindingSource, "Assinatura", True))
        Me.AssinaturaTextBox.Enabled = False
        Me.AssinaturaTextBox.Location = New System.Drawing.Point(184, 668)
        Me.AssinaturaTextBox.Name = "AssinaturaTextBox"
        Me.AssinaturaTextBox.Size = New System.Drawing.Size(250, 20)
        Me.AssinaturaTextBox.TabIndex = 39
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
        'EvolucaoClinicaPanel
        '
        Me.EvolucaoClinicaPanel.AutoScroll = True
        Me.EvolucaoClinicaPanel.Controls.Add(NumRegistroProfissionalLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(AssinaturaLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.CPFTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.AssinaturaTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(CPFLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(ProfissionalLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.NomeTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.ProfissionalComboBox)
        Me.EvolucaoClinicaPanel.Controls.Add(NomeLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.DataDateTimePicker)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.NumRegistroProfissionalComboBox)
        Me.EvolucaoClinicaPanel.Controls.Add(DataLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(CodigoPacienteLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.QueixaPrincipalTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.CodigoPacienteTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(QueixaPrincipalLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(NumeroProntuarioLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.HistoriaDoencaAtualTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.NumeroProntuarioTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(HistoriaDoencaAtualLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(TratamentoLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.ExameFisicoTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.TratamentoTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(ExameFisicoLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(CIDLabel)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.CIFTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(Me.CIDTextBox)
        Me.EvolucaoClinicaPanel.Controls.Add(CIFLabel)
        Me.EvolucaoClinicaPanel.Location = New System.Drawing.Point(0, 28)
        Me.EvolucaoClinicaPanel.Name = "EvolucaoClinicaPanel"
        Me.EvolucaoClinicaPanel.Size = New System.Drawing.Size(456, 404)
        Me.EvolucaoClinicaPanel.TabIndex = 40
        '
        'form_editar_evolucao_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(457, 313)
        Me.Controls.Add(Me.EvolucaoClinicaPanel)
        Me.Controls.Add(Me.EvolucaoClinicaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_editar_evolucao_clinica"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Evolução Clínica"
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EvolucaoClinicaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvolucaoClinicaBindingNavigator.ResumeLayout(False)
        Me.EvolucaoClinicaBindingNavigator.PerformLayout()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EvolucaoClinicaPanel.ResumeLayout(False)
        Me.EvolucaoClinicaPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents EvolucaoClinicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EvolucaoClinicaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.EvolucaoClinicaTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EvolucaoClinicaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents EvolucaoClinicaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TratamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExameFisicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaDoencaAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QueixaPrincipalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImprimirToolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirEvolucaoClinicaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents NumeroProntuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumRegistroProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents ProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AssinaturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents EvolucaoClinicaPanel As System.Windows.Forms.Panel
End Class
