Imports System.Data.SqlClient

Public Class uc_Delete_Hostel
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub btn_delete_Hostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_Hostel.Click
        frm_Hostel_MDI.Panel_Delete_Hostel_Room.Visible = True
        frm_Hostel_MDI.Panel_Delete_Hostel_Room.Controls.Clear()
        Dim obj = New uc_Delete_Room

        frm_Hostel_MDI.Panel_Delete_Hostel_Room.Controls.Add(obj)
        obj.cb_Hostel_Number_Update.Text = btn_delete_Hostel.Text
        frm_Hostel_MDI.btn_Delete_Hostel.Text = btn_delete_Hostel.Text
        frm_Hostel_MDI.Label1.Visible = True

            End Sub
End Class
