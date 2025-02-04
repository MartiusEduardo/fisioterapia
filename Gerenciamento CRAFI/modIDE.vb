Imports System.Windows
Module modIDE

    Public Sub habilitarObjetos(ByVal form As Form, _
                                ByVal adicionar As ToolStripButton, _
                                ByVal salvar As ToolStripButton, _
                                ByVal cancelar As ToolStripButton, _
                                ByVal habilitaAdicionar As Boolean, _
                                ByVal habilitaSalvar As Boolean, _
                                ByVal habilitaCancelar As Boolean)
        Dim clt As Control
        For Each clt In form.Controls
            If clt.Tag <> "N" Then
                If Not TypeOf clt Is BindingNavigator Then
                    clt.Enabled = True
                Else
                    adicionar.Enabled = habilitaAdicionar
                    salvar.Enabled = habilitaSalvar
                    cancelar.Enabled = habilitaCancelar
                End If
            End If
        Next
    End Sub

    Public Sub desabilitarObjetos(ByVal form As Form, _
                                  ByVal adicionar As ToolStripButton, _
                                  ByVal salvar As ToolStripButton, _
                                  ByVal cancelar As ToolStripButton, _
                                  ByVal habilitaAdicionar As Boolean, _
                                  ByVal habilitaSalvar As Boolean, _
                                  ByVal habilitaCancelar As Boolean)
        Dim clt As Control
        For Each clt In form.Controls
            If Not TypeOf clt Is BindingNavigator Then
                clt.Enabled = False
            Else
                adicionar.Enabled = habilitaAdicionar
                salvar.Enabled = habilitaSalvar
                cancelar.Enabled = habilitaCancelar
            End If
        Next
    End Sub

    Public Function getTipoForm()
        Return My.Settings.tipoForm
    End Function

    Public Sub setTipoForm(ByVal tipoForm As Integer)
        My.Settings.tipoForm = tipoForm
        My.Settings.Save()
    End Sub

    Public Sub menuUsuario(ByVal listaFuncoes As Gerenciamento_CRAFIDataSet.pegarFuncoesLoginDataTable)
        Try
            'Dim i As Integer = 0
            'While i <= 31
            '    For Each ms As ToolStripMenuItem In form_principal.MenuStrip.Items()
            '        If ms.Name = "FileMenu" Then
            '            ms.DropDownItems.RemoveAt(3)
            '            ms.DropDownItems.RemoveAt(4)
            '            ms.DropDownItems.RemoveAt(5)
            '        End If
            '        If ms.Name = "AnamneseToolStripMenuItem" Then
            '            Dim numString As Integer = Len(listaFuncoes.Columns(i).ColumnName)
            '            Dim subString As String = ms.Name.Substring(0, numString)
            '            If subString = listaFuncoes.Columns(i).ColumnName Then
            '                If listaFuncoes.Rows(0).Item(subString) = False Then
            '                    ms.Enabled = False
            '                End If
            '                i += 1
            '            End If
            '        End If
            '        For Each tsmi As ToolStripMenuItem In ms.DropDownItems
            '            If i <= 31 Then
            '                Dim numString As Integer = Len(listaFuncoes.Columns(i).ColumnName)
            '                Dim subString As String = tsmi.Name.Substring(0, numString)
            '                If subString = listaFuncoes.Columns(i).ColumnName Then
            '                    If listaFuncoes.Rows(0).Item(subString) = False Then
            '                        tsmi.Enabled = False
            '                    End If
            '                    i += 1
            '                End If
            '            End If
            '        Next
            '    Next
            'End While
            'USUÁRIO
            If listaFuncoes.Item(0).UsuarioNovo = False Then
                form_principal.UsuarioNovoToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).UsuarioEditar = False Then
                form_principal.UsuarioEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).UsuarioExcluir = False Then
                form_principal.UsuarioExcluirToolStripMenuItem.Enabled = False
            End If
            'SERVIÇOS
            If listaFuncoes.Item(0).ServicosIncluir = False Then
                form_principal.ServicosIncluirToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ServicosEditar = False Then
                form_principal.ServicosEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ServicosExcluir = False Then
                form_principal.ServicosExcluirToolStripMenuItem.Enabled = False
            End If
            'CONVÊNIO
            If listaFuncoes.Item(0).ConvenioIncluir = False Then
                form_principal.ConvenioIncluirToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ConvenioEditar = False Then
                form_principal.ConvenioEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ConvenioExcluir = False Then
                form_principal.ConvenioExcluirToolStripMenuItem.Enabled = False
            End If
            'PROFISSIONAL
            If listaFuncoes.Item(0).ProfissionalIncluir = False Then
                form_principal.ProfissionalIncluirToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ProfissionalEditar = False Then
                form_principal.ProfissionalEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ProfissionalExcluir = False Then
                form_principal.ProfissionalExcluirToolStripMenuItem.Enabled = False
            End If
            'PACIENTE
            If listaFuncoes.Item(0).PacienteIncluir = False Then
                form_principal.PacienteIncluirToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).PacienteEditar = False Then
                form_principal.PacienteEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).PacienteExcluir = False Then
                form_principal.PacienteExcluirToolStripMenuItem.Enabled = False
            End If
            'CONSULTA
            If listaFuncoes.Item(0).ConsultaAgenda = False Then
                form_principal.ConsultaAgendaToolStripMenuItem.Enabled = False
            End If
            'ANAMNESE
            If listaFuncoes.Item(0).Anamnese = False Then
                form_principal.AnamneseToolStripMenuItem.Enabled = False
            End If
            'EVOLUÇÃO CLÍNICA
            If listaFuncoes.Item(0).ECEvolucaoClinicaPacientes = False Then
                form_principal.ECEvolucaoClinicaPacientesToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ECPesquisar = False Then
                form_principal.ECPesquisarToolStripMenuItem.Enabled = False
            End If
            'FINANÇAS
            If listaFuncoes.Item(0).FinancasReceita = False Then
                form_principal.FinancasReceitaToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasImpostos = False Then
                form_principal.FinancasImpostosToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasCustoFixo = False Then
                form_principal.FinancasCustoFixoToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasCustoVariavel = False Then
                form_principal.FinancasCustoVariavelToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasDespesaFixa = False Then
                form_principal.FinancasDespesaFixaToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasDespesaVariavel = False Then
                form_principal.FinancasDespesaVariavelToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).FinancasDRE = False Then
                form_principal.FinancasDREToolStripMenuItem.Enabled = False
            End If
            'RELATÓRIOS
            If listaFuncoes.Item(0).RelatoriosAniversariantes = False Then
                form_principal.RelatoriosAniversariantesToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).RelatoriosConsultas = False Then
                form_principal.RelatoriosConsultasToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).RelatoriosDRE = False Then
                form_principal.RelatoriosDREToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).RelatoriosISACLI = False Then
                form_principal.RelatoriosISACLIToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).RelatoriosLogEntrada = False Then
                form_principal.RelatoriosLogEntradaToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).RelatoriosLogControle = False Then
                form_principal.RelatoriosLogControleToolStripMenuItem.Enabled = False
            End If
            'CONTATOS
            If listaFuncoes.Item(0).ContatoIncluir = False Then
                form_principal.ContatoIncluirToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ContatoEditar = False Then
                form_principal.ContatoEditarToolStripMenuItem.Enabled = False
            End If
            If listaFuncoes.Item(0).ContatoExcluir = False Then
                form_principal.ContatoExcluirToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Public Sub habilitarMenu()
        For Each ms As ToolStripMenuItem In form_principal.MenuStrip.Items()
            ms.Enabled = True
            If ((Not ms.Name = "FileMenu") And (Not ms.Name = "WindowsMenu")) Then
                For Each tsmi As ToolStripMenuItem In ms.DropDownItems
                    tsmi.Enabled = True
                Next
            End If
        Next
        form_principal.UsuarioNovoToolStripMenuItem.Enabled = True
        form_principal.UsuarioEditarToolStripMenuItem.Enabled = True
        form_principal.UsuarioExcluirToolStripMenuItem.Enabled = True
    End Sub

End Module
