Public Class Calculator

    ' Stores the current input as a string (e.g., "12+3.4")
    Dim input As String = ""

    ' This method runs when the form loads, it does nothing for now.
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Handles all number and operator button clicks.
    ' Appends the clicked button's text to the input and updates the display.
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click,
    btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click,
    btnadd.Click, btnsub.Click, btnmul.Click, btndiv.Click, btndot.Click

        Dim btn As Button = CType(sender, Button)
        input &= btn.Text
        txtDisplay.Text = input
    End Sub

    ' Handles the equals button click.
    ' Evaluates the input string as a mathematical expression and displays the result.
    ' Uses InvariantCulture to ensure the decimal separator is a dot (.)
    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        Try
            Dim result = New DataTable().Compute(input.Replace("x", "*").Replace("÷", "/"), Nothing)
            ' Format the result using InvariantCulture to ensure dot as decimal separator
            Dim resultString As String = Convert.ToDouble(result).ToString(System.Globalization.CultureInfo.InvariantCulture)
            txtDisplay.Text = resultString
            input = resultString
        Catch ex As Exception
            txtDisplay.Text = "Error"
            input = ""
        End Try
    End Sub

    ' Handles the clear button click.
    ' Clears the input and the display.
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        input = ""
        txtDisplay.Clear()
    End Sub

    ' Handles the delete button click.
    ' Removes the last character from the input and updates the display.
    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If input.Length > 0 Then
            input = input.Substring(0, input.Length - 1)
            txtDisplay.Text = input
        End If
    End Sub

End Class
