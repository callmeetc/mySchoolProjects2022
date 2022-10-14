Public Class Katrina

    Dim firstNum As Double
    Dim secondNum As Double
    Dim myAnswer As Double

    Dim op As String
    Dim n As Int64

    Private Sub btnClick(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click, btnZero.Click, btnPoint.Click

        Dim btns As Button = sender

        If txtScreen.Text = "0" Then
            txtScreen.Text = btns.Text
        ElseIf Not (txtScreen.Text.Contains(".")) Then
            txtScreen.Text = txtScreen.Text + btns.Text
        Else
            txtScreen.Text = txtScreen.Text + btns.Text
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScreen.Text = "0"
    End Sub

    Private Sub arithFuncs(sender As Object, e As EventArgs) Handles btnMultiply.Click, btnMinus.Click, btnDivide.Click, btnAdd.Click

        Dim ops As Button = sender

        firstNum = txtScreen.Text
        txtScreen.Text = ""
        op = ops.Text

    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondNum = txtScreen.Text

        If op = "+" Then
            myAnswer = firstNum + secondNum
            txtScreen.Text = myAnswer
            'txtScreen.Text = ""
        ElseIf op = "-" Then
            myAnswer = firstNum - secondNum
            txtScreen.Text = myAnswer
            'txtScreen.Text = ""

        ElseIf op = "*" Then
            myAnswer = firstNum * secondNum
            txtScreen.Text = myAnswer
            'txtScreen.Text = ""

        ElseIf op = "/" Then
            myAnswer = firstNum / secondNum
            txtScreen.Text = myAnswer
            'txtScreen.Text = ""
        End If

    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txtScreen.Text = ""
    End Sub
End Class
