Imports System.Data.SqlClient

Public Class uc_single_Student_Bill_Report
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Dim sum As Integer = 0

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Reports

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        Try
            connection()

            Dim dt As New DataTable()
            cmd.Connection = con
            cmd = New SqlCommand("select * from tbl_Stud_Master where Student_ID = " + tb_Student_id.Text + " ", con)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)

            Dim dt2 As New DataTable()

            cmd = New SqlCommand("select * from tbl_Stud_Fee_Master where Student_ID = " + tb_Student_id.Text + " ", con)
            adp = New SqlDataAdapter(cmd)
            adp.Fill(dt2)
            con.Close()

            Dim rpt As New rpt_Signle_Student_fees()
            rpt.Database.Tables("tbl_Stud_Master").SetDataSource(dt)
            rpt.Database.Tables("tbl_Stud_Fee_Master").SetDataSource(dt2)

            crv_Single_student_fee.ReportSource = Nothing
            crv_Single_student_fee.ReportSource = rpt

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub tb_Student_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Student_id.TextChanged

    End Sub
End Class
