Public Class form_editar_usuarios

    Private Sub form_editar_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.LoginTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Login"
            Me.LoginTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub LoginDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LoginDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_usuario.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class