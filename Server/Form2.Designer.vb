<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.positionVal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstTurnPlayer2 = New System.Windows.Forms.Label()
        Me.firstTurnPlayer1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rollBtnP2 = New System.Windows.Forms.Button()
        Me.diceLabel = New System.Windows.Forms.Label()
        Me.valueLabel = New System.Windows.Forms.Label()
        Me.rollBtnP1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.p2pTimer = New System.Windows.Forms.Timer(Me.components)
        Me.diceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.playerTwo = New System.Windows.Forms.PictureBox()
        Me.playerOne = New System.Windows.Forms.PictureBox()
        Me.diceP1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pieceP2 = New System.Windows.Forms.PictureBox()
        Me.pieceP1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.playerTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.diceP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pieceP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pieceP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.playerTwo)
        Me.Panel3.Controls.Add(Me.playerOne)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(610, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 106)
        Me.Panel3.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.timerLabel)
        Me.Panel2.Controls.Add(Me.positionVal)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.firstTurnPlayer2)
        Me.Panel2.Controls.Add(Me.firstTurnPlayer1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.rollBtnP2)
        Me.Panel2.Controls.Add(Me.diceLabel)
        Me.Panel2.Controls.Add(Me.valueLabel)
        Me.Panel2.Controls.Add(Me.rollBtnP1)
        Me.Panel2.Controls.Add(Me.diceP1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(610, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 428)
        Me.Panel2.TabIndex = 4
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(119, 222)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(73, 10)
        Me.ProgressBar2.TabIndex = 14
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(33, 222)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(73, 10)
        Me.ProgressBar1.TabIndex = 3
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Location = New System.Drawing.Point(100, 85)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(13, 13)
        Me.timerLabel.TabIndex = 13
        Me.timerLabel.Text = "1"
        '
        'positionVal
        '
        Me.positionVal.AutoSize = True
        Me.positionVal.Location = New System.Drawing.Point(74, 270)
        Me.positionVal.Name = "positionVal"
        Me.positionVal.Size = New System.Drawing.Size(0, 13)
        Me.positionVal.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Position:"
        '
        'firstTurnPlayer2
        '
        Me.firstTurnPlayer2.AutoSize = True
        Me.firstTurnPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstTurnPlayer2.Location = New System.Drawing.Point(18, 246)
        Me.firstTurnPlayer2.Name = "firstTurnPlayer2"
        Me.firstTurnPlayer2.Size = New System.Drawing.Size(205, 20)
        Me.firstTurnPlayer2.TabIndex = 10
        Me.firstTurnPlayer2.Text = "FIRST TURN IS PLAYER 2"
        Me.firstTurnPlayer2.Visible = False
        '
        'firstTurnPlayer1
        '
        Me.firstTurnPlayer1.AutoSize = True
        Me.firstTurnPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstTurnPlayer1.Location = New System.Drawing.Point(17, 246)
        Me.firstTurnPlayer1.Name = "firstTurnPlayer1"
        Me.firstTurnPlayer1.Size = New System.Drawing.Size(205, 20)
        Me.firstTurnPlayer1.TabIndex = 9
        Me.firstTurnPlayer1.Text = "FIRST TURN IS PLAYER 1"
        Me.firstTurnPlayer1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Player 2 Turn"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Player 1 Turn"
        '
        'rollBtnP2
        '
        Me.rollBtnP2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rollBtnP2.Location = New System.Drawing.Point(118, 188)
        Me.rollBtnP2.Name = "rollBtnP2"
        Me.rollBtnP2.Size = New System.Drawing.Size(75, 35)
        Me.rollBtnP2.TabIndex = 5
        Me.rollBtnP2.Text = "Roll"
        Me.rollBtnP2.UseVisualStyleBackColor = False
        '
        'diceLabel
        '
        Me.diceLabel.AutoSize = True
        Me.diceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diceLabel.Location = New System.Drawing.Point(113, 26)
        Me.diceLabel.Name = "diceLabel"
        Me.diceLabel.Size = New System.Drawing.Size(0, 20)
        Me.diceLabel.TabIndex = 4
        '
        'valueLabel
        '
        Me.valueLabel.AutoSize = True
        Me.valueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueLabel.Location = New System.Drawing.Point(17, 27)
        Me.valueLabel.Name = "valueLabel"
        Me.valueLabel.Size = New System.Drawing.Size(90, 20)
        Me.valueLabel.TabIndex = 3
        Me.valueLabel.Text = "Dice Value:"
        '
        'rollBtnP1
        '
        Me.rollBtnP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rollBtnP1.Location = New System.Drawing.Point(32, 188)
        Me.rollBtnP1.Name = "rollBtnP1"
        Me.rollBtnP1.Size = New System.Drawing.Size(75, 35)
        Me.rollBtnP1.TabIndex = 2
        Me.rollBtnP1.Text = "Roll"
        Me.rollBtnP1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'p2pTimer
        '
        Me.p2pTimer.Interval = 10
        '
        'diceTimer
        '
        '
        'playerTwo
        '
        Me.playerTwo.BackgroundImage = Global.Server.My.Resources.Resources.p2
        Me.playerTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.playerTwo.Location = New System.Drawing.Point(132, 12)
        Me.playerTwo.Name = "playerTwo"
        Me.playerTwo.Size = New System.Drawing.Size(53, 70)
        Me.playerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.playerTwo.TabIndex = 1
        Me.playerTwo.TabStop = False
        '
        'playerOne
        '
        Me.playerOne.BackgroundImage = Global.Server.My.Resources.Resources.p1
        Me.playerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.playerOne.Location = New System.Drawing.Point(50, 12)
        Me.playerOne.Name = "playerOne"
        Me.playerOne.Size = New System.Drawing.Size(57, 70)
        Me.playerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.playerOne.TabIndex = 0
        Me.playerOne.TabStop = False
        '
        'diceP1
        '
        Me.diceP1.BackColor = System.Drawing.Color.White
        Me.diceP1.BackgroundImage = Global.Server.My.Resources.Resources._1
        Me.diceP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.diceP1.Location = New System.Drawing.Point(74, 101)
        Me.diceP1.Name = "diceP1"
        Me.diceP1.Size = New System.Drawing.Size(70, 70)
        Me.diceP1.TabIndex = 1
        Me.diceP1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Server.My.Resources.Resources.map1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pieceP2)
        Me.Panel1.Controls.Add(Me.pieceP1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 534)
        Me.Panel1.TabIndex = 1
        '
        'pieceP2
        '
        Me.pieceP2.BackColor = System.Drawing.Color.Transparent
        Me.pieceP2.BackgroundImage = Global.Server.My.Resources.Resources.p2
        Me.pieceP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pieceP2.Location = New System.Drawing.Point(36, 501)
        Me.pieceP2.Name = "pieceP2"
        Me.pieceP2.Size = New System.Drawing.Size(25, 30)
        Me.pieceP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pieceP2.TabIndex = 2
        Me.pieceP2.TabStop = False
        Me.pieceP2.Visible = False
        '
        'pieceP1
        '
        Me.pieceP1.BackColor = System.Drawing.Color.Transparent
        Me.pieceP1.BackgroundImage = Global.Server.My.Resources.Resources.p1
        Me.pieceP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pieceP1.Location = New System.Drawing.Point(4, 501)
        Me.pieceP1.Name = "pieceP1"
        Me.pieceP1.Size = New System.Drawing.Size(25, 30)
        Me.pieceP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pieceP1.TabIndex = 2
        Me.pieceP1.TabStop = False
        Me.pieceP1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 534)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.playerTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.diceP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pieceP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pieceP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pieceP2 As PictureBox
    Friend WithEvents pieceP1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents playerTwo As PictureBox
    Friend WithEvents playerOne As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents timerLabel As Label
    Friend WithEvents positionVal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstTurnPlayer2 As Label
    Friend WithEvents firstTurnPlayer1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rollBtnP2 As Button
    Friend WithEvents diceLabel As Label
    Friend WithEvents valueLabel As Label
    Friend WithEvents rollBtnP1 As Button
    Friend WithEvents diceP1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents p2pTimer As Timer
    Friend WithEvents diceTimer As Timer
End Class
