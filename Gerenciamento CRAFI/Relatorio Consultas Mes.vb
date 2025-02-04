Public Class form_relatorio_consultas_mes

    Private Sub form_relatorio_consultas_mes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConsultasTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            Me.ConsultasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConsultasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Consultas WHERE Data BETWEEN GETDATE() AND DATEADD(MONTH, 1, getdate())"
            Me.ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            ConsultasMesReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class