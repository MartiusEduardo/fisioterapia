Public Class form_cirurgias

    Private Sub CirurgiasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CirurgiasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CirurgiasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, CirurgiasBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            CirurgiasDataGridView.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub Cirurgias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            CirurgiasTableAdapter.Connection.ConnectionString = conexao.strConexao
            '------------------------------------------------------------------------------------------------------------------------------
            Me.CirurgiasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Cirurgias)
            desabilitarObjetos(Me, AdicionarToolStripButton, CirurgiasBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            CirurgiasDataGridView.Enabled = True
            Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Cirurgias WHERE (NumeroProntuario = '" & form_anamnese.NumeroProntuarioTextBox.Text & "')"
            Me.CirurgiasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Cirurgias)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            CirurgiasBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, CirurgiasBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
            CirurgiasDataGridView.Enabled = False
            Me.NumeroProntuarioTextBox.Text = form_anamnese.NumeroProntuarioTextBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripButton.Click
        Try
            CirurgiasBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, CirurgiasBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            CirurgiasDataGridView.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CirurgiasDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CirurgiasDataGridView.CellDoubleClick
        Try
            If (MsgBox("Deseja excluir a cirurgia " & CirurgiasDataGridView.CurrentRow.Cells(0).Value & " do paciente " & CirurgiasDataGridView.CurrentRow.Cells(1).Value & "?", vbQuestion + vbYesNo) = MsgBoxResult.Yes) Then
                QueriesTableAdapter.excluirCirurgia(CirurgiasDataGridView.CurrentRow.Cells(0).Value, CirurgiasDataGridView.CurrentRow.Cells(1).Value)
                Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.CirurgiasTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Cirurgias WHERE (NumeroProntuario = '" & form_anamnese.NumeroProntuarioTextBox.Text & "')"
                Me.CirurgiasTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Cirurgias)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class