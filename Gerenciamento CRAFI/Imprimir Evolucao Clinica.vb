Public Class form_imprimir_evolucao_clinica

    Private Sub form_imprimir_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (codigoEvolucaoClinica = '" & form_incluir_evolucao_clinica.CodigoEvolucaoClinicaTextBox.Text & "')"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.ImprimirEvolucaoClinicaReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class