Public Class Form1

    Dim alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Dim plainText As String
    Dim key As String
    Dim output As String = " "
    Dim output2 As String = " "
    Dim fullKey As String = " "

    Public Sub SetVariables()

        plainText = txtInput.Text.ToUpper().Replace(" ", "").Replace(".", "").Replace(",", "").Replace("'", "")
        key = txtKey.Text.ToUpper
        fullKey = " "
        output = " "

    End Sub

    Function GetFullKey() As String

        ' Find where both letters are in the alphabet.  
        ' Find Index Of Each letter In the key, And find the index Of Each letter In the plain text. 
        ' Add them together To Get the index For the New cipher text letter. 
        ' If it Then goes over 26, Get difference And start from 0.

        Dim temp As Integer
        Dim overFlow As Integer
        Dim keyOverFlow As Integer = 0

        For i As Integer = 0 To plainText.Length() - 1 Step 1

            If i > key.Length() - 1 Then
                keyOverFlow += 1
                If keyOverFlow > key.Length() - 1 Then
                    keyOverFlow = 0
                End If
            Else
                keyOverFlow = i
            End If
            temp = alphabet.IndexOf(key(keyOverFlow)) + alphabet.IndexOf(plainText(i))
            If ((temp) >= 26) Then
                overFlow = temp - 26
                fullKey += alphabet(overFlow)
            Else
                fullKey += alphabet(temp)
            End If
        Next

        'Return alphabet(alphabet.IndexOf("A") + alphabet.IndexOf("B"))

        Return fullKey
    End Function

    Function decipher() As String

        Dim temp As Integer
        Dim overFlow As Integer
        Dim keyOverFlow As Integer = 0

        For i As Integer = 0 To plainText.Length() - 1 Step 1

            If i > key.Length() - 1 Then
                keyOverFlow += 1
                If keyOverFlow > key.Length() - 1 Then
                    keyOverFlow = 0
                End If
            Else
                keyOverFlow = i
            End If
            temp = alphabet.IndexOf(plainText(i)) - alphabet.IndexOf(key(keyOverFlow))
            If ((temp) >= 26) Then
                overFlow = temp - 26
                fullKey += alphabet(overFlow)
            ElseIf ((temp) < 0) Then
                overFlow = 26 + temp
                fullKey += alphabet(overFlow)
            Else
                fullKey += alphabet(temp)
            End If
        Next

        'Return alphabet(alphabet.IndexOf("A") + alphabet.IndexOf("B"))

        Return fullKey

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SetVariables()
        output = GetFullKey()
        lblOutput.Text = output
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetVariables()
        output2 = decipher()
        lblDecipher.Text = output2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(output)
    End Sub
End Class
