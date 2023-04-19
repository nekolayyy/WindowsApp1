'#include <iostream>
Imports MySql.Data.MySqlClient
Module Module1
    Public myconn As New MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_toDB()
        myConnectionString = "server=localhost;port=3306;" _
                    & "uid=root;" _
                    & "pwd=nekolayyypogi22-;" _
                    & "database=order_management"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password!")
            End Select

        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub


End Module