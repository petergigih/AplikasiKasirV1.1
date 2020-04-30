Imports System.Data.OleDb
Public Class ListBarang

    Private Sub ListBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        DA = New OleDbDataAdapter("Select * from tbl_barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_barang")
        DataGridView1.DataSource = DS.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class