Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalDataSet.SushiTotal' table. You can move, or remove it, as needed.
        Me.SushiTotalTableAdapter.Fill(Me.FinalDataSet.SushiTotal)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '-------------- เพิ่มข้อมูล -------------------'
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SushiTotalBindingSource.AddNew()
        SushiTotalBindingSource.EndEdit()
        SushiTotalTableAdapter.Update(FinalDataSet.SushiTotal)
        MessageBox.Show("ทำรายการสำเร็จ.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows(0).Cells(1).Value = Val(Form5.TextBox1.Text)


        If Form2.CheckBox1.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "นมชมพูบุก"
        End If
        If Form2.CheckBox2.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ชาเขียวไข่มุก"
        End If
        If Form2.CheckBox3.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "น้ำทะเลไข่มุก"
        End If
        If Form2.CheckBox4.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ชาลูกพีช"
        End If
        If Form2.CheckBox5.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ชาส้ม"
        End If
        If Form2.CheckBox6.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ชาสตอเบอร์รี่"
        End If
        If Form2.CheckBox7.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ปังเย็นสตอเบอร์รี่ "
        End If
        If Form2.CheckBox8.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ปังเย็นฟุตสลัด "
        End If
        If Form2.CheckBox9.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ปังเย็นบลู "
        End If
        If Form2.CheckBox10.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ปังเย็นมะม่วง "
        End If

        If Form4.CheckBox1.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ดูโอ้ปลา"
        End If
        If Form4.CheckBox2.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "หน้าไข่หวาน"
        End If
        If Form4.CheckBox3.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ห่อสาหร่ายแซลม่อน"
        End If
        If Form4.CheckBox4.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "หอสาหร่ายไข่หวาน"
        End If
        If Form4.CheckBox5.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "หน้าเเซลม่อน ไข่ปลา"
        End If
        If Form4.CheckBox6.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "หน้าไข่ปลา"
        End If
        If Form4.CheckBox7.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "หน้าชูชิ "
        End If
        If Form4.CheckBox8.Checked = True Then
            DataGridView1.Rows(0).Cells(2).Value = "ห่อสาหร่ายปลาโรยไข่ "
        End If

        DataGridView1.Rows(0).Cells(4).Value = Val(Form3.TextBox1.Text)
        DataGridView1.Rows(0).Cells(3).Value = Val(Form2.TextBox1.Text) + Val(Form2.TextBox2.Text) + Val(Form2.TextBox3.Text) + Val(Form2.TextBox4.Text) + Val(Form2.TextBox5.Text) + Val(Form2.TextBox6.Text) + Val(Form2.TextBox7.Text) + Val(Form2.TextBox8.Text) + Val(Form2.TextBox9.Text) + Val(Form2.TextBox10.Text)
        DataGridView1.Rows(0).Cells(3).Value = Val(Form4.TextBox1.Text) + Val(Form4.TextBox2.Text) + Val(Form4.TextBox3.Text) + Val(Form4.TextBox4.Text) + Val(Form4.TextBox5.Text) + Val(Form4.TextBox6.Text) + Val(Form4.TextBox7.Text) + Val(Form4.TextBox8.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '-------------- ลบข้อมูล -------------------'
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SushiTotalBindingSource.RemoveCurrent()
        SushiTotalBindingSource.EndEdit()
        SushiTotalTableAdapter.Update(FinalDataSet.SushiTotal)
        MessageBox.Show("ทำรายการสำเร็จ.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class