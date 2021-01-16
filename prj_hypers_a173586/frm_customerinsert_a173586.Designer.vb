<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerinsert_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerinsert_a173586))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.back = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "ID :"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(141, 353)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 74
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(860, 502)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 73
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(726, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "PHONE :"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(714, 353)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(100, 20)
        Me.phone.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(448, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "NAME :"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(381, 353)
        Me.pname.Multiline = True
        Me.pname.Name = "pname"
        Me.pname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.pname.Size = New System.Drawing.Size(203, 36)
        Me.pname.TabIndex = 69
        Me.pname.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(427, 54)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "INSERT CUSTOMER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(377, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_insert.Location = New System.Drawing.Point(381, 502)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(203, 32)
        Me.btn_insert.TabIndex = 66
        Me.btn_insert.Text = "INSERT CUSTOMER"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AllowUserToResizeColumns = False
        Me.grd_staff.AllowUserToResizeRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(55, 106)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.Size = New System.Drawing.Size(856, 201)
        Me.grd_staff.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(713, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "ADDRESS :"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(661, 438)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.address.Size = New System.Drawing.Size(203, 36)
        Me.address.TabIndex = 76
        Me.address.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "EMAIL :"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(89, 438)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.email.Size = New System.Drawing.Size(203, 36)
        Me.email.TabIndex = 78
        Me.email.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "AGE :"
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(432, 438)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(100, 20)
        Me.age.TabIndex = 80
        '
        'frm_customerinsert_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(965, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.grd_staff)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_customerinsert_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Customer"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents back As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents age As TextBox
End Class
