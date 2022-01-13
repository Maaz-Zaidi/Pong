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
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOptionSelected = New System.Windows.Forms.Timer(Me.components)
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.tmrDraw = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRinkAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayerUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayerDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBallUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBallDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBallLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBallRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBallTracker = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblAI = New System.Windows.Forms.Label()
        Me.tmrOption1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOption2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOption3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrArrowMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayer2Up = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayer2Down = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.picArrowKeys = New System.Windows.Forms.PictureBox()
        Me.picPause = New System.Windows.Forms.PictureBox()
        Me.picLock = New System.Windows.Forms.PictureBox()
        Me.picTriangle = New System.Windows.Forms.PictureBox()
        Me.picPongLogo = New System.Windows.Forms.PictureBox()
        Me.picWASD = New System.Windows.Forms.PictureBox()
        Me.picLock1 = New System.Windows.Forms.PictureBox()
        Me.picLock3 = New System.Windows.Forms.PictureBox()
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPongLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWASD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLock3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 1
        '
        'tmrOptionSelected
        '
        Me.tmrOptionSelected.Enabled = True
        Me.tmrOptionSelected.Interval = 10
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Rubik", 28.0!)
        Me.lblStart.ForeColor = System.Drawing.Color.White
        Me.lblStart.Location = New System.Drawing.Point(318, 224)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(217, 46)
        Me.lblStart.TabIndex = 1
        Me.lblStart.Text = "Start Game"
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.BackColor = System.Drawing.Color.Transparent
        Me.lblOptions.Font = New System.Drawing.Font("Rubik", 28.0!)
        Me.lblOptions.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOptions.Location = New System.Drawing.Point(346, 280)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(155, 46)
        Me.lblOptions.TabIndex = 2
        Me.lblOptions.Text = "Options"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Rubik", 28.0!)
        Me.lblExit.ForeColor = System.Drawing.SystemColors.Control
        Me.lblExit.Location = New System.Drawing.Point(379, 340)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(88, 46)
        Me.lblExit.TabIndex = 3
        Me.lblExit.Text = "Exit"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrDraw
        '
        Me.tmrDraw.Interval = 1
        '
        'tmrRinkAnimate
        '
        Me.tmrRinkAnimate.Interval = 10
        '
        'tmrPlayerUp
        '
        Me.tmrPlayerUp.Interval = 10
        '
        'tmrPlayerDown
        '
        Me.tmrPlayerDown.Interval = 10
        '
        'tmrBallUp
        '
        Me.tmrBallUp.Interval = 10
        '
        'tmrBallDown
        '
        Me.tmrBallDown.Interval = 10
        '
        'tmrBallLeft
        '
        Me.tmrBallLeft.Interval = 10
        '
        'tmrBallRight
        '
        Me.tmrBallRight.Interval = 10
        '
        'tmrBallTracker
        '
        Me.tmrBallTracker.Interval = 1
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer.Font = New System.Drawing.Font("Rubik", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.White
        Me.lblPlayer.Location = New System.Drawing.Point(314, -41)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(43, 45)
        Me.lblPlayer.TabIndex = 4
        Me.lblPlayer.Text = "0"
        '
        'lblAI
        '
        Me.lblAI.AutoSize = True
        Me.lblAI.BackColor = System.Drawing.Color.Transparent
        Me.lblAI.Font = New System.Drawing.Font("Rubik", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAI.ForeColor = System.Drawing.Color.White
        Me.lblAI.Location = New System.Drawing.Point(486, -40)
        Me.lblAI.Name = "lblAI"
        Me.lblAI.Size = New System.Drawing.Size(43, 45)
        Me.lblAI.TabIndex = 5
        Me.lblAI.Text = "0"
        '
        'tmrOption1
        '
        Me.tmrOption1.Interval = 5
        '
        'tmrOption2
        '
        Me.tmrOption2.Interval = 5
        '
        'tmrOption3
        '
        Me.tmrOption3.Interval = 5
        '
        'tmrArrowMovement
        '
        Me.tmrArrowMovement.Enabled = True
        Me.tmrArrowMovement.Interval = 1
        '
        'tmrPlayer2Up
        '
        Me.tmrPlayer2Up.Interval = 1
        '
        'tmrPlayer2Down
        '
        Me.tmrPlayer2Down.Interval = 1
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("Rubik", 20.0!)
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(74, 65)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(717, 363)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'picArrowKeys
        '
        Me.picArrowKeys.BackColor = System.Drawing.Color.Transparent
        Me.picArrowKeys.Enabled = False
        Me.picArrowKeys.Image = Global.Pong.My.Resources.Resources.c0facb164c02a5815d7efea4eb898a98_keyboard_arrow_keys_stroke_icon_by_vexels
        Me.picArrowKeys.Location = New System.Drawing.Point(529, 144)
        Me.picArrowKeys.Name = "picArrowKeys"
        Me.picArrowKeys.Size = New System.Drawing.Size(222, 193)
        Me.picArrowKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picArrowKeys.TabIndex = 11
        Me.picArrowKeys.TabStop = False
        Me.picArrowKeys.Visible = False
        '
        'picPause
        '
        Me.picPause.BackColor = System.Drawing.Color.Transparent
        Me.picPause.Image = Global.Pong.My.Resources.Resources.pause_icon_18_256
        Me.picPause.Location = New System.Drawing.Point(355, 162)
        Me.picPause.Name = "picPause"
        Me.picPause.Size = New System.Drawing.Size(153, 164)
        Me.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPause.TabIndex = 10
        Me.picPause.TabStop = False
        '
        'picLock
        '
        Me.picLock.Image = Global.Pong.My.Resources.Resources.lock
        Me.picLock.Location = New System.Drawing.Point(667, 280)
        Me.picLock.Name = "picLock"
        Me.picLock.Size = New System.Drawing.Size(51, 46)
        Me.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLock.TabIndex = 8
        Me.picLock.TabStop = False
        '
        'picTriangle
        '
        Me.picTriangle.BackColor = System.Drawing.Color.Transparent
        Me.picTriangle.Image = Global.Pong.My.Resources.Resources.yellow_shape
        Me.picTriangle.Location = New System.Drawing.Point(281, 232)
        Me.picTriangle.Name = "picTriangle"
        Me.picTriangle.Size = New System.Drawing.Size(31, 28)
        Me.picTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTriangle.TabIndex = 6
        Me.picTriangle.TabStop = False
        '
        'picPongLogo
        '
        Me.picPongLogo.Image = Global.Pong.My.Resources.Resources.ponglogo
        Me.picPongLogo.Location = New System.Drawing.Point(189, 87)
        Me.picPongLogo.Name = "picPongLogo"
        Me.picPongLogo.Size = New System.Drawing.Size(465, 120)
        Me.picPongLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPongLogo.TabIndex = 0
        Me.picPongLogo.TabStop = False
        '
        'picWASD
        '
        Me.picWASD.BackColor = System.Drawing.Color.Transparent
        Me.picWASD.Enabled = False
        Me.picWASD.Image = Global.Pong.My.Resources.Resources.wasd
        Me.picWASD.Location = New System.Drawing.Point(115, 147)
        Me.picWASD.Name = "picWASD"
        Me.picWASD.Size = New System.Drawing.Size(217, 184)
        Me.picWASD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWASD.TabIndex = 7
        Me.picWASD.TabStop = False
        Me.picWASD.Visible = False
        '
        'picLock1
        '
        Me.picLock1.Image = Global.Pong.My.Resources.Resources.lock
        Me.picLock1.Location = New System.Drawing.Point(667, 224)
        Me.picLock1.Name = "picLock1"
        Me.picLock1.Size = New System.Drawing.Size(51, 46)
        Me.picLock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLock1.TabIndex = 12
        Me.picLock1.TabStop = False
        '
        'picLock3
        '
        Me.picLock3.Image = Global.Pong.My.Resources.Resources.lock
        Me.picLock3.Location = New System.Drawing.Point(667, 340)
        Me.picLock3.Name = "picLock3"
        Me.picLock3.Size = New System.Drawing.Size(51, 46)
        Me.picLock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLock3.TabIndex = 13
        Me.picLock3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.picLock3)
        Me.Controls.Add(Me.picLock1)
        Me.Controls.Add(Me.picPause)
        Me.Controls.Add(Me.picLock)
        Me.Controls.Add(Me.picTriangle)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.picPongLogo)
        Me.Controls.Add(Me.lblAI)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.picWASD)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picArrowKeys)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Pong!"
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPongLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWASD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLock3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPongLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents tmrOptionSelected As System.Windows.Forms.Timer
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents tmrDraw As System.Windows.Forms.Timer
    Friend WithEvents tmrRinkAnimate As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayerUp As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayerDown As System.Windows.Forms.Timer
    Friend WithEvents tmrBallUp As System.Windows.Forms.Timer
    Friend WithEvents tmrBallDown As System.Windows.Forms.Timer
    Friend WithEvents tmrBallLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrBallRight As System.Windows.Forms.Timer
    Friend WithEvents tmrBallTracker As System.Windows.Forms.Timer
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblAI As System.Windows.Forms.Label
    Friend WithEvents tmrOption1 As System.Windows.Forms.Timer
    Friend WithEvents tmrOption2 As System.Windows.Forms.Timer
    Friend WithEvents tmrOption3 As System.Windows.Forms.Timer
    Friend WithEvents picTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents tmrArrowMovement As System.Windows.Forms.Timer
    Friend WithEvents picWASD As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPlayer2Up As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayer2Down As System.Windows.Forms.Timer
    Friend WithEvents picLock As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents picPause As System.Windows.Forms.PictureBox
    Friend WithEvents picArrowKeys As System.Windows.Forms.PictureBox
    Friend WithEvents picLock1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLock3 As System.Windows.Forms.PictureBox

End Class
