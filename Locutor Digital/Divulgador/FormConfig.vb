Public Class FormConfig
    
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\alumino1.jpg")

            PictureBox1.Image = Vbitmap

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

   

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        'ao clicar no radioButton4 a imagem textura6 Brasil deve aparecer no pictureBox

        If RadioButton4.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura6.jpg")

            PictureBox1.Image = Vbitmap

        End If


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\ferruge.jpg")

            PictureBox1.Image = Vbitmap

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FormConfig_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub FormConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura5.jpg")

            PictureBox1.Image = Vbitmap

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\alumino2.jpg")

            PictureBox1.Image = Vbitmap

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Enabled = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura2.jpg")

            PictureBox1.Image = Vbitmap


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAdicionar.Click

        If RadioButton4.Checked = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura6.jpg")
            Form1.BackgroundImage = Vbitmap

        ElseIf RadioButton5.Checked = True Then

            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\ferruge.jpg")


            Form1.BackgroundImage = Vbitmap

        ElseIf RadioButton6.Checked = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura5.jpg")

            Form1.BackgroundImage = Vbitmap

        ElseIf RadioButton2.Checked = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\alumino1.jpg")

            Form1.BackgroundImage = Vbitmap

        ElseIf RadioButton3.Checked = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\alumino2.jpg")

            Form1.BackgroundImage = Vbitmap

        ElseIf RadioButton1.Checked = True Then
            Dim Vbitmap As New Bitmap("C:\Users\Anderson\Desktop\LocutorDigital\Locutor digital\Divulgador\Resources\textura2.jpg")

            Form1.BackgroundImage = Vbitmap

        End If




    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class