Imports System.Data.SqlClient

Public Class uc_Stock_Datewise_Report
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
            cmd = New SqlCommand("select * from tbl_Stock_Details where Stock_Added_Date Between  '" + dtp_Start.Text + "' and '" + dtp_End.Text + "'", con)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)

            con.Close()

            Dim rpt As New rpt_Stock()
            rpt.Database.Tables("tbl_Stock_Details").SetDataSource(dt)

            crv_Stock.ReportSource = Nothing
            crv_Stock.ReportSource = rpt

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
