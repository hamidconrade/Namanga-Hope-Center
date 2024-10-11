Imports Namanga_Hope_Center.Namanga_Hope_Center

Public Class Committees
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ITButton_Click(sender As Object, e As RoutedEventArgs)
        Dim PublicityWindow As New Publicity()
        PublicityWindow.Show()
        Me.Hide()
    End Sub

    Private Sub StoresButton_Click(sender As Object, e As RoutedEventArgs)
        Dim storesWindow As New Stores()
        storesWindow.Show()
        Me.Hide()
    End Sub

    Private Sub SecurityButton_Click(sender As Object, e As RoutedEventArgs)
        Dim securityWindow As New Security()
        securityWindow.Show()
        Me.Hide()
    End Sub

    Private Sub FieldworkButton_Click(sender As Object, e As RoutedEventArgs)
        Dim fieldworkWindow As New Fieldwork()
        fieldworkWindow.Show()
        Me.Hide()
    End Sub

    Private Sub HRButton_Click(sender As Object, e As RoutedEventArgs)
        Dim HRWindow As New HR()
        HRWindow.Show()
        Me.Hide()
    End Sub

    Private Sub FinanceButton_Click(sender As Object, e As RoutedEventArgs)
        Dim FinanceWindow As New Finance()
        FinanceWindow.Show()
        Me.Hide()
    End Sub

    Private Sub WelfareButton_Click(sender As Object, e As RoutedEventArgs)
        Dim WelfareWindow As New Welfare()
        WelfareWindow.Show()
        Me.Close()
    End Sub

    Private Sub AdmissionsButton_Click(sender As Object, e As RoutedEventArgs)
        Dim admissionWindow As New Admission()
        admissionWindow.Show()
        Me.Close()
    End Sub

    Private Sub MentorshipButton_Click(sender As Object, e As RoutedEventArgs)
        Dim mentorshipWindow As New Mentorship()
        mentorshipWindow.Show()
        Me.Hide()
    End Sub
End Class
