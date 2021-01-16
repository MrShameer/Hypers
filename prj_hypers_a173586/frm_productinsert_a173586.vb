Public Class frm_productinsert_a173586
    Dim defaultpicture As String = Application.StartupPath & "\Pictures\nophoto.jpg"
    Private Sub frm_productinsert_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A173586")

        id.Text = generate_matric()

        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A173586").Rows(0).Item("LASTMATRIC")
        '' MsgBox(lastmatric)
        Dim newmatric As String = "P" & (Mid(lastmatric, 2) + 1).ToString("000")
        Return newmatric
    End Function

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName
        Else
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            txt_picture.Text = defaultpicture
        End If

        'OpenFileDialog1.ShowDialog()

        ''pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        ''txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A173586 VALUES ('" & id.Text & "' , '" & pname.Text & "' , '" & pprice.Text & "' , '" & type.Text & "' , '" & brand.Text & "' , '" & desc.Text & "' , '" & quantity.Text & "' , '" & material.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        If id.Text = “” Or pname.Text = “” Or brand.Text = “” Or type.Text = “” Or pprice.Text = “” Or desc.Text = “” Or material.Text = “” Or quantity.Text = “” Then
            MsgBox(“Please enter complete data”)

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A173586")
            id.Text = generate_matric()
            pprice.Text = ""
            pname.Text = ""
            brand.Text = ""
            type.Text = ""
            desc.Text = ""
            material.Text = ""
            quantity.Text = ""

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        Else

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_picture.Text, "Pictures\" & id.Text & ".jpg")

                grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A173586")
                id.Text = generate_matric()
                pprice.Text = ""
                pname.Text = ""
                brand.Text = ""
                type.Text = ""
                desc.Text = ""
                material.Text = ""
                quantity.Text = ""

                txt_picture.Text = defaultpicture
                pic_product.BackgroundImage = Image.FromFile(defaultpicture)

            Catch ex As Exception
                Beep()
                MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
            End Try
        End If
    End Sub

    Private Sub pprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pprice.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantity.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick

    End Sub
End Class