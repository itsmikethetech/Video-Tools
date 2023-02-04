Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("convert.bat")
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("transcode.bat")
    End Sub

    Private Sub ProgressBar_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of T))

    End Sub
End Class

