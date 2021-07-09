'Im sorry future me... this code is pretty gross... but I (current me, Time 9:39 PM on 1/31/19) understands it all

Public Class Form1

    Dim key As String
    Dim alphabet As String
    Dim output As String = " "
    Dim vigOutput As String = " "
    Dim plainText As String

    Dim encOrDec As Integer

    Dim normOrVig As Integer = 1

    Public Sub SetVariables()

        If normOrVig = 1 Then

            alphabet = txtAlphabet.Text
            key = txtKey.Text

        ElseIf normOrVig = 0 Then

            key = txtKey.Text.ToUpper
            txtAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            alphabet = txtAlphabet.Text
            vigOutput = " "

        End If

    End Sub

    ' Start of Vignere

    'Checks if there is a number in the vignere key. if it does it returns true
    Function ContainsNumbers() As Boolean
        Dim numbers As String = "0123456789"
        For j As Integer = 0 To numbers.Length() - 1 Step 1
            For i As Integer = 0 To txtKey.Text.Length() - 1 Step 1
                If txtKey.Text(i) = numbers(j) Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Public Sub VigEncode()

        output = " "
        vigOutput = " "
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
                vigOutput += alphabet(overFlow)
            Else
                vigOutput += alphabet(temp)
            End If
        Next

        output = vigOutput
        lblOutput.Text = output

    End Sub

    ' Decipher does the backwards of the encoding
    Public Sub VigDecipher()

        output = " "
        vigOutput = " "

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
                vigOutput += alphabet(overFlow)
            ElseIf ((temp) < 0) Then
                overFlow = 26 + temp
                vigOutput += alphabet(overFlow)
            Else
                vigOutput += alphabet(temp)
            End If
        Next

        output = vigOutput
        lblOutput.Text = output

    End Sub

    ' End of Vignere

    ' Swap/Rotate Cipher Encode
    Public Sub NormEncode()
        Dim inputText As String = txtInput.Text
        output = " "

        For i As Integer = 0 To inputText.Length() - 1
            For j As Integer = 0 To alphabet.Length() - 1

                If inputText(0 + i) = alphabet(0 + j) Then
                    output += key(0 + j)
                End If

            Next
        Next

        lblOutput.Text = output
    End Sub

    ' Swap/Rotate Cipher encode
    Public Sub NormDecode()
        Dim inputText As String = txtInput.Text
        output = " "

        For i As Integer = 0 To inputText.Length() - 1
            For j As Integer = 0 To key.Length() - 1

                If inputText(0 + i) = key(0 + j) Then
                    output += alphabet(0 + j)
                End If
            Next
        Next

        lblOutput.Text = output
    End Sub

    Private Sub btnEncDec_Click(sender As Object, e As EventArgs) Handles btnEncDec.Click

        plainText = txtInput.Text.ToUpper().Replace(" ", "").Replace(".", "").Replace(",", "").Replace("'", "")

        If encOrDec = 1 Then
            If normOrVig = 1 Then
                NormEncode()
            ElseIf normOrVig = 0 Then

                vigEncode()
            End If
        ElseIf encOrDec = 0 Then
            If normOrVig = 1 Then
                NormDecode()
            ElseIf normOrVig = 0 Then
                VigDecipher()
            End If
        End If

    End Sub

    Private Sub radEncrypt_CheckedChanged(sender As Object, e As EventArgs) Handles radEncrypt.CheckedChanged
        encOrDec = 1
        btnEncDec.Text = "Encrypt"
    End Sub

    Private Sub radDecrypt_CheckedChanged(sender As Object, e As EventArgs) Handles radDecrypt.CheckedChanged
        encOrDec = 0
        btnEncDec.Text = "Decrypt"
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        SetVariables()

        If normOrVig = 1 Then

            If (alphabet.Length() > key.Length()) Or (alphabet.Length() < key.Length()) Then
                MessageBox.Show("The key and alphabet must be equal length!")
            Else
                btnEncDec.Visible = True
            End If

        ElseIf normOrVig = 0 Then

            If txtKey.Text = "" Or txtKey.Text = " " Then
                MessageBox.Show("The key cannot be empty!")
            ElseIf ContainsNumbers() Then
                MessageBox.Show("The key cannot contain numbers!")
            ElseIf txtAlphabet.Text IsNot "ABCDEFGHIJKLMNOPQRSTUVWXYZ" Then
                txtAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                btnEncDec.Visible = True
            Else
                btnEncDec.Visible = True
            End If

        End If

    End Sub

    Private Sub txtKey_TextChanged(sender As Object, e As EventArgs) Handles txtKey.TextChanged
        btnEncDec.Visible = False
    End Sub

    Private Sub txtAlphabet_Clicked(sender As Object, e As EventArgs) Handles txtAlphabet.Click ' This is the text change event for the Alphabet entry box. If someone clicks and changes something, I need to remove the encrypt/decrypt button to ensure they didnt enter invalid characters
        btnEncDec.Visible = False

        If normOrVig = 0 Then
            MessageBox.Show("You cannot edit the alphabet in Vigenere!")
            txtAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If
    End Sub

    Private Sub txtAlphabet_TextChanged(sender As Object, e As EventArgs) Handles txtAlphabet.TextChanged
        btnEncDec.Visible = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click ' This is the click event for the reset button. Sets the alphabet and key back to its default incase someone screws up their entry somehow

        If normOrVig = 1 Then

            txtAlphabet.Text = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
            txtKey.Text = "0987654321 QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm"

        ElseIf normOrVig = 0 Then
            txtAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            txtKey.Text = ""
        End If
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click 'Click event for "copy to clipboard button" pretty self explanatory
        Clipboard.SetText(output)
    End Sub

    Private Sub radNormal_CheckedChanged(sender As Object, e As EventArgs) Handles radNormal.CheckedChanged
        normOrVig = 1
        txtAlphabet.Text = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"
        txtKey.Text = "0987654321 QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm"
        txtAlphabet.ReadOnly = False
    End Sub

    Private Sub radVigenere_CheckedChanged(sender As Object, e As EventArgs) Handles radVigenere.CheckedChanged
        normOrVig = 0
        txtAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        txtKey.Text = ""
        txtAlphabet.ReadOnly = True
    End Sub
End Class
