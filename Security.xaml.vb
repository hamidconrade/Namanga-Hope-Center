﻿' Security.xaml.vb
Class Security
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ChairmanButton_Click(sender As Object, e As RoutedEventArgs)
        ' Action for Chairman button click
        MessageBox.Show("Chairman button clicked in Security window")
    End Sub

    Private Sub SecretaryButton_Click(sender As Object, e As RoutedEventArgs)
        ' Action for Secretary button click
        MessageBox.Show("Secretary button clicked in Security window")
    End Sub

    Private Sub TreasurerButton_Click(sender As Object, e As RoutedEventArgs)
        ' Action for Treasurer button click
        MessageBox.Show("Treasurer button clicked in Security window")
    End Sub
End Class