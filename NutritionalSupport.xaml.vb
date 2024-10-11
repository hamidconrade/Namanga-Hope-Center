Imports System.Windows.Threading

Namespace Namanga_Hope_Center
    Class NutritionalSupport

        Private SlideshowImages As New List(Of String) From {
        "pack://application:,,,/Resources/image1.jpg",
        "pack://application:,,,/Resources/image2.jpg",
        "pack://application:,,,/Resources/image3.jpg"
    }

        Private currentImageIndex As Integer = 0
        Private slideshowTimer As DispatcherTimer

        Public Sub New()
            InitializeComponent()

            slideshowTimer = New DispatcherTimer()
            AddHandler slideshowTimer.Tick, AddressOf OnSlideshowTick
            slideshowTimer.Interval = TimeSpan.FromSeconds(3)
            slideshowTimer.Start()
        End Sub

        Private Sub OnSlideshowTick(sender As Object, e As EventArgs)
            currentImageIndex = (currentImageIndex + 1) Mod SlideshowImages.Count
            SlideshowImage.Source = New BitmapImage(New Uri(SlideshowImages(currentImageIndex)))
        End Sub

        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs()
            programsWindow.Show()
        End Sub

    End Class
End Namespace