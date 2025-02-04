Public Class form_excluir_contatos

    Private Sub form_excluir_contatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ContatosTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirContatoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirContatoToolStripButton.Click
        Try
            If CodigoContatoToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir um código.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o contato do código " & CodigoContatoToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirContato(CodigoContatoToolStripTextBox.Text)
                    Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
                    MsgBox("Contato excluído com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu contato", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class