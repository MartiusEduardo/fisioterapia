Public Class form_incluir_pacientes

    Private Sub PacientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
            desabilitarObjetos(Me, AdicionarPacienteToolStripButton, PacientesBindingNavigatorSaveItem, CancelarPacienteToolStripButton, True, False, False)
            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo paciente", DateTime.Now)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            PacientesTableAdapter.Connection.ConnectionString = conexao.conexaoServidor
            '-----------------------------------------------------------------------------------------------------------------------------
            Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarPacienteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarPacienteToolStripButton.Click
        Try
            PacientesBindingSource.AddNew()
            habilitarObjetos(Me, AdicionarPacienteToolStripButton, PacientesBindingNavigatorSaveItem, CancelarPacienteToolStripButton, False, True, True)
            'Grupo Sexo
            SexoMRadioButton.Checked = True
            SexoFRadioButton.Checked = False
            'Grupo Registro
            RegistroAtivoRadioButton.Checked = True
            RegistroInativoRadioButton.Checked = False
            'Grupo Status
            StatusAltaCheckBox.Checked = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarPacienteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarPacienteToolStripButton.Click
        Try
            PacientesBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarPacienteToolStripButton, PacientesBindingNavigatorSaveItem, CancelarPacienteToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub StatusAltaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusAltaCheckBox.CheckedChanged
        Try
            If StatusAltaCheckBox.Checked = True Then
                StatusAltaTipoComboBox.Enabled = True
            Else
                StatusAltaTipoComboBox.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class
