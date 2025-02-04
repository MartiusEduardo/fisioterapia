Public Class form_ie_contatos

    Dim tipoForm As Integer

    Private Sub ContatosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ContatosBindingSource.EndEdit()
            Me.ContatosTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.Contatos)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarToolStripButton, ContatosBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um contato", DateTime.Now)
                Case 1
                    MsgBox("Contato salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou contato", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            ContatosBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, ContatosBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripButton.Click
        Try
            ContatosBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, ContatosBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_ie_contatos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_ie_contatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ContatosTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Contato"
                    Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
                    desabilitarObjetos(Me, AdicionarToolStripButton, ContatosBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
                Case 1
                    Me.Text = "Editar Contato"
                    AdicionarToolStripButton.Visible = False
                    CancelarToolStripButton.Visible = False
                    habilitarObjetos(Me, AdicionarToolStripButton, ContatosBindingNavigatorSaveItem, CancelarToolStripButton, False, True, False)
                    Dim codigo As String
                    codigo = form_editar_contatos.ContatosDataGridView.CurrentRow.Cells(0).Value
                    Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
                    Me.ContatosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ContatosTableAdapter.Adapter.SelectCommand.CommandText = "Select * From Contatos Where (codigoContato = '" & codigo & "')"
                    Me.ContatosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Contatos)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class