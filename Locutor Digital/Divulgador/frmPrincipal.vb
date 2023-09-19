Imports System.Speech.Synthesis

Public Class frmPrincipal

    'Chamada de API
    Private Declare Function GetKeyState Lib "user32.dll" Alias "GetKeyState" (ByVal nVirtKey As Long) As Integer

    Dim Speech As New SpeechSynthesizer

    Private StatusBar1 As StatusBar

    Private Panel1 As StatusBarPanel
    Private Panel2 As StatusBarPanel
    Private Panel3 As StatusBarPanel

    Private TempoEspera As Integer
    Private TempoEsperado As Integer

    Private Iniciado As Boolean

    Private playlist As WMPLib.IWMPPlaylist ' = Winplayer1.playlistCollection.newPlaylist("PlayList001")

    Private Sub SaveFile()
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objVoices As IReadOnlyCollection(Of InstalledVoice) = Speech.GetInstalledVoices(Globalization.CultureInfo.CurrentCulture)
        Dim ObjVoiceInformation As VoiceInfo = objVoices(0).VoiceInfo
        For Each tmpVoice As InstalledVoice In objVoices
            ObjVoiceInformation = tmpVoice.VoiceInfo
            cboLocutor.Items.Add(ObjVoiceInformation.Name.ToString)
        Next

        playlist = Winplayer1.playlistCollection.newPlaylist("PlayList001")
        Winplayer1.currentPlaylist = playlist

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If cboLocutor.SelectedIndex > -1 Then

            Timer2.Enabled = False

            Speech.SelectVoice(cboLocutor.Text)

            'velocidade da voz
            Speech.Rate = TrackBarVelocidade.Value
            'volume da voz
            Speech.Volume = TrackBarVolume.Value

            Speech.SpeakAsync(txtDivulgacao.Text)
            TempoEsperado = 1
            Timer1.Enabled = True
            Iniciado = True

            'Winplayer1.Ctlcontrols.GetType.get


        Else
            Iniciado = False
            MsgBox("É preciso escolher uma voz de locutor na aba Texto", MsgBoxStyle.Critical, "Aviso ao usuário")

        End If
        
    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        Iniciado = False
        Timer1.Enabled = False
        Timer2.Enabled = False

        Speech.SpeakAsyncCancelAll()
        
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '---------------------------Aqui verifico se o  texto ja foi falado " speak" 

        Dim Estado As Boolean = Speech.State = SynthesizerState.Speaking

        If Estado Then

        Else
            'Se cair aqui é porque ele parou de falar e precisa esperar o tempo necessário para voltar a falar
            'Quando parar de falar, precisa esperar o tempo necessário para poder falar novamente.

            If Not chkRepetir.Checked Then
                TempoEsperado = 0
            End If

            If TempoEsperado = 0 Then
                TempoEsperado = 1
                Timer1.Enabled = False
                If TempoEspera < 1 Then
                    'TempoEspera = 100
                    Timer2.Interval = 100
                Else
                    Timer2.Interval = TempoEspera * 65000
                End If
                Timer2.Enabled = True
            Else
                Speech.SpeakAsync(txtDivulgacao.Text)
                TempoEsperado = 0
            End If
            'Speech.SpeakAsync(txtDivulgacao.Text)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TempoEsperado = 1
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub btnAdicionaMusica_Click(sender As Object, e As EventArgs) Handles btnAdicionaMusica.Click
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            BindingSource1.Add(OpenFileDialog1.FileName)
            playlist.appendItem(Winplayer1.newMedia(OpenFileDialog1.FileName))

            If playlist.count < 1 Then
                Winplayer1.currentPlaylist = playlist
            End If
        End If
        
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'BindingSource1.Add(OpenFileDialog1.FileName)
        'playlist.appendItem(Winplayer1.newMedia(OpenFileDialog1.FileName))

        'If playlist.count < 1 Then
        'Winplayer1.currentPlaylist = playlist
        'End If
    End Sub

    Private Sub cboLocutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocutor.SelectedIndexChanged
        btnIniciar.Enabled = True
        btnParar.Enabled = True
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage1_Layout(sender As Object, e As LayoutEventArgs) Handles TabPage1.Layout
        lblResumo.Text = txtDivulgacao.Text
    End Sub

    Private Sub OpenFile()
        OpenFileDialog1.ShowDialog()
        Dim strAarquivoDeSaida As String

        'txtArquivoDeSaida.Text = OpenFileDialog1.FileName
        strAarquivoDeSaida = OpenFileDialog1.FileName
        'If txtArquivoDeSaida.Text <> "" Then
        If strAarquivoDeSaida <> "" Then
            Dim vLeitor As System.IO.StreamReader
            'vLeitor = My.Computer.FileSystem.OpenTextFileReader(txtArquivoDeSaida.Text)
            vLeitor = My.Computer.FileSystem.OpenTextFileReader(strAarquivoDeSaida)
            'RichTextBox1.Clear()
            txtDivulgacao.Text = ""

            'RichTextBox1.Text = vLeitor.ReadToEnd
            txtDivulgacao.Text = vLeitor.ReadToEnd
        Else
            MessageBox.Show("Arquivo não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFile()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSave As String = SaveFileDialog1.FileName

        Dim ObjWriter As New System.IO.StreamWriter(FileToSave)
        ObjWriter.Write(txtDivulgacao.Text)
        ObjWriter.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub chkRepetir_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepetir.CheckedChanged
        If Iniciado Then
            If chkRepetir.Checked Then
                Timer1.Enabled = True
            Else
                Timer1.Enabled = False
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTempoEspera.TextChanged
        If IsNumeric(txtTempoEspera.Text) Then
            TempoEspera = txtTempoEspera.Text
        Else
            txtTempoEspera.Text = "0"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Formquemsomos.ShowDialog()
    End Sub
End Class