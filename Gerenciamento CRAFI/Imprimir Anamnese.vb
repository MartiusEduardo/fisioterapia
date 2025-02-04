Public Class form_imprimir_anamnese

    Private Sub form_imprimir_anamnese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            AnamneseTableAdapter.Connection.ConnectionString = conexao.strConexao
            ExamesComplementaresTableAdapter.Connection.ConnectionString = conexao.strConexao
            CirurgiasTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.AnamneseTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Anamnese)
            Me.CirurgiasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Cirurgias)
            Me.ExamesComplementaresTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ExamesComplementares)
            Dim codigoPaciente As String
            codigoPaciente = form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            Me.AnamneseTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.AnamneseTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Anamnese WHERE (NumeroProntuario = '" & codigoPaciente & "')"
            Me.AnamneseTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Anamnese)
            Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Cirurgias WHERE (NumeroProntuario = '" & codigoPaciente & "')"
            Me.CirurgiasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Cirurgias)
            Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ExamesComplementares WHERE (NumeroProntuario = '" & codigoPaciente & "')"
            Me.ExamesComplementaresTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ExamesComplementares)
            Me.ImprimirAnamneseReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class