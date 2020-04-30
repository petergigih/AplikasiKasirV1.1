<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusUser
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLLevel = New System.Windows.Forms.Label()
        Me.LBLNama = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(24, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 1)
        Me.Label6.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 29)
        Me.Panel1.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DELETE USER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(249, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 31)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LBLLevel)
        Me.Panel2.Controls.Add(Me.LBLNama)
        Me.Panel2.Controls.Add(Me.Nama)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(2, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 321)
        Me.Panel2.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 1)
        Me.Label2.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(19, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLLevel
        '
        Me.LBLLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLLevel.Location = New System.Drawing.Point(88, 62)
        Me.LBLLevel.Name = "LBLLevel"
        Me.LBLLevel.Size = New System.Drawing.Size(138, 23)
        Me.LBLLevel.TabIndex = 86
        Me.LBLLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNama
        '
        Me.LBLNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNama.Location = New System.Drawing.Point(88, 40)
        Me.LBLNama.Name = "LBLNama"
        Me.LBLNama.Size = New System.Drawing.Size(138, 22)
        Me.LBLNama.TabIndex = 85
        Me.LBLNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nama
        '
        Me.Nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nama.Location = New System.Drawing.Point(19, 40)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(67, 23)
        Me.Nama.TabIndex = 84
        Me.Nama.Text = "Nama"
        Me.Nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 182)
        Me.DataGridView1.TabIndex = 33
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(198, 17)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 20)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Username"
        '
        'HapusUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(358, 348)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HapusUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HapusUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLLevel As System.Windows.Forms.Label
    Friend WithEvents LBLNama As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
