Imports System.IO

Public Class PL_Load

    Private Sub Pic_DoubleClick(sender As Object, e As EventArgs) Handles Pic.DoubleClick
        OFD.Filter = "PNG(*.PNG)|*.PNG;"
        Dim dr As DialogResult = OFD.ShowDialog()
        If dr = DialogResult.OK Then
            Dim Pic() As Byte = Encoder()

            Dim Str As String = System.Text.Encoding.Unicode.GetString(Pic)
            Dim DB As DB = New DB
            'Dim _SQL As String = "INSERT INTO (Img) VALUES (" & Pic & ")"
        End If
    End Sub

    Private Function Encoder() As Byte()
        Dim bm As Bitmap = Image.FromFile(OFD.FileName)
        Dim ms As MemoryStream = New MemoryStream
        Pic.Image = bm
        bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Return ms.ToArray
    End Function

    Private Sub Decoder(ByVal PicByte() As Byte)
        If Not PicByte Is Nothing Then
            Dim ms As MemoryStream = New MemoryStream(PicByte)
            Dim bm As Bitmap = Image.FromStream(ms)
            Pic.Image = bm
        End If
    End Sub
End Class
