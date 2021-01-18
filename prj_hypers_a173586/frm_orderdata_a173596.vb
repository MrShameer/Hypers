Public Class frm_orderdata_a173596
    Dim bmp As Bitmap
    Private Sub frm_orderdata_a173596_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        order()
        updates(orderid.Text)
    End Sub

    Private Sub order()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        orderid.DataSource = mydatatable
        orderid.DisplayMember = "FLD_ORDER_ID"
    End Sub

    Private Sub updates(ids As String)
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
        For Each row As DataRow In tran.Rows
            Dim pro As DataTable = run_sql_query("SELECT FLD_PRODUCT_NAME, FLD_PRICE FROM TBL_PRODUCTS_A173586 WHERE FLD_PRODUCT_ID = '" & row.Item("FLD_PRODUCT_ID") & "'")
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
    End Sub

    Private Sub orderid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles orderid.SelectedIndexChanged
        Try
            updates(orderid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim graphic As Graphics
        bmp = New Bitmap(Me.Width - 10, Me.Height)
        graphic = Graphics.FromImage(bmp)
        graphic.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, bmp.Size)
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", Me.Width, Me.Height)
        ' PrintDocument1.PrinterSettings.PrintToFile = True
        '' PrintDocument1.PrinterSettings.PrintFileName = "ghvgh"
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDocument1.PrinterSettings.PrintFileName = "ali.pdf"
    End Sub
End Class