Imports System.Data.OleDb

Namespace Namanga_Hope_Center
    Public Class Admission
        Inherits Window

        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\rnyin\source\repos\Namanga Hope Center\Namanga Hope Center\Namanga Hope Center_Backup.accdb"

        Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

            AdmissionDataGrid.ItemsSource = New List(Of AdmissionRecord)()
        End Sub

        Private Sub SubmitButton_Click(sender As Object, e As RoutedEventArgs)
            Dim records As List(Of AdmissionRecord) = CType(AdmissionDataGrid.ItemsSource, List(Of AdmissionRecord))

            Using connection As New OleDbConnection(connectionString)
                Try
                    connection.Open()

                    For Each record In records
                        Dim query As String = "INSERT INTO ChildPortfolio (NameofChild, DateOfBirth, FathersName, MothersName, GuardiansName, Village, School, Grade, ContactInfo, Male, Female, FosterCare, DrugAbuseRehabilitation, EducationalSupport, ChildAbuseRehabilitation, Medicare, PsychologicalCounselling, NutritionSupport, InsertPassport) " &
                                              "VALUES (@NameofChild, @DateOfBirth, @FathersName, @MothersName, @GuardiansName, @Village, @School, @Grade, @ContactInfo, @Male, @Female, @FosterCare, @DrugAbuseRehabilitation, @EducationalSupport, @ChildAbuseRehabilitation, @Medicare, @PsychologicalCounselling, @NutritionSupport, @InsertPassport)"

                        Using command As New OleDbCommand(query, connection)
                            command.Parameters.AddWithValue("@NameofChild", record.NameofChild)
                            command.Parameters.AddWithValue("@DateOfBirth", record.DateOfBirth)
                            command.Parameters.AddWithValue("@FathersName", record.FathersName)
                            command.Parameters.AddWithValue("@MothersName", record.MothersName)
                            command.Parameters.AddWithValue("@GuardiansName", record.GuardiansName)
                            command.Parameters.AddWithValue("@Village", record.Village)
                            command.Parameters.AddWithValue("@School", record.School)
                            command.Parameters.AddWithValue("@Grade", record.Grade)
                            command.Parameters.AddWithValue("@ContactInfo", record.ContactInfo)
                            command.Parameters.AddWithValue("@Male", record.Male)
                            command.Parameters.AddWithValue("@Female", record.Female)
                            command.Parameters.AddWithValue("@FosterCare", record.FosterCare)
                            command.Parameters.AddWithValue("@DrugAbuseRehabilitation", record.DrugAbuseRehabilitation)
                            command.Parameters.AddWithValue("@EducationalSupport", record.EducationalSupport)
                            command.Parameters.AddWithValue("@ChildAbuseRehabilitation", record.ChildAbuseRehabilitation)
                            command.Parameters.AddWithValue("@Medicare", record.Medicare)
                            command.Parameters.AddWithValue("@PsychologicalCounselling", record.PsychologicalCounselling)
                            command.Parameters.AddWithValue("@NutritionSupport", record.NutritionSupport)
                            command.Parameters.AddWithValue("@InsertPassport", record.InsertPassport)

                            command.ExecuteNonQuery()
                        End Using
                    Next

                    MessageBox.Show("Records added successfully!")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Sub
    End Class

    Public Class AdmissionRecord
        Public Property NameofChild As String
        Public Property DateOfBirth As DateTime
        Public Property FathersName As String
        Public Property MothersName As String
        Public Property GuardiansName As String
        Public Property Village As String
        Public Property School As String
        Public Property Grade As String
        Public Property ContactInfo As String
        Public Property Male As Boolean
        Public Property Female As Boolean
        Public Property FosterCare As Boolean
        Public Property DrugAbuseRehabilitation As Boolean
        Public Property EducationalSupport As Boolean
        Public Property ChildAbuseRehabilitation As Boolean
        Public Property Medicare As Boolean
        Public Property PsychologicalCounselling As Boolean
        Public Property NutritionSupport As Boolean
        Public Property InsertPassport As String
    End Class
End Namespace
