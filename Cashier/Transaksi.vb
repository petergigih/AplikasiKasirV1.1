Imports System.Data.OleDb

Public Class Transaksi

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox3.Text = ""
        LBLKodeBarang.Text = ""
        LBLSatuan.Text = ""
        LBLHarga.Text = ""
        LBLStok.Text = ""
        LBLTotal.Text = ""
        LBLItem.Text = ""
        LBLKembali.Text = ""
        LBLTanggal.Text = Format(Today, "dd/MM/yyyy")
        LBLAdmin.Text = MenuUtama.LBLNamaUser.Text
        Call NomorOtomatis()
        Call BuatKolom()
        Call MunculNamaBarang()
    End Sub

    Private Sub Transaksi_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub NomorOtomatis()
        Call Connection()
        CMD = New OleDbCommand("Select * from tbl_jual where nojual in (select max(nojual) from tbl_jual)", CONN)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLTransaksi.Text = UrutanKode
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Satuan", "Satuan")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub MunculNamaBarang()
        Call Connection()
        ComboBox2.Items.Clear()
        CMD = New OleDbCommand("Select * from tbl_barang", CONN)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item(1))
        Loop
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Connection()
        CMD = New OleDbCommand("Select * from tbl_barang where namabarang ='" & ComboBox2.Text & "'", CONN)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLKodeBarang.Text = RD!kodebarang
            LBLHarga.Text = RD!harga
            LBLSatuan.Text = RD!satuan
            LBLStok.Text = RD!stok
        End If
        TextBox3.Focus()

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Me.Close()
        'End

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Sub RumusTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(5).Value
            LBLTotal.Text = hitung
        Next
    End Sub

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LBLItem.Text = HitungItem
        Next
    End Sub

    Private Sub ButtonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInsert.Click
        If ComboBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan masukan nama barang dan jumlah barang!")
        Else
            If Val(LBLStok.Text) < Val(TextBox3.Text) Then
                MsgBox("Jumlah Pembelian Melebihi Stok Barang!")
            Else
                DataGridView1.Rows.Add(New String() {LBLKodeBarang.Text, ComboBox2.Text, LBLHarga.Text, TextBox3.Text, LBLSatuan.Text, Val(LBLHarga.Text) * Val(TextBox3.Text)})
                Call RumusTotal()
                ComboBox2.Text = ""
                LBLHarga.Text = ""
                TextBox3.Text = ""
                LBLKodeBarang.Text = ""
                LBLSatuan.Text = ""
                LBLStok.Text = ""

                Call RumusCariItem()
                DataGridView1.ReadOnly = True
                'Dim Baris As String = 0
                'If ComboBox2.Text.Equals(DataGridView1.Rows(Baris).Cells(1).Value) Then
                '    ComboBox2.Text = ComboBox2.Text - DataGridView1.Rows(Baris).Cells(1).Value
                'End If
            End If
        End If
    End Sub

    Private Sub ButtonDibayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDibayar.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukan Pembayaran!")
            TextBox1.Focus()
        ElseIf LBLTotal.Text = "" Then
            MsgBox("Masukan Transaksi!")
        ElseIf Val(TextBox1.Text) < Val(LBLTotal.Text) Then
            MsgBox("Pembayaran Kurang!")
        ElseIf Val(TextBox1.Text) = Val(LBLTotal.Text) Then
            LBLKembali.Text = 0
        ElseIf Val(TextBox1.Text) > Val(LBLTotal.Text) Then
            LBLKembali.Text = Val(TextBox1.Text) - Val(LBLTotal.Text)
            ButtonSimpan.Focus()
        End If
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        If LBLKembali.Text = "" Or LBLTotal.Text = "" Or DataGridView1.RowCount = 1 Then
            MsgBox("Transaksi tidak ada, silahkan lakukan transaksi terlebih dahulu")
        Else

            Dim SimpanJual As String = "Insert into tbl_jual values ('" & LBLTransaksi.Text & "', '" & LBLAdmin.Text & "','" & LBLJam.Text & "','" & LBLTanggal.Text & "','" & LBLItem.Text & "','" & LBLTotal.Text & "')" 'LBLAdmin.Text"
            CMD = New OleDbCommand(SimpanJual, CONN)
            CMD.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLTransaksi.Text & "', '" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "', '" & DataGridView1.Rows(Baris).Cells(5).Value & "', '" & LBLTanggal.Text & "')"
                CMD = New OleDbCommand(SimpanDetail, CONN)
                CMD.ExecuteNonQuery()

                CMD = New OleDbCommand("Select * from tbl_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                Dim KurangiStok As String = "update tbl_Barang set stok = '" & RD.Item("stok") - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                CMD = New OleDbCommand(KurangiStok, CONN)
                CMD.ExecuteNonQuery()
            Next
            If MessageBox.Show("Cetak Nota?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                FormLaporanPerNota.tbl_detailjualTableAdapter.FillByNoJual(FormLaporanPerNota.KasirDataSet.tbl_detailjual, Me.LBLTransaksi.Text)
                FormLaporanPerNota.Show()

                'MsgBox("Berhasil")
                'AxCrystalReport1.SelectionFormula = "totext({tbl_jual.Nojual})='" & LBLNoJual.Text & "'"
                'AxCrystalReport1.ReportFileName = "notajual.rpt"
                'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                'AxCrystalReport1.RetrieveDataFiles()
                'AxCrystalReport1.Action = 1
            Else
                MsgBox("Transaksi telah berhasil disimpan")
            End If
            Call KondisiAwal()
        End If
    End Sub
End Class