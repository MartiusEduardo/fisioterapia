Public Class form_incluir_servicos

    Dim tipoForm As Integer

    Private Sub ServicosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ServicosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo serviço", DateTime.Now)
                Case 1
                    MsgBox("Serviço salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou serviço", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_servicos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_servicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ServicosTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao 
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Serviço"
                Case 1
                    Me.Text = "Editar Serviço"
                    AdicionarServicosToolStripButton.Visible = False
                    CancelarServicosToolStripButton.Visible = False
                    ImprimirToolStripButton.Visible = True
                    habilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, False, True, False)
                    Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
                    Dim codigo As String = form_editar_servicos.ServicosDataGridView.CurrentRow.Cells(2).Value
                    Me.ServicosTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ServicosTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Servicos WHERE (Codigo = '" & codigo & "')"
                    Me.ServicosTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Servicos)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarServicosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarServicosToolStripButton.Click
        Try
            ServicosBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarServicosToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarServicosToolStripButton.Click
        Try
            ServicosBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarServicosToolStripButton, ServicosBindingNavigatorSaveItem, CancelarServicosToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripButton.Click
        Try
            form_imprimir_servico.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class