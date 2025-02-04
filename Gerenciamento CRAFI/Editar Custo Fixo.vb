Public Class form_editar_custo_fixo

    Private Sub CustoFixoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustoFixoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CustoFixoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou custo fixo", DateTime.Now)
            MsgBox("Custo fixo salvo com sucesso!", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_custo_fixo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (CodigoCF = '" & form_custo_fixo.CustoFixoDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
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
            Dim codigo As Integer = Me.CustoFixoTableAdapter.ScalarQueryMaxCustoFixo() + 1
            Dim dataVencimento, dataEmissao, dataBaixa As Date
            dataVencimento = DataVencimentoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataEmissao = DataEmissaoDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            dataBaixa = DataBaixaDateTimePicker.Value.AddMonths(+NumMesesAFrenteToolStripTextBox.Text)
            Me.CustoFixoTableAdapter.Insert(codigo, NomeTextBox.Text, ValorTextBox.Text, dataVencimento, Today, dataEmissao, dataBaixa, ObservacaoTextBox.Text)
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