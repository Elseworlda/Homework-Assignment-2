Public Class Form1
    Dim strIncome As String
    Dim decIncome As Decimal
    Dim decFica As Decimal
    Dim decFederal As Decimal
    Dim decState As Decimal
    Dim decNet As Decimal
    Const cdecFica As Decimal = 0.0765D
    Const cdecFed As Decimal = 0.22D
    Const cdecState As Decimal = 0.04D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGrossPay.Clear()
        txtGrossPay.Focus()
        lblFederalTaxAmount.Text = ""
        lblFICAAmount.Text = ""
        lblStateTaxAmount.Text = ""
        lblNetIncomeAmount.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossPay.Clear()
        txtGrossPay.Focus()
        lblFederalTaxAmount.Text = ""
        lblFICAAmount.Text = ""
        lblStateTaxAmount.Text = ""
        lblNetIncomeAmount.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnComputeTaxes_Click(sender As Object, e As EventArgs) Handles btnComputeTaxes.Click
        strIncome = txtGrossPay.Text
        decIncome = Convert.ToInt32(strIncome)
        decFica = (decIncome * cdecFica)
        decFederal = (decIncome * cdecFed)
        decState = (decIncome * cdecState)
        decNet = decIncome - (decFica + decFederal + decState)
        lblFederalTaxAmount.Text = decFederal.ToString("C")
        lblFICAAmount.Text = decFica.ToString("C")
        lblStateTaxAmount.Text = decState.ToString("C")
        lblNetIncomeAmount.Text = decNet.ToString("C")
    End Sub
End Class
