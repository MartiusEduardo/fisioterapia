Public Class form_editar_convenio

    Private Sub ConveniosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ConveniosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Me.ServicosConveniosTableAdapter.Update(Gerenciamento_CRAFIDataSet.ServicosConvenios)
            MsgBox("Convênio salvo com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou convênio", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_editar_convenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ServicosConveniosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
            Me.ServicosConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
            Dim cnpj As String
            cnpj = form_editar_convenios.ConveniosDataGridView.CurrentRow.Cells(1).Value
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios WHERE (CNPJ = '" & cnpj & "')"
            Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
            Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ServicosConvenios WHERE (CNPJ = '" & cnpj & "')"
            Me.ServicosConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub ServicosConveniosDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ServicosConveniosDataGridView.CellBeginEdit
        Try
            Me.ServicosConveniosDataGridView.CurrentRow.Cells(0).Value = CNPJTextBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirConveniosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirConveniosToolStripButton.Click
        Try
            form_imprimir_convenio.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class