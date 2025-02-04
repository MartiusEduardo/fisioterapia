Public Class form_custo_fixo

    Private Sub form_custo_fixo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Dim i As Integer
            For i = 0 To CustoFixoDataGridView.RowCount - 1
                mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(2).Value)
            Next
            mc_custo_fixo.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo"
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Dim i As Integer
            mc_custo_fixo.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(2).Value)
                Next
            ElseIf rdo_data_cadastro.Checked = True Then
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(3).Value)
                Next
            ElseIf rdo_data_emissao.Checked = True Then
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(4).Value)
                Next
            ElseIf rdo_data_baixa.Checked = True Then
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(5).Value)
                Next
            End If
            mc_custo_fixo.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirCFToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirCFToolStripButton.Click
        Try
            Dim formCustoFixo As New form_incluir_custo_fixo
            formCustoFixo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirCFToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirCFToolStripButton.Click
        Try
            If CodigoCFToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir o custo fixo do código " & CodigoCFToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    QueriesTableAdapter.excluirCustoFixo(CodigoCFToolStripTextBox.Text)
                    MsgBox("Custo fixo excluído com sucesso.", MsgBoxStyle.OkOnly)
                    Dim data As String = mc_custo_fixo.SelectionRange.Start
                    Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    If rdo_data_vencimento.Checked = True Then
                        Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataVencimento Like '" & data & "')"
                    ElseIf rdo_data_cadastro.Checked = True Then
                        Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataCadastro Like '" & data & "')"
                    ElseIf rdo_data_emissao.Checked = True Then
                        Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataEmissao Like '" & data & "')"
                    ElseIf rdo_data_baixa.Checked = True Then
                        Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataBaixa Like '" & data & "')"
                    End If
                    Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_custo_fixo_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_custo_fixo.DateChanged
        Try
            Dim data As String = Format(mc_custo_fixo.SelectionRange.Start, "yyyy-MM-dd")
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_data_vencimento.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataVencimento Like '" & data & "%')"
            ElseIf rdo_data_cadastro.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataCadastro Like '" & data & "%')"
            ElseIf rdo_data_emissao.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataEmissao Like '" & data & "%')"
            ElseIf rdo_data_baixa.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (DataBaixa Like '" & data & "%')"
            End If
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_vencimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_vencimento.CheckedChanged
        Try
            If rdo_data_vencimento.Checked = True Then
                mc_custo_fixo.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(2).Value)
                Next
                mc_custo_fixo.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_cadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_cadastro.CheckedChanged
        Try
            If rdo_data_cadastro.Checked = True Then
                mc_custo_fixo.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(3).Value)
                Next
                mc_custo_fixo.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_emissao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_emissao.CheckedChanged
        Try
            If rdo_data_emissao.Checked = True Then
                mc_custo_fixo.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(4).Value)
                Next
                mc_custo_fixo.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_baixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_baixa.CheckedChanged
        Try
            If rdo_data_baixa.Checked = True Then
                mc_custo_fixo.RemoveAllBoldedDates()
                Dim i As Integer
                For i = 0 To CustoFixoDataGridView.RowCount - 1
                    mc_custo_fixo.AddBoldedDate(CustoFixoDataGridView.Rows(i).Cells(5).Value)
                Next
                mc_custo_fixo.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CustoFixoDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustoFixoDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_custo_fixo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SomarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomarToolStripButton.Click
        Try
            If CamposToolStripComboBox.Text = "" Then
                MsgBox("Escolha o nome do campo do custo fixo.", MsgBoxStyle.OkOnly)
            Else
                If NomeToolStripComboBox.Text = "" Then
                    MsgBox("Escolha um nome.", MsgBoxStyle.OkOnly)
                Else
                    Dim soma As Double
                    If CamposToolStripComboBox.Text = "Nome do Custo Fixo" Then
                        For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                            If CustoFixoDataGridView.Rows.Item(i).Cells(1).Value = NomeToolStripComboBox.Text Then
                                soma += CustoFixoDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                        For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                            If CustoFixoDataGridView.Rows.Item(i).Cells(2).Value = NomeToolStripComboBox.Text Then
                                soma += CustoFixoDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                        For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                            If CustoFixoDataGridView.Rows.Item(i).Cells(3).Value = NomeToolStripComboBox.Text Then
                                soma += CustoFixoDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                        For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                            If CustoFixoDataGridView.Rows.Item(i).Cells(4).Value = NomeToolStripComboBox.Text Then
                                soma += CustoFixoDataGridView.Rows.Item(i).Cells(6).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                        For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                            If CustoFixoDataGridView.Rows.Item(i).Cells(5).Value = NomeToolStripComboBox.Text Then
                                soma += CustoFixoDataGridView.Rows.Item(i).Cells(6).Value
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
            If CamposToolStripComboBox.Text = "Nome do Custo Fixo" Then
                For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoFixoDataGridView.Rows.Item(i).Cells(1).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoFixoDataGridView.Rows.Item(i).Cells(2).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoFixoDataGridView.Rows.Item(i).Cells(3).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoFixoDataGridView.Rows.Item(i).Cells(4).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                For i = 0 To CustoFixoDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(CustoFixoDataGridView.Rows.Item(i).Cells(5).Value)
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class