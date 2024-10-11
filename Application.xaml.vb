Imports System.Windows.Threading

Namespace Namanga_Hope_Center
    Partial Public Class Application
        Inherits System.Windows.Application
        Protected Overrides Sub OnStartup(e As StartupEventArgs)
            MyBase.OnStartup(e)
            Dim loadingWindow As New LoadingWindow()
            loadingWindow.Show()
            Dim timer As New DispatcherTimer()
            timer.Interval = TimeSpan.FromSeconds(10)
            AddHandler timer.Tick, AddressOf Timer_Tick
            timer.Start()
        End Sub
        Private Sub Timer_Tick(sender As Object, e As EventArgs)
            Dim timer = CType(sender, DispatcherTimer)
            timer.Stop()
            Dim LoginWindow As New Log_In()
            LoginWindow.Show()
            For Each window As Window In Application.Current.Windows
                If TypeOf window Is LoadingWindow Then window.Close()
            Next
        End Sub
    End Class
End Namespace
