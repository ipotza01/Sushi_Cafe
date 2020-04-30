<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FinalDataSet = New WindowsApp9.FinalDataSet()
        Me.SushiTotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SushiTotalTableAdapter = New WindowsApp9.FinalDataSetTableAdapters.SushiTotalTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SushiTotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CatomerDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.NumProductDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SushiTotalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 110)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(718, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(731, 111)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "เพิ่มข้อมูล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(731, 168)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 54)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "จัดเก็บข้อมูล"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(731, 352)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ลบข้อมูล"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(731, 410)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 51)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "ออก"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.WindowsApp9.My.Resources.Resources.images
        Me.PictureBox3.Location = New System.Drawing.Point(752, 3)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(98, 103)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(112, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 107)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "S U S H I _ C A F E"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp9.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(9, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApp9.My.Resources.Resources.images
        Me.PictureBox2.Location = New System.Drawing.Point(731, 227)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(118, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'FinalDataSet
        '
        Me.FinalDataSet.DataSetName = "FinalDataSet"
        Me.FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SushiTotalBindingSource
        '
        Me.SushiTotalBindingSource.DataMember = "SushiTotal"
        Me.SushiTotalBindingSource.DataSource = Me.FinalDataSet
        '
        'SushiTotalTableAdapter
        '
        Me.SushiTotalTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CatomerDataGridViewTextBoxColumn
        '
        Me.CatomerDataGridViewTextBoxColumn.DataPropertyName = "Catomer"
        Me.CatomerDataGridViewTextBoxColumn.HeaderText = "Catomer"
        Me.CatomerDataGridViewTextBoxColumn.Name = "CatomerDataGridViewTextBoxColumn"
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "Product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'NumProductDataGridViewTextBoxColumn
        '
        Me.NumProductDataGridViewTextBoxColumn.DataPropertyName = "numProduct"
        Me.NumProductDataGridViewTextBoxColumn.HeaderText = "numProduct"
        Me.NumProductDataGridViewTextBoxColumn.Name = "NumProductDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(859, 470)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SushiTotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FinalDataSet As FinalDataSet
    Friend WithEvents SushiTotalBindingSource As BindingSource
    Friend WithEvents SushiTotalTableAdapter As FinalDataSetTableAdapters.SushiTotalTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
