Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("ทำรายการสำเร็จ.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Form1.Show()
        



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("ยกเลิกการทำรายการ.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Form2.Show()

        Form2.CheckBox1.Checked = False
        Form2.CheckBox2.Checked = False
        Form2.CheckBox3.Checked = False
        Form2.CheckBox4.Checked = False
        Form2.CheckBox5.Checked = False
        Form2.CheckBox6.Checked = False
        Form2.CheckBox7.Checked = False
        Form2.CheckBox8.Checked = False
        Form2.CheckBox9.Checked = False
        Form2.CheckBox10.Checked = False

        Form2.TextBox1.Text = ""
        Form2.TextBox2.Text = ""
        Form2.TextBox3.Text = ""
        Form2.TextBox4.Text = ""
        Form2.TextBox5.Text = ""
        Form2.TextBox6.Text = ""
        Form2.TextBox7.Text = ""
        Form2.TextBox8.Text = ""
        Form2.TextBox9.Text = ""
        Form2.TextBox10.Text = ""

        ListBox1.Items.Clear()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class