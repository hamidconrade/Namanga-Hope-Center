Imports System.Windows

Namespace Namanga_Hope_Center
    Public Class Log_In
        Inherits Window
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub LogInButton_Click(Sender As Object, e As RoutedEventArgs)
            Dim username As String = UsernameBox.Text
            Dim Password As String = PasswordBox.Password

            If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(Password) Then
                MessageBox.Show("Welcome! Get Password from Director Richard", "Please contact Director Richard.", MessageBoxButton.OK, MessageBoxImage.Warning)
            Else MessageBox.Show("Praise God!", "Info!", MessageBoxButton.OK, MessageBoxImage.Information)
                Dim DashboardWindow As New DashBoard()
                DashboardWindow.Show()
                Me.Close()
            End If
        End Sub
    End Class
End Namespace