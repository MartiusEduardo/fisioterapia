Public Class form_anamnese

    Private Sub AnamneseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnamneseBindingNavigatorSaveItem.Click
        Try
            DataUltimaAtualizacaoTextBox.Text = Format(Today, "yyyy-MM-dd")
            Me.Validate()
            Me.AnamneseBindingSource.EndEdit()
            Me.AnamneseTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.Anamnese)
            CancelarAnamneseToolStripButton.Enabled = False
            ExamesComplementaresToolStripButton.Enabled = True
            CirurgiasToolStripButton.Enabled = True
            MsgBox("Anamnese salva com sucesso!", MsgBoxStyle.OkOnly)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou ou editou anamnese", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AdicionarAnamneseToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarAnamneseToolStripButton.Click
        Try
            AnamneseBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarAnamneseToolStripButton, AnamneseBindingNavigatorSaveItem, CancelarAnamneseToolStripButton, False, True, True)
            NumeroProntuarioTextBox.Text = form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            DataTextBox.Text = Format(Today, "yyyy-MM-dd")
            DataUltimaAtualizacaoTextBox.Text = Format(Today, "yyyy-MM-dd")
            'Checkbox
            TabagismoCheckBox.Checked = False
            EtilismoCheckBox.Checked = False
            CarneVermelhaCheckBox.Checked = False
            HidratacaoCheckBox.Checked = False
            DormeMesmoHorarioCheckBox.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarAnamneseToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarAnamneseToolStripButton.Click
        Try
            AnamneseBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarAnamneseToolStripButton, AnamneseBindingNavigatorSaveItem, CancelarAnamneseToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirAnamneseToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirAnamneseToolStripButton.Click
        Try
            form_imprimir_anamnese.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExamesComplementaresToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamesComplementaresToolStripButton.Click
        Try
            Dim examesCompl As New form_exames_complementares
            examesCompl.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_anamnese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            AnamneseTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '------------------------------------------------------------------------------------------------------------------------------
            Me.AnamneseTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Anamnese)
            Me.AnamneseTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
            Me.AnamneseTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Anamnese WHERE (NumeroProntuario = '" & form_anamnese_dos_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value & "')"
            If Me.AnamneseTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Anamnese) <> 0 Then
                habilitarObjetos(Me, AdicionarAnamneseToolStripButton, AnamneseBindingNavigatorSaveItem, CancelarAnamneseToolStripButton, False, True, False)
                ExamesComplementaresToolStripButton.Enabled = True
                CirurgiasToolStripButton.Enabled = True
            Else
                desabilitarObjetos(Me, AdicionarAnamneseToolStripButton, AnamneseBindingNavigatorSaveItem, CancelarAnamneseToolStripButton, True, False, False)
                ExamesComplementaresToolStripButton.Enabled = False
                CirurgiasToolStripButton.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CirurgiasToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CirurgiasToolStripButton.Click
        Try
            Dim cirurgias As New form_cirurgias
            cirurgias.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class