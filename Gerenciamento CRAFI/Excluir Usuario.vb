Public Class form_excluir_usuario

    Private Sub form_excluir_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirUsuarioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirUsuarioToolStripButton.Click
        Try
            If UsuarioToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o usuário.", MsgBoxStyle.OkOnly)
            ElseIf SenhaToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir a senha.", MsgBoxStyle.OkOnly)
            Else
                If QueriesTableAdapter.validarLogin(UsuarioToolStripTextBox.Text, SenhaToolStripTextBox.Text) = True Then
                    If MsgBox("Tem certeza que deseja excluir o usuário " & UsuarioToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        QueriesTableAdapter.excluirLogin(UsuarioToolStripTextBox.Text, SenhaToolStripTextBox.Text)
                        Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
                        MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.OkOnly)
                        Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu usuário", DateTime.Now)
                    End If
                Else
                    MsgBox("Usuário ou senha incorreta. Tente novamente.", MsgBoxStyle.OkOnly)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class