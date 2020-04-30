Imports System.Data.OleDb
Public Class Tambah_Barang
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

        TextBox1.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True

        Button1.Text = "Input"
        Button2.Text = "Close"
        Call NomorOtomatis()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Tambah_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Sub NomorOtomatis()
        Call Connection()
        CMD = New OleDbCommand("Select * from tbl_barang where KodeBarang in (select max(KodeBarang) from tbl_barang)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "BRG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = UrutanKode
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Call Connection()
            Dim InputData As String = "Insert Into tbl_barang values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            CMD = New OleDbCommand(InputData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil di Tambahkan")
            Call KondisiAwal()
        End If
    End Sub

End Class