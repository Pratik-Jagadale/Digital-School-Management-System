Public Class uc_Hostel


    Private Sub btn_add_Hostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_Hostel.Click
        frm_Hostel_MDI.Panel_Add_New_Room.Visible = True
        frm_Hostel_MDI.Panel_Add_New_Room.Controls.Clear()
        Dim obj = New uc_Add_Room

        frm_Hostel_MDI.Panel_Add_New_Room.Controls.Add(obj)
        obj.tb_Add_New_Hostel.Text = btn_add_Hostel.Text

    End Sub
End Class
