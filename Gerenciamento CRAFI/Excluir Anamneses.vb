Public Class form_excluir_anamneses

    Private Sub form_excluir_anamneses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim user As String = My.Settings.Usuario
            Dim senha As String = My.Settings.Senha
            Dim servidor As String = My.Settings.Servidor
            Me.AnamneseTableAdapter.Connection.ConnectionString = "Data Source=" & servidor & ";User ID=" & user & ";Password=" & senha
            Me.LogControleTableAdapter.Connection.ConnectionString = "Data Source=" & servidor & ";User ID=" & user & ";Password=" & senha
            Dim cpf As String
            cpf = form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            'Me.AnamneseTableAdapter.FillByCPFAnamnese(Me.Gerenciamento_CRAFIDataSet.Anamnese, cpf)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ExcluirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripButton.Click
        Try
            If ExcluirDataToolStripTextBox.Text = "" Then
                MsgBox("É necessário inserir uma Data.", MsgBoxStyle.OkOnly)
            Else
                If MsgBox("Tem certeza que deseja excluir a anamnese do paciente " & form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(1).Value & " na data " & ExcluirDataToolStripTextBox.Text & "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim cpf As String
                    cpf = form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
                    'Me.AnamneseTableAdapter.DeleteQueryCPFDataAnamnese(cpf, ExcluirDataToolStripTextBox.Text)
                    'Me.AnamneseTableAdapter.FillByCPFAnamnese(Me.Gerenciamento_CRAFIDataSet.Anamnese, cpf)
                    MsgBox("Anamnese excluída com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu anamnese", DateTime.Now)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class