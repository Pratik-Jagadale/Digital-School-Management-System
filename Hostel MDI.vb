Imports System.Data.SqlClient

Public Class frm_Hostel_MDI
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Dim obj = New common_class

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Administration.Click
        lbl.Text = "Administration"
        common_class.menu_hide_open(Panel_admin)
        If panel_report.Visible = True Then
            panel_report.Visible = False
        End If
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.Click
        lbl.Text = "                Reports"
        common_class.menu_hide_open(panel_report)
        If Panel_admin.Visible = True Then
            Panel_admin.Visible = False
        End If
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home_Hostel.Click
        lbl.Text = "Dgital School Management Systemm"
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_My_Account.Click
        lbl.Text = "      My Account"
        TabControl1.SelectedIndex = 3
        tb_Username.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Back_to_Main_Menu.Click
        frm_Main_Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Add_New_RoomClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Room.Click
        Panel_Add_Hostel.Controls.Clear()
        Dim dr As SqlDataReader
        Dim x As Integer = 25
        Dim y As Integer = 39
        cmd.Dispose()
        connection()

        cmd = New SqlCommand("select distinct Hostel_No from Htbl_Room_Master", con)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim obj = New uc_Hostel
            obj.btn_add_Hostel.Text = dr("Hostel_No")
            Panel_Add_Hostel.Controls.Add(obj)
            obj.Location = New System.Drawing.Point(x, y)
            x = x + 350
        End While

        dr.Close()
        cmd.Dispose()
        lbl.Text = "ADD NEW ROOM"
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Room.Click
        Panel_Delete_Room.Controls.Clear()
        Dim dr As SqlDataReader
        Dim x As Integer = 25
        Dim y As Integer = 39
        cmd.Dispose()
        connection()

        cmd = New SqlCommand("select distinct Hostel_No from Htbl_Room_Master", con)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim obj = New uc_Delete_Hostel
            obj.btn_delete_Hostel.Text = dr("Hostel_No")
            Panel_Delete_Room.Controls.Add(obj)
            obj.Location = New System.Drawing.Point(x, y)
            x = x + 350
        End While

        dr.Close()
        cmd.Dispose()
        lbl.Text = "DELETE ROOM"
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student_Registration.Click
        lbl.Text = "STUDENT REGISTRATION"
        TabControl2.SelectedIndex = 2
        tb_Student_id_Registration.Focus()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Room_Report.Click
        lbl.Text = "     Room Reports"
        Home.SelectedIndex = 0
        tb_Hostel_No_srch_Room_info.Focus()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student_Report.Click
        lbl.Text = "     Student Reports"
        Home.SelectedIndex = 1
        cb_Student_id__Student_info.Focus()
    End Sub

    Private Sub btn_Administration_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Administration.MouseHover
        common_class.menu_hide_open(Panel_admin)
        If panel_report.Visible = True Then
            panel_report.Visible = False
        End If
        TabControl1.SelectedIndex = 1
        TabControl2.SelectedIndex = 3
    End Sub

    Private Sub btn_Report_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.MouseHover
        common_class.menu_hide_open(panel_report)
        If Panel_admin.Visible = True Then
            Panel_admin.Visible = False
        End If
        TabControl1.SelectedIndex = 2
        Home.SelectedIndex = 2
    End Sub

    Private Sub frm_Hostel_MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If common_class.gbl_var = 2 Then
            btn_Exit_to_login.Visible = True
            btn_Back_to_Main_Menu.Visible = False
            common_class.gbl_var = 0
        ElseIf common_class.gbl_var = 3 Then
            btn_Back_to_Main_Menu.Visible = True
            common_class.gbl_var = 0

        End If
    End Sub

    Private Sub btn_Exit_to_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit_to_login.Click
        Me.Hide()
        frm_Login.Show()
        btn_Exit_to_login.Visible = False
        btn_Back_to_Main_Menu.Visible = True
    End Sub

    Private Sub frm_Hostel_MDI_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If common_class.gbl_var = 2 Then
            btn_Exit_to_login.Visible = True
            btn_Back_to_Main_Menu.Visible = False
            common_class.gbl_var = 0
        ElseIf common_class.gbl_var = 3 Then
            btn_Back_to_Main_Menu.Enabled = True
            common_class.gbl_var = 0
        End If
        'connection()
        'Dim cmd As New SqlCommand("select distinct(Hostel_No) from Htbl_Room_Master", con)
        'Dim adapter1 As New SqlDataAdapter(cmd)
        'Dim table As New DataTable()

        'adapter1.Fill(table)
        'cb_Hostel_Number_Registration.DataSource = table
        'cb_Hostel_Number_Registration.DisplayMember = "Hostel_No"

        'adapter1.Dispose()
        'cmd.Dispose()
        'table.Clear()

    End Sub

    Private Sub tb_Student_id_Registration_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Student_id_Registration.TextChanged
        btn_Search_Student_id_Registration.Enabled = True
    End Sub

    Private Sub tb_Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Username.TextChanged
        tb_Current_Password.Enabled = True
    End Sub

    Private Sub tb_Current_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Current_Password.TextChanged
        tb_New_Password.Enabled = True
    End Sub

    Private Sub tb_New_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_New_Password.TextChanged
        btn_Confirm_New_Password.Enabled = True
    End Sub

    Private Sub btn_Confirm_New_Password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirm_New_Password.Click
        Try
            If tb_Username.Text <> "" And tb_Current_Password.Text <> "" And tb_New_Password.Text <> "" And tb_Current_Password.Text.ToString = tb_New_Password.Text.ToString Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "Update tb_login set Password = '" + tb_New_Password.Text + "' where User_Name = '" & tb_Username.Text & "' "
                cmd.ExecuteNonQuery()

                MessageBox.Show("Password Updated Succesfully!!!")
            Else
                MessageBox.Show("Please Fill Correct Information!!")

                tb_Username.Focus()

                tb_Current_Password.Enabled = False
                tb_New_Password.Enabled = False
                btn_Confirm_New_Password.Enabled = False

                common_class.clear_tb(Panel_my_acnt)
            End If
            tb_Username.Focus()

            tb_Current_Password.Enabled = False
            tb_New_Password.Enabled = False
            btn_Confirm_New_Password.Enabled = False

            common_class.clear_tb(Panel_my_acnt)
            common_class.clear_cb(Panel_my_acnt)

            con.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cb_Student_id__Student_info_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Student_id__Student_info.TextChanged
        btn_Search_Student_id__Student_info.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Hostel_No_srch_Room_info.TextChanged
        btn_Search_Room_info.Enabled = True
    End Sub

    Private Sub btn_Search_Room_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Room_info.Click
        Try
            cmd.Connection = con
            connection()

            cmd = New SqlCommand("select *from Htbl_Hostel_Student_Master where Hostel_No like '%" & tb_Hostel_No_srch_Room_info.Text & "%'", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_Room_Information.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Refresh_Room_Info_grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh_Room_Info_grid.Click
        tb_Hostel_No_srch_Room_info.Focus()
        Grid_Room_Information.DataSource = ""
        btn_Search_Room_info.Enabled = False
    End Sub

    Private Sub btn_Search_Student_id__Student_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Student_id__Student_info.Click
        Try
            cmd.Connection = con
            connection()

            cmd = New SqlCommand("select *from Htbl_Hostel_Student_Master where Student_ID like '%" & cb_Student_id__Student_info.Text & "%'", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_Student_Report.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Search_Student_id_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Student_id_Registration.Click
        'Try
        connection()
        Dim dr As SqlDataReader
        cmd = New SqlCommand("Select * From Htbl_Hostel_Student_Master where Student_ID = " + tb_Student_id_Registration.Text + " ", con)
        Dim i As Integer = 0

        i = cmd.ExecuteScalar

        If (i > 0) Then

            ' cmd.Dispose()
            ' connection()
            ' cmd.Connection = con

            ' cmd.CommandText = "Select * From Htbl_Hostel_Student_Master where Student_ID = " + tb_Student_id_Registration.Text + ""
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                tb_Hostel_Fees_Registration.Text = dr("Paid_Fee").ToString
                cb_Hostel_Number_Registration.Text = dr("Hostel_No").ToString
                cb_Room_Number_Registration.Text = dr("Room_No").ToString

                MessageBox.Show("Student Already Admitted in the Hostel")
                MessageBox.Show("You Can Remove Student From Hostel")
                btn_Search_Student_id_Registration.Enabled = True
            Else

                MessageBox.Show("Invalid Student ID!!!")

            End If
            btn_Delete_Registration.Enabled = True
            btn_Confirm_Registration.Enabled = False
            btn_Search_Student_id_Registration.Enabled = False
            cb_Hostel_Number_Registration.Enabled = False
            cb_Room_Number_Registration.Enabled = False
            btn_Reset_Registration.Enabled = True

            dr.Close()
            con.Close()
            cmd.Dispose()
        Else
            cmd.Dispose()

            connection()
            cmd.Connection = con

            cmd.CommandText = "Select * From tbl_Stud_Fee_Master where Student_ID = " + tb_Student_id_Registration.Text + ""
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                tb_Hostel_Fees_Registration.Text = dr("Hostel_Fee").ToString

            Else

                MessageBox.Show("Invalid Student ID!!!")
            End If
            btn_Search_Student_id_Registration.Enabled = False
            cb_Hostel_Number_Registration.Focus()
            cb_Hostel_Number_Registration.Enabled = True
            btn_Reset_Registration.Enabled = True
            btn_Delete_Registration.Enabled = False
            btn_Confirm_Registration.Enabled = True
            dr.Close()
            con.Close()
            cmd.Dispose()
        End If
        dr.Close()
        dr.Close()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub btn_Confirm_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirm_Registration.Click
        connection()
        If tb_Hostel_Fees_Registration.Text <> "" Then
            cmd = New SqlCommand("insert into Htbl_Hostel_Student_Master values (" + tb_Student_id_Registration.Text + "," + tb_Hostel_Fees_Registration.Text + ",'" + cb_Hostel_Number_Registration.Text + "'," + cb_Room_Number_Registration.Text + " )", con)
            If (cmd.ExecuteNonQuery) Then
                MessageBox.Show("Student Registred Successfully in the Hostel")
            End If
            tb_Student_id_Registration.Focus()

            cb_Hostel_Number_Registration.Enabled = False
            cb_Room_Number_Registration.Enabled = False
            cb_Room_Number_Registration.Enabled = False

            common_class.clear_tb(Panel_student_Reg)
            common_class.clear_cb(Panel_student_Reg)
        End If
       

    End Sub

    Private Sub btn_Delete_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Registration.Click
        Try
            If cb_Hostel_Number_Registration.Text <> "" And cb_Room_Number_Registration.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "select * from Htbl_Hostel_Student_Master where Student_ID ='" + tb_Student_id_Registration.Text + "' "
                cmd.ExecuteNonQuery()

                If (cmd.ExecuteNonQuery) Then
                    cmd.Dispose()

                    cmd.CommandText = "Delete from Htbl_Hostel_Student_Master where Student_ID = '" + tb_Student_id_Registration.Text + "' "
                    cmd.ExecuteNonQuery()

                End If
                MessageBox.Show("Student Deleted Succesfully From Hostel!!!")
            Else
                MessageBox.Show("Please Fill Correct Information!!")
            End If
            tb_Student_id_Registration.Focus()

            tb_Hostel_Fees_Registration.Enabled = False
            cb_Hostel_Number_Registration.Enabled = False
            cb_Room_Number_Registration.Enabled = False
            cb_Room_Number_Registration.Enabled = False

             common_class.clear_tb(Panel_student_Reg)
            common_class.clear_cb(Panel_student_Reg)

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Student_id_Registration.Focus()

    End Sub

    Private Sub btn_add_Hostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_Hostel.Click
        Panel_Add_Hostel.Controls.Clear()
        Dim dr As SqlDataReader
        Dim x As Integer = 25
        Dim y As Integer = 39
        cmd.Dispose()
        connection()

        cmd = New SqlCommand("select distinct Hostel_No from Htbl_Room_Master", con)
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim obj = New uc_Hostel
            obj.btn_add_Hostel.Text = dr("Hostel_No")
            Panel_Add_Hostel.Controls.Add(obj)
            obj.Location = New System.Drawing.Point(x, y)
            x = x + 300
        End While
        Dim ob = New uc_Hostel
        Dim h_name As String = ""
        h_name = InputBox("Enter Name of hostel")
        ob.btn_add_Hostel.Text = h_name
        If (h_name = "") Then
            dr.Close()
            Exit Sub

        End If
        Panel_Add_Hostel.Controls.Add(ob)
        ob.Location = New System.Drawing.Point(x, y)
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btn_Delete_Hostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Hostel.Click
      

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dlt_h.Click
        Panel_Delete_Hostel_Room.Controls.Clear()
        Dim nm As String
        Dim ob = New uc_Delete_Hostel
        Try
            If btn_Delete_Hostel.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "select * from Htbl_Room_Master where Hostel_No ='" + btn_Delete_Hostel.Text + "' "

                nm = cmd.ExecuteScalar
                If (nm <> "") Then
                    cmd.Dispose()
                    cmd.CommandText = "Delete from Htbl_Room_Master where Hostel_No = '" + btn_Delete_Hostel.Text + "' "
                    cmd.ExecuteNonQuery()
                Else
                    MessageBox.Show("Hostel is not Available !!")
                    lbl2.Text = "First Select The Hostel.."
                End If
                MessageBox.Show("Hostel Deleted Succesfully !!!")
            Else

            End If
            cmd.Dispose()
            con.Close()

            Panel_Delete_Room.Controls.Clear()
            Dim dr As SqlDataReader
            Dim x As Integer = 25
            Dim y As Integer = 39
            cmd.Dispose()
            connection()

            cmd = New SqlCommand("select distinct Hostel_No from Htbl_Room_Master", con)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim obj = New uc_Delete_Hostel
                obj.btn_delete_Hostel.Text = dr("Hostel_No")
                Panel_Delete_Room.Controls.Add(obj)
                obj.Location = New System.Drawing.Point(x, y)
                x = x + 350
            End While

            dr.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cb_Hostel_Number_Registration_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Hostel_Number_Registration.SelectedIndexChanged
        cb_Room_Number_Registration.Enabled = True
    End Sub

    Private Sub cb_Hostel_Number_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Hostel_Number_Registration.Click
        cb_Hostel_Number_Registration.SelectedIndex = -1
        connection()
        Dim cmd As New SqlCommand("select distinct(Hostel_No) from Htbl_Room_Master", con)
        Dim adapter1 As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter1.Fill(table)
        cb_Hostel_Number_Registration.DataSource = table
        cb_Hostel_Number_Registration.DisplayMember = "Hostel_No"

        adapter1.Dispose()
        cmd.Dispose()
    End Sub

    Private Sub cb_Room_Number_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Room_Number_Registration.Click
        connection()
        Dim cmd As New SqlCommand("select distinct(Room_No) from Htbl_Room_Master where Hostel_No = '" + cb_Hostel_Number_Registration.Text + "' ", con)
        Dim adapter1 As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter1.Fill(table)
        cb_Room_Number_Registration.DataSource = table
        cb_Room_Number_Registration.DisplayMember = "Room_No"

        adapter1.Dispose()
        cmd.Dispose()
    End Sub

    Private Sub btn_Reset_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset_Registration.Click
        tb_Student_id_Registration.Focus()
        btn_Search_Student_id_Registration.Enabled = False

        cb_Hostel_Number_Registration.Enabled = False
        cb_Room_Number_Registration.Enabled = False
        cb_Room_Number_Registration.Enabled = False

         common_class.clear_tb(Panel_student_Reg)
        common_class.clear_cb(Panel_student_Reg)

        btn_Delete_Registration.Enabled = False
        btn_Confirm_Registration.Enabled = False
    End Sub

    Private Sub cb_Student_id__Student_info_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_Student_id__Student_info.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Username_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Username.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Current_Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Current_Password.Leave
        If Pass_len(tb_Current_Password.TextLength) = 0 Then
            tb_Current_Password.Focus()
        End If
    End Sub

    Private Sub tb_New_Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_New_Password.Leave
        If Pass_len(tb_New_Password.TextLength) = 0 Then
            tb_New_Password.Focus()
        End If
    End Sub
End Class