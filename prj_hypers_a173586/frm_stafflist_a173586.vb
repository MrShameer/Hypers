Public Class frm_stafflist_a173586
    Private Sub grd_stafftlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_stafflist.CellContentClick

    End Sub

    Private Sub frm_stafflist_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT*FROM TBL_STAFFS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_stafflist.DataSource = mydatatable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        frm_mainmenu_a173586.Show()
        Me.Close()
    End Sub
End Class