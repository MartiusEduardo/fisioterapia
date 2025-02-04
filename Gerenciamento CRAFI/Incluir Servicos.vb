Public Class form_incluir_servicos

    Private Sub ServicosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ServicosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo serviço", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_servicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ServicosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarServicosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarServicosToolStripButton.Click
        Try
            ServicosBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarServicosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarServicosToolStripButton.Click
        Try
            ServicosBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class