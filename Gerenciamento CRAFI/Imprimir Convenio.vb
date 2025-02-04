Public Class form_imprimir_convenio

    Private Sub form_imprimir_convenio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            TableAdapterManager.Connection.Close()
        Catch ex As Exception
            MsgBox("Não foi possível fechar a conexão." & vbCr & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_imprimir_convenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            ServicosConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
            Me.ServicosConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios WHERE (CodigoConvenio Like '" & form_editar_convenios.ConveniosDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.ConveniosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Convenios)
            Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ServicosConvenios WHERE (CodigoConvenio Like '" & form_editar_convenios.ConveniosDataGridView.CurrentRow.Cells(0).Value & "')"
            Me.ServicosConveniosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.ServicosConvenios)
            Me.ImprimirConvenioReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class