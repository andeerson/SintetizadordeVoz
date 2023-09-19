Public Class FormRestrito

    Private Sub btsair_Click(sender As Object, e As EventArgs) Handles btsair.Click
        Me.Close()

    End Sub

    Private Sub FormRestrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblData.Text = DateTime.Now
        lblFim.Text = My.Settings.Serials30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblData.Text = DateTime.Now

    End Sub
End Class