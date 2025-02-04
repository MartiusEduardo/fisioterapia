Public Class form_imprimir_pacientes

    Private codigo, nome, cep, endereco, bairro, cidade, estado, pais, planoSaude, celular, telefone, ativo As String

    Private Sub form_imprimir_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
            Me.ImprimirPacientesReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub FillByPesquisaPacientesSemAIToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByPesquisaPacientesSemAIToolStripButton.Click
        Try
            filtroPacientes()
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes WHERE (CodigoPaciente Like '%" & codigo & "%') OR (Nome Like '%" & nome & "%') OR (CEP Like '%" & cep & "%') OR (Endereco Like '%" & endereco & "%') OR (Bairro Like '%" & bairro & "%') OR (Cidade Like '%" & cidade & "%') OR (Estado Like '%" & estado & "%') OR (Pais Like '%" & pais & "%') OR (PlanosSaude Like '%" & planoSaude & "%') OR (Celular Like '%" & celular & "%') OR (TelefoneComercial Like '%" & telefone & "%') OR (RegistroAtivo Like '%" & ativo & "%')"
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
            Me.ImprimirPacientesReportViewer.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub filtroPacientes()
        If CodigoPacienteToolStripTextBox.Text = "" Then
            codigo = "''"
        Else
            codigo = CodigoPacienteToolStripTextBox.Text
        End If
        If NomeToolStripTextBox.Text = "" Then
            nome = "''"
        Else
            nome = NomeToolStripTextBox.Text
        End If
        If CEPToolStripTextBox.Text = "" Then
            cep = "''"
        Else
            cep = CEPToolStripTextBox.Text
        End If
        If EndereçoToolStripTextBox.Text = "" Then
            endereco = "''"
        Else
            endereco = EndereçoToolStripTextBox.Text
        End If
        If BairroToolStripTextBox.Text = "" Then
            bairro = "''"
        Else
            bairro = BairroToolStripTextBox.Text
        End If
        If CidadeToolStripTextBox.Text = "" Then
            cidade = "''"
        Else
            cidade = CidadeToolStripTextBox.Text
        End If
        If EstadoToolStripTextBox.Text = "" Then
            estado = "''"
        Else
            estado = EstadoToolStripTextBox.Text
        End If
        If PaisToolStripTextBox.Text = "" Then
            pais = "''"
        Else
            pais = PaisToolStripTextBox.Text
        End If
        If PlanoSaudeToolStripTextBox.Text = "" Then
            planoSaude = "''"
        Else
            planoSaude = PlanoSaudeToolStripTextBox.Text
        End If
        If CelularToolStripTextBox.Text = "" Then
            celular = "''"
        Else
            celular = CelularToolStripTextBox.Text
        End If
        If TelefoneToolStripTextBox.Text = "" Then
            telefone = "''"
        Else
            telefone = TelefoneToolStripTextBox.Text
        End If
        If RegistroToolStripComboBox.Text = "Ativo" Then
            ativo = 1
        ElseIf RegistroToolStripComboBox.Text = "Inativo" Then
            ativo = 0
        Else
            ativo = "''"
        End If
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes"
            Me.PacientesTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Pacientes)
            Me.ImprimirPacientesReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class