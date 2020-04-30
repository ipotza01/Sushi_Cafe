Imports System.Data.SqlClient

Public Class Form7
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=LAPTOP-AGMQUCVA\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Username,Password from Staff where ID ='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"

        rd = cmd.ExecuteReader
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
        ElseIf rd.HasRows Then
            Form10.Show()
            Me.Hide()
        Else
            MessageBox.Show("ID หรือ Password ไม่ถกต้อง")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.PasswordChar = If(CheckBox1.Checked, "", "*")
    End Sub
End Class