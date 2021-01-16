Public Class frm_productlist_a173586
    Private Sub grd_productlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productlist.CellContentClick, grd_productlist.CellClick
        Dim value As String = grd_productlist.Rows(e.RowIndex).Cells(0).Value.ToString()
        ''e.ColummIndex
        If IsDBNull(value) Then

        Else
            ref(value)
        End If
    End Sub

    Private Sub frm_productlist_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT*FROM TBL_PRODUCTS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_productlist.DataSource = mydatatable

        Me.grd_productlist.Columns(2).DefaultCellStyle.Format = "c"

        ref(grd_productlist.Rows(0).Cells(0).Value.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_productdetails_a173586.Show()
        Me.Close()
    End Sub

    Private Sub pic_Click(sender As Object, e As EventArgs) Handles pic.Click

    End Sub

    Private Sub ref(id As String)
        Try
            pic.BackgroundImage = Image.FromFile("Pictures/" & id & ".jpg")
        Catch ex As Exception
            pic.BackgroundImage = Image.FromFile("Pictures/nophoto.jpg")
        End Try
    End Sub

End Class