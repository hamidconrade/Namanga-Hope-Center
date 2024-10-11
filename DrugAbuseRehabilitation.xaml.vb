Namespace Namanga_Hope_Center
    Class DrugAbuseRehabilitation

        Public Sub New()
            InitializeComponent()

            SetupSlideshow()
        End Sub

        Private SlideshowImages As String() = {"Images/image1.jpg", "Images/image2.jpg", "Images/image3.jpg"}
        Private CurrentImageIndex As Integer = 0
        Private SlideShowTimer As New System.Windows.Threading.DispatcherTimer()

        Private Sub SetupSlideshow()
            SlideShowTimer.Interval = TimeSpan.FromSeconds(3)
            AddHandler SlideShowTimer.Tick, AddressOf OnSlideShowTimerTick
            SlideShowTimer.Start()

            If SlideshowImages.Length > 0 Then
                SlideshowImage.Source = New BitmapImage(New Uri(SlideshowImages(CurrentImageIndex), UriKind.Relative))
            End If
        End Sub

        Private Sub OnSlideShowTimerTick(sender As Object, e As EventArgs)
            CurrentImageIndex += 1
            If CurrentImageIndex >= SlideshowImages.Length Then
                CurrentImageIndex = 0
            End If

            SlideshowImage.Source = New BitmapImage(New Uri(SlideshowImages(CurrentImageIndex), UriKind.Relative))
        End Sub

        Private Sub InfoTextBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles InfoTextBox.TextChanged

        End Sub

        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs()
            programsWindow.Show()
        End Sub

    End Class
End Namespace