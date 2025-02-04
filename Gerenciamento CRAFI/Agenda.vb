Imports DevExpress.XtraScheduler

Public Class form_agenda

    Private codigo As Integer

    Private Sub form_agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '--------------------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConsultasTableAdapter.Connection.ConnectionString = conexao.strConexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            '--------------------------------------------------------------------------------------------------------------------------------------
            Me.ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
            sc_agenda.Start = Today
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AgendaSchedulerStorage_AppointmentsChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles AgendaSchedulerStorage.AppointmentsChanged, AgendaSchedulerStorage.AppointmentsDeleted, AgendaSchedulerStorage.AppointmentsInserted
        Try
            Me.Validate()
            Me.ConsultasBindingSource.EndEdit()
            Me.ConsultasTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.Consultas)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "inseriu, editou ou excluiu consulta", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

#Region "#EditAppointmentFormShowing"
    Private Sub sc_agenda_EditAppointmentFormShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles sc_agenda.EditAppointmentFormShowing
        Try
            Dim apt As Appointment = e.Appointment

            ' Required to open the recurrence form via context menu.
            Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso AgendaSchedulerStorage.Appointments.IsNewAppointment(apt)

            ' Create a custom form.
            Dim myForm As New form_incluir_consulta(Me.sc_agenda, apt, openRecurrenceForm)
            e.DialogResult = myForm.ShowDialog()
            e.Handled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
#End Region


    Private Sub AgendaSchedulerStorage_FilterResource(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles AgendaSchedulerStorage.FilterResource
        Try
            If form_principal.TipoToolStripStatusLabel.Text <> "Administrador 1" And form_principal.TipoToolStripStatusLabel.Text <> "Administrador 2" Then
                sc_agenda.Storage.Resources.Filter = "[Id] = '" & codigo & "'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AgendaSchedulerStorage_FilterAppointment(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectCancelEventArgs) Handles AgendaSchedulerStorage.FilterAppointment
        Try
            If form_principal.TipoToolStripStatusLabel.Text <> "Administrador 1" And form_principal.TipoToolStripStatusLabel.Text <> "Administrador 2" Then
                If (codigo = 0) Then codigo = LoginTableAdapter.ScalarQueryCodigo(form_principal.ToolStripStatusLabel.Text)
                sc_agenda.Storage.Appointments.Filter = "[ResourceId] = '" & codigo & "'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_atualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atualizar.Click
        Try
            '--------------------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            conexao.conexaoServidor(TableAdapterManager)
            '--------------------------------------------------------------------------------------------------------------------------------------
            ConsultasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            ConsultasTableAdapter.Adapter.SelectCommand.CommandText = filtroConsulta("", "", "", "")
            Me.ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            AgendaSchedulerStorage.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            ConsultasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            ConsultasTableAdapter.Adapter.SelectCommand.CommandText = filtroConsulta(PacienteToolStripTextBox.Text, ProfissionalToolStripTextBox.Text, DataToolStripTextBox.Text, DataTerminoToolStripTextBox.Text)
            ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            AgendaSchedulerStorage.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class