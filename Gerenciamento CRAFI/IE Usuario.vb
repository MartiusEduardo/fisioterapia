Public Class form_incluir_usuario

    Dim tipoForm As Integer

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "excluiu serviço", DateTime.Now)
                Case 1
                    MsgBox("Usuário salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou usuário", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_usuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LoginTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Usuário"
                    desabilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, True, False, False)
                Case 1
                    Me.Text = "Editar Usuário"
                    AdicionarUsuarioToolStripButton.Visible = False
                    CancelarUsuarioToolStripButton.Visible = False
                    habilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, False, True, False)
                    Me.LoginTableAdapter.Fill(Gerenciamento_CRAFIDataSet.Login)
                    Dim usuario As String
                    usuario = form_editar_usuarios.LoginDataGridView.CurrentRow.Cells(0).Value
                    Me.LoginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.LoginTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Login WHERE (Usuario Like '" & usuario & "')"
            End Select
            LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarUsuarioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarUsuarioToolStripButton.Click
        Try
            LoginBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, False, True, True)
            checarTodosFalse()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarUsuarioToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarUsuarioToolStripButton.Click
        Try
            LoginBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarUsuarioToolStripButton, LoginBindingNavigatorSaveItem, CancelarUsuarioToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub checarTodosFalse()
        For Each clt As Control In Me.Controls
            If TypeOf clt Is GroupBox Then
                For Each cb As CheckBox In clt.Controls
                    If TypeOf cb Is CheckBox Then
                        cb.Checked = False
                    End If
                Next
            End If
        Next
        ConsultaAgendaCheckBox.Checked = False
        AnamneseCheckBox.Checked = False
    End Sub
End Class