Imports System.Data.OleDb
Public Class GantiNama
    Sub KondisiAwal()
        TextBox1.Text = MenuUtama.LBLUsername.Text
        TextBox2.Text = MenuUtama.LBLNamaUser.Text
        TextBox3.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        TextBox2.Enabled = False
        TextBox1.Enabled = False

        Button1.Text = "Edit"
        Button2.Text = "Close"
    End Sub

    Private Sub GantiNama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Call Connection()
            Dim UpdateData As String = "Update tbl_admin set nama_admin = '" & TextBox3.Text & "' Where kode_admin = '" & TextBox1.Text & "'"
            CMD = New OleDbCommand(UpdateData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Nama Berhasil di Ganti, Silahkan Login Kembali untuk melihat perubahan!")
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
End Class