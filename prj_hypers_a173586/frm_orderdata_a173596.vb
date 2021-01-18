Public Class frm_orderdata_a173596
    Private Sub frm_orderdata_a173596_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        order()
        'orderid.SelectedIndex = 0
        update(orderid.Text)
    End Sub

    Private Sub order()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        orderid.DataSource = mydatatable
        orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub update(ids As String)
        item.Text = ""
        quantity.Text = ""
        unit.Text = ""
        total.Text = ""
        ftotal.Text = ""
        Dim dat As DataTable = run_sql_query("SELECT * FROM TBL_ORDERS_A173586 WHERE FLD_ORDER_ID = '" & ids & "'")
        cid.Text = dat.Rows(0).Item("FLD_CUSTOMER_ID")
        did.Text = dat.Rows(0).Item("FLD_ORDER_DATE")
        sid.Text = dat.Rows(0).Item("FLD_STAFF_ID")

        Dim tran As DataTable = run_sql_query("SELECT * FROM TBL_TRANSACTIONS_A173586 WHERE FLD_ORDER_ID = '" & ids & "'")
        'MsgBox(tran.Rows.Count)
        For Each row As DataRow In tran.Rows
            Dim pro As DataTable = run_sql_query("SELECT FLD_PRODUCT_NAME, FLD_PRICE FROM TBL_PRODUCTS_A173586 WHERE FLD_PRODUCT_ID = '" & row.Item("FLD_PRODUCT_ID") & "'")
            'Dim tx As String = item.Text +
            ' MsgBox(tx)
            item.Text += pro.Rows(0).Item("FLD_PRODUCT_NAME") + Environment.NewLine
            quantity.Text += row.Item("FLD_QUANTITY") + Environment.NewLine
            unit.Text += "RM" + pro.Rows(0).Item("FLD_PRICE").ToString + Environment.NewLine
            total.Text += "RM" + row.Item("FLD_PRICE").ToString + Environment.NewLine
            ftotal.Text = Val(ftotal.Text) + row.Item("FLD_PRICE")
        Next
        item.Text = item.Text.Remove(item.Text.LastIndexOf(Environment.NewLine))
        quantity.Text = quantity.Text.Remove(quantity.Text.LastIndexOf(Environment.NewLine))
        unit.Text = unit.Text.Remove(unit.Text.LastIndexOf(Environment.NewLine))
        total.Text = total.Text.Remove(total.Text.LastIndexOf(Environment.NewLine))
        ftotal.Text = "RM" + ftotal.Text
        'total.Text = "RM" + total.Text
        '' item.Text = tran.Rows(0).Item("FLD_PRODUCT_ID")
        'did.Text = tran.Rows(0).Item("FLD_ORDER_DATE")
        'sid.Text = tran.Rows(0).Item("FLD_STAFF_ID")
    End Sub

    Private Sub orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles orderid.SelectedIndexChanged
        Try
            update(orderid.Text)

        Catch ex As Exception

        End Try

    End Sub
End Class