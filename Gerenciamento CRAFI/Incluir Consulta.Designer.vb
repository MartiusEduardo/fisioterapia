<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_incluir_consulta
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim EspecialidadeLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DataTerminoLabel As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_incluir_consulta))
        Me.ConsultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.PrevistoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConfirmadoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConsultasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConsultasTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.DataTerminoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DataDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.EspecialidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ValorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MotivoMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ObservacaoMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.AllDayEventCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.HorarioTimeEdit = New DevExpress.XtraEditors.TimeEdit()
        Me.HorarioTerminoTimeEdit = New DevExpress.XtraEditors.TimeEdit()
        Me.DataTimeLabel = New System.Windows.Forms.Label()
        Me.DataTimeTerminoLabel = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter()
        Me.PacienteComboBox = New System.Windows.Forms.ComboBox()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacienteTextBox = New System.Windows.Forms.TextBox()
        Me.SatisfacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SatisfacaoLabel = New System.Windows.Forms.Label()
        Me.ProfissionalComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfissionaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfissionalIdLabel = New System.Windows.Forms.Label()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_add_como_receita = New System.Windows.Forms.Button()
        Me.ReceitaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceitaTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter()
        Me.ReciboCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        Me.ContagemReceitaTextBox = New System.Windows.Forms.TextBox()
        Me.txtProfissionalId = New System.Windows.Forms.TextBox()
        Me.txtProfissional = New System.Windows.Forms.TextBox()
        Me.ProfissionaisTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter()
        Me.lblContagemReceita = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        EspecialidadeLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DataTerminoLabel = New System.Windows.Forms.Label()
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTerminoDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTerminoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspecialidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotivoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObservacaoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDayEventCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioTerminoTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatisfacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReciboCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(23, 98)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(98, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome do Paciente:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(88, 126)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(33, 13)
        DataLabel.TabIndex = 5
        DataLabel.Text = "Data:"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.Location = New System.Drawing.Point(79, 203)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(42, 13)
        MotivoLabel.TabIndex = 9
        MotivoLabel.Text = "Motivo:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Location = New System.Drawing.Point(53, 309)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(68, 13)
        ObservacaoLabel.TabIndex = 11
        ObservacaoLabel.Text = "Observação:"
        '
        'EspecialidadeLabel
        '
        EspecialidadeLabel.AutoSize = True
        EspecialidadeLabel.Location = New System.Drawing.Point(45, 72)
        EspecialidadeLabel.Name = "EspecialidadeLabel"
        EspecialidadeLabel.Size = New System.Drawing.Size(76, 13)
        EspecialidadeLabel.TabIndex = 15
        EspecialidadeLabel.Text = "Especialidade:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(87, 177)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 22
        ValorLabel.Text = "Valor:"
        '
        'DataTerminoLabel
        '
        DataTerminoLabel.AutoSize = True
        DataTerminoLabel.Location = New System.Drawing.Point(32, 152)
        DataTerminoLabel.Name = "DataTerminoLabel"
        DataTerminoLabel.Size = New System.Drawing.Size(89, 13)
        DataTerminoLabel.TabIndex = 23
        DataTerminoLabel.Text = "Data de Término:"
        '
        'ConsultasBindingSource
        '
        Me.ConsultasBindingSource.DataMember = "Consultas"
        Me.ConsultasBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'Gerenciamento_CRAFIDataSet
        '
        Me.Gerenciamento_CRAFIDataSet.DataSetName = "Gerenciamento_CRAFIDataSet"
        Me.Gerenciamento_CRAFIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrevistoRadioButton
        '
        Me.PrevistoRadioButton.Location = New System.Drawing.Point(127, 12)
        Me.PrevistoRadioButton.Name = "PrevistoRadioButton"
        Me.PrevistoRadioButton.Size = New System.Drawing.Size(66, 24)
        Me.PrevistoRadioButton.TabIndex = 18
        Me.PrevistoRadioButton.TabStop = True
        Me.PrevistoRadioButton.Text = "Previsto"
        Me.PrevistoRadioButton.UseVisualStyleBackColor = True
        '
        'ConfirmadoRadioButton
        '
        Me.ConfirmadoRadioButton.Location = New System.Drawing.Point(199, 12)
        Me.ConfirmadoRadioButton.Name = "ConfirmadoRadioButton"
        Me.ConfirmadoRadioButton.Size = New System.Drawing.Size(82, 24)
        Me.ConfirmadoRadioButton.TabIndex = 20
        Me.ConfirmadoRadioButton.TabStop = True
        Me.ConfirmadoRadioButton.Text = "Confirmado"
        Me.ConfirmadoRadioButton.UseVisualStyleBackColor = True
        '
        'ConsultasTableAdapter
        '
        Me.ConsultasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnamneseTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CirurgiasTableAdapter = Nothing
        Me.TableAdapterManager.ConsultasTableAdapter = Me.ConsultasTableAdapter
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
        'DataTerminoDateEdit
        '
        Me.DataTerminoDateEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataTerminoDateEdit.EditValue = Nothing
        Me.DataTerminoDateEdit.Location = New System.Drawing.Point(127, 148)
        Me.DataTerminoDateEdit.Name = "DataTerminoDateEdit"
        Me.DataTerminoDateEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DataTerminoDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataTerminoDateEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.DataTerminoDateEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataTerminoDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DataTerminoDateEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DataTerminoDateEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DataTerminoDateEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.DataTerminoDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.DataTerminoDateEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.DataTerminoDateEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.DataTerminoDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DataTerminoDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataTerminoDateEdit.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.DataTerminoDateEdit.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DataTerminoDateEdit.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.DataTerminoDateEdit.Size = New System.Drawing.Size(115, 20)
        Me.DataTerminoDateEdit.TabIndex = 8
        Me.DataTerminoDateEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'DataDateEdit
        '
        Me.DataDateEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataDateEdit.EditValue = Nothing
        Me.DataDateEdit.Location = New System.Drawing.Point(127, 122)
        Me.DataDateEdit.Name = "DataDateEdit"
        Me.DataDateEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DataDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataDateEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.DataDateEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.DataDateEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DataDateEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DataDateEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.DataDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.DataDateEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.DataDateEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.DataDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DataDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataDateEdit.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject4.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.DataDateEdit.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.DataDateEdit.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.DataDateEdit.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.DataDateEdit.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.DataDateEdit.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.DataDateEdit.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.DataDateEdit.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.DataDateEdit.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.DataDateEdit.Size = New System.Drawing.Size(115, 20)
        Me.DataDateEdit.TabIndex = 6
        Me.DataDateEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'EspecialidadeTextEdit
        '
        Me.EspecialidadeTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.EspecialidadeTextEdit.EditValue = ""
        Me.EspecialidadeTextEdit.Location = New System.Drawing.Point(127, 69)
        Me.EspecialidadeTextEdit.Name = "EspecialidadeTextEdit"
        Me.EspecialidadeTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.EspecialidadeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.EspecialidadeTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EspecialidadeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.EspecialidadeTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.EspecialidadeTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.EspecialidadeTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.EspecialidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.EspecialidadeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.EspecialidadeTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.EspecialidadeTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.EspecialidadeTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.EspecialidadeTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.EspecialidadeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.EspecialidadeTextEdit.Size = New System.Drawing.Size(327, 20)
        Me.EspecialidadeTextEdit.TabIndex = 3
        Me.EspecialidadeTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ValorTextEdit
        '
        Me.ValorTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ValorTextEdit.Location = New System.Drawing.Point(127, 174)
        Me.ValorTextEdit.Name = "ValorTextEdit"
        Me.ValorTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ValorTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ValorTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ValorTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ValorTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ValorTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ValorTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ValorTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ValorTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ValorTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ValorTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ValorTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ValorTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ValorTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ValorTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ValorTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ValorTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ValorTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ValorTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ValorTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ValorTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ValorTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ValorTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ValorTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ValorTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ValorTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ValorTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.ValorTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ValorTextEdit.Size = New System.Drawing.Size(115, 20)
        Me.ValorTextEdit.TabIndex = 10
        Me.ValorTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'MotivoMemoEdit
        '
        Me.MotivoMemoEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.MotivoMemoEdit.Location = New System.Drawing.Point(127, 200)
        Me.MotivoMemoEdit.Name = "MotivoMemoEdit"
        Me.MotivoMemoEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.MotivoMemoEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.MotivoMemoEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MotivoMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.MotivoMemoEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.MotivoMemoEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.MotivoMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.MotivoMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MotivoMemoEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.MotivoMemoEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.MotivoMemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.MotivoMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MotivoMemoEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.MotivoMemoEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.MotivoMemoEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.MotivoMemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MotivoMemoEdit.Size = New System.Drawing.Size(327, 100)
        Me.MotivoMemoEdit.TabIndex = 12
        Me.MotivoMemoEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ObservacaoMemoEdit
        '
        Me.ObservacaoMemoEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ObservacaoMemoEdit.Location = New System.Drawing.Point(127, 306)
        Me.ObservacaoMemoEdit.Name = "ObservacaoMemoEdit"
        Me.ObservacaoMemoEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ObservacaoMemoEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ObservacaoMemoEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ObservacaoMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ObservacaoMemoEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ObservacaoMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ObservacaoMemoEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ObservacaoMemoEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.ObservacaoMemoEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ObservacaoMemoEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ObservacaoMemoEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ObservacaoMemoEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ObservacaoMemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ObservacaoMemoEdit.Size = New System.Drawing.Size(327, 100)
        Me.ObservacaoMemoEdit.TabIndex = 13
        Me.ObservacaoMemoEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'AllDayEventCheckEdit
        '
        Me.AllDayEventCheckEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.AllDayEventCheckEdit.Location = New System.Drawing.Point(249, 175)
        Me.AllDayEventCheckEdit.Name = "AllDayEventCheckEdit"
        Me.AllDayEventCheckEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.AllDayEventCheckEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AllDayEventCheckEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AllDayEventCheckEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AllDayEventCheckEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.AllDayEventCheckEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AllDayEventCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.AllDayEventCheckEdit.Properties.Caption = "Evento Dia Inteiro"
        Me.AllDayEventCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.AllDayEventCheckEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.AllDayEventCheckEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.AllDayEventCheckEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.AllDayEventCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.AllDayEventCheckEdit.Size = New System.Drawing.Size(115, 19)
        Me.AllDayEventCheckEdit.TabIndex = 11
        Me.AllDayEventCheckEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'HorarioTimeEdit
        '
        Me.HorarioTimeEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HorarioTimeEdit.EditValue = New Date(2011, 3, 22, 0, 0, 0, 0)
        Me.HorarioTimeEdit.Location = New System.Drawing.Point(354, 123)
        Me.HorarioTimeEdit.Name = "HorarioTimeEdit"
        Me.HorarioTimeEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.HorarioTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HorarioTimeEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTimeEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTimeEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTimeEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTimeEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTimeEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTimeEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTimeEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTimeEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject5.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject5.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTimeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.HorarioTimeEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.HorarioTimeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.HorarioTimeEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.HorarioTimeEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.HorarioTimeEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.HorarioTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.HorarioTimeEdit.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.HorarioTimeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.HorarioTimeEdit.Size = New System.Drawing.Size(100, 20)
        Me.HorarioTimeEdit.TabIndex = 7
        Me.HorarioTimeEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'HorarioTerminoTimeEdit
        '
        Me.HorarioTerminoTimeEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HorarioTerminoTimeEdit.EditValue = New Date(2011, 3, 22, 0, 0, 0, 0)
        Me.HorarioTerminoTimeEdit.Location = New System.Drawing.Point(354, 149)
        Me.HorarioTerminoTimeEdit.Name = "HorarioTerminoTimeEdit"
        Me.HorarioTerminoTimeEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTerminoTimeEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.HorarioTerminoTimeEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTerminoTimeEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject6.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject6.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject6.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject6.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.HorarioTerminoTimeEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.HorarioTerminoTimeEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.HorarioTerminoTimeEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.HorarioTerminoTimeEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.HorarioTerminoTimeEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.HorarioTerminoTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.HorarioTerminoTimeEdit.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.HorarioTerminoTimeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.HorarioTerminoTimeEdit.Size = New System.Drawing.Size(100, 20)
        Me.HorarioTerminoTimeEdit.TabIndex = 9
        Me.HorarioTerminoTimeEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'DataTimeLabel
        '
        Me.DataTimeLabel.AutoSize = True
        Me.DataTimeLabel.Location = New System.Drawing.Point(304, 126)
        Me.DataTimeLabel.Name = "DataTimeLabel"
        Me.DataTimeLabel.Size = New System.Drawing.Size(44, 13)
        Me.DataTimeLabel.TabIndex = 37
        Me.DataTimeLabel.Text = "Horário:"
        '
        'DataTimeTerminoLabel
        '
        Me.DataTimeTerminoLabel.AutoSize = True
        Me.DataTimeTerminoLabel.Location = New System.Drawing.Point(248, 152)
        Me.DataTimeTerminoLabel.Name = "DataTimeTerminoLabel"
        Me.DataTimeTerminoLabel.Size = New System.Drawing.Size(100, 13)
        Me.DataTimeTerminoLabel.TabIndex = 38
        Me.DataTimeTerminoLabel.Text = "Horário de Término:"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(127, 464)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 16
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(208, 464)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'PacienteComboBox
        '
        Me.PacienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PacienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PacienteComboBox.DataSource = Me.PacientesBindingSource
        Me.PacienteComboBox.DisplayMember = "Nome"
        Me.PacienteComboBox.FormattingEnabled = True
        Me.PacienteComboBox.Location = New System.Drawing.Point(251, 95)
        Me.PacienteComboBox.Name = "PacienteComboBox"
        Me.PacienteComboBox.Size = New System.Drawing.Size(203, 21)
        Me.PacienteComboBox.TabIndex = 5
        Me.PacienteComboBox.ValueMember = "Nome"
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'PacienteTextBox
        '
        Me.PacienteTextBox.Location = New System.Drawing.Point(127, 95)
        Me.PacienteTextBox.Name = "PacienteTextBox"
        Me.PacienteTextBox.ReadOnly = True
        Me.PacienteTextBox.Size = New System.Drawing.Size(115, 20)
        Me.PacienteTextBox.TabIndex = 4
        '
        'SatisfacaoTextEdit
        '
        Me.SatisfacaoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.SatisfacaoTextEdit.Location = New System.Drawing.Point(127, 412)
        Me.SatisfacaoTextEdit.Name = "SatisfacaoTextEdit"
        Me.SatisfacaoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.SatisfacaoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.SatisfacaoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SatisfacaoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SatisfacaoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SatisfacaoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.SatisfacaoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.SatisfacaoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SatisfacaoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.SatisfacaoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SatisfacaoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.SatisfacaoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.SatisfacaoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.SatisfacaoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.SatisfacaoTextEdit.Size = New System.Drawing.Size(88, 20)
        Me.SatisfacaoTextEdit.TabIndex = 14
        Me.SatisfacaoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'SatisfacaoLabel
        '
        Me.SatisfacaoLabel.AutoSize = True
        Me.SatisfacaoLabel.Location = New System.Drawing.Point(61, 415)
        Me.SatisfacaoLabel.Name = "SatisfacaoLabel"
        Me.SatisfacaoLabel.Size = New System.Drawing.Size(60, 13)
        Me.SatisfacaoLabel.TabIndex = 52
        Me.SatisfacaoLabel.Text = "Satisfação:"
        '
        'ProfissionalComboBox
        '
        Me.ProfissionalComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ProfissionalComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProfissionalComboBox.DataSource = Me.ProfissionaisBindingSource
        Me.ProfissionalComboBox.DisplayMember = "Nome"
        Me.ProfissionalComboBox.FormattingEnabled = True
        Me.ProfissionalComboBox.Location = New System.Drawing.Point(251, 42)
        Me.ProfissionalComboBox.Name = "ProfissionalComboBox"
        Me.ProfissionalComboBox.Size = New System.Drawing.Size(203, 21)
        Me.ProfissionalComboBox.TabIndex = 15
        Me.ProfissionalComboBox.ValueMember = "Nome"
        '
        'ProfissionaisBindingSource
        '
        Me.ProfissionaisBindingSource.DataMember = "Profissionais"
        Me.ProfissionaisBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ProfissionalIdLabel
        '
        Me.ProfissionalIdLabel.AutoSize = True
        Me.ProfissionalIdLabel.Location = New System.Drawing.Point(58, 45)
        Me.ProfissionalIdLabel.Name = "ProfissionalIdLabel"
        Me.ProfissionalIdLabel.Size = New System.Drawing.Size(63, 13)
        Me.ProfissionalIdLabel.TabIndex = 54
        Me.ProfissionalIdLabel.Text = "Profissional:"
        '
        'btn_excluir
        '
        Me.btn_excluir.Location = New System.Drawing.Point(289, 464)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(75, 23)
        Me.btn_excluir.TabIndex = 55
        Me.btn_excluir.Text = "Excluir"
        Me.btn_excluir.UseVisualStyleBackColor = True
        '
        'btn_add_como_receita
        '
        Me.btn_add_como_receita.Location = New System.Drawing.Point(287, 13)
        Me.btn_add_como_receita.Name = "btn_add_como_receita"
        Me.btn_add_como_receita.Size = New System.Drawing.Size(128, 23)
        Me.btn_add_como_receita.TabIndex = 56
        Me.btn_add_como_receita.Text = "Adicionar como Receita"
        Me.btn_add_como_receita.UseVisualStyleBackColor = True
        '
        'ReceitaBindingSource
        '
        Me.ReceitaBindingSource.DataMember = "Receita"
        Me.ReceitaBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'ReceitaTableAdapter
        '
        Me.ReceitaTableAdapter.ClearBeforeFill = True
        '
        'ReciboCheckEdit
        '
        Me.ReciboCheckEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ReciboCheckEdit.Location = New System.Drawing.Point(370, 175)
        Me.ReciboCheckEdit.Name = "ReciboCheckEdit"
        Me.ReciboCheckEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ReciboCheckEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ReciboCheckEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ReciboCheckEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ReciboCheckEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ReciboCheckEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ReciboCheckEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ReciboCheckEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ReciboCheckEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ReciboCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ReciboCheckEdit.Properties.Caption = "Recibo"
        Me.ReciboCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard
        Me.ReciboCheckEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ReciboCheckEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ReciboCheckEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ReciboCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked
        Me.ReciboCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.ReciboCheckEdit.TabIndex = 57
        Me.ReciboCheckEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'ContagemReceitaTextBox
        '
        Me.ContagemReceitaTextBox.Location = New System.Drawing.Point(340, 412)
        Me.ContagemReceitaTextBox.Name = "ContagemReceitaTextBox"
        Me.ContagemReceitaTextBox.ReadOnly = True
        Me.ContagemReceitaTextBox.Size = New System.Drawing.Size(59, 20)
        Me.ContagemReceitaTextBox.TabIndex = 59
        '
        'txtProfissionalId
        '
        Me.txtProfissionalId.Location = New System.Drawing.Point(127, 438)
        Me.txtProfissionalId.Name = "txtProfissionalId"
        Me.txtProfissionalId.ReadOnly = True
        Me.txtProfissionalId.Size = New System.Drawing.Size(88, 20)
        Me.txtProfissionalId.TabIndex = 60
        '
        'txtProfissional
        '
        Me.txtProfissional.Location = New System.Drawing.Point(127, 43)
        Me.txtProfissional.Name = "txtProfissional"
        Me.txtProfissional.ReadOnly = True
        Me.txtProfissional.Size = New System.Drawing.Size(115, 20)
        Me.txtProfissional.TabIndex = 61
        '
        'ProfissionaisTableAdapter
        '
        Me.ProfissionaisTableAdapter.ClearBeforeFill = True
        '
        'lblContagemReceita
        '
        Me.lblContagemReceita.AutoSize = True
        Me.lblContagemReceita.Location = New System.Drawing.Point(221, 415)
        Me.lblContagemReceita.Name = "lblContagemReceita"
        Me.lblContagemReceita.Size = New System.Drawing.Size(113, 13)
        Me.lblContagemReceita.TabIndex = 62
        Me.lblContagemReceita.Text = "Contagem da Receita:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(100, 441)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 63
        Me.lblID.Text = "ID:"
        '
        'form_incluir_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(474, 498)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblContagemReceita)
        Me.Controls.Add(Me.txtProfissional)
        Me.Controls.Add(Me.txtProfissionalId)
        Me.Controls.Add(Me.ContagemReceitaTextBox)
        Me.Controls.Add(Me.ReciboCheckEdit)
        Me.Controls.Add(Me.btn_add_como_receita)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.ProfissionalIdLabel)
        Me.Controls.Add(Me.ProfissionalComboBox)
        Me.Controls.Add(Me.SatisfacaoLabel)
        Me.Controls.Add(Me.SatisfacaoTextEdit)
        Me.Controls.Add(Me.PacienteTextBox)
        Me.Controls.Add(Me.PacienteComboBox)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.DataTimeTerminoLabel)
        Me.Controls.Add(Me.DataTimeLabel)
        Me.Controls.Add(Me.HorarioTerminoTimeEdit)
        Me.Controls.Add(Me.HorarioTimeEdit)
        Me.Controls.Add(Me.AllDayEventCheckEdit)
        Me.Controls.Add(Me.ObservacaoMemoEdit)
        Me.Controls.Add(Me.MotivoMemoEdit)
        Me.Controls.Add(Me.ValorTextEdit)
        Me.Controls.Add(Me.EspecialidadeTextEdit)
        Me.Controls.Add(Me.DataDateEdit)
        Me.Controls.Add(Me.DataTerminoDateEdit)
        Me.Controls.Add(DataTerminoLabel)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ConfirmadoRadioButton)
        Me.Controls.Add(Me.PrevistoRadioButton)
        Me.Controls.Add(EspecialidadeLabel)
        Me.Controls.Add(ObservacaoLabel)
        Me.Controls.Add(MotivoLabel)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(NomeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_incluir_consulta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTerminoDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTerminoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspecialidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotivoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObservacaoMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDayEventCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioTerminoTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatisfacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfissionaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceitaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReciboCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ConsultasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConsultasTableAdapter
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents PrevistoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ConfirmadoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DataTerminoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DataDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EspecialidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ValorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MotivoMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ObservacaoMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents AllDayEventCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents HorarioTimeEdit As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents HorarioTerminoTimeEdit As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents DataTimeLabel As System.Windows.Forms.Label
    Friend WithEvents DataTimeTerminoLabel As System.Windows.Forms.Label
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents PacientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PacientesTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents PacienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PacienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SatisfacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SatisfacaoLabel As System.Windows.Forms.Label
    Friend WithEvents ProfissionalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProfissionalIdLabel As System.Windows.Forms.Label
    Friend WithEvents btn_excluir As System.Windows.Forms.Button
    Friend WithEvents btn_add_como_receita As System.Windows.Forms.Button
    Friend WithEvents ReceitaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceitaTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ReceitaTableAdapter
    Friend WithEvents ReciboCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents ContagemReceitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtProfissionalId As System.Windows.Forms.TextBox
    Friend WithEvents txtProfissional As System.Windows.Forms.TextBox
    Friend WithEvents ProfissionaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfissionaisTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ProfissionaisTableAdapter
    Friend WithEvents lblContagemReceita As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
