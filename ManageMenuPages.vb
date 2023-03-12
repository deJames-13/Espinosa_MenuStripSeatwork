Module ManageMenuPages
    Public Sub switchPage(ByRef newPage As Panel, ByRef currentPage As Panel)
        currentPage.Hide()
        newPage.Parent = MainMenuForm.PageContainer
        newPage.Dock = DockStyle.Fill
        newPage.Show()
        currentPage = newPage
    End Sub
End Module
