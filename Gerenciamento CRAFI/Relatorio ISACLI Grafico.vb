Public Class form_relatorio_ISACLI_grafico

    Private Sub form_relatorio_ISACLI_grafico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConsultasTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConsultasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Consultas)
            Dim data As String = My.Settings.ConsultaDataGrafico
            Me.ConsultasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConsultasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Consultas WHERE (Data Like '%" & data & "%')"
            Me.ConsultasTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Consultas)
            Me.ISACLIGraficoReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class