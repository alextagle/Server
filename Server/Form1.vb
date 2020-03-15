Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class Form1
    'Dim game As New Form2
    Dim loadingscreen As New loadingScreen
    '' Dim menu As New mainMenu
    Dim ServerStatus As Boolean = False
    Dim ServerTrying As Boolean = False
    Dim Server As TcpListener
    Dim Clients As New List(Of TcpClient)

    '********************************************************
    Dim random As Byte
    Dim scoreP1 As String
    Dim scoreP2 As String

    Dim player1 As Boolean = True
    Dim player2 As Boolean = True

    Private flag As Boolean = False ' if false, player 1 turn

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        loadingscreen.ShowDialog()
        'menu.ShowDialog()
        'Me.Dispose()
        '***********


        RollBtnP1.Enabled = False
        rollBtnP2.Enabled = False


        'rollBtnP2.Enabled = False
        'rollDiceP1()
        'Timer1.Start()
        snakeBites(p, x1, y1, pieceP1)
        ladder(p, x1, y1, pieceP1)
        snakeBites2()
        ladder2()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        StartServer()
    End Sub

    Function StartServer()

        If ServerStatus = False Then
            ServerTrying = True
            Try
                Server = New TcpListener(IPAddress.Any, 63861)
                Server.Start()
                Button1.Text = "Started"
                Button2.Text = "Stop"
                ServerStatus = True
                Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)


            Catch ex As Exception
                ServerStatus = False
            End Try
            ServerTrying = False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        StopServer()
    End Sub
    Function StopServer()
        Button2.Text = "Stopped"
        Button1.Text = "Start"
        RollBtnP1.Enabled = False
        rollBtnP2.Enabled = False

        If ServerStatus = True Then
            ServerTrying = True
            Try
                For Each Client As TcpClient In Clients
                    Client.Close()
                Next
                Server.Stop()
                ServerStatus = False
            Catch ex As Exception
                StopServer()
            End Try
            ServerTrying = False
        End If
        Return True
    End Function
    Function Handler_Client(ByVal state As Object)
        Dim TempClient As TcpClient

        Try
            Using Client As TcpClient = Server.AcceptTcpClient
                Console.Beep()

                RollBtnP1.Enabled = True

                If ServerTrying = False Then
                    Threading.ThreadPool.QueueUserWorkItem(AddressOf Handler_Client)
                End If

                Clients.Add(Client)
                TempClient = Client

                Dim TX As New StreamWriter(Client.GetStream)
                Dim RX As New StreamReader(Client.GetStream)
                Try
                    If RX.BaseStream.CanRead = True Then
                        While RX.BaseStream.CanRead = True
                            Dim RawData As String = RX.ReadLine

                            If Client.Client.Connected = True AndAlso Client.Connected = True AndAlso Client.GetStream.CanRead = True Then


                                'received data from client

                                diceP1.Image = My.Resources.ResourceManager.GetObject("_" & RawData)
                                diceLabel.Text = RawData
                                dice = RawData

                                TextBox2.Text = dice
                                diceP1.SizeMode = PictureBoxSizeMode.StretchImage

                                prevVal2.Text = positionVal2.Text

                                'rollDiceP1()

                                'scoreP2 = random
                                'pieceP2.Visible = True

                                'playerOne.Visible = True
                                '  playerTwo.Visible = False
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
                                    'Mover(q, x2, y2, pieceP2)
                                    Mover2()

                                End If
                                    If (diceLabel.Text = "6" AndAlso player2 = False) Then

                                    pieceP2.Visible = True
                                    '    playerTwo.Visible = False

                                    'pieceP1.Location = New Point(x1, y1)

                                    player2 = True
                                        'p += 1
                                        'pos(p) = 1
                                    End If
                                    'snakeBites(q, x2, y2, pieceP2)
                                    'ladder(q, x2, y2, pieceP2)
                                    snakeBites2()
                                    ladder2()


                                    REM For some reason this seems to stop the comon tcp connection bug vvv
                                    Dim RawDataLength As String = RawData.Length.ToString
                                REM ^^^^ Comment it out and test it in your own projects. Mine might be the only stupid one.
                                ''''RichTextBox1.Text += Client.Client.RemoteEndPoint.ToString + ">>" + RawData + vbNewLine



                            Else Exit While
                            End If
                        End While
                    End If
                Catch ex As Exception
                    If Clients.Contains(Client) Then
                        Clients.Remove(Client)
                        Client.Close()
                    End If

                End Try


                ''   If RX.BaseStream.CanRead = False Then
                ''   Client.Close()
                ''   Clients.Remove(Client)
                ''   End If
                ''   Console.Beep()
            End Using
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
                TempClient.Close()
            End If
        Catch ex As Exception
            If Clients.Contains(TempClient) Then
                Clients.Remove(TempClient)
                TempClient.Close()
            End If
        End Try

        Return True
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, TextBox1.Text)
    End Sub
    Function SendToClients(ByVal Data As String)
        If ServerStatus = True Then
            If Clients.Count > 0 Then
                Try
                    REM  Broadcast data to all clients
                    REM To target one client,
                    REM USAGE: If client.client.remoteendpoint.tostring.contains(IP As String) Then
                    REM I am sorry for the lack of preparation for this project and in the video.
                    REM I wrote 99% of this from the top of my head,  no one is perfect, bound to make mistakes.
                    For Each Client As TcpClient In Clients
                        Dim TX1 As New StreamWriter(Client.GetStream)
                        ''   Dim RX1 As New StreamReader(Client.GetStream)
                        TX1.WriteLine(Data)
                        TX1.Flush()
                    Next
                Catch ex As Exception
                    SendToClients(Data)
                End Try
            End If
        End If
        Return True
    End Function
    REM   Timer1 enabled = true
    REM Just if you want to always have a count of connected clients.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Clients.Count.ToString
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        StartServer()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        StopServer()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, TextBox1.Text)
    End Sub


    ' ***************************************************************************************************************

    Private Sub RollBtnP1_Click(sender As Object, e As EventArgs) Handles RollBtnP1.Click

        'btnSound()
        'diceTimer.Start()
        'Timer2.Start()
        rollDiceP1()

        RollBtnP1.Enabled = False
        rollBtnP2.Enabled = True
        Label2.Visible = False

        'passing this data to client 
        TextBox1.Text = diceLabel.Text
        Threading.ThreadPool.QueueUserWorkItem(AddressOf SendToClients, TextBox1.Text)


        'scoreP1 = random
        ' playerTwo.Visible = True

        'rollBtnP2.Enabled = True
        'Label1.Visible = False
        'Label2.Visible = True

        If (player1 = True) Then
            pieceP1.Visible = True
            'x1 += 60
            'pieceP1.Location = New Point(x1, y1)
            'stepLimiter()
            Mover(p, x1, y1, pieceP1)

        End If
        If (diceLabel.Text = 6 AndAlso player1 = False) Then
            pieceP1.Visible = True
            '             playerOne.Visible = False

            'pieceP1.Location = New Point(x1, y1)

            player1 = True
            'p += 1
            'pos(p) = 1
        End If
        snakeBites(p, x1, y1, pieceP1)
        ladder(p, x1, y1, pieceP1)
    End Sub

    Private Sub rollBtnP2_Click(sender As Object, e As EventArgs) Handles rollBtnP2.Click
        'rollDiceP2()
        'RollBtnP1.Enabled = True
        ''scoreP2 = random
        'pieceP2.Visible = True

        ''  playerOne.Visible = True
        '' playerTwo.Visible = False
        ''rollBtnP1.Enabled = True
        ''rollBtnP2.Enabled = False
        '' Label1.Visible = True
        ''Label2.Visible = False
        ''pieceP2.Location = New Point(x2, y2)

        ''firstMove()
        ''********************************

        'If (player2 = True) Then
        '    'x1 += 60
        '    'pieceP1.Location = New Point(x1, y1)
        '    'stepLimiter()
        '    ' Mover(q, x2, y2, pieceP2)
        '    Mover2()


        'End If
        'If (diceLabel.Text = "6" AndAlso player2 = False) Then
        '    pieceP2.Visible = True
        '    '     playerTwo.Visible = False

        '    'pieceP1.Location = New Point(x1, y1)

        '    player2 = True
        '    'p += 1
        '    'pos(p) = 1
        'End If
        ''snakeBites(q, x2, y2, pieceP2)
        ''ladder(q, x2, y2, pieceP2)
        'snakeBites2()
        'ladder2()

    End Sub
    Private Sub rollDiceP1()
        Randomize()
        random = (Rnd() * 5) + 1
        dice = random
        diceP1.Image = My.Resources.ResourceManager.GetObject("_" & random)
        diceP1.SizeMode = PictureBoxSizeMode.StretchImage
        diceLabel.Text = random.ToString
        'diceTimer.Start()

        prevVal.Text = positionVal.Text
        ' Timer2.Start()
        ' Timer2.Start()
    End Sub
    Private Sub rollDiceP2()
        Randomize()
        random = (Rnd() * 5) + 1
        dice = random
        diceP1.Image = My.Resources.ResourceManager.GetObject("_" & random)
        diceP1.SizeMode = PictureBoxSizeMode.StretchImage
        diceLabel.Text = random.ToString
        'diceTimer.Start()

        prevVal2.Text = positionVal2.Text

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
            RollBtnP1.Enabled = False
            rollBtnP2.Enabled = False

            Return
        End If

        For i As Integer = 1 To dice

            If p = 10 Then
                'x1 = 114
                'y1 = 446
                'pieceP1.Location = New Point(x1, y1)
                'Threading.Thread.Sleep(2000)
                'x1 = 89
                'y1 = 385
                'pieceP1.Location = New Point(x1, y1)
                'Threading.Thread.Sleep(2000)
                'x1 = 66
                'y1 = 329
                'pieceP1.Location = New Point(x1, y1)
                'Threading.Thread.Sleep(2000)
                'x1 = 45
                'y1 = 278
                'pieceP1.Location = New Point(x1, y1)
                'Threading.Thread.Sleep(2000)
                wait(500)
                x1 = 4
                y1 = 447

            ElseIf p = 20 Then
                wait(500)
                x1 = 4
                y1 = 393
            ElseIf p = 30 Then
                wait(500)
                x1 = 4
                y1 = 339
            ElseIf p = 40 Then
                wait(500)
                x1 = 4
                y1 = 285
            ElseIf p = 50 Then
                wait(500)
                x1 = 4
                y1 = 231
            ElseIf p = 60 Then
                wait(500)
                x1 = 4
                y1 = 177
            ElseIf p = 70 Then
                wait(500)
                x1 = 4
                y1 = 123
            ElseIf p = 80 Then
                wait(500)
                x1 = 4
                y1 = 69
            ElseIf p = 90 Then
                wait(500)
                x1 = 4
                y1 = 15

            Else
                wait(500)
                x1 = x1 + 60

            End If
            pieceP1.Location = New Point(x1, y1)
            p += 1
            'pos(p) = 1
            positionVal.Text = p.ToString

        Next
    End Sub
    ' ****************************** FOR SNAKES **************************************
    Private Sub snakeBites(ByRef p As Integer, ByRef x1 As Integer, ByRef y1 As Integer, ByRef pieceP1 As PictureBox)

        If p = 25 Then
            wait(500)
            x1 = 244
            y1 = 501
            p = 5

        ElseIf p = 34 Then
            wait(500)
            x1 = 4
            y1 = 501
            p = 1
        ElseIf p = 47 Then
            wait(500)
            x1 = 484
            y1 = 447
            p = 19
        ElseIf p = 65 Then
            wait(500)
            x1 = 64
            y1 = 231
            p = 52
        ElseIf p = 87 Then
            wait(500)
            x1 = 364
            y1 = 231
            p = 57
        ElseIf p = 91 Then
            wait(500)
            x1 = 4
            y1 = 177
            p = 61
        ElseIf p = 99 Then
            wait(500)
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
            wait(500)
            x1 = 4
            y1 = 231
            p = 51
        ElseIf p = 6 Then
            wait(500)
            x1 = 364
            y1 = 393
            p = 27
        ElseIf p = 20 Then
            wait(500)
            x1 = 544
            y1 = 177
            p = 70
        ElseIf p = 36 Then
            wait(500)
            x1 = 244
            y1 = 231
            p = 55
        ElseIf p = 63 Then
            wait(500)
            x1 = 244
            y1 = 20
            p = 95
        ElseIf p = 68 Then
            wait(500)
            x1 = 424
            y1 = 20
            p = 98
        End If
        pieceP1.Location = New Point(x1, y1)
        positionVal.Text = p.ToString
        '*********************************************************************************

    End Sub

    Private Sub Mover2()

        If ((dice + q) > 100) Then
            Return
        End If

        If (dice + q) = 100 Then

            x2 += 60 * dice
            pieceP2.Location = New Point(x2, y2)
            q += 1 * dice
            pos(q) = 1
            positionVal2.Text = q.ToString
            MsgBox("You Lost!", MsgBoxStyle.OkOnly, "Defeated")
            RollBtnP1.Enabled = False
            rollBtnP2.Enabled = False

            Return
        End If

        For i As Integer = 1 To dice

            If q = 10 Then
                wait(500)
                x2 = 4 + 32
                y2 = 447
            ElseIf q = 20 Then
                wait(500)
                x2 = 4 + 32
                y2 = 393
            ElseIf q = 30 Then
                wait(500)
                x2 = 4 + 32
                y2 = 339
            ElseIf q = 40 Then
                wait(500)
                x2 = 4 + 32
                y2 = 285
            ElseIf q = 50 Then
                wait(500)
                x2 = 4 + 32
                y2 = 231
            ElseIf q = 60 Then
                wait(500)
                x2 = 4 + 32
                y2 = 177
            ElseIf q = 70 Then
                wait(500)
                x2 = 4 + 32
                y2 = 123
            ElseIf q = 80 Then
                wait(500)
                x2 = 4 + 32
                y2 = 69
            ElseIf q = 90 Then
                wait(500)
                x2 = 4 + 32
                y2 = 15

            Else
                wait(500)
                x2 = x2 + 60

            End If
            pieceP2.Location = New Point(x2, y2)
            q += 1
            ' pos(q) = 1
            positionVal2.Text = q.ToString

        Next
    End Sub
    ' ****************************** FOR SNAKES **************************************
    Private Sub snakeBites2()

        If q = 25 Then
            wait(500)
            x2 = 244 + 32
            y2 = 501
            p = 5

        ElseIf q = 34 Then
            wait(500)
            x2 = 4 + 32
            y2 = 501
            q = 1
        ElseIf q = 47 Then
            wait(500)
            x2 = 484 + 32
            y2 = 447
            q = 19
        ElseIf q = 65 Then
            wait(500)
            x2 = 64 + 32
            y2 = 231
            q = 52
        ElseIf q = 87 Then
            wait(500)
            x2 = 364 + 32
            y2 = 231
            q = 57
        ElseIf q = 91 Then
            wait(500)
            x2 = 4 + 32
            y2 = 177
            q = 61
        ElseIf q = 99 Then
            wait(500)
            x2 = 484 + 32
            y2 = 177
            q = 69
        End If
        pieceP1.Location = New Point(x1, y1)
        positionVal.Text = p.ToString
        '*********************************************************************************
    End Sub

    Private Sub positionVal2_TextChanged(sender As Object, e As EventArgs)
        RollBtnP1.Enabled = True
        rollBtnP2.Enabled = False
    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    '    'dice = random
    '    'rand = New Random
    '    Randomize()
    '    random = (Rnd() * 5) + 1
    '    ProgressBar1.Increment(5)
    '    If ProgressBar1.Value = 100 Then
    '        Timer1.Stop()
    '        If dice = 1 Then
    '            diceP1.Image = My.Resources._1
    '        End If
    '        If dice = 2 Then
    '            diceP1.Image = My.Resources._2
    '        End If
    '        If dice = 3 Then
    '            diceP1.Image = My.Resources._3
    '        End If
    '        If dice = 4 Then
    '            diceP1.Image = My.Resources._4
    '        End If
    '        If dice = 5 Then
    '            diceP1.Image = My.Resources._5
    '        End If
    '        If dice = 6 Then
    '            diceP1.Image = My.Resources._6
    '        End If
    '        Mover(p, x1, y1, pieceP1)
    '    Else

    '        'rollDiceP1()
    '        dice = random
    '        diceP1.Image = My.Resources.ResourceManager.GetObject("_" & dice)
    '        diceP1.SizeMode = PictureBoxSizeMode.StretchImage
    '        diceLabel.Text = random.ToString


    '        prevVal2.Text = positionVal2.Text



    '    End If
    'End Sub

    Private Sub ladder2()

        ' ****************************** FOR LADDER **************************************
        If q = 3 Then
            wait(500)
            x2 = 4 + 32
            y2 = 231
            q = 51
        ElseIf q = 6 Then
            wait(500)
            x2 = 364 + 32
            y2 = 393
            q = 27
        ElseIf q = 20 Then
            wait(500)
            x2 = 544 + 32
            y2 = 177
            q = 70
        ElseIf q = 36 Then
            wait(500)
            x2 = 244 + 32
            y2 = 231
            q = 55
        ElseIf q = 63 Then
            wait(500)
            x2 = 244 + 32
            y2 = 20
            q = 95
        ElseIf q = 68 Then
            wait(500)
            x2 = 424 + 32
            y2 = 20
            q = 98
        End If
        pieceP2.Location = New Point(x2, y2)
        positionVal2.Text = q.ToString
        ' *********************************************************************************

    End Sub

    Private Sub receiveMove()

    End Sub

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval

            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub btnSound()
        Dim path As String
        Dim sound As Media.SoundPlayer
        path = "C:\Users\ronaricci\source\repos\Server\Server\Resources\mouseClick.mp3"
        sound = New Media.SoundPlayer(path)
        sound.Play()
    End Sub

    '****************************************************************************************************************************
    '*************************************************************************************************************************************
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Panel4.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = False
        RichTextBox2.Visible = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        RichTextBox2.Visible = False
        GroupBox1.Visible = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Panel4.Visible = False
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Visible = False
        RichTextBox2.Visible = True
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        RichTextBox2.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Panel4.Visible = True
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        '********************** player 1 ***************
        x1 = -56
        y1 = 501
        pieceP1.Location = New Point(x1, y1)
        'Dim x2 = 36, y2 = 501
        p = 0
        dice = 0


        '*********************player 2 *****************
        x2 = -56 + 32
        y2 = 501
        pieceP2.Location = New Point(x2, y2)
        q = 0
        '******************* randomizer ******************

        positionVal.Text = 0
        positionVal2.Text = 0

        prevVal.Text = ""
        prevVal2.Text = ""
        StopServer()

        Button1.Text = "Start"
        Button2.Text = "Stop"

        wait(500)
        Panel4.Visible = True

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        RollBtnP1.Enabled = True
        rollBtnP2.Enabled = False
    End Sub

    Private Sub positionVal2_TextChanged_1(sender As Object, e As EventArgs) Handles positionVal2.TextChanged
        RollBtnP1.Enabled = True
        rollBtnP2.Enabled = False
        Label2.Visible = True
    End Sub
End Class