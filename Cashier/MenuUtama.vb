Public Class MenuUtama

    Private Sub BTNClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNClose.Click
        'Me.Close()
        End
    End Sub

    Private Sub BTNMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTNMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BTNMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMaster.Click
        LblSelected1.Visible = True
        LblSelected2.Visible = False
        LblSelected3.Visible = False
        LblSelected4.Visible = False
        LblSelected5.Visible = False
        LblSelected6.Visible = False
        LBLSelected7.Visible = False

        PanelDataMaster.Visible = True
        PanelLaporan.Visible = False
        PanelTransaksi.Visible = False
        PanelProfil.Visible = False
        PanelAbout.Visible = False
        PanelDataBarang.Visible = False
    End Sub

    Private Sub BTNTransaksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTransaksi.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = True
        LblSelected3.Visible = False
        LblSelected4.Visible = False
        LblSelected5.Visible = False
        LblSelected6.Visible = False
        LBLSelected7.Visible = False

        PanelDataMaster.Visible = False
        PanelLaporan.Visible = False
        PanelTransaksi.Visible = True
        PanelAbout.Visible = False
        PanelDataBarang.Visible = False
        PanelProfil.Visible = False
    End Sub

    Private Sub BTNLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLaporan.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = False
        LblSelected3.Visible = True
        LblSelected4.Visible = False
        LblSelected5.Visible = False
        LblSelected6.Visible = False
        LBLSelected7.Visible = False

        PanelDataMaster.Visible = False
        PanelLaporan.Visible = True
        PanelTransaksi.Visible = False
        PanelAbout.Visible = False
        PanelDataBarang.Visible = False
        PanelProfil.Visible = False
    End Sub

    Private Sub BTNDATA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDATA.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = False
        LblSelected3.Visible = False
        LblSelected4.Visible = True
        LblSelected5.Visible = False
        LblSelected6.Visible = False
        LBLSelected7.Visible = False

        PanelDataMaster.Visible = False
        PanelLaporan.Visible = False
        PanelTransaksi.Visible = False
        PanelAbout.Visible = False
        PanelDataBarang.Visible = True
        PanelProfil.Visible = False
    End Sub

    Private Sub BTNAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAbout.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = False
        LblSelected3.Visible = False
        LblSelected4.Visible = False
        LblSelected5.Visible = True
        LblSelected6.Visible = False
        LBLSelected7.Visible = False

        PanelDataMaster.Visible = False
        PanelLaporan.Visible = False
        PanelTransaksi.Visible = False
        PanelAbout.Visible = True
        PanelDataBarang.Visible = False
        PanelProfil.Visible = False
    End Sub


    Private Sub BTNLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLogout.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = False
        LblSelected3.Visible = False
        LblSelected4.Visible = False
        LblSelected5.Visible = False
        LblSelected6.Visible = True
        LBLSelected7.Visible = False


        Dim choose = MessageBox.Show("Apakah anda yakin ingin Logout ?", "WARNING !", MessageBoxButtons.YesNo)
        If choose = DialogResult.Yes Then
            Me.Hide()
            Login.Show()
            Login.TxtUsername.Text = ""
            Login.TxtPassword.Text = ""
            Login.TxtUsername.Focus()
        End If
    End Sub

    Private Sub BTNTmbhUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTmbhUser.Click
        TambahUser.ShowDialog()
    End Sub

    Private Sub BTNEditUsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNEditUsr.Click
        EditUservb.ShowDialog()
    End Sub

    Private Sub BTNDelUsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDelUsr.Click
        HapusUser.ShowDialog()

    End Sub

    Private Sub BTNListUsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNListUsr.Click
        ListUser.ShowDialog()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Tambah_Barang.ShowDialog()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        EditBarang.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        HapusBarang.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBarang.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        LaporanHarian.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        LaporanMingguan.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LaporanBulanan.ShowDialog()

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        CallCenter.ShowDialog()

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Email.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Transaksi.ShowDialog()

    End Sub

    Private Sub BTNProfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNProfil.Click
        LblSelected1.Visible = False
        LblSelected2.Visible = False
        LblSelected3.Visible = False
        LblSelected4.Visible = False
        LblSelected5.Visible = False
        LblSelected6.Visible = False
        LBLSelected7.Visible = True

        PanelDataMaster.Visible = False
        PanelLaporan.Visible = False
        PanelTransaksi.Visible = False
        PanelProfil.Visible = True
        PanelAbout.Visible = False
        PanelDataBarang.Visible = False
    End Sub

    Private Sub BTNGantiNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGantiNama.Click
        GantiNama.ShowDialog()
    End Sub

    Private Sub BTNGantiPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGantiPass.Click
        GantiPassword.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LaporanPerNota.Show()
    End Sub
End Class
