Public Class form_editar_profissional

    Private Sub ProfissionaisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionaisBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProfissionaisBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            MsgBox("Profissional salvo com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou profissional", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            Dim codigoPro As String
            codigoPro = form_editar_profissionais.ProfissionaisDataGridView.CurrentRow.Cells(0).Value
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais WHERE (CodigoPro = '" & codigoPro & "')"
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ImprimirProfissionalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirProfissionalToolStripButton.Click
        Try
            form_imprimir_profissional.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class