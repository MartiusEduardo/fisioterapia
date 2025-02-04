Public Class form_incluir_convenio

    Private Sub ConveniosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ConveniosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Me.ServicosConveniosTableAdapter.Update(Gerenciamento_CRAFIDataSet.ServicosConvenios)
            desabilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo convênio", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_convenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ServicosConveniosTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarConvenioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarConvenioToolStripButton.Click
        Try
            ConveniosBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarConvenioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarConvenioToolStripButton.Click
        Try
            ServicosConveniosBindingSource.CancelEdit()
            ConveniosBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CNPJTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CNPJTextBox.TextChanged
        Try
            If CNPJTextBox.Text <> "" Then
                GrupoServicosConvenio.Enabled = True
            Else
                GrupoServicosConvenio.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ServicosConveniosDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ServicosConveniosDataGridView.CellBeginEdit
        Try
            ServicosConveniosDataGridView.CurrentRow.Cells(0).Value = CNPJTextBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class