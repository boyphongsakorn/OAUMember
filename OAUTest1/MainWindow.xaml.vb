Class MainWindow
    Private Sub ExitBox_Click(sender As Object, e As RoutedEventArgs) Handles ExitBox.Click
        End
    End Sub
    Private Sub UpdateBox_Click(sender As Object, e As RoutedEventArgs) Handles UpdateBox.Click
        If My.Computer.Network.IsAvailable Then
            Process.Start("Run.bat")
            End
        Else
            MsgBox("internet not connected.")
        End If
    End Sub
    Private Sub StartM_Click(sender As Object, e As RoutedEventArgs) Handles StartM.Click
        Process.Start("MinecraftAuto.exe")
        End
    End Sub
    Private Sub StartSP_Click(sender As Object, e As RoutedEventArgs) Handles StartSP.Click
        Process.Start("MinecraftAutoSP.exe")
        End
    End Sub
End Class
