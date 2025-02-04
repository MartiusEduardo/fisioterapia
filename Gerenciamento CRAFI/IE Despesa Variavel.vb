Public Class form_incluir_despesa_variavel

    Dim tipoForm As Integer

    Private Sub DespesaVariavelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesaVariavelBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DespesaVariavelBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarToolStripButton, DespesaVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu despesa variável", DateTime.Now)
                Case 1
                    MsgBox("Despesa variável salva com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou despesa variável", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_despesa_variavel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_despesa_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Despesa Variável"
                    Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
                Case 1
                    Me.Text = "Editar Despesa Variável"
                    AdicionarToolStripButton.Visible = False
                    CancelarToolStripButton.Visible = False
                    habilitarObjetos(Me, AdicionarToolStripButton, DespesaVariavelBindingNavigatorSaveItem, CancelarToolStripButton, False, True, False)
                    Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
                    Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (CodigoDV Like '%" & form_despesa_variavel.DespesaVariavelDataGridView.CurrentRow.Cells(0).Value & "%')"
                    Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            End Select
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