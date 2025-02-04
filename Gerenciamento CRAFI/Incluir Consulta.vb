Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI

Partial Public Class form_incluir_consulta

    Private control As SchedulerControl
    Private apt As Appointment
    Private openRecurrenceForm As Boolean = False
    Private suspendUpdateCount As Integer
    Private WithEvents checkAllDay As DevExpress.XtraEditors.CheckEdit
    Private controller As MyAppointmentFormController

    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
        Me.openRecurrenceForm = openRecurrenceForm
        Me.controller = New MyAppointmentFormController(control, apt)
        Me.apt = apt
        Me.control = control
        '
        ' Required for Windows Form Designer support
        '
        SuspendUpdate()
        InitializeComponent()
        ResumeUpdate()

        UpdateForm()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

    Protected ReadOnly Property Appointments() As AppointmentStorage
        Get
            Return control.Storage.Appointments
        End Get
    End Property
    Protected Friend ReadOnly Property IsNewAppointment() As Boolean
        Get
            If Not controller Is Nothing Then
                Return controller.IsNewAppointment
            Else
                Return True
            End If
        End Get
    End Property
    Protected ReadOnly Property IsUpdateSuspended() As Boolean
        Get
            Return suspendUpdateCount > 0
        End Get
    End Property

    Protected Sub SuspendUpdate()
        suspendUpdateCount += 1
    End Sub
    Protected Sub ResumeUpdate()
        If suspendUpdateCount > 0 Then
            suspendUpdateCount -= 1
        End If
    End Sub

    'Private Sub btn_recorrencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'OnRecurrenceButton()
    'End Sub

    Private Sub OnRecurrenceButton()
        ShowRecurrenceForm()
    End Sub

    Private Sub ShowRecurrenceForm()

        If (Not control.SupportsRecurrence) Then
            Return
        End If

        ' Prepare to edit appointment's recurrence.
        Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
        Dim editedPattern As Appointment = controller.EditedPattern
        Dim patternCopy As Appointment = controller.PrepareToRecurrenceEdit()

        Dim dlg As AppointmentRecurrenceForm = New AppointmentRecurrenceForm(patternCopy, control.OptionsView.FirstDayOfWeek, controller)

        ' Required for skins support.
        'dlg.LookAndFeel.ParentLookAndFeel = Me.LookAndFeel.ParentLookAndFeel

        Dim result As DialogResult = dlg.ShowDialog(Me)
        dlg.Dispose()

        If result = Windows.Forms.DialogResult.Abort Then
            controller.RemoveRecurrence()
        Else
            If result = System.Windows.Forms.DialogResult.OK Then
                controller.ApplyRecurrence(patternCopy)
                If Not controller.EditedAppointmentCopy Is editedAptCopy Then
                    UpdateForm()
                End If
            End If
        End If
        UpdateIntervalControls()
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        atualizarController()
        ' Save all changes made to the appointment edited in a form.
        controller.ApplyChanges()
        Me.Close()
    End Sub

    Private Sub atualizarController()
        ' Required to check appointment's conflicts.
        If (Not controller.IsConflictResolved()) Then
            Return
        End If

        If Not IsNumeric(ValorTextEdit.Text) Then
            ValorTextEdit.Text = 0
        End If

        If Not IsNumeric(SatisfacaoTextEdit.Text) Then
            SatisfacaoTextEdit.Text = 0
        End If

        'controller.ResourceId = txtProfissionalId.Text
        controller.Profissional = txtProfissional.Text
        controller.Subject = PacienteTextBox.Text
        controller.Description = ObservacaoMemoEdit.Text
        'ontroller.SetStatus(edStatus.Status)
        'controller.SetLabel(edLabel.Label)
        controller.AllDay = Me.AllDayEventCheckEdit.Checked
        controller.Start = Me.DataDateEdit.DateTime.Date + Me.HorarioTimeEdit.Time.TimeOfDay
        controller.End = Me.DataTerminoDateEdit.DateTime.Date + Me.HorarioTerminoTimeEdit.Time.TimeOfDay
        controller.Especialidade = EspecialidadeTextEdit.Text
        controller.Motivo = MotivoMemoEdit.Text
        controller.Valor = ValorTextEdit.Text
        controller.Previsto = PrevistoRadioButton.Checked
        controller.Confirmado = ConfirmadoRadioButton.Checked
        controller.Satisfacao = SatisfacaoTextEdit.Text
        controller.Recibo = ReciboCheckEdit.Checked
        controller.ContagemReceita = ContagemReceitaTextBox.Text
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub UpdateForm()
        SuspendUpdate()
        Try
            txtProfissionalId.Text = controller.ResourceId
            txtProfissional.Text = controller.Profissional
            PacienteTextBox.Text = controller.Subject
            ObservacaoMemoEdit.Text = controller.Description
            'edStatus.Status = Appointments.Statuses(controller.StatusId)
            'edLabel.Label = Appointments.Labels(controller.LabelId)

            DataDateEdit.DateTime = controller.Start.Date
            DataTerminoDateEdit.DateTime = controller.End.Date

            HorarioTimeEdit.Time = DateTime.MinValue.AddTicks(controller.Start.TimeOfDay.Ticks)
            HorarioTerminoTimeEdit.Time = DateTime.MinValue.AddTicks(controller.End.TimeOfDay.Ticks)
            AllDayEventCheckEdit.Checked = controller.AllDay

            'edStatus.Storage = control.Storage
            'edLabel.Storage = control.Storage

            EspecialidadeTextEdit.Text = controller.Especialidade
            MotivoMemoEdit.Text = controller.Motivo
            ValorTextEdit.Text = controller.Valor
            SatisfacaoTextEdit.Text = controller.Satisfacao
            PrevistoRadioButton.Checked = controller.Previsto
            ConfirmadoRadioButton.Checked = controller.Confirmado
            ReciboCheckEdit.Checked = controller.Recibo
            ContagemReceitaTextBox.Text = controller.ContagemReceita
        Finally
            ResumeUpdate()
        End Try
        UpdateIntervalControls()
    End Sub

    Private Sub MyAppointmentEditForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ' Required to show the recurrence form.
        If openRecurrenceForm Then
            openRecurrenceForm = False
            OnRecurrenceButton()
        End If
    End Sub

    Private Sub dtStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataDateEdit.EditValueChanged
        If (Not IsUpdateSuspended) Then
            controller.Start = DataDateEdit.DateTime.Date + HorarioTimeEdit.Time.TimeOfDay
        End If
        UpdateIntervalControls()
    End Sub
    Protected Overridable Sub UpdateIntervalControls()
        If IsUpdateSuspended Then
            Return
        End If

        SuspendUpdate()
        Try
            DataDateEdit.EditValue = controller.Start.Date
            DataTerminoDateEdit.EditValue = controller.End.Date
            HorarioTimeEdit.EditValue = controller.Start.TimeOfDay
            HorarioTerminoTimeEdit.EditValue = controller.End.TimeOfDay

            Dim editedAptCopy As Appointment = controller.EditedAppointmentCopy
            Dim showControls As Boolean = IsNewAppointment OrElse editedAptCopy.Type <> AppointmentType.Pattern
            DataDateEdit.Enabled = showControls
            DataTerminoDateEdit.Enabled = showControls
            Dim enableTime As Boolean = showControls AndAlso Not controller.AllDay
            HorarioTimeEdit.Visible = enableTime
            HorarioTimeEdit.Enabled = enableTime
            HorarioTerminoTimeEdit.Visible = enableTime
            HorarioTerminoTimeEdit.Enabled = enableTime
            AllDayEventCheckEdit.Enabled = showControls
        Finally
            ResumeUpdate()
        End Try
    End Sub
    Private Sub timeStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HorarioTimeEdit.EditValueChanged
        If (Not IsUpdateSuspended) Then
            controller.Start = DataDateEdit.DateTime.Date + HorarioTimeEdit.Time.TimeOfDay
        End If
        UpdateIntervalControls()
    End Sub
    Private Sub timeEnd_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HorarioTerminoTimeEdit.EditValueChanged
        If IsUpdateSuspended Then
            Return
        End If
        If IsIntervalValid() Then
            controller.End = DataTerminoDateEdit.DateTime.Date + HorarioTerminoTimeEdit.Time.TimeOfDay
        Else
            HorarioTerminoTimeEdit.EditValue = controller.End.TimeOfDay
        End If
    End Sub
    Private Sub DataTerminoDataEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataTerminoDateEdit.EditValueChanged
        If IsUpdateSuspended Then
            Return
        End If
        If IsIntervalValid() Then
            controller.End = DataTerminoDateEdit.DateTime.Date + HorarioTerminoTimeEdit.Time.TimeOfDay
        Else
            DataTerminoDateEdit.EditValue = controller.End.Date
        End If
    End Sub
    Private Function IsIntervalValid() As Boolean
        Dim lStart As DateTime = DataDateEdit.DateTime + HorarioTimeEdit.Time.TimeOfDay
        Dim lEnd As DateTime = DataTerminoDateEdit.DateTime + HorarioTerminoTimeEdit.Time.TimeOfDay
        Return lEnd >= lStart
    End Function

    Private Sub checkAllDay_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkAllDay.CheckedChanged
        controller.AllDay = Me.checkAllDay.Checked
        If (Not IsUpdateSuspended) Then
            UpdateAppointmentStatus()
        End If

        UpdateIntervalControls()
    End Sub
    Private Sub UpdateAppointmentStatus()
        'Dim currentStatus As AppointmentStatus = edStatus.Status
        'Dim newStatus As AppointmentStatus = controller.UpdateAppointmentStatus(currentStatus)
        'If Not newStatus Is currentStatus Then
        '    edStatus.Status = newStatus
        'End If
    End Sub

    Private Sub form_incluir_consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            ReceitaTableAdapter.Connection.ConnectionString = conexao.strConexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            PacienteComboBox.Text = ""
            ProfissionalComboBox.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_excluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excluir.Click
        Try
            controller.DeleteAppointment()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_add_como_receita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_como_receita.Click
        Try
            If Trim(PacienteTextBox.Text) = "" Then
                MsgBox("O campo paciente está vazio.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If Not IsNumeric(ValorTextEdit.Text) Then
                MsgBox("O valor da consulta não é um valor correto.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If ContagemReceitaTextBox.Text > 0 Then
                If MsgBox("Esta receita já foi adicionada " & ContagemReceitaTextBox.Text & " vez(es), deseja adicioná-la novamente?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If
            ReceitaTableAdapter.Insert(txtProfissional.Text, PacienteTextBox.Text, MotivoMemoEdit.Text, Today, Today, Today, Today, ValorTextEdit.Text, ObservacaoMemoEdit.Text)
            ContagemReceitaTextBox.Text += 1
            atualizarController()
            controller.ApplyChanges()
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "inseriu receita", DateTime.Now)
            MsgBox("Receita incluída com sucesso.", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PacienteComboBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles PacienteComboBox.TextUpdate
        Try
            PacienteTextBox.Text = PacienteComboBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ValorTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValorTextEdit.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SatisfacaoTextEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SatisfacaoTextEdit.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PacienteComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteComboBox.SelectedIndexChanged
        Try
            PacienteTextBox.Text = PacienteComboBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ProfissionalComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionalComboBox.SelectedIndexChanged
        Try
            txtProfissional.Text = ProfissionalComboBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ProfissionalComboBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProfissionalComboBox.TextUpdate
        Try
            txtProfissional.Text = ProfissionalComboBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class

Friend Class MyAppointmentFormController
    Inherits AppointmentFormController

    Public Property Especialidade() As String
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Especialidade")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Especialidade")) Then
                EditedAppointmentCopy.CustomFields("Especialidade") = "Especialidade"
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Especialidade"))
        End Get
        Set(ByVal value As String)
            EditedAppointmentCopy.CustomFields("Especialidade") = value
        End Set
    End Property

    Public Property Motivo() As String
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Motivo")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Motivo")) Then
                EditedAppointmentCopy.CustomFields("Motivo") = "Motivo"
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Motivo"))
        End Get
        Set(ByVal value As String)
            EditedAppointmentCopy.CustomFields("Motivo") = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Valor")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Valor")) Then
                EditedAppointmentCopy.CustomFields("Valor") = 0.0
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Valor"))
        End Get
        Set(ByVal value As Double)
            EditedAppointmentCopy.CustomFields("Valor") = value
        End Set
    End Property

    Public Property Previsto() As Boolean
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Previsto")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Previsto")) Then
                EditedAppointmentCopy.CustomFields("Previsto") = True
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Previsto"))
        End Get
        Set(ByVal value As Boolean)
            EditedAppointmentCopy.CustomFields("Previsto") = value
        End Set
    End Property

    Public Property Confirmado() As Boolean
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Confirmado")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Confirmado")) Then
                EditedAppointmentCopy.CustomFields("Confirmado") = False
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Confirmado"))
        End Get
        Set(ByVal value As Boolean)
            EditedAppointmentCopy.CustomFields("Confirmado") = value
        End Set
    End Property

    Public Property Satisfacao() As Integer
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Satisfacao")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Satisfacao")) Then
                EditedAppointmentCopy.CustomFields("Satisfacao") = 0
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Satisfacao"))
        End Get
        Set(ByVal value As Integer)
            EditedAppointmentCopy.CustomFields("Satisfacao") = value
        End Set
    End Property

    Public Property Recibo() As Boolean
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Recibo")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Recibo")) Then
                EditedAppointmentCopy.CustomFields("Recibo") = False
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Recibo"))
        End Get
        Set(ByVal value As Boolean)
            EditedAppointmentCopy.CustomFields("Recibo") = value
        End Set
    End Property

    Public Property ContagemReceita() As Integer
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("ContagemReceita")) Or IsDBNull(EditedAppointmentCopy.CustomFields("ContagemReceita")) Then
                EditedAppointmentCopy.CustomFields("ContagemReceita") = 0
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("ContagemReceita"))
        End Get
        Set(ByVal value As Integer)
            EditedAppointmentCopy.CustomFields("ContagemReceita") = value
        End Set
    End Property

    Public Property Profissional() As String
        Get
            If IsNothing(EditedAppointmentCopy.CustomFields("Profissional")) Or IsDBNull(EditedAppointmentCopy.CustomFields("Profissional")) Then
                EditedAppointmentCopy.CustomFields("Profissional") = form_principal.ToolStripStatusLabel.Text
            End If
            Return CStr(EditedAppointmentCopy.CustomFields("Profissional"))
        End Get
        Set(ByVal value As String)
            EditedAppointmentCopy.CustomFields("Profissional") = value
        End Set
    End Property

    'SOURCE
    Private Property SourceEspecialidade() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Especialidade"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Especialidade") = value
        End Set
    End Property

    Private Property SourceMotivo() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Motivo"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Motivo") = value
        End Set
    End Property

    Private Property SourceValor() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Valor"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Valor") = value
        End Set
    End Property

    Private Property SourcePrevisto() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Previsto"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Previsto") = value
        End Set
    End Property

    Private Property SourceConfirmado() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Confirmado"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Confirmado") = value
        End Set
    End Property

    Private Property SourceSatisfacao() As Integer
        Get
            Return CStr(SourceAppointment.CustomFields("Satisfacao"))
        End Get
        Set(ByVal value As Integer)
            SourceAppointment.CustomFields("Satisfacao") = value
        End Set
    End Property

    Private Property SourceRecibo() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Recibo"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Recibo") = value
        End Set
    End Property

    Private Property SourceContagemReceita() As Integer
        Get
            Return CStr(SourceAppointment.CustomFields("ContagemReceita"))
        End Get
        Set(ByVal value As Integer)
            SourceAppointment.CustomFields("ContagemReceita") = value
        End Set
    End Property

    Private Property SourceProfissional() As String
        Get
            Return CStr(SourceAppointment.CustomFields("Profissional"))
        End Get
        Set(ByVal value As String)
            SourceAppointment.CustomFields("Profissional") = value
        End Set
    End Property

    'TERMINA SOURCEs dos Custom Fields
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
        MyBase.New(control, apt)
    End Sub

    Public Overrides Function IsAppointmentChanged() As Boolean
        If MyBase.IsAppointmentChanged() Then
            Return True
        End If
        Return SourceEspecialidade <> Especialidade OrElse SourceMotivo <> Motivo OrElse SourceValor <> Valor OrElse SourcePrevisto <> Previsto OrElse SourceConfirmado <> Confirmado OrElse SourceSatisfacao <> Satisfacao OrElse SourceRecibo <> Recibo OrElse SourceContagemReceita <> ContagemReceita OrElse SourceProfissional <> Profissional
    End Function

    Protected Overrides Sub ApplyCustomFieldsValues()
        SourceEspecialidade = Especialidade
        SourceMotivo = Motivo
        SourceValor = Valor
        SourcePrevisto = Previsto
        SourceConfirmado = Confirmado
        SourceSatisfacao = Satisfacao
        SourceRecibo = Recibo
        SourceContagemReceita = ContagemReceita
        SourceProfissional = Profissional
    End Sub
End Class