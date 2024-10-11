Public Class HR
    Inherits Window

    Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
            ' Action for Chairman button click
            MessageBox.Show("Chairman button clicked")
        End Sub

        Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
            ' Action for Secretary button click
            MessageBox.Show("Secretary button clicked")
        End Sub

        Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
            ' Action for Treasurer button click
            MessageBox.Show("Treasurer button clicked")
        End Sub
    End Class
