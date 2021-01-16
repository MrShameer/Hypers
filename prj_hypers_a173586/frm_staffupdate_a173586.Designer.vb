<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffupdate_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffupdate_a173586))
        Me.back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(729, 424)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 66
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 54)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "UPDATE STAFF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(303, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 52)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "HYPERS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.Location = New System.Drawing.Point(319, 424)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(196, 32)
        Me.btn_update.TabIndex = 63
        Me.btn_update.Text = "UPDATE STAFF"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "ID :"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(129, 363)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(618, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "PHONE :"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(606, 363)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(100, 20)
        Me.phone.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "NAME :"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(317, 363)
        Me.pname.Multiline = True
        Me.pname.Name = "pname"
        Me.pname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.pname.Size = New System.Drawing.Size(203, 36)
        Me.pname.TabIndex = 67
        Me.pname.WordWrap = False
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AllowUserToResizeColumns = False
        Me.grd_staff.AllowUserToResizeRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(52, 127)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.Size = New System.Drawing.Size(730, 189)
        Me.grd_staff.TabIndex = 73
        '
        'frm_staffupdate_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(834, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_update)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_staffupdate_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Staff"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents grd_staff As DataGridView
End Class
