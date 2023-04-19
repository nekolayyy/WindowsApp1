Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Call Connect_toDB()
        Dim mycmd As New MySqlCommand

        Dim first_name As String = firstnametextbox.Text
        Dim last_name As String = lastnametextbox.Text
        Dim username As String = usernametextbox.Text
        Dim password As String = passwordtextbox.Text

        Dim sql As String = "INSERT INTO customer (first_name, last_name, username, password) VALUES (@first_name, @last_name, @username, @password)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@first_name", first_name)
        mycmd.Parameters.AddWithValue("@last_name", password)
        mycmd.Parameters.AddWithValue("@username", username)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        Form1.Show()
        Hide()


    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub passwordtextbox_TextChanged(sender As Object, e As EventArgs) Handles passwordtextbox.TextChanged

    End Sub

    Private Sub firstnametextbox_TextChanged(sender As Object, e As EventArgs) Handles firstnametextbox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class