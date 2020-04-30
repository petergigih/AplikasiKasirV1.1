Imports System.Data.OleDb
Public Class HapusBarang
    Sub KondisiAwal()
        TextBox1.Text = ""
        LBLKodeBarang.Text = ""
        LBLHarga.Text = ""
        LBLSatuan.Text = ""
        LBLStok.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True

        Button1.Text = "Delete"
        Button2.Text = "Close"

        Call Connection()
        DA = New OleDbDataAdapter("Select * from tbl_barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_barang")
        DataGridView1.DataSource = DS.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub HapusBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or LBLHarga.Text = "" Or LBLKodeBarang.Text = "" Or LBLSatuan.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Dim Choose = MessageBox.Show("Anda akan Menghapus Data ini ?", "WARNING !", MessageBoxButtons.YesNo)
            If Choose = DialogResult.Yes Then
                Call Connection()
                Dim DeleteData As String = "Delete From tbl_barang Where KodeBarang = '" & LBLKodeBarang.Text & "'"
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
        CMD = New OleDbCommand("Select * From tbl_barang where namaBarang = '" & TextBox1.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            MsgBox("Data tidak ditemukan!")
        Else
            LBLKodeBarang.Text = RD.Item("KodeBarang")
            LBLHarga.Text = RD.Item("Harga")
            LBLSatuan.Text = RD.Item("Satuan")
            LBLStok.Text = RD.Item("Stok")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class