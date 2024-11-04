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
            dataTable.Clear() ' Clear the DataTable, not DataGridView rows

            ' Fill dataTable with query results
            Dim query As String = "SELECT `ticktno`, `ticketdate`, `ticketmonth`, `moviename`, `price` FROM `tbl_ticket`"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dataTable)

            bindingSource.DataSource = dataTable ' Update the BindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            conn.Open()
            dataTable.Clear() ' Clear the DataTable, not DataGridView rows

            ' Fill dataTable with query results
            Dim query As String = "SELECT `ticktno`, `ticketdate`, `ticketmonth`, `moviename`, `price` FROM `tbl_ticket` WHERE ticktno like '%" & txt_search.Text & "%' or moviename like '%" & txt_search.Text & "%'"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dataTable)

            bindingSource.DataSource = dataTable ' Update the BindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Try
            conn.Open()
            dataTable.Clear() ' Clear the DataTable, not DataGridView rows

            ' Fill dataTable with query results
            Dim query As String = "SELECT `ticktno`, `ticketdate`, `ticketmonth`, `moviename`, `price` FROM `tbl_ticket` WHERE ticketdate between '" & date1 & "' and '" & date2 & "' "
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dataTable)

            bindingSource.DataSource = dataTable ' Update the BindingSource
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Total()
        Try
            Dim sum As Double = 0
            For j As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
                sum = sum + DataGridView2.Rows(j).Cells(5).Value
            Next
            lbl_totalPrice.Text = Format(sum, "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub

End Class
