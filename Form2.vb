Public Class Form2
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim name As String = ""
        If Not IsNumeric(txtIncome.Text) Then
            txtIncome.Clear()
            txtIncome.Focus()
            Return
        End If
        fIncome = CDbl(txtIncome.Text)
        fTaxableIncome = computeIncome(fIncome, fTaxes)
        txtIncome.Text = fIncome.ToString("C2")
        txtTax.Text = fTaxes.ToString("C2")
        txtTaxIncome.Text = fTaxableIncome.ToString("C2")
        fpayerName(name, Me)
        txtName.Text = name
        MsgBox(stringFormatPrints(fIncome, fTaxes, fTaxableIncome))
    End Sub

    Private Sub cmbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedIndexChanged
        txtDesc.Text = cmbProd.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.panelMain.Hide()
        MainMenuForm.Show()
    End Sub
End Class