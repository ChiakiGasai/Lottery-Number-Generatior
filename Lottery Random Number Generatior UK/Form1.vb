Public Class Form1
    Private Sub clear()
        Num1.Text = "0"
        Num2.Text = "0"
        Num3.Text = "0"
        Num4.Text = "0"
        Num5.Text = "0"
        Num6.Text = "0"
        butgen.Enabled = True
        butreset.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        Randomize()
    End Sub

    Private Sub butreset_Click(sender As Object, e As EventArgs) Handles butreset.Click
        clear()

    End Sub

    Private Sub butgen_Click(sender As Object, e As EventArgs) Handles butgen.Click
        Dim i, r, tmp, numbers(60) As Integer

        For i = 1 To 59 'initialises
            numbers(i) = i
        Next

        For i = 1 To 59 'loop from 1 to 59
            r = Int(59 * Rnd()) + 1 'generates a random number between 1 and 69 (upperband, lowerband)
            numbers(i) = numbers(r) 'array pos (i) is allocated random number
        Next

        Num1.Text = numbers(1)
        Num2.Text = numbers(2)
        Num3.Text = numbers(3)
        Num4.Text = numbers(4)
        Num5.Text = numbers(5)
        Num6.Text = numbers(6)

        butgen.Enabled = False
        butreset.Enabled = True
    End Sub
End Class
