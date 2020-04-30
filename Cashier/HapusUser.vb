Imports System.Data.OleDb
Public Class HapusUser
    Sub KondisiAwal()
        TextBox1.Text = ""
        LBLLevel.Text = ""
        LBLNama.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True

        Button1.Text = "Delete"
        Button2.Text = "Close"

        Call Connection()
        DA = New OleDbDataAdapter("Select kode_admin AS Username,nama_admin,level_admin from tbl_admin", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_admin")
        DataGridView1.DataSource = DS.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub HapusUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or LBLLevel.Text = "" Or LBLNama.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Dim Choose = MessageBox.Show("Anda akan Menghapus Data ini ?", "WARNING !", MessageBoxButtons.YesNo)
            If Choose = DialogResult.Yes Then
                Call Connection()
                Dim DeleteData As String = "Delete From tbl_admin Where kode_admin = '" & TextBox1.Text & "'"
                CMD = New OleDbCommand(DeleteData, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus")
                Call KondisiAwal()
            ElseIf Choose = DialogResult.No Then
                Call KondisiAwal()
            End If
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
            TextBox1.Text = RD.Item("Kode_Admin")
            LBLNama.Text = RD.Item("Nama_Admin")
            LBLLevel.Text = RD.Item("Level_Admin")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Close" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
End Class