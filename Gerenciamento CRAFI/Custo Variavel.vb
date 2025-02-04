Public Class form_custo_variavel

    Private Sub form_custo_variavel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Dim i As Integer
            For i = 0 To CustoVariavelDataGridView.RowCount - 1
                mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(2).Value)
            Next
            mc_custo_variavel.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel"
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Dim i As Integer
            mc_custo_variavel.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(2).Value)
                Next
            ElseIf rdo_data_cadastro.Checked = True Then
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(3).Value)
                Next
            ElseIf rdo_data_emissao.Checked = True Then
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(4).Value)
                Next
            ElseIf rdo_data_baixa.Checked = True Then
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(5).Value)
                Next
            End If
            mc_custo_variavel.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirCVToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirCVToolStripButton.Click
        Try
            Dim custoVariavel As New form_incluir_custo_variavel
            custoVariavel.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripButton.Click
        Try
            If CodigoCVToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o custo variável do código " & CodigoCVToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirCustoVariavel(CodigoCVToolStripTextBox.Text)
                    MsgBox("Custo fixo excluído com sucesso.", MsgBoxStyle.OkOnly)
                    Dim data As String = mc_custo_variavel.SelectionRange.Start
                    Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    If rdo_data_vencimento.Checked = True Then
                        Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataVencimento Like '" & data & "')"
                    ElseIf rdo_data_cadastro.Checked = True Then
                        Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataCadastro Like '" & data & "')"
                    ElseIf rdo_data_emissao.Checked = True Then
                        Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataEmissao Like '" & data & "')"
                    ElseIf rdo_data_baixa.Checked = True Then
                        Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataBaixa Like '" & data & "')"
                    End If
                    Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_custo_variavel_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_custo_variavel.DateChanged
        Try
            Dim data As String = Format(mc_custo_variavel.SelectionRange.Start, "yyyy-MM-dd")
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_data_vencimento.Checked = True Then
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataVencimento Like '" & data & "%')"
            ElseIf rdo_data_cadastro.Checked = True Then
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataCadastro Like '" & data & "%')"
            ElseIf rdo_data_emissao.Checked = True Then
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataEmissao Like '" & data & "%')"
            ElseIf rdo_data_baixa.Checked = True Then
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (DataBaixa Like '" & data & "%')"
            End If
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_vencimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_vencimento.CheckedChanged
        Try
            If rdo_data_vencimento.Checked = True Then
                mc_custo_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(2).Value)
                Next
                mc_custo_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_cadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_cadastro.CheckedChanged
        Try
            If rdo_data_cadastro.Checked = True Then
                mc_custo_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(3).Value)
                Next
                mc_custo_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_emissao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_emissao.CheckedChanged
        Try
            If rdo_data_emissao.Checked = True Then
                mc_custo_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(4).Value)
                Next
                mc_custo_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_baixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_baixa.CheckedChanged
        Try
            If rdo_data_baixa.Checked = True Then
                mc_custo_variavel.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoVariavelDataGridView.RowCount - 1
                    mc_custo_variavel.AddBoldedDate(CustoVariavelDataGridView.Rows(i).Cells(5).Value)
                Next
                mc_custo_variavel.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CustoVariavelDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustoVariavelDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_custo_variavel.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SomarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomarToolStripButton.Click
        Try
            If CamposToolStripComboBox.Text = "" Then
                MsgBox("Escolha o nome do campo do custo variável.", MsgBoxStyle.OkOnly)
            Else
                If NomeToolStripComboBox.Text = "" Then
                    MsgBox("Escolha um nome.", MsgBoxStyle.OkOnly)
                Else
                    Dim soma As Double
                    If CamposToolStripComboBox.Text = "Nome do Custo Variável" Then
                        For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                            If CustoVariavelDataGridView.Rows.Item(i).Cells(1).Value = NomeToolStripComboBox.Text Then
                                soma += CustoVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                        For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                            If CustoVariavelDataGridView.Rows.Item(i).Cells(2).Value = NomeToolStripComboBox.Text Then
                                soma += CustoVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                        For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                            If CustoVariavelDataGridView.Rows.Item(i).Cells(3).Value = NomeToolStripComboBox.Text Then
                                soma += CustoVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                        For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                            If CustoVariavelDataGridView.Rows.Item(i).Cells(4).Value = NomeToolStripComboBox.Text Then
                                soma += CustoVariavelDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                        For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                            If CustoVariavelDataGridView.Rows.Item(i).Cells(5).Value = NomeToolStripComboBox.Text Then
                                soma += CustoVariavelDataGridView.Rows.Item(i).Cells(6).Value
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
            If CamposToolStripComboBox.Text = "Nome do Custo Variável" Then
                For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoVariavelDataGridView.Rows.Item(i).Cells(1).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoVariavelDataGridView.Rows.Item(i).Cells(2).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoVariavelDataGridView.Rows.Item(i).Cells(3).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoVariavelDataGridView.Rows.Item(i).Cells(4).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                For i = 0 To CustoVariavelDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoVariavelDataGridView.Rows.Item(i).Cells(5).Value)
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class