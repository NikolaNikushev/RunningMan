<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level1))
        Me.Wall8 = New System.Windows.Forms.Label()
        Me.Wall3 = New System.Windows.Forms.Label()
        Me.Wall5 = New System.Windows.Forms.Label()
        Me.Wall11 = New System.Windows.Forms.Label()
        Me.Wall10 = New System.Windows.Forms.Label()
        Me.Wall9 = New System.Windows.Forms.Label()
        Me.Wall2 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.PictureBox()
        Me.Finish = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Wall7 = New System.Windows.Forms.Label()
        Me.RunningMan = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunningMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wall8
        '
        Me.Wall8.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall8.Location = New System.Drawing.Point(285, 80)
        Me.Wall8.Name = "Wall8"
        Me.Wall8.Size = New System.Drawing.Size(17, 260)
        Me.Wall8.TabIndex = 202
        Me.Wall8.Text = "Label1"
        '
        'Wall3
        '
        Me.Wall3.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall3.Location = New System.Drawing.Point(356, 0)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(17, 97)
        Me.Wall3.TabIndex = 204
        Me.Wall3.Text = "Label3"
        '
        'Wall5
        '
        Me.Wall5.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall5.ForeColor = System.Drawing.Color.Black
        Me.Wall5.Location = New System.Drawing.Point(288, 80)
        Me.Wall5.Name = "Wall5"
        Me.Wall5.Size = New System.Drawing.Size(85, 17)
        Me.Wall5.TabIndex = 205
        Me.Wall5.Text = "Label4"
        '
        'Wall11
        '
        Me.Wall11.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall11.ForeColor = System.Drawing.Color.Black
        Me.Wall11.Location = New System.Drawing.Point(24, 323)
        Me.Wall11.Name = "Wall11"
        Me.Wall11.Size = New System.Drawing.Size(278, 17)
        Me.Wall11.TabIndex = 206
        Me.Wall11.Text = "Label5"
        '
        'Wall10
        '
        Me.Wall10.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall10.Location = New System.Drawing.Point(24, 241)
        Me.Wall10.Name = "Wall10"
        Me.Wall10.Size = New System.Drawing.Size(17, 99)
        Me.Wall10.TabIndex = 208
        Me.Wall10.Text = "Label1"
        '
        'Wall9
        '
        Me.Wall9.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall9.ForeColor = System.Drawing.Color.Black
        Me.Wall9.Location = New System.Drawing.Point(24, 241)
        Me.Wall9.Name = "Wall9"
        Me.Wall9.Size = New System.Drawing.Size(97, 17)
        Me.Wall9.TabIndex = 209
        Me.Wall9.Text = "Label8"
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall2.Location = New System.Drawing.Point(-2, 0)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(17, 97)
        Me.Wall2.TabIndex = 210
        Me.Wall2.Text = "Label9"
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Start.Image = CType(resources.GetObject("Start.Image"), System.Drawing.Image)
        Me.Start.Location = New System.Drawing.Point(12, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(97, 71)
        Me.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Start.TabIndex = 266
        Me.Start.TabStop = False
        '
        'Finish
        '
        Me.Finish.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Finish.Image = CType(resources.GetObject("Finish.Image"), System.Drawing.Image)
        Me.Finish.Location = New System.Drawing.Point(117, 90)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(90, 63)
        Me.Finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Finish.TabIndex = 265
        Me.Finish.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-2, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 17)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(201, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 178)
        Me.Label2.TabIndex = 268
        Me.Label2.Text = "Label1"
        '
        'Wall7
        '
        Me.Wall7.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall7.Location = New System.Drawing.Point(104, 80)
        Me.Wall7.Name = "Wall7"
        Me.Wall7.Size = New System.Drawing.Size(17, 178)
        Me.Wall7.TabIndex = 269
        Me.Wall7.Text = "Label1"
        '
        'RunningMan
        '
        Me.RunningMan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RunningMan.Image = CType(resources.GetObject("RunningMan.Image"), System.Drawing.Image)
        Me.RunningMan.Location = New System.Drawing.Point(16, 34)
        Me.RunningMan.Name = "RunningMan"
        Me.RunningMan.Size = New System.Drawing.Size(25, 29)
        Me.RunningMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RunningMan.TabIndex = 270
        Me.RunningMan.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Wall1.ForeColor = System.Drawing.Color.Black
        Me.Wall1.Location = New System.Drawing.Point(-2, 0)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(375, 17)
        Me.Wall1.TabIndex = 271
        Me.Wall1.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 339)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.RunningMan)
        Me.Controls.Add(Me.Wall7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall9)
        Me.Controls.Add(Me.Wall10)
        Me.Controls.Add(Me.Wall11)
        Me.Controls.Add(Me.Wall5)
        Me.Controls.Add(Me.Wall3)
        Me.Controls.Add(Me.Wall8)
        Me.Name = "Level1"
        Me.Text = "Level1"
        CType(Me.Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunningMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Wall8 As System.Windows.Forms.Label
    Friend WithEvents Wall3 As System.Windows.Forms.Label
    Friend WithEvents Wall5 As System.Windows.Forms.Label
    Friend WithEvents Wall11 As System.Windows.Forms.Label
    Friend WithEvents Wall10 As System.Windows.Forms.Label
    Friend WithEvents Wall9 As System.Windows.Forms.Label
    Friend WithEvents Wall2 As System.Windows.Forms.Label
    Friend WithEvents Start As System.Windows.Forms.PictureBox
    Friend WithEvents Finish As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Wall7 As System.Windows.Forms.Label
    Friend WithEvents RunningMan As System.Windows.Forms.PictureBox
    Friend WithEvents Wall1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
