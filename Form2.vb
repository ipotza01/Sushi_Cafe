Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("ยืนยันการทำรายการหรือไม่ ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        End If
        Me.Hide()
        Form3.Show()

        '----------------ราคารวมกาแฟ------------------'
        Form3.TextBox1.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)

        Dim total As Integer

        If CheckBox1.Checked = True Then
            total += 45 * Val(TextBox1.Text)
        End If
        If CheckBox2.Checked = True Then
            total += 30 * Val(TextBox2.Text)
        End If
        If CheckBox3.Checked = True Then
            total += 35 * Val(TextBox3.Text)
        End If
        If CheckBox4.Checked = True Then
            total += 25 * Val(TextBox4.Text)
        End If
        If CheckBox5.Checked = True Then
            total += 25 * Val(TextBox5.Text)
        End If
        If CheckBox6.Checked = True Then
            total += 25 * Val(TextBox6.Text)
        End If
        If CheckBox7.Checked = True Then
            total += 69 * Val(TextBox7.Text)
        End If
        If CheckBox8.Checked = True Then
            total += 69 * Val(TextBox8.Text)
        End If
        If CheckBox9.Checked = True Then
            total += 59 * Val(TextBox9.Text)
        End If
        If CheckBox10.Checked = True Then
            total += 59 * Val(TextBox10.Text)
        End If
        Form3.TextBox1.Text = total

        Form3.Label1.Text = "กรุณาตรวจสอบสินค้าอย่างระเอียด : "

        If CheckBox1.Checked = True Then
            Form3.ListBox1.Items.Add("นมชมพูบุก ราคา 45 = " & TextBox1.Text & " แก้ว ")
        End If
        If CheckBox2.Checked = True Then
            Form3.ListBox1.Items.Add("ชาเขียวไข่มุก ราคา. 30 = " & TextBox2.Text & "แก้ว")
        End If
        If CheckBox3.Checked = True Then
            Form3.ListBox1.Items.Add("น้ำทะเลไข่มุก ราคา35 = " & TextBox3.Text & "แก้ว")
        End If
        If CheckBox4.Checked = True Then
            Form3.ListBox1.Items.Add("ชาลูกพีช  ราคา 25 = " & TextBox4.Text & "แก้ว")
        End If
        If CheckBox5.Checked = True Then
            Form3.ListBox1.Items.Add("ชาส้ม ราคา25 = " & TextBox5.Text & "แก้ว")
        End If
        If CheckBox6.Checked = True Then
            Form3.ListBox1.Items.Add("ชาสตอเบอร์รี่ ราคา25 = " & TextBox6.Text & "แก้ว")
        End If
        If CheckBox7.Checked = True Then
            Form3.ListBox1.Items.Add("ปังเย็นสตอเบอร์รี่ ราคา 69 = " & TextBox7.Text & "แก้ว")
        End If
        If CheckBox8.Checked = True Then
            Form3.ListBox1.Items.Add("ปังเย็นฟุตสลัด ราคา 69 = " & TextBox8.Text & "แก้ว")
        End If
        If CheckBox9.Checked = True Then
            Form3.ListBox1.Items.Add("ปังเย็นบลู ราคา59 = " & TextBox9.Text & "แก้ว")
        End If
        If CheckBox10.Checked = True Then
            Form3.ListBox1.Items.Add("ปังเย็นมะม่วง ราคา59 = " & TextBox1.Text & "แก้ว")
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
        CheckBox9.Checked = False
        CheckBox10.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""


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
        CheckBox9.Checked = False
        CheckBox10.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

    End Sub
End Class