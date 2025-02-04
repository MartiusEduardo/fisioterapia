Public Class form_editar_despesa_fixa

    Private Sub DespesaFixaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesaFixaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.DespesaFixaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou despesa fixa", DateTime.Now)
            MsgBox("Despesa fixa salva com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_despesa_fixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaFixaTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (CodigoDF = '" & form_despesa_fixa.DespesaFixaDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ReplicarDFToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplicarDFToolStripButton.Click
        Try
            If NumMesesAFrenteToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o número de meses à frente para replicar a despesa fixa.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            If MsgBox("Tem certeza que deseja replicar a despesa fixa do código " & CodigoDFTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            Dim codigo As Integer = Me.DespesaFixaTableAdapter.ScalarQueryMaxDespesaFixa() + 1
            Dim dataVencimento, dataEmissao, dataBaixa As Date
            dataVencimento = DataVencimentoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataEmissao = DataEmissaoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataBaixa = DataBaixaDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            Me.DespesaFixaTableAdapter.Insert(codigo, NomeTextBox.Text, dataVencimento, Today, dataEmissao, dataBaixa, ValorTextBox.Text, ObservacaoTextBox.Text)
            MsgBox("Despesa fixa replicada com sucesso!", MsgBoxStyle.OkOnly)
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