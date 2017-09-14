Imports MySql.Data.MySqlClient

Public Class Register
    Dim Mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        Dim window As New Login()
        window.Show()
        Me.Close()
    End Sub

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server=db4free.net;port=3307;userid=boyoau;password=team1556th;database=boyoau;"
        Dim READER As MySqlDataReader

        Try
            Mysqlconn.Open()
            Dim Query As String
            Query = "insert into boyoau.oaumember (username,password,loginstatus,timemember) values ('" & UNTextBox.Text & "','" & PWBOX.Password & "',0,NOW() + INTERVAL 1 MONTH)"
            If PWBOX.Password = passwordBox.Password Then
                COMMAND = New MySqlCommand(Query, Mysqlconn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("สมัครสำเร็จ")
            Else
                MessageBox.Show("รหัสผ่านไม่ตรงกัน")
            End If
            Mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub
End Class
