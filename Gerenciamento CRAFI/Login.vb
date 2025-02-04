Public Class form_login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            '-----------------------------------------------------------------------------------------------------------------------------
            'CONEXÃO
            Dim conexao As New Conexao
            conexao.conexaoServidor(TableAdapterManager)
            '-----------------------------------------------------------------------------------------------------------------------------
            If UsernameTextBox.Text = "" Then
                MsgBox("É necessário inserir um usuário.", MsgBoxStyle.OkOnly)
            ElseIf PasswordTextBox.Text = "" Then
                MsgBox("É necessário inserir uma senha.", MsgBoxStyle.OkOnly)
            Else
                If QueriesTableAdapter.validarLogin(UsernameTextBox.Text, PasswordTextBox.Text) = True Then
                    form_principal.ToolStripStatusLabel.Text = UsernameTextBox.Text
                    form_principal.TipoToolStripStatusLabel.Text = LoginTableAdapter.ScalarQueryLoginTipo(UsernameTextBox.Text)
                    If My.Settings.rdo_Servidor1.Equals(True) Then
                        form_principal.ServidorToolStripStatusLabel.Text = My.Settings.NomeServidor1
                        form_principal.UsuarioServidorToolStripStatusLabel.Text = My.Settings.UsuarioServidor1
                    ElseIf My.Settings.rdo_Servidor2.Equals(True) Then
                        form_principal.ServidorToolStripStatusLabel.Text = My.Settings.NomeServidor2
                        form_principal.UsuarioServidorToolStripStatusLabel.Text = My.Settings.UsuarioServidor2
                    End If
                    Me.LogEntradaTableAdapter.Insert(UsernameTextBox.Text, DateTime.Now)
                    Dim listaFuncoes As Gerenciamento_CRAFIDataSet.pegarFuncoesLoginDataTable
                    listaFuncoes = PegarFuncoesLoginTableAdapter.GetData(UsernameTextBox.Text, PasswordTextBox.Text)
                    menuUsuario(listaFuncoes)
                    setTipoForm(0)
                    form_passaporte.ShowDialog()
                    Me.Close()
                Else
                    MsgBox("Usuário ou senha incorreta. Tente novamente.", MsgBoxStyle.OkOnly)
                End If
            End If
            Try
                TableAdapterManager.Connection.Close()
            Catch ex As Exception
                MsgBox("Não foi possível fechar a conexão." & vbCr & ex.Message, MsgBoxStyle.OkOnly)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub btn_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sair.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PasswordTextBox.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_configurar_servidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_configurar_servidor.Click
        Try
            form_opcoes.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class
