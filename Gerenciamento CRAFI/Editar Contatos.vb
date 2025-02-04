Public Class form_editar_contatos

    Private Sub Editar_Contatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ContatosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            ContatosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            ContatosTableAdapter.Adapter.SelectCommand.CommandText = "Select * From Contatos"
            ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ContatosDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ContatosDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_ie_contatos.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class