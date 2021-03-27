Public Class Form1

    Public Function CountChars(ByVal inputText As String) As Integer
        Return inputText.Length
    End Function

    Public Function CpuntWords(ByVal inputText As String) As Integer
        If (inputText = "") Then Return 0

        Dim stringWords() As String = inputText.Split(" ".ToCharArray())
        Return stringWords.Length
    End Function

    Public Sub UpdateGui()
        Dim inputText As String = txtWords.Text
        Dim outputText As String

        If (radCountWords.Checked) Then
            outputText = CountWords(inputText) & " words"
        Else
            outputText = CountChars(inputText) & " characters"
        End If
        lblOutput.Text = outputText

    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        lblOutput.Text = CountChars(txtWords.Text) & " characters"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
