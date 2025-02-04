Public Class form_editar_convenios

    Private Sub form_editar_convenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios"
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ConveniosDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ConveniosDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_convenio.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = filtroConvenios(, RazaoSocialToolStripTextBox.Text, , , CidadeToolStripTextBox.Text, EstadoToolStripTextBox.Text, , , , EmailToolStripTextBox.Text, , , )
            Me.ConveniosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Convenios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_convenios.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class