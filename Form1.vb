Option Strict On
Option Explicit On

Public Class Calculator

    ' stores the current input as a string
    Private input As String = ""

    ' use Char literals for a HashSet(Of Char)
    ' this improves performance for character checks
    Private ReadOnly operators As HashSet(Of Char) = New HashSet(Of Char) From {"+"c, "-"c, "x"c, "÷"c, "*"c, "/"c}

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' no initialization needed
    End Sub

    ' handles all number and operator button clicks to append the button's text to the input string and updates the display
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click,
        btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click,
        btnadd.Click, btnsub.Click, btnmul.Click, btndiv.Click, btndot.Click

        Dim btn As Button = CType(sender, Button)
        Dim val As String = btn.Text

        ' operator check (val is single-char for operators)

        If val.Length = 1 AndAlso IsOperator(val(0)) Then
            If input.Length = 0 OrElse IsOperator(input.Chars(input.Length - 1)) Then Return
        End If

        ' prevent multiple dots in a number
        If val = "." AndAlso Not CanAddDot() Then Return

        input &= val
        txtDisplay.Text = input
    End Sub

    ' checks if a string is an operator to prevent consecutive operators
    Private Function IsOperator(ch As String) As Boolean
        Return ch.Length = 1 AndAlso operators.Contains(ch(0))
    End Function

    ' checks if a dot can be added to prevents multiple dots in a number
    Private Function CanAddDot() As Boolean
        Dim lastOperatorIndex = input.LastIndexOfAny(operators.ToArray())
        Dim lastNumber = If(lastOperatorIndex >= 0, input.Substring(lastOperatorIndex + 1), input)
        Return Not lastNumber.Contains(".")
    End Function

    ' handles the equals button click to evaluates the expression and updates the display
    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If String.IsNullOrWhiteSpace(input) Then Return

        ' crop trailing operators misalnya: "2+3+" becomes "2+3"
        While input.Length > 0 AndAlso IsOperator(input.Chars(input.Length - 1))
            input = input.Substring(0, input.Length - 1)
        End While

        If input = "" Then
            txtDisplay.Text = ""
            Return
        End If

        Dim expression As String = input.Replace("x", "*").Replace("÷", "/")

        Try
            Dim dt As New System.Data.DataTable()
            Dim rawResult As Object = dt.Compute(expression, Nothing)

            Dim resultString As String = String.Empty
            Dim dec As Decimal
            Dim rawStr As String = Convert.ToString(rawResult, System.Globalization.CultureInfo.InvariantCulture)

            ' decimal formatting when possible, remove unnecessary trailing zeros
            If Decimal.TryParse(rawStr, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, dec) Then
                resultString = dec.ToString("G29", System.Globalization.CultureInfo.InvariantCulture)
            Else
                Dim dbl As Double = Convert.ToDouble(rawResult)
                resultString = dbl.ToString(System.Globalization.CultureInfo.InvariantCulture)
            End If

            txtDisplay.Text = resultString
            input = resultString
        Catch ex As DivideByZeroException
            txtDisplay.Text = "Division by zero"
            input = ""
        Catch ex As Exception
            txtDisplay.Text = "Invalid expression"
            input = ""
        End Try
    End Sub

    ' handles the clear button click to reset the input and clears the display
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        input = ""
        txtDisplay.Clear()
    End Sub

    ' handles the delete button click to remove the last character from the input and updates the display
    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If input.Length > 0 Then
            input = input.Substring(0, input.Length - 1)
            txtDisplay.Text = input
        End If
    End Sub

End Class
