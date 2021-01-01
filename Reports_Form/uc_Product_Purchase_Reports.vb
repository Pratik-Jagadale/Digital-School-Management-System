﻿Imports System.Data.SqlClient

Public Class uc_Product_Purchase_Reports
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
            cmd = New SqlCommand("select * from stbl_Product_Purchase_Details where Product_ID = " + tb_Student_id.Text + " ", con)
            Dim adp As New SqlDataAdapter(cmd)
            adp.Fill(dt)


            Dim rpt As New rpt_Product_Purchase()
            rpt.Database.Tables("stbl_Product_Purchase_Details").SetDataSource(dt)

            crv_Product_Pruchase_Report.ReportSource = Nothing
            crv_Product_Pruchase_Report.ReportSource = rpt

            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()

    End Sub
End Class
