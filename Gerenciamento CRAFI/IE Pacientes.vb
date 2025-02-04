Public Class form_incluir_pacientes

    Dim tipoForm As Integer

    Private Sub PacientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PacientesBindingSource.EndEdit()
            PacientesTableAdapter.Update(Me.Gerenciamento_CRAFIDataSet.Pacientes)
            Select Case tipoForm
                Case 0
                    desabilitarObjetos(Me, AdicionarPacienteToolStripButton, PacientesBindingNavigatorSaveItem, CancelarPacienteToolStripButton, True, False, False)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou um novo paciente", DateTime.Now)
                Case 1
                    MsgBox("Paciente foi salvo com sucesso!", MsgBoxStyle.OkOnly)
                    Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou paciente", DateTime.Now)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub form_incluir_pacientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_pacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            PacientesTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Pacientes"
                    Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
                Case 1
                    Me.Text = "Editar Paciente"
                    AdicionarPacienteToolStripButton.Visible = False
                    CancelarPacienteToolStripButton.Visible = False
                    ImprimirPacientesToolStripButton.Visible = True
                    habilitarObjetos(Me, AdicionarPacienteToolStripButton, PacientesBindingNavigatorSaveItem, CancelarPacienteToolStripButton, False, True, False)
                    Dim codigoPaciente As String
                    codigoPaciente = form_editar_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
                    Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
                    Me.PacientesTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.PacientesTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM Pacientes WHERE (CodigoPaciente = '" & codigoPaciente & "')"
                    Me.PacientesTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Pacientes)
            End Select
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

    Private Sub ImprimirPacientesToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirPacientesToolStripButton.Click
        Try
            form_imprimir_paciente.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class
