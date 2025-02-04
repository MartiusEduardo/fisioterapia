Public Class form_imprimir_profissionais

    Private Sub form_imprimir_profissionais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ImprimirProfissionaisReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Dim registroOrgao, nome, data, endereco, bairro, cidade, estado, pais, telefone, celular As String
            If RegOrgClasseToolStripTextBox.Text = "" Then
                registroOrgao = "''"
            Else
                registroOrgao = RegOrgClasseToolStripTextBox.Text
            End If
            If NomeToolStripTextBox.Text = "" Then
                nome = "''"
            Else
                nome = NomeToolStripTextBox.Text
            End If
            If DataNascimentoToolStripTextBox.Text = "" Then
                data = "''"
            Else
                data = DataNascimentoToolStripTextBox.Text
            End If
            If EnderecoToolStripTextBox.Text = "" Then
                endereco = "''"
            Else
                endereco = EnderecoToolStripTextBox.Text
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
            If TelefoneToolStripTextBox.Text = "" Then
                telefone = "''"
            Else
                telefone = TelefoneToolStripTextBox.Text
            End If
            If CelularToolStripTextBox.Text = "" Then
                celular = "''"
            Else
                celular = CelularToolStripTextBox.Text
            End If
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais WHERE (NumRegistroOrgaoClasse Like '%" & registroOrgao & "%') OR (Nome Like '%" & nome & "%') OR (Endereco Like '%" & endereco & "%') OR (Bairro Like '%" & bairro & "%') OR (Cidade Like '%" & cidade & "%') OR (Estado Like '%" & estado & "%') OR (Pais Like '%" & pais & "%') OR (Celular Like '%" & celular & "%') OR (Telefone Like '%" & telefone & "%') OR (DataNascimento Like '%" & data & "%')"
            Me.ProfissionaisTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ImprimirProfissionaisReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais"
            Me.ProfissionaisTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Profissionais)
            Me.ImprimirProfissionaisReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class