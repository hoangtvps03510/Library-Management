﻿
Public Class frmChiTiet

    'click đóng form
    Private Sub btnThoatND_Click(sender As Object, e As EventArgs) Handles btnThoatND.Click
        Me.Close()
    End Sub
    'click hiện form đăng kí
    Private Sub btnMuonSachND_Click(sender As Object, e As EventArgs) Handles btnMuonSachND.Click
        frmDangKiMuonSach.ShowDialog()
    End Sub

    Private Sub frmChiTiet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class