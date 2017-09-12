Imports MySql.Data.MySqlClient

Public Class Login
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        End
    End Sub
    Private Sub CCB_Click(sender As Object, e As RoutedEventArgs) Handles CCB.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=db4free.net;port=3307;userid=boyoau;password=team1556th;database=boyoau;"

        Try
            Mysqlconn.Open()
            MessageBox.Show("Connect To MySQL Server is working")
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try

    End Sub
    Private Sub Login1_Click(sender As Object, e As RoutedEventArgs) Handles Login1.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=db4free.net;port=3307;userid=boyoau;password=team1556th;database=boyoau;"
        Dim READER As MySqlDataReader
        Try
            Mysqlconn.Open()
            Dim Query As String
            Query = "select * from boyoau.oaumember where username='" & UNBOX.Text & "' and password='" & PWBOX.Password & "'"
            COMMAND = New MySqlCommand(Query, Mysqlconn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While
            If count = 1 Then
                MessageBox.Show("Username And Password are correct")
            ElseIf count > 1 Then
                MessageBox.Show("Username And Password are Duplicate")
            Else
                MessageBox.Show("Username And Password are not correct")
            End If
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub
End Class
