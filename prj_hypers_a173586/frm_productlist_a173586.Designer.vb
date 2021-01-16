<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productlist_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productlist_a173586))
        Me.grd_productlist = New System.Windows.Forms.DataGridView()
        Me.back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.grd_productlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_productlist
        '
        Me.grd_productlist.AllowUserToAddRows = False
        Me.grd_productlist.AllowUserToDeleteRows = False
        Me.grd_productlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grd_productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productlist.Location = New System.Drawing.Point(12, 120)
        Me.grd_productlist.Name = "grd_productlist"
        Me.grd_productlist.ReadOnly = True
        Me.grd_productlist.Size = New System.Drawing.Size(648, 346)
        Me.grd_productlist.TabIndex = 0
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(765, 448)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 5
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 54)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PRODUCT LIST"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(333, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic.Location = New System.Drawing.Point(677, 210)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(175, 173)
        Me.pic.TabIndex = 8
        Me.pic.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(673, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Choose Product ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(691, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "To View Image"
        '
        'frm_productlist_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(870, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.grd_productlist)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_productlist_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product List"
        CType(Me.grd_productlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_productlist As DataGridView
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
