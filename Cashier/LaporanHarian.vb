Public Class LaporanHarian
    Sub kondisiawal()
        DateTimePicker1.Text = Today
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LaporanHarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'FormLaporan.ReportViewer1.

        FormLaporanHarian.tbl_detailjualTableAdapter.FillByTanggalJual(FormLaporanHarian.KasirDataSet.tbl_detailjual, Me.DateTimePicker1.Text)
        FormLaporanHarian.Show()


        'AxCrystalReport1.SelectionFormula = "totext({tbl_jual.TanggalJual})='" & DateTimePicker1.Value & "'"
        'AxCrystalReport1.ReportFileName = "LaporanHarian.rpt"
        'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        'AxCrystalReport1.RetrieveDataFiles()
        'AxCrystalReport1.Action = 1
    End Sub
End Class