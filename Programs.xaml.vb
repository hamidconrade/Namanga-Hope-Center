Imports System.Windows
Imports Namanga_Hope_Center.Namanga_Hope_Center

Namespace Namanga_Hope_Center
    Class Programs
        Inherits Window

        Private Sub FosterCareButton_Click(sender As Object, e As RoutedEventArgs)
            Try
                Dim fosterCareWindow As New FosterCare()
                fosterCareWindow.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub

        Private Sub EducationalSupportButton_Click(sender As Object, e As RoutedEventArgs)
            Dim educationalSupportWindow As New EducationalSupport()
            educationalSupportWindow.Show()
            Me.Close()
        End Sub

        Private Sub NutritionalSupportButton_Click(sender As Object, e As RoutedEventArgs)
            Dim nutritionalSupportWindow As New NutritionalSupport()
            nutritionalSupportWindow.Show()
            Me.Hide()
        End Sub

        Private Sub MedicareButton_Click(sender As Object, e As RoutedEventArgs)
            Dim medicareWindow As New Medicare()
            medicareWindow.Show()
            Me.Hide()
        End Sub

        Private Sub DrugAbuseRehabilitationButton_Click(sender As Object, e As RoutedEventArgs)
            Dim drugAbuseWindow As New DrugAbuseRehabilitation()
            drugAbuseWindow.Show()
            Me.Hide()
        End Sub

        Private Sub ChildAbuseRehabilitationButton_Click(sender As Object, e As RoutedEventArgs)
            Dim window As New ChildAbuseRehabilitation()
            window.Show()
            Me.Hide()
        End Sub

        Private Sub PsychologicalSupportButton_Click(sender As Object, e As RoutedEventArgs)
            Dim PsychologicalSupportWindow As New PsychologicalSupport
            PsychologicalSupportWindow.Show()
            Me.Hide()
        End Sub
        Private Sub Window_Closed(sender As Object, e As EventArgs)
            Me.Show()
        End Sub
    End Class
End Namespace