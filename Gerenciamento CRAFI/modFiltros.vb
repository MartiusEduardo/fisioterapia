Module modFiltros

    Private strSQL As String

    Public Function filtroPacientes(Optional ByVal codigo As String = "", _
                                           Optional ByVal nome As String = "", _
                                           Optional ByVal cep As String = "", _
                                           Optional ByVal endereco As String = "", _
                                           Optional ByVal bairro As String = "", _
                                           Optional ByVal cidade As String = "", _
                                           Optional ByVal estado As String = "", _
                                           Optional ByVal pais As String = "", _
                                           Optional ByVal planoSaude As String = "", _
                                           Optional ByVal celular As String = "", _
                                           Optional ByVal telefone As String = "", _
                                           Optional ByVal registro As String = "",
                                           Optional ByVal telefoneResidencial As String = "") As String

        strSQL = "Select * FROM Pacientes WHERE 1 = 1 "
        If codigo <> "" Then
            strSQL += " AND (CodigoPaciente Like '%" & codigo & "%')"
        End If
        If nome <> "" Then
            strSQL += " AND (Nome Like '%" & nome & "%')"
        End If
        If cep <> "" Then
            strSQL += " AND (CEP Like '%" & cep & "%')"
        End If
        If endereco <> "" Then
            strSQL += " AND (Endereco Like '%" & endereco & "%')"
        End If
        If bairro <> "" Then
            strSQL += " AND (Bairro Like '%" & bairro & "%')"
        End If
        If cidade <> "" Then
            strSQL += " AND (Cidade Like '%" & cidade & "%')"
        End If
        If estado <> "" Then
            strSQL += " AND (Estado Like '%" & estado & "%')"
        End If
        If pais <> "" Then
            strSQL += " AND (Pais Like '%" & pais & "%')"
        End If
        If planoSaude <> "" Then
            strSQL += " AND (PlanosSaude Like '%" & planoSaude & "%')"
        End If
        If celular <> "" Then
            strSQL += " AND (Celular Like '%" & celular & "%')"
        End If
        If telefone <> "" Then
            strSQL += " AND (TelefoneComercial Like '%" & telefone & "%')"
        End If
        If telefoneResidencial <> "" Then
            strSQL += " AND (TelefoneResidencial Like '%" & telefoneResidencial & "%')"
        End If
        If registro = "Ativo" Then
            strSQL += " AND (RegistroAtivo = '1')"
        ElseIf registro = "Inativo" Then
            strSQL += " AND (RegistroInativo = '1')"
        End If

        Return strSQL
    End Function

    Public Function filtroProfissionais(Optional ByVal regOrgClasse As String = "", _
                                        Optional ByVal nome As String = "", _
                                        Optional ByVal dataNascimento As String = "", _
                                        Optional ByVal endereco As String = "", _
                                        Optional ByVal bairro As String = "", _
                                        Optional ByVal cidade As String = "", _
                                        Optional ByVal estado As String = "", _
                                        Optional ByVal pais As String = "", _
                                        Optional ByVal telefone As String = "", _
                                        Optional ByVal celular As String = "", _
                                        Optional ByVal registro As String = "") As String

        strSQL = "Select * FROM Profissionais WHERE 1 = 1 "
        If regOrgClasse <> "" Then
            strSQL += " AND (NumRegistroOrgaoClasse Like '%" & regOrgClasse & "%')"
        End If
        If nome <> "" Then
            strSQL += " AND (Nome Like '%" & nome & "%')"
        End If
        If dataNascimento <> "" Then
            strSQL += " AND (DataNascimento Like '%" & dataNascimento & "%')"
        End If
        If endereco <> "" Then
            strSQL += " AND (Endereco Like '%" & endereco & "%')"
        End If
        If bairro <> "" Then
            strSQL += " AND (Bairro Like '%" & bairro & "%')"
        End If
        If cidade <> "" Then
            strSQL += " AND (Cidade Like '%" & cidade & "%')"
        End If
        If estado <> "" Then
            strSQL += " AND (Estado Like '%" & estado & "%')"
        End If
        If pais <> "" Then
            strSQL += " AND (Pais Like '%" & pais & "%')"
        End If
        If telefone <> "" Then
            strSQL += " AND (Telefone Like '%" & telefone & "%')"
        End If
        If celular <> "" Then
            strSQL += " AND (Celular Like '%" & celular & "%')"
        End If
        If registro = "Ativo" Then
            strSQL += " AND (RegistroAtivo = '1')"
        ElseIf registro = "Inativo" Then
            strSQL += " AND (RegistroInativo = '1')"
        End If

        Return strSQL
    End Function

    Public Function filtroConvenios(Optional ByVal codigoConvenio As String = "", _
                                    Optional ByVal razaoSocial As String = "", _
                                    Optional ByVal cnpj As String = "", _
                                    Optional ByVal endereco As String = "", _
                                    Optional ByVal cidade As String = "", _
                                    Optional ByVal estado As String = "", _
                                    Optional ByVal telefone As String = "", _
                                    Optional ByVal inscricaoEstadual As String = "", _
                                    Optional ByVal cep As String = "", _
                                    Optional ByVal email As String = "", _
                                    Optional ByVal contato As String = "", _
                                    Optional ByVal telefoneContato As String = "", _
                                    Optional ByVal ramalContato As String = "") As String

        strSQL = "Select * FROM Convenios WHERE 1 = 1 "
        If codigoConvenio <> "" Then
            strSQL += " AND (CodigoConvenio Like '%" & codigoConvenio & "%')"
        End If
        If razaoSocial <> "" Then
            strSQL += " AND (RazaoSocial Like '%" & razaoSocial & "%')"
        End If
        If cnpj <> "" Then
            strSQL += " AND (CNPJ Like '%" & cnpj & "%')"
        End If
        If endereco <> "" Then
            strSQL += " AND (Endereco Like '%" & endereco & "%')"
        End If
        If inscricaoEstadual <> "" Then
            strSQL += " AND (InscricaoEstadual Like '%" & inscricaoEstadual & "%')"
        End If
        If cidade <> "" Then
            strSQL += " AND (Cidade Like '%" & cidade & "%')"
        End If
        If estado <> "" Then
            strSQL += " AND (Estado Like '%" & estado & "%')"
        End If
        If cep <> "" Then
            strSQL += " AND (CEP Like '%" & cep & "%')"
        End If
        If telefone <> "" Then
            strSQL += " AND (Telefone Like '%" & telefone & "%')"
        End If
        If email <> "" Then
            strSQL += " AND (Email Like '%" & email & "%')"
        End If
        If contato <> "" Then
            strSQL += " AND (Contato Like '%" & contato & "%')"
        End If
        If telefoneContato <> "" Then
            strSQL += " AND (TelefoneContato Like '%" & telefoneContato & "%')"
        End If
        If ramalContato <> "" Then
            strSQL += " AND (RamalContato Like '%" & ramalContato & "%')"
        End If

        Return strSQL
    End Function

    Public Function filtroServicos(Optional ByVal nome As String = "", _
                                   Optional ByVal profissionaisHabilitados As String = "", _
                                   Optional ByVal codigo As String = "", _
                                   Optional ByVal valorUnitario As String = "") As String

        strSQL = "Select * FROM Servicos WHERE 1 = 1 "
        If nome <> "" Then
            strSQL += " AND (CodigoConvenio Like '%" & nome & "%')"
        End If
        If profissionaisHabilitados <> "" Then
            strSQL += " AND (RazaoSocial Like '%" & profissionaisHabilitados & "%')"
        End If
        If codigo <> "" Then
            strSQL += " AND (CNPJ Like '%" & codigo & "%')"
        End If
        If valorUnitario <> "" Then
            strSQL += " AND (Endereco Like '%" & valorUnitario & "%')"
        End If

        Return strSQL

    End Function

    Public Function filtroEvolucaoClinica(Optional ByVal numeroProntuario As String = "", _
                                          Optional ByVal numeroRegProfissional As String = "", _
                                          Optional ByVal profissional As String = "", _
                                          Optional ByVal codigoPaciente As String = "", _
                                          Optional ByVal cpf As String = "", _
                                          Optional ByVal nome As String = "", _
                                          Optional ByVal data As String = "", _
                                          Optional ByVal queixaPrincipal As String = "", _
                                          Optional ByVal historiaDoencaAtual As String = "", _
                                          Optional ByVal exameFisico As String = "", _
                                          Optional ByVal cif As String = "", _
                                          Optional ByVal cid As String = "", _
                                          Optional ByVal tratamento As String = "", _
                                          Optional ByVal assinatura As String = "") As String

        strSQL = "Select * FROM EvolucaoClinica WHERE 1 = 1 "
        If numeroProntuario <> "" Then
            strSQL += " AND (NumeroProntuario Like '%" & numeroProntuario & "%')"
        End If
        If numeroRegProfissional <> "" Then
            strSQL += " AND (NumRegistroProfissional Like '%" & numeroRegProfissional & "%')"
        End If
        If profissional <> "" Then
            strSQL += " AND (Profissional Like '%" & profissional & "%')"
        End If
        If codigoPaciente <> "" Then
            strSQL += " AND (CodigoPaciente Like '%" & codigoPaciente & "%')"
        End If
        If cpf <> "" Then
            strSQL += " AND (CPF Like '%" & cpf & "%')"
        End If
        If nome <> "" Then
            strSQL += " AND (Nome Like '%" & nome & "%')"
        End If
        If data <> "" Then
            strSQL += " AND (Data Like '%" & data & "%')"
        End If
        If queixaPrincipal <> "" Then
            strSQL += " AND (QueixaPrincipal Like '%" & queixaPrincipal & "%')"
        End If
        If historiaDoencaAtual <> "" Then
            strSQL += " AND (HistoriaDoencaAtual Like '%" & historiaDoencaAtual & "%')"
        End If
        If exameFisico <> "" Then
            strSQL += " AND (ExameFisico Like '%" & exameFisico & "%')"
        End If
        If cif <> "" Then
            strSQL += " AND (CIF Like '%" & cif & "%')"
        End If
        If cid <> "" Then
            strSQL += " AND (CID Like '%" & cid & "%')"
        End If
        If tratamento <> "" Then
            strSQL += " AND (Tratamento Like '%" & tratamento & "%')"
        End If
        If assinatura <> "" Then
            strSQL += " AND (Assinatura Like '%" & assinatura & "%')"
        End If

        Return strSQL

    End Function

    Public Function filtroConsulta(Optional ByVal paciente As String = "", _
                                 Optional ByVal profissional As String = "", _
                                 Optional ByVal data As String = "", _
                                 Optional ByVal dataTermino As String = "")

        strSQL = "Select * From Consultas Where 1 = 1 "

        If paciente <> "" Then
            strSQL += " AND (Paciente Like '%" & paciente & "%')"
        End If
        If form_principal.TipoToolStripStatusLabel.Text <> "Administrador 1" And form_principal.TipoToolStripStatusLabel.Text <> "Administrador 2" Then
            strSQL += " AND (Profissional Like '%" & form_principal.ToolStripStatusLabel.Text & "%')"
        Else
            If profissional <> "" Then
                strSQL += " AND (Profissional Like '%" & profissional & "%')"
            End If
        End If
        If data <> "" Then
            strSQL += " AND (Data BETWEEN '" & data & "' AND DateAdd(DAY, 1, '" & data & "'))"
        End If
        If dataTermino <> "" Then
            strSQL += " AND (DataTermino BETWEEN '" & dataTermino & "' AND DATEADD(DAY, 1, '" & dataTermino & "'))"
        End If

        Return strSQL
    End Function
End Module
