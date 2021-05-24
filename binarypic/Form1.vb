Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pic As [Byte]()
        Dim mstream As New IO.MemoryStream
        Dim image As New Bitmap(PictureBox1.Image)
        image.Save(mstream, Imaging.ImageFormat.Jpeg)
        pic = mstream.ToArray
        mstream.Close()
    End Sub
End Class
