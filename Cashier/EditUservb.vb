Imports System.Data.OleDb
Public Class EditUservb
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")

        Button1.Enabled = True
        Button2.Enabled = True

        Button1.Text = "Edit"
        Button2.Text = "Close"

        Call Connection()
        DA = New OleDbDataAdapter("Select kode_admin AS Username,nama_admin,level_admin from tbl_admin", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_admin")
        DataGridView1.DataSource = DS.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub EditUservb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Masukkan Data Terlebih Dahulu")
            Else
                Call Connection()
            Dim UpdateData As String = "Update tbl_admin set nama_admin = '" & TextBox2.Text & "',password_admin = '" & TextBox3.Text & "',level_admin = '" & ComboBox1.Text & "' Where kode_admin = '" & TextBox1.Text & "'"
            CMD = New OleDbCommand(UpdateData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Ubah")
                Call KondisiAwal()
            End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call Connection()
        CMD = New OleDbCommand("Select * From tbl_admin where kode_admin = '" & TextBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            MsgBox("Data tidak ditemukan!")
        Else
            TextBox1.Enabled = False
            TextBox1.Text = RD.Item("Kode_Admin")
            TextBox2.Text = RD.Item("Nama_Admin")
            TextBox3.Text = RD.Item("Password_Admin")
            ComboBox1.Text = RD.Item("Level_Admin")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Close" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub
End Class