Public Class mainMenu


    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Form1.Visible = False
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Me.Dispose()
        Form1.Dispose()
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Me.Dispose()
        Form1.Visible = True
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub GunaAdvenceButton1_MouseHover(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.MouseHover
        GunaAdvenceButton1.Left = 652
    End Sub

    Private Sub GunaAdvenceButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.MouseLeave
        GunaAdvenceButton1.Left = 677
    End Sub

    Private Sub GunaAdvenceButton2_MouseHover(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.MouseHover
        GunaAdvenceButton2.Left = 652
    End Sub

    Private Sub GunaAdvenceButton3_MouseHover(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.MouseHover
        GunaAdvenceButton3.Left = 652
    End Sub

    Private Sub GunaAdvenceButton5_MouseHover(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.MouseHover
        GunaAdvenceButton5.Left = 652
    End Sub

    Private Sub GunaAdvenceButton4_MouseHover(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.MouseHover
        GunaAdvenceButton4.Left = 652
    End Sub

    Private Sub GunaAdvenceButton2_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.MouseLeave
        GunaAdvenceButton2.Left = 677
    End Sub

    Private Sub GunaAdvenceButton3_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.MouseLeave
        GunaAdvenceButton3.Left = 677
    End Sub

    Private Sub GunaAdvenceButton5_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.MouseLeave
        GunaAdvenceButton5.Left = 677
    End Sub

    Private Sub GunaAdvenceButton4_MouseLeave(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.MouseLeave
        GunaAdvenceButton4.Left = 677
    End Sub
End Class