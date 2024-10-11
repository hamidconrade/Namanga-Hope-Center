Public Class Publicity


    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Chairman button clicked!")
    End Sub

    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
            MessageBox.Show("Secretary button clicked!")
        End Sub

        Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
            MessageBox.Show("Treasurer button clicked!")
        End Sub

End Class