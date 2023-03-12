Module Form2Module
    Public iTax As Integer = 5230
    Public fRate = 0.38
    Public fTaxes, fTaxableIncome, fIncome As Double

    Public Function stringTrap(ByVal str As String) As Boolean
        If String.IsNullOrEmpty(str) Then
            Return True
        End If
        Return False
    End Function

    Public Function trapInvalidText(ByVal str As String) As Boolean
        If stringTrap(str) OrElse Not (IsNumeric(str)) Then
            Return True
        End If
        Return False
    End Function

    Public Function tax1(income As Integer) As Double
        Dim tax As Double = iTax + (fRate * (income - 20000))
        Return tax
    End Function

    Public Function tax2(income As Integer) As Double
        Dim tax As Double = 5990 + (0.4 * (income - 22000))
        Return tax
    End Function
    Public Function tax3(income As Integer) As Double
        Dim tax As Double = 7590 + (0.45 * (income - 26000))
        Return tax
    End Function
    Public Function tax4(income As Integer) As Double
        Dim tax As Double = 10290 + (0.5 * (income - 32000))
        Return tax
    End Function
    Public Function tax5(income As Integer) As Double
        Dim tax As Double = 13290 + (0.55 * (income - 38000))
        Return tax
    End Function

    Public Function computeIncome(income As Double, ByRef taxes As Double)
        Dim incomeRes As Double
        If (income > 2000 AndAlso income <= 20000) Then
            taxes = tax1(income)
        ElseIf (income > 22000 AndAlso income <= 26000) Then
            taxes = tax2(income)
        ElseIf (income > 26000 AndAlso income <= 38000) Then
            taxes = tax3(income)
        Else
            taxes = tax4(income)
        End If
        incomeRes = income - taxes
        Return incomeRes
    End Function

    Public Function stringFormatPrints(income As Double, fTaxes As Double, taxableIncome As Double)
        Dim strP As String = ($"Income = {fIncome} {vbCrLf}Tax = {fTaxes} {vbCrLf}TaxableIncome = {fTaxableIncome}")
        Return strP
    End Function

    Public Function payerName() As String
        Dim strName As String = "Dalinar"
        If Form2.RadioButton1.Checked Then
            strName = "Shallan"
        ElseIf Form2.RadioButton2.Checked Then
            strName = "Kaladin"
        End If
        Return strName
    End Function

    Public Sub fpayerName(ByRef name As String, f As Form2)
        name = "Adolin"
        If Form2.RadioButton1.Checked Then
            name = "Jasnah"
        ElseIf Form2.RadioButton2.Checked Then
            name = "Renarin"
        End If
    End Sub

    Public Function getData() As String
        Dim dept As String = ""
        If Form2.cmbProd.SelectedIndex >= 0 Then
            dept = Form2.cmbProd.Text
        End If
        Return dept
    End Function

End Module
