' Joshua Picknenpaugh
' September 3rd, 2016
' "Circle Solution", Unit 3, CPT 432

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closes the application:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Declares sub-wide constant:
        Const dblPI As Double = 3.14

        ' Delcares the variables:
        Dim dblDiameter As Double
        Dim dblCircumference As Double

        ' Stores diameter in a variable:
        Double.TryParse(txtDiameter.Text, dblDiameter)
        '  Above line can also be coded as:
        ' dblDiameter = Val(txtDiameter.Text)

        ' Calculates circumference:
        dblCircumference = dblPI * dblDiameter

        ' Output result with 2 decimal places:
        lblCircumference.Text = dblCircumference.ToString("N2")


    End Sub
End Class
