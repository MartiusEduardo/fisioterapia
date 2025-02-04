Imports System.Windows
Public Class form_incluir_custo_fixo

    Dim tipoForm As Integer

    Private Sub CustoFixoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoFixoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoFixoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarToolStripButton, CustoFixoBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "incluiu custo fixo", DateTime.Now)
                Case 1
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou custo fixo", DateTime.Now)
                    MsgBox("Custo fixo salvo com sucesso!", MsgBoxStyle.OkOnly)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_custo_fixo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_custo_fixo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0 'Incluir Custo Fixo
                    Me.Text = "Incluir Custo Fixo"
                    Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
                Case 1 'Editar Custo Fixo
                    Me.Text = "Editar Custo Fixo"
                    AdicionarToolStripButton.Visible = False
                    CancelarToolStripButton.Visible = False
                    NumMesesAFrenteToolStripLabel.Visible = True
                    NumMesesAFrenteToolStripTextBox.Visible = True
                    ReplicarToolStripButton.Visible = True
                    habilitarObjetos(Me, AdicionarToolStripButton, CustoFixoBindingNavigatorSaveItem, CancelarToolStripButton, False, True, False)
                    Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
                    Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (CodigoCF = '" & form_custo_fixo.CustoFixoDataGridView.CurrentRow.Cells(0).Value & "')"
                    Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            End Select            
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

    Private Sub ReplicarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplicarToolStripButton.Click
        Try
            If NumMesesAFrenteToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o número de meses à frente para replicar o custo fixo.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If MsgBox("Tem certeza que deseja replicar o custo fixo do código " & CodigoCFTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            Dim dataVencimento, dataEmissao, dataBaixa As Date
            dataVencimento = DataVencimentoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataEmissao = DataEmissaoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataBaixa = DataBaixaDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            Me.CustoFixoTableAdapter.Insert(NomeTextBox.Text, ValorTextBox.Text, dataVencimento, Today, dataEmissao, dataBaixa, ObservacaoTextBox.Text)
            MsgBox("Custo fixo replicado com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub NumMesesAFrenteToolStripTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumMesesAFrenteToolStripTextBox.KeyPress
        Try
            If Char.IsLetter(e.KeyChar) = True Or Char.IsPunctuation(e.KeyChar) = True Or Char.IsSymbol(e.KeyChar) = True Or Char.IsWhiteSpace(e.KeyChar) = True Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class