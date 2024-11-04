Imports MySql.Data.MySqlClient
Public Class frmReport
    Private bindingSource As New BindingSource()
    Private dataTable As New DataTable()

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView2.RowTemplate.Height = 30
        DataGridView2.DataSource = bindingSource
        Load_Report()
    End Sub

    Sub Load_Report()
        Try
            conn.Open()
            dataTable.Clear() ' Clear the DataTable

            ' Fill dataTable with query results
            Dim query As String = "SELECT `ticktno`, `ticketdate`, `ticketmonth`,`moviename`, `price` FROM `tbl_ticket`"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dataTable)

            bindingSource.DataSource = dataTable ' Update the BindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            conn.Open()
            dataTable.Clear()

            ' Query with search criteria
            Dim query As String = "SELECT `ticktno`, `ticketdate`,`ticketmonth`, `moviename`, `price` FROM `tbl_ticket` WHERE ticktno like '%" & txt_search.Text & "%' or moviename like '%" & txt_search.Text & "%'"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dataTable)
            bindingSource.DataSource = dataTable
            DataGridView2.Refresh() ' Refresh the view to reflect filtered data
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("dd-MM-yyyy")
        Dim date2 As String = DateTimePicker2.Value.ToString("dd-MM-yyyy")

        Try
            conn.Open()
            dataTable.Clear()

            ' Query with date range filter
            Dim query As String = "SELECT `ticktno`, `ticketdate`, `ticketmonth`, `moviename`, `price` FROM `tbl_ticket` WHERE ticketdate BETWEEN @date1 AND @date2"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@date1", date1)
            adapter.SelectCommand.Parameters.AddWithValue("@date2", date2)
            adapter.Fill(dataTable)

            bindingSource.DataSource = dataTable
            DataGridView2.Refresh() ' Refresh the view to reflect filtered data
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total()
        Try
            Dim sum As Double = 0
            For j As Integer = 0 To DataGridView2.Rows.Count - 1 Step +1
                ' Check if the cell value is DBNull or not a valid number
                sum = sum + DataGridView2.Rows(j).Cells(5).Value
            Next
            lbl_totalPrice.Text = Format(sum, "#,##0.00")
        Catch ex As Exception
            MsgBox("An error occurred in calculating total: " & ex.Message)
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

End Class

