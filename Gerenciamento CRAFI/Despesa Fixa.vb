Public Class form_despesa_fixa

    Private Sub form_despesa_fixa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            DespesaFixaTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Dim i As Integer
            For i = 0 To DespesaFixaDataGridView.RowCount - 1
                mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(2).Value)
            Next
            mc_despesa_fixa.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub IncluirDFToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirDFToolStripButton.Click
        Try
            Dim despesaFixa As New form_incluir_despesa_fixa
            despesaFixa.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripButton.Click
        Try
            If CodigoDFToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir a despesa fixa do código " & CodigoDFToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirDespesaFixa(CodigoDFToolStripTextBox.Text)
                    MsgBox("Custo fixo excluído com sucesso.", MsgBoxStyle.OkOnly)
                    Dim data As String = mc_despesa_fixa.SelectionRange.Start
                    Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    If rdo_data_vencimento.Checked = True Then
                        Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataVencimento Like '" & data & "')"
                    ElseIf rdo_data_cadastro.Checked = True Then
                        Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataCadastro Like '" & data & "')"
                    ElseIf rdo_data_emissao.Checked = True Then
                        Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataEmissao Like '" & data & "')"
                    ElseIf rdo_data_baixa.Checked = True Then
                        Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (DataBaixa Like '" & data & "')"
                    End If
                    Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DespesaFixaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DespesaFixaDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_despesa_fixa.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_despesa_fixa_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_despesa_fixa.DateChanged
        Try
            Dim data As String = Format(mc_despesa_fixa.SelectionRange.Start, "yyyy-MM-dd")
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_data_vencimento.Checked = True Then
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (DataVencimento Like '" & data & "%')"
            ElseIf rdo_data_cadastro.Checked = True Then
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (DataCadastro Like '" & data & "%')"
            ElseIf rdo_data_emissao.Checked = True Then
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (DataEmissao Like '" & data & "%')"
            ElseIf rdo_data_baixa.Checked = True Then
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (DataBaixa Like '" & data & "%')"
            End If
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa"
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Dim i As Integer
            mc_despesa_fixa.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(2).Value)
                Next
            ElseIf rdo_data_cadastro.Checked = True Then
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(3).Value)
                Next
            ElseIf rdo_data_emissao.Checked = True Then
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(4).Value)
                Next
            ElseIf rdo_data_baixa.Checked = True Then
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(5).Value)
                Next
            End If
            mc_despesa_fixa.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_vencimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_vencimento.CheckedChanged
        Try
            If rdo_data_vencimento.Checked = True Then
                mc_despesa_fixa.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(2).Value)
                Next
                mc_despesa_fixa.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_cadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_cadastro.CheckedChanged
        Try
            If rdo_data_cadastro.Checked = True Then
                mc_despesa_fixa.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(3).Value)
                Next
                mc_despesa_fixa.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_emissao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_emissao.CheckedChanged
        Try
            If rdo_data_emissao.Checked = True Then
                mc_despesa_fixa.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(4).Value)
                Next
                mc_despesa_fixa.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_baixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_baixa.CheckedChanged
        Try
            If rdo_data_baixa.Checked = True Then
                mc_despesa_fixa.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To DespesaFixaDataGridView.RowCount - 1
                    mc_despesa_fixa.AddBoldedDate(DespesaFixaDataGridView.Rows(i).Cells(5).Value)
                Next
                mc_despesa_fixa.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SomarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomarToolStripButton.Click
        Try
            If CamposToolStripComboBox.Text = "" Then
                MsgBox("Escolha o nome do campo da despesa fixa.", MsgBoxStyle.OkOnly)
            Else
                If NomeToolStripComboBox.Text = "" Then
                    MsgBox("Escolha um nome.", MsgBoxStyle.OkOnly)
                Else
                    Dim soma As Double
                    If CamposToolStripComboBox.Text = "Nome da Despesa Fixa" Then
                        For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                            If DespesaFixaDataGridView.Rows.Item(i).Cells(1).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaFixaDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                        For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                            If DespesaFixaDataGridView.Rows.Item(i).Cells(2).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaFixaDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                        For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                            If DespesaFixaDataGridView.Rows.Item(i).Cells(3).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaFixaDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                        For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                            If DespesaFixaDataGridView.Rows.Item(i).Cells(4).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaFixaDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                        For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                            If DespesaFixaDataGridView.Rows.Item(i).Cells(5).Value = NomeToolStripComboBox.Text Then
                                soma += DespesaFixaDataGridView.Rows.Item(i).Cells(6).Value
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
            If CamposToolStripComboBox.Text = "Nome da Despesa Fixa" Then
                For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaFixaDataGridView.Rows.Item(i).Cells(1).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaFixaDataGridView.Rows.Item(i).Cells(2).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaFixaDataGridView.Rows.Item(i).Cells(3).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaFixaDataGridView.Rows.Item(i).Cells(4).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                For i = 0 To DespesaFixaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(DespesaFixaDataGridView.Rows.Item(i).Cells(5).Value)
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class