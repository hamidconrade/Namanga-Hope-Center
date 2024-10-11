Class Resources
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Basics_Click(sender As Object, e As RoutedEventArgs)
        Dim BasicsWindow As New Basics()
        BasicsWindow.Show()
        Me.Close()
    End Sub

    Private Sub Firstaid_Click(sender As Object, e As RoutedEventArgs)
        Dim FirstaidWindow As New Firstaid()
        FirstaidWindow.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Schooling_Click(sender As Object, e As RoutedEventArgs)
        Dim SchoolingWindow As New Schooling()
        SchoolingWindow.Show()
        Me.Close()
    End Sub

    Private Sub Religion_Click(sender As Object, e As RoutedEventArgs)
        Dim ReligionWindow As New Religion()
        ReligionWindow.Show()
        Me.Close()
    End Sub

    Private Sub Recreation_Click(sender As Object, e As RoutedEventArgs)
        Dim RecreationWindow As New Recreation()
        RecreationWindow.Show()
        Me.Close()
    End Sub
End Class
