Public Class form_editar_servico

    Private Sub ServicosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ServicosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Serviço salvo com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou serviço", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_servico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ServicosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
            Dim codigo As String = form_editar_servicos.ServicosDataGridView.CurrentRow.Cells(2).Value
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos WHERE (Codigo = '" & codigo & "')"
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_servico.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class