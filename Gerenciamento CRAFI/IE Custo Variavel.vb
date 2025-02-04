Public Class form_incluir_custo_variavel

    Dim tipoForm As Integer

    Private Sub CustoVariavelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoVariavelBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoVariavelBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarToolStripButton, CustoVariavelBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu custo variável", DateTime.Now)
                Case 1
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou custo variável", DateTime.Now)
                    MsgBox("Custo variável salvo com sucesso!", MsgBoxStyle.OkOnly)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_custo_variavel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_custo_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Custo Variável"
                    Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
                Case 1
                    Me.Text = "Editar Custo Variável"
                    AdicionarToolStripButton.Visible = False
                    CancelarToolStripButton.Visible = False
                    habilitarObjetos(Me, AdicionarToolStripButton, CustoVariavelBindingNavigatorSaveItem, CancelarToolStripButton, False, True, False)
                    Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
                    Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (CodigoCV Like '%" & form_custo_variavel.CustoVariavelDataGridView.CurrentRow.Cells(0).Value & "%')"
                    Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            End Select
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