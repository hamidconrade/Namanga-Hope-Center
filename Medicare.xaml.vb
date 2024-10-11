Imports System.Windows.Threading
Imports System.Windows.Media.Imaging

Namespace Namanga_Hope_Center
    Class Medicare
        Private images As New List(Of String) From {
        "Resources/image1.jpg",
        "Resources/image2.jpg",
        "Resources/image3.jpg"
    }

        Private slideshowTimer As DispatcherTimer
        Private currentImageIndex As Integer = 0

        Public Sub New()
            InitializeComponent()

            slideshowTimer = New DispatcherTimer()
            slideshowTimer.Interval = TimeSpan.FromSeconds(3)
            AddHandler slideshowTimer.Tick, AddressOf OnSlideshowTick
            slideshowTimer.Start()

            SlideshowImage.Source = New BitmapImage(New Uri(images(currentImageIndex), UriKind.Relative))
        End Sub

        ' Timer event handler to switch images
        Private Sub OnSlideshowTick(sender As Object, e As EventArgs)
            currentImageIndex = (currentImageIndex + 1) Mod images.Count
            SlideshowImage.Source = New BitmapImage(New Uri(images(currentImageIndex), UriKind.Relative))
        End Sub

        ' This is no longer an override method
        Private Sub Medicare_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            ' Stop slideshow when window is closed
            slideshowTimer.Stop()
        End Sub

        ' Open Programs window and close this one
        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs()
            programsWindow.Show()
            Me.Close() ' Close current window after opening Programs
        End Sub
    End Class
End Namespace