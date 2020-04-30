<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BTNMasuk As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BTNMasuk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNClose = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Bell MT", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(643, 97)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(295, 30)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Log in"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(649, 127)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(289, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Silahkan Masukkan Username dan Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUsername
        '
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.ForeColor = System.Drawing.Color.Black
        Me.TxtUsername.Location = New System.Drawing.Point(684, 187)
        Me.TxtUsername.Multiline = True
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(220, 24)
        Me.TxtUsername.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.Location = New System.Drawing.Point(684, 244)
        Me.TxtPassword.Multiline = True
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(220, 24)
        Me.TxtPassword.TabIndex = 3
        '
        'BTNMasuk
        '
        Me.BTNMasuk.BackColor = System.Drawing.Color.Black
        Me.BTNMasuk.FlatAppearance.BorderSize = 0
        Me.BTNMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMasuk.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNMasuk.Location = New System.Drawing.Point(684, 286)
        Me.BTNMasuk.Name = "BTNMasuk"
        Me.BTNMasuk.Size = New System.Drawing.Size(220, 28)
        Me.BTNMasuk.TabIndex = 4
        Me.BTNMasuk.Text = "Masuk"
        Me.BTNMasuk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(684, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 1)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(684, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 1)
        Me.Label2.TabIndex = 7
        '
        'BTNClose
        '
        Me.BTNClose.FlatAppearance.BorderSize = 0
        Me.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNClose.Image = Global.Cashier.My.Resources.Resources.resizeApi_php
        Me.BTNClose.Location = New System.Drawing.Point(920, 3)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.Size = New System.Drawing.Size(18, 18)
        Me.BTNClose.TabIndex = 8
        Me.BTNClose.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Image = Global.Cashier.My.Resources.Resources.lg_56af0c511a7f0
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(637, 500)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(681, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "USERNAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(681, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PASSWORD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AcceptButton = Me.BTNMasuk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(950, 500)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNMasuk)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm1"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
