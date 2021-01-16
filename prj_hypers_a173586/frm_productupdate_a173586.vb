Imports System.IO

Public Class frm_productupdate_a173586

    Dim current_code As String
    Dim defaultpicture As String = Application.StartupPath & "\Pictures\nophoto.jpg"
    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        id.Text = current_code
        pname.Text = grd_products(1, current_row).Value
        pprice.Text = grd_products(2, current_row).Value
        type.Text = grd_products(3, current_row).Value
        brand.Text = grd_products(4, current_row).Value
        desc.Text = grd_products(5, current_row).Value
        quantity.Text = grd_products(6, current_row).Value
        material.Text = grd_products(7, current_row).Value

        txt_picture.Text = "Pictures\" & current_code & ".jpg"
        pic_product.BackgroundImage = SafeImage("Pictures\" & current_code & ".jpg")
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub frm_productupdate_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()

        ' txt_picture.Text = defaultpicture
        ' pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable


    End Sub

    Private Sub clear_fields()
        id.Text = ""
        pname.Text = ""
        pprice.Text = ""
        type.Text = ""
        brand.Text = ""
        desc.Text = ""
        quantity.Text = ""
        material.Text = ""
    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A173586 SET FLD_PRODUCT_NAME ='" & pname.Text & "', FLD_PRICE='" & pprice.Text & "', FLD_TYPE='" & type.Text & "', FLD_BRAND='" & brand.Text & "', FLD_DESCRIPTION='" & desc.Text & "', FLD_QUANTITY='" & quantity.Text & "', FLD_MATERIAL='" & material.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        Beep()
        Dim paths As String = txt_picture.Text
        pic_product.BackgroundImage.Dispose()
        pic_product.BackgroundImage = Nothing
        txt_picture.Text = Nothing
        System.IO.File.Delete("Pictures\" & current_code & ".jpg")
        My.Computer.FileSystem.CopyFile(paths, "Pictures\" & current_code & ".jpg")
        MsgBox("You have successfully updated the Product """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pic_product.BackgroundImage = SafeImage(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        End If
        ''OpenFileDialog1.ShowDialog()


    End Sub

    Public Shared Function SafeImage(path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function

    Private Sub pprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantity.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick

    End Sub
End Class