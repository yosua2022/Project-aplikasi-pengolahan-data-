﻿Imports System.Data.Odbc
Public Class FormLogin
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled= False
        FormMenuUtama.LogOutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tb_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!KodeAdmin
                FormMenuUtama.STLabel4.Text = Rd!NamaAdmin
                FormMenuUtama.STLabel6.Text = Rd!LevelAdmin
                If FormMenuUtama.STLabel6.Text = "USER" Then
                    FormMenuUtama.AdminToolStripMenuItem.Enabled = False
                End If
            Else

                MsgBox("Kodeadmin atau password salah!")
            End If
        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        TextBox1.Text = "ADM01"
        TextBox2.Text = "ADMIN"
    End Sub
End Class