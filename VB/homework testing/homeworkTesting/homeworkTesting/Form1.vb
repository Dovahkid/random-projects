Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sngSpeed As Single = 400

        If "cat" > "cb" Then
            MessageBox.Show("Cat big")
        Else
            MessageBox.Show("Cat not big")
        End If

    End Sub
End Class
