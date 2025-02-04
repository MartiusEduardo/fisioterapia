Public Class form_editar_paciente

    Private Sub PacientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Paciente foi salvo com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou paciente", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            PacientesTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Dim codigoPaciente As String
            codigoPaciente = form_editar_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes WHERE (CodigoPaciente = '" & codigoPaciente & "')"
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirPacientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirPacientesToolStripButton.Click
        Try
            form_imprimir_paciente.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class