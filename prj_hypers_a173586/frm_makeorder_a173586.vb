Public Class frm_makeorder_a173586

    Dim count As Integer
    Private Sub frm_makeorder_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' cust.Text = generate_customer()
        staffid.Text = generate_staff()
        orderid.Text = generate_order()

        cust()
        prod()
        Dim data As DataTable = run_sql_query("SELECT * FROM TBL_TRANSACTIONS_A173586")
        '' Dim df As Integer = data.Columns.Count
        ''MsgBox(df)
        grdcart.ColumnCount = data.Columns.Count
        ''MsgBox(grdcart.Columns.Count)
        For i = 0 To data.Columns.Count - 1
            grdcart.Columns(i).HeaderText = data.Columns(i).ColumnName
        Next
        refresh_text(productid.Text)
        count = 0
        cartprice.Text = count
    End Sub

    Private Sub refresh_text(ids As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173586 WHERE FLD_PRODUCT_ID = '" & ids & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        ''Dim v = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        pname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        pprice.Text = "RM " & mydatatable.Rows(0).Item("FLD_PRICE")
        type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        material.Text = mydatatable.Rows(0).Item("FLD_MATERIAL")
        desc.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")

        quantity.Items.Clear()
        quantity.Items.AddRange(Enumerable.Range(1, mydatatable.Rows(0).Item("FLD_QUANTITY")).Select(Function(s) s.ToString()).ToArray())
        quantity.SelectedIndex = 0

        Try
            pic_student.BackgroundImage = Image.FromFile("Pictures/" & ids & ".jpg")
        Catch ex As Exception
            pic_student.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Function generate_order() As String
        Try
            Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTMATRIC FROM TBL_ORDERS_A173586").Rows(0).Item("LASTMATRIC")
            '' MsgBox(lastmatric)
            Dim newmatric As String = "O" & (Mid(lastmatric, 2) + 1).ToString("000")
            Return newmatric

        Catch ex As Exception
            Return "O001"
        End Try
    End Function

    Private Sub cust()
        Dim mysql As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        customer.DataSource = mydatatable
        customer.DisplayMember = "FLD_CUSTOMER_ID"
    End Sub

    Private Sub prod()
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        productid.DataSource = mydatatable
        productid.DisplayMember = "FLD_PRODUCT_ID"
    End Sub


    Private Function generate_staff() As String
        '' Dim rn As Integer = System.Random
        Dim rdm As New Random()
        Dim data As DataTable = run_sql_query("SELECT FLD_STAFF_ID AS RN FROM TBL_STAFFS_A173586 ORDER BY RND()")
        Dim rands As String = data.Rows(rdm.Next(0, data.Rows.Count)).Item("RN")
        '' MsgBox(lastmatric)
        Return rands
    End Function

    Private Sub productid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productid.SelectedIndexChanged
        Try
            refresh_text(productid.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_mainmenu_a173586.Show()
        Me.Close()
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        grdcart.Rows.Add(orderid.Text, productid.Text, quantity.Text, totalprice.Text)
        cartprice.Text = Val(totalprice.Text) + Val(cartprice.Text)
    End Sub

    Private Sub quantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles quantity.SelectedIndexChanged
        Try
            Dim qu As Integer = (quantity.Text)
            Dim pr As Integer = (pprice.Text)
            totalprice.Text = qu * pr
        Catch ex As Exception

        End Try
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        grdcart.Rows.RemoveAt(grdcart.SelectedRows(0).Index)
    End Sub

    Private Sub customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customer.SelectedIndexChanged
        grdcart.Rows.Clear()
    End Sub
End Class