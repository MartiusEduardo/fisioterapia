Public Class form_incluir_usuario

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu serviço", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LoginTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarUsuarioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarUsuarioToolStripButton.Click
        Try
            LoginBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarUsuarioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarUsuarioToolStripButton.Click
        Try
            LoginBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class