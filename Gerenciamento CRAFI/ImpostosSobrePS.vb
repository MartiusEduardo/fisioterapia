Public Class form_impostos_sobre_receita

    Private Sub ImpostosSobreVendasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpostosSobreVendasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ImpostosSobreVendasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Impostos salvos com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_impostos_sobre_ps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ImpostosSobreVendasTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ImpostosSobreVendasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ImpostosSobreVendas)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class