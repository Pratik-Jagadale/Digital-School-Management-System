Imports System.Data.SqlClient

Public Class uc_Delete_Room
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub


    Private Sub btn_Delete_Room_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Room_Update.Click
        Dim nm As String
        Try
            If cb_Hostel_Number_Update.Text <> "" And cb_Room_Number_Update.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "select * from Htbl_Room_Master where Hostel_No ='" + cb_Hostel_Number_Update.Text + "'and Room_No = '" + cb_Room_Number_Update.Text + "' "

                nm = cmd.ExecuteScalar
                If (nm <> "") Then
                    cmd.Dispose()
                    cmd.CommandText = "Delete from Htbl_Room_Master where Hostel_No = '" + cb_Hostel_Number_Update.Text + "' and Room_No = '" + cb_Room_Number_Update.Text + "'"
                    cmd.ExecuteNonQuery()
                Else
                    MessageBox.Show("Room is not Available !!")
                End If
                MessageBox.Show("Room Deleted Succesfully !!!")
            Else

            End If
            cb_Room_Number_Update.Focus()

            cb_Room_Number_Update.Text = ""
            cb_Room_Number_Update.Enabled = False
            btn_Delete_Room_Update.Enabled = False
            btn_Reset_Room_Update.Enabled = False

            cb_Room_Number_Update.Text = ""

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cb_Room_Number_Update.Focus()
    End Sub
End Class
