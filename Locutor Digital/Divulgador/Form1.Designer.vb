<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARQUIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuemSomosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOBREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestritoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Winplayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LblFim = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btProcurar = New System.Windows.Forms.Button()
        Me.txtArquivoDeSaida = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBarVolume = New System.Windows.Forms.TrackBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBarVelocidade = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.rbDesligar = New System.Windows.Forms.RadioButton()
        Me.rbLigar = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btSalvarMP3 = New System.Windows.Forms.Button()
        Me.btSalvarWAV = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Winplayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TrackBarVelocidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARQUIVOToolStripMenuItem, Me.ConfiguraçãoToolStripMenuItem, Me.QuemSomosToolStripMenuItem, Me.SOBREToolStripMenuItem, Me.AJUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1237, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARQUIVOToolStripMenuItem
        '
        Me.ARQUIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.ToolStripSeparator2, Me.AbrirToolStripMenuItem1})
        Me.ARQUIVOToolStripMenuItem.Name = "ARQUIVOToolStripMenuItem"
        Me.ARQUIVOToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ARQUIVOToolStripMenuItem.Text = "ARQUIVO"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar como..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        'AbrirToolStripMenuItem1
        '
        Me.AbrirToolStripMenuItem1.Name = "AbrirToolStripMenuItem1"
        Me.AbrirToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.AbrirToolStripMenuItem1.Text = "Sair"
        '
        'ConfiguraçãoToolStripMenuItem
        '
        Me.ConfiguraçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ConfiguraçãoToolStripMenuItem.Name = "ConfiguraçãoToolStripMenuItem"
        Me.ConfiguraçãoToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ConfiguraçãoToolStripMenuItem.Text = "CONFIGURAÇÃO"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuItem1.Text = "Layout"
        '
        'QuemSomosToolStripMenuItem
        '
        Me.QuemSomosToolStripMenuItem.Name = "QuemSomosToolStripMenuItem"
        Me.QuemSomosToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.QuemSomosToolStripMenuItem.Text = "QUEM SOMOS"
        '
        'SOBREToolStripMenuItem
        '
        Me.SOBREToolStripMenuItem.Name = "SOBREToolStripMenuItem"
        Me.SOBREToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SOBREToolStripMenuItem.Text = "SOBRE"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjudaToolStripMenuItem1, Me.RegistrarToolStripMenuItem, Me.RestritoToolStripMenuItem})
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'AjudaToolStripMenuItem1
        '
        Me.AjudaToolStripMenuItem1.Name = "AjudaToolStripMenuItem1"
        Me.AjudaToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.AjudaToolStripMenuItem1.Text = "Ajuda"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'RestritoToolStripMenuItem
        '
        Me.RestritoToolStripMenuItem.Name = "RestritoToolStripMenuItem"
        Me.RestritoToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RestritoToolStripMenuItem.Text = "Restrito"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(24, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(271, 22)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escolha a voz que deseja :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(491, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Digite o texto do dia, para iniciarmos a nossa divulgação."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox11)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1213, 689)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(821, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(382, 325)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage1.Controls.Add(Me.Winplayer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(374, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Player"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Winplayer1
        '
        Me.Winplayer1.Enabled = True
        Me.Winplayer1.Location = New System.Drawing.Point(6, 6)
        Me.Winplayer1.Name = "Winplayer1"
        Me.Winplayer1.OcxState = CType(resources.GetObject("Winplayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winplayer1.Size = New System.Drawing.Size(365, 214)
        Me.Winplayer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(374, 298)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Playlist"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(209, 225)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(161, 26)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Play"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 225)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(157, 26)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Add Music"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(262, 317)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(268, 26)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Play"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 317)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(250, 26)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Add Music"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.BindingSource1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(6, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(524, 214)
        Me.ListBox1.TabIndex = 0
        '
        'BindingSource1
        '
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button5)
        Me.GroupBox11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.White
        Me.GroupBox11.Location = New System.Drawing.Point(493, 450)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(308, 94)
        Me.GroupBox11.TabIndex = 14
        Me.GroupBox11.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.Divulgador.My.Resources.Resources.alumino1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(25, 26)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(261, 49)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Fechar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button4)
        Me.GroupBox9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.White
        Me.GroupBox9.Location = New System.Drawing.Point(493, 357)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(308, 94)
        Me.GroupBox9.TabIndex = 13
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Corretor Ortografico"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Divulgador.My.Resources.Resources.alumino1
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(25, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(261, 49)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Corretor Ortográfico"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 664)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1208, 23)
        Me.ProgressBar1.Step = 40
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 14
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox7.Controls.Add(Me.LblFim)
        Me.GroupBox7.Controls.Add(Me.lblData)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(1007, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(192, 73)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Data/Hora"
        '
        'LblFim
        '
        Me.LblFim.AutoSize = True
        Me.LblFim.Location = New System.Drawing.Point(26, 54)
        Me.LblFim.Name = "LblFim"
        Me.LblFim.Size = New System.Drawing.Size(46, 17)
        Me.LblFim.TabIndex = 1
        Me.LblFim.Text = "Label5"
        Me.LblFim.Visible = False
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.White
        Me.lblData.Location = New System.Drawing.Point(24, 28)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(69, 17)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Data/Hora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btProcurar)
        Me.GroupBox5.Controls.Add(Me.txtArquivoDeSaida)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(886, 562)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(321, 116)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'btProcurar
        '
        Me.btProcurar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btProcurar.Image = Global.Divulgador.My.Resources.Resources._365
        Me.btProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProcurar.Location = New System.Drawing.Point(207, 53)
        Me.btProcurar.Name = "btProcurar"
        Me.btProcurar.Size = New System.Drawing.Size(106, 43)
        Me.btProcurar.TabIndex = 12
        Me.btProcurar.Text = "Procurar"
        Me.btProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btProcurar.UseVisualStyleBackColor = True
        '
        'txtArquivoDeSaida
        '
        Me.txtArquivoDeSaida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtArquivoDeSaida.Location = New System.Drawing.Point(6, 63)
        Me.txtArquivoDeSaida.Name = "txtArquivoDeSaida"
        Me.txtArquivoDeSaida.Size = New System.Drawing.Size(199, 25)
        Me.txtArquivoDeSaida.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(24, 439)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 202)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Controles"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.TrackBarVolume)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 103)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Volume da voz"
        '
        'TrackBarVolume
        '
        Me.TrackBarVolume.BackColor = System.Drawing.Color.Black
        Me.TrackBarVolume.Location = New System.Drawing.Point(6, 35)
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
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TrackBarVelocidade)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 87)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Velocidade da voz"
        '
        'TrackBarVelocidade
        '
        Me.TrackBarVelocidade.BackColor = System.Drawing.Color.Black
        Me.TrackBarVelocidade.Location = New System.Drawing.Point(6, 35)
        Me.TrackBarVelocidade.Minimum = -10
        Me.TrackBarVelocidade.Name = "TrackBarVelocidade"
        Me.TrackBarVelocidade.Size = New System.Drawing.Size(348, 45)
        Me.TrackBarVelocidade.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox12)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(24, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 77)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comandos"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.rbDesligar)
        Me.GroupBox12.Controls.Add(Me.rbLigar)
        Me.GroupBox12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.White
        Me.GroupBox12.Location = New System.Drawing.Point(267, 10)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(148, 61)
        Me.GroupBox12.TabIndex = 14
        Me.GroupBox12.TabStop = False
        '
        'rbDesligar
        '
        Me.rbDesligar.AutoSize = True
        Me.rbDesligar.Checked = True
        Me.rbDesligar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDesligar.ForeColor = System.Drawing.Color.Red
        Me.rbDesligar.Location = New System.Drawing.Point(10, 35)
        Me.rbDesligar.Name = "rbDesligar"
        Me.rbDesligar.Size = New System.Drawing.Size(138, 21)
        Me.rbDesligar.TabIndex = 1
        Me.rbDesligar.TabStop = True
        Me.rbDesligar.Text = "Desligar repetição"
        Me.rbDesligar.UseVisualStyleBackColor = True
        '
        'rbLigar
        '
        Me.rbLigar.AutoSize = True
        Me.rbLigar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLigar.ForeColor = System.Drawing.Color.Red
        Me.rbLigar.Location = New System.Drawing.Point(10, 14)
        Me.rbLigar.Name = "rbLigar"
        Me.rbLigar.Size = New System.Drawing.Size(118, 21)
        Me.rbLigar.TabIndex = 0
        Me.rbLigar.TabStop = True
        Me.rbLigar.Text = "Ligar repetição"
        Me.rbLigar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Divulgador.My.Resources.Resources.alumino1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(148, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 51)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Parar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Divulgador.My.Resources.Resources.alumino1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 51)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "INICIAR  "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(26, 123)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(661, 228)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox10)
        Me.GroupBox8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(24, 453)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(308, 194)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Convertendo texto para MP3/WAV"
        Me.GroupBox8.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btSalvarMP3)
        Me.GroupBox10.Controls.Add(Me.btSalvarWAV)
        Me.GroupBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Red
        Me.GroupBox10.Location = New System.Drawing.Point(15, 20)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(277, 159)
        Me.GroupBox10.TabIndex = 14
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Escolha o local para gravar e o tipo arquivo"
        '
        'btSalvarMP3
        '
        Me.btSalvarMP3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btSalvarMP3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btSalvarMP3.BackgroundImage = Global.Divulgador.My.Resources.Resources.MP3
        Me.btSalvarMP3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btSalvarMP3.ForeColor = System.Drawing.Color.Black
        Me.btSalvarMP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalvarMP3.Location = New System.Drawing.Point(14, 24)
        Me.btSalvarMP3.Name = "btSalvarMP3"
        Me.btSalvarMP3.Size = New System.Drawing.Size(122, 119)
        Me.btSalvarMP3.TabIndex = 14
        Me.btSalvarMP3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvarMP3.UseVisualStyleBackColor = False
        '
        'btSalvarWAV
        '
        Me.btSalvarWAV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btSalvarWAV.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btSalvarWAV.BackgroundImage = Global.Divulgador.My.Resources.Resources.WAV2
        Me.btSalvarWAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSalvarWAV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSalvarWAV.Location = New System.Drawing.Point(148, 24)
        Me.btSalvarWAV.Name = "btSalvarWAV"
        Me.btSalvarWAV.Size = New System.Drawing.Size(122, 119)
        Me.btSalvarWAV.TabIndex = 13
        Me.btSalvarWAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvarWAV.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Arquivo Texto(*.txt)|*.txt|All Files|*.*"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImage = Global.Divulgador.My.Resources.Resources.textura5
        Me.ClientSize = New System.Drawing.Size(1237, 728)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema avançado "" Sintetizador de texto """
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Winplayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.TrackBarVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TrackBarVelocidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARQUIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AbrirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuemSomosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SOBREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBarVelocidade As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TrackBarVolume As System.Windows.Forms.TrackBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AjudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btProcurar As System.Windows.Forms.Button
    Friend WithEvents txtArquivoDeSaida As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RestritoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btSalvarWAV As System.Windows.Forms.Button
    Friend WithEvents btSalvarMP3 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ConfiguraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblFim As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDesligar As System.Windows.Forms.RadioButton
    Friend WithEvents rbLigar As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Winplayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource

End Class
