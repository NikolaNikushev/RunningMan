<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.Start = New System.Windows.Forms.Label()
        Me.Levelss = New System.Windows.Forms.Label()
        Me.Quit = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.TimeResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Olive
        Me.Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Start.Location = New System.Drawing.Point(325, 28)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(135, 85)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Levelss
        '
        Me.Levelss.BackColor = System.Drawing.Color.Olive
        Me.Levelss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Levelss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Levelss.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Levelss.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Levelss.Location = New System.Drawing.Point(325, 135)
        Me.Levelss.Name = "Levelss"
        Me.Levelss.Size = New System.Drawing.Size(135, 102)
        Me.Levelss.TabIndex = 1
        Me.Levelss.Text = "Level Select"
        Me.Levelss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Olive
        Me.Quit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Quit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Quit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Quit.Location = New System.Drawing.Point(325, 256)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(135, 107)
        Me.Quit.TabIndex = 2
        Me.Quit.Text = "Exit Game"
        Me.Quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.BackColor = System.Drawing.Color.Olive
        Me.Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Time.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Time.Location = New System.Drawing.Point(2, 43)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(115, 28)
        Me.Time.TabIndex = 3
        Me.Time.Text = "Total time:"
        Me.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeResult
        '
        Me.TimeResult.BackColor = System.Drawing.Color.Olive
        Me.TimeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeResult.Cursor = System.Windows.Forms.Cursors.Default
        Me.TimeResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TimeResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TimeResult.Location = New System.Drawing.Point(123, 4)
        Me.TimeResult.Name = "TimeResult"
        Me.TimeResult.Size = New System.Drawing.Size(135, 109)
        Me.TimeResult.TabIndex = 4
        Me.TimeResult.Text = "0 seconds"
        Me.TimeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 393)
        Me.ControlBox = False
        Me.Controls.Add(Me.TimeResult)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Levelss)
        Me.Controls.Add(Me.Start)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Label
    Friend WithEvents Levelss As System.Windows.Forms.Label
    Friend WithEvents Quit As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents TimeResult As System.Windows.Forms.Label
End Class
