Public Class form_receitas

    Private Sub Receitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ReceitaTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Dim i As Integer
            For i = 0 To ReceitaDataGridView.RowCount - 1
                mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(4).Value)
            Next
            mc_receita.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub rdo_data_vencimento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_vencimento.CheckedChanged
        Try
            mc_receita.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                Dim i As Integer
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(4).Value)
                Next
                mc_receita.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_cadastro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_cadastro.CheckedChanged
        Try
            mc_receita.RemoveAllBoldedDates()
            If rdo_data_cadastro.Checked = True Then
                Dim i As Integer
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(5).Value)
                Next
                mc_receita.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_emissao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_emissao.CheckedChanged
        Try
            mc_receita.RemoveAllBoldedDates()
            If rdo_data_emissao.Checked = True Then
                Dim i As Integer
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(6).Value)
                Next
                mc_receita.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_data_baixa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_data_baixa.CheckedChanged
        Try
            mc_receita.RemoveAllBoldedDates()
            If rdo_data_baixa.Checked = True Then
                Dim i As Integer
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(7).Value)
                Next
                mc_receita.UpdateBoldedDates()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_receita_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_receita.DateChanged
        Try
            Dim data As String = Format(mc_receita.SelectionRange.Start, "-MM-")
            If rdo_dia.Checked = True Then
                data = Format(mc_receita.SelectionRange.Start, "yyyy-MM-dd")
            ElseIf rdo_mes.Checked = True Then
                data = Format(mc_receita.SelectionRange.Start, "yyyy-MM-")
            ElseIf rdo_ano.Checked = True Then
                data = Format(mc_receita.SelectionRange.Start, "yyyy-")
            End If
            ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_data_vencimento.Checked = True Then
                ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataVencimento Like '" & data & "%')"
            ElseIf rdo_data_cadastro.Checked = True Then
                ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataCadastro Like '" & data & "%')"
            ElseIf rdo_data_emissao.Checked = True Then
                ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataEmissao Like '" & data & "%')"
            ElseIf rdo_data_baixa.Checked = True Then
                ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataBaixa Like '" & data & "%')"
            End If
            ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirReceitaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncluirReceitaToolStripButton.Click
        Try
            Dim receita As New form_incluir_receita
            receita.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita"
            ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Dim i As Integer
            mc_receita.RemoveAllBoldedDates()
            If rdo_data_vencimento.Checked = True Then
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(4).Value)
                Next
            ElseIf rdo_data_cadastro.Checked = True Then
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(5).Value)
                Next
            ElseIf rdo_data_emissao.Checked = True Then
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(6).Value)
                Next
            ElseIf rdo_data_baixa.Checked = True Then
                For i = 0 To ReceitaDataGridView.RowCount - 1
                    mc_receita.AddBoldedDate(ReceitaDataGridView.Rows(i).Cells(7).Value)
                Next
            End If
            mc_receita.UpdateBoldedDates()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirReceitaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirReceitaToolStripButton.Click
        Try
            If CodigoReceitaToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir o código da receita", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir a receita do código " & CodigoReceitaToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    ReceitaTableAdapter.DeleteQueryReceita(CodigoReceitaToolStripTextBox.Text)
                    MsgBox("Receita excluída com sucesso!", MsgBoxStyle.OkOnly)
                    Dim data As String
                    data = Format(mc_receita.SelectionRange.Start, "yyyy-MM-dd")
                    ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    If rdo_data_vencimento.Checked = True Then
                        ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataVencimento Like '%" & data & "%')"
                    ElseIf rdo_data_cadastro.Checked = True Then
                        ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataCadastro Like '%" & data & "%')"
                    ElseIf rdo_data_emissao.Checked = True Then
                        ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataEmissao Like '%" & data & "%')"
                    ElseIf rdo_data_baixa.Checked = True Then
                        ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (DataBaixa Like '%" & data & "%')"
                    End If
                    ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ReceitaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReceitaDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_receita.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SomarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SomarToolStripButton.Click
        Try
            If CamposToolStripComboBox.Text = "" Then
                MsgBox("Escolha o nome do campo de receita.", MsgBoxStyle.OkOnly)
            Else
                If NomeToolStripComboBox.Text = "" Then
                    MsgBox("Escolha um nome.", MsgBoxStyle.OkOnly)
                Else
                    Dim soma As Double
                    If CamposToolStripComboBox.Text = "Nome do Profissional" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(1).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Nome do Paciente" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(2).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Nome (Serviço / Produto)" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(3).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(4).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(5).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(6).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
                            End If
                        Next
                    ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                        For i = 0 To ReceitaDataGridView.Rows.Count - 1
                            If ReceitaDataGridView.Rows.Item(i).Cells(7).Value = NomeToolStripComboBox.Text Then
                                soma += ReceitaDataGridView.Rows.Item(i).Cells(8).Value
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
            If CamposToolStripComboBox.Text = "Nome do Profissional" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(1).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Nome do Paciente" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(2).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Nome (Serviço / Produto)" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(3).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Vencimento" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(4).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Cadastro" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(5).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Emissão" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(6).Value)
                Next i
            ElseIf CamposToolStripComboBox.Text = "Data de Baixa" Then
                For i = 0 To ReceitaDataGridView.Rows.Count - 1
                    NomeToolStripComboBox.Items.Add(ReceitaDataGridView.Rows.Item(i).Cells(7).Value)
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class