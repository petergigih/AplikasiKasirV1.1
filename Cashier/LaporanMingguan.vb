Public Class LaporanMingguan
    Private Sub LaporanHarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker2.Text = Today
        DateTimePicker3.Text = Today
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormLaporanMingguan.tbl_detailjualTableAdapter.FillByMingguan(FormLaporanMingguan.KasirDataSet.tbl_detailjual, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text)
        FormLaporanMingguan.Show()


        'AxCrystalReport1.SelectionFormula = "{tbl_jual.tanggaljual}in date (" & Label7.Text & ") to date(" & Label8.Text & ")"
        'AxCrystalReport1.ReportFileName = "LaporanMingguan.rpt"
        'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        'AxCrystalReport1.RetrieveDataFiles()
        'AxCrystalReport1.Action = 1
    End Sub
End Class