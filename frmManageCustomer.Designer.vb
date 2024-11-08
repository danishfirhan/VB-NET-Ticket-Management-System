<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.DataTable2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketDataSet2 = New Ticket_Management_System.TicketDataSet()
        Me.TicketDataSet = New Ticket_Management_System.TicketDataSet()
        Me.TicketDataSet1 = New Ticket_Management_System.TicketDataSet()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_id, Me.Column2, Me.phone, Me.email})
        Me.dgvCustomers.Location = New System.Drawing.Point(128, 105)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersWidth = 51
        Me.dgvCustomers.Size = New System.Drawing.Size(553, 150)
        Me.dgvCustomers.TabIndex = 1
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.TicketDataSet
        '
        'TicketDataSetBindingSource
        '
        Me.TicketDataSetBindingSource.DataSource = Me.TicketDataSet
        Me.TicketDataSetBindingSource.Position = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 44)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 44)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 44)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Email"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerName.Location = New System.Drawing.Point(145, 278)
        Me.txtCustomerName.MinimumSize = New System.Drawing.Size(240, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(277, 20)
        Me.txtCustomerName.TabIndex = 6
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(144, 335)
        Me.txtCustomerPhone.MinimumSize = New System.Drawing.Size(240, 30)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(277, 20)
        Me.txtCustomerPhone.TabIndex = 7
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(144, 391)
        Me.txtCustomerEmail.MinimumSize = New System.Drawing.Size(240, 30)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(277, 20)
        Me.txtCustomerEmail.TabIndex = 8
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.Yellow
        Me.btnAddCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(484, 275)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(197, 42)
        Me.btnAddCustomer.TabIndex = 9
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.Yellow
        Me.btnDeleteCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(484, 335)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(197, 42)
        Me.btnDeleteCustomer.TabIndex = 10
        Me.btnDeleteCustomer.Text = "Delete Customer"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(484, 391)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(197, 42)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(-5, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 68)
        Me.Panel1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "MANAGE CUSTOMER"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_exit.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_exit.Location = New System.Drawing.Point(667, -2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(140, 67)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'DataTable2BindingSource1
        '
        Me.DataTable2BindingSource1.DataMember = "DataTable2"
        Me.DataTable2BindingSource1.DataSource = Me.TicketDataSetBindingSource
        '
        'DataTable2BindingSource2
        '
        Me.DataTable2BindingSource2.DataMember = "DataTable2"
        Me.DataTable2BindingSource2.DataSource = Me.TicketDataSet1
        '
        'DataTable2BindingSource3
        '
        Me.DataTable2BindingSource3.DataMember = "DataTable2"
        Me.DataTable2BindingSource3.DataSource = Me.TicketDataSet2
        '
        'TicketDataSet2
        '
        Me.TicketDataSet2.DataSetName = "TicketDataSet"
        Me.TicketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketDataSet
        '
        Me.TicketDataSet.DataSetName = "TicketDataSet"
        Me.TicketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketDataSet1
        '
        Me.TicketDataSet1.DataSetName = "TicketDataSet"
        Me.TicketDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "customer_id"
        Me.customer_id.MinimumWidth = 6
        Me.customer_id.Name = "customer_id"
        Me.customer_id.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name"
        Me.Column2.HeaderText = "name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'phone
        '
        Me.phone.DataPropertyName = "phone"
        Me.phone.HeaderText = "phone"
        Me.phone.MinimumWidth = 6
        Me.phone.Name = "phone"
        Me.phone.Width = 125
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "email"
        Me.email.MinimumWidth = 6
        Me.email.Name = "email"
        Me.email.Width = 125
        '
        'frmManageCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Name = "frmManageCustomer"
        Me.Text = "frmManageCustomer"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents TicketDataSet As TicketDataSet
    Friend WithEvents TicketDataSetBindingSource As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents DataTable2BindingSource2 As BindingSource
    Friend WithEvents TicketDataSet1 As TicketDataSet
    Friend WithEvents DataTable2BindingSource1 As BindingSource
    Friend WithEvents DataTable2BindingSource3 As BindingSource
    Friend WithEvents TicketDataSet2 As TicketDataSet
    Friend WithEvents customer_id As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
End Class
