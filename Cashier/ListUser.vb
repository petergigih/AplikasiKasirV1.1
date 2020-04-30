Imports System.Data.OleDb
Public Class ListUser

    Private Sub ListUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Connection()
        DA = New OleDbDataAdapter("Select kode_admin AS Username,nama_admin,level_admin from tbl_admin", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_admin")
        DataGridView1.DataSource = DS.Tables("tbl_admin")
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class