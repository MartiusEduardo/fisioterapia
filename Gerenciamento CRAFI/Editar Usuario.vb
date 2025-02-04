Public Class form_editar_usuario

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Usuário salvo com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou usuário", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LoginTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Login)
            Dim usuario, senhaUsuario, tipo As String
            usuario = form_editar_usuarios.LoginDataGridView.CurrentRow.Cells(0).Value
            senhaUsuario = form_editar_usuarios.LoginDataGridView.CurrentRow.Cells(1).Value
            tipo = form_editar_usuarios.LoginDataGridView.CurrentRow.Cells(2).Value
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Login WHERE (Usuario Like '" & usuario & "') AND (Senha Like '" & senhaUsuario & "') AND (Tipo Like '" & tipo & "')"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class