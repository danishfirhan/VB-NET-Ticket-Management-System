Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        Me.ReportViewer1.RefreshReport()
        Print_reportLoad()
    End Sub

    Sub Print_reportLoad()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()

            Dim ds As New TicketDataSet
            Dim da As New MySqlDataAdapter
            da.SelectCommand = New MySqlCommand("SELECT * FROM `tbl_ticket` WHERE `ticktno`='" & Form1.lbl_ticketNo.Text & "'", conn)
            da.Fill(ds.Tables("DataTable1"))

            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)


            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            Dim ps As New PaperSize("Custom", 315, 354) ' 315 x 354 hundredths of an inch = 8cm x 9cm
            ReportViewer1.PrinterSettings.DefaultPageSettings.PaperSize = ps
            ReportViewer1.PrinterSettings.DefaultPageSettings.Landscape = False ' Set to False for portrait orientation

            ' Refresh and display the report with updated settings
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class