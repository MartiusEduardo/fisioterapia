Public Class form_incluir_profissional

    Private Sub ProfissionaisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionaisBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProfissionaisBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo profissional", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_profissional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarProfissionalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarProfissionalToolStripButton.Click
        Try
            Me.ProfissionaisBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarProfissionalToolStripButton, ProfissionaisBindingNavigatorSaveItem, CancelarProfissionalToolStripButton, False, True, True)
            'Grupo Sexo
            SexoMRadioButton.Checked = True
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
End Class