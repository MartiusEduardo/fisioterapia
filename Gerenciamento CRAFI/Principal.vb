Imports System.Windows.Forms

Public Class form_principal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles UsuarioNovoToolStripMenuItem.Click
        Try
            Dim usuario As New form_incluir_usuario
            usuario.TopLevel = False
            usuario.MdiParent = Me
            usuario.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub IncluirPacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteIncluirToolStripMenuItem.Click
        Try
            Dim pacientes As New form_incluir_pacientes
            pacientes.TopLevel = False
            pacientes.MdiParent = Me
            pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditarPacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteEditarToolStripMenuItem.Click
        Try
            form_editar_pacientes.TopLevel = False
            form_editar_pacientes.MdiParent = Me
            form_editar_pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirPacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteExcluirToolStripMenuItem.Click
        Try
            form_excluir_pacientes.TopLevel = False
            form_excluir_pacientes.MdiParent = Me
            form_excluir_pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AnamneseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnamneseToolStripMenuItem.Click
        Try
            form_anamnese_dos_pacientes.TopLevel = False
            form_anamnese_dos_pacientes.MdiParent = Me
            form_anamnese_dos_pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirConvenioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvenioIncluirToolStripMenuItem.Click
        Try
            Dim convenio As New form_convenio
            convenio.TopLevel = False
            convenio.MdiParent = Me
            convenio.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditarConvenioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvenioEditarToolStripMenuItem.Click
        Try
            form_editar_convenios.TopLevel = False
            form_editar_convenios.MdiParent = Me
            form_editar_convenios.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirConvenioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvenioExcluirToolStripMenuItem.Click
        Try
            form_excluir_convenios.TopLevel = False
            form_excluir_convenios.MdiParent = Me
            form_excluir_convenios.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirProfissionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionalIncluirToolStripMenuItem.Click
        Try
            Dim profissional As New form_incluir_profissional
            profissional.TopLevel = False
            profissional.MdiParent = Me
            profissional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditarProfissionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionalEditarToolStripMenuItem.Click
        Try
            form_editar_profissionais.TopLevel = False
            form_editar_profissionais.MdiParent = Me
            form_editar_profissionais.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirProfissionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionalExcluirToolStripMenuItem.Click
        Try
            form_excluir_profissional.TopLevel = False
            form_excluir_profissional.MdiParent = Me
            form_excluir_profissional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Try
            form_opcoes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub IncluirServicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosIncluirToolStripMenuItem.Click
        Try
            Dim servicos As New form_incluir_servicos
            servicos.TopLevel = False
            servicos.MdiParent = Me
            servicos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditarServicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosEditarToolStripMenuItem.Click
        Try
            form_editar_servicos.TopLevel = False
            form_editar_servicos.MdiParent = Me
            form_editar_servicos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirServicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicosExcluirToolStripMenuItem.Click
        Try
            form_excluir_servicos.TopLevel = False
            form_excluir_servicos.MdiParent = Me
            form_excluir_servicos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            form_login.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub LogDeEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosLogEntradaToolStripMenuItem.Click
        Try
            form_relatorio_login_entrada.TopLevel = False
            form_relatorio_login_entrada.MdiParent = Me
            form_relatorio_login_entrada.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ConsultasDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasDiaToolStripMenuItem.Click
        Try
            form_relatorio_consultas_dia.TopLevel = False
            form_relatorio_consultas_dia.MdiParent = Me
            form_relatorio_consultas_dia.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ConsultasMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasMesToolStripMenuItem.Click
        Try
            form_relatorio_consultas_mes.TopLevel = False
            form_relatorio_consultas_mes.MdiParent = Me
            form_relatorio_consultas_mes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PacientesDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesDiaToolStripMenuItem.Click
        Try
            Dim dia As String = Format(Today, "-MM-dd")
            My.Settings.Aniversario = dia
            My.Settings.Save()
            form_aniversariantes.TopLevel = False
            form_aniversariantes.MdiParent = Me
            form_aniversariantes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioEditarToolStripMenuItem.Click
        Try
            form_editar_usuarios.TopLevel = False
            form_editar_usuarios.MdiParent = Me
            form_editar_usuarios.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ExcluirUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioExcluirToolStripMenuItem.Click
        Try
            form_excluir_usuario.TopLevel = False
            form_excluir_usuario.MdiParent = Me
            form_excluir_usuario.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub MudarSenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MudarSenhaToolStripMenuItem.Click
        Try
            form_mudar_senha.TopLevel = False
            form_mudar_senha.MdiParent = Me
            form_mudar_senha.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoffToolStripMenuItem.Click
        Try
            If MsgBox("Tem certeza que deseja fazer log off?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim i, num As Integer
                num = Me.MdiChildren.Count
                For i = 0 To num - 1
                    Me.MdiChildren.ElementAt(0).Close()
                Next
                ToolStripStatusLabel.Text = "Não logado"
                TipoToolStripStatusLabel.Text = "Tipo"
                ServidorToolStripStatusLabel.Text = "Servidor"
                UsuarioServidorToolStripStatusLabel.Text = "Usuário (Servidor)"
                habilitarMenu()
                form_login.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIDiaTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIDiaTextoToolStripMenuItem.Click
        Try
            Dim dia As String = Format(Today, "-MM-dd")
            My.Settings.ConsultaData = dia
            My.Settings.Save()
            form_relatorio_ISACLI.TopLevel = False
            form_relatorio_ISACLI.MdiParent = Me
            form_relatorio_ISACLI.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIMesTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIMesTextoToolStripMenuItem.Click
        Try
            Dim mes As String = Format(Today, "-MM-")
            My.Settings.ConsultaData = mes
            My.Settings.Save()
            form_relatorio_ISACLI.TopLevel = False
            form_relatorio_ISACLI.MdiParent = Me
            form_relatorio_ISACLI.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIAnoTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIAnoTextoToolStripMenuItem.Click
        Try
            Dim ano As String = Format(Today, "yyyy-")
            My.Settings.ConsultaData = ano
            My.Settings.Save()
            form_relatorio_ISACLI.TopLevel = False
            form_relatorio_ISACLI.MdiParent = Me
            form_relatorio_ISACLI.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIDiaGraficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIDiaGraficoToolStripMenuItem.Click
        Try
            My.Settings.ConsultaDataGrafico = Format(Today, "-MM-dd")
            My.Settings.Save()
            form_relatorio_ISACLI_grafico.TopLevel = False
            form_relatorio_ISACLI_grafico.MdiParent = Me
            form_relatorio_ISACLI_grafico.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIMesGraficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIMesGraficoToolStripMenuItem.Click
        Try
            My.Settings.ConsultaDataGrafico = Format(Today, "-MM-")
            My.Settings.Save()
            form_relatorio_ISACLI_grafico.TopLevel = False
            form_relatorio_ISACLI_grafico.MdiParent = Me
            form_relatorio_ISACLI_grafico.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ISACLIAnoGraficoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISACLIAnoGraficoToolStripMenuItem.Click
        Try
            My.Settings.ConsultaDataGrafico = Format(Today, "yyyy-")
            My.Settings.Save()
            form_relatorio_ISACLI_grafico.TopLevel = False
            form_relatorio_ISACLI_grafico.MdiParent = Me
            form_relatorio_ISACLI_grafico.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ProfissionalDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissionalDiaToolStripMenuItem.Click
        Try
            My.Settings.AniversarioProfissional = Format(Today, "-MM-dd")
            My.Settings.Save()
            form_relatorio_aniversario_profissional.TopLevel = False
            form_relatorio_aniversario_profissional.MdiParent = Me
            form_relatorio_aniversario_profissional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            form_sobre.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub LogDeControleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosLogControleToolStripMenuItem.Click
        Try
            form_relatorio_log_controle.TopLevel = False
            form_relatorio_log_controle.MdiParent = Me
            form_relatorio_log_controle.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ReceitaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasReceitaToolStripMenuItem.Click
        Try
            form_receitas.TopLevel = False
            form_receitas.MdiParent = Me
            form_receitas.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ImpostosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasImpostosToolStripMenuItem.Click
        Try
            form_impostos_sobre_receita.TopLevel = False
            form_impostos_sobre_receita.MdiParent = Me
            form_impostos_sobre_receita.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CustoFixoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasCustoFixoToolStripMenuItem.Click
        Try
            form_custo_fixo.TopLevel = False
            form_custo_fixo.MdiParent = Me
            form_custo_fixo.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub CustoVariavelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasCustoVariavelToolStripMenuItem.Click
        Try
            form_custo_variavel.TopLevel = False
            form_custo_variavel.MdiParent = Me
            form_custo_variavel.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DespesaVariavelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasDespesaVariavelToolStripMenuItem.Click
        Try
            form_despesa_variavel.TopLevel = False
            form_despesa_variavel.MdiParent = Me
            form_despesa_variavel.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasDREToolStripMenuItem.Click
        Try
            form_dre.TopLevel = False
            form_dre.MdiParent = Me
            form_dre.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DespesaFixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancasDespesaFixaToolStripMenuItem.Click
        Try
            form_despesa_fixa.TopLevel = False
            form_despesa_fixa.MdiParent = Me
            form_despesa_fixa.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DRERelatorioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatoriosDREToolStripMenuItem.Click
        Try
            form_relatorio_demonstracao_do_resultado_do_exercicio.TopLevel = False
            form_relatorio_demonstracao_do_resultado_do_exercicio.MdiParent = Me
            form_relatorio_demonstracao_do_resultado_do_exercicio.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaAgendaToolStripMenuItem.Click
        Try
            form_agenda.TopLevel = False
            form_agenda.MdiParent = Me
            form_agenda.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub EvoluçãoClínicaDosPacientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECEvolucaoClinicaPacientesToolStripMenuItem.Click
        Try
            form_evolucao_clinica_pacientes.TopLevel = False
            form_evolucao_clinica_pacientes.MdiParent = Me
            form_evolucao_clinica_pacientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub PesquisarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECPesquisarToolStripMenuItem.Click
        Try
            form_pesquisar_evolucao_clinica.TopLevel = False
            form_pesquisar_evolucao_clinica.MdiParent = Me
            form_pesquisar_evolucao_clinica.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ContatoIncluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoIncluirToolStripMenuItem.Click
        Try
            Dim incluirContato As New form_ie_contatos
            incluirContato.TopLevel = False
            incluirContato.MdiParent = Me
            incluirContato.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ContatoEditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoEditarToolStripMenuItem.Click
        Try
            form_editar_contatos.TopLevel = False
            form_editar_contatos.MdiParent = Me
            form_editar_contatos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub ContatoExcluirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContatoExcluirToolStripMenuItem.Click
        Try
            form_excluir_contatos.TopLevel = False
            form_excluir_contatos.MdiParent = Me
            form_excluir_contatos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    'ANIVERSÁRIOS (MÊS)

    Private Sub abrirFormAniverMes(ByVal data As Date, ByVal paciente As Boolean)
        Try
            If paciente Then
                My.Settings.Aniversario = Format(data, "-MM-")
                My.Settings.Save()
                form_aniversariantes.TopLevel = False
                form_aniversariantes.MdiParent = Me
                form_aniversariantes.Show()
            Else
                My.Settings.AniversarioProfissional = Format(data, "-MM-")
                My.Settings.Save()
                form_relatorio_aniversario_profissional.TopLevel = False
                form_relatorio_aniversario_profissional.MdiParent = Me
                form_relatorio_aniversario_profissional.Show()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    'ANIVERSÁRIO PACIENTE
    Private Sub JaneiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JaneiroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("01/01/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub FevereiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FevereiroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("02/02/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub MarçoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarçoToolStripMenuItem.Click
        Try
            abrirFormAniverMes("03/03/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AbrilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrilToolStripMenuItem.Click
        Try
            abrirFormAniverMes("04/04/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub MaioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaioToolStripMenuItem.Click
        Try
            abrirFormAniverMes("05/05/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub JunhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JunhoToolStripMenuItem.Click
        Try
            abrirFormAniverMes("06/06/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub JulhoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JulhoToolStripMenuItem.Click
        Try
            abrirFormAniverMes("07/07/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub AgostoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgostoToolStripMenuItem.Click
        Try
            abrirFormAniverMes("08/08/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub SetembroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetembroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("09/09/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub OutubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutubroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("10/10/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub NovembroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovembroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("11/11/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DezembroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DezembroToolStripMenuItem.Click
        Try
            abrirFormAniverMes("12/12/2000", True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    'ANIVERSÁRIO PROFISSIONAL

    Private Sub JaneiroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JaneiroToolStripMenuItem1.Click
        abrirFormAniverMes("01/01/2000", False)
    End Sub

    Private Sub FevereiroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FevereiroToolStripMenuItem1.Click
        abrirFormAniverMes("02/02/2000", False)
    End Sub

    Private Sub MarçoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarçoToolStripMenuItem1.Click
        abrirFormAniverMes("03/03/2000", False)
    End Sub

    Private Sub AbrilToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrilToolStripMenuItem1.Click
        abrirFormAniverMes("04/04/2000", False)
    End Sub

    Private Sub MaioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaioToolStripMenuItem1.Click
        abrirFormAniverMes("05/05/2000", False)
    End Sub

    Private Sub JunhoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JunhoToolStripMenuItem1.Click
        abrirFormAniverMes("06/06/2000", False)
    End Sub

    Private Sub JulhoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JulhoToolStripMenuItem1.Click
        abrirFormAniverMes("07/07/2000", False)
    End Sub

    Private Sub AgostoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgostoToolStripMenuItem1.Click
        abrirFormAniverMes("08/08/2000", False)
    End Sub

    Private Sub SetembroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetembroToolStripMenuItem1.Click
        abrirFormAniverMes("09/09/2000", False)
    End Sub

    Private Sub OutubroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutubroToolStripMenuItem1.Click
        abrirFormAniverMes("10/10/2000", False)
    End Sub

    Private Sub NovembroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovembroToolStripMenuItem1.Click
        abrirFormAniverMes("11/11/2000", False)
    End Sub

    Private Sub DezembroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DezembroToolStripMenuItem1.Click
        abrirFormAniverMes("12/12/2000", False)
    End Sub
End Class
