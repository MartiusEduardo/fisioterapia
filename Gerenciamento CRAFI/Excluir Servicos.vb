Public Class form_excluir_servicos

    Private Sub form_excluir_servicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ServicosTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirServicoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirServicoToolStripButton.Click
        Try
            If CodigoToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código do serviço.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja eliminar o serviço do código " & CodigoToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirServico(CodigoToolStripTextBox.Text)
                    Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
                    MsgBox("Serviço excluído com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu serviço", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class