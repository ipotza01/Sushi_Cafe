Imports System.Data.SqlClient
Public Class Form6
    Dim con As New SqlConnection("Data Source=LAPTOP-AGMQUCVA\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True")
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.PasswordChar = If(CheckBox1.Checked, "", "*")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As String = "INSERT INTO User(Username,Password,Tel,Age,Male,Female) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & RadioButton1.Checked & "','" & RadioButton2.Checked & "')"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=LAPTOP-AGMQUCVA\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Username,Password from User where Username ='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "' and Tel='" & TextBox3.Text & "' and Age= '" & TextBox4.Text & "' and Male= '" & RadioButton1.Checked & "' and Female= '" & RadioButton2.Checked & "'"

        rd = cmd.ExecuteReader
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        Else
            MessageBox.Show("Sign Up สำเร็จ")
            Form1.Show()
            Me.Hide()
        End If

        ExecuteQuery(insert)
    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, con)
        con.Open()
        command.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class