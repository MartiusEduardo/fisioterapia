Imports Microsoft
Public Class form_aniversariantes

    Private Sub Aniversariante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
            Dim data As String = My.Settings.Aniversario
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes WHERE (DataNascimento Like '%" & data & "%') AND (RegistroAtivo = '1' OR RegistroAtivo IS NULL)"
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
            Me.AniversariantesReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
        Me.AniversariantesReportViewer.RefreshReport()
    End Sub
End Class