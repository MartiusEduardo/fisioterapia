Public Class form_excluir_evolucao_clinica

    Private Sub form_excluir_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (NumeroProntuario = '" & form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirEvolucaoClinicaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirEvolucaoClinicaToolStripButton.Click
        Try
            If codigoEvolucaoClinicaToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o número do prontuário.", MsgBoxStyle.OkOnly)
            Else
                If form_principal.TipoToolStripStatusLabel.Text = "Administrador 1" Then
                    If MsgBox("Tem certeza que deseja excluir a evolução clínica do número " & codigoEvolucaoClinicaToolStripTextBox.Text & " do paciente " & form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(2).Value & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        Dim codigoPaciente As String
                        codigoPaciente = form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
                        QueriesTableAdapter.excluirEvolucaoClinica(codigoEvolucaoClinicaToolStripTextBox.Text, codigoPaciente)
                        Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                        Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (NumeroProntuario = '" & codigoPaciente & "')"
                        Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
                        MsgBox("Evolução Clínica excluída com sucesso!", MsgBoxStyle.OkOnly)
                        Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu evolução clínica", DateTime.Now)
                    End If
                Else
                    MsgBox("Você não tem permissão para excluir a evolução clínica.", MsgBoxStyle.OkOnly)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class