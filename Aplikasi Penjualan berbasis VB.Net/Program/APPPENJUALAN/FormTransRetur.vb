Imports System.Data.Odbc
Public Class FormTransRetur
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLKodeAdmin.Text = ""
        LBLKodePlg.Text = ""
        'LBLTelepon.Text = ""
        'LBLTanggal.Text = Today
        'LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        'LBLKembali.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        LBLHargaBarang.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        'LBLItem.Text = ""
        'Call MunculKodePelanggan()
        'Call NomorOtomatis()
        'Call Buatkolom()
        LBLTgl.Text = "0"
        TextBox1.Text = ""
        'ComboBox1.Text = ""
        DataGridView2.DataSource = ""
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = Format(TimeOfDay, "HH:mm:ss")
        LBLTgl.Text = Today
    End Sub
    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tb_retur where noretur in (select max(noretur) from tb_retur)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "R" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "R" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoRetur.Text = UrutanKode
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call MunculkanData()

        End If
    End Sub
    Sub MunculkanData()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select kodebarang,namabarang,hargajual,jumlahjual,subtotal From tb_detailpenjualan where nopenjualan='" & TextBox1.Text & "'", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_detailpenjualan")
        DataGridView2.DataSource = Ds.Tables("tb_detailpenjualan")
        DataGridView2.ReadOnly = True


        Call Koneksi()
        Cmd = New OdbcCommand("select * from tb_penjualan where nopenjualan = '" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox(" No Penjualan Tidak Ada")
        Else
            LBLKodePlg.Text = Rd.Item("KodePelanggan")
            LBLKodeAdmin.Text = Rd.Item("KodeAdmin")
            'TextBox3.Text = Rd.Item("PasswordAdmin")

        End If

        Call Koneksi()
        Cmd = New OdbcCommand("select * from tb_pelanggan where kodepelanggan = '" & LBLKodePlg.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox(" No Penjualan Tidak Ada")
        Else
            LBLNamaPlg.Text = Rd.Item("NamaPelanggan")
            LBLAlamat.Text = Rd.Item("AlamatPelanggan")
            'TextBox3.Text = Rd.Item("PasswordAdmin")
        End If
    End Sub

    Private Sub FormTransRetur_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call NomorOtomatis()
        Call KondisiAwal()
    End Sub

End Class