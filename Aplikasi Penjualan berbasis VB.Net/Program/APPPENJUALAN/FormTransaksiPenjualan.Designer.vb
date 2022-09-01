<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksiPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLNoPenjualan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLJumlahBrg = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBLItem = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Penjualan"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Pelanggan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telepon"
        '
        'LBLNoPenjualan
        '
        Me.LBLNoPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoPenjualan.Location = New System.Drawing.Point(143, 14)
        Me.LBLNoPenjualan.Name = "LBLNoPenjualan"
        Me.LBLNoPenjualan.Size = New System.Drawing.Size(170, 23)
        Me.LBLNoPenjualan.TabIndex = 5
        Me.LBLNoPenjualan.Text = "LBLNoPenjualan"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Location = New System.Drawing.Point(143, 84)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(377, 23)
        Me.LBLAlamat.TabIndex = 7
        Me.LBLAlamat.Text = "LBLAlamat"
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Location = New System.Drawing.Point(143, 61)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(377, 23)
        Me.LBLNamaPlg.TabIndex = 8
        Me.LBLNamaPlg.Text = "LBLNamaPlg"
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Location = New System.Drawing.Point(143, 107)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(170, 23)
        Me.LBLTelepon.TabIndex = 9
        Me.LBLTelepon.Text = "LBLTelepon"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(482, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jam"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(482, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Admin"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(593, 60)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(163, 23)
        Me.LBLTanggal.TabIndex = 13
        Me.LBLTanggal.Text = "LBLTanggal"
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Location = New System.Drawing.Point(614, 106)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(142, 23)
        Me.LBLAdmin.TabIndex = 14
        Me.LBLAdmin.Text = "LBLAdmin"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Location = New System.Drawing.Point(615, 83)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(142, 23)
        Me.LBLJam.TabIndex = 15
        Me.LBLJam.Text = "LBLJam"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(526, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 32)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Rp. 250.000"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(428, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 32)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "TOTAL : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(102, 191)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(526, 102)
        Me.DataGridView1.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(500, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Dibayar"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(500, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Kembali"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(602, 303)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 21
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Location = New System.Drawing.Point(602, 323)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(144, 16)
        Me.LBLKembali.TabIndex = 22
        Me.LBLKembali.Text = "LBLKembali"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 42)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(127, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 42)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "BATAL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(252, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 42)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "TUTUP"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Kode"
        '
        'LBLJumlahBrg
        '
        Me.LBLJumlahBrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLJumlahBrg.Location = New System.Drawing.Point(526, 161)
        Me.LBLJumlahBrg.Name = "LBLJumlahBrg"
        Me.LBLJumlahBrg.Size = New System.Drawing.Size(75, 23)
        Me.LBLJumlahBrg.TabIndex = 27
        Me.LBLJumlahBrg.Visible = False
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(347, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 23)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Harga"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(131, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 23)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Nama"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(66, 159)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(59, 20)
        Me.TextBox2.TabIndex = 30
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(682, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Masukkan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(607, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(69, 20)
        Me.TextBox3.TabIndex = 33
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLNamaBarang.Location = New System.Drawing.Point(196, 161)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(145, 23)
        Me.LBLNamaBarang.TabIndex = 34
        Me.LBLNamaBarang.Text = "Nama"
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLHargaBarang.Location = New System.Drawing.Point(400, 161)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(120, 23)
        Me.LBLHargaBarang.TabIndex = 35
        Me.LBLHargaBarang.Text = "Harga"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(368, 305)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Item"
        '
        'LBLItem
        '
        Me.LBLItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLItem.Location = New System.Drawing.Point(418, 305)
        Me.LBLItem.Name = "LBLItem"
        Me.LBLItem.Size = New System.Drawing.Size(76, 23)
        Me.LBLItem.TabIndex = 37
        Me.LBLItem.Text = "Item"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(366, 110)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 38
        '
        'FormTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.APPPENJUALAN.My.Resources.Resources.Logo
        Me.ClientSize = New System.Drawing.Size(794, 397)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.LBLItem)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LBLJumlahBrg)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLNamaPlg)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LBLNoPenjualan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksiPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransaksI Penjualan Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBLNoPenjualan As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLNamaPlg As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLKembali As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LBLJumlahBrg As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LBLNamaBarang As System.Windows.Forms.Label
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LBLItem As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
