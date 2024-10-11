Imports System.Collections.Specialized.BitVector32
Imports System.IO
Imports Namanga_Hope_Center.Namanga_Hope_Center

Class Management

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub DirectorButton_Click(sender As Object, e As RoutedEventArgs)
        Dim directorWindow As New Director()
        directorWindow.Show()
    End Sub

    Private Sub BoardButton_Click(sender As Object, e As RoutedEventArgs)
        Dim boardWindow As New Board()
        boardWindow.Show()
    End Sub

    Private Sub CommetteesButton_Click(sender As Object, e As RoutedEventArgs)
        Dim committeesWindow As New Committees()
        committeesWindow.Show()
    End Sub

    Private Sub SectionsButton_Click(sender As Object, e As RoutedEventArgs)
        Dim sectionsWindow As New Sections()
        sectionsWindow.Show()
    End Sub

    Private Sub FamilyButton_Click(sender As Object, e As RoutedEventArgs)
        Dim BeneficiariesWindow As New Beneficiaries()
        BeneficiariesWindow.Show()
    End Sub

    Private Sub BoardButton_Click(sender As Object, e As MouseEventArgs)
        Dim boardWindow As New Board()
        boardWindow.Show()
    End Sub
End Class
