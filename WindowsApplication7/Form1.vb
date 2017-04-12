Option Strict On
Public Class Form1
    Const _constRate As Double = 0.1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim doubAmount As Double
        Dim doubYears As Double
        Dim doubTotal As Double
        If IsNumeric(txtAmount.Text) = True And IsNumeric(txtYear.Text) = True Then
            doubAmount = Convert.ToDouble(txtAmount.Text)
            doubYears = Convert.ToDouble(txtYear.Text)
            If doubYears > 0 And doubAmount > 0 Then
                doubTotal = Interest(doubAmount, doubYears)
                lblPrint.Visible = True
                lblPrint.Text = "The Total Earned Amount is $" & doubTotal.ToString()
            Else
                MsgBox("Invalid Value")
            End If
        Else
            MsgBox("Invalid Value")
        End If

    End Sub

    'The Funciton Procedure is used to calculate the earned interested
    Private Function Interest(ByVal doubAmount As Double, ByVal doubYears As Double) As Double
        Dim doubTotal As Double
        'Simple interest rate is calculated because investment is not compounded anually
        doubTotal = (doubAmount * (1 + (_constRate * doubYears)))
        Return doubTotal
    End Function

End Class
