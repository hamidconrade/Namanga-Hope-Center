Imports System.Windows.Threading
Imports System.Windows.Media.Imaging

Namespace Namanga_Hope_Center
    Public Class ChildAbuseRehabilitation
        Private images As New List(Of String) From {
            "Resources/image1.jpg",
            "Resources/image2.jpg",
            "Resources/image3.jpg"
        }

        ' Timer to handle the slideshow
        Private slideshowTimer As DispatcherTimer
        Private currentImageIndex As Integer = 0

        Public Sub New()
            InitializeComponent()

            ' Initialize the slideshow timer
            slideshowTimer = New DispatcherTimer()
            slideshowTimer.Interval = TimeSpan.FromSeconds(3)
            AddHandler slideshowTimer.Tick, AddressOf OnSlideshowTick
            slideshowTimer.Start()

            ' Set the first image
            SlideshowImage.Source = New BitmapImage(New Uri(images(currentImageIndex), UriKind.Relative))
        End Sub

        ' Event handler for the timer tick, changes the image
        Private Sub OnSlideshowTick(sender As Object, e As EventArgs)
            currentImageIndex = (currentImageIndex + 1) Mod images.Count
            SlideshowImage.Source = New BitmapImage(New Uri(images(currentImageIndex), UriKind.Relative))
        End Sub

        Private Sub ChildAbuseRehabilitation_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            slideshowTimer.Stop()
        End Sub

        ' Programs button click event to open the Programs window
        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs() ' Assuming Programs is the window's class name
            programsWindow.Show() ' Open the Programs window
        End Sub
    End Class
End Namespace
