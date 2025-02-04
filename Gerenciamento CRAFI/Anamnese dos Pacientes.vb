Public Class form_anamnese_dos_pacientes

    Private Sub form_anamnese_dos_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes"
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PacientesDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PacientesDataGridView.CellDoubleClick
        Try
            form_anamnese.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Dim strSQL As String = filtroPacientes(CodigoPacienteToolStripTextBox.Text, NomeToolStripTextBox.Text, , , BairroToolStripTextBox.Text, CidadeToolStripTextBox.Text, EstadoToolStripTextBox.Text)
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = strSQL
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class