<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a173586
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a173586))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.staffid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.orderid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdcart = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.material = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.brand = New System.Windows.Forms.TextBox()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.pprice = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.TextBox()
        Me.productid = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.ComboBox()
        Me.customer = New System.Windows.Forms.ComboBox()
        Me.BasicIndo = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.totalprice = New System.Windows.Forms.TextBox()
        Me.remove = New System.Windows.Forms.Button()
        CType(Me.grdcart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BasicIndo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 54)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MAKE ORDER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(425, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "This Order is handle by :"
        '
        'staffid
        '
        Me.staffid.Location = New System.Drawing.Point(595, 31)
        Me.staffid.Name = "staffid"
        Me.staffid.ReadOnly = True
        Me.staffid.Size = New System.Drawing.Size(116, 20)
        Me.staffid.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(807, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Order ID:"
        '
        'orderid
        '
        Me.orderid.Location = New System.Drawing.Point(896, 30)
        Me.orderid.Name = "orderid"
        Me.orderid.ReadOnly = True
        Me.orderid.Size = New System.Drawing.Size(100, 20)
        Me.orderid.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Customer ID :"
        '
        'grdcart
        '
        Me.grdcart.AllowUserToAddRows = False
        Me.grdcart.AllowUserToDeleteRows = False
        Me.grdcart.AllowUserToResizeColumns = False
        Me.grdcart.AllowUserToResizeRows = False
        Me.grdcart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdcart.Location = New System.Drawing.Point(25, 595)
        Me.grdcart.Name = "grdcart"
        Me.grdcart.ReadOnly = True
        Me.grdcart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdcart.Size = New System.Drawing.Size(718, 150)
        Me.grdcart.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(345, 572)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CART :"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(955, 786)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 61
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(626, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "DESCRIPTION :"
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(771, 290)
        Me.desc.Multiline = True
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.desc.Size = New System.Drawing.Size(232, 57)
        Me.desc.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 423)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "MATERIAL :"
        '
        'material
        '
        Me.material.Location = New System.Drawing.Point(402, 423)
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        Me.material.Size = New System.Drawing.Size(100, 20)
        Me.material.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(315, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "BRAND :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(692, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "PRICE :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(701, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 20)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "TYPE :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(323, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "NAME : "
        '
        'brand
        '
        Me.brand.Location = New System.Drawing.Point(402, 375)
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        Me.brand.Size = New System.Drawing.Size(100, 20)
        Me.brand.TabIndex = 50
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(57, 299)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(187, 177)
        Me.pic_student.TabIndex = 49
        Me.pic_student.TabStop = False
        '
        'pprice
        '
        Me.pprice.Location = New System.Drawing.Point(771, 423)
        Me.pprice.Name = "pprice"
        Me.pprice.ReadOnly = True
        Me.pprice.Size = New System.Drawing.Size(100, 20)
        Me.pprice.TabIndex = 47
        '
        'type
        '
        Me.type.Location = New System.Drawing.Point(771, 375)
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Size = New System.Drawing.Size(100, 20)
        Me.type.TabIndex = 46
        '
        'productid
        '
        Me.productid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productid.FormattingEnabled = True
        Me.productid.Location = New System.Drawing.Point(525, 232)
        Me.productid.Name = "productid"
        Me.productid.Size = New System.Drawing.Size(121, 21)
        Me.productid.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(414, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Product ID :"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(402, 290)
        Me.pname.Multiline = True
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        Me.pname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.pname.Size = New System.Drawing.Size(203, 36)
        Me.pname.TabIndex = 64
        Me.pname.WordWrap = False
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Green
        Me.lv.Location = New System.Drawing.Point(801, 623)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(211, 32)
        Me.lv.TabIndex = 65
        Me.lv.Text = "ADD TO CART"
        Me.lv.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(425, 775)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 32)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "CHECKOUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(292, 471)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 20)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "QUANTITY :"
        '
        'quantity
        '
        Me.quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.quantity.FormattingEnabled = True
        Me.quantity.Location = New System.Drawing.Point(403, 470)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(121, 21)
        Me.quantity.TabIndex = 68
        '
        'customer
        '
        Me.customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customer.FormattingEnabled = True
        Me.customer.Location = New System.Drawing.Point(180, 32)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(121, 21)
        Me.customer.TabIndex = 70
        '
        'BasicIndo
        '
        Me.BasicIndo.BackColor = System.Drawing.Color.Transparent
        Me.BasicIndo.Controls.Add(Me.orderid)
        Me.BasicIndo.Controls.Add(Me.customer)
        Me.BasicIndo.Controls.Add(Me.staffid)
        Me.BasicIndo.Controls.Add(Me.Label5)
        Me.BasicIndo.Controls.Add(Me.Label3)
        Me.BasicIndo.Controls.Add(Me.Label4)
        Me.BasicIndo.Location = New System.Drawing.Point(12, 134)
        Me.BasicIndo.Name = "BasicIndo"
        Me.BasicIndo.Size = New System.Drawing.Size(1036, 73)
        Me.BasicIndo.TabIndex = 71
        Me.BasicIndo.TabStop = False
        Me.BasicIndo.Text = "Basic Info"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(632, 473)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 20)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "TOTAL PRICE :"
        '
        'totalprice
        '
        Me.totalprice.Location = New System.Drawing.Point(771, 471)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        Me.totalprice.Size = New System.Drawing.Size(100, 20)
        Me.totalprice.TabIndex = 72
        '
        'remove
        '
        Me.remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remove.Location = New System.Drawing.Point(781, 681)
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(257, 32)
        Me.remove.TabIndex = 74
        Me.remove.Text = "REMOVE FROM CART"
        Me.remove.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.ClientSize = New System.Drawing.Size(1060, 836)
        Me.ControlBox = False
        Me.Controls.Add(Me.remove)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.totalprice)
        Me.Controls.Add(Me.BasicIndo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.productid)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.material)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.brand)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.pprice)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grdcart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_makeorder_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Order"
        CType(Me.grdcart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BasicIndo.ResumeLayout(False)
        Me.BasicIndo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents staffid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents orderid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grdcart As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents back As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents desc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents material As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents brand As TextBox
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents pprice As TextBox
    Friend WithEvents type As TextBox
    Friend WithEvents productid As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents lv As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents quantity As ComboBox
    Friend WithEvents customer As ComboBox
    Friend WithEvents BasicIndo As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents totalprice As TextBox
    Friend WithEvents remove As Button
End Class
