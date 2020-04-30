Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("ยืนยันการทำรายการหรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        End If
        Me.Hide()
        Form3.Show()

        Dim a, b, c, d, f, g, h, i As Integer
        Form3.TextBox1.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        If CheckBox1.Checked = True Then
            a = 85
        End If
        If CheckBox2.Checked = True Then
            b = 90
        End If
        If CheckBox3.Checked = True Then
            c = 100
        End If
        If CheckBox4.Checked = True Then
            d = 120
        End If
        If CheckBox5.Checked = True Then
            f = 130
        End If
        If CheckBox6.Checked = True Then
            g = 140
        End If
        If CheckBox7.Checked = True Then
            h = 120
        End If
        If CheckBox8.Checked = True Then
            i = 130
        End If
        Form3.TextBox1.Text = a + b + c + d + f + g + h + i

        Form3.Label1.Text = "กรุณาตรวจสอบสินค้าอย่างระเอียด : "

        If CheckBox1.Checked = True Then
            Form3.ListBox1.Items.Add("ดูโอ้ปลา ราคา 45 = " & TextBox1.Text & " ชิ้น ")
        End If
        If CheckBox2.Checked = True Then
            Form3.ListBox1.Items.Add("หน้าไข่หวาน ราคา10 = " & TextBox2.Text & "ชิ้น")
        End If
        If CheckBox3.Checked = True Then
            Form3.ListBox1.Items.Add("ห่อสาหร่ายแซลม่อน ราคา30 = " & TextBox3.Text & "ชิ้น")
        End If
        If CheckBox4.Checked = True Then
            Form3.ListBox1.Items.Add("หอสาหร่ายไข่หวาน ราคา25 = " & TextBox4.Text & "ชิ้น")
        End If
        If CheckBox5.Checked = True Then
            Form3.ListBox1.Items.Add("หน้าเเซลม่อน ไข่ปลา 15 บาท = " & TextBox5.Text & "ชิ้น")
        End If
        If CheckBox6.Checked = True Then
            Form3.ListBox1.Items.Add("หน้าไข่ปลา ราคา10 = " & TextBox6.Text & "ชิ้น")
        End If
        If CheckBox7.Checked = True Then
            Form3.ListBox1.Items.Add("หน้าชูชิ ราคา 20 = " & TextBox7.Text & "ชิ้น")
        End If
        If CheckBox8.Checked = True Then
            Form3.ListBox1.Items.Add("ห่อสาหร่ายปลาโรยไข่ ราคา 49 = " & TextBox8.Text & "ชิ้น")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub
End Class