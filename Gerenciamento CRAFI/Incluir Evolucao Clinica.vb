Public Class form_incluir_evolucao_clinica

    Private Sub EvolucaoClinicaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvolucaoClinicaBindingNavigatorSaveItem.Click
        Try
            If QueixaPrincipalTextBox.TextLength >= 10 And HistoriaDoencaAtualTextBox.TextLength >= 10 And TratamentoTextBox.TextLength >= 10 Then
                Dim senhaLogin As String = My.Settings.SenhaUsuario
                AssinaturaTextBox.Text = Me.LoginTableAdapter.ScalarQueryAssinatura(form_principal.ToolStripStatusLabel.Text, senhaLogin, form_principal.TipoToolStripStatusLabel.Text)
                Me.Validate()
                Me.EvolucaoClinicaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
                desabilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, True, False, False)
                Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou uma nova evolução clínica", DateTime.Now)
            Else
                MsgBox("É necessário inserir mais de 10 caracteres em: Queixa Principal; História da Doença Atual e Tratamento.", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LoginTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarECToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarECToolStripButton.Click
        Try
            EvolucaoClinicaBindingSource.AddNew()
            CodigoPacienteTextBox.Text = form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            NomeTextBox.Text = form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(2).Value
            habilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarECToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarECToolStripButton.Click
        Try
            EvolucaoClinicaBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class