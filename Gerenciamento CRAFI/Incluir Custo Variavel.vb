Public Class form_incluir_custo_variavel

    Private Sub CustoVariavelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoVariavelBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoVariavelBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, CustoVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu custo variável", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_custo_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            CustoVariavelBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, CustoVariavelBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
            DataVencimentoDateTimePicker.Value = Today
            DataCadastroTextBox.Text = Format(Today, "yyyy-MM-dd")
            DataEmissaoDateTimePicker.Value = Today
            DataBaixaDateTimePicker.Value = Today
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripButton.Click
        Try
            CustoVariavelBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, CustoVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class