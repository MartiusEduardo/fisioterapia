Public Class form_excluir_pacientes

    Private Sub form_excluir_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            AnamneseTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripButton.Click
        Try
            If CodigoPacienteExcluirToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código do paciente para excluí-lo.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o paciente do código " & CodigoPacienteExcluirToolStripTextBox.Text & ", a anamnese e todas as evoluções clínicas desse paciente?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirPaciente(CodigoPacienteExcluirToolStripTextBox.Text)
                    Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
                    MsgBox("Paciente excluído com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu paciente", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class