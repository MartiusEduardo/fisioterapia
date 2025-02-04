Public Class form_editar_custo_variavel

    Private Sub CustoVariavelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoVariavelBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoVariavelBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou custo variável", DateTime.Now)
            MsgBox("Custo variável salvo com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_custo_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (CodigoCV Like '%" & form_custo_variavel.CustoVariavelDataGridView.CurrentRow.Cells(0).Value & "%')"
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class