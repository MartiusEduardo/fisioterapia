Public Class form_relatorio_demonstracao_do_resultado_do_exercicio

    Private Sub form_relatorio_demonstracao_do_resultado_do_exercicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CustoFixoTableAdapter.Connection.ConnectionString = conexao.strConexao
            CustoVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            DespesaFixaTableAdapter.Connection.ConnectionString = conexao.strConexao
            DespesaVariavelTableAdapter.Connection.ConnectionString = conexao.strConexao
            ReceitaTableAdapter.Connection.ConnectionString = conexao.strConexao
            ImpostosSobreVendasTableAdapter.Connection.ConnectionString = conexao.strConexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Me.ImpostosSobreVendasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ImpostosSobreVendas)
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
            Me.DREReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub mc_relatorio_dre_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mc_relatorio_dre.DateChanged
        Try
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
            Dim data As String = Format(mc_relatorio_dre.SelectionRange.Start, "yyyy-MM-dd")
            If rdo_dia.Checked = True Then
                data = Format(mc_relatorio_dre.SelectionRange.Start, "yyyy-MM-dd")
            ElseIf rdo_mes.Checked = True Then
                data = Format(mc_relatorio_dre.SelectionRange.Start, "yyyy-MM-")
            ElseIf rdo_ano.Checked = True Then
                data = Format(mc_relatorio_dre.SelectionRange.Start, "yyyy-")
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
            Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ReceitaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Receita WHERE (" & nomeData & " Like '%" & data & "%') And (NomeProfissional Like '%" & profissional & "%')"
            Me.ReceitaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Receita)
            'Impostos Sobre Vendas
            Me.ImpostosSobreVendasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ImpostosSobreVendasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ImpostosSobreVendas WHERE (UtilizarCalculo = 'True')"
            Me.ImpostosSobreVendasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ImpostosSobreVendas)
            'Custos e Despesas
            Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            If rdo_total.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select Min(CodigoCF) As CodigoCF, Nome, Sum(Valor) As Valor, MIN(DataVencimento) As DataVencimento, Min(DataCadastro) As DataCadastro, Min(DataEmissao) As DataEmissao, Min(DataBaixa) As DataBaixa, Min(Observacao) As Observacao FROM CustoFixo WHERE (" & nomeData & " Like '%" & data & "%') Group By Nome"
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select Min(CodigoCV) As CodigoCV, Nome, Sum(Valor) As Valor, MIN(DataVencimento) As DataVencimento, Min(DataCadastro) As DataCadastro, Min(DataEmissao) As DataEmissao, Min(DataBaixa) As DataBaixa, Min(Observacao) As Observacao FROM CustoVariavel WHERE (" & nomeData & " Like '%" & data & "%') Group By Nome"
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select Min(CodigoDF) As CodigoDF, Nome, Sum(Valor) As Valor, MIN(DataVencimento) As DataVencimento, Min(DataCadastro) As DataCadastro, Min(DataEmissao) As DataEmissao, Min(DataBaixa) As DataBaixa, Min(Observacao) As Observacao FROM DespesaFixa WHERE (" & nomeData & " Like '%" & data & "%') Group By Nome"
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select Min(CodigoDV) As CodigoDV, Nome, Sum(Valor) As Valor, MIN(DataVencimento) As DataVencimento, Min(DataCadastro) As DataCadastro, Min(DataEmissao) As DataEmissao, Min(DataBaixa) As DataBaixa, Min(Observacao) As Observacao FROM DespesaVariavel WHERE (" & nomeData & " Like '%" & data & "%') Group By Nome"
            ElseIf rdo_profissional.Checked = True Then
                Me.CustoFixoTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoFixo WHERE (CodigoCF = '-1')"
                Me.CustoVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM CustoVariavel WHERE (CodigoCV = '-1')"
                Me.DespesaFixaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaFixa WHERE (CodigoDF = '-1')"
                Me.DespesaVariavelTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM DespesaVariavel WHERE (CodigoDV = '-1')"
            End If
            Me.CustoFixoTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoFixo)
            Me.CustoVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.CustoVariavel)
            Me.DespesaFixaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaFixa)
            Me.DespesaVariavelTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.DespesaVariavel)
            Me.DREReportViewer.RefreshReport()
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
End Class