Public Class frm_staffupdate_a173586
    Dim current_code As String

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        id.Text = current_code
        pname.Text = grd_staff(1, current_row).Value
        phone.Text = grd_staff(2, current_row).Value
    End Sub

    Private Sub frm_staffupdate_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFFS_A173586"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        id.Text = ""
        pname.Text = ""
        phone.Text = ""
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFFS_A173586 SET FLD_STAFF_NAME='" & pname.Text & "' , FLD_STAFF_PHONENO='" & phone.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the Staff """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub

    Private Sub phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub
End Class