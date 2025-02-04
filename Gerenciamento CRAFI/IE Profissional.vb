Imports System.Windows
Public Class form_incluir_profissional

    Dim tipoForm As Integer

    Private Sub ProfissionaisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionaisBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProfissionaisBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo profissional", DateTime.Now)
                Case 1
                    MsgBox("Profissional salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou profissional", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_profissional_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao 
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Profissional"
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
                Case 1
                    Me.Text = "Editar Profissional"
                    AdicionarProfissionalToolStripButton.Visible = False
                    CancelarProfissionalToolStripButton.Visible = False
                    ImprimirProfissionalToolStripButton.Visible = True
                    habilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, False, True, False)
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
                    Dim codigoPro As String
                    codigoPro = form_editar_profissionais.ProfissionaisDataGridView.CurrentRow.Cells(0).Value
                    Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.ProfissionaisTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Profissionais WHERE (CodigoPro = '" & codigoPro & "')"
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarProfissionalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarProfissionalToolStripButton.Click
        Try
            Me.ProfissionaisBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, False, True, True)
            'Grupo Sexo
            SexoMRadioButton.Checked = False
            SexoFRadioButton.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarProfissionalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarProfissionalToolStripButton.Click
        Try
            Me.ProfissionaisBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, True, False, False)
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