Imports System.Data.SqlClient

Public Class frmthongke
    'khai báo biến
    Dim db As New DataTable
    Dim classs As New Class1
    Dim connect As SqlConnection = New SqlConnection(classs.source)
    Dim MaHD As String
    Dim TenKH As String
    Dim SDT As String
    Dim MAKH As String
    Dim ngaymuonconlai As Byte


    Private Sub frmthongke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load dữ liệu lên datagridview
        MessageBox.Show(txtmasach.Text)
        Dim sql As String = "select MAHD as 'Mã hóa đơn',TENKH as 'Tên khách hàng',SDT as 'Số điện thoại', HOADONMUON.MAKH as 'Mã khách hàng', case when DATEDIFF(day,GETDATE(),NGAYTRA) > 0 then (N'Còn ') + cast(DATEDIFF(day,GETDATE(),NGAYTRA)as varchar)+(N' Ngày') when DATEDIFF(day,GETDATE(),NGAYTRA) = 0 then N'Đến hạn' when DATEDIFF(day,GETDATE(),NGAYTRA) < 0 then N'Trễ hạn' end as 'Trạng thái' from HOADONMUON ,KHACHHANG  where HOADONMUON .MAKH = KHACHHANG .MAKH and MASACH = '" & txtmasach.Text & "' "
        connect.Open()
        Dim thongke As SqlDataAdapter = New SqlDataAdapter(sql, connect)
        dgvthongke.DataSource = db.DefaultView
        db.Clear()
        thongke.Fill(db)
        connect.Close()
        MaHD = dgvthongke.Item(0, 0).Value
        TenKH = dgvthongke.Item(2, 0).Value
        SDT = dgvthongke.Item(3, 0).Value
        MAKH = dgvthongke.Item(4, 0).Value
        ngaymuonconlai = dgvthongke.Item(5, 0).Value
    End Sub
End Class