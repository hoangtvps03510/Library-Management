﻿
Class Class1
    Public Function source() As String
        Dim chuoiketnoi As String = "Data Source=(local);AttachDbFilename=" + My.Application.Info.DirectoryPath.ToString + "\QLThuVien_Agile.mdf;Integrated Security=True"
        Return chuoiketnoi
    End Function

End Class
