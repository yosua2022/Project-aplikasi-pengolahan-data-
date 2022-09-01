Public Class FormLapPenjualan

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxCrystalReport1.SelectionFormula = "totext({tb_penjualan.tgljual})='" & DateTimePicker1.Value & "'"
        AxCrystalReport1.ReportFileName = "laporanharian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub FormLapPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("01 - JANUARI")
        ComboBox1.Items.Add("02 - FEBRUARI")
        ComboBox1.Items.Add("03 - MARET")
        ComboBox1.Items.Add("04 - APRIL")
        ComboBox1.Items.Add("05 - MEI")
        ComboBox1.Items.Add("06 - JUNI")
        ComboBox1.Items.Add("07 - JULI")
        ComboBox1.Items.Add("08 - AGUSTUS")
        ComboBox1.Items.Add("09 - SEPTEMBER")
        ComboBox1.Items.Add("10 - OKTOBER")
        ComboBox1.Items.Add("11 - NOVEMBER")
        ComboBox1.Items.Add("12 - DESEMBER")

        ComboBox2.Items.Clear()
        ComboBox2.Text = Date.Now.Year
        For i As Integer = 0 To 5
            ComboBox2.Items.Add(Date.Now.Year - i)
        Next
        Label7.Text = "2020, 01, 01"
        Label8.Text = "2020, 09, 17"

        'Dim tglaawal As String
        'Dim tglakhir As String
        Label7.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
        Label8.Text = Format(DateTimePicker3.Value, "yyyy, MM, dd")


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silahkan isi Bulan dan Tahunnya terlebih dahulu!")
        Else
            AxCrystalReport1.SelectionFormula = "Month({tb_penjualan.tgljual})=" & Val(ComboBox1.Text) & "and year({tb_penjualan.tgljual})=" & Val(ComboBox2.Text)
            AxCrystalReport1.ReportFileName = "laporanbulanan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        End If


        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxCrystalReport1.SelectionFormula = "{tb_penjualan.tgljual} in date (" & Label7.Text & ") to date (" & Label8.Text & ")"
        'AxCrystalReport1.SelectionFormula = "{tb_penjualan.tgljual} in date (" & DateTimePicker2.Value & ") to date (" & DateTimePicker3.Value & ")"
        AxCrystalReport1.ReportFileName = "laporanMingguan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Label7.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Label8.Text = Format(DateTimePicker3.Value, "yyyy, MM, dd")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "totext({tb_penjualan.nopenjualan})='" & LBLNota.Text & "'"
        AxCrystalReport1.ReportFileName = "notapenjualan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub AxCrystalReport1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCrystalReport1.Enter
        AxCrystalReport1.Action = 1

    End Sub
End Class