Public Class form_imprimir_convenios

    Private Sub form_imprimir_convenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
            Me.ImprimirConveniosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Try
            Dim razaoSocial, cidade, estado, email As String
            If RazaoSocialToolStripTextBox.Text = "" Then
                razaoSocial = "''"
            Else
                razaoSocial = RazaoSocialToolStripTextBox.Text
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
            If EmailToolStripTextBox.Text = "" Then
                email = "''"
            Else
                email = EmailToolStripTextBox.Text
            End If
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios WHERE (RazaoSocial Like '%" & razaoSocial & "%') OR (Cidade Like '%" & cidade & "%') OR (Estado Like '%" & estado & "%') OR (Email Like '%" & email & "%')"
            Me.ConveniosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Convenios)
            Me.ImprimirConveniosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AtualizarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizarToolStripButton.Click
        Try
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios"
            Me.ConveniosTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Convenios)
            Me.ImprimirConveniosReportViewer.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class