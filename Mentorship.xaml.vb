Class Mentorship

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    ' Event handler for Chairman button click
    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Chairman details or action triggered.")
    End Sub

    ' Event handler for Secretary button click
    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Secretary details or action triggered.")
    End Sub

    ' Event handler for Treasurer button click
    Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Treasurer details or action triggered.")
    End Sub

End Class
