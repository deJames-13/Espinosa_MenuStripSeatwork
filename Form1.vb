
Public Class Form1
    Public currentPage As Panel = BlankPage.panelMain





    Private Sub handleToolStripClicks(sender As Object, e As EventArgs) Handles formMain.Click, formBlank.Click, formForm2.Click, ExitToolStripMenuItem.Click, formsHome.Click, HomeToolStripMenuItem.Click
        Dim menu As ToolStripItem = CType(sender, ToolStripItem)

        Select Case menu.Name
            Case "formMain"
                switchPage(MainForm.panelMain, currentPage)
            Case "formForm2"
                switchPage(Form2.panelMain, currentPage)
            Case "formBlank"
                switchPage(BlankPage.panelMain, currentPage)
            Case "formsHome", "HomeToolStripMenuItem"
                currentPage.Hide()
                panelMain.Show()
                currentPage = BlankPage.panelMain

            Case "ExitToolStripMenuItem"
                Me.Close()
        End Select

    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        panelMain.Hide()
        switchPage(MainForm.panelMain, currentPage)
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        panelMain.Hide()
        switchPage(Form2.panelMain, currentPage)

    End Sub

End Class
