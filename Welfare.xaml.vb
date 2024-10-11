Class Welfare

    ' Constructor for the Window
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Event handler for the Chairman button click
    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Chairman Button Clicked! Overseeing welfare programs.", "Chairman")
    End Sub

    ' Event handler for the Secretary button click
    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Secretary Button Clicked! Documenting welfare initiatives.", "Secretary")
    End Sub

    ' Event handler for the Treasurer button click
    Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Treasurer Button Clicked! Managing welfare funds.", "Treasurer")
    End Sub

End Class
