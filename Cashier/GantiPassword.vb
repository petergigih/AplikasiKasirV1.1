Imports System.Data.OleDb
Public Class GantiPassword
    Sub KondisiAwal()
        TextBox1.Text = MenuUtama.LBLUsername.Text
        TextBox2.Text = MenuUtama.LBLPassword.Text
        TextBox3.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        TextBox2.Enabled = False
        TextBox1.Enabled = False

        Button1.Text = "Edit"
        Button2.Text = "Close"
    End Sub

    Private Sub GantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Call Connection()
            Dim UpdateData As String = "Update tbl_admin set password_admin = '" & TextBox3.Text & "' Where kode_admin = '" & TextBox1.Text & "'"
            CMD = New OleDbCommand(UpdateData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Password Berhasil di Ganti, Silahkan Login Kembali!")
            Me.Close()
            MenuUtama.Close()
            Login.Show()
            Login.TxtUsername.Text = ""
            Login.TxtPassword.Text = ""
            Login.TxtUsername.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.PasswordChar = ""
    End Sub

    Private Sub Button4_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        TextBox3.PasswordChar = "*"
    End Sub
End Class