Public Class frm_customerdelete_a173586

    Dim current_code As String
    Private Sub frm_customerdelete_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value

        id.Text = current_code
        pname.Text = grd_customer(1, current_row).Value
        phone.Text = grd_customer(2, current_row).Value
        email.Text = grd_customer(3, current_row).Value
        address.Text = grd_customer(4, current_row).Value
        age.Text = grd_customer(5, current_row).Value
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMERS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        pname.Text = ""
        phone.Text = ""
        age.Text = ""
        email.Text = ""
        address.Text = ""
        id.Text = ""
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the Customer """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMERS_A173586 WHERE FLD_CUSTOMER_ID='" & current_code & "'")
            Beep()
            MsgBox("The Customer """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub
End Class