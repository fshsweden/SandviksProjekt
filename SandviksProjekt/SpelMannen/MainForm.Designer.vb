<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPoäng = New System.Windows.Forms.Label()
        Me.SenasteSvar = New System.Windows.Forms.Label()
        Me.Points = New System.Windows.Forms.Label()
        Me.HighScore1 = New System.Windows.Forms.Label()
        Me.HighScore2 = New System.Windows.Forms.Label()
        Me.HighScore3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 176)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(423, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(195, 176)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(624, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(195, 176)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblPoäng
        '
        Me.lblPoäng.AutoSize = True
        Me.lblPoäng.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoäng.Location = New System.Drawing.Point(407, 388)
        Me.lblPoäng.Name = "lblPoäng"
        Me.lblPoäng.Size = New System.Drawing.Size(268, 91)
        Me.lblPoäng.TabIndex = 5
        Me.lblPoäng.Text = "Poäng"
        '
        'SenasteSvar
        '
        Me.SenasteSvar.AutoSize = True
        Me.SenasteSvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenasteSvar.Location = New System.Drawing.Point(-4, 209)
        Me.SenasteSvar.Name = "SenasteSvar"
        Me.SenasteSvar.Size = New System.Drawing.Size(0, 91)
        Me.SenasteSvar.TabIndex = 4
        '
        'Points
        '
        Me.Points.AutoSize = True
        Me.Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Points.Location = New System.Drawing.Point(717, 400)
        Me.Points.Name = "Points"
        Me.Points.Size = New System.Drawing.Size(83, 91)
        Me.Points.TabIndex = 4
        Me.Points.Text = "0"
        '
        'HighScore1
        '
        Me.HighScore1.AutoSize = True
        Me.HighScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore1.Location = New System.Drawing.Point(12, 338)
        Me.HighScore1.Name = "HighScore1"
        Me.HighScore1.Size = New System.Drawing.Size(115, 25)
        Me.HighScore1.TabIndex = 4
        Me.HighScore1.Text = "HighScore1"
        '
        'HighScore2
        '
        Me.HighScore2.AutoSize = True
        Me.HighScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore2.Location = New System.Drawing.Point(12, 363)
        Me.HighScore2.Name = "HighScore2"
        Me.HighScore2.Size = New System.Drawing.Size(115, 25)
        Me.HighScore2.TabIndex = 4
        Me.HighScore2.Text = "HighScore2"
        '
        'HighScore3
        '
        Me.HighScore3.AutoSize = True
        Me.HighScore3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore3.Location = New System.Drawing.Point(12, 388)
        Me.HighScore3.Name = "HighScore3"
        Me.HighScore3.Size = New System.Drawing.Size(115, 25)
        Me.HighScore3.TabIndex = 4
        Me.HighScore3.Text = "HighScore3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HIGH SCORES"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 500)
        Me.Controls.Add(Me.lblPoäng)
        Me.Controls.Add(Me.Points)
        Me.Controls.Add(Me.SenasteSvar)
        Me.Controls.Add(Me.HighScore3)
        Me.Controls.Add(Me.HighScore2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HighScore1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "Spel Mannen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblPoäng As System.Windows.Forms.Label
    Friend WithEvents SenasteSvar As System.Windows.Forms.Label
    Friend WithEvents Points As System.Windows.Forms.Label
    Friend WithEvents HighScore1 As System.Windows.Forms.Label
    Friend WithEvents HighScore2 As System.Windows.Forms.Label
    Friend WithEvents HighScore3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
