Public Class form_convenio

    Public tipoForm As Integer

    Private Sub ConveniosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConveniosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ConveniosBindingSource.EndEdit()
            Me.ServicosConveniosTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
            Me.ConveniosTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.Convenios)
            Me.ServicosConveniosTableAdapter.Update(Gerenciamento_CRAFIDataSet.ServicosConvenios)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo convênio", DateTime.Now)
                Case 1
                    MsgBox("Convênio salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou convênio", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_convenio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_convenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            ServicosConveniosTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0 'Incluir Convênio
                    Me.Text = "Incluir Convênio"
                    ImprimirConvenioToolStripButton.Visible = False
                    ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
                Case 1 'Editar Convênio
                    Me.Text = "Editar Convênio"
                    habilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, False, True, False)
                    AdicionarConvenioToolStripButton.Visible = False
                    CancelarConvenioToolStripButton.Visible = False
                    Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
                    Me.ServicosConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
                    Dim codConvenio As Integer
                    codConvenio = form_editar_convenios.ConveniosDataGridView.CurrentRow.Cells(0).Value
                    Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Convenios WHERE (CodigoConvenio = '" & codConvenio & "')"
                    Me.ConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Convenios)
                    Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ServicosConveniosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ServicosConvenios WHERE (CodigoConvenio = '" & codConvenio & "')"
                    Me.ServicosConveniosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ServicosConvenios)
            End Select
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
            ServicosConveniosDataGridView.Refresh()
            ServicosConveniosBindingSource.CancelEdit()
            ConveniosBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarConvenioToolStripButton, ConveniosBindingNavigatorSaveItem, CancelarConvenioToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ServicosConveniosDataGridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ServicosConveniosDataGridView.CellBeginEdit
        Try
            ServicosConveniosDataGridView.CurrentRow.Cells(0).Value = CodigoConvenioTextBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirConvenioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirConvenioToolStripButton.Click
        Try
            form_imprimir_convenio.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class