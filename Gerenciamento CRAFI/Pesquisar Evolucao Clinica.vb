Public Class form_pesquisar_evolucao_clinica

    Private Sub form_pesquisar_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = filtroEvolucaoClinica(NumEvolClinicaToolStripTextBox.Text, NumRegistroProfissioanlToolStripTextBox.Text, ProfissionalToolStripTextBox.Text, CodigoPacienteToolStripTextBox.Text, CPFToolStripTextBox.Text, NomeToolStripTextBox.Text, DataToolStripTextBox.Text, QueixaPrincipalToolStripTextBox.Text, HDAToolStripTextBox.Text, ExameFisicoToolStripTextBox.Text, CIFToolStripTextBox.Text, CIDToolStripTextBox.Text, TratamentoToolStripTextBox.Text, AssinaturaToolStripTextBox.Text)
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_evolucoes_clinicas.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class