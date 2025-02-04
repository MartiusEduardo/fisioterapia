Public Class form_imprimir_servicos

    Private Sub Imprimir_Servicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ServicosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
            Me.ImprimirServicosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Dim nome, codigo, valorUnitario As String
            If NomeToolStripTextBox.Text = "" Then
                nome = "''"
            Else
                nome = NomeToolStripTextBox.Text
            End If
            If CodigoToolStripTextBox.Text = "" Then
                codigo = "''"
            Else
                codigo = CodigoToolStripTextBox.Text
            End If
            If ValorUnitarioToolStripTextBox.Text = "" Then
                valorUnitario = "''"
            Else
                valorUnitario = ValorUnitarioToolStripTextBox.Text
            End If
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos WHERE (Nome Like '%" & nome & "%') OR (Codigo Like '%" & codigo & "%') OR (ValorUnitario Like '%" & valorUnitario & "%')"
            Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
            Me.ImprimirServicosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos"
            Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
            Me.ImprimirServicosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class