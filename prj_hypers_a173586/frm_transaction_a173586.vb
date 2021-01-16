Public Class frm_transaction_a173586
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_mainmenu_a173586.Show()
        Me.Close()
    End Sub

    Private Sub grd_customerlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customerlist.CellContentClick

    End Sub

    Private Sub frm_transaction_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT*FROM TBL_TRANSACTIONS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customerlist.DataSource = mydatatable
    End Sub
End Class