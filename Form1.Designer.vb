<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pic_qrcode = New System.Windows.Forms.PictureBox()
        Me.pic_barcode = New System.Windows.Forms.PictureBox()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.manageMovieBtn = New System.Windows.Forms.Button()
        Me.newBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_ticketNo = New System.Windows.Forms.Label()
        Me.lbl_movieName = New System.Windows.Forms.Label()
        Me.lbl_moviePrice = New System.Windows.Forms.Label()
        CType(Me.pic_qrcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_qrcode
        '
        Me.pic_qrcode.Location = New System.Drawing.Point(394, 230)
        Me.pic_qrcode.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_qrcode.Name = "pic_qrcode"
        Me.pic_qrcode.Size = New System.Drawing.Size(353, 248)
        Me.pic_qrcode.TabIndex = 11
        Me.pic_qrcode.TabStop = False
        '
        'pic_barcode
        '
        Me.pic_barcode.Location = New System.Drawing.Point(279, 576)
        Me.pic_barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_barcode.Name = "pic_barcode"
        Me.pic_barcode.Size = New System.Drawing.Size(420, 71)
        Me.pic_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_barcode.TabIndex = 17
        Me.pic_barcode.TabStop = False
        '
        'reportBtn
        '
        Me.reportBtn.BackColor = System.Drawing.Color.Yellow
        Me.reportBtn.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.reportBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reportBtn.Location = New System.Drawing.Point(584, 683)
        Me.reportBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.reportBtn.Size = New System.Drawing.Size(247, 100)
        Me.reportBtn.TabIndex = 6
        Me.reportBtn.Text = "REPORT"
        Me.reportBtn.UseVisualStyleBackColor = False
        '
        'manageMovieBtn
        '
        Me.manageMovieBtn.BackColor = System.Drawing.Color.Yellow
        Me.manageMovieBtn.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.manageMovieBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.manageMovieBtn.Location = New System.Drawing.Point(290, 679)
        Me.manageMovieBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.manageMovieBtn.Name = "manageMovieBtn"
        Me.manageMovieBtn.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.manageMovieBtn.Size = New System.Drawing.Size(268, 100)
        Me.manageMovieBtn.TabIndex = 5
        Me.manageMovieBtn.Text = "MANAGE MOVIE"
        Me.manageMovieBtn.UseVisualStyleBackColor = False
        '
        'newBtn
        '
        Me.newBtn.BackColor = System.Drawing.Color.Yellow
        Me.newBtn.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.newBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newBtn.Location = New System.Drawing.Point(41, 676)
        Me.newBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.newBtn.Name = "newBtn"
        Me.newBtn.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.newBtn.Size = New System.Drawing.Size(228, 103)
        Me.newBtn.TabIndex = 1
        Me.newBtn.Text = "NEW"
        Me.newBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.Yellow
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.exitBtn.Location = New System.Drawing.Point(859, 683)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Padding = New System.Windows.Forms.Padding(80, 0, 0, 0)
        Me.exitBtn.Size = New System.Drawing.Size(221, 96)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox6.Image = Global.Ticket_Management_System.My.Resources.Resources.add_icon
        Me.PictureBox6.Location = New System.Drawing.Point(62, 700)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(81, 70)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox5.Image = Global.Ticket_Management_System.My.Resources.Resources.exit_icon
        Me.PictureBox5.Location = New System.Drawing.Point(881, 700)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(76, 64)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox4.Image = Global.Ticket_Management_System.My.Resources.Resources.report_icon
        Me.PictureBox4.Location = New System.Drawing.Point(593, 700)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(74, 64)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Image = Global.Ticket_Management_System.My.Resources.Resources.film_icon
        Me.PictureBox3.Location = New System.Drawing.Point(313, 692)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Ticket_Management_System.My.Resources.Resources.GSC_Promotion_Page_velvet_premiere_ticket
        Me.PictureBox2.Location = New System.Drawing.Point(27, 13)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(209, 79)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(379, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(376, 358)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'lbl_ticketNo
        '
        Me.lbl_ticketNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_ticketNo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ticketNo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_ticketNo.Location = New System.Drawing.Point(387, 172)
        Me.lbl_ticketNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ticketNo.Name = "lbl_ticketNo"
        Me.lbl_ticketNo.Size = New System.Drawing.Size(379, 54)
        Me.lbl_ticketNo.TabIndex = 14
        Me.lbl_ticketNo.Text = "Ticket Management System"
        '
        'lbl_movieName
        '
        Me.lbl_movieName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_movieName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_movieName.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_movieName.Location = New System.Drawing.Point(387, 493)
        Me.lbl_movieName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_movieName.Name = "lbl_movieName"
        Me.lbl_movieName.Size = New System.Drawing.Size(379, 54)
        Me.lbl_movieName.TabIndex = 15
        Me.lbl_movieName.Text = "Movie Name"
        '
        'lbl_moviePrice
        '
        Me.lbl_moviePrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_moviePrice.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_moviePrice.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_moviePrice.Location = New System.Drawing.Point(387, 529)
        Me.lbl_moviePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_moviePrice.Name = "lbl_moviePrice"
        Me.lbl_moviePrice.Size = New System.Drawing.Size(379, 43)
        Me.lbl_moviePrice.TabIndex = 16
        Me.lbl_moviePrice.Text = "Movie Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1143, 792)
        Me.Controls.Add(Me.pic_barcode)
        Me.Controls.Add(Me.lbl_moviePrice)
        Me.Controls.Add(Me.lbl_movieName)
        Me.Controls.Add(Me.lbl_ticketNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pic_qrcode)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.manageMovieBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.newBtn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic_qrcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents reportBtn As Button
    Friend WithEvents manageMovieBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_ticketNo As Label
    Friend WithEvents lbl_movieName As Label
    Friend WithEvents lbl_moviePrice As Label
    Friend WithEvents pic_qrcode As PictureBox
    Friend WithEvents pic_barcode As PictureBox
End Class
