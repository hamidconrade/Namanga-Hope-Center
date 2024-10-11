Public Class Treasurer
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub EmailButton_Click(sender As Object, e As RoutedEventArgs)
        Dim email As String = "mailto:@gmail.com?subject=Inquiry"
        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(email) With {.UseShellExecute = True})
    End Sub

End Class
