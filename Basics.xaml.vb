Class Basics

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Food button clicked. Enhancing access to balanced nutrition and safe storage.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Water button clicked. Ensuring access to clean water and water cleaning mechanisms.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As RoutedEventArgs)
        Dim button As Button = CType(sender, Button)

        If button.Content.ToString() = "Shelter" Then
            MessageBox.Show("Shelter button clicked. Providing housing resources or safe shelters, especially in cases of natural disasters.")
        ElseIf button.Content.ToString() = "Clothing" Then
            MessageBox.Show("Clothing button clicked. For varying weather conditions, especially durable and affordable clothing options.")
        End If
    End Sub

End Class