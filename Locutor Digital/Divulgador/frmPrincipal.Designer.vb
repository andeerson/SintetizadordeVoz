<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTempoEspera = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkRepetir = New System.Windows.Forms.CheckBox()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblResumo = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Winplayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboLocutor = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TrackBarVolume = New System.Windows.Forms.TrackBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TrackBarVelocidade = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDivulgacao = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAdicionaMusica = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Winplayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TrackBarVelocidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(952, 491)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(944, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Locutor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(439, 436)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "   Locutor Dígital   "
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.txtTempoEspera)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.chkRepetir)
        Me.GroupBox9.Controls.Add(Me.btnParar)
        Me.GroupBox9.Controls.Add(Me.btnIniciar)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 331)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(406, 99)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "   Comandos   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Minutos"
        '
        'txtTempoEspera
        '
        Me.txtTempoEspera.Location = New System.Drawing.Point(240, 65)
        Me.txtTempoEspera.Name = "txtTempoEspera"
        Me.txtTempoEspera.Size = New System.Drawing.Size(33, 20)
        Me.txtTempoEspera.TabIndex = 4
        Me.txtTempoEspera.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tempo de espera entre repetições"
        '
        'chkRepetir
        '
        Me.chkRepetir.AutoSize = True
        Me.chkRepetir.Location = New System.Drawing.Point(242, 19)
        Me.chkRepetir.Name = "chkRepetir"
        Me.chkRepetir.Size = New System.Drawing.Size(60, 17)
        Me.chkRepetir.TabIndex = 2
        Me.chkRepetir.Text = "Repetir"
        Me.chkRepetir.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Location = New System.Drawing.Point(124, 28)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(99, 55)
        Me.btnParar.TabIndex = 1
        Me.btnParar.Text = "Parar"
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(22, 28)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(99, 55)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblResumo)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 22)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(407, 300)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "   Texto   "
        '
        'lblResumo
        '
        Me.lblResumo.AutoSize = True
        Me.lblResumo.Location = New System.Drawing.Point(20, 22)
        Me.lblResumo.MaximumSize = New System.Drawing.Size(400, 295)
        Me.lblResumo.Name = "lblResumo"
        Me.lblResumo.Size = New System.Drawing.Size(56, 13)
        Me.lblResumo.TabIndex = 0
        Me.lblResumo.Text = "lblResumo"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Winplayer1)
        Me.GroupBox5.Location = New System.Drawing.Point(463, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(471, 437)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "   Player de Música   "
        '
        'Winplayer1
        '
        Me.Winplayer1.Enabled = True
        Me.Winplayer1.Location = New System.Drawing.Point(6, 19)
        Me.Winplayer1.Name = "Winplayer1"
        Me.Winplayer1.OcxState = CType(resources.GetObject("Winplayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winplayer1.Size = New System.Drawing.Size(459, 412)
        Me.Winplayer1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtDivulgacao)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(944, 465)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Texto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(843, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button2, "Abrir arquivo texto")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(881, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(32, 32)
        Me.btnSave.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnSave, "Salvar arquivo texto")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(511, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 110)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "   Controle de Texto   "
        Me.GroupBox3.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(349, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Corretor Ortográfico"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(510, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 295)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   Controles da Voz   "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cboLocutor)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 77)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "   Voz do Locutor   "
        '
        'cboLocutor
        '
        Me.cboLocutor.FormattingEnabled = True
        Me.cboLocutor.Location = New System.Drawing.Point(21, 29)
        Me.cboLocutor.Name = "cboLocutor"
        Me.cboLocutor.Size = New System.Drawing.Size(323, 21)
        Me.cboLocutor.TabIndex = 3
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.TrackBarVolume)
        Me.GroupBox6.Location = New System.Drawing.Point(25, 193)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "   Volume   "
        '
        'TrackBarVolume
        '
        Me.TrackBarVolume.BackColor = System.Drawing.Color.Black
        Me.TrackBarVolume.Location = New System.Drawing.Point(6, 19)
        Me.TrackBarVolume.Maximum = 100
        Me.TrackBarVolume.Minimum = 50
        Me.TrackBarVolume.Name = "TrackBarVolume"
        Me.TrackBarVolume.Size = New System.Drawing.Size(348, 45)
        Me.TrackBarVolume.TabIndex = 0
        Me.TrackBarVolume.Value = 100
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TrackBarVelocidade)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 101)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 77)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "   Velocidade   "
        '
        'TrackBarVelocidade
        '
        Me.TrackBarVelocidade.BackColor = System.Drawing.Color.Black
        Me.TrackBarVelocidade.Location = New System.Drawing.Point(6, 19)
        Me.TrackBarVelocidade.Minimum = -10
        Me.TrackBarVelocidade.Name = "TrackBarVelocidade"
        Me.TrackBarVelocidade.Size = New System.Drawing.Size(348, 45)
        Me.TrackBarVelocidade.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texto a ser divulgado."
        '
        'txtDivulgacao
        '
        Me.txtDivulgacao.Location = New System.Drawing.Point(6, 43)
        Me.txtDivulgacao.Multiline = True
        Me.txtDivulgacao.Name = "txtDivulgacao"
        Me.txtDivulgacao.Size = New System.Drawing.Size(471, 415)
        Me.txtDivulgacao.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAdicionaMusica)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(944, 465)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PlayList"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAdicionaMusica
        '
        Me.btnAdicionaMusica.Location = New System.Drawing.Point(170, 308)
        Me.btnAdicionaMusica.Name = "btnAdicionaMusica"
        Me.btnAdicionaMusica.Size = New System.Drawing.Size(571, 26)
        Me.btnAdicionaMusica.TabIndex = 5
        Me.btnAdicionaMusica.Text = "Adicionar Música"
        Me.btnAdicionaMusica.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.BindingSource1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(938, 290)
        Me.ListBox1.TabIndex = 4
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Arquivo Texto(*.txt)|*.txt|All Files|*.*"
        '
        'ToolTip1
        '
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(918, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 43)
        Me.Button3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button3, "Quem somos")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 65000
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 526)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locutor Digital."
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Winplayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TrackBarVelocidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDivulgacao As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBarVelocidade As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBarVolume As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocutor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdicionaMusica As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Winplayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResumo As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRepetir As System.Windows.Forms.CheckBox
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTempoEspera As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
