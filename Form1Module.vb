Module Form1Module
    Public arrInv As New ArrayList

    Public Function addItem(desc As String, price As String, quant As String, total As String) As ArrayList
        arrInv.Add($"{desc}/{price}/{quant}/{total}")
        Return arrInv
    End Function

    Public Function splitArray(arr As ArrayList, ByRef n As Integer, ch As String) As Array
        Return Split(arr(n), ch)
    End Function

    Public Sub clearAll(ts As TextBox())
        For Each t In ts
            t.Clear()
        Next
    End Sub

End Module
