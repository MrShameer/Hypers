Public Class frm_customerlist_a173586
    Private Sub grd_stafflist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customerlist.CellContentClick

    End Sub

    Private Sub frm_customerlist_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT*FROM TBL_CUSTOMERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customerlist.DataSource = mydatatable
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_mainmenu_a173586.Show()
        Me.Close()
    End Sub
End Class