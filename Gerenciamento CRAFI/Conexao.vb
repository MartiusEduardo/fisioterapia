Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Conexao

    Dim myConnection As SqlConnection

    Public Sub conexaoServidor(ByVal tbAdapterManager As Gerenciamento_CRAFIDataSetTableAdapters.TableAdapterManager)

        If My.Settings.rdo_Servidor1 Then
            myConnection = New SqlConnection(My.Settings.GerenciamentoCRAFIConnectionString)
        ElseIf My.Settings.rdo_Servidor2 Then
            myConnection = New SqlConnection(My.Settings.Servidor2)
        End If

        tbAdapterManager.Connection = myConnection
        
        'ANAMNESE
        If Not IsNothing(tbAdapterManager.AnamneseTableAdapter) Then
            tbAdapterManager.AnamneseTableAdapter.Connection = myConnection
        End If
        'CIRURGIAS
        If Not IsNothing(tbAdapterManager.CirurgiasTableAdapter) Then
            tbAdapterManager.CirurgiasTableAdapter.Connection = myConnection
        End If
        'CONSULTAS
        If Not IsNothing(tbAdapterManager.ConsultasTableAdapter) Then
            tbAdapterManager.ConsultasTableAdapter.Connection = myConnection
        End If
        'CONVÊNIOS
        If Not IsNothing(tbAdapterManager.ConveniosTableAdapter) Then
            tbAdapterManager.ConveniosTableAdapter.Connection = myConnection
        End If
        'CUSTO FIXO
        If Not IsNothing(tbAdapterManager.CustoFixoTableAdapter) Then
            tbAdapterManager.CustoFixoTableAdapter.Connection = myConnection
        End If
        'CUSTO VARIÁVEL
        If Not IsNothing(tbAdapterManager.CustoVariavelTableAdapter) Then
            tbAdapterManager.CustoVariavelTableAdapter.Connection = myConnection
        End If
        'DESPESA FIXA
        If Not IsNothing(tbAdapterManager.DespesaFixaTableAdapter) Then
            tbAdapterManager.DespesaFixaTableAdapter.Connection = myConnection
        End If
        'DESPESA VARIÁVEL
        If Not IsNothing(tbAdapterManager.DespesaVariavelTableAdapter) Then
            tbAdapterManager.DespesaVariavelTableAdapter.Connection = myConnection
        End If
        'EVOLUÇÃO CLÍNICA
        If Not IsNothing(tbAdapterManager.EvolucaoClinicaTableAdapter) Then
            tbAdapterManager.EvolucaoClinicaTableAdapter.Connection = myConnection
        End If
        'EXAMES COMPLEMENTARES
        If Not IsNothing(tbAdapterManager.ExamesComplementaresTableAdapter) Then
            tbAdapterManager.ExamesComplementaresTableAdapter.Connection = myConnection
        End If
        'IMPOSTOS SOBRE VENDAS
        If Not IsNothing(tbAdapterManager.ImpostosSobreVendasTableAdapter) Then
            tbAdapterManager.ImpostosSobreVendasTableAdapter.Connection = myConnection
        End If
        'LOG CONTROLE
        If Not IsNothing(tbAdapterManager.LogControleTableAdapter) Then
            tbAdapterManager.LogControleTableAdapter.Connection = myConnection
        End If
        'LOG ENTRADA
        If Not IsNothing(tbAdapterManager.LogEntradaTableAdapter) Then
            tbAdapterManager.LogEntradaTableAdapter.Connection = myConnection
        End If
        'LOGIN
        If Not IsNothing(tbAdapterManager.LoginTableAdapter) Then
            tbAdapterManager.LoginTableAdapter.Connection = myConnection
        End If
        'PACIENTES
        If Not IsNothing(tbAdapterManager.PacientesTableAdapter) Then
            tbAdapterManager.PacientesTableAdapter.Connection = myConnection
        End If
        'PROFISSIONAIS
        If Not IsNothing(tbAdapterManager.ProfissionaisTableAdapter) Then
            tbAdapterManager.ProfissionaisTableAdapter.Connection = myConnection
        End If
        'RECEITA
        If Not IsNothing(tbAdapterManager.ReceitaTableAdapter) Then
            tbAdapterManager.ReceitaTableAdapter.Connection = myConnection
        End If
        'SERVIÇOS CONVÊNIOS
        If Not IsNothing(tbAdapterManager.ServicosConveniosTableAdapter) Then
            tbAdapterManager.ServicosConveniosTableAdapter.Connection = myConnection
        End If
        'SERVIÇOS
        If Not IsNothing(tbAdapterManager.ServicosTableAdapter) Then
            tbAdapterManager.ServicosTableAdapter.Connection = myConnection
        End If
        'CONTATOS
        If Not IsNothing(tbAdapterManager.ContatosTableAdapter) Then
            tbAdapterManager.ContatosTableAdapter.Connection = myConnection
        End If

        Try
            tbAdapterManager.Connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
            tbAdapterManager.Connection.Close()
        End Try

    End Sub

    Public Function strConexao() As String
        strConexao = ""
        If My.Settings.rdo_Servidor1 Then
            strConexao = My.Settings.GerenciamentoCRAFIConnectionString
        ElseIf My.Settings.rdo_Servidor2 Then
            strConexao = My.Settings.Servidor2
        End If
        Return strConexao
    End Function
End Class
