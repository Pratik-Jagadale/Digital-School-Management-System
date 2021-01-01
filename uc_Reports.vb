Public Class uc_Reports

    Private Sub btn_Students_Reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Students_Reports.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_single_Student_Bill_Report

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)

    End Sub

    Private Sub btn_Staff_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Staff_report.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Student_Puchase_Reports

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Hostel_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Product_Purchse_report.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Product_Purchase_Reports

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Store_Room_Reports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Store_Room_Reports.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Stock_Datewise_Report

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Stock_Report

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student_bill_Datewise_report.Click
        Dim x As Integer = 0
        Dim y As Integer = 0
        frm_Main_Menu.panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Student_Bill_Datewise_Reports

        frm_Main_Menu.panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub
End Class
