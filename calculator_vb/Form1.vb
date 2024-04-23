Public Class Form1

    Dim firstValue As Double
    Dim secondValue As Double
    Dim result As Double
    Dim op As String



    Private Sub NumberClick(sender As Object, e As EventArgs) Handles Btn9.Click, Button8.Click, btn7.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn1.Click, Btn2.Click, Btn3.Click, BtnDotOperator.Click, Btn0.Click
        Dim b As Button = sender

        If (TxtDisplay.Text = "0") Then
            TxtDisplay.Text = ""
            TxtDisplay.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not TxtDisplay.Text.Contains(".")) Then
                TxtDisplay.Text = TxtDisplay.Text + b.Text
            End If
        Else
            TxtDisplay.Text = TxtDisplay.Text + b.Text

        End If

    End Sub

    Private Sub Backspace_Click(sender As Object, e As EventArgs) Handles BtnBackspace.Click
        If (TxtDisplay.Text.Length = 1) Then
            TxtDisplay.Text = "0"

        ElseIf (TxtDisplay.Text.Length > 0) Then
            TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1)
        End If

    End Sub

    Private Sub OperatorOnClick(sender As Object, e As EventArgs) Handles Btnplus.Click, Btnminus.Click, BtnMultiply.Click, Btndivide.Click
        Dim b As Button = sender
        firstValue = TxtDisplay.Text
        op = b.Text
        TxtDisplay.Text = "0"


    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        secondValue = TxtDisplay.Text
        If op = "+" Then
            result = firstValue + secondValue
            TxtDisplay.Text = result
        ElseIf op = "-" Then
            result = firstValue - secondValue
            TxtDisplay.Text = result
        ElseIf op = "*" Then
            result = firstValue * secondValue
            TxtDisplay.Text = result
        ElseIf op = "/" Then
            result = firstValue / secondValue
            TxtDisplay.Text = result
        End If
    End Sub

    Private Sub Btnplus_minus_Click(sender As Object, e As EventArgs) Handles Btnplus_minus.Click
        If TxtDisplay.Text.Contains("-") Then
            TxtDisplay.Text = TxtDisplay.Text.Remove(0, 1)
        ElseIf TxtDisplay.Text <> "0" Then
            TxtDisplay.Text = "-" & TxtDisplay.Text
        End If

    End Sub

    Private Sub Clear(sender As Object, e As EventArgs) Handles BtnCE.Click, BtnC.Click
        TxtDisplay.Text = "0"

    End Sub
End Class
