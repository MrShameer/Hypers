<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderlist_a173586
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderlist_a173586))
        Me.grd_orderlist = New System.Windows.Forms.DataGridView()
        Me.back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_orderlist
        '
        Me.grd_orderlist.AllowUserToAddRows = False
        Me.grd_orderlist.AllowUserToDeleteRows = False
        Me.grd_orderlist.AllowUserToResizeColumns = False
        Me.grd_orderlist.AllowUserToResizeRows = False
        Me.grd_orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderlist.Location = New System.Drawing.Point(162, 108)
        Me.grd_orderlist.Name = "grd_orderlist"
        Me.grd_orderlist.ReadOnly = True
        Me.grd_orderlist.Size = New System.Drawing.Size(544, 336)
        Me.grd_orderlist.TabIndex = 3
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Red
        Me.back.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.jhnb
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(765, 446)
        Me.back.Name = "back"
        Me.back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.back.Size = New System.Drawing.Size(93, 38)
        Me.back.TabIndex = 10
        Me.back.Text = "BACK "
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 54)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ORDER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(332, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 52)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "HYPERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frm_orderlist_a173586
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prj_hypers_a173586.My.Resources.Resources.Main_Menu_BG13
        Me.ClientSize = New System.Drawing.Size(870, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.grd_orderlist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_orderlist_a173586"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order List"
        CType(Me.grd_orderlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_orderlist As DataGridView
    Friend WithEvents back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
