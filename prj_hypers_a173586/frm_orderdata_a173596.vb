Public Class frm_orderdata_a173596
    Private Sub frm_orderdata_a173596_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        order()
    End Sub

    Private Sub order()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        orderid.DataSource = mydatatable
        orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub


End Class