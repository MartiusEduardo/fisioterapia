<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_anamnese
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
        Dim QueixaPrincipalLabel As System.Windows.Forms.Label
        Dim HistoriaDoencaAtualLabel As System.Windows.Forms.Label
        Dim HistoriaPatologicaPregressaLabel As System.Windows.Forms.Label
        Dim HistoriaFamiliarLabel As System.Windows.Forms.Label
        Dim HistoriaFamilialLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim CICLabel As System.Windows.Forms.Label
        Dim CIDLabel As System.Windows.Forms.Label
        Dim CIFLabel As System.Windows.Forms.Label
        Dim NumeroProntuarioLabel As System.Windows.Forms.Label
        Dim DataUltimaAtualizacaoLabel As System.Windows.Forms.Label
        Dim APAtividadesFisicasLabel As System.Windows.Forms.Label
        Dim APPesLabel As System.Windows.Forms.Label
        Dim APPernaCurtaAnatomicaLabel As System.Windows.Forms.Label
        Dim APCicatrizesLabel As System.Windows.Forms.Label
        Dim APAparelhoVestibularAudicaoLabel As System.Windows.Forms.Label
        Dim APVisaoConvergenciaOcularLabel As System.Windows.Forms.Label
        Dim APOclusaoDentariaATMLabel As System.Windows.Forms.Label
        Dim QualidadeSonoLabel As System.Windows.Forms.Label
        Dim HorasSonoLabel As System.Windows.Forms.Label
        Dim HidratacaoObsLabel As System.Windows.Forms.Label
        Dim CarneVermelhaObsLabel As System.Windows.Forms.Label
        Dim EtilismoObsLabel As System.Windows.Forms.Label
        Dim TabagismoObsLabel As System.Windows.Forms.Label
        Dim MedicamentosLabel As System.Windows.Forms.Label
        Dim MetabolismoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_anamnese))
        Me.AnamneseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.AnamneseTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.AnamneseBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AdicionarAnamneseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AnamneseBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CancelarAnamneseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirAnamneseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExamesComplementaresToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CirurgiasToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.QueixaPrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaDoencaAtualTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaPatologicaPregressaTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaFamiliarTextBox = New System.Windows.Forms.TextBox()
        Me.HistoriaFamilialTextBox = New System.Windows.Forms.TextBox()
        Me.CICComboBox = New System.Windows.Forms.ComboBox()
        Me.CIDTextBox = New System.Windows.Forms.TextBox()
        Me.CIFTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroProntuarioTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextBox = New System.Windows.Forms.TextBox()
        Me.DataUltimaAtualizacaoTextBox = New System.Windows.Forms.TextBox()
        Me.AnamnesePanel = New System.Windows.Forms.Panel()
        Me.DormeMesmoHorarioCheckBox = New System.Windows.Forms.CheckBox()
        Me.GrupoAnalisePosturologia = New System.Windows.Forms.GroupBox()
        Me.APAtividadesFisicasTextBox = New System.Windows.Forms.TextBox()
        Me.APPesTextBox = New System.Windows.Forms.TextBox()
        Me.APPernaCurtaAnatomicaTextBox = New System.Windows.Forms.TextBox()
        Me.APCicatrizesTextBox = New System.Windows.Forms.TextBox()
        Me.APAparelhoVestibularAudicaoTextBox = New System.Windows.Forms.TextBox()
        Me.APVisaoConvergenciaOcularTextBox = New System.Windows.Forms.TextBox()
        Me.APOclusaoDentariaATMTextBox = New System.Windows.Forms.TextBox()
        Me.QualidadeSonoTextBox = New System.Windows.Forms.TextBox()
        Me.HorasSonoTextBox = New System.Windows.Forms.TextBox()
        Me.HidratacaoObsTextBox = New System.Windows.Forms.TextBox()
        Me.HidratacaoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CarneVermelhaObsTextBox = New System.Windows.Forms.TextBox()
        Me.CarneVermelhaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EtilismoObsTextBox = New System.Windows.Forms.TextBox()
        Me.EtilismoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabagismoObsTextBox = New System.Windows.Forms.TextBox()
        Me.TabagismoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MedicamentosTextBox = New System.Windows.Forms.TextBox()
        Me.MetabolismoTextBox = New System.Windows.Forms.TextBox()
        CPFLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        QueixaPrincipalLabel = New System.Windows.Forms.Label()
        HistoriaDoencaAtualLabel = New System.Windows.Forms.Label()
        HistoriaPatologicaPregressaLabel = New System.Windows.Forms.Label()
        HistoriaFamiliarLabel = New System.Windows.Forms.Label()
        HistoriaFamilialLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CICLabel = New System.Windows.Forms.Label()
        CIDLabel = New System.Windows.Forms.Label()
        CIFLabel = New System.Windows.Forms.Label()
        NumeroProntuarioLabel = New System.Windows.Forms.Label()
        DataUltimaAtualizacaoLabel = New System.Windows.Forms.Label()
        APAtividadesFisicasLabel = New System.Windows.Forms.Label()
        APPesLabel = New System.Windows.Forms.Label()
        APPernaCurtaAnatomicaLabel = New System.Windows.Forms.Label()
        APCicatrizesLabel = New System.Windows.Forms.Label()
        APAparelhoVestibularAudicaoLabel = New System.Windows.Forms.Label()
        APVisaoConvergenciaOcularLabel = New System.Windows.Forms.Label()
        APOclusaoDentariaATMLabel = New System.Windows.Forms.Label()
        QualidadeSonoLabel = New System.Windows.Forms.Label()
        HorasSonoLabel = New System.Windows.Forms.Label()
        HidratacaoObsLabel = New System.Windows.Forms.Label()
        CarneVermelhaObsLabel = New System.Windows.Forms.Label()
        EtilismoObsLabel = New System.Windows.Forms.Label()
        TabagismoObsLabel = New System.Windows.Forms.Label()
        MedicamentosLabel = New System.Windows.Forms.Label()
        MetabolismoLabel = New System.Windows.Forms.Label()
        CType(Me.AnamneseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnamneseBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnamneseBindingNavigator.SuspendLayout()
        Me.AnamnesePanel.SuspendLayout()
        Me.GrupoAnalisePosturologia.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(580, 8)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(280, 8)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'QueixaPrincipalLabel
        '
        QueixaPrincipalLabel.AutoSize = True
        QueixaPrincipalLabel.Location = New System.Drawing.Point(74, 81)
        QueixaPrincipalLabel.Name = "QueixaPrincipalLabel"
        QueixaPrincipalLabel.Size = New System.Drawing.Size(86, 13)
        QueixaPrincipalLabel.TabIndex = 5
        QueixaPrincipalLabel.Text = "Queixa Principal:"
        '
        'HistoriaDoencaAtualLabel
        '
        HistoriaDoencaAtualLabel.AutoSize = True
        HistoriaDoencaAtualLabel.Location = New System.Drawing.Point(32, 187)
        HistoriaDoencaAtualLabel.Name = "HistoriaDoencaAtualLabel"
        HistoriaDoencaAtualLabel.Size = New System.Drawing.Size(128, 13)
        HistoriaDoencaAtualLabel.TabIndex = 7
        HistoriaDoencaAtualLabel.Text = "História da Doença Atual:"
        '
        'HistoriaPatologicaPregressaLabel
        '
        HistoriaPatologicaPregressaLabel.AutoSize = True
        HistoriaPatologicaPregressaLabel.Location = New System.Drawing.Point(12, 293)
        HistoriaPatologicaPregressaLabel.Name = "HistoriaPatologicaPregressaLabel"
        HistoriaPatologicaPregressaLabel.Size = New System.Drawing.Size(148, 13)
        HistoriaPatologicaPregressaLabel.TabIndex = 9
        HistoriaPatologicaPregressaLabel.Text = "História Patológica Pregressa:"
        '
        'HistoriaFamiliarLabel
        '
        HistoriaFamiliarLabel.AutoSize = True
        HistoriaFamiliarLabel.Location = New System.Drawing.Point(77, 405)
        HistoriaFamiliarLabel.Name = "HistoriaFamiliarLabel"
        HistoriaFamiliarLabel.Size = New System.Drawing.Size(83, 13)
        HistoriaFamiliarLabel.TabIndex = 11
        HistoriaFamiliarLabel.Text = "História Familiar:"
        '
        'HistoriaFamilialLabel
        '
        HistoriaFamilialLabel.AutoSize = True
        HistoriaFamilialLabel.Location = New System.Drawing.Point(78, 511)
        HistoriaFamilialLabel.Name = "HistoriaFamilialLabel"
        HistoriaFamilialLabel.Size = New System.Drawing.Size(82, 13)
        HistoriaFamilialLabel.TabIndex = 13
        HistoriaFamilialLabel.Text = "História Familial:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(127, 35)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 17
        DataLabel.Text = "Data:"
        '
        'CICLabel
        '
        CICLabel.AutoSize = True
        CICLabel.Location = New System.Drawing.Point(722, 8)
        CICLabel.Name = "CICLabel"
        CICLabel.Size = New System.Drawing.Size(33, 13)
        CICLabel.TabIndex = 44
        CICLabel.Text = "C.I.C:"
        '
        'CIDLabel
        '
        CIDLabel.AutoSize = True
        CIDLabel.Location = New System.Drawing.Point(867, 8)
        CIDLabel.Name = "CIDLabel"
        CIDLabel.Size = New System.Drawing.Size(34, 13)
        CIDLabel.TabIndex = 46
        CIDLabel.Text = "C.I.D:"
        '
        'CIFLabel
        '
        CIFLabel.AutoSize = True
        CIFLabel.Location = New System.Drawing.Point(1013, 8)
        CIFLabel.Name = "CIFLabel"
        CIFLabel.Size = New System.Drawing.Size(32, 13)
        CIFLabel.TabIndex = 48
        CIFLabel.Text = "C.I.F:"
        '
        'NumeroProntuarioLabel
        '
        NumeroProntuarioLabel.AutoSize = True
        NumeroProntuarioLabel.Location = New System.Drawing.Point(47, 8)
        NumeroProntuarioLabel.Name = "NumeroProntuarioLabel"
        NumeroProntuarioLabel.Size = New System.Drawing.Size(113, 13)
        NumeroProntuarioLabel.TabIndex = 51
        NumeroProntuarioLabel.Text = "Número do Prontuário:"
        '
        'DataUltimaAtualizacaoLabel
        '
        DataUltimaAtualizacaoLabel.AutoSize = True
        DataUltimaAtualizacaoLabel.Location = New System.Drawing.Point(22, 61)
        DataUltimaAtualizacaoLabel.Name = "DataUltimaAtualizacaoLabel"
        DataUltimaAtualizacaoLabel.Size = New System.Drawing.Size(138, 13)
        DataUltimaAtualizacaoLabel.TabIndex = 53
        DataUltimaAtualizacaoLabel.Text = "Data da Última Atualização:"
        '
        'APAtividadesFisicasLabel
        '
        APAtividadesFisicasLabel.AutoSize = True
        APAtividadesFisicasLabel.Location = New System.Drawing.Point(62, 659)
        APAtividadesFisicasLabel.Name = "APAtividadesFisicasLabel"
        APAtividadesFisicasLabel.Size = New System.Drawing.Size(96, 13)
        APAtividadesFisicasLabel.TabIndex = 43
        APAtividadesFisicasLabel.Text = "Atividades Físicas:"
        '
        'APPesLabel
        '
        APPesLabel.AutoSize = True
        APPesLabel.Location = New System.Drawing.Point(130, 553)
        APPesLabel.Name = "APPesLabel"
        APPesLabel.Size = New System.Drawing.Size(28, 13)
        APPesLabel.TabIndex = 42
        APPesLabel.Text = "Pés:"
        '
        'APPernaCurtaAnatomicaLabel
        '
        APPernaCurtaAnatomicaLabel.AutoSize = True
        APPernaCurtaAnatomicaLabel.Location = New System.Drawing.Point(39, 447)
        APPernaCurtaAnatomicaLabel.Name = "APPernaCurtaAnatomicaLabel"
        APPernaCurtaAnatomicaLabel.Size = New System.Drawing.Size(119, 13)
        APPernaCurtaAnatomicaLabel.TabIndex = 41
        APPernaCurtaAnatomicaLabel.Text = "Perna Curta Anatômica:"
        '
        'APCicatrizesLabel
        '
        APCicatrizesLabel.AutoSize = True
        APCicatrizesLabel.Location = New System.Drawing.Point(103, 341)
        APCicatrizesLabel.Name = "APCicatrizesLabel"
        APCicatrizesLabel.Size = New System.Drawing.Size(55, 13)
        APCicatrizesLabel.TabIndex = 40
        APCicatrizesLabel.Text = "Cicatrizes:"
        '
        'APAparelhoVestibularAudicaoLabel
        '
        APAparelhoVestibularAudicaoLabel.AutoSize = True
        APAparelhoVestibularAudicaoLabel.Location = New System.Drawing.Point(6, 235)
        APAparelhoVestibularAudicaoLabel.Name = "APAparelhoVestibularAudicaoLabel"
        APAparelhoVestibularAudicaoLabel.Size = New System.Drawing.Size(152, 13)
        APAparelhoVestibularAudicaoLabel.TabIndex = 39
        APAparelhoVestibularAudicaoLabel.Text = "Aparelho Vestibular e Audição:"
        '
        'APVisaoConvergenciaOcularLabel
        '
        APVisaoConvergenciaOcularLabel.AutoSize = True
        APVisaoConvergenciaOcularLabel.Location = New System.Drawing.Point(10, 129)
        APVisaoConvergenciaOcularLabel.Name = "APVisaoConvergenciaOcularLabel"
        APVisaoConvergenciaOcularLabel.Size = New System.Drawing.Size(148, 13)
        APVisaoConvergenciaOcularLabel.TabIndex = 38
        APVisaoConvergenciaOcularLabel.Text = "Visão e Convergência Ocular:"
        '
        'APOclusaoDentariaATMLabel
        '
        APOclusaoDentariaATMLabel.AutoSize = True
        APOclusaoDentariaATMLabel.Location = New System.Drawing.Point(34, 23)
        APOclusaoDentariaATMLabel.Name = "APOclusaoDentariaATMLabel"
        APOclusaoDentariaATMLabel.Size = New System.Drawing.Size(124, 13)
        APOclusaoDentariaATMLabel.TabIndex = 37
        APOclusaoDentariaATMLabel.Text = "Oclusão Dentária - ATM:"
        '
        'QualidadeSonoLabel
        '
        QualidadeSonoLabel.AutoSize = True
        QualidadeSonoLabel.Location = New System.Drawing.Point(434, 667)
        QualidadeSonoLabel.Name = "QualidadeSonoLabel"
        QualidadeSonoLabel.Size = New System.Drawing.Size(101, 13)
        QualidadeSonoLabel.TabIndex = 75
        QualidadeSonoLabel.Text = "Qualidade do Sono:"
        '
        'HorasSonoLabel
        '
        HorasSonoLabel.AutoSize = True
        HorasSonoLabel.Location = New System.Drawing.Point(538, 592)
        HorasSonoLabel.Name = "HorasSonoLabel"
        HorasSonoLabel.Size = New System.Drawing.Size(164, 13)
        HorasSonoLabel.TabIndex = 73
        HorasSonoLabel.Text = "Quantas horas de sono por noite:"
        '
        'HidratacaoObsLabel
        '
        HidratacaoObsLabel.AutoSize = True
        HidratacaoObsLabel.Location = New System.Drawing.Point(448, 492)
        HidratacaoObsLabel.Name = "HidratacaoObsLabel"
        HidratacaoObsLabel.Size = New System.Drawing.Size(87, 13)
        HidratacaoObsLabel.TabIndex = 70
        HidratacaoObsLabel.Text = "Hidratação Obs.:"
        '
        'CarneVermelhaObsLabel
        '
        CarneVermelhaObsLabel.AutoSize = True
        CarneVermelhaObsLabel.Location = New System.Drawing.Point(425, 356)
        CarneVermelhaObsLabel.Name = "CarneVermelhaObsLabel"
        CarneVermelhaObsLabel.Size = New System.Drawing.Size(110, 13)
        CarneVermelhaObsLabel.TabIndex = 68
        CarneVermelhaObsLabel.Text = "Carne Vermelha Obs.:"
        '
        'EtilismoObsLabel
        '
        EtilismoObsLabel.AutoSize = True
        EtilismoObsLabel.Location = New System.Drawing.Point(465, 220)
        EtilismoObsLabel.Name = "EtilismoObsLabel"
        EtilismoObsLabel.Size = New System.Drawing.Size(70, 13)
        EtilismoObsLabel.TabIndex = 64
        EtilismoObsLabel.Text = "Etilismo Obs.:"
        '
        'TabagismoObsLabel
        '
        TabagismoObsLabel.AutoSize = True
        TabagismoObsLabel.Location = New System.Drawing.Point(448, 84)
        TabagismoObsLabel.Name = "TabagismoObsLabel"
        TabagismoObsLabel.Size = New System.Drawing.Size(87, 13)
        TabagismoObsLabel.TabIndex = 61
        TabagismoObsLabel.Text = "Tabagismo Obs.:"
        '
        'MedicamentosLabel
        '
        MedicamentosLabel.AutoSize = True
        MedicamentosLabel.Location = New System.Drawing.Point(81, 723)
        MedicamentosLabel.Name = "MedicamentosLabel"
        MedicamentosLabel.Size = New System.Drawing.Size(79, 13)
        MedicamentosLabel.TabIndex = 59
        MedicamentosLabel.Text = "Medicamentos:"
        '
        'MetabolismoLabel
        '
        MetabolismoLabel.AutoSize = True
        MetabolismoLabel.Location = New System.Drawing.Point(91, 617)
        MetabolismoLabel.Name = "MetabolismoLabel"
        MetabolismoLabel.Size = New System.Drawing.Size(69, 13)
        MetabolismoLabel.TabIndex = 57
        MetabolismoLabel.Text = "Metabolismo:"
        '
        'AnamneseBindingSource
        '
        Me.AnamneseBindingSource.DataMember = "Anamnese"
        Me.AnamneseBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnamneseTableAdapter
        '
        Me.AnamneseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Me.AnamneseTableAdapter
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
        'AnamneseBindingNavigator
        '
        Me.AnamneseBindingNavigator.AddNewItem = Nothing
        Me.AnamneseBindingNavigator.BindingSource = Me.AnamneseBindingSource
        Me.AnamneseBindingNavigator.CountItem = Nothing
        Me.AnamneseBindingNavigator.DeleteItem = Nothing
        Me.AnamneseBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.AnamneseBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdicionarAnamneseToolStripButton, Me.AnamneseBindingNavigatorSaveItem, Me.CancelarAnamneseToolStripButton, Me.ToolStripSeparator1, Me.ImprimirAnamneseToolStripButton, Me.ToolStripSeparator2, Me.ExamesComplementaresToolStripButton, Me.ToolStripSeparator3, Me.CirurgiasToolStripButton})
        Me.AnamneseBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnamneseBindingNavigator.MoveFirstItem = Nothing
        Me.AnamneseBindingNavigator.MoveLastItem = Nothing
        Me.AnamneseBindingNavigator.MoveNextItem = Nothing
        Me.AnamneseBindingNavigator.MovePreviousItem = Nothing
        Me.AnamneseBindingNavigator.Name = "AnamneseBindingNavigator"
        Me.AnamneseBindingNavigator.PositionItem = Nothing
        Me.AnamneseBindingNavigator.Size = New System.Drawing.Size(833, 25)
        Me.AnamneseBindingNavigator.TabIndex = 0
        Me.AnamneseBindingNavigator.Text = "BindingNavigator1"
        '
        'AdicionarAnamneseToolStripButton
        '
        Me.AdicionarAnamneseToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Add
        Me.AdicionarAnamneseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AdicionarAnamneseToolStripButton.Name = "AdicionarAnamneseToolStripButton"
        Me.AdicionarAnamneseToolStripButton.Size = New System.Drawing.Size(78, 22)
        Me.AdicionarAnamneseToolStripButton.Text = "Adicionar"
        '
        'AnamneseBindingNavigatorSaveItem
        '
        Me.AnamneseBindingNavigatorSaveItem.Enabled = False
        Me.AnamneseBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnamneseBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnamneseBindingNavigatorSaveItem.Name = "AnamneseBindingNavigatorSaveItem"
        Me.AnamneseBindingNavigatorSaveItem.Size = New System.Drawing.Size(58, 22)
        Me.AnamneseBindingNavigatorSaveItem.Text = "Salvar"
        '
        'CancelarAnamneseToolStripButton
        '
        Me.CancelarAnamneseToolStripButton.Enabled = False
        Me.CancelarAnamneseToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources.Button_White_Stop
        Me.CancelarAnamneseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelarAnamneseToolStripButton.Name = "CancelarAnamneseToolStripButton"
        Me.CancelarAnamneseToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.CancelarAnamneseToolStripButton.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirAnamneseToolStripButton
        '
        Me.ImprimirAnamneseToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._9854_32x32
        Me.ImprimirAnamneseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirAnamneseToolStripButton.Name = "ImprimirAnamneseToolStripButton"
        Me.ImprimirAnamneseToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.ImprimirAnamneseToolStripButton.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ExamesComplementaresToolStripButton
        '
        Me.ExamesComplementaresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ExamesComplementaresToolStripButton.Image = CType(resources.GetObject("ExamesComplementaresToolStripButton.Image"), System.Drawing.Image)
        Me.ExamesComplementaresToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExamesComplementaresToolStripButton.Name = "ExamesComplementaresToolStripButton"
        Me.ExamesComplementaresToolStripButton.Size = New System.Drawing.Size(144, 22)
        Me.ExamesComplementaresToolStripButton.Text = "Exames Complementares"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CirurgiasToolStripButton
        '
        Me.CirurgiasToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CirurgiasToolStripButton.Image = CType(resources.GetObject("CirurgiasToolStripButton.Image"), System.Drawing.Image)
        Me.CirurgiasToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CirurgiasToolStripButton.Name = "CirurgiasToolStripButton"
        Me.CirurgiasToolStripButton.Size = New System.Drawing.Size(58, 22)
        Me.CirurgiasToolStripButton.Text = "Cirurgias"
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "CPF", True))
        Me.CPFTextBox.Location = New System.Drawing.Point(616, 5)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(324, 5)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(250, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'QueixaPrincipalTextBox
        '
        Me.QueixaPrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "QueixaPrincipal", True))
        Me.QueixaPrincipalTextBox.Location = New System.Drawing.Point(166, 84)
        Me.QueixaPrincipalTextBox.Multiline = True
        Me.QueixaPrincipalTextBox.Name = "QueixaPrincipalTextBox"
        Me.QueixaPrincipalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.QueixaPrincipalTextBox.Size = New System.Drawing.Size(250, 100)
        Me.QueixaPrincipalTextBox.TabIndex = 6
        '
        'HistoriaDoencaAtualTextBox
        '
        Me.HistoriaDoencaAtualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HistoriaDoencaAtual", True))
        Me.HistoriaDoencaAtualTextBox.Location = New System.Drawing.Point(166, 190)
        Me.HistoriaDoencaAtualTextBox.Multiline = True
        Me.HistoriaDoencaAtualTextBox.Name = "HistoriaDoencaAtualTextBox"
        Me.HistoriaDoencaAtualTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HistoriaDoencaAtualTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaDoencaAtualTextBox.TabIndex = 8
        '
        'HistoriaPatologicaPregressaTextBox
        '
        Me.HistoriaPatologicaPregressaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HistoriaPatologicaPregressa", True))
        Me.HistoriaPatologicaPregressaTextBox.Location = New System.Drawing.Point(166, 296)
        Me.HistoriaPatologicaPregressaTextBox.Multiline = True
        Me.HistoriaPatologicaPregressaTextBox.Name = "HistoriaPatologicaPregressaTextBox"
        Me.HistoriaPatologicaPregressaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HistoriaPatologicaPregressaTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaPatologicaPregressaTextBox.TabIndex = 10
        '
        'HistoriaFamiliarTextBox
        '
        Me.HistoriaFamiliarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HistoriaFamiliar", True))
        Me.HistoriaFamiliarTextBox.Location = New System.Drawing.Point(166, 402)
        Me.HistoriaFamiliarTextBox.Multiline = True
        Me.HistoriaFamiliarTextBox.Name = "HistoriaFamiliarTextBox"
        Me.HistoriaFamiliarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HistoriaFamiliarTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaFamiliarTextBox.TabIndex = 12
        '
        'HistoriaFamilialTextBox
        '
        Me.HistoriaFamilialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HistoriaFamilial", True))
        Me.HistoriaFamilialTextBox.Location = New System.Drawing.Point(166, 508)
        Me.HistoriaFamilialTextBox.Multiline = True
        Me.HistoriaFamilialTextBox.Name = "HistoriaFamilialTextBox"
        Me.HistoriaFamilialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HistoriaFamilialTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HistoriaFamilialTextBox.TabIndex = 14
        '
        'CICComboBox
        '
        Me.CICComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "CIC", True))
        Me.CICComboBox.FormattingEnabled = True
        Me.CICComboBox.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.CICComboBox.Location = New System.Drawing.Point(761, 5)
        Me.CICComboBox.Name = "CICComboBox"
        Me.CICComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CICComboBox.TabIndex = 45
        '
        'CIDTextBox
        '
        Me.CIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "CID", True))
        Me.CIDTextBox.Location = New System.Drawing.Point(907, 5)
        Me.CIDTextBox.Name = "CIDTextBox"
        Me.CIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIDTextBox.TabIndex = 47
        '
        'CIFTextBox
        '
        Me.CIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "CIF", True))
        Me.CIFTextBox.Location = New System.Drawing.Point(1051, 5)
        Me.CIFTextBox.Name = "CIFTextBox"
        Me.CIFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CIFTextBox.TabIndex = 49
        '
        'NumeroProntuarioTextBox
        '
        Me.NumeroProntuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "NumeroProntuario", True))
        Me.NumeroProntuarioTextBox.Enabled = False
        Me.NumeroProntuarioTextBox.Location = New System.Drawing.Point(166, 5)
        Me.NumeroProntuarioTextBox.Name = "NumeroProntuarioTextBox"
        Me.NumeroProntuarioTextBox.Size = New System.Drawing.Size(108, 20)
        Me.NumeroProntuarioTextBox.TabIndex = 52
        '
        'DataTextBox
        '
        Me.DataTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "Data", True))
        Me.DataTextBox.Enabled = False
        Me.DataTextBox.Location = New System.Drawing.Point(166, 32)
        Me.DataTextBox.Name = "DataTextBox"
        Me.DataTextBox.Size = New System.Drawing.Size(152, 20)
        Me.DataTextBox.TabIndex = 55
        '
        'DataUltimaAtualizacaoTextBox
        '
        Me.DataUltimaAtualizacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "DataUltimaAtualizacao", True))
        Me.DataUltimaAtualizacaoTextBox.Enabled = False
        Me.DataUltimaAtualizacaoTextBox.Location = New System.Drawing.Point(166, 58)
        Me.DataUltimaAtualizacaoTextBox.Name = "DataUltimaAtualizacaoTextBox"
        Me.DataUltimaAtualizacaoTextBox.Size = New System.Drawing.Size(152, 20)
        Me.DataUltimaAtualizacaoTextBox.TabIndex = 56
        '
        'AnamnesePanel
        '
        Me.AnamnesePanel.AutoScroll = True
        Me.AnamnesePanel.Controls.Add(Me.DormeMesmoHorarioCheckBox)
        Me.AnamnesePanel.Controls.Add(Me.GrupoAnalisePosturologia)
        Me.AnamnesePanel.Controls.Add(QualidadeSonoLabel)
        Me.AnamnesePanel.Controls.Add(Me.QualidadeSonoTextBox)
        Me.AnamnesePanel.Controls.Add(HorasSonoLabel)
        Me.AnamnesePanel.Controls.Add(Me.HorasSonoTextBox)
        Me.AnamnesePanel.Controls.Add(HidratacaoObsLabel)
        Me.AnamnesePanel.Controls.Add(Me.HidratacaoObsTextBox)
        Me.AnamnesePanel.Controls.Add(Me.HidratacaoCheckBox)
        Me.AnamnesePanel.Controls.Add(CarneVermelhaObsLabel)
        Me.AnamnesePanel.Controls.Add(Me.CarneVermelhaObsTextBox)
        Me.AnamnesePanel.Controls.Add(Me.CarneVermelhaCheckBox)
        Me.AnamnesePanel.Controls.Add(EtilismoObsLabel)
        Me.AnamnesePanel.Controls.Add(Me.EtilismoObsTextBox)
        Me.AnamnesePanel.Controls.Add(Me.EtilismoCheckBox)
        Me.AnamnesePanel.Controls.Add(TabagismoObsLabel)
        Me.AnamnesePanel.Controls.Add(Me.TabagismoObsTextBox)
        Me.AnamnesePanel.Controls.Add(Me.TabagismoCheckBox)
        Me.AnamnesePanel.Controls.Add(MedicamentosLabel)
        Me.AnamnesePanel.Controls.Add(Me.MedicamentosTextBox)
        Me.AnamnesePanel.Controls.Add(MetabolismoLabel)
        Me.AnamnesePanel.Controls.Add(Me.MetabolismoTextBox)
        Me.AnamnesePanel.Controls.Add(Me.QueixaPrincipalTextBox)
        Me.AnamnesePanel.Controls.Add(Me.DataUltimaAtualizacaoTextBox)
        Me.AnamnesePanel.Controls.Add(HistoriaPatologicaPregressaLabel)
        Me.AnamnesePanel.Controls.Add(Me.DataTextBox)
        Me.AnamnesePanel.Controls.Add(QueixaPrincipalLabel)
        Me.AnamnesePanel.Controls.Add(DataUltimaAtualizacaoLabel)
        Me.AnamnesePanel.Controls.Add(NumeroProntuarioLabel)
        Me.AnamnesePanel.Controls.Add(Me.HistoriaPatologicaPregressaTextBox)
        Me.AnamnesePanel.Controls.Add(Me.NumeroProntuarioTextBox)
        Me.AnamnesePanel.Controls.Add(Me.HistoriaDoencaAtualTextBox)
        Me.AnamnesePanel.Controls.Add(CIFLabel)
        Me.AnamnesePanel.Controls.Add(HistoriaDoencaAtualLabel)
        Me.AnamnesePanel.Controls.Add(Me.CIFTextBox)
        Me.AnamnesePanel.Controls.Add(CIDLabel)
        Me.AnamnesePanel.Controls.Add(Me.HistoriaFamiliarTextBox)
        Me.AnamnesePanel.Controls.Add(Me.CIDTextBox)
        Me.AnamnesePanel.Controls.Add(HistoriaFamiliarLabel)
        Me.AnamnesePanel.Controls.Add(CICLabel)
        Me.AnamnesePanel.Controls.Add(Me.HistoriaFamilialTextBox)
        Me.AnamnesePanel.Controls.Add(Me.CICComboBox)
        Me.AnamnesePanel.Controls.Add(HistoriaFamilialLabel)
        Me.AnamnesePanel.Controls.Add(Me.CPFTextBox)
        Me.AnamnesePanel.Controls.Add(CPFLabel)
        Me.AnamnesePanel.Controls.Add(Me.NomeTextBox)
        Me.AnamnesePanel.Controls.Add(NomeLabel)
        Me.AnamnesePanel.Controls.Add(DataLabel)
        Me.AnamnesePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnamnesePanel.Enabled = False
        Me.AnamnesePanel.Location = New System.Drawing.Point(0, 25)
        Me.AnamnesePanel.Name = "AnamnesePanel"
        Me.AnamnesePanel.Size = New System.Drawing.Size(833, 335)
        Me.AnamnesePanel.TabIndex = 57
        '
        'DormeMesmoHorarioCheckBox
        '
        Me.DormeMesmoHorarioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnamneseBindingSource, "DormeMesmoHorario", True))
        Me.DormeMesmoHorarioCheckBox.Location = New System.Drawing.Point(541, 634)
        Me.DormeMesmoHorarioCheckBox.Name = "DormeMesmoHorarioCheckBox"
        Me.DormeMesmoHorarioCheckBox.Size = New System.Drawing.Size(185, 24)
        Me.DormeMesmoHorarioCheckBox.TabIndex = 78
        Me.DormeMesmoHorarioCheckBox.Text = "Dorme sempre no mesmo horário"
        Me.DormeMesmoHorarioCheckBox.UseVisualStyleBackColor = True
        '
        'GrupoAnalisePosturologia
        '
        Me.GrupoAnalisePosturologia.Controls.Add(APAtividadesFisicasLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APAtividadesFisicasTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APPesLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APPesTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APPernaCurtaAnatomicaLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APPernaCurtaAnatomicaTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APCicatrizesLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APCicatrizesTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APAparelhoVestibularAudicaoLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APAparelhoVestibularAudicaoTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APVisaoConvergenciaOcularLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APVisaoConvergenciaOcularTextBox)
        Me.GrupoAnalisePosturologia.Controls.Add(APOclusaoDentariaATMLabel)
        Me.GrupoAnalisePosturologia.Controls.Add(Me.APOclusaoDentariaATMTextBox)
        Me.GrupoAnalisePosturologia.Location = New System.Drawing.Point(797, 51)
        Me.GrupoAnalisePosturologia.Name = "GrupoAnalisePosturologia"
        Me.GrupoAnalisePosturologia.Size = New System.Drawing.Size(432, 771)
        Me.GrupoAnalisePosturologia.TabIndex = 77
        Me.GrupoAnalisePosturologia.TabStop = False
        Me.GrupoAnalisePosturologia.Text = "AP - Análise de posturologia"
        '
        'APAtividadesFisicasTextBox
        '
        Me.APAtividadesFisicasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APAtividadesFisicas", True))
        Me.APAtividadesFisicasTextBox.Location = New System.Drawing.Point(164, 656)
        Me.APAtividadesFisicasTextBox.Multiline = True
        Me.APAtividadesFisicasTextBox.Name = "APAtividadesFisicasTextBox"
        Me.APAtividadesFisicasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APAtividadesFisicasTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APAtividadesFisicasTextBox.TabIndex = 44
        '
        'APPesTextBox
        '
        Me.APPesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APPes", True))
        Me.APPesTextBox.Location = New System.Drawing.Point(164, 550)
        Me.APPesTextBox.Multiline = True
        Me.APPesTextBox.Name = "APPesTextBox"
        Me.APPesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APPesTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APPesTextBox.TabIndex = 43
        '
        'APPernaCurtaAnatomicaTextBox
        '
        Me.APPernaCurtaAnatomicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APPernaCurtaAnatomica", True))
        Me.APPernaCurtaAnatomicaTextBox.Location = New System.Drawing.Point(164, 444)
        Me.APPernaCurtaAnatomicaTextBox.Multiline = True
        Me.APPernaCurtaAnatomicaTextBox.Name = "APPernaCurtaAnatomicaTextBox"
        Me.APPernaCurtaAnatomicaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APPernaCurtaAnatomicaTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APPernaCurtaAnatomicaTextBox.TabIndex = 42
        '
        'APCicatrizesTextBox
        '
        Me.APCicatrizesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APCicatrizes", True))
        Me.APCicatrizesTextBox.Location = New System.Drawing.Point(164, 338)
        Me.APCicatrizesTextBox.Multiline = True
        Me.APCicatrizesTextBox.Name = "APCicatrizesTextBox"
        Me.APCicatrizesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APCicatrizesTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APCicatrizesTextBox.TabIndex = 41
        '
        'APAparelhoVestibularAudicaoTextBox
        '
        Me.APAparelhoVestibularAudicaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APAparelhoVestibularAudicao", True))
        Me.APAparelhoVestibularAudicaoTextBox.Location = New System.Drawing.Point(164, 232)
        Me.APAparelhoVestibularAudicaoTextBox.Multiline = True
        Me.APAparelhoVestibularAudicaoTextBox.Name = "APAparelhoVestibularAudicaoTextBox"
        Me.APAparelhoVestibularAudicaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APAparelhoVestibularAudicaoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APAparelhoVestibularAudicaoTextBox.TabIndex = 40
        '
        'APVisaoConvergenciaOcularTextBox
        '
        Me.APVisaoConvergenciaOcularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APVisaoConvergenciaOcular", True))
        Me.APVisaoConvergenciaOcularTextBox.Location = New System.Drawing.Point(164, 126)
        Me.APVisaoConvergenciaOcularTextBox.Multiline = True
        Me.APVisaoConvergenciaOcularTextBox.Name = "APVisaoConvergenciaOcularTextBox"
        Me.APVisaoConvergenciaOcularTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APVisaoConvergenciaOcularTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APVisaoConvergenciaOcularTextBox.TabIndex = 39
        '
        'APOclusaoDentariaATMTextBox
        '
        Me.APOclusaoDentariaATMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "APOclusaoDentariaATM", True))
        Me.APOclusaoDentariaATMTextBox.Location = New System.Drawing.Point(164, 20)
        Me.APOclusaoDentariaATMTextBox.Multiline = True
        Me.APOclusaoDentariaATMTextBox.Name = "APOclusaoDentariaATMTextBox"
        Me.APOclusaoDentariaATMTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.APOclusaoDentariaATMTextBox.Size = New System.Drawing.Size(250, 100)
        Me.APOclusaoDentariaATMTextBox.TabIndex = 38
        '
        'QualidadeSonoTextBox
        '
        Me.QualidadeSonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "QualidadeSono", True))
        Me.QualidadeSonoTextBox.Location = New System.Drawing.Point(541, 664)
        Me.QualidadeSonoTextBox.Multiline = True
        Me.QualidadeSonoTextBox.Name = "QualidadeSonoTextBox"
        Me.QualidadeSonoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.QualidadeSonoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.QualidadeSonoTextBox.TabIndex = 76
        '
        'HorasSonoTextBox
        '
        Me.HorasSonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HorasSono", True))
        Me.HorasSonoTextBox.Location = New System.Drawing.Point(541, 608)
        Me.HorasSonoTextBox.Name = "HorasSonoTextBox"
        Me.HorasSonoTextBox.Size = New System.Drawing.Size(250, 20)
        Me.HorasSonoTextBox.TabIndex = 74
        '
        'HidratacaoObsTextBox
        '
        Me.HidratacaoObsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "HidratacaoObs", True))
        Me.HidratacaoObsTextBox.Location = New System.Drawing.Point(541, 489)
        Me.HidratacaoObsTextBox.Multiline = True
        Me.HidratacaoObsTextBox.Name = "HidratacaoObsTextBox"
        Me.HidratacaoObsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HidratacaoObsTextBox.Size = New System.Drawing.Size(250, 100)
        Me.HidratacaoObsTextBox.TabIndex = 72
        '
        'HidratacaoCheckBox
        '
        Me.HidratacaoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnamneseBindingSource, "Hidratacao", True))
        Me.HidratacaoCheckBox.Location = New System.Drawing.Point(541, 459)
        Me.HidratacaoCheckBox.Name = "HidratacaoCheckBox"
        Me.HidratacaoCheckBox.Size = New System.Drawing.Size(82, 24)
        Me.HidratacaoCheckBox.TabIndex = 71
        Me.HidratacaoCheckBox.Text = "Hidratação"
        Me.HidratacaoCheckBox.UseVisualStyleBackColor = True
        '
        'CarneVermelhaObsTextBox
        '
        Me.CarneVermelhaObsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "CarneVermelhaObs", True))
        Me.CarneVermelhaObsTextBox.Location = New System.Drawing.Point(541, 353)
        Me.CarneVermelhaObsTextBox.Multiline = True
        Me.CarneVermelhaObsTextBox.Name = "CarneVermelhaObsTextBox"
        Me.CarneVermelhaObsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CarneVermelhaObsTextBox.Size = New System.Drawing.Size(250, 100)
        Me.CarneVermelhaObsTextBox.TabIndex = 69
        '
        'CarneVermelhaCheckBox
        '
        Me.CarneVermelhaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnamneseBindingSource, "CarneVermelha", True))
        Me.CarneVermelhaCheckBox.Location = New System.Drawing.Point(541, 323)
        Me.CarneVermelhaCheckBox.Name = "CarneVermelhaCheckBox"
        Me.CarneVermelhaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.CarneVermelhaCheckBox.TabIndex = 67
        Me.CarneVermelhaCheckBox.Text = "Carne Vermelha"
        Me.CarneVermelhaCheckBox.UseVisualStyleBackColor = True
        '
        'EtilismoObsTextBox
        '
        Me.EtilismoObsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "EtilismoObs", True))
        Me.EtilismoObsTextBox.Location = New System.Drawing.Point(541, 217)
        Me.EtilismoObsTextBox.Multiline = True
        Me.EtilismoObsTextBox.Name = "EtilismoObsTextBox"
        Me.EtilismoObsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.EtilismoObsTextBox.Size = New System.Drawing.Size(250, 100)
        Me.EtilismoObsTextBox.TabIndex = 66
        '
        'EtilismoCheckBox
        '
        Me.EtilismoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnamneseBindingSource, "Etilismo", True))
        Me.EtilismoCheckBox.Location = New System.Drawing.Point(541, 187)
        Me.EtilismoCheckBox.Name = "EtilismoCheckBox"
        Me.EtilismoCheckBox.Size = New System.Drawing.Size(65, 24)
        Me.EtilismoCheckBox.TabIndex = 65
        Me.EtilismoCheckBox.Text = "Etilismo"
        Me.EtilismoCheckBox.UseVisualStyleBackColor = True
        '
        'TabagismoObsTextBox
        '
        Me.TabagismoObsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "TabagismoObs", True))
        Me.TabagismoObsTextBox.Location = New System.Drawing.Point(541, 81)
        Me.TabagismoObsTextBox.Multiline = True
        Me.TabagismoObsTextBox.Name = "TabagismoObsTextBox"
        Me.TabagismoObsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TabagismoObsTextBox.Size = New System.Drawing.Size(250, 100)
        Me.TabagismoObsTextBox.TabIndex = 63
        '
        'TabagismoCheckBox
        '
        Me.TabagismoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AnamneseBindingSource, "Tabagismo", True))
        Me.TabagismoCheckBox.Location = New System.Drawing.Point(541, 51)
        Me.TabagismoCheckBox.Name = "TabagismoCheckBox"
        Me.TabagismoCheckBox.Size = New System.Drawing.Size(81, 24)
        Me.TabagismoCheckBox.TabIndex = 62
        Me.TabagismoCheckBox.Text = "Tabagismo"
        Me.TabagismoCheckBox.UseVisualStyleBackColor = True
        '
        'MedicamentosTextBox
        '
        Me.MedicamentosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "Medicamentos", True))
        Me.MedicamentosTextBox.Location = New System.Drawing.Point(166, 720)
        Me.MedicamentosTextBox.Multiline = True
        Me.MedicamentosTextBox.Name = "MedicamentosTextBox"
        Me.MedicamentosTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MedicamentosTextBox.Size = New System.Drawing.Size(250, 100)
        Me.MedicamentosTextBox.TabIndex = 60
        '
        'MetabolismoTextBox
        '
        Me.MetabolismoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnamneseBindingSource, "Metabolismo", True))
        Me.MetabolismoTextBox.Location = New System.Drawing.Point(166, 614)
        Me.MetabolismoTextBox.Multiline = True
        Me.MetabolismoTextBox.Name = "MetabolismoTextBox"
        Me.MetabolismoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.MetabolismoTextBox.Size = New System.Drawing.Size(250, 100)
        Me.MetabolismoTextBox.TabIndex = 58
        '
        'form_anamnese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(833, 360)
        Me.Controls.Add(Me.AnamnesePanel)
        Me.Controls.Add(Me.AnamneseBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_anamnese"
        Me.ShowIcon = False
        Me.Text = "Anamnese"
        CType(Me.AnamneseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnamneseBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnamneseBindingNavigator.ResumeLayout(False)
        Me.AnamneseBindingNavigator.PerformLayout()
        Me.AnamnesePanel.ResumeLayout(False)
        Me.AnamnesePanel.PerformLayout()
        Me.GrupoAnalisePosturologia.ResumeLayout(False)
        Me.GrupoAnalisePosturologia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents AnamneseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnamneseTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.AnamneseTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnamneseBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents AnamneseBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CPFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QueixaPrincipalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaDoencaAtualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaPatologicaPregressaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaFamiliarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoriaFamilialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdicionarAnamneseToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelarAnamneseToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CICComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents NumeroProntuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataUltimaAtualizacaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AnamnesePanel As System.Windows.Forms.Panel
    Friend WithEvents DormeMesmoHorarioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GrupoAnalisePosturologia As System.Windows.Forms.GroupBox
    Friend WithEvents APAtividadesFisicasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APPesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APPernaCurtaAnatomicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APCicatrizesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APAparelhoVestibularAudicaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APVisaoConvergenciaOcularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents APOclusaoDentariaATMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QualidadeSonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HorasSonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HidratacaoObsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HidratacaoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CarneVermelhaObsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarneVermelhaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EtilismoObsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EtilismoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TabagismoObsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabagismoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MedicamentosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MetabolismoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirAnamneseToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExamesComplementaresToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CirurgiasToolStripButton As System.Windows.Forms.ToolStripButton
End Class
