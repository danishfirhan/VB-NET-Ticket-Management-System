<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(53, 181)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 1000, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 218)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GSC Admin Ticket Management System Version 1.0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(333, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 1000, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 51)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Copyright © 2024"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(333, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 1000, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 51)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Developed by GSC"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(333, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 1000, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(432, 153)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.Yellow
        Me.exitBtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(338, 356)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(174, 42)
        Me.exitBtn.TabIndex = 9
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(324, -50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(3, 556)
        Me.Label5.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ticket_Management_System.My.Resources.Resources.gsc_logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAbout"
        Me.Text = "frmAbout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label5 As Label
End Class
