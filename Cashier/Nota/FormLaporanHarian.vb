Public Class FormLaporanHarian

    Private Sub FormLaporanHarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'KasirDataSet.tbl_detailjual' table. You can move, or remove it, as needed.
        'Me.tbl_detailjualTableAdapter.Fill(Me.KasirDataSet.tbl_detailjual)
        ''TODO: This line of code loads data into the 'KasirDataSet.tbl_admin' table. You can move, or remove it, as needed.
        'Me.tbl_adminTableAdapter.Fill(Me.KasirDataSet.tbl_admin)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class