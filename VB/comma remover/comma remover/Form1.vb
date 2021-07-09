Public Class Form1
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Dim str As String = txtNumber.Text
        Dim len As Integer = str.Length
        Dim p As Integer

        For i As Integer = 0 To len - 1
            p = str.IndexOf(",", 0)
            If p <> -1 Then
                str = str.Substring(0, p) & str.Substring(p + 1, len - p - 1)
            End If
            len -= 1
        Next

        If str = String.Empty Then
            MessageBox.Show("There is nothing in the text box")
        End If

        lblOutput.Text = str

    End Sub
End Class
