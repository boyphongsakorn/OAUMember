﻿Public Class FreeUser
    Private Sub button3_Click(sender As Object, e As RoutedEventArgs) Handles button3.Click
        Dim window As New Login()
        window.Show()
        Me.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        End
    End Sub

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Process.Start("MinecraftAuto.exe")
    End Sub

    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        Process.Start("MinecraftAutoSP.exe")
    End Sub

    Private Sub button4_Click(sender As Object, e As RoutedEventArgs) Handles button4.Click
        Process.Start("https://optifineautoupdater.ga/")
    End Sub
End Class
