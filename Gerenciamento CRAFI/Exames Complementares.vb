Imports System.Windows
Public Class form_exames_complementares

    Private Sub ExamesComplementaresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamesComplementaresBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ExamesComplementaresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarToolStripButton, ExamesComplementaresBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            ExamesComplementaresDataGridView.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_exames_complementares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            ExamesComplementaresTableAdapter.Connection.ConnectionString = conexao.strConexao
            QueriesTableAdapter.changeConnection(conexao.strConexao)
            '------------------------------------------------------------------------------------------------------------------------------
            Me.ExamesComplementaresTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ExamesComplementares)
            desabilitarObjetos(Me, AdicionarToolStripButton, ExamesComplementaresBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            ExamesComplementaresDataGridView.Enabled = True
            Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ExamesComplementares WHERE (NumeroProntuario = '" & form_anamnese.NumeroProntuarioTextBox.Text & "')"
            Me.ExamesComplementaresTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ExamesComplementares)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarToolStripButton.Click
        Try
            ExamesComplementaresBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarToolStripButton, ExamesComplementaresBindingNavigatorSaveItem, CancelarToolStripButton, False, True, True)
            ExamesComplementaresDataGridView.Enabled = False
            Me.NumeroProntuarioTextBox.Text = form_anamnese.NumeroProntuarioTextBox.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnInserirImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirImagem.Click
        Try
            OFDExamesComplementares.FileName = ""
            OFDExamesComplementares.Filter = "Arquivos de Imagem (*.jpg; *.gif; *.jpe; *.bmp; *.png) | *.jpg; *.gif; *.jpe; *.bmp; *.png"
            If OFDExamesComplementares.ShowDialog = Windows.Forms.DialogResult.OK Then
                ExameComplementarPictureBox.Image = Image.FromFile(OFDExamesComplementares.FileName)
            Else
                Dim resposta As String = "Cancelado"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripButton.Click
        Try
            ExamesComplementaresBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarToolStripButton, ExamesComplementaresBindingNavigatorSaveItem, CancelarToolStripButton, True, False, False)
            ExamesComplementaresDataGridView.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExamesComplementaresDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ExamesComplementaresDataGridView.CellDoubleClick
        Try
            If MsgBox("Deseja excluir o exame complementar " & ExamesComplementaresDataGridView.CurrentRow.Cells(0).Value & " do paciente " & ExamesComplementaresDataGridView.CurrentRow.Cells(1).Value & "?", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
                QueriesTableAdapter.excluirExamesComplemetares(ExamesComplementaresDataGridView.CurrentRow.Cells(0).Value, ExamesComplementaresDataGridView.CurrentRow.Cells(1).Value)
                Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                Me.ExamesComplementaresTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM ExamesComplementares WHERE (NumeroProntuario = '" & form_anamnese.NumeroProntuarioTextBox.Text & "')"
                Me.ExamesComplementaresTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.ExamesComplementares)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class