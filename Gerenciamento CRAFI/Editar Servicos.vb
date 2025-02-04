Public Class form_editar_servicos

    Private Sub form_editar_servicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ServicosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos"
            Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ServicosDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ServicosDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_servicos.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = filtroServicos(NomeToolStripTextBox.Text, , CodigoToolStripTextBox.Text, ValorUnitarioToolStripTextBox.Text)
            Me.ServicosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Servicos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_servicos.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class