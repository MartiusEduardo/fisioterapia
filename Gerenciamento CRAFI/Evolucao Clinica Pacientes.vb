Public Class form_evolucao_clinica_pacientes

    Private Sub Evolucao_Clinica_Pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub PacientesDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PacientesDataGridView.CellDoubleClick
        Try
            If PretendeToolStripComboBox.Text = "" Then
                MsgBox("É necessário dizer o que pretende fazer: Inlcuir, Editar ou Excluir Evolução Clínica.", MsgBoxStyle.OkOnly)
            ElseIf PretendeToolStripComboBox.Text = "Incluir Evolução Clínica" Then
                form_incluir_evolucao_clinica.ShowDialog()
            ElseIf PretendeToolStripComboBox.Text = "Editar Evolução Clínica" Then
                form_editar_evolucoes_clinicas.ShowDialog()
            ElseIf PretendeToolStripComboBox.Text = "Excluir Evolução Clínica" Then
                form_excluir_evolucao_clinica.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscaToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = filtroPacientes(CodigoPacienteToolStripTextBox.Text, NomeToolStripTextBox.Text, , , BairroToolStripTextBox.Text, CidadeToolStripTextBox.Text, EstadoToolStripTextBox.Text, , , , , )
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes"
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class