Imports System.Net.Mail

Class Board
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub EmailChairman_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("your_email@example.com")
            mail.To.Add("rnyinge2@gmail.com")
            mail.Subject = "Subject of the Email"
            mail.Body = "This is the body of the email."

            Dim smtp As New SmtpClient("smtp.your_email_provider.com")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("your_email@example.com", "your_password")
            smtp.EnableSsl = True

            smtp.Send(mail)
            MessageBox.Show("Email sent to Chairman successfully.")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        Dim DirectorWindow As New Director()
        DirectorWindow.Show()
        Me.Hide()
    End Sub


    Private Sub EmailSecretary_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("your_email@example.com")
            mail.To.Add("marythiga@gmail.com")
            mail.Subject = "Subject of the Email"
            mail.Body = "This is the body of the email."

            Dim smtp As New SmtpClient("smtp.your_email_provider.com")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("your_email@example.com", "your_password")
            smtp.EnableSsl = True

            smtp.Send(mail)
            MessageBox.Show("Email sent to Chairman successfully.")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
        Dim SecretaryWindow As New Secretary()
        SecretaryWindow.Show()
        Me.Hide()
    End Sub

    Private Sub EmailTreasurer_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("your_email@example.com")
            mail.To.Add("rnyinge2@gmail.com")
            mail.Subject = "Subject of the Email"
            mail.Body = "This is the body of the email."

            Dim smtp As New SmtpClient("smtp.your_email_provider.com")
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential("your_email@example.com", "your_password")
            smtp.EnableSsl = True

            smtp.Send(mail)
            MessageBox.Show("Email sent to Chairman successfully.")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
        Dim TreasurerWindow As New Treasurer()
        TreasurerWindow.Show()
        Me.Hide()
    End Sub

End Class
