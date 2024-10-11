Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions
Imports System.Windows.Controls

Class Finance

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Function GetMpesaAccessToken() As Task(Of String)
        Try
            Dim client As New HttpClient()

            Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes("YourConsumerKey:YourConsumerSecret"))

            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", credentials)

            Dim response = Await client.GetStringAsync("https://sandbox.safaricom.co.ke/oauth/v1/generate?grant_type=client_credentials")
            Dim jsonResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response)

            Return jsonResponse("access_token")

        Catch ex As Exception
            MessageBox.Show("Error retrieving access token: " & ex.Message, "Error")
            Return Nothing
        End Try
    End Function

    Private Function GeneratePassword() As String
        Dim shortCode As String = "6700292"
        Dim passkey As String = "YourLipaNaMpesaOnlinePasskey"
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim password As String = shortCode & passkey & timestamp
        Return Convert.ToBase64String(Encoding.ASCII.GetBytes(password))
    End Function

    Private Async Function InitiateSTKPush(accessToken As String, amount As Decimal) As Task
        Try
            Dim client As New HttpClient()

            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", accessToken)

            Dim requestBody As New Dictionary(Of String, String) From {
                {"BusinessShortCode", "6700292"},
                {"Password", GeneratePassword()},
                {"Timestamp", DateTime.Now.ToString("yyyyMMddHHmmss")},
                {"TransactionType", "CustomerPayBillOnline"},
                {"Amount", amount.ToString()},
                {"PartyA", "254113766817"},
                {"PartyB", "6700292"},
                {"PhoneNumber", "254113766817"},
                {"CallBackURL", "https://yourdomain.com/callback"},
                {"AccountReference", "DonationXYZ"},
                {"TransactionDesc", "Donation to Namanga Hope Center"}
            }

            Dim content As New StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json")

            Dim response = Await client.PostAsync("https://sandbox.safaricom.co.ke/mpesa/stkpush/v1/processrequest", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("STK Push sent! Check your phone to complete the transaction.", "Success")
            Else
                MessageBox.Show("STK Push failed: " & response.StatusCode.ToString(), "Error")
            End If

        Catch ex As Exception
            MessageBox.Show("Error during STK Push: " & ex.Message, "Error")
        End Try
    End Function

    Private Async Sub DonateButton_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim donationAmount As Decimal
            If Not Decimal.TryParse(AmountTextBox.Text, donationAmount) OrElse donationAmount <= 0 Then
                MessageBox.Show("Please enter a valid donation amount.", "Invalid Amount")
                Return
            End If

            Dim accessToken = Await GetMpesaAccessToken()

            If accessToken IsNot Nothing Then
                Await InitiateSTKPush(accessToken, donationAmount)
            End If

        Catch ex As Exception
            MessageBox.Show("Error processing donation: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub AmountTextBox_PreviewTextInput(sender As Object, e As TextCompositionEventArgs)
        Dim isNumber As Boolean = Regex.IsMatch(e.Text, "^[0-9]*$")
        e.Handled = Not isNumber
    End Sub

    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Chairman button clicked!", "Info")
    End Sub

    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Secretary button clicked!", "Info")
    End Sub

    Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Treasurer button clicked!", "Info")
    End Sub

End Class
