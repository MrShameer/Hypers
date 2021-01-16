<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productinsert_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productinsert_a173586))
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.pprice = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.ComboBox()
        Me.brand = New System.Windows.Forms.ComboBox()
        Me.material = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_picture.Location = New System.Drawing.Point(50, 361)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(128, 34)
        Me.btn_picture.TabIndex = 17
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(30, 123)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(167, 158)
        Me.pic_product.TabIndex = 16
        Me.pic_product.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(51, 330)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.ReadOnly = True
        Me.txt_picture.Size = New System.Drawing.Size(128, 20)
        Me.txt_picture.TabIndex = 15
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_insert.Location = New System.Drawing.Point(445, 568)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(196, 32)
        Me.btn_insert.TabIndex = 14
        Me.btn_insert.Text = "INSERT PRODUCT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(65, 293)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 11
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.AllowUserToResizeColumns = False
        Me.grd_products.AllowUserToResizeRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(232, 114)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        Me.grd_products.Size = New System.Drawing.Size(824, 249)
        Me.grd_products.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(406, 54)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "INSERT PRODUCT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(444, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(770, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "DESCRIPTION :"
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(734, 498)
        Me.desc.Multiline = True
        Me.desc.Name = "desc"
        Me.desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.desc.Size = New System.Drawing.Size(232, 57)
        Me.desc.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(556, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "QUANTITY :"
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(550, 498)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(100, 20)
        Me.quantity.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "MATERIAL :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 471)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "BRAND :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(547, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "PRICE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "TYPE :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "NAME :"
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(248, 411)
        Me.pname.Multiline = True
        Me.pname.Name = "pname"
        Me.pname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.pname.Size = New System.Drawing.Size(203, 36)
        Me.pname.TabIndex = 28
        Me.pname.WordWrap = False
        '
        'pprice
        '
        Me.pprice.Location = New System.Drawing.Point(530, 411)
        Me.pprice.Name = "pprice"
        Me.pprice.Size = New System.Drawing.Size(100, 20)
        Me.pprice.TabIndex = 27
        '
        'type
        '
        Me.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"Action Figure", "Building", "Vehicle", "Weapon", "Electronic", "Other"})
        Me.type.Location = New System.Drawing.Point(707, 410)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(131, 21)
        Me.type.TabIndex = 40
        '
        'brand
        '
        Me.brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brand.FormattingEnabled = True
        Me.brand.Items.AddRange(New Object() {"Hasbro", "Lego", "ToysRUs", "Knex", "Nintendo", "Playmobil", "Other"})
        Me.brand.Location = New System.Drawing.Point(154, 497)
        Me.brand.Name = "brand"
        Me.brand.Size = New System.Drawing.Size(131, 21)
        Me.brand.TabIndex = 41
        '
        'material
        '
        Me.material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.material.FormattingEnabled = True
        Me.material.Items.AddRange(New Object() {"Plastic", "Metal", "Flexible Plastic", "Paper", "Fur", "CD", "Other"})
        Me.material.Location = New System.Drawing.Point(348, 497)
        Me.material.Name = "material"
        Me.material.Size = New System.Drawing.Size(131, 21)
        Me.material.TabIndex = 42
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(981, 566)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 43
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'frm_productinsert_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1086, 612)
        Me.ControlBox = False
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.material)
        Me.Controls.Add(Me.brand)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.pprice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.grd_products)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_productinsert_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Insert"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_picture As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents id As TextBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents desc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents quantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents pprice As TextBox
    Friend WithEvents type As ComboBox
    Friend WithEvents brand As ComboBox
    Friend WithEvents material As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents back As Button
End Class
