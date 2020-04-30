<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusBarang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLHarga = New System.Windows.Forms.Label()
        Me.LBLKodeBarang = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLSatuan = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLStok = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(16, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 1)
        Me.Label2.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(19, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 23)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Harga"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLHarga
        '
        Me.LBLHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHarga.Location = New System.Drawing.Point(102, 62)
        Me.LBLHarga.Name = "LBLHarga"
        Me.LBLHarga.Size = New System.Drawing.Size(82, 23)
        Me.LBLHarga.TabIndex = 86
        Me.LBLHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLKodeBarang
        '
        Me.LBLKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKodeBarang.Location = New System.Drawing.Point(102, 40)
        Me.LBLKodeBarang.Name = "LBLKodeBarang"
        Me.LBLKodeBarang.Size = New System.Drawing.Size(138, 22)
        Me.LBLKodeBarang.TabIndex = 85
        Me.LBLKodeBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nama
        '
        Me.Nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nama.Location = New System.Drawing.Point(19, 40)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(77, 23)
        Me.Nama.TabIndex = 84
        Me.Nama.Text = "Kode Barang"
        Me.Nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 157)
        Me.DataGridView1.TabIndex = 33
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(212, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 20)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.LBLStok)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LBLSatuan)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LBLHarga)
        Me.Panel2.Controls.Add(Me.LBLKodeBarang)
        Me.Panel2.Controls.Add(Me.Nama)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(2, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 362)
        Me.Panel2.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(19, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Satuan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLSatuan
        '
        Me.LBLSatuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLSatuan.Location = New System.Drawing.Point(102, 85)
        Me.LBLSatuan.Name = "LBLSatuan"
        Me.LBLSatuan.Size = New System.Drawing.Size(82, 23)
        Me.LBLSatuan.TabIndex = 89
        Me.LBLSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 31)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DELETE BARANG"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 29)
        Me.Panel1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(19, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Stok"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLStok
        '
        Me.LBLStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLStok.Location = New System.Drawing.Point(102, 108)
        Me.LBLStok.Name = "LBLStok"
        Me.LBLStok.Size = New System.Drawing.Size(82, 23)
        Me.LBLStok.TabIndex = 91
        Me.LBLStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HapusBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(358, 389)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HapusBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HapusBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLHarga As System.Windows.Forms.Label
    Friend WithEvents LBLKodeBarang As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLSatuan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLStok As System.Windows.Forms.Label
End Class
