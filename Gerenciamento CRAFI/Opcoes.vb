Public Class form_opcoes

    Private Sub form_opcoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            rdo_servidor1.Checked = My.Settings.rdo_Servidor1
            rdo_servidor2.Checked = My.Settings.rdo_Servidor2
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        Try
            My.Settings.rdo_Servidor1 = rdo_servidor1.Checked
            My.Settings.rdo_Servidor2 = rdo_servidor2.Checked
            My.Settings.Save()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class