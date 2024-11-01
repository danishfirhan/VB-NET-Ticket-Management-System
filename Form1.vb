Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Imports MessagingToolkit.Barcode.Common.Detector

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        QR_CODE()
        BAR_CODE()
    End Sub

    Public Sub QR_CODE()
        Try
            Dim qrcode As New QRCodeEncoder
            qrcode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrcode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            pic_qrcode.Image = qrcode.Encode(lbl_ticketNo.Text, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub BAR_CODE()
        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        generator.BackColor = Color.White
        Try
            pic_barcode.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code93, lbl_movieName.Text))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class