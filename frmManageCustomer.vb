Imports MySql.Data.MySqlClient

Public Class frmManageCustomer
    Private Sub frmManageCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
    End Sub

    ' Load Customer Data
    Private Sub LoadCustomerData()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim query As String = "SELECT * FROM tbl_customers"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCustomers.DataSource = table
        Catch ex As Exception
            MsgBox("Error loading customer data: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Add New Customer
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO tbl_customers (name, phone, email) VALUES (@name, @phone, @email)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@phone", txtCustomerPhone.Text)
            cmd.Parameters.AddWithValue("@email", txtCustomerEmail.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Customer added successfully!", vbInformation)
            LoadCustomerData()
        Catch ex As Exception
            MsgBox("Error adding customer: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Delete Selected Customer
    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Try
            If dgvCustomers.SelectedRows.Count > 0 Then
                ' Ensure column exists
                Dim columnName As String = "customer_id"
                If dgvCustomers.Columns.Contains(columnName) Then
                    Dim customerId As Integer = dgvCustomers.SelectedRows(0).Cells(columnName).Value
                    conn.Open()
                    Dim query As String = "DELETE FROM tbl_customers WHERE customer_id = @customer_id"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@customer_id", customerId)
                    cmd.ExecuteNonQuery()
                    MsgBox("Customer deleted successfully!", vbInformation)
                Else
                    MsgBox("Column 'customer_id' not found in DataGridView.")
                End If
            Else
                MsgBox("Please select a customer to delete.")
            End If
        Catch ex As Exception
            MsgBox("Error deleting customer: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            LoadCustomerData()
        End Try
    End Sub

    ' Refresh Customer Data
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCustomerData()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class

