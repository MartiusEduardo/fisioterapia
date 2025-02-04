Public Class form_incluir_custo_fixo

    Private Sub CustoFixoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoFixoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoFixoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, CustoFixoBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu custo fixo", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_custo_fixo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            CustoFixoBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, CustoFixoBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
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
            CustoFixoBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, CustoFixoBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class