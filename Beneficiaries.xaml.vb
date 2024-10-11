Imports System.Data
Imports System.Data.OleDb

Namespace Namanga_Hope_Center
    Public Class Beneficiaries
        Inherits Window

        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rnyin\source\repos\Namanga Hope Center\Namanga Hope Center\Namanga Hope Center_Backup.accdb"
        Private connection As OleDbConnection

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub BeneficiaryWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
            connection = New OleDbConnection(connectionString)
        End Sub

        Private Sub LoadButton_Click(sender As Object, e As RoutedEventArgs)
            LoadData()
        End Sub

        Private Sub LoadData()
            Using connection As New OleDbConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "SELECT * FROM ChildPortfolio"
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

        Private Sub OpenAdmissionButton_Click(sender As Object, e As RoutedEventArgs)
            Dim admissionWindow As New Admission()
            admissionWindow.Show()
            Me.Close()
        End Sub

        Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs)
            Dim SiblingWindow As New Sibling()
            SiblingWindow.Show()
            Me.Close()
        End Sub

        Private Function PerformComputation(Childname As String) As Double
            Return 100.0
        End Function

        Private Sub BeneficiariesButton_Click(sender As Object, e As RoutedEventArgs)
            Dim Beneficiary As New Beneficiaries()
        End Sub
    End Class
End Namespace
