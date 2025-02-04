Public Class form_imprimir_profissional

    Private Sub form_imprimir_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais WHERE (CodigoPro Like '" & form_editar_profissionais.ProfissionaisDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.ProfissionaisTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ImprimirProfissionalReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class