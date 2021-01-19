Public Class frm_splashscreen_a173586
    Private Sub order_Click(sender As Object, e As EventArgs) Handles order.Click


        frm_mainmenu_a173586.Show()
        Me.Hide()

    End Sub

    Private Sub frm_splashscreen_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.BackColor = Color.Transparent
        'BackColor = Color.Coral
        ' TransparencyKey = BackColor
        ' frm_mainmenu_a173586.Show()
        ' Me.Hide()
    End Sub
End Class