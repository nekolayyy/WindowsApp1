Imports MySql.Data.MySqlClient
Imports System.IO

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
                Form4.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String = "C:\Users\hale3\source\repos\WindowsApp1\WindowsApp1\usermanual\Austria--EDPact7.pdf"

        If File.Exists(filePath) Then
            Process.Start(filePath)
        Else
            MessageBox.Show("File not found")
        End If
    End Sub

End Class