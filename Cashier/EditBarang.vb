Imports System.Data.OleDb
Public Class EditBarang
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        TextBox1.Enabled = False

        Button1.Text = "Edit"
        Button2.Text = "Close"

        Call Connection()
        DA = New OleDbDataAdapter("Select * from tbl_barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_barang")
        DataGridView1.DataSource = DS.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub EditBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            TextBox1.Enabled = False
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            TextBox1.Enabled = False
            Call Connection()
            Dim UpdateData As String = "Update tbl_barang set NamaBarang = '" & TextBox2.Text & "',Harga = '" & TextBox3.Text & "',Satuan = '" & TextBox4.Text & "',Stok = '" & TextBox5.Text & "' Where KodeBarang = '" & TextBox1.Text & "'"
            CMD = New OleDbCommand(UpdateData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil di Ubah")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Close" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call Connection()
        CMD = New OleDbCommand("Select * From tbl_barang where namaBarang = '" & TextBox2.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            MsgBox("Data tidak ditemukan!")
        Else
            TextBox1.Text = RD.Item("KodeBarang")
            TextBox2.Text = RD.Item("NamaBarang")
            TextBox3.Text = RD.Item("Harga")
            TextBox4.Text = RD.Item("Satuan")
            TextBox5.Text = RD.Item("Stok")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub
End Class