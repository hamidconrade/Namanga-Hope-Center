Imports System.Data
Imports System.Data.OleDb

Namespace Namanga_Hope_Center
    Public Class Sibling
        Inherits Window

        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rnyin\source\repos\Namanga Hope Center\Namanga Hope Center\Namanga Hope Center_Backup.accdb"
        Private connection As OleDbConnection

        Private Sub SiblingWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
            connection = New OleDbConnection(connectionString)
        End Sub

        Private Sub LoadButton_Click(sender As Object, e As RoutedEventArgs)
            LoadData()
        End Sub

        Private Sub LoadData()
            Using connection As New OleDbConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "SELECT * FROM SiblingPortfolioT"
                    Dim command As New OleDbCommand(query, connection)
                    Dim adapter As New OleDbDataAdapter(command)
                    Dim dataTable As New DataTable()

                    adapter.Fill(dataTable)
                    ResultsDataGrid.ItemsSource = dataTable.DefaultView

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Sub
        Private Sub BackToDashboardButton_Click(sender As Object, e As RoutedEventArgs)
            Me.Hide()
            Dim dashboardWindow As DashBoard = Application.Current.Windows.OfType(Of DashBoard)().FirstOrDefault()
            If dashboardWindow Is Nothing Then
                dashboardWindow = New DashBoard()
                dashboardWindow.Show()
            Else
                dashboardWindow.Activate()
            End If
        End Sub
        Private Sub ResultsDataGrid_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ResultsDataGrid.SelectionChanged

        End Sub
    End Class
End Namespace
