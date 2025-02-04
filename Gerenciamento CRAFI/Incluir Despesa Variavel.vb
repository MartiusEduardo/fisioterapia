Public Class form_incluir_despesa_variavel

    Private Sub DespesaVariavelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesaVariavelBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DespesaVariavelBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, DespesaVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu despesa variável", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_despesa_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaVariavelTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            DespesaVariavelBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, DespesaVariavelBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
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
            DespesaVariavelBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, DespesaVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class