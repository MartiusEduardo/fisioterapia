<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_agenda
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.AgendaSchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ConsultasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gerenciamento_CRAFIDataSet = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dn_agenda = New DevExpress.XtraScheduler.DateNavigator()
        Me.sc_agenda = New DevExpress.XtraScheduler.SchedulerControl()
        Me.btn_atualizar = New System.Windows.Forms.Button()
        Me.BuscaAgendaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PacienteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PacienteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ProfissionalToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ProfissionalToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DataToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DataToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DataTerminoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DataTerminoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConsultasTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConsultasTableAdapter()
        Me.TableAdapterManager = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager()
        Me.LogControleTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter()
        Me.LoginTableAdapter = New Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter()
        CType(Me.AgendaSchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dn_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sc_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuscaAgendaToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AgendaSchedulerStorage
        '
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Confirmado", "Confirmado", DevExpress.XtraScheduler.FieldValueType.[Boolean]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Especialidade", "Especialidade", DevExpress.XtraScheduler.FieldValueType.[String]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Motivo", "Motivo", DevExpress.XtraScheduler.FieldValueType.[String]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Previsto", "Previsto", DevExpress.XtraScheduler.FieldValueType.[Boolean]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("RecurrenceInfo", "RecurrenceInfo", DevExpress.XtraScheduler.FieldValueType.[String]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Satisfacao", "Satisfacao", DevExpress.XtraScheduler.FieldValueType.[Integer]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Valor", "Valor", DevExpress.XtraScheduler.FieldValueType.[Object]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Recibo", "Recibo", DevExpress.XtraScheduler.FieldValueType.[Boolean]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ContagemReceita", "ContagemReceita", DevExpress.XtraScheduler.FieldValueType.[Object]))
        Me.AgendaSchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Profissional", "Profissional", DevExpress.XtraScheduler.FieldValueType.[Object]))
        Me.AgendaSchedulerStorage.Appointments.DataSource = Me.ConsultasBindingSource
        Me.AgendaSchedulerStorage.Appointments.DateSaving = DevExpress.XtraScheduler.DateSavingType.LocalTime
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(190, Byte), Integer)), "Importante", "&Importante"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer)), "Negócios", "&Negócios"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(156, Byte), Integer)), "Pessoal", "&Pessoal"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(199, Byte), Integer)), "Férias", "&Férias"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(147, Byte), Integer)), "Deve Comparecer", "&Deve Comparecer"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer)), "Viagem Necessária", "&Viagem Necessária"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(152, Byte), Integer)), "Precisa Preparação", "P&recisa Preparação"))
        Me.AgendaSchedulerStorage.Appointments.Labels.Add(New DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(165, Byte), Integer)), "Chamada", "&Chamada"))
        Me.AgendaSchedulerStorage.Appointments.Mappings.AllDay = "AllDayEvent"
        Me.AgendaSchedulerStorage.Appointments.Mappings.Description = "Observacao"
        Me.AgendaSchedulerStorage.Appointments.Mappings.End = "DataTermino"
        Me.AgendaSchedulerStorage.Appointments.Mappings.Label = "Label"
        Me.AgendaSchedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.AgendaSchedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.AgendaSchedulerStorage.Appointments.Mappings.ResourceId = "ProfissionalId"
        Me.AgendaSchedulerStorage.Appointments.Mappings.Start = "Data"
        Me.AgendaSchedulerStorage.Appointments.Mappings.Status = "Status"
        Me.AgendaSchedulerStorage.Appointments.Mappings.Subject = "Paciente"
        Me.AgendaSchedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Free, "Livre", "&Livre"))
        Me.AgendaSchedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Tentative, System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(226, Byte), Integer)), "Experimental", "&Experimental"))
        Me.AgendaSchedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.Busy, System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(226, Byte), Integer)), "Ocupado", "&Ocupado"))
        Me.AgendaSchedulerStorage.Appointments.Statuses.Add(New DevExpress.XtraScheduler.AppointmentStatus(DevExpress.XtraScheduler.AppointmentStatusType.OutOfOffice, System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(83, Byte), Integer)), "Fora do Escritório", "&Fora do Escritório"))
        Me.AgendaSchedulerStorage.Resources.ColorSaving = DevExpress.XtraScheduler.ColorSavingType.OleColor
        Me.AgendaSchedulerStorage.Resources.DataSource = Me.LoginBindingSource
        Me.AgendaSchedulerStorage.Resources.Mappings.Caption = "Usuario"
        Me.AgendaSchedulerStorage.Resources.Mappings.Color = "Tipo"
        Me.AgendaSchedulerStorage.Resources.Mappings.Id = "Codigo"
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
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.Gerenciamento_CRAFIDataSet
        '
        'dn_agenda
        '
        Me.dn_agenda.AppearanceCalendar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dn_agenda.AppearanceCalendar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dn_agenda.AppearanceCalendar.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dn_agenda.AppearanceCalendar.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dn_agenda.AppearanceCalendar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dn_agenda.AppearanceCalendar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dn_agenda.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dn_agenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dn_agenda.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dn_agenda.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dn_agenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dn_agenda.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dn_agenda.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.dn_agenda.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.dn_agenda.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.dn_agenda.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.dn_agenda.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.dn_agenda.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.dn_agenda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.dn_agenda.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.dn_agenda.Dock = System.Windows.Forms.DockStyle.Right
        Me.dn_agenda.HotDate = Nothing
        Me.dn_agenda.Location = New System.Drawing.Point(561, 25)
        Me.dn_agenda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.dn_agenda.Name = "dn_agenda"
        Me.dn_agenda.SchedulerControl = Me.sc_agenda
        Me.dn_agenda.Size = New System.Drawing.Size(178, 253)
        Me.dn_agenda.TabIndex = 1
        Me.dn_agenda.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        '
        'sc_agenda
        '
        Me.sc_agenda.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
        Me.sc_agenda.Appearance.AlternateHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.AlternateHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.AlternateHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.sc_agenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc_agenda.DragDropMode = DevExpress.XtraScheduler.DragDropMode.Standard
        Me.sc_agenda.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.[Date]
        Me.sc_agenda.Location = New System.Drawing.Point(0, 48)
        Me.sc_agenda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.sc_agenda.Name = "sc_agenda"
        Me.sc_agenda.OptionsBehavior.RecurrentAppointmentDeleteAction = DevExpress.XtraScheduler.RecurrentAppointmentAction.Ask
        Me.sc_agenda.OptionsBehavior.RecurrentAppointmentEditAction = DevExpress.XtraScheduler.RecurrentAppointmentAction.Occurrence
        Me.sc_agenda.OptionsBehavior.RemindersFormDefaultAction = DevExpress.XtraScheduler.RemindersFormDefaultAction.DismissAll
        Me.sc_agenda.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Allowed
        Me.sc_agenda.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsCustomization.AllowDisplayAppointmentForm = DevExpress.XtraScheduler.AllowDisplayAppointmentForm.[Auto]
        Me.sc_agenda.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.All
        Me.sc_agenda.OptionsPrint.PrintStyle = DevExpress.XtraScheduler.Printing.SchedulerPrintStyleKind.[Default]
        Me.sc_agenda.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.System
        Me.sc_agenda.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.OptionsView.ResourceHeaders.Height = 75
        Me.sc_agenda.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Left
        Me.sc_agenda.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.CenterImage
        Me.sc_agenda.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Standard
        Me.sc_agenda.ResourceNavigator.Visibility = DevExpress.XtraScheduler.ResourceNavigatorVisibility.[Auto]
        Me.sc_agenda.Size = New System.Drawing.Size(561, 230)
        Me.sc_agenda.Start = New Date(2011, 3, 22, 0, 0, 0, 0)
        Me.sc_agenda.Storage = Me.AgendaSchedulerStorage
        Me.sc_agenda.TabIndex = 3
        Me.sc_agenda.Text = "CRAFI"
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AllDayAreaSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.AlternateHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.SelectedAllDayArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRuler.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerHourLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.DayView.Appearance.TimeRulerNowLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never
        Me.sc_agenda.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.DayView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.Views.DayView.ResourcesPerPage = 1
        Me.sc_agenda.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.CellHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.MonthView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.Views.MonthView.ResourcesPerPage = 1
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.AlternateHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.TimelineView.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.TimelineView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.Views.TimelineView.OptionsSelectionBehavior.UpdateSelectionDurationAction = DevExpress.XtraScheduler.UpdateSelectionDurationAction.Reset
        Me.sc_agenda.Views.TimelineView.ResourcesPerPage = 1
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.CellHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WeekView.Appearance.TodayCellHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WeekView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.WeekView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.WeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.Views.WeekView.ResourcesPerPage = 1
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AllDayAreaSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.AlternateHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.NavigationButtonDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.ResourceHeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.SelectedAllDayArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.Selection.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRuler.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerHourLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.sc_agenda.Views.WorkWeekView.Appearance.TimeRulerNowLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.sc_agenda.Views.WorkWeekView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Never
        Me.sc_agenda.Views.WorkWeekView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.WorkWeekView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.[Auto]
        Me.sc_agenda.Views.WorkWeekView.NavigationButtonVisibility = DevExpress.XtraScheduler.NavigationButtonVisibility.[Auto]
        Me.sc_agenda.Views.WorkWeekView.ResourcesPerPage = 1
        Me.sc_agenda.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'btn_atualizar
        '
        Me.btn_atualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_atualizar.Location = New System.Drawing.Point(0, 25)
        Me.btn_atualizar.Name = "btn_atualizar"
        Me.btn_atualizar.Size = New System.Drawing.Size(561, 23)
        Me.btn_atualizar.TabIndex = 4
        Me.btn_atualizar.Text = "Atualizar"
        Me.btn_atualizar.UseVisualStyleBackColor = True
        '
        'BuscaAgendaToolStrip
        '
        Me.BuscaAgendaToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BuscaAgendaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripLabel, Me.PacienteToolStripTextBox, Me.ProfissionalToolStripLabel, Me.ProfissionalToolStripTextBox, Me.DataToolStripLabel, Me.DataToolStripTextBox, Me.DataTerminoToolStripLabel, Me.DataTerminoToolStripTextBox, Me.BuscarToolStripButton})
        Me.BuscaAgendaToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.BuscaAgendaToolStrip.Name = "BuscaAgendaToolStrip"
        Me.BuscaAgendaToolStrip.Size = New System.Drawing.Size(739, 25)
        Me.BuscaAgendaToolStrip.TabIndex = 5
        Me.BuscaAgendaToolStrip.Text = "ToolStrip1"
        '
        'PacienteToolStripLabel
        '
        Me.PacienteToolStripLabel.Name = "PacienteToolStripLabel"
        Me.PacienteToolStripLabel.Size = New System.Drawing.Size(55, 22)
        Me.PacienteToolStripLabel.Text = "Paciente:"
        '
        'PacienteToolStripTextBox
        '
        Me.PacienteToolStripTextBox.Name = "PacienteToolStripTextBox"
        Me.PacienteToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ProfissionalToolStripLabel
        '
        Me.ProfissionalToolStripLabel.Name = "ProfissionalToolStripLabel"
        Me.ProfissionalToolStripLabel.Size = New System.Drawing.Size(71, 22)
        Me.ProfissionalToolStripLabel.Text = "Profissional:"
        '
        'ProfissionalToolStripTextBox
        '
        Me.ProfissionalToolStripTextBox.Name = "ProfissionalToolStripTextBox"
        Me.ProfissionalToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DataToolStripLabel
        '
        Me.DataToolStripLabel.Name = "DataToolStripLabel"
        Me.DataToolStripLabel.Size = New System.Drawing.Size(34, 22)
        Me.DataToolStripLabel.Text = "Data:"
        '
        'DataToolStripTextBox
        '
        Me.DataToolStripTextBox.Name = "DataToolStripTextBox"
        Me.DataToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DataTerminoToolStripLabel
        '
        Me.DataTerminoToolStripLabel.Name = "DataTerminoToolStripLabel"
        Me.DataTerminoToolStripLabel.Size = New System.Drawing.Size(79, 22)
        Me.DataTerminoToolStripLabel.Text = "Data término:"
        '
        'DataTerminoToolStripTextBox
        '
        Me.DataTerminoToolStripTextBox.Name = "DataTerminoToolStripTextBox"
        Me.DataTerminoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'BuscarToolStripButton
        '
        Me.BuscarToolStripButton.Image = Global.Gerenciamento_CRAFI.My.Resources.Resources._4998_32x32
        Me.BuscarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarToolStripButton.Name = "BuscarToolStripButton"
        Me.BuscarToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.BuscarToolStripButton.Text = "Buscar"
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
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'form_agenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 278)
        Me.Controls.Add(Me.sc_agenda)
        Me.Controls.Add(Me.btn_atualizar)
        Me.Controls.Add(Me.dn_agenda)
        Me.Controls.Add(Me.BuscaAgendaToolStrip)
        Me.Name = "form_agenda"
        Me.ShowIcon = False
        Me.Text = "Agenda"
        CType(Me.AgendaSchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gerenciamento_CRAFIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dn_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sc_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuscaAgendaToolStrip.ResumeLayout(False)
        Me.BuscaAgendaToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AgendaSchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents Gerenciamento_CRAFIDataSet As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSet
    Friend WithEvents ConsultasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultasTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.ConsultasTableAdapter
    Friend WithEvents dn_agenda As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents TableAdapterManager As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LogControleTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LogControleTableAdapter
    Friend WithEvents sc_agenda As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents btn_atualizar As System.Windows.Forms.Button
    Friend WithEvents BuscaAgendaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PacienteToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PacienteToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ProfissionalToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ProfissionalToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataTerminoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataTerminoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BuscarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoginBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoginTableAdapter As Gerenciamento_CRAFI.Gerenciamento_CRAFIDataSetTableAdapters.LoginTableAdapter
End Class
