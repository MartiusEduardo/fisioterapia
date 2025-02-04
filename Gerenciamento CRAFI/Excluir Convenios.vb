Public Class form_excluir_convenios

    Private Sub form_excluir_convenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            ServicosConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirConveniosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirConveniosToolStripButton.Click
        Try
            If ExcluirCodConvenioToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir um CNPJ.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o convênio do código " & ExcluirCodConvenioToolStripTextBox.Text & " e todos os seus serviços?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirConvenio(ExcluirCodConvenioToolStripTextBox.Text)
                    Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
                    MsgBox("Convênio excluído com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu convênio", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class