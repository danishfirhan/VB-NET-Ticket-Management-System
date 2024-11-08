Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.Barcode
Imports MessagingToolkit.Barcode.Common.Detector

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Auto_GenerateTicketNo()
        GetMovieNameandPrice()
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

    Private Sub manageMovieBtn_Click(sender As Object, e As EventArgs) Handles manageMovieBtn.Click
        frm_ManageMovie.ShowDialog()
    End Sub

    Sub Auto_GenerateTicketNo()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT ticktno FROM tbl_ticket ORDER BY ID DESC LIMIT 1", conn)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim lastTicketNo As Integer = Integer.Parse(dr("ticktno").ToString())
                lbl_ticketNo.Text = (lastTicketNo + 1).ToString("000000000") ' Keep the format with leading zeros
            Else
                lbl_ticketNo.Text = Date.Now.ToString("yyyyMM") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub


    Sub GetMovieNameandPrice()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tbl_moviedata` WHERE `movieid`='1001'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                lbl_movieName.Text = dr.Item("moviename").ToString
                lbl_moviePrice.Text = dr.Item("price").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Save_Data()
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tbl_ticket`(`ticktno`, `ticketdate`, `ticketmonth`, `moviename`, `price`, `qrcode`, `barcode`) VALUES (@ticktno,@ticketdate,@ticketmonth,@moviename,@price,@qrcode,@barcode)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ticktno", lbl_ticketNo.Text)
            cmd.Parameters.AddWithValue("@ticketdate", Date.Now.ToString("dd-MM-yyyy"))
            cmd.Parameters.AddWithValue("@ticketmonth", Date.Now.ToString("MM"))
            cmd.Parameters.AddWithValue("@moviename", lbl_movieName.Text)
            cmd.Parameters.AddWithValue("@price", lbl_moviePrice.Text)

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_qrcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            pic_barcode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim qrpic() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()

            cmd.Parameters.AddWithValue("@qrcode", qrpic)
            cmd.Parameters.AddWithValue("@barcode", qrpic)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Ticket Generate Success!", vbInformation)
            Else
                MsgBox("Ticket Generate Failed!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        frmPrint.Show()
        Auto_GenerateTicketNo()
        QR_CODE()
        BAR_CODE()
    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        Auto_GenerateTicketNo()
        Save_Data()
        QR_CODE()
        BAR_CODE()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Save_Data()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        frmReport.ShowDialog()
    End Sub

    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        frmAbout.ShowDialog()
    End Sub MySub()

End Sub

    Private Sub manageCustomerBtn_Click(sender As Object, e As EventArgs) Handles manageCustomerBtn.Click
        frmManageCustomer.ShowDialog()
    End Sub
End Class