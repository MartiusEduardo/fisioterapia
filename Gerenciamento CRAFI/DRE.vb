Public Class form_dre

    Private Sub form_dre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.strConexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            DespesaFixaTableAdapter.Connection.ConnectionString = conexao.strConexao
            DespesaVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            ImpostosSobreVendasTableAdapter.Connection.ConnectionString = conexao.strConexao
            ReceitaTableAdapter.Connection.ConnectionString = conexao.strConexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Me.ImpostosSobreVendasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ImpostosSobreVendas)
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub mc_dre_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_dre.DateChanged
        Try
            dgv_dre.Rows.Clear()
            Dim nomeData As String = "DataVencimento"
            If rdo_data_vencimento.Checked = True Then
                nomeData = "DataVencimento"
            ElseIf rdo_data_cadastro.Checked = True Then
                nomeData = "DataCadastro"
            ElseIf rdo_data_emissao.Checked = True Then
                nomeData = "DataEmissao"
            ElseIf rdo_data_baixa.Checked = True Then
                nomeData = "DataBaixa"
            End If
            Dim data As String = Format(mc_dre.SelectionRange.Start, "yyyy-MM-dd")
            If rdo_dia.Checked = True Then
                data = Format(mc_dre.SelectionRange.Start, "yyyy-MM-dd")
            ElseIf rdo_mes.Checked = True Then
                data = Format(mc_dre.SelectionRange.Start, "yyyy-MM-")
            ElseIf rdo_ano.Checked = True Then
                data = Format(mc_dre.SelectionRange.Start, "yyyy-")
            End If
            Dim profissional As String = My.Settings.UsuarioTotalDRE
            If rdo_profissional.Checked = True Then
                profissional = ProfissionalComboBox.Text
                If profissional = "" Then
                    MsgBox("Nenhum profissional foi selecionado.", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
            ElseIf rdo_total.Checked = True Then
                If UtilizarProfissionalCheckBox.Checked = True Then
                    profissional = ProfissionalComboBox.Text
                    If profissional = "" Then
                        MsgBox("Nenhum profissional foi selecionado.", MsgBoxStyle.OkOnly)
                        Exit Sub
                    End If
                End If
            End If
            dgv_tabelas_dre.DataSource = Me.ReceitaBindingSource
            Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (" & nomeData & " Like '" & data & "%') And (NomeProfissional Like '%" & profissional & "%')"
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Dim nome(0 To ReceitaBindingSource.Count), valor(0 To ReceitaBindingSource.Count) As String
            Dim somaPorcentagem As Double = 0
            Dim valorTotal As Double = 0
            Dim n As Integer = 0
            Dim z As Integer = 0
            For i = 0 To dgv_tabelas_dre.RowCount - 1
                nome(i) = dgv_tabelas_dre.Rows(i).Cells(2).Value
                valor(i) = dgv_tabelas_dre.Rows(i).Cells(8).Value
                dgv_dre.Rows.Add(nome(i), valor(i))
                n += 1
            Next
            'Receita Operacional Líquida
            For i = 0 To dgv_dre.RowCount - 1
                valorTotal += dgv_dre.Rows(i).Cells(1).Value
            Next
            'Impostos Sobre Vendas
            dgv_tabelas_dre.DataSource = Me.ImpostosSobreVendasBindingSource
            Me.ImpostosSobreVendasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ImpostosSobreVendasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ImpostosSobreVendas"
            Me.ImpostosSobreVendasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ImpostosSobreVendas)
            Dim nomeISV(0 To ImpostosSobreVendasBindingSource.Count), valorISV(0 To ImpostosSobreVendasBindingSource.Count), porcentagem(0 To ImpostosSobreVendasBindingSource.Count) As String
            For i = 0 To dgv_tabelas_dre.RowCount - 1
                If dgv_tabelas_dre.Rows(i).Cells(3).Value = True Then
                    nomeISV(i) = dgv_tabelas_dre.Rows(i).Cells(0).Value
                    somaPorcentagem += dgv_tabelas_dre.Rows(i).Cells(1).Value
                    valorISV(i) = valorTotal * (dgv_tabelas_dre.Rows(i).Cells(1).Value / 100)
                    dgv_dre.Rows.Add(nomeISV(i), valorISV(i))
                    n += 1
                End If
            Next
            'Receita Operacional Líquida
            valorTotal -= valorTotal * (somaPorcentagem / 100)
            dgv_dre.Rows.Add("= Receita Operacional Líquida", valorTotal)
            dgv_dre.Rows(n).Cells(0).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
            dgv_dre.Rows(n).Cells(1).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
            dgv_dre.Rows(n).Cells(0).Style.ForeColor = Color.White
            dgv_dre.Rows(n).Cells(1).Style.ForeColor = Color.White
            n += 1
            If rdo_total.Checked = True Then
                'Custo Fixo
                dgv_tabelas_dre.DataSource = CustoFixoBindingSource
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (" & nomeData & " Like '" & data & "%')"
                Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
                Dim nomeCF(0 To CustoFixoBindingSource.Count), valorCF(0 To CustoFixoBindingSource.Count) As String
                For i = 0 To dgv_tabelas_dre.RowCount - 1
                    nomeCF(i) = dgv_tabelas_dre.Rows(i).Cells(1).Value
                    valorCF(i) = dgv_tabelas_dre.Rows(i).Cells(2).Value
                    dgv_dre.Rows.Add(nomeCF(i), valorCF(i))
                    z += 1
                Next
                'Custo Variável
                dgv_tabelas_dre.DataSource = CustoVariavelBindingSource
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (" & nomeData & " Like '" & data & "%')"
                Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
                Dim nomeCV(0 To CustoVariavelBindingSource.Count), valorCV(0 To CustoVariavelBindingSource.Count) As String
                For i = 0 To dgv_tabelas_dre.RowCount - 1
                    nomeCV(i) = dgv_tabelas_dre.Rows(i).Cells(1).Value
                    valorCV(i) = dgv_tabelas_dre.Rows(i).Cells(6).Value
                    dgv_dre.Rows.Add(nomeCV(i), valorCV(i))
                    z += 1
                Next
                'Lucro Operacional Bruto
                For i = n To dgv_dre.RowCount - 1
                    valorTotal -= dgv_dre.Rows(i).Cells(1).Value
                Next
                dgv_dre.Rows.Add("= Lucro Operacional Bruto", valorTotal)
                dgv_dre.Rows(n + z).Cells(0).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
                dgv_dre.Rows(n + z).Cells(1).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
                dgv_dre.Rows(n + z).Cells(0).Style.ForeColor = Color.White
                dgv_dre.Rows(n + z).Cells(1).Style.ForeColor = Color.White
                n += z + 1
                z = 0
                'Despesa Fixa
                dgv_tabelas_dre.DataSource = DespesaFixaBindingSource
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (" & nomeData & " Like '" & data & "%')"
                Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
                Dim nomeDF(0 To DespesaFixaBindingSource.Count), valorDF(0 To DespesaFixaBindingSource.Count) As String
                For i = 0 To dgv_tabelas_dre.RowCount - 1
                    nomeDF(i) = dgv_tabelas_dre.Rows(i).Cells(1).Value
                    valorDF(i) = dgv_tabelas_dre.Rows(i).Cells(6).Value
                    dgv_dre.Rows.Add(nomeDF(i), valorDF(i))
                    z += 1
                Next
                'Despesa Variável
                dgv_tabelas_dre.DataSource = DespesaVariavelBindingSource
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (" & nomeData & " Like '" & data & "%')"
                Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
                Dim nomeDV(0 To DespesaVariavelBindingSource.Count), valorDV(0 To DespesaVariavelBindingSource.Count) As String
                For i = 0 To dgv_tabelas_dre.RowCount - 1
                    nomeDV(i) = dgv_tabelas_dre.Rows(i).Cells(1).Value
                    valorDV(i) = dgv_tabelas_dre.Rows(i).Cells(6).Value
                    dgv_dre.Rows.Add(nomeDV(i), valorDV(i))
                    z += 1
                Next
                'Lucro Operacional Líquido
                For i = n To dgv_dre.RowCount - 1
                    valorTotal -= dgv_dre.Rows(i).Cells(1).Value
                Next
                dgv_dre.Rows.Add("= Lucro Operacional Líquido", valorTotal)
                dgv_dre.Rows(n + z).Cells(0).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
                dgv_dre.Rows(n + z).Cells(1).Style.BackColor = Color.FromArgb(&H4E, &H90, &H6A)
                dgv_dre.Rows(n + z).Cells(0).Style.ForeColor = Color.White
                dgv_dre.Rows(n + z).Cells(1).Style.ForeColor = Color.White
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub rdo_total_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_total.CheckedChanged
        Try
            If rdo_total.Checked = False Then
                UtilizarProfissionalCheckBox.Checked = False
                UtilizarProfissionalCheckBox.Enabled = False
            Else
                UtilizarProfissionalCheckBox.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_modificar_usuario_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar_usuario_total.Click
        Try
            Dim usuario As String
            usuario = InputBox("Qual o nome do novo usuário total?", vbOKCancel)
            If usuario <> "" Then
                My.Settings.UsuarioTotalDRE = usuario
                My.Settings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class