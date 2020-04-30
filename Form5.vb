Imports System.Data.SqlClient
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=LAPTOP-AGMQUCVA\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Username,Password from User where Username ='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"

        rd = cmd.ExecuteReader
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        ElseIf rd.HasRows Then
            Form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username หรือ Password ไม่ถกต้อง")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.PasswordChar = If(CheckBox1.Checked, "", "*")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class