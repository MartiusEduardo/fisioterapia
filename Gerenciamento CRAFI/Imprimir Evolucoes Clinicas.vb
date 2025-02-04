Public Class form_imprimir_evolucoes_clinicas

    Private Sub Imprimir_Evolucoes_Clinicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.ImprimirECReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Dim numEvolClinica, numRegProfissional, profissional, codigoPaciente, cpf, nome, data, queixaPrincipal, hda, exameFisico, cif, cid, tratamento, assinatura As String
            If NumEvolClinicaToolStripTextBox.Text = "" Then
                numEvolClinica = "''"
            Else
                numEvolClinica = NumEvolClinicaToolStripTextBox.Text
            End If
            If NumRegistroProfissioanlToolStripTextBox.Text = "" Then
                numRegProfissional = "''"
            Else
                numRegProfissional = NumRegistroProfissioanlToolStripTextBox.Text
            End If
            If ProfissionalToolStripTextBox.Text = "" Then
                profissional = "''"
            Else
                profissional = ProfissionalToolStripTextBox.Text
            End If
            If CodigoPacienteToolStripTextBox.Text = "" Then
                codigoPaciente = "''"
            Else
                codigoPaciente = CodigoPacienteToolStripTextBox.Text
            End If
            If CPFToolStripTextBox.Text = "" Then
                cpf = "''"
            Else
                cpf = CPFToolStripTextBox.Text
            End If
            If NomeToolStripTextBox.Text = "" Then
                nome = "''"
            Else
                nome = NomeToolStripTextBox.Text
            End If
            If DataToolStripTextBox.Text = "" Then
                data = "''"
            Else
                data = DataToolStripTextBox.Text
            End If
            If QueixaPrincipalToolStripTextBox.Text = "" Then
                queixaPrincipal = "''"
            Else
                queixaPrincipal = QueixaPrincipalToolStripTextBox.Text
            End If
            If HDAToolStripTextBox.Text = "" Then
                hda = "''"
            Else
                hda = HDAToolStripTextBox.Text
            End If
            If ExameFisicoToolStripTextBox.Text = "" Then
                exameFisico = "''"
            Else
                exameFisico = ExameFisicoToolStripTextBox.Text
            End If
            If CIFToolStripTextBox.Text = "" Then
                cif = "''"
            Else
                cif = CIFToolStripTextBox.Text
            End If
            If CIDToolStripTextBox.Text = "" Then
                cid = "''"
            Else
                cid = CIDToolStripTextBox.Text
            End If
            If TratamentoToolStripTextBox.Text = "" Then
                tratamento = "''"
            Else
                tratamento = TratamentoToolStripTextBox.Text
            End If
            If AssinaturaToolStripTextBox.Text = "" Then
                assinatura = "''"
            Else
                assinatura = AssinaturaToolStripTextBox.Text
            End If
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (NumeroProntuario Like '%" & numEvolClinica & "%') OR (NumRegistroProfissional Like '%" & numRegProfissional & "%') OR (Profissional Like '%" & profissional & "%') OR (CodigoPaciente Like '%" & codigoPaciente & "%') OR (CPF Like '%" & cpf & "%') OR (Nome Like '%" & nome & "%') OR (Data Like '%" & data & "%') OR (QueixaPrincipal Like '%" & queixaPrincipal & "%') OR (HistoriaDoencaAtual Like '%" & hda & "%') OR (ExameFisico Like '%" & exameFisico & "%') OR (CIF Like '%" & cif & "%') OR (CID Like '%" & cid & "%') OR (Tratamento Like '%" & tratamento & "%') OR (Assinatura Like '%" & assinatura & "%')"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.ImprimirECReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica"
            Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
            Me.ImprimirECReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class