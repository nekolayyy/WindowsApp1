Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loginbtn.Click
        With Me
            Call Connect_toDB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from customer where username = '" _
                & .usernamebtn.Text & "' and password = ('" _
                & .passwordbtn.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Form2.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form3.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class