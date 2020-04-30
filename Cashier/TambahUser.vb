Imports System.Data.OleDb
Public Class TambahUser
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")

        Button1.Enabled = True
        Button2.Enabled = True

        Button1.Text = "Input"
        Button2.Text = "Close"
    End Sub

    Private Sub TambahUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Masukkan Data Terlebih Dahulu")
        Else
            Call Connection()
            Dim InputData As String = "Insert Into tbl_admin values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            CMD = New OleDbCommand(InputData, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil di Tambahkan")
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

End Class