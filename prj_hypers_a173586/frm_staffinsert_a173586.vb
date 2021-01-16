Public Class frm_staffinsert_a173586
    Private Sub phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phone.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub frm_staffinsert_a173586_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        clear_fields()
    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFFS_A173586")
    End Sub

    Private Sub clear_fields()
        pname.Text = ""
        phone.Text = ""
        id.Text = generate_id()
    End Sub

    Private Function generate_id() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTMATRIC FROM TBL_STAFFS_A173586").Rows(0).Item("LASTMATRIC")
        '' MsgBox(lastmatric)
        Dim newmatric As String = "S" & (Mid(lastmatric, 2) + 1).ToString("000")
        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFFS_A173586 VALUES ('" & id.Text & "', '" & pname.Text & "', '" & phone.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        If pname.Text = “” Or phone.Text = “” Then
            MsgBox(“Please enter complete data”)
        Else
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                refresh_grid()
                clear_fields()
            Catch ex As Exception
                Beep()
                MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
            End Try
        End If

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
    End Sub
End Class