Public Class LaporanBulanan
    Sub KondisiAwal()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("JANUARI")
        ComboBox1.Items.Add("FEBRUARI")
        ComboBox1.Items.Add("MARET")
        ComboBox1.Items.Add("APRIL")
        ComboBox1.Items.Add("MEI")
        ComboBox1.Items.Add("JUNI")
        ComboBox1.Items.Add("JULI")
        ComboBox1.Items.Add("AGUSTUS")
        ComboBox1.Items.Add("SEPTEMBER")
        ComboBox1.Items.Add("OKTOBER")
        ComboBox1.Items.Add("NOVEMBER")
        ComboBox1.Items.Add("DESEMBER")
        ComboBox2.Items.Clear()
        ComboBox2.Text = Date.Now.Year
        For i As Integer = 0 To 1
            ComboBox2.Items.Add(Date.Now.Year - i)
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LaporanBulananvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silahkan isi Bulan dan Tahunnya terlebih dahulu!")
        Else
            FormLaporanBulanan.tbl_detailjualTableAdapter.FillByBulanan(FormLaporanBulanan.KasirDataSet.tbl_detailjual, Me.Label3.Text, Me.ComboBox2.Text)
            FormLaporanBulanan.Show()
        End If





        'If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
        '    MsgBox("Silahkan isi Bulan dan Tahunnya terlebih dahulu!")
        'Else
        '    'Call Connection()
        '    'Cmd = New OdbcCommand("Select * From tbl_jual where tanggalJual='" & Val(ComboBox1.Text) & "'", Conn)
        '    'Rd = Cmd.ExecuteReader
        '    'Rd.Read()
        '    'If Rd.HasRows Then
        '    AxCrystalReport1.SelectionFormula = "Month({tbl_jual.tanggaljual})=" & Val(ComboBox1.Text) & " and year({tbl_jual.tanggaljual})=" & Val(ComboBox2.Text)
        '    AxCrystalReport1.ReportFileName = "LaporanBulanan.rpt"
        '    AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        '    AxCrystalReport1.RetrieveDataFiles()
        '    AxCrystalReport1.Action = 1
        '    '    Else
        '    '    MsgBox("Data tidak ditemukan!")
        '    '    TextBox1.Text = ""
        '    'End If
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "JANUARI" Then
            Label3.Text = "1"
        ElseIf ComboBox1.Text = "FEBRUARI" Then
            Label3.Text = "2"
        ElseIf ComboBox1.Text = "MARET" Then
            Label3.Text = "3"
        ElseIf ComboBox1.Text = "APRIL" Then
            Label3.Text = "4"
        ElseIf ComboBox1.Text = "MEI" Then
            Label3.Text = "5"
        ElseIf ComboBox1.Text = "JUNI" Then
            Label3.Text = "6"
        ElseIf ComboBox1.Text = "JULI" Then
            Label3.Text = "7"
        ElseIf ComboBox1.Text = "AGUSTUS" Then
            Label3.Text = "8"
        ElseIf ComboBox1.Text = "SEPTEMBER" Then
            Label3.Text = "9"
        ElseIf ComboBox1.Text = "OKTOBER" Then
            Label3.Text = "10"
        ElseIf ComboBox1.Text = "NOVEMBER" Then
            Label3.Text = "11"
        ElseIf ComboBox1.Text = "DESEMBER" Then
            Label3.Text = "12"
        End If
    End Sub
End Class