Imports System.Windows.Threading
Imports System.Windows.Media.Imaging

Namespace Namanga_Hope_Center
    Partial Public Class LoadingWindow
        Inherits Window

        Private SlideshowTimer As DispatcherTimer
        Private ImagePaths As List(Of String)
        Private CurrentImageIndex As Integer = 0
        Private LoadingTimer As DispatcherTimer

        Public Sub New()
            InitializeComponent()

            ImagePaths = New List(Of String) From {
                "pack://application:,,,/Resources/director.jpg",
                "pack://application:,,,/Resources/linda.jpg",
                "pack://application:,,,/Resources/MikeLinda.jpg",
                "pack://application:,,,/Resources/Children.JPG",
                "pack://application:,,,/Resources/Church.JPG",
                "pack://application:,,,/Resources/Men.JPG",
                "pack://application:,,,/Resources/men2.JPG",
                "pack://application:,,,/Resources/class.jpg",
                "pack://application:,,,/Resources/me.JPG"
            }

            SlideshowImage.Source = New BitmapImage(New Uri(ImagePaths(CurrentImageIndex), UriKind.Absolute))

            SlideshowTimer = New DispatcherTimer()
            SlideshowTimer.Interval = TimeSpan.FromSeconds(3)
            AddHandler SlideshowTimer.Tick, AddressOf OnSlideshowTimerTick
            SlideshowTimer.Start()

            ' Initialize LoadingTimer
            LoadingTimer = New DispatcherTimer()
            LoadingTimer.Interval = TimeSpan.FromSeconds(28) ' Set the desired interval
            AddHandler LoadingTimer.Tick, AddressOf OnLoadingCompleted
            LoadingTimer.Start()
        End Sub

        Private Sub OnSlideshowTimerTick(sender As Object, e As EventArgs)
            ' Update the image
            CurrentImageIndex = (CurrentImageIndex + 1) Mod ImagePaths.Count
            SlideshowImage.Source = New BitmapImage(New Uri(ImagePaths(CurrentImageIndex), UriKind.Absolute))
        End Sub

        Private Sub OnLoadingCompleted(sender As Object, e As EventArgs)
            LoadingTimer.Stop()
            Dim loginWindow As New Log_In()
            loginWindow.Show()
            Me.Close()
        End Sub
    End Class
End Namespace
