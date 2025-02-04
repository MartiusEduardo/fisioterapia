Public Class form_incluir_despesa_fixa

    Private Sub DespesaFixaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesaFixaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DespesaFixaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, DespesaFixaBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu despesa fixa", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_despesa_fixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaFixaTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            DespesaFixaBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, DespesaFixaBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
            'datas
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
            DespesaFixaBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, DespesaFixaBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class