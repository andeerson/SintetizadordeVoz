<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRestrito
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFim = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btsair = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.GroupBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(287, 164)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.lblFim)
        Me.GroupBox7.Controls.Add(Me.lblData)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(23, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(237, 73)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Informação restrita"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data atual"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data p/ expirar"
        '
        'lblFim
        '
        Me.lblFim.AutoSize = True
        Me.lblFim.ForeColor = System.Drawing.Color.Red
        Me.lblFim.Location = New System.Drawing.Point(92, 46)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.Size = New System.Drawing.Size(70, 13)
        Me.lblFim.TabIndex = 1
        Me.lblFim.Text = "Data/expirar"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.ForeColor = System.Drawing.Color.Black
        Me.lblData.Location = New System.Drawing.Point(91, 22)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(60, 13)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Data/Hora" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btsair)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 63)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btsair
        '
        Me.btsair.BackColor = System.Drawing.Color.Maroon
        Me.btsair.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsair.ForeColor = System.Drawing.Color.White
        Me.btsair.Location = New System.Drawing.Point(20, 14)
        Me.btsair.Name = "btsair"
        Me.btsair.Size = New System.Drawing.Size(131, 37)
        Me.btsair.TabIndex = 41
        Me.btsair.Text = "FECHAR"
        Me.btsair.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormRestrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 182)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRestrito"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area restrita ----"
        Me.TopMost = True
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btsair As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFim As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
