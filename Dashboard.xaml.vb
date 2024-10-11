Imports System.Windows.Threading
Imports System.Windows.Media

Namespace Namanga_Hope_Center
    Partial Public Class Dashboard

        Private flashTimer As DispatcherTimer
        Private isFlashing As Boolean

        Public Sub New()
            InitializeComponent()

            flashTimer = New DispatcherTimer()
            flashTimer.Interval = TimeSpan.FromSeconds(0.5)
            AddHandler flashTimer.Tick, AddressOf FlashTextBox

            flashTimer.Start()
        End Sub

        Private Sub FlashTextBox(sender As Object, e As EventArgs)
            If isFlashing Then
                FlashingTextBox.Background = New SolidColorBrush(Colors.Red)
            Else
                FlashingTextBox.Background = New SolidColorBrush(Colors.White)
            End If
            isFlashing = Not isFlashing
        End Sub

        Private Sub BeneficiariesButton_Click(sender As Object, e As RoutedEventArgs)
            Dim BeneficiaryWindow As New Beneficiaries()
            BeneficiaryWindow.Show()
            Me.Close()
        End Sub

        Private Sub FinanceButton_Click(sender As Object, e As RoutedEventArgs)
            Dim FinanceWindow As New Finance()
            FinanceWindow.Show()
            Me.Close()
        End Sub

        Private Sub SecurityButton_Click(sender As Object, e As RoutedEventArgs)
            Dim SecurityWindow As New Security()
            SecurityWindow.Show()
            Me.Close()
        End Sub

        Private Sub ProgramsButton_Click(sender As Object, e As RoutedEventArgs)
            Dim programsWindow As New Programs()
            programsWindow.Show()
            Me.Close()
        End Sub

        Private Sub ManagementButton_Click(sender As Object, e As RoutedEventArgs)
            Dim ManagementWindow As New Management()
            ManagementWindow.Show()
            Me.Close()
        End Sub

        Private Sub WelfareButton_Click(sender As Object, e As RoutedEventArgs)
            Dim WelfareWindow As New Welfare()
            WelfareWindow.Show()
            Me.Close()
        End Sub

        Private Sub ResourcesButton_Click(sender As Object, e As RoutedEventArgs)
            Dim ResourcesWindow As New Resources()
            ResourcesWindow.Show()
            Me.Close()
        End Sub

        Private Sub AlumniButton_Click(sender As Object, e As RoutedEventArgs)
            Dim AlumniWindow As New Alumni()
            AlumniWindow.Show()
            Me.Close()
        End Sub
    End Class
End Namespace
