Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.Sockets
Public Class Form2
    Dim random As Byte
    Dim scoreP1 As String
    Dim scoreP2 As String

    Dim player1 As Boolean = False
    Dim player2 As Boolean = False

    Dim flag As Boolean = False ' if false, player 1 turn

    Dim firstTurnFlag As Boolean = False

    '********************** player 1 ***************
    Dim x1 = -56, y1 = 501
    'Dim x2 = 36, y2 = 501
    Dim p = 0
    Dim dice As Integer = 0
    Dim pos(101) As Integer

    '*********************player 2 *****************
    Dim x2 = -56 + 32, y2 = 501
    Dim q = 0
    '******************* randomizer ******************
    Dim rand As Random

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rollBtnP2.Enabled = False
        'rollDiceP1()
        'Timer1.Start()
        snakeBites(p, x1, y1, pieceP1)
        ladder(p, x1, y1, pieceP1)
        snakeBites(q, x2, y2, pieceP2)
        ladder(q, x2, y2, pieceP2)
    End Sub
    '**************receiving move *****************
    Private Sub rollBtnP1_Click(sender As Object, e As EventArgs) Handles rollBtnP1.Click
        'diceTimer.Start()

        rollDiceP1()

        'scoreP1 = random
        playerTwo.Visible = True
        'rollBtnP1.Enabled = False
        'rollBtnP2.Enabled = True
        'Label1.Visible = False
        'Label2.Visible = True

        If (player1 = True) Then
            'x1 += 60
            'pieceP1.Location = New Point(x1, y1)
            'stepLimiter()
            Mover(p, x1, y1, pieceP1)

        End If
        If (diceLabel.Text = "6" AndAlso player1 = False) Then
            pieceP1.Visible = True
            playerOne.Visible = False

            'pieceP1.Location = New Point(x1, y1)

            player1 = True
            'p += 1
            'pos(p) = 1
        End If
        snakeBites(p, x1, y1, pieceP1)
        ladder(p, x1, y1, pieceP1)
    End Sub

    Private Sub rollBtnP2_Click(sender As Object, e As EventArgs) Handles rollBtnP2.Click
        rollDiceP1()

        scoreP2 = random
        pieceP2.Visible = True

        playerOne.Visible = True
        playerTwo.Visible = False
        'rollBtnP1.Enabled = True
        'rollBtnP2.Enabled = False
        ' Label1.Visible = True
        'Label2.Visible = False
        'pieceP2.Location = New Point(x2, y2)

        'firstMove()
        '********************************

        If (player2 = True) Then
            'x1 += 60
            'pieceP1.Location = New Point(x1, y1)
            'stepLimiter()
            Mover(q, x2, y2, pieceP2)

        End If
        If (diceLabel.Text = "6" AndAlso player2 = False) Then
            pieceP2.Visible = True
            playerTwo.Visible = False

            'pieceP1.Location = New Point(x1, y1)

            player2 = True
            'p += 1
            'pos(p) = 1
        End If
        snakeBites(q, x2, y2, pieceP2)
        ladder(q, x2, y2, pieceP2)
    End Sub
    Private Sub rollDiceP1()
        Randomize()
        random = (Rnd() * 5) + 1
        dice = random
        diceP1.Image = My.Resources.ResourceManager.GetObject("_" & random)
        diceP1.SizeMode = PictureBoxSizeMode.StretchImage
        diceLabel.Text = random.ToString
        'diceTimer.Start()

    End Sub

    Private Sub Mover(ByRef p As Integer, ByRef x1 As Integer, ByRef y1 As Integer, ByRef pieceP1 As PictureBox)

        If ((dice + p) > 100) Then
            Return
        End If

        If (dice + p) = 100 Then

            x1 += 60 * dice
            pieceP1.Location = New Point(x1, y1)
            p += 1 * dice
            pos(p) = 1
            positionVal.Text = p.ToString
            MsgBox("You win", MsgBoxStyle.OkOnly, "Congratulations")
            rollBtnP1.Enabled = False
            rollBtnP2.Enabled = False

            Return
        End If

        For i As Integer = 1 To dice

            If p = 10 Then
                x1 = 4
                y1 = 447
            ElseIf p = 20 Then
                x1 = 4
                y1 = 393
            ElseIf p = 30 Then
                x1 = 4
                y1 = 339
            ElseIf p = 40 Then
                x1 = 4
                y1 = 285
            ElseIf p = 50 Then
                x1 = 4
                y1 = 231
            ElseIf p = 60 Then
                x1 = 4
                y1 = 177
            ElseIf p = 70 Then
                x1 = 4
                y1 = 123
            ElseIf p = 80 Then
                x1 = 4
                y1 = 69
            ElseIf p = 90 Then
                x1 = 4
                y1 = 15

            Else
                x1 = x1 + 60

            End If
            pieceP1.Location = New Point(x1, y1)
            p += 1
            pos(p) = 1
            positionVal.Text = p.ToString

        Next
    End Sub
    ' ****************************** FOR SNAKES **************************************
    Private Sub snakeBites(ByRef p As Integer, ByRef x1 As Integer, ByRef y1 As Integer, ByRef pieceP1 As PictureBox)

        If p = 25 Then
            x1 = 244
            y1 = 501
            p = 5

        ElseIf p = 34 Then
            x1 = 4
            y1 = 501
            p = 1
        ElseIf p = 47 Then
            x1 = 484
            y1 = 447
            p = 19
        ElseIf p = 65 Then
            x1 = 64
            y1 = 231
            p = 52
        ElseIf p = 87 Then
            x1 = 364
            y1 = 231
            p = 57
        ElseIf p = 91 Then
            x1 = 4
            y1 = 177
            p = 61
        ElseIf p = 99 Then
            x1 = 484
            y1 = 177
            p = 69
        End If
        pieceP1.Location = New Point(x1, y1)
        positionVal.Text = p.ToString
        '*********************************************************************************
    End Sub



    Private Sub ladder(ByRef p As Integer, ByRef x1 As Integer, ByRef y1 As Integer, ByRef pieceP1 As PictureBox)

        ' ****************************** FOR LADDER **************************************
        If p = 3 Then
            x1 = 4
            y1 = 231
            p = 51
        ElseIf p = 6 Then
            x1 = 364
            y1 = 393
            p = 27
        ElseIf p = 20 Then
            x1 = 544
            y1 = 177
            p = 70
        ElseIf p = 36 Then
            x1 = 244
            y1 = 231
            p = 55
        ElseIf p = 63 Then
            x1 = 244
            y1 = 20
            p = 95
        ElseIf p = 68 Then
            x1 = 424
            y1 = 20
            p = 98
        End If
        pieceP1.Location = New Point(x1, y1)
        positionVal.Text = p.ToString
        '*********************************************************************************

    End Sub



    Private Sub receiveMove()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'diceP1.Image = My.Resources.ResourceManager.GetObject("_" & r.Next(1, 6))
        'diceP1.SizeMode = PictureBoxSizeMode.StretchImage

        timerLabel.Text += 1
        If (timerLabel.Text = 10) Then
            Timer1.Stop()
            timerLabel.Text = 1
        End If
    End Sub



    Private Sub p2pTimer_Tick(sender As Object, e As EventArgs) Handles p2pTimer.Tick

    End Sub

    Private Sub firstMove()

        If (scoreP1 > scoreP2) Then
            'Label1.Visible = False
            rollBtnP1.Enabled = True
            rollBtnP2.Enabled = False
            firstTurnPlayer1.Visible = True
            player1 = True
        ElseIf (scoreP1 = scoreP2) Then
            rollBtnP1.Enabled = True
            rollBtnP2.Enabled = False
        Else
            'Label2.Visible = False
            rollBtnP1.Enabled = False
            rollBtnP2.Enabled = True
            firstTurnPlayer2.Visible = True
            player2 = True
        End If

    End Sub

    Private Sub diceTimer_Tick(sender As Object, e As EventArgs) Handles diceTimer.Tick
        rand = New Random
        ProgressBar1.Increment(10)

        If (ProgressBar1.Value = 100) Then
            diceTimer.Stop()
            ProgressBar1.Value = 0
        Else
            dice = rand.Next(1, 7)

            diceP1.Image = My.Resources.ResourceManager.GetObject("_" & dice)
            diceP1.SizeMode = PictureBoxSizeMode.StretchImage
            diceLabel.Text = dice.ToString
        End If
    End Sub

    '********* if theres a winner, may fireworks
    '********* every ladder or snake, may llabas na label or sound effect
    '********* pwede paltan ung pieces tska map
    '********* lalagyan ng name ung player 1 at player 2. para sa history
    '********* may rules, may info ng devs, may 
End Class