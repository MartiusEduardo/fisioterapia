Public Class form_passaporte

    Private Sub form_passaporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wbPassaporte.Navigate("www.gruporyr.com.br")
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Close()
    End Sub
End Class