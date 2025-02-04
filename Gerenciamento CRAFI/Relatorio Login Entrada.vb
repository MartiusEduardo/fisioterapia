Public Class form_relatorio_login_entrada

    Private Sub form_relatorio_login_entrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogEntradaTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LogEntradaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.LogEntrada)
            Me.ReportViewerLogEntrada.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class