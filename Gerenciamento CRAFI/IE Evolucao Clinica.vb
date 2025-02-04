Imports System.Windows
Public Class form_incluir_evolucao_clinica

    Dim tipoForm As Integer

    Private Sub EvolucaoClinicaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvolucaoClinicaBindingNavigatorSaveItem.Click
        Try
            If QueixaPrincipalTextBox.TextLength >= 10 And HistoriaDoencaAtualTextBox.TextLength >= 10 And TratamentoTextBox.TextLength >= 10 Then
                LoginTableAdapter.Adapter.SelectCommand.Connection.Open()
                LoginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                LoginTableAdapter.Adapter.SelectCommand.CommandText = "Select Assinatura From Login Where Usuario = '" & form_principal.ToolStripStatusLabel.Text & "'"
                Select Case tipoForm
                    Case 0
                        AssinaturaTextBox.Text = LoginTableAdapter.Adapter.SelectCommand.ExecuteScalar()
                        Me.Validate()
                        Me.EvolucaoClinicaBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
                        desabilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, True, False, False)
                        Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "adicionou uma nova evolução clínica", DateTime.Now)
                    Case 1
                        Dim assinatura As String
                        assinatura = LoginTableAdapter.Adapter.SelectCommand.ExecuteScalar()
                        If AssinaturaTextBox.Text = assinatura Or form_principal.TipoToolStripStatusLabel.Text = "Administrador 1" Then
                            Me.Validate()
                            Me.EvolucaoClinicaBindingSource.EndEdit()
                            Me.TableAdapterManager.UpdateAll(Me.Gerenciamento_CRAFIDataSet)
                            MsgBox("Evolução Clínica salva com sucesso!", MsgBoxStyle.OkOnly)
                            Me.LogControleTableAdapter.Insert(form_principal.ToolStripStatusLabel.Text, "editou evolução clínica", DateTime.Now)
                        Else
                            MsgBox("Você não tem permissão para modificar esta evolução clínica.", MsgBoxStyle.OkOnly)
                        End If
                End Select
                LoginTableAdapter.Adapter.SelectCommand.Connection.Close()
            Else
                MsgBox("É necessário inserir mais de 10 caracteres em: Queixa Principal; História da Doença Atual e Tratamento.", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            Try
                LoginTableAdapter.Adapter.SelectCommand.Connection.Close()
            Catch ex2 As Exception
                MsgBox("O programa tentou fechar a conexão da tabela Login, mas não conseguiu. Esse erro ocorreu porque a conexão já está fechada." & vbNewLine * "Se o erro persistir, por favor, é só reiniciar o programa.", MsgBoxStyle.OkOnly)
            End Try
        End Try

    End Sub

    Private Sub form_incluir_evolucao_clinica_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        setTipoForm(0)
    End Sub

    Private Sub form_incluir_evolucao_clinica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            EvolucaoClinicaTableAdapter.Connection.ConnectionString = conexao.strConexao
            LogControleTableAdapter.Connection.ConnectionString = conexao.strConexao
            ProfissionaisTableAdapter.Connection.ConnectionString = conexao.strConexao
            '-----------------------------------------------------------------------------------------------------------------------------
            tipoForm = getTipoForm()
            Select Case tipoForm
                Case 0
                    Me.Text = "Incluir Evolução Clínica"
                    Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
                    Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
                    desabilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, True, False, False)
                    AdicionarECToolStripButton.Visible = True
                    CancelarECToolStripButton.Visible = True
                    ImprimirEvolucaoClinicaToolStripButton.Visible = False
                Case 1
                    Me.Text = "Editar Evolução Clínica"
                    AdicionarECToolStripButton.Visible = False
                    CancelarECToolStripButton.Visible = False
                    ImprimirEvolucaoClinicaToolStripButton.Visible = True
                    habilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, False, True, False)
                    Me.ProfissionaisTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Profissionais)
                    Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
                    Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text
                    Me.EvolucaoClinicaTableAdapter.Adapter.SelectCommand.CommandText = "Select * FROM EvolucaoClinica WHERE (codigoEvolucaoClinica = '" & form_editar_evolucoes_clinicas.EvolucaoClinicaDataGridView.CurrentRow.Cells(0).Value & "')"
                    Me.EvolucaoClinicaTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.EvolucaoClinica)
                    Me.LoginTableAdapter.Fill(Me.Gerenciamento_CRAFIDataSet.Login)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub AdicionarECToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdicionarECToolStripButton.Click
        Try
            EvolucaoClinicaBindingSource.AddNew()
            NumeroProntuarioTextBox.Text = form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(0).Value
            NomeTextBox.Text = form_evolucao_clinica_pacientes.PacientesDataGridView.CurrentRow.Cells(2).Value
            habilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, False, True, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CancelarECToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarECToolStripButton.Click
        Try
            EvolucaoClinicaBindingSource.CancelEdit()
            desabilitarObjetos(Me, AdicionarECToolStripButton, EvolucaoClinicaBindingNavigatorSaveItem, CancelarECToolStripButton, True, False, False)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImprimirEvolucaoClinicaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirEvolucaoClinicaToolStripButton.Click
        Try
            form_imprimir_evolucao_clinica.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class