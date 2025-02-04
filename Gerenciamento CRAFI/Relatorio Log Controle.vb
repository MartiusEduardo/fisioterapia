Public Class form_relatorio_log_controle

    Private Sub form_relatorio_log_controle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LogControleTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.LogControle)
            Me.LogControleReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class