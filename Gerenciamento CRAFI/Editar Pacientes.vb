Public Class form_editar_pacientes

    Private Sub form_editar_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AtualizarPacientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarPacientesToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes"
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PacientesDataGridView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PacientesDataGridView.CellMouseDoubleClick
        Try
            setTipoForm(1)
            form_incluir_pacientes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub FillByPesquisaPacientesSemAIToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByPesquisaPacientesSemAIToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = filtroPacientes(CodigoPacienteToolStripTextBox.Text, NomeToolStripTextBox.Text, CEPToolStripTextBox.Text, EnderecoToolStripTextBox.Text, BairroToolStripTextBox.Text, CidadeToolStripTextBox.Text, EstadoToolStripTextBox.Text, PaisToolStripTextBox.Text, PlanoSaudeToolStripTextBox.Text, CelularToolStripTextBox.Text, TelefoneToolStripTextBox.Text, RegistroToolStripComboBox.Text, TelefoneResidencialToolStripTextBox.Text)
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ImprimirPacientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirPacientesToolStripButton.Click
        Try
            form_imprimir_pacientes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class