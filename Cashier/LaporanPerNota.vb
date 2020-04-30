Public Class LaporanPerNota
    Sub kondisiawal()
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub LaporanPerNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kondisiawal()
    End Sub

    Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FormLaporanPerNota.tbl_detailjualTableAdapter.FillByNoJual(FormLaporanPerNota.KasirDataSet.tbl_detailjual, Me.TextBox1.Text)
        FormLaporanPerNota.Show()

        'AxCrystalReport1.SelectionFormula = "totext({tbl_jual.TanggalJual})='" & DateTimePicker1.Value & "'"
        'AxCrystalReport1.ReportFileName = "LaporanHarian.rpt"
        'AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        'AxCrystalReport1.RetrieveDataFiles()
        'AxCrystalReport1.Action = 1
    End Sub
End Class