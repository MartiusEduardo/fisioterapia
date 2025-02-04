Public Class form_imprimir_servico

    Private Sub form_imprimir_servico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ServicosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos WHERE (Codigo Like '" & form_editar_servicos.ServicosDataGridView.CurrentRow.Cells(2).Value & "')"
            Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
            Me.ImprimirServicoReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class