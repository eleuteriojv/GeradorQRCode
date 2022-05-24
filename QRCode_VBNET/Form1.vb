Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Public Class Form1
    Private Sub btnGerarQRCode_Click(sender As Object, e As EventArgs) Handles btnGerarQRCode.Click
        Try
            Dim qrencod As New QRCodeEncoder
            Dim qrcode As Bitmap = qrencod.Encode(txtTexto.Text)
            picImagem.Image = TryCast(qrcode, Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSalvarQRCode_Click(sender As Object, e As EventArgs) Handles btnSalvarQRCode.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.InitialDirectory = "c:\QrCode\"
            sfd.Filter = "PNG | *.png| JPEG| *.jpg| BMP|*.bmp"
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picImagem.Image.Save(sfd.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCarregarQRCode_Click(sender As Object, e As EventArgs) Handles btnCarregarQRCode.Click
        Try
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = "c:\QrCode\"
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picImagem.ImageLocation = ofd.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLerQRCode_Click(sender As Object, e As EventArgs) Handles btnLerQRCode.Click
        Try
            Dim decoder As New QRCodeDecoder
            MessageBox.Show(decoder.Decode(New QRCodeBitmapImage(TryCast(picImagem.Image, Bitmap))))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
