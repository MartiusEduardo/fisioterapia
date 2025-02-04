Public Class form_editar_profissionais

    Private Sub form_editar_profissionais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao 
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais"
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ProfissionaisDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProfissionaisDataGridView.CellDoubleClick
        Try
            setTipoForm(1)
            form_incluir_profissional.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = filtroProfissionais(RegOrgClasseToolStripTextBox.Text, NomeToolStripTextBox.Text, DataNascimentoToolStripTextBox.Text, EnderecoToolStripTextBox.Text, BairroToolStripTextBox.Text, CidadeToolStripTextBox.Text, EstadoToolStripTextBox.Text, PaisToolStripTextBox.Text, TelefoneToolStripTextBox.Text, CelularToolStripTextBox.Text, RegistroToolStripComboBox.Text)
            Me.ProfissionaisTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_profissionais.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class