Imports System.Drawing.Drawing2D

Public Class Form1
    Public g As Graphics
    Dim screen As Integer = 1
    Dim OptionSelect As Integer = 1
    Dim BallX As Integer = 440
    Dim BallY As Integer = 560
    Dim PlayerY As Integer
    Dim playerWidth As Integer = 0
    Dim AIX As Integer = 830
    Dim AIY As Integer
    Dim AnimatedRinkHeight As Integer = 10
    Dim PlayerHeight As Integer = 15
    Private BallBarrier As New Rectangle(BallX, BallY, 70, 70)
    Private AnimatedRink As New Rectangle(430, (Me.Height / 2) - (AnimatedRinkHeight / 2), 0, AnimatedRinkHeight)
    Private PlayerBoundary As New Rectangle(0, 0, 50, 1000)
    Private PlayerBoundary2 As New Rectangle(830, -50, 50, 1000)
    Private Player2 As New Rectangle(AIX, (Me.Height / 2) - PlayerHeight, 0, PlayerHeight)
    Dim WinPoints As Integer
    Dim LosePoints As Integer
    Dim LineDoneLoading As Boolean = False
    Dim speed As Integer = 5
    Dim BallStarted As Boolean = False
    Dim firstHit As Boolean = False
    Dim AiRange As Integer = 20
    Dim AiTop As Boolean = False
    Dim AiBottom As Boolean = False
    Dim playerTop As Boolean = False
    Dim playerBottom As Boolean = False
    Dim ballVerticalSpeed As Integer = 3
    Dim ballHorizontalSpeed As Integer = 3
    Dim ballTrackStart As Boolean = False
    Dim AiSpeed As Integer = 6
    Dim playerPoints As Integer = 0
    Dim AiPoints As Integer = 0
    Dim brush1 = Brushes.White
    Dim fontSize1 As Decimal = 28
    Dim fontSize1Big As Boolean = False
    Dim fontSize1Small As Boolean = False
    Dim font1Counter1 As Integer
    Dim font1Counter2 As Integer

    Dim fontSize2 As Decimal = 28
    Dim fontSize2Big As Boolean = False
    Dim fontSize2Small As Boolean = False

    Dim fontSize3 As Decimal = 28
    Dim fontSize3Big As Boolean = False
    Dim fontSize3Small As Boolean = False

    Dim startNotSelected As Boolean = False
    Dim optionsNotSelected As Boolean = True
    Dim exitNotSelected As Boolean = True

    Dim arrow As Integer = 1

    Dim isGamePaused As Boolean = False

    Dim ballUp As Boolean = False
    Dim ballDown As Boolean = False
    Dim ballLeft As Boolean = False
    Dim ballRight As Boolean = False

    Dim difficulty As Integer = 1

    Dim BallSpeedLimit As Integer = 10
    Dim ballSpeedIncrease As Integer = 1

    Dim multiplayerEnabled As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
        tmrOptionSelected.Enabled = True
        tmrMain.Enabled = True
        picPause.Visible = False
        picLock.Enabled = False
        picLock.Visible = False
        lblInstructions.Visible = False
        picArrowKeys.Visible = False
        picLock1.Visible = False
        picLock3.Visible = False
    End Sub

    Private Sub tmrDraw_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDraw.Tick
        AnimatedRink.Width = 5
        If lblPlayer.Top < 10 Then
            lblPlayer.Top += 1
            lblAI.Top += 1
        End If

        If AnimatedRinkHeight < 480 Then
            AnimatedRink.Y = (Me.Height / 2) - (AnimatedRinkHeight / 2) - 17
            AnimatedRink.Height = AnimatedRinkHeight
            AnimatedRinkHeight += 5
        Else
            LineDoneLoading = True
        End If

        If PlayerHeight < 80 Then

            If playerWidth < 15 Then
                playerWidth += 1
            End If

            PlayerHeight += 1

            Player2.Width = playerWidth
            Player2.Height = PlayerHeight
            Player2.Y = (Me.Height / 2) - PlayerHeight
            AIY = Player2.Y
            PlayerY = (Me.Height / 2) - PlayerHeight
            Me.Invalidate(PlayerBoundary2)
            Me.Invalidate(PlayerBoundary)
        Else
            Player2.Width = playerWidth
            Player2.Height = PlayerHeight
            Me.Invalidate(PlayerBoundary)
            Me.Invalidate(PlayerBoundary2)

        End If

        If LineDoneLoading = True Then
            BallBarrier.Width = 70 + speed
            BallBarrier.Height = 70 + speed
            BallBarrier.X = BallX - (BallBarrier.Width / 2)
            BallBarrier.Y = BallY - (BallBarrier.Height / 2)
            Me.Invalidate(BallBarrier)
        End If


        Me.Invalidate(AnimatedRink)
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        'Player.Width = 15
        e.Graphics.FillRectangle(Brushes.White, AIX, AIY, playerWidth, PlayerHeight)
        e.Graphics.FillRectangle(Brushes.White, 15, PlayerY - 10, playerWidth, PlayerHeight)
        e.Graphics.FillRectangle(Brushes.White, AnimatedRink)
        If LineDoneLoading = True Then
            e.Graphics.FillEllipse(brush1, BallX - 10, BallY - 10, 20, 20)
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If isGamePaused = False Then
            Select Case e.KeyCode
                Case Keys.W
                    If screen = 1 Then
                        If OptionSelect > 0 Then
                            OptionSelect -= 1
                        End If
                    Else
                        If PlayerY > 10 Then
                            tmrPlayerUp.Enabled = True
                            playerTop = True
                            playerBottom = False
                            picWASD.Enabled = False
                            picWASD.Visible = False
                        End If

                    End If
                Case Keys.S
                    If screen = 1 Then
                        If OptionSelect < 4 Then
                            OptionSelect += 1
                        End If

                    Else
                        If PlayerY < Me.Height - 100 Then
                            tmrPlayerDown.Enabled = True
                            playerTop = False
                            playerBottom = True
                            picWASD.Enabled = False
                            picWASD.Visible = False
                        End If
                    End If
                Case Keys.D

                Case Keys.A

                Case Keys.Up
                    If screen = 1 Or screen = 3 Or screen = 4 Then
                        If OptionSelect > 0 Then
                            OptionSelect -= 1
                        End If
                    ElseIf screen = 2 Then
                        If multiplayerEnabled = True Then
                            tmrPlayer2Up.Enabled = True
                            picArrowKeys.Enabled = False
                            picArrowKeys.Visible = False
                        End If
                    End If

                Case Keys.Down
                    If screen = 1 Or screen = 3 Or screen = 4 Then
                        If OptionSelect < 4 Then
                            OptionSelect += 1
                        End If
                    ElseIf screen = 2 Then
                        If multiplayerEnabled = True Then
                            tmrPlayer2Down.Enabled = True
                            picArrowKeys.Enabled = False
                            picArrowKeys.Visible = False
                        End If
                    End If
                Case Keys.Enter
                    If screen = 1 Then
                        If OptionSelect = 1 Then
                            screen = 2
                            leaveScreen1()
                        ElseIf OptionSelect = 2 Then
                            enterScreen3()
                            screen = 3
                        ElseIf OptionSelect = 3 Then
                            Me.Close()
                        End If
                    ElseIf screen = 3 Then
                        If OptionSelect = 1 Then
                            screen = 4
                            enterScreen4()

                        ElseIf OptionSelect = 2 Then
                            If multiplayerEnabled = False Then
                                multiplayerEnabled = True
                                picLock.Enabled = True
                                picLock.Visible = True
                            ElseIf multiplayerEnabled = True Then
                                multiplayerEnabled = False
                                picLock.Enabled = False
                                picLock.Visible = False
                            End If


                        ElseIf OptionSelect = 3 Then
                            screen = 6
                            enterScreen6()
                        End If
                    ElseIf screen = 4 Then
                        If OptionSelect = 1 Then
                            picLock1.Visible = True
                            picLock.Visible = False
                            picLock3.Visible = False

                            difficulty = 1
                            AiRange = 15

                            speed = 5
                            AiSpeed = 6
                            BallSpeedLimit = 10
                            ballSpeedIncrease = 1
                        ElseIf OptionSelect = 2 Then
                            picLock.Visible = True
                            picLock.Enabled = True
                            picLock1.Visible = False
                            picLock3.Visible = False

                            difficulty = 2
                            AiRange = 20
                            speed = 7
                            AiSpeed = 9
                            BallSpeedLimit = 14
                            ballSpeedIncrease = 2
                        ElseIf OptionSelect = 3 Then
                            picLock3.Visible = True
                            picLock1.Visible = False
                            picLock.Visible = False

                            difficulty = 3
                            AiRange = 40
                            speed = 9
                            AiSpeed = 12
                            BallSpeedLimit = 18
                            ballSpeedIncrease = 3
                        End If
                    End If
            End Select
        End If

        Select Case e.KeyCode
            Case Keys.Escape
                If screen = 3 Then
                    enterScreen1()
                    screen = 1
                ElseIf screen = 4 Then
                    picLock.Visible = False
                    picLock1.Visible = False
                    picLock3.Visible = False
                    enterScreen3()
                    screen = 3
                ElseIf screen = 5 Then
                    screen = 4
                ElseIf screen = 6 Then
                    enterScreen3()
                    screen = 3
                    lblInstructions.Visible = False
                End If
                If isGamePaused = False Then
                    If screen = 2 Then
                        gamePause()
                    End If
                Else
                    gameResumed()
                End If

        End Select
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.W
                tmrPlayerUp.Enabled = False
                playerTop = False
            Case Keys.S
                tmrPlayerDown.Enabled = False
                playerBottom = False
            Case Keys.Up
                tmrPlayer2Up.Enabled = False
            Case Keys.Down
                tmrPlayer2Down.Enabled = False
        End Select
    End Sub

    Sub enterScreen3()
        lblStart.Text = "Select Difficulty"
        lblOptions.Text = "Multiplayer Mode"
        lblExit.Text = "Instructions"
        picTriangle.Visible = True
        picPongLogo.Enabled = False
        picPongLogo.Visible = False
        If multiplayerEnabled = True Then
            picLock.Enabled = True
            picLock.Visible = True
        ElseIf multiplayerEnabled = False Then
            picLock.Enabled = False
            picLock.Visible = False
        End If
    End Sub

    Sub enterScreen4()
        lblStart.Text = "Normal"
        lblOptions.Text = "Difficult"
        lblExit.Text = "Dark Souls"
        picPongLogo.Enabled = False
        picPongLogo.Visible = False
        If difficulty = 1 Then
            picLock1.Visible = True
            picLock.Visible = False
            picLock3.Visible = False
        ElseIf difficulty = 2 Then
            picLock.Visible = True
            picLock.Enabled = True
            picLock1.Visible = False
            picLock3.Visible = False
        ElseIf difficulty = 3 Then
            picLock3.Visible = True
            picLock1.Visible = False
            picLock.Visible = False
        End If
    End Sub

    Sub enterScreen6()
        lblStart.Text = ""
        lblOptions.Text = ""
        lblExit.Text = ""
        picPongLogo.Enabled = False
        picPongLogo.Visible = False
        picTriangle.Visible = False

        lblInstructions.Visible = True

        picLock.Enabled = False
        picLock.Visible = False
    End Sub

    Private Sub tmrOptionSelected_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOptionSelected.Tick
        If OptionSelect = 1 Then
            lblStart.ForeColor = Color.Yellow
            lblExit.ForeColor = Color.White
            lblOptions.ForeColor = Color.White

            'tmrOption1.Enabled = True
            startNotSelected = False
            exitNotSelected = True
            optionsNotSelected = True
        ElseIf OptionSelect = 2 Then
            lblStart.ForeColor = Color.White
            lblExit.ForeColor = Color.White
            lblOptions.ForeColor = Color.Yellow

            'tmrOption2.Enabled = True
            startNotSelected = True
            exitNotSelected = True
            optionsNotSelected = False
        ElseIf OptionSelect = 3 Then
            lblStart.ForeColor = Color.White
            lblExit.ForeColor = Color.Yellow
            lblOptions.ForeColor = Color.White

            'tmrOption3.Enabled = True
            startNotSelected = True
            optionsNotSelected = True
            exitNotSelected = False
        End If
    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick

        If screen = 2 Then


            If ballVerticalSpeed > 10 Then
                brush1 = Brushes.DarkRed
            ElseIf ballVerticalSpeed > 8 Then
                brush1 = Brushes.OrangeRed
            ElseIf ballVerticalSpeed > 6 Then
                brush1 = Brushes.YellowGreen
            ElseIf ballVerticalSpeed > 4 Then
                brush1 = Brushes.LightYellow
            End If
            If BallX < 0 Then
                AiPoints += 1
                gameReset()

            End If

            If BallX > Me.Width - 20 Then
                playerPoints += 1
                gameReset()

            End If

            If BallY < 0 Then
                tmrBallUp.Enabled = False
                tmrBallDown.Enabled = True
            End If

            If BallY + 20 > Me.Height - 20 Then
                tmrBallDown.Enabled = False
                tmrBallUp.Enabled = True
            End If

        If PlayerY < 10 Then
            tmrPlayerUp.Enabled = False
        End If

        If PlayerY > Me.Height - 110 Then
            tmrPlayerDown.Enabled = False
        End If

        If BallStarted = False Then
            Dim MyValue As Integer = 0
            Randomize()
            MyValue = Int((Rnd()) * 2 + 1)
            If MyValue = 1 Then
                BallY = 830
                BallX = 200
                tmrBallRight.Enabled = True
                tmrBallUp.Enabled = True
                BallStarted = True
            ElseIf MyValue = 2 Then
                BallY = 830
                BallX = 700
                tmrBallLeft.Enabled = True
                tmrBallUp.Enabled = True
                BallStarted = True
            End If
        End If

        If BallX - 10 < 30 And BallY > PlayerY - 10 And BallY + 10 < PlayerY + 70 Then



            tmrBallRight.Enabled = True
            tmrBallLeft.Enabled = False
            ballHorizontalSpeed += 1

            If multiplayerEnabled = False Then
                If ballTrackStart = False Then
                    tmrBallTracker.Enabled = True
                    ballTrackStart = True
                End If
            End If

            If tmrPlayerUp.Enabled = True And tmrPlayerDown.Enabled = False And tmrBallUp.Enabled = True Then
                If ballHorizontalSpeed < BallSpeedLimit Then
                    ballHorizontalSpeed += ballSpeedIncrease
                End If

                If ballVerticalSpeed > ballSpeedIncrease Then
                    ballVerticalSpeed -= ballSpeedIncrease
                End If
                tmrBallUp.Enabled = True
            ElseIf tmrPlayerUp.Enabled = False And tmrPlayerDown.Enabled = True And tmrBallDown.Enabled = True Then
                If ballHorizontalSpeed < BallSpeedLimit Then
                    ballHorizontalSpeed += ballSpeedIncrease
                End If

                If ballVerticalSpeed > ballSpeedIncrease Then
                    ballVerticalSpeed -= ballSpeedIncrease
                End If
                tmrBallDown.Enabled = True
            ElseIf tmrPlayerUp.Enabled = True And tmrPlayerDown.Enabled = False And tmrBallDown.Enabled = True Then
                If ballHorizontalSpeed > ballSpeedIncrease Then
                    ballHorizontalSpeed -= ballSpeedIncrease
                End If
                Dim MyValue As Integer = 0
                Randomize()
                MyValue = Int((Rnd()) * 2 + 1)

                If MyValue = 1 Then

                ElseIf MyValue = 2 Then
                    If ballVerticalSpeed < BallSpeedLimit Then
                        ballVerticalSpeed += ballSpeedIncrease
                    End If
                End If

                tmrBallDown.Enabled = True
            ElseIf tmrPlayerUp.Enabled = False And tmrPlayerDown.Enabled = True And tmrBallUp.Enabled = True Then
                If ballHorizontalSpeed > ballSpeedIncrease Then
                    ballHorizontalSpeed -= ballSpeedIncrease
                End If

                Dim MyValue As Integer = 0
                Randomize()
                MyValue = Int((Rnd()) * 2 + 1)

                If MyValue = 1 Then

                ElseIf MyValue = 2 Then
                    If ballVerticalSpeed < BallSpeedLimit Then
                        ballVerticalSpeed += ballSpeedIncrease
                    End If
                End If
            End If
        End If

        If BallX + 15 > AIX And BallY > AIY And BallY - 10 < AIY + 80 Then


            tmrBallLeft.Enabled = True
            tmrBallRight.Enabled = False
            ballHorizontalSpeed += 1
            If multiplayerEnabled = False Then
                If ballTrackStart = False Then
                    tmrBallTracker.Enabled = True
                    ballTrackStart = True
                End If
            End If


            If AiTop = True And tmrBallUp.Enabled = True Then
                If ballHorizontalSpeed < BallSpeedLimit Then
                    ballHorizontalSpeed += ballSpeedIncrease
                End If

                If ballVerticalSpeed > ballSpeedIncrease Then
                    ballVerticalSpeed -= ballSpeedIncrease
                End If
                tmrBallUp.Enabled = True
            ElseIf AiBottom = True And tmrBallDown.Enabled = True Then
                If ballHorizontalSpeed < BallSpeedLimit Then
                    ballHorizontalSpeed += ballSpeedIncrease
                End If

                If ballVerticalSpeed > ballSpeedIncrease Then
                    ballVerticalSpeed -= ballSpeedIncrease
                End If
                tmrBallDown.Enabled = True
            ElseIf AiTop = True And tmrBallDown.Enabled = True Then
                If ballHorizontalSpeed > ballSpeedIncrease Then
                    ballHorizontalSpeed -= ballSpeedIncrease
                End If

                If ballVerticalSpeed < BallSpeedLimit Then
                    ballVerticalSpeed += 1
                End If
                tmrBallDown.Enabled = True
            ElseIf AiBottom = True And tmrBallUp.Enabled = True Then
                If ballHorizontalSpeed > ballSpeedIncrease Then
                    ballHorizontalSpeed -= ballSpeedIncrease
                End If

                If ballVerticalSpeed < BallSpeedLimit Then
                    ballVerticalSpeed += ballSpeedIncrease
                End If
            End If
        End If

        lblPlayer.Text = Str(playerPoints)
        lblAI.Text = Str(AiPoints)

        End If
    End Sub


    Sub leaveScreen1()
        picPongLogo.Enabled = False
        picPongLogo.Visible = False
        lblOptions.Enabled = False
        lblOptions.Visible = False
        lblStart.Enabled = False
        lblStart.Visible = False
        lblExit.Enabled = False
        lblExit.Visible = False
        lblInstructions.Enabled = False
        lblInstructions.Visible = False
        tmrDraw.Enabled = True
        If screen = 2 Then
            picWASD.Enabled = True
            picWASD.Visible = True
            If multiplayerEnabled = True Then
                picArrowKeys.Visible = True
                picArrowKeys.Enabled = True
            End If
        End If
        picTriangle.Enabled = False
        picTriangle.Visible = False
    End Sub

    Sub enterScreen1()
        lblStart.Text = "Start Game"
        lblOptions.Text = "Options"
        lblExit.Text = "Exit"
        picPongLogo.Enabled = True
        picPongLogo.Visible = True

        picLock.Enabled = False
        picLock.Visible = False
    End Sub

    Sub gamePause()
        picPause.Visible = True
        tmrMain.Enabled = False
        isGamePaused = True
        If multiplayerEnabled = False Then
            tmrBallTracker.Enabled = False
        End If

        tmrBallDown.Enabled = False
        tmrBallUp.Enabled = False
        tmrBallLeft.Enabled = False
        tmrBallRight.Enabled = False
    End Sub

    Sub gameResumed()
        picPause.Visible = False
        tmrMain.Enabled = True
        isGamePaused = False
        If multiplayerEnabled = False Then
            tmrBallTracker.Enabled = True
        End If

        If ballUp = True Then
            tmrBallUp.Enabled = True
        ElseIf ballDown = True Then
            tmrBallDown.Enabled = True
        End If

        If ballLeft = True Then
            tmrBallLeft.Enabled = True
        ElseIf ballRight = True Then
            tmrBallRight.Enabled = True
        End If
    End Sub

    Private Sub tmrPlayerUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerUp.Tick
        PlayerY -= speed
    End Sub

    Private Sub tmrPlayerDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerDown.Tick
        PlayerY += speed
    End Sub

    Private Sub tmrBallUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallUp.Tick
        BallY -= ballHorizontalSpeed
        ballUp = True
        ballDown = False

    End Sub

    Private Sub tmrBallDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallDown.Tick
        BallY += ballHorizontalSpeed
        ballDown = True
        ballUp = False
    End Sub

    Private Sub tmrBallLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallLeft.Tick
        BallX -= ballVerticalSpeed
        ballLeft = True
        ballRight = False
    End Sub

    Private Sub tmrBallRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallRight.Tick
        BallX += ballVerticalSpeed
        ballRight = True
        ballLeft = False
    End Sub

    Sub gameReset()
        ballVerticalSpeed = 3
        ballHorizontalSpeed = 3
        BallX = 440
        BallY = 560
        ballTrackStart = False
        BallStarted = False
        AiTop = False
        AiBottom = False
        firstHit = False
        tmrBallDown.Enabled = False
        tmrBallUp.Enabled = False
        tmrBallRight.Enabled = False
        tmrBallLeft.Enabled = False
        brush1 = Brushes.White
    End Sub

    Private Sub tmrBallTracker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBallTracker.Tick
        If AIY + 120 < Me.Height And AIX > BallX Then
            If AIY + 80 - AiRange < BallY Then
                AIY += AiSpeed
                AiBottom = True
                AiTop = False
            End If
        End If

        If AIY > 0 And AIX > BallX Then
            If AIY + AiRange > BallY + 20 Then
                AIY -= AiSpeed
                AiTop = True
                AiBottom = False
            End If
        End If
    End Sub

    Private Sub tmrOption1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOption1.Tick
        If startNotSelected = False Then


            If fontSize1 < 29 Then
                fontSize1Big = True
                fontSize1Small = False
            ElseIf fontSize1 > 35 Then
                fontSize1Small = True
                fontSize1Big = False
            End If

            If fontSize1Big = True Then
                fontSize1 += 1 / 5

            ElseIf fontSize1Small = True Then
                fontSize1 -= 1 / 5

            End If



            lblStart.Font = New Font("Rubik", fontSize1)
        ElseIf startNotSelected = True Then

            fontSize1 = 28
            lblStart.Font = New Font("Rubik", fontSize1)
            fontSize1Big = False
            fontSize1Small = False
            tmrOption1.Enabled = False
        End If

    End Sub

    Private Sub tmrOption2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOption2.Tick
        If optionsNotSelected = False Then


            If fontSize2 < 29 Then
                fontSize2Big = True
                fontSize2Small = False
            ElseIf fontSize2 > 35 Then
                fontSize2Small = True
                fontSize2Big = False
            End If

            If fontSize2Big = True Then
                fontSize2 += 1 / 5

            ElseIf fontSize2Small = True Then
                fontSize2 -= 1 / 5

            End If



            lblOptions.Font = New Font("Rubik", fontSize2)
        ElseIf optionsNotSelected = True Then

            fontSize2 = 28
            lblOptions.Font = New Font("Rubik", fontSize2)
            fontSize2Big = False
            fontSize2Small = False
            tmrOption2.Enabled = False
        End If
    End Sub

    Private Sub tmrOption3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOption3.Tick
        If exitNotSelected = False Then

            If fontSize3 < 29 Then
                fontSize3Big = True
                fontSize3Small = False
            ElseIf fontSize3 > 35 Then
                fontSize3Small = True
                fontSize3Big = False
            End If

            If fontSize3Big = True Then
                fontSize3 += 1 / 5

            ElseIf fontSize3Small = True Then
                fontSize3 -= 1 / 5

            End If



            lblExit.Font = New Font("Rubik", fontSize3)
        ElseIf exitNotSelected = True Then

            fontSize3 = 28
            lblExit.Font = New Font("Rubik", fontSize3)
            fontSize3Big = False
            fontSize3Small = False
            tmrOption3.Enabled = False
        End If
    End Sub

    Private Sub tmrArrowMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrArrowMovement.Tick
        If arrow = 1 And OptionSelect = 2 Then
            If picTriangle.Top < 289 Then
                picTriangle.Top += 20
            Else
                arrow = 2
            End If
        ElseIf arrow = 1 And OptionSelect = 3 Then
            If picTriangle.Top < 347 Then
                picTriangle.Top += 20
            Else
                arrow = 3
            End If
        ElseIf arrow = 2 And OptionSelect = 3 Then
            If picTriangle.Top < 347 Then
                picTriangle.Top += 20
            Else
                arrow = 3
            End If

        ElseIf arrow = 2 And OptionSelect = 1 Then
            If picTriangle.Top > 232 Then
                picTriangle.Top -= 20
            Else
                arrow = 1
            End If
        ElseIf arrow = 3 And OptionSelect = 1 Then
            If picTriangle.Top < 347 Then
                picTriangle.Top += 20
            Else
                arrow = 1
            End If
        ElseIf arrow = 3 And OptionSelect = 2 Then
            If picTriangle.Top > 289 Then
                picTriangle.Top -= 20
            Else
                arrow = 2
            End If
        End If
    End Sub

    Private Sub tmrPlayer2Down_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer2Down.Tick
        AiBottom = True
        AiTop = False
        AIY += speed
    End Sub

    Private Sub tmrPlayer2Up_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer2Up.Tick
        AiBottom = False
        AiTop = True
        AIY -= speed
    End Sub

End Class
