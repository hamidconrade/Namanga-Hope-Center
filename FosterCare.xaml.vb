Imports System.Windows.Threading

Namespace Namanga_Hope_Center

    Class FosterCare
        Inherits Window
        Public Sub New()
            InitializeComponent()

            StartSlideshow()
        End Sub

        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs()
            programsWindow.Show()
            Me.Close()
        End Sub

        Private imagePaths As List(Of String) = New List(Of String) From {
        "pack://application:,,,/Resources/fostercare_1.jpg",
        "pack://application:,,,/Resources/fostercare_2.jpg",
        "pack://application:,,,/Resources/fostercare_3.jpg"
    }
        Private slideshowTimer As DispatcherTimer
        Private currentImageIndex As Integer = 0

        Private Sub StartSlideshow()
            slideshowTimer = New DispatcherTimer()
            AddHandler slideshowTimer.Tick, AddressOf OnSlideshowTick
            slideshowTimer.Interval = TimeSpan.FromSeconds(3)
            slideshowTimer.Start()
            UpdateSlideshowImage()
        End Sub

        Private Sub OnSlideshowTick(sender As Object, e As EventArgs)
            currentImageIndex = (currentImageIndex + 1) Mod imagePaths.Count
            UpdateSlideshowImage()
        End Sub

        Private Sub UpdateSlideshowImage()
            Dim uri As New Uri(imagePaths(currentImageIndex), UriKind.Absolute)
            Dim bitmap As New BitmapImage(uri)
            SlideshowImage.Source = bitmap
        End Sub

    End Class
End Namespace