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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.positionVal2 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.positionVal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rollBtnP2 = New System.Windows.Forms.Button()
        Me.diceLabel = New System.Windows.Forms.Label()
        Me.valueLabel = New System.Windows.Forms.Label()
        Me.rollBtnP1 = New System.Windows.Forms.Button()
        Me.diceP1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pieceP2 = New System.Windows.Forms.PictureBox()
        Me.pieceP1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.diceP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pieceP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pieceP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(-1, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 428)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.positionVal2)
        Me.Panel3.Controls.Add(Me.ProgressBar2)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.timerLabel)
        Me.Panel3.Controls.Add(Me.positionVal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.rollBtnP2)
        Me.Panel3.Controls.Add(Me.diceLabel)
        Me.Panel3.Controls.Add(Me.valueLabel)
        Me.Panel3.Controls.Add(Me.rollBtnP1)
        Me.Panel3.Controls.Add(Me.diceP1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 290)
        Me.Panel3.TabIndex = 13
        '
        'positionVal2
        '
        Me.positionVal2.AutoSize = True
        Me.positionVal2.Location = New System.Drawing.Point(74, 273)
        Me.positionVal2.Name = "positionVal2"
        Me.positionVal2.Size = New System.Drawing.Size(0, 13)
        Me.positionVal2.TabIndex = 17
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
        Me.positionVal.Location = New System.Drawing.Point(74, 247)
        Me.positionVal.Name = "positionVal"
        Me.positionVal.Size = New System.Drawing.Size(0, 13)
        Me.positionVal.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Position:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Position:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Player 1 Turn"
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
        Me.diceLabel.Size = New System.Drawing.Size(18, 20)
        Me.diceLabel.TabIndex = 4
        Me.diceLabel.Text = "1"
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 11
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, -28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(232, 134)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(166, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Send"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Server.My.Resources.Resources.map1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.pieceP2)
        Me.Panel1.Controls.Add(Me.pieceP1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(235, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 535)
        Me.Panel1.TabIndex = 14
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
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 535)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.diceP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pieceP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pieceP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pieceP2 As PictureBox
    Friend WithEvents pieceP1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents timerLabel As Label
    Friend WithEvents positionVal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rollBtnP2 As Button
    Friend WithEvents diceLabel As Label
    Friend WithEvents valueLabel As Label
    Friend WithEvents rollBtnP1 As Button
    Friend WithEvents diceP1 As PictureBox
    Friend WithEvents positionVal2 As Label
    Friend WithEvents Label5 As Label
End Class
