Public Class frmPayrollCalculator
    Private Sub frmPayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFederalAmount.Text = ""
        lblStateAmount.Text = ""
        lblFICAAmount.Text = ""
        lblNetPaycheckIncome.Text = ""
        txtGrossPay.Focus()
    End Sub

    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal = 0.0765D
        Dim decFederal As Decimal = 0.22D
        Dim decState As Decimal = 0.04D
        Dim decNet As Decimal

        strIncome = txtGrossPay.Text
        If IsNumeric(txtGrossPay.Text) Then
            decIncome = Convert.ToDecimal(strIncome)
            decNet = decIncome - ((decIncome * decFica) + decIncome * decFederal + decIncome * decState)
            lblFICAAmount.Text = (decIncome * decFica).ToString("C")
            lblFederalAmount.Text = (decIncome * decFederal).ToString("C")
            lblStateAmount.Text = (decIncome * decState).ToString("C")
            lblNetPaycheckIncome.Text = decNet.ToString("C")
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFederalAmount.Text = ""
        lblStateAmount.Text = ""
        lblFICAAmount.Text = ""
        lblNetPaycheckIncome.Text = ""
        txtGrossPay.Clear()
        txtGrossPay.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
