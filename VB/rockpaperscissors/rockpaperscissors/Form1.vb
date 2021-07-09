Public Class Form1

    Dim strName As String

    Private Function ComputerChoice()
        Dim rand As New Random
        Return rand.Next(3) + 1
    End Function

    Private Function WinCheck(ByVal intPlayer As Integer) As Boolean

        Dim intComp As Integer = ComputerChoice()
        Dim intWinner As Integer

        Select Case intComp
            Case 1
                lblComputer.Text = "Rock"
            Case 2
                lblComputer.Text = "Paper"
            Case 3
                lblComputer.Text = "Scissors"
        End Select

        Select Case intPlayer
            Case 1
                lblChoice.Text = "Rock"
            Case 2
                lblChoice.Text = "Paper"
            Case 3
                lblChoice.Text = "Scissors"
        End Select

        If intComp = intPlayer Then
            intWinner = 0
        End If
        If intPlayer - intComp = 1 Or intPlayer - intComp = -2 Then
            intWinner = 1
        End If
        If intComp - intPlayer = 1 Or intComp - intPlayer = -2 Then
            intWinner = 2
        End If

        Select Case intWinner
            Case 0
                MessageBox.Show("Draw!")
            Case 1
                MessageBox.Show(strName & " Wins!")
            Case 2
                MessageBox.Show("Computer Wins!")
        End Select

    End Function

    Private Sub picRock_Click(sender As Object, e As EventArgs) Handles picRock.Click
        WinCheck(1)
    End Sub

    Private Sub picPaper_Click(sender As Object, e As EventArgs) Handles picPaper.Click
        WinCheck(2)
    End Sub

    Private Sub picScissors_Click(sender As Object, e As EventArgs) Handles picScissors.Click
        WinCheck(3)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Michael Gain")
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strName = InputBox("Please Enter your name?")
    End Sub
End Class
