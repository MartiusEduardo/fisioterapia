Public Class form_incluir_receita

    Dim tipoForm As Integer

    Private Sub ReceitaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceitaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ReceitaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarReceitaToolStripButton, ReceitaBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu receita", DateTime.Now)
                Case 1
                    MsgBox("Receita salva com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou receita", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_receita_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_receita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ReceitaTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Receita"
                    Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
                Case 1
                    Me.Text = "Editar Receita"
                    AdicionarReceitaToolStripButton.Visible = False
                    CancelarToolStripButton.Visible = False
                    habilitarObjetos(Me, AdicionarReceitaToolStripButton, ReceitaBindingNavigatorSaveItem, CancelarToolStripButton, False, True, False)
                    Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
                    Dim codigoR As Integer = form_receitas.ReceitaDataGridView.CurrentRow.Cells(0).Value
                    Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (CodigoR = '" & codigoR & "')"
                    Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarReceitaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarReceitaToolStripButton.Click
        Try
            ReceitaBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarReceitaToolStripButton, ReceitaBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
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
            ReceitaBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarReceitaToolStripButton, ReceitaBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class