Public Class form_editar_evolucao_clinica

    Private Sub EvolucaoClinicaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvolucaoClinicaBindingNavigatorSaveItem.Click
        Try
            If QueixaPrincipalTextBox.TextLength >= 10 And HistoriaDoencaAtualTextBox.TextLength >= 10 And TratamentoTextBox.TextLength >= 10 Then
                Dim senhaLogin As String = My.Settings.SenhaUsuario
                Dim assinatura As String = Me.LoginTableAdapter.ScalarQueryAssinatura(form_principal.ToolStripStatusLabel.Text, senhaLogin, form_principal.TipoToolStripStatusLabel.Text)
                If AssinaturaTextBox.Text = assinatura Or form_principal.TipoToolStripStatusLabel.Text = "Administrador 1" Then
                    Me.Validate()
                    Me.EvolucaoClinicaBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
                    MsgBox("Evolução Clínica salva com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou evolução clínica", DateTime.Now)
                Else
                    MsgBox("Você não tem permissão para modificar esta evolução clínica.", MsgBoxStyle.OkOnly)
                End If
            Else
                MsgBox("É necessário inserir mais de 10 caracteres em: Queixa Principal; História da Doença Atual e Tratamento.", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LoginTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Dim numeroProntuario As String
            numeroProntuario = form_editar_evolucoes_clinicas.EvolucaoClinicaDataGridView.CurrentRow.Cells(0).Value
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (NumeroProntuario = '" & numeroProntuario & "')"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ImprimirEvolucaoClinicaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirEvolucaoClinicaToolStripButton.Click
        Try
            form_imprimir_evolucao_clinica.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class