Imports System.Speech
Imports System.Speech.Synthesis
Imports System.Speech.AudioFormat
'Imports Microsoft.Office.Interop.Word

Public Class Form1
    'Chamada de API
    Private Declare Function GetKeyState Lib "user32.dll" Alias "GetKeyState" (ByVal nVirtKey As Long) As Integer

    Dim Speech As New SpeechSynthesizer

    Private StatusBar1 As StatusBar

    Private Panel1 As StatusBarPanel
    Private Panel2 As StatusBarPanel
    Private Panel3 As StatusBarPanel

    Private playlist As WMPLib.IWMPPlaylist ' = Winplayer1.playlistCollection.newPlaylist("PlayList001")

    


    '------------------as as procedures----------------------------

    Private Sub OpenFile()
        OpenFileDialog1.ShowDialog()
        txtArquivoDeSaida.Text = OpenFileDialog1.FileName

        If txtArquivoDeSaida.Text <> "" Then
            Dim vLeitor As System.IO.StreamReader
            vLeitor = My.Computer.FileSystem.OpenTextFileReader(txtArquivoDeSaida.Text)
            RichTextBox1.Clear()

            RichTextBox1.Text = vLeitor.ReadToEnd

        Else
            MessageBox.Show("Arquivo não encontrado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
    Private Sub SaveFile()
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub CriarMayStatusBar()
        StatusBar1 = New StatusBar

        Panel1 = New StatusBarPanel
        Panel2 = New StatusBarPanel
        Panel3 = New StatusBarPanel

        'exibe o panel1 com o stilo de bordas com contornos
        Panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken
        'inicia o texto
        Panel1.Text = "New File"
        'Alinha o conteudo do panel a esquerda
        Panel1.Alignment = HorizontalAlignment.Left
        'Define a propriedade autosize para usar todo o aspaço disponivel na statusBar
        Panel1.AutoSize = StatusBarPanelAutoSize.Spring
        '------------------------------------------------

        'Configurando Panel2
        Panel2.BorderStyle = StatusBarPanelBorderStyle.Sunken
        Panel2.Alignment = HorizontalAlignment.Center

        'API GetKeyState, determina o status da tecla Caps Lock, retornando a condição

        If GetKeyState(Keys.CapsLock) = 1 Then
            Panel2.Text = "A tecla CAPSLOCK esta ligado!"
        Else
            Panel2.Text = "capslock"

        End If

        Panel2.AutoSize = StatusBarPanelAutoSize.Contents

        'configurando Panel3

        'exibe o panel1 com o stilo de bordas com contornos
        Panel3.BorderStyle = StatusBarPanelBorderStyle.Raised
        'inicia o texto
        Panel3.Text = System.DateTime.Today.ToLongDateString
        'Alinha o conteudo do panel a esquerda
        Panel3.AutoSize = StatusBarPanelAutoSize.Contents

        'Inclui os três Panels na  coleção statusbarpanelCollection
        StatusBar1.Panels.Add(Panel1)
        StatusBar1.Panels.Add(Panel2)
        StatusBar1.Panels.Add(Panel3)
        'exibe os panels no controle statusBar
        StatusBar1.ShowPanels = True
        'inclui StatusBar1 a coleção do formulario
        Me.Controls.Add(StatusBar1)



    End Sub
    '-----------------------Fim das procedures----------------------


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Registrado = True Then

        Else
            If My.Settings.Serials30 = "" Then
                My.Settings.Serials30 = DateTime.Now.AddDays(30)
                My.Settings.Save()
                My.Settings.Reload()
            Else
            End If
            lblData.Text = DateTime.Now
            LblFim.Text = My.Settings.Serials30
        End If


        Dim objVoices As IReadOnlyCollection(Of InstalledVoice) = Speech.GetInstalledVoices(Globalization.CultureInfo.CurrentCulture)
        Dim ObjVoiceInformation As VoiceInfo = objVoices(0).VoiceInfo
        For Each tmpVoice As InstalledVoice In objVoices
            ObjVoiceInformation = tmpVoice.VoiceInfo
            ComboBox1.Items.Add(ObjVoiceInformation.Name.ToString)
        Next

        'Winplayer1.DataBindings(BindingSource1)
        playlist = Winplayer1.playlistCollection.newPlaylist("PlayList001")
        Winplayer1.currentPlaylist = playlist

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True
        Button4.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Speech.SelectVoice(ComboBox1.Text)

        'velocidade da voz
        Speech.Rate = TrackBarVelocidade.Value
        'volume da voz
        Speech.Volume = TrackBarVolume.Value

        Speech.SpeakAsync(RichTextBox1.Text)

        'Abilitando button
        GroupBox10.Enabled = True




        If rbLigar.Checked = True Then

            Timer1.Enabled = True

        Else
            Timer1.Enabled = False


        End If

    End Sub

    Private Sub QuemSomosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuemSomosToolStripMenuItem.Click
        Formquemsomos.ShowDialog()

    End Sub

    Private Sub AbrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub SOBREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOBREToolStripMenuItem.Click
        FormSobre.ShowDialog()

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFile()

    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        SaveFile()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Speech.SpeakAsyncCancelAll()
        Timer1.Enabled = False

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSave As String = SaveFileDialog1.FileName

        Dim ObjWriter As New System.IO.StreamWriter(FileToSave)
        ObjWriter.Write(RichTextBox1.Text)
        ObjWriter.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lblData.Text = DateTime.Now
        'If My.Settings.Serials30 <= lblData.Text Then
        '    Timer1.Stop()
        '    MsgBox("O SoftWare expirou, entre em contato com   sac.skynetsystem@gmail.com!", MsgBoxStyle.Exclamation, "Fim do Serial")
        '    DialogKey.Show()
        '    Me.Visible = False

        'End If


        '---------------------------Aqui verifico se o  texto ja foi falado " speak" 
        Dim Estado As Boolean = Speech.State = SynthesizerState.Speaking

        If rbLigar.Checked = True Then

            If Estado Then

                ' MessageBox.Show("rodando!")
            Else
                ' Timer1.Enabled = False

                '   MessageBox.Show("Parou")
                Speech.SpeakAsync(RichTextBox1.Text)

            End If
        End If
        
        ''--------------------------------------------------------------------------


    End Sub

    Private Sub RestritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestritoToolStripMenuItem.Click
        FormLoginRest.ShowDialog()

        'FormRestrito.ShowDialog()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

        Try
            Dim Info As New System.IO.FileInfo(txtArquivoDeSaida.Text.Trim)
            SaveFileDialog1.InitialDirectory = Info.Directory.FullName

            SaveFileDialog1.Filter = ("Arquivo de áudio MP3|*.mp3")
            SaveFileDialog1.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btSalvarWAV_Click(sender As Object, e As EventArgs) Handles btSalvarWAV.Click
        Try
            SaveFileDialog1.DefaultExt = ".wav"
            SaveFileDialog1.Filter = ""
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Speech.SetOutputToWaveFile(SaveFileDialog1.FileName, New SpeechAudioFormatInfo(44100, AudioBitsPerSample.Sixteen, AudioChannel.Stereo))
                Speech.Speak(RichTextBox1.Text.ToLower)
                Speech.Dispose()

                MsgBox("Arquivo criado com sucesso!", MsgBoxStyle.Information)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btSalvarMP3_Click_2(sender As Object, e As EventArgs) Handles btSalvarMP3.Click
        SaveFileDialog1.Filter = Nothing

        Try
            SaveFileDialog1.DefaultExt = ".mp3"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                Speech.SetOutputToWaveFile(Application.StartupPath & "\1.wav", New SpeechAudioFormatInfo(44100, AudioBitsPerSample.Sixteen, AudioChannel.Stereo))
                Speech.Speak(RichTextBox1.Text.ToLower)
                Speech.SetOutputToNull()

                Dim Lame As Process = New Process()
                Lame.StartInfo.FileName = "Lame.exe"
                Lame.StartInfo.Arguments = " -h -V 0 " + """" + Application.StartupPath & "\1.wav" + """" + " " + """" + SaveFileDialog1.FileName + """"
                Lame.StartInfo.CreateNoWindow = True
                Lame.StartInfo.UseShellExecute = False
                Lame.StartInfo.RedirectStandardOutput = True
                Lame.StartInfo.RedirectStandardError = True
                Lame.Start()



                While Not Lame.StandardError.EndOfStream
                    'esse For loop é para progresbar
                    For cont = 1 To 100
                        ProgressBar1.Value = cont

                        Lame.StandardError.ReadLine()
                        Application.DoEvents()

                    Next cont


                End While
                ProgressBar1.Value = 0


                Lame.WaitForExit()

                If Lame.HasExited Then

                    MsgBox("Arquivo criado com sucesso!", MsgBoxStyle.Information)


                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\1.wav")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objWord As New Microsoft.Office.Interop.Word.Application



        'Cria um documento em branco
        objWord.Documents.Add()
        'Adiciona o texto no novo documento em branco
        objWord.Selection.TypeText(RichTextBox1.Text)
        'Aciona a ação de verificação ortográfica
        objWord.Documents.Item(objWord.Documents.Count).CheckSpelling()
        'Retorna o texto corrigido para o textbox
        RichTextBox1.Text = objWord.Documents.Item(objWord.Documents.Count).Content.Text
        'Fecha o documento sem salvar as alterações no documento em branco que foi criado
        objWord.Documents.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges)
        'Fecha a instância do word
        objWord.Quit()
        'Destrói o objeto word
        objWord = Nothing

    End Sub

    Private Sub RichTextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyUp
        'If e.KeyValue = Keys.CapsLock Then
        '    'usamos a API GetKeyState para determinar o status de caps Lock 
        '    'retorna 1 capsLock esta ativa
        '    If GetKeyState(Keys.CapsLock) = 1 Then
        '        Panel2.Text = "CAPSLOCK"
        '    Else
        '        Panel2.Text = "capslock"

        '    End If
        'End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FormConfig.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub rbLigar_CheckedChanged(sender As Object, e As EventArgs) Handles rbLigar.CheckedChanged

        ''If rbLigar.Checked = True Then

        ''    '' MessageBox.Show("rodando!")
        ''    'Timer1.Enabled = True
        ''Else
        ''    ' Timer1.Enabled = False

        ''    '   MessageBox.Show("Parou")

        ''End If

    End Sub

    Private Sub rbDesligar_CheckedChanged(sender As Object, e As EventArgs) Handles rbDesligar.CheckedChanged
        Timer1.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        BindingSource1.Add(OpenFileDialog1.FileName)
        playlist.appendItem(Winplayer1.newMedia(OpenFileDialog1.FileName))
        
        If playlist.count < 1 Then
            Winplayer1.currentPlaylist = playlist
        End If
            
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        'Winplayer1.URL = ListBox1.SelectedItem
        '/Winplayer1.playlistCollection()
        '//Winplayer1.newPlaylist(AbrirToolS)


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Winplayer1.Ctlcontrols.play()
    End Sub

    Private Sub Winplayer1_EndOfStream(sender As Object, e As AxWMPLib._WMPOCXEvents_EndOfStreamEvent) Handles Winplayer1.EndOfStream
        'If ListBox1.Items.Count - 1 > ListBox1.SelectedIndex Then
        'ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        'Winplayer1.URL = ListBox1.SelectedItem
        'End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub btProcurar_Click(sender As Object, e As EventArgs) Handles btProcurar.Click

    End Sub
End Class
