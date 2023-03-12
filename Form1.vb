Public Class Form1
    Dim arr As String() = {}
    Dim arrInvents As New ArrayList
    Dim ans, desc, invent, choice, prod As String
    Dim nr, quant As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Do
            nr = dtGrid1.Rows.Add
            arr = splitArray(arrInvents, n, "/")

            For cols As Integer = 0 To dtGrid1.ColumnCount - 1
                dtGrid1.Item(cols, nr).Value = arr(cols)
            Next

            n += 1
        Loop While (n < arrInvents.Count)
    End Sub

    Dim n As Integer = 0
    Dim price, totals As Double

    Private Sub cmbProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProd.SelectedIndexChanged
        txtDesc.Text = cmbProd.Text
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        desc = txtDesc.Text
        price = CDbl(txtPrice.Text)
        quant = CInt(txtQuant.Text)

        totals = quant * price
        txtTotals.Text = totals.ToString("C2")

        ans = MessageBox.Show("Would you like to save the data?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = vbYes Then
            arrInvents = addItem(desc, price, quant, totals)
        Else
            If arrInvents.Count = 0 Then
                txtTotals.Focus()
                clearAll({txtDesc, txtPrice, txtQuant, txtTotals})
            Else
                Do
                    nr = dtGrid1.Rows.Add
                    arr = splitArray(arrInvents, n, "/")

                    For cols As Integer = 0 To dtGrid1.ColumnCount - 1
                        dtGrid1.Item(cols, nr).Value = arr(cols)
                    Next

                    n += 1
                Loop While (n < arrInvents.Count)
            End If

        End If



    End Sub




End Class