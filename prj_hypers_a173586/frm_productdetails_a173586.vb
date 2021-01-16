Public Class frm_productdetails_a173586
    Private Sub frm_productdetails_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_id.DataSource = mydatatable
        lst_id.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_id.Text)
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
        quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        desc.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        Try
            pic_student.BackgroundImage = Image.FromFile("Pictures/" & ids & ".jpg")
        Catch ex As Exception
            pic_student.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_id.MouseClick
        refresh_text(lst_id.Text)
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_mainmenu_a173586.Show()
        Me.Close()
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs) Handles lv.Click
        frm_productlist_a173586.Show()
    End Sub

    Private Sub lst_id_SelectedValueChanged(sender As Object, e As EventArgs) Handles lst_id.SelectedValueChanged
        ''refresh_text(lst_id.Text)
    End Sub

    Private Sub lst_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_id.SelectedIndexChanged

    End Sub
End Class