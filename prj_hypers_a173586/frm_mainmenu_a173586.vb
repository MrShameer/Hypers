Public Class frm_mainmenu_a173586
    Private Sub product_Click(sender As Object, e As EventArgs) Handles product.Click
        frm_productdetails_a173586.Show()
        ''Me.Hide()
    End Sub

    Private Sub frm_mainmenu_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub staff_Click(sender As Object, e As EventArgs) Handles staff.Click
        frm_stafflist_a173586.Show()
        '' Me.Hide()
    End Sub

    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click
        frm_customerlist_a173586.Show()
        ''Me.Hide()
    End Sub

    Private Sub order_Click(sender As Object, e As EventArgs) Handles order.Click
        frm_orderlist_a173586.Show()
        '' Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_transaction_a173586.Show()
        ''  Me.Hide()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub Inp_Click(sender As Object, e As EventArgs) Handles Inp.Click
        frm_productinsert_a173586.Show()
    End Sub

    Private Sub Upp_Click(sender As Object, e As EventArgs) Handles Upp.Click
        frm_productupdate_a173586.Show()
    End Sub

    Private Sub Delp_Click(sender As Object, e As EventArgs) Handles Delp.Click
        frm_productdelete_a173586.Show()
    End Sub

    Private Sub ins_Click(sender As Object, e As EventArgs) Handles ins.Click
        frm_staffinsert_a173586.Show()
    End Sub

    Private Sub ups_Click(sender As Object, e As EventArgs) Handles ups.Click
        frm_staffupdate_a173586.Show()
    End Sub

    Private Sub dels_Click(sender As Object, e As EventArgs) Handles dels.Click
        frm_staffdelete_a173586.Show()
    End Sub

    Private Sub inc_Click(sender As Object, e As EventArgs) Handles inc.Click
        frm_customerinsert_a173586.Show()
    End Sub

    Private Sub upc_Click(sender As Object, e As EventArgs) Handles upc.Click
        frm_customerupdate_a173586.Show()
    End Sub

    Private Sub delc_Click(sender As Object, e As EventArgs) Handles delc.Click
        frm_customerdelete_a173586.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_makeorder_a173586.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_orderdata_a173596.Show()
    End Sub
End Class
