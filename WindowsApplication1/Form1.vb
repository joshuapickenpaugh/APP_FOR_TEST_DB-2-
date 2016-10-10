'Joshua Pickenpaugh
'October 10th, 2016
'Self-modified DB app (made table and app)

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
'Below is changed from "Imports System.Data.EntityClient" to this as of VS 4.3:
Imports System.Data.Entity.Core.EntityClient
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        '"fname" is the table, so using "first_name" is needed since that is the 
        'litteral column name in the table I created. ___IT WORKED!___:

        Dim cmdString As String = "SELECT fname.first_name FROM TEST_DBEntities.persons as fname"
        'This was changed to "name=TEST_DBEntities":
        Dim Conn = New EntityConnection("name=TEST_DBEntities")
        Conn.Open()
        Dim cmd = Conn.CreateCommand()
        cmd.CommandText = cmdString
        Dim rd As EntityDataReader
        rd = cmd.ExecuteReader(CommandBehavior.SequentialAccess)
        'Clears the list box before being filled:
        lstBoxPersons.Items.Clear()

        While (rd.Read())
            'This was changed to "first_name":
            lstBoxPersons.Items.Add(rd("first_name"))
        End While

        Conn.Close()

    End Sub
End Class
