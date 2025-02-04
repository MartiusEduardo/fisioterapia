Public Class form_relatorio_aniversario_profissional

    Private Sub form_relatorio_aniversario_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Dim data As String = My.Settings.AniversarioProfissional
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais WHERE (DataNascimento Like '%" & data & "%')"
            Me.ProfissionaisTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ProfissionaisAniversariantesReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class