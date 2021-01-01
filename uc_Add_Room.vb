Imports System.Data.SqlClient

Public Class uc_Add_Room
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btn_Save_New_Added_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_New_Added_Room.Click
        Dim nm As String
        Try
check:
            If tb_Add_New_Hostel.Text <> "" And cb_Add_New_Room.Text <> "" Then
                connection()
                cmd.Connection = con
                cmd.CommandText = "select * from  htbl_Room_Master where Hostel_No = '" + tb_Add_New_Hostel.Text + "' and Room_No = '" + cb_Add_New_Room.Text + "' "

                nm = cmd.ExecuteScalar
                If (nm <> "") Then
                    cmd.Dispose()

                    MessageBox.Show("Room Already exits !!!")

                    tb_Add_New_Hostel.Focus()

                    tb_Add_New_Hostel.Text = ""
                    cb_Add_New_Room.Text = ""
                    tb_Add_New_Description.Text = ""

                    cb_Add_New_Room.Enabled = False
                    tb_Add_New_Description.Enabled = False
                    btn_Reset_Add_New_Room.Enabled = False
                    GoTo check

                Else
                    connection()
                    cmd.Connection = con
                    cmd.CommandText = "Insert Into htbl_Room_Master Values ('" + tb_Add_New_Hostel.Text + "','" + cb_Add_New_Room.Text + "','" + tb_Add_New_Description.Text + "' )"

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New Room Added Successfully !!!")

                    tb_Add_New_Hostel.Focus()

                    tb_Add_New_Hostel.Text = ""
                    cb_Add_New_Room.Text = ""
                    tb_Add_New_Description.Text = ""

                    cb_Add_New_Room.Enabled = False
                    tb_Add_New_Description.Enabled = False
                    btn_Reset_Add_New_Room.Enabled = False

                    con.Close()
                    cmd.Dispose()
                End If
                tb_Add_New_Hostel.Focus()

                tb_Add_New_Hostel.Text = ""
                cb_Add_New_Room.Text = ""
                tb_Add_New_Description.Text = ""

                cb_Add_New_Room.Enabled = False
                tb_Add_New_Description.Enabled = False
                btn_Reset_Add_New_Room.Enabled = False
                con.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Add_New_Hostel.Focus()

    End Sub

    Private Sub btn_Reset_Add_New_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset_Add_New_Room.Click
        tb_Add_New_Hostel.Focus()

        tb_Add_New_Hostel.Text = ""
        cb_Add_New_Room.Text = ""
        tb_Add_New_Description.Text = ""

        cb_Add_New_Room.Enabled = False
        tb_Add_New_Description.Enabled = False
        btn_Reset_Add_New_Room.Enabled = False
    End Sub
End Class
