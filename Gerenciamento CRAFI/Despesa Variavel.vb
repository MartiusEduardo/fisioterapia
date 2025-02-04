Public Class form_despesa_variavel

    Private Sub form_custo_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            Dim i As Integer
            For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(2).Value)
            Next
            mc_despesa_variavel.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel"
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            Dim i As Integer
            mc_despesa_variavel.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(2).Value)
                Next
            ElseIf rdo_data_cadastro.Checked = True Then
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(3).Value)
                Next
            ElseIf rdo_data_emissao.Checked = True Then
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(4).Value)
                Next
            ElseIf rdo_data_baixa.Checked = True Then
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(5).Value)
                Next
            End If
            mc_despesa_variavel.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirDVToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirDVToolStripButton.Click
        Try
            Dim despesaVariavel As New form_incluir_despesa_variavel
            despesaVariavel.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirDVToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirDVToolStripButton.Click
        Try
            If CodigoDVToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir a despesa variável do código " & CodigoDVToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirDespesaVariavel(CodigoDVToolStripTextBox.Text)
                    MsgBox("Custo fixo excluído com sucesso.", MsgBoxStyle.OkOnly)
                    Dim data As String = mc_despesa_variavel.SelectionRange.Start
                    Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    If rdo_data_vencimento.Checked = True Then
                        Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataVencimento Like '" & data & "')"
                    ElseIf rdo_data_cadastro.Checked = True Then
                        Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataCadastro Like '" & data & "')"
                    ElseIf rdo_data_emissao.Checked = True Then
                        Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataEmissao Like '" & data & "')"
                    ElseIf rdo_data_baixa.Checked = True Then
                        Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataBaixa Like '" & data & "')"
                    End If
                    Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_despesa_variavel_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_despesa_variavel.DateChanged
        Try
            Dim data As String = Format(mc_despesa_variavel.SelectionRange.Start, "yyyy-MM-dd")
            Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_data_vencimento.Checked = True Then
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataVencimento Like '" & data & "%')"
            ElseIf rdo_data_cadastro.Checked = True Then
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataCadastro Like '" & data & "%')"
            ElseIf rdo_data_emissao.Checked = True Then
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataEmissao Like '" & data & "%')"
            ElseIf rdo_data_baixa.Checked = True Then
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataBaixa Like '" & data & "%')"
            End If
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_vencimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_vencimento.CheckedChanged
        Try
            If rdo_data_vencimento.Checked = True Then
                mc_despesa_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(2).Value)
                Next
                mc_despesa_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_cadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_cadastro.CheckedChanged
        Try
            If rdo_data_cadastro.Checked = True Then
                mc_despesa_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(3).Value)
                Next
                mc_despesa_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_emissao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_emissao.CheckedChanged
        Try
            If rdo_data_emissao.Checked = True Then
                mc_despesa_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(4).Value)
                Next
                mc_despesa_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_baixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_baixa.CheckedChanged
        Try
            If rdo_data_baixa.Checked = True Then
                mc_despesa_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaVariavelDataGridView.RowCount - 1
                    mc_despesa_variavel.AddBoldedDate(DespesaVariavelDataGridView.Rows(i).Cells(5).Value)
                Next
                mc_despesa_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DespesaVariavelDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DespesaVariavelDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_despesa_variavel.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SomarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomarToolStripButton.Click
        Try
            If CamposToolStripComboBox.Text = "" Then
                MsgBox("Escolha o nome do campo da despesa variável.", MsgBoxStyle.OkOnly)
            Else
                If NomeToolStripComboBox.Text = "" Then
                    MsgBox("Escolha um nome.", MsgBoxStyle.OkOnly)
                Else
                    Dim soma As Double
                    If CamposToolStripComboBox.Text = "Nome da Despesa Variável" Then
                        For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                            If DespesaVariavelDataGridView.Rows.Item(i).Cells(1).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                        For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                            If DespesaVariavelDataGridView.Rows.Item(i).Cells(2).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                        For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                            If DespesaVariavelDataGridView.Rows.Item(i).Cells(3).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                        For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                            If DespesaVariavelDataGridView.Rows.Item(i).Cells(4).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                        For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                            If DespesaVariavelDataGridView.Rows.Item(i).Cells(5).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    End If
                    SomaToolStripTextBox.Text = soma
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CamposToolStripComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CamposToolStripComboBox.TextChanged
        Try
            NomeToolStripComboBox.Items.Clear()
            Dim i As Integer
            If CamposToolStripComboBox.Text = "Nome da Despesa Variável" Then
                For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaVariavelDataGridView.Rows.Item(i).Cells(1).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaVariavelDataGridView.Rows.Item(i).Cells(2).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaVariavelDataGridView.Rows.Item(i).Cells(3).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaVariavelDataGridView.Rows.Item(i).Cells(4).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                For i = 0 To DespesaVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaVariavelDataGridView.Rows.Item(i).Cells(5).Value)
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class