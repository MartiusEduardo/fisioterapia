Public Class form_mudar_senha

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Nova senha salva com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_mudar_senha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Login)
            Dim usuario As String = form_principal.ToolStripStatusLabel.Text
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Login WHERE (Usuario Like '" & usuario & "')"
            Me.LoginTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class