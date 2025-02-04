Public Class form_excluir_profissional

    Private Sub form_excluir_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirProfissionalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirProfissionalToolStripButton.Click
        Try
            If CodigoProToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o número do registro em órgão de classe.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o profissional do código " & CodigoProToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirProfissional(CodigoProToolStripTextBox.Text)
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
                    MsgBox("Profissional excluído com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu profissional", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class