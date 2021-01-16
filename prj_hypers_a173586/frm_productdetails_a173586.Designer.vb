<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a173586))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.pprice = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.lst_id = New System.Windows.Forms.ListBox()
        Me.brand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.material = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.back = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.Button()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(429, 54)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "PRODUCT DETAILS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(212, 163)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(169, 182)
        Me.pic_student.TabIndex = 14
        Me.pic_student.TabStop = False
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(555, 127)
        Me.pname.Multiline = True
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        Me.pname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.pname.Size = New System.Drawing.Size(203, 36)
        Me.pname.TabIndex = 13
        Me.pname.WordWrap = False
        '
        'pprice
        '
        Me.pprice.Location = New System.Drawing.Point(555, 182)
        Me.pprice.Name = "pprice"
        Me.pprice.ReadOnly = True
        Me.pprice.Size = New System.Drawing.Size(100, 20)
        Me.pprice.TabIndex = 12
        '
        'type
        '
        Me.type.Location = New System.Drawing.Point(555, 220)
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Size = New System.Drawing.Size(100, 20)
        Me.type.TabIndex = 11
        '
        'lst_id
        '
        Me.lst_id.FormattingEnabled = True
        Me.lst_id.Location = New System.Drawing.Point(42, 128)
        Me.lst_id.Name = "lst_id"
        Me.lst_id.Size = New System.Drawing.Size(121, 290)
        Me.lst_id.TabIndex = 10
        '
        'brand
        '
        Me.brand.Location = New System.Drawing.Point(555, 262)
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        Me.brand.Size = New System.Drawing.Size(100, 20)
        Me.brand.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(480, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NAME :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TYPE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "PRICE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(468, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "BRAND :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(441, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "MATERIAL :"
        '
        'material
        '
        Me.material.Location = New System.Drawing.Point(555, 307)
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Size = New System.Drawing.Size(100, 20)
        Me.material.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(442, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "QUANTITY :"
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(555, 346)
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Size = New System.Drawing.Size(100, 20)
        Me.quantity.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "DESCRIPTION :"
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(555, 386)
        Me.desc.Multiline = True
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.desc.Size = New System.Drawing.Size(232, 57)
        Me.desc.TabIndex = 24
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(775, 456)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 26
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lv.Location = New System.Drawing.Point(367, 457)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(146, 32)
        Me.lv.TabIndex = 27
        Me.lv.Text = "List View"
        Me.lv.UseVisualStyleBackColor = False
        '
        'frm_productdetails_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(880, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.material)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.brand)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.pprice)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.lst_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_productdetails_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details"
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents pname As TextBox
    Friend WithEvents pprice As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents lst_id As ListBox
    Friend WithEvents brand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents material As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents quantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents desc As TextBox
    Friend WithEvents back As Button
    Friend WithEvents lv As Button
End Class
