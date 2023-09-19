Imports System.Windows.Forms

Public Class DialogKey

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        If MaskedKey.Text = "0000-0000-0000-2310-1980" Then
            My.Settings.Registrado = True
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("O SoftWare foi registrado com exitô.", MsgBoxStyle.Information, "Sucesso!")
            My.Settings.Serials30 = DateTime.Now.AddDays(30)
            My.Settings.Save()
            My.Settings.Reload()
            '=====
            My.Settings.Registrado = False
            My.Settings.Save()
            My.Settings.Reload()

            Me.Close()

        Else
            MsgBox("O Serial informado é invalido.", MsgBoxStyle.Information, "Erro!")

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Form1.Close()

    End Sub

    Private Sub DialogKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
