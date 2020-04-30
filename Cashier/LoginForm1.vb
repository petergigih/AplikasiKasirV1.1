Imports System.Data.OleDb
Public Class Login

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call BTNMasuk_Click(e, AcceptButton)
        End If
    End Sub

    Private Sub BTNClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNClose.Click
        End
    End Sub

    Private Sub BTNMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMasuk.Click
        If TxtUsername.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Masukan Username dan Password!", MsgBoxStyle.Critical, "WARNING!")
            TxtUsername.Focus()
        Else
            Call Connection()
            CMD = New OleDbCommand("Select * From tbl_admin where kode_admin='" & TxtUsername.Text & "' and password_admin = '" & TxtPassword.Text & "'", CONN)

            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MenuUtama.Show()
                Me.Hide()
                MenuUtama.LBLUsername.Text = RD!Kode_Admin
                MenuUtama.LBLNamaUser.Text = RD!Nama_Admin
                MenuUtama.LBLPassword.Text = RD!Password_Admin
                MenuUtama.LBLLevel.Text = RD!Level_Admin
                MenuUtama.LBLUsername.Visible = False
                MenuUtama.LBLPassword.Visible = False
                If MenuUtama.LBLLevel.Text = "ADMIN" Then
                    MenuUtama.BTNMaster.Visible = True
                    MenuUtama.LblSelected1.Visible = True
                    MenuUtama.PanelDataMaster.Visible = True
                    MenuUtama.BTNProfil.Visible = False
                    MenuUtama.LBLSelected7.Visible = False
                    MenuUtama.PanelProfil.Visible = False
                ElseIf MenuUtama.LBLLevel.Text = "USER" Then
                    MenuUtama.BTNMaster.Visible = False
                    MenuUtama.LblSelected1.Visible = False
                    MenuUtama.PanelDataMaster.Visible = False
                    MenuUtama.BTNProfil.Visible = True
                    MenuUtama.LBLSelected7.Visible = True
                    MenuUtama.PanelProfil.Visible = True
                End If
            Else
                MsgBox("Username atau Password Anda Salah!", MsgBoxStyle.Critical, "WARNING!")
                TxtUsername.Clear()
                TxtPassword.Clear()
                TxtUsername.Focus()
            End If

        End If
        'MenuUtama.Show()
        'Me.Hide()

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
