Imports System.Data.SqlClient

Public Class frm_Main_Menu
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Dim sum As Integer = 0

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub frm_Main_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If common_class.gbl_var = 1 Then
            btn_Hostel.Visible = False
            btn_Store_Room.Visible = False
            common_class.gbl_var = 0
        End If

        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Student_ID) from tbl_Stud_Master"

            Cnt = cmd.ExecuteScalar()


            lbl_NO_STUDENT.Text = Cnt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmd.Dispose()
        Try
            Dim Cnt As Integer

            cmd.Connection = con
            cmd.CommandText = "select Count(Staff_ID) from tbl_Employee_Master"

            Cnt = cmd.ExecuteScalar()

            lbl_No_Staff.Text = Cnt

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        Try
            connection()
            Dim Cnt1 As Integer
            cmd = New SqlCommand("select distinct count (Hostel_No) from Htbl_Room_Master", con)

            Cnt1 = cmd.ExecuteScalar()

            lbl_no_hostels.Text = Cnt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        Try
            connection()
            Dim Cnt1 As Integer
            cmd = New SqlCommand("select count (Room_No) from Htbl_Room_Master", con)

            Cnt1 = cmd.ExecuteScalar()

            lbl_no_Room.Text = Cnt1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        ''Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home_Main_Menu.Click
        TabControl1.SelectedIndex = 0
        lbl.Text = "Digital School Managment System"

    End Sub

    Private Sub btn_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student.Click
        common_class.menu_hide_open(Panel_Student)
        lbl.Text = "      Student "
        If Panel_User_Control.Visible = True Then
            Panel_User_Control.Visible = False

        End If
        If panel_Staff.Visible = True Then
            panel_Staff.Visible = False

        End If
        If Panel_Fee_Structure.Visible = True Then
            Panel_Fee_Structure.Visible = False
        End If

        TabControl1.SelectedIndex = 1
        TabControl2.SelectedIndex = 5
    End Sub

    Private Sub btn_Staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Staff.Click
        common_class.menu_hide_open(panel_Staff)
        lbl.Text = "             Staff"
        If Panel_User_Control.Visible = True Then
            Panel_User_Control.Visible = False
        End If
        If Panel_Student.Visible = True Then
            Panel_Student.Visible = False
        End If
        If Panel_Fee_Structure.Visible = True Then
            Panel_Fee_Structure.Visible = False
        End If

        TabControl1.SelectedIndex = 2
        TabControl3.SelectedIndex = 0
    End Sub

    Private Sub btn_User_Control_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User_Control.Click
        common_class.menu_hide_open(Panel_User_Control)
        lbl.Text = "     User Control"
        If Panel_Student.Visible = True Then
            Panel_Student.Visible = False
        End If
        If panel_Staff.Visible = True Then
            panel_Staff.Visible = False
        End If
        If Panel_Fee_Structure.Visible = True Then
            Panel_Fee_Structure.Visible = False
        End If

        TabControl1.SelectedIndex = 4
        TabControl10.SelectedIndex = 3
    End Sub

    Private Sub btn_Hostel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hostel.Click
        frm_Hostel_MDI.Show()
    End Sub

    Private Sub btn_Store_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Store_Room.Click
        frm_Store_Room_MDI.Show()
    End Sub

    Private Sub btn_Expenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Expenses.Click
        TabControl1.SelectedIndex = 3
        lbl.Text = "        Reports"

        Dim x As Integer = 0
        Dim y As Integer = 0
        panal_Crystal_Report.Controls.Clear()
        Dim obj = New uc_Reports

        panal_Crystal_Report.Controls.Add(obj)
        obj.Location = New System.Drawing.Point(x, y)
    End Sub

    Private Sub btn_Exit_DSMS_Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Fee_Stucture.Click
        lbl.Text = "      Fee Stucture"
        common_class.menu_hide_open(Panel_Fee_Structure)

        If Panel_Student.Visible = True Then
            Panel_Student.Visible = False
        End If
        If panel_Staff.Visible = True Then
            panel_Staff.Visible = False
        End If
        If Panel_User_Control.Visible = True Then
            Panel_User_Control.Visible = False
        End If
        TabControl1.SelectedIndex = 5
        TabControl_Fee_Stucture.SelectedIndex = 0
    End Sub

    Private Sub btn_Add_New_Fees_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Fees_Main_Menu.Click
        lbl.Text = "Add New Fees"
        TabControl_Fee_Stucture.SelectedIndex = 1


        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Fee_ID) from tbl_Fee_Master "

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 101
            Else
                Cnt = Cnt + 101
            End If
            tb_Fees_id_Add_Fee.Text = Cnt
            tb_Standard_Add_Fee.Focus()

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_Update_Fees_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Fees_Main_Menu.Click
        lbl.Text = "   Update Fees"
        TabControl_Fee_Stucture.SelectedIndex = 2
        tb_Fees_id_Update_Fee.Focus()
        tb_Fees_id_Update_Fee.Enabled = True
    End Sub

    Private Sub btn_View_Fee_Stucture_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_Fee_Stucture_Main_Menu.Click
        lbl.Text = "  View Fees Details"
        TabControl_Fee_Stucture.SelectedIndex = 3
        Try
            connection()
            cmd = New SqlCommand("select *from tbl_Fee_Master ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_View_Fees.DataSource = ""
            Grid_View_Fees.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        
    End Sub

    Private Sub btn_Add_New_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Student.Click
        TabControl2.SelectedIndex = 0
        lbl.Text = "    Add New Student"
        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Student_ID) from tbl_Stud_Master"

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 101
            Else
                Cnt = Cnt + 101
            End If
            tb_Stud_id.Text = Cnt
            tb_First_Name.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub btn_Update_Student_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Student_Main_Menu.Click
        TabControl2.SelectedIndex = 2
        lbl.Text = "Update Student Information"
    End Sub

    Private Sub btn_Single_Student_Info_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Single_Student_Info_Main_Menu.Click
        TabControl2.SelectedIndex = 3
        tb_Student_Search_Info.Focus()
        lbl.Text = "Single Student Information"
        Try
            connection()
            cmd = New SqlCommand("select *from tbl_stud_Master ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_Single_Stud_info.DataSource = ""
            Grid_Single_Stud_info.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        cb_Search_Stud_by_Studinfo.Focus()
        cb_Search_Stud_by_Studinfo.SelectedIndex = -1
        tb_Student_Search_Info.Text = ""
        btn_Student_Search_Info.Enabled = True
        btn_Refresh_grid_Single_Stufd_info.Enabled = True

    End Sub

    Private Sub btn_All_Student_Info_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_All_Student_Info_Main_Menu.Click
        TabControl2.SelectedIndex = 4
        lbl.Text = "All Student Information"
        Try
            connection()
            cmd = New SqlCommand("select *from tbl_stud_Master ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_All_Student_info.DataSource = ""
            Grid_All_Student_info.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btn_Add_New_Staff_Main_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Staff_Main_menu.Click
        TabControl3.SelectedIndex = 1
        tb_Staff_First_Name.Focus()
        lbl.Text = "   Add New Staff "
        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Staff_ID) from tbl_Employee_Master"

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 101
            Else
                Cnt = Cnt + 101
            End If
            tb_Staff_id.Text = Cnt
            tb_Staff_First_Name.Focus()

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_Update_Staff_main_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Staff_main_menu.Click
        TabControl10.SelectedIndex = 1
        TabControl3.SelectedIndex = 2
        tb_Staff_id_Update.Focus()
        lbl.Text = "Update Staff Informations"
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_View_Staff_Main_Menu.Click
        TabControl3.SelectedIndex = 3
        lbl.Text = "View & Search Staff Details"
        Try
            connection()
            cmd = New SqlCommand("select *from tbl_Employee_Master ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_All_Student_info.DataSource = ""
            Grid_All_Student_info.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btn_Add_New_User_Main_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_User_Main_Menu.Click
        TabControl10.SelectedIndex = 0
        lbl.Text = "  Add New User"
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        TabControl10.SelectedIndex = 1
        lbl.Text = "   Change User Password"
    End Sub

    Private Sub btn_Delete_User_Control_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_User_Control.Click
        lbl.Text = "      Delete User"
        TabControl10.SelectedIndex = 2
        tb_User_Category_Add_New_User.Focus()

    End Sub

    Private Sub btn_Exit_DSMS_Home_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit_DSMS_Home.Click
        Me.Hide()
        frm_Login.Show()
    End Sub

    Private Sub btn_Save_Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Proceed.Click
        If tb_Stud_id.Text <> "" And tb_First_Name.Text <> "" And tb_Middle_Name.Text <> "" And tb_Last_Name.Text <> "" And tb_Religion.Text <> "" And tb_Gender.Text <> "" And tb_Standard.Text <> "" And tb_Address.Text <> "" And tb_City.Text <> "" And tb_pincode.Text <> "" And cb_Medium.Text <> "" And tb_Father_Name.Text <> "" And tb_Mother_Name.Text <> "" And tb_Mob_no.Text <> "" And tb_Father_Profession.Text <> "" And tb_Mother_Profession.Text <> "" And tb_EmailID.Text <> "" Then
            Try
                If tb_Standard.Text <> "" Then
                    Dim dr As SqlDataReader
                    connection()
                    cmd.Connection = con

                    cmd.CommandText = "Select * From tbl_Fee_Master where Standard = '" + tb_Standard.Text + "'and Medium = '" + cb_Medium.Text + "'"
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then
                        tb_Tution_Fee.Text = dr("Tution_Fee").ToString
                        tb_Hostel_Fees.Text = dr("Hostel_Fee").ToString
                        tb_Store_Room_Fee.Text = dr("StoreRoom_Fee").ToString

                        sum = sum + Val(tb_Tution_Fee.Text)
                        sum = sum + Val(tb_Hostel_Fees.Text)
                        sum = sum + Val(tb_Store_Room_Fee.Text)
                        tb_Total_Fee.Text = sum

                        sum = 0

                        btn_Save_Update_Fees.Enabled = True
                        btn_Refresh_Update_Fees.Enabled = True
                        TabControl2.SelectedIndex = 1
                        dr.Close()
                    Else
                        MessageBox.Show("Please Fill First Fees Amount of given Standard and Medium ")
                        dr.Close()
                    End If
                    tb_Tution_Fees_Update_Fee.Enabled = True
                    tb_Hostel_Fees_Update_Fee.Enabled = True
                    tb_StoreRoom_Fees_Update_Fee.Enabled = True
                    btn_Save_Update_Fees.Enabled = True
                    btn_Refresh_Update_Fees.Enabled = True
                    tb_Fees_id_Update_Fee.Enabled = False


                    dr.Close()
                    con.Close()
                    cmd.Dispose()

                End If
            Catch ex As Exception

                con.Close()
                cmd.Dispose()
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("First fill all the fields...")
        End If
    End Sub

    Private Sub btn_Confirm_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

      
    End Sub

    Private Sub btn_reset_Ass_Stud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset_Ass_Stud.Click

        common_class.clear_tb(Panel6)
        common_class.clear_tb(Panel8)
        
    End Sub

    Private Sub tb_Middle_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Middle_Name.TextChanged
        If tb_Middle_Name.Text <> "" Then
            tb_Father_Name.Text = tb_Middle_Name.Text.ToString
        End If
    End Sub

    Private Sub btn_Confirm_Payment_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Confirm_Payment.Click
        If tb_Tution_Fee.Text <> "" And tb_Hostel_Fees.Text <> "" And tb_Store_Room_Fee.Text <> "" And tb_Total_Fee.Text <> "" Then
            connection()
            Dim i As Integer
            cmd.Connection = con
            cmd.CommandText = "Insert Into tbl_Stud_Master Values (" + tb_Stud_id.Text + ",'" + tb_First_Name.Text + "','" + tb_Middle_Name.Text + "','" + tb_Last_Name.Text + "','" + tb_Religion.Text + "','" + tb_Gender.Text + "'," + tb_Standard.Text + ",'" + tb_Address.Text + "','" + tb_City.Text + "'," + tb_pincode.Text + ",'" + dtp_DOB.Text + "','" + cb_Medium.Text + "','" + tb_Father_Name.Text + "','" + tb_Mother_Name.Text + "'," + tb_Mob_no.Text + ",'" + tb_Father_Profession.Text + "','" + tb_Mother_Profession.Text + "','" + tb_EmailID.Text + "','" + Date_Addmission.Text + "')"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd.CommandText = "Insert Into tbl_Stud_Fee_Master Values (" + tb_Stud_id.Text + "," + tb_Tution_Fee.Text + "," + tb_Hostel_Fees.Text + "," + tb_Store_Room_Fee.Text + "," + tb_Total_Fee.Text + ",'" + Date_Addmission.Text + "')"
            i = cmd.ExecuteNonQuery()

            If (i > 0) Then
                MessageBox.Show("Student Added Successfully !!!")

                common_class.clear_tb(Panel6)
                common_class.clear_tb(Panel8)
                common_class.clear_tb(Panel10)

                TabControl2.SelectedIndex = 0
                Try
                    Dim Cnt As Integer
                    connection()

                    cmd.Connection = con
                    cmd.CommandText = "select Count(Student_ID) from tbl_Stud_Master"

                    Cnt = cmd.ExecuteScalar()

                    If Cnt = 0 Then
                        Cnt = 101
                    Else
                        Cnt = Cnt + 101
                    End If
                    tb_Stud_id.Text = Cnt
                    tb_First_Name.Focus()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                con.Close()
                cmd.Dispose()
                con.Close()
            Else
                MessageBox.Show("System Error...")
            End If
            
        End If
        con.Close()
        cmd.Dispose()
        Try

            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Student_ID) from tbl_Stud_Master"

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 101
            Else
                Cnt = Cnt + 101
            End If
            tb_Staff_id.Text = Cnt
            tb_Staff_First_Name.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_Cancle_Payment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancle_Payment.Click
        common_class.clear_tb(Panel10)
        TabControl2.SelectedIndex = 0
    End Sub

    Private Sub tb_Stud_id_Update_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Stud_id_Update.TextChanged
        btn_Search_Student.Enabled = True
    End Sub

    Private Sub btn_Search_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Student.Click
        Try
            Dim dr As SqlDataReader
            connection()
            cmd.Connection = con

            cmd.CommandText = "Select * From tbl_Stud_Master where Student_ID = " + tb_Stud_id_Update.Text + ""
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                tb_First_Name_Update.Text = dr("First_Name").ToString
                tb_Middle_Name_Update.Text = dr("Middle_Name").ToString
                tb_Last_Name_Update.Text = dr("Last_Name").ToString
                tb_Religion_Update.Text = dr("Religion").ToString
                tb_Gender_Update.Text = dr("Gender").ToString
                tb_Standard_Update.Text = dr("Standard").ToString
                tb_Address__Update.Text = dr("Address").ToString
                tb_City_Update.Text = dr("City").ToString
                tb_Pin_Code_Update.Text = dr("Pincode").ToString
                DTP_Stud_Update.Text = dr("DOB").ToString
                cb_Medium_Update.Text = dr("Medium").ToString
                tb_Father_name_Update.Text = dr("Father_Name").ToString
                tb_Mother_Name_Update.Text = dr("Mother_Name").ToString
                tb_Mobile_Number_Update.Text = dr("Mobile_No").ToString
                tb_Father_Profession_Update.Text = dr("Father_Profession").ToString
                tb_Mother_Profession_Update.Text = dr("Mother_Profession").ToString
                tb_Email_id_Update.Text = dr("Email_id").ToString

            Else
                MessageBox.Show("Invalid Student ID!!!")
                tb_Stud_id_Update.Text = ""
                tb_First_Name_Update.Focus()
            End If

            dr.Close()
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Save_Change_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Change_Update.Click
        Try
            If tb_Stud_id_Update.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "Update tbl_Stud_Master set First_Name= '" + tb_First_Name_Update.Text + "',Middle_Name ='" + tb_Middle_Name_Update.Text + "',Last_Name = '" + tb_Last_Name_Update.Text + "',Religion ='" + tb_Religion_Update.Text + "',Gender ='" + tb_Gender_Update.Text + "',Standard = " + tb_Standard_Update.Text + ",Address = '" + tb_Address__Update.Text + "',City = '" + tb_City_Update.Text + "',Pincode = " + tb_Pin_Code_Update.Text + ",DOB = '" + DTP_Stud_Update.Text + "',Medium = '" + cb_Medium_Update.Text + "',Father_Name = '" + tb_Father_name_Update.Text + "',Mother_Name = '" + tb_Mother_Name_Update.Text + "',Mobile_No = " + tb_Mobile_Number_Update.Text + ",Father_Profession = '" + tb_Father_Profession_Update.Text + "',Mother_Profession = '" + tb_Mother_Profession_Update.Text + "',Email_id = '" + tb_Email_id_Update.Text + "' where Student_ID = " & tb_Stud_id_Update.Text & ""
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student Updated Succesfully!!!")
            Else
                MessageBox.Show("Enter Details for Update Student Information!!!")
            End If
            btn_Search_Student.Enabled = False
            btn_Save_Change_Update.Enabled = False
            tb_Stud_id_Update.Focus

            common_class.clear_tb(Panel13)
            common_class.clear_tb(Panel14)

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Stud_id_Update.Focus()
    End Sub

    Private Sub btn_Reset_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset_Update.Click
        tb_Stud_id_Update.Focus()
        btn_Search_Student.Enabled = False
        btn_Save_Change_Update.Enabled = False

        common_class.clear_tb(Panel13)
        common_class.clear_tb(Panel14)

    End Sub

    Private Sub btn_Remove_updatee_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_updatee_Student.Click
        Try
            If tb_Stud_id_Update.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "Select * From tbl_Stud_Master where Student_ID = " + tb_Stud_id_Update.Text + ""
                cmd.ExecuteNonQuery()

                If (cmd.ExecuteNonQuery) Then
                    cmd.Dispose()
                    Dim cmd1 As New SqlCommand
                    cmd1 = New SqlCommand("Delete from tbl_Stud_Fee_Master where Student_ID = '" + tb_Stud_id_Update.Text + "' ", con)
                    cmd1.ExecuteNonQuery()

                    Dim cmd2 As New SqlCommand
                    cmd2 = New SqlCommand("Delete from stbl_Student_Purchase_Details where Student_ID = '" + tb_Stud_id_Update.Text + "' ", con)
                    cmd2.ExecuteNonQuery()



                    cmd.CommandText = "Delete from tbl_Stud_Master where Student_ID = '" + tb_Stud_id_Update.Text + "' "
                    cmd.ExecuteNonQuery()

                    
                    'Dim cmd3 As New SqlCommand
                    'cmd3.CommandText = "Update stbl_Product_Purchase_Details set Student_ID= '" + tb_First_Name_Update.Text + "' where Student_ID = " + tb_Stud_id_Update.Text + "' "
                    'cmd3.ExecuteNonQuery()

                    cmd1.Dispose()
                    cmd2.Dispose()
                End If
                MessageBox.Show("Student Deleted Succesfully !!!")
            Else
                MessageBox.Show("Please Fill Correct Information!!")
            End If
            common_class.clear_tb(Panel13)
            common_class.clear_tb(Panel14)
            cb_Medium_Update.Text = ""

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tb_Student_Search_Info_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Student_Search_Info.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Lf AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_Student_Search_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student_Search_Info.Click
        Try
            cmd.Connection = con
            connection()
            If cb_Search_Stud_by_Studinfo.Text = "Student ID" Then
                cmd = New SqlCommand("select *from tbl_stud_Master where Student_ID like '%" & tb_Student_Search_Info.Text & "%'", con)
            ElseIf cb_Search_Stud_by_Studinfo.Text = "First Name" Then
                cmd = New SqlCommand("select *from tbl_stud_Master where First_Name like '%" & tb_Student_Search_Info.Text & "%'", con)
            End If
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_Single_Stud_info.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Refresh_grid_Single_Stufd_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh_grid_Single_Stufd_info.Click
        Try
            connection()
            cmd = New SqlCommand("select *from tbl_stud_Master ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_Single_Stud_info.DataSource = ""
            Grid_Single_Stud_info.DataSource = dt
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        cb_Search_Stud_by_Studinfo.Focus()
        cb_Search_Stud_by_Studinfo.SelectedIndex = -1
        tb_Student_Search_Info.Text = ""
        btn_Student_Search_Info.Enabled = True
        btn_Refresh_grid_Single_Stufd_info.Enabled = True
    End Sub

    Private Sub tb_Student_id_Search_Info_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btn_Student_Search_Info.Enabled = True
        Grid_Single_Stud_info.Enabled = True

    End Sub

    Private Sub btn_Save_Add_Staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Add_Staff.Click
        If tb_Staff_First_Name.Text <> "" And tb_Staff_Middle_Name.Text <> "" And tb_staff_last_Name.Text <> "" And tb_Staff_Religion.Text <> "" And cb_staff_gender.Text <> "" And tb_Staff_Mob_Number.Text <> "" And tb_Staff_City.Text <> "" And tb_Staff_Pin_Code.Text <> "" And tb_Staff_Adhar_No.Text <> "" And tb_Staff_Qualification.Text <> "" And tb_Staff_Salary.Text And cb_staff_Position.Text <> "" Then
            connection()

            Dim jdate As Date = (DTP_Staff_joining_Date.Text).ToString
            Dim bdate As Date = (DTP_Staff_Birth_date.Text).ToString

            cmd = New SqlCommand("Insert Into tbl_Employee_Master Values (" & tb_Staff_id.Text & ",'" & tb_Staff_First_Name.Text & "','" & tb_Staff_Middle_Name.Text & "','" & tb_staff_last_Name.Text & "','" & tb_Staff_Religion.Text & "','" & cb_staff_gender.Text & "','" & bdate & "'," & tb_Staff_Mob_Number.Text & ",'" & tb_Staff_City.Text & "'," & tb_Staff_Pin_Code.Text & "," & tb_Staff_Adhar_No.Text & ",'" & tb_Staff_Qualification.Text & "','" & jdate & "'," & tb_Staff_Salary.Text & ",'" & cb_staff_Position.Text & "')", con)
            
            cmd.ExecuteNonQuery()

        Else
            MessageBox.Show("Please Fill the all Fields..!")
        End If
        MessageBox.Show("New Staff Memmber Added Successfully..!")

        common_class.clear_tb(Panel32)

        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub btn_Staff_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Staff_Search.Click
        Try
            Dim dr As SqlDataReader
            connection()
            cmd.Connection = con

            cmd.CommandText = "Select * From tbl_Employee_Master where Staff_ID = " + tb_Staff_id_Update.Text + ""
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                tb_Staff_Update_First_Name.Text = dr("First_Name").ToString
                tb_Staff_Update_Middle_Name.Text = dr("Middle_Name").ToString
                tb_Staff_update_last_name.Text = dr("Last_Name").ToString
                tb_Staff_Update_Religion.Text = dr("Religion").ToString
                cb_staff_update_gender.Text = dr("Gender").ToString
                tb_Staff_Update_Mobile_no.Text = dr("Mobile_Number").ToString
                dtp_Staff_Update_Birthdate.Text = dr("Birth_date").ToString
                tb_Staff_Update_City.Text = dr("City").ToString
                tb_Staff_Update_Pincode.Text = dr("Pin_code").ToString
                tb_Staff_Update__Adhar_No.Text = dr("Adhar_Number").ToString
                tb_Staff_Update_Qualification.Text = dr("Qualification").ToString
                tb_Staff_Update_Sallary.Text = dr("Sallary").ToString
                cb_Staff_Update_Appoint_Position.Text = dr("Appoint_Position").ToString


            Else
                MessageBox.Show("Invalid Staff ID!!!")
                tb_Staff_id_Update.Text = ""
                tb_Staff_Update_First_Name.Focus()
            End If

            dr.Close()
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Staff_Update_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Staff_Update_Save.Click
        Try
            If tb_Staff_id_Update.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "Update tbl_Employee_Master set First_Name = '" + tb_Staff_Update_First_Name.Text + "',Middle_Name ='" + tb_Staff_Update_Middle_Name.Text + "',Last_Name = '" + tb_Staff_update_last_name.Text + "',Religion ='" + tb_Staff_Update_Religion.Text + "',Gender ='" + cb_staff_update_gender.Text + "',Birth_date = '" + dtp_Staff_Update_Birthdate.Text + "',Mobile_Number = " + tb_Staff_Update_Mobile_no.Text + ",City = '" + tb_Staff_Update_City.Text + "',Pin_Code = " + tb_Staff_Update_Pincode.Text + ",Adhar_Number = " + tb_Staff_Update__Adhar_No.Text + ",Qualification = '" + tb_Staff_Update_Qualification.Text + "',Sallary = " + tb_Staff_Update_Sallary.Text + ",Appoint_Position = '" + cb_Staff_Update_Appoint_Position.Text + "' where Staff_ID = " & tb_Staff_id_Update.Text & " "
                cmd.ExecuteNonQuery()

                MessageBox.Show("Student Updated Succesfully!!!")
            Else
                MessageBox.Show("Enter Details for Update Student Information!!!")
            End If
            btn_Staff_Search.Enabled = False
            btn_Staff_Update_Save.Enabled = False

            common_class.clear_tb(Panel47)
            common_class.clear_cb(Panel47)

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Stud_id_Update.Focus()
    End Sub

    Private Sub btn_Remove_Staff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove_Staff.Click
        Try
            If tb_Staff_id_Update.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "delete tbl_Employee_Master where Staff_ID = '" + tb_Staff_id_Update.Text + "' "
                Dim i As Integer = cmd.ExecuteNonQuery()

                If (i > 0) Then

                    MessageBox.Show("Student Deleted Succesfully!!!")
                End If
            Else
                MessageBox.Show("Enter Details for Update Student Information!!!")
            End If
            btn_Staff_Search.Enabled = False
            btn_Staff_Update_Save.Enabled = False

            common_class.clear_tb(Panel47)
            common_class.clear_cb(Panel47)

            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Stud_id_Update.Focus()
    End Sub

    Private Sub btn_Search_Staff_Deatil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Staff_Deatil.Click
        Try
            cmd.Connection = con
            connection()
            If cb_Employee_Srch_By.Text = "Staff ID" Then
                cmd = New SqlCommand("select *from tbl_Employee_Master where Staff_ID like '%" & Staff_id_Search_Staff.Text & "%'", con)
            ElseIf cb_Employee_Srch_By.Text = "First Name" Then
                cmd = New SqlCommand("select *from tbl_Employee_Master where First_Name like '%" & Staff_id_Search_Staff.Text & "%'", con)
            End If
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_View_Staff_detail.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btn_Save_Add_New_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Add_New_User.Click

        If tb_User_Category_Add_New_User.Text <> "" And tb_Username_Add_New_User.Text <> "" And tb_Password_New_Add_New_User.Text <> "" And tb_Password_Confirm_Add_New_User.Text <> "" And tb_Password_New_Add_New_User.Text = tb_Password_Confirm_Add_New_User.Text Then
            btn_Save_Add_New_User.Enabled = True
            If tb_Password_New_Add_New_User.Text = tb_Password_Confirm_Add_New_User.Text Then

                connection()
                cmd.Connection = con
                cmd.CommandText = "Insert Into tb_login Values ('" + tb_User_Category_Add_New_User.Text + "','" + tb_Username_Add_New_User.Text + "','" + tb_Password_Confirm_Add_New_User.Text + "' )"

                cmd.ExecuteNonQuery()

                MessageBox.Show("New User Added Successfully !!!")
            Else
                MessageBox.Show("Please Enter same Passwords  !!!")
            End If
            btn_Save_Add_New_User.Enabled = False

            common_class.clear_tb(Panel_Add_New_User)
            common_class.clear_cb(Panel_Add_New_User)

            con.Close()
            cmd.Dispose()
        Else
            MessageBox.Show("Fill the All fields !!!")
        End If
        
    End Sub


    Private Sub tb_New_Password_Change_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_New_Password_Change_Password.TextChanged
        btn_Save_Change_Password.Enabled = True
    End Sub

    Private Sub tb_Current_Password_Change_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Current_Password_Change_Password.TextChanged
        tb_New_Password_Change_Password.Enabled = True
    End Sub

    Private Sub btn_Save_Change_Password_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Change_Password.Click
        Try
            If tb_Username__Change_Password.Text <> "" And tb_Current_Password_Change_Password.Text <> "" And tb_New_Password_Change_Password.Text <> "" And tb_Current_Password_Change_Password.Text.ToString = tb_New_Password_Change_Password.Text.ToString Then
                connection()
                cmd.Connection = con


                cmd.CommandText = "Update tb_login set Password = '" + tb_New_Password_Change_Password.Text + "' where User_Name = '" & tb_Username__Change_Password.Text & "'"
                cmd.ExecuteNonQuery()

                MessageBox.Show("Password Updated Succesfully!!!")
            Else
                MessageBox.Show("Please Fill Correct Information!!")
            End If
            tb_Username__Change_Password.Focus()

            btn_Save_Change_Password.Enabled = False
            tb_New_Password_Change_Password.Enabled = False
            tb_Current_Password_Change_Password.Enabled = False

            common_class.clear_tb(Panel_Change_Pass)
            common_class.clear_cb(Panel_Change_Pass)

            con.Close()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tb_Username__Change_Password_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Username__Change_Password.TextChanged
        tb_Current_Password_Change_Password.Enabled = True
    End Sub

    Private Sub tb_User_Category_Delete_User_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_User_Category_Delete_User.TextChanged
        tb_Username_Delete_User.Enabled = True
    End Sub

    Private Sub tb_Username_Delete_User_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Username_Delete_User.TextChanged
        tb_Password__Delete_User.Enabled = True
    End Sub

    Private Sub tb_Password__Delete_User_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Password__Delete_User.TextChanged
        btn_Save_Delete_User.Enabled = True
    End Sub

    Private Sub btn_Save_Delete_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Delete_User.Click
        Try
            If tb_User_Category_Delete_User.Text <> "" And tb_Username_Delete_User.Text <> "" And tb_Password__Delete_User.Text <> "" Then
                connection()
                cmd.Connection = con

                cmd.CommandText = "select * from tb_login where User_Category ='" + tb_User_Category_Delete_User.Text + "'and User_Name = '" + tb_Username_Delete_User.Text + "' and Password = '" + tb_Password__Delete_User.Text + "'"
                cmd.ExecuteNonQuery()

                If (cmd.ExecuteNonQuery) Then
                    cmd.Dispose()
                    cmd.CommandText = "Delete from tb_login where User_Name = '" + tb_Username_Delete_User.Text + "' "
                    cmd.ExecuteNonQuery()
                End If
                MessageBox.Show("User Deleted Succesfully !!!")
            Else
                MessageBox.Show("Please Fill Correct Information!!")
            End If
            tb_User_Category_Delete_User.Focus()

            tb_Username_Delete_User.Enabled = False
            btn_Save_Delete_User.Enabled = False
            tb_Password__Delete_User.Enabled = False

            common_class.clear_tb(Panel_Delete)
            common_class.clear_cb(Panel_Delete)

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_User_Category_Delete_User.Focus()
    End Sub

    Private Sub tb_Standard_Add_Fee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Standard_Add_Fee.SelectedIndexChanged
        tb_Medium_Add_Fee.Enabled = True
    End Sub

    Private Sub tb_Medium_Add_Fee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Medium_Add_Fee.SelectedIndexChanged
        tb_Tution_Fees_Add_Fee.Enabled = True
        tb_Hostel_Fees_Add_Fee.Enabled = True
        tb_Store_Room_Fees_Add_Fee.Enabled = True
        btn_Save_Add_Fees.Enabled = True
        btn_Refresh_Add_Fees.Enabled = True
    End Sub

    Private Sub btn_Save_Add_Fees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Add_Fees.Click

        If tb_Fees_id_Add_Fee.Text <> "" And tb_Standard_Add_Fee.Text <> "" And tb_Medium_Add_Fee.Text <> "" And tb_Tution_Fees_Add_Fee.Text <> "" And tb_Hostel_Fees_Add_Fee.Text <> "" And tb_Store_Room_Fees_Add_Fee.Text Then

            connection()
            cmd.Connection = con
            cmd.CommandText = "Insert Into tbl_Fee_Master Values ('" + tb_Fees_id_Add_Fee.Text + "','" + tb_Standard_Add_Fee.Text + "','" + tb_Medium_Add_Fee.Text + "' ,'" + tb_Tution_Fees_Add_Fee.Text + "' ,'" + tb_Hostel_Fees_Add_Fee.Text + "' ,'" + tb_Store_Room_Fees_Add_Fee.Text + "' )"

            cmd.ExecuteNonQuery()

            MessageBox.Show("Fees Added Successsfully !!!")
        Else
            MessageBox.Show("Fill the All fields !!!")
        End If
        tb_Tution_Fees_Add_Fee.Enabled = False
        tb_Hostel_Fees_Add_Fee.Enabled = False
        tb_Store_Room_Fees_Add_Fee.Enabled = False
        btn_Save_Add_Fees.Enabled = False
        btn_Refresh_Add_Fees.Enabled = False

        tb_Standard_Add_Fee.Text = ""
        tb_Medium_Add_Fee.Text = ""
        tb_Tution_Fees_Add_Fee.Text = ""
        tb_Hostel_Fees_Add_Fee.Text = ""
        tb_Store_Room_Fees_Add_Fee.Text = ""

        tb_Staff_First_Name.Focus()

        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Fee_ID) from tbl_Fee_Master "

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 101
            Else
                Cnt = Cnt + 101
            End If
            tb_Fees_id_Add_Fee.Text = Cnt
            tb_Standard_Add_Fee.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()

    End Sub

    Private Sub tb_Fees_id_Update_Fee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Fees_id_Update_Fee.TextChanged
        btn_Search_Update_Fees.Enabled = True
    End Sub

    Private Sub btn_Search_Update_Fees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Update_Fees.Click
        Try
            If tb_Fees_id_Update_Fee.Text <> "" Then
                Dim dr As SqlDataReader
                connection()
                cmd.Connection = con

                cmd.CommandText = "Select * From tbl_Fee_Master where Fee_ID = " + tb_Fees_id_Update_Fee.Text + ""
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    tb_Standrad_Update_Fee.Text = dr("Standard").ToString
                    tb_Medium_Update_Fee.Text = dr("Medium").ToString
                    tb_Tution_Fees_Update_Fee.Text = dr("Tution_Fee").ToString
                    tb_Hostel_Fees_Update_Fee.Text = dr("Hostel_Fee").ToString
                    tb_StoreRoom_Fees_Update_Fee.Text = dr("StoreRoom_Fee").ToString

                    btn_Save_Update_Fees.Enabled = True
                    btn_Refresh_Update_Fees.Enabled = True

                Else
                    MessageBox.Show("Invalid Fees ID!!!")
                    tb_Fees_id_Update_Fee.Text = ""

                    tb_Fees_id_Update_Fee.Focus()

                    btn_Search_Update_Fees.Enabled = False
                End If
                tb_Tution_Fees_Update_Fee.Enabled = True
                tb_Hostel_Fees_Update_Fee.Enabled = True
                tb_StoreRoom_Fees_Update_Fee.Enabled = True
                btn_Save_Update_Fees.Enabled = True
                btn_Refresh_Update_Fees.Enabled = True
                tb_Fees_id_Update_Fee.Enabled = False


                dr.Close()
                con.Close()
                cmd.Dispose()

            End If
                    Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Save_Update_Fees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Update_Fees.Click
        Try
            If tb_Fees_id_Update_Fee.Text <> "" Then
                connection()
                cmd.Connection = con


                cmd.CommandText = "Update tbl_Fee_Master set Standard ='" + tb_Standrad_Update_Fee.Text + "',Medium = '" + tb_Medium_Update_Fee.Text + "',Tution_Fee =" + tb_Tution_Fees_Update_Fee.Text + ",Hostel_Fee =" + tb_Hostel_Fees_Update_Fee.Text + ",StoreRoom_Fee = " + tb_StoreRoom_Fees_Update_Fee.Text + " where Fee_ID = " & tb_Fees_id_Update_Fee.Text & ""
                Dim i As Integer = cmd.ExecuteNonQuery()

                If i < 0 Then
                    MessageBox.Show("Fees Updated Succesfully!!!")
                End If

            Else
                MessageBox.Show("Enter fee Details for Update Fees Details !!!")

                tb_Fees_id_Update_Fee.Text = ""
                tb_Standrad_Update_Fee.Text = ""
                tb_Medium_Update_Fee.Text = ""
                tb_Tution_Fees_Update_Fee.Text = ""
                tb_Hostel_Fees_Update_Fee.Text = ""
                tb_StoreRoom_Fees_Update_Fee.Text = ""

                btn_Search_Update_Fees.Enabled = False
                btn_Save_Update_Fees.Enabled = False
                btn_Refresh_Update_Fees.Enabled = False

                tb_Fees_id_Update_Fee.Focus()

            End If

            tb_Fees_id_Update_Fee.Text = ""
            tb_Standrad_Update_Fee.Text = ""
            tb_Medium_Update_Fee.Text = ""
            tb_Tution_Fees_Update_Fee.Text = ""
            tb_Hostel_Fees_Update_Fee.Text = ""
            tb_StoreRoom_Fees_Update_Fee.Text = ""

            btn_Search_Update_Fees.Enabled = False
            btn_Save_Update_Fees.Enabled = False
            btn_Refresh_Update_Fees.Enabled = False

            tb_Fees_id_Update_Fee.Focus()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Stud_id_Update.Focus()
    End Sub

    Private Sub Timer_Stud_H_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Stud_H.Tick
        If P1.Text = "P1" Then
            PictureBox_Stud_H.Image = My.Resources.P1
            P1.Text = "P2"
        ElseIf P1.Text = "P2" Then
            PictureBox_Stud_H.Image = My.Resources.P2
            P1.Text = "P3"
        ElseIf P1.Text = "P3" Then
            PictureBox_Stud_H.Image = My.Resources.P3
            P1.Text = "P4"
        ElseIf P1.Text = "P4" Then
            PictureBox_Stud_H.Image = My.Resources.P4
            P1.Text = "P5"
        ElseIf P1.Text = "P5" Then
            PictureBox_Stud_H.Image = My.Resources.P5
            P1.Text = "P1"
        End If
    End Sub

    Private Sub tb_Stud_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Stud_id.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Standard_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Standard.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_pincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_pincode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Mob_no_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Mob_no.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Tution_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Tution_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Hostel_Fees_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Hostel_Fees.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Store_Room_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Store_Room_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Total_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Total_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Stud_id_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Stud_id_Update.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Standard_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Standard_Update.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Pin_Code_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Pin_Code_Update.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Mobile_Number_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Mobile_Number_Update.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_id.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Pin_Code_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Pin_Code.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Adhar_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Adhar_No.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Mob_Number_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Mob_Number.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Salary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Salary.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_id_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_id_Update.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Update__Adhar_No_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Update__Adhar_No.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Update_Mobile_no_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Update_Mobile_no.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Update_Sallary_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Update_Sallary.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Fees_id_Add_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Fees_id_Add_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Standard_Add_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Tution_Fees_Add_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Tution_Fees_Add_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Store_Room_Fees_Add_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Store_Room_Fees_Add_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Hostel_Fees_Add_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Hostel_Fees_Add_Fee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_First_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Middle_Name.KeyPress, tb_Last_Name.KeyPress, tb_First_Name.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Religion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Religion.KeyPress, tb_Mother_Profession.KeyPress, tb_Mother_Name.KeyPress, tb_Gender.KeyPress, tb_Father_Profession.KeyPress, tb_Father_Name.KeyPress, tb_City.KeyPress, cb_Medium.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_First_Name_Update_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Religion_Update.KeyPress, tb_Mother_Profession_Update.KeyPress, tb_Mother_Name_Update.KeyPress, tb_Middle_Name_Update.KeyPress, tb_Last_Name_Update.KeyPress, tb_Gender_Update.KeyPress, tb_First_Name_Update.KeyPress, tb_Father_Profession_Update.KeyPress, tb_Father_name_Update.KeyPress, tb_City_Update.KeyPress, cb_Medium_Update.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_First_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Religion.KeyPress, tb_Staff_Qualification.KeyPress, tb_Staff_Middle_Name.KeyPress, tb_staff_last_Name.KeyPress, tb_Staff_First_Name.KeyPress, tb_Staff_City.KeyPress, cb_staff_Position.KeyPress, cb_staff_gender.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_Update_First_Name_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Staff_Update_Religion.KeyPress, tb_Staff_Update_Qualification.KeyPress, tb_Staff_Update_Middle_Name.KeyPress, tb_Staff_update_last_name.KeyPress, tb_Staff_Update_First_Name.KeyPress, tb_Staff_Update_City.KeyPress, cb_staff_update_gender.KeyPress, cb_Staff_Update_Appoint_Position.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_User_Category_Add_New_User_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Username_Add_New_User.KeyPress, tb_User_Category_Add_New_User.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Username__Change_Password_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Username__Change_Password.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_User_Category_Delete_User_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Username_Delete_User.KeyPress, tb_User_Category_Delete_User.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Standard_Add_Fee_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Standard_Add_Fee.KeyPress, tb_Medium_Add_Fee.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Standrad_Update_Fee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Standrad_Update_Fee.KeyPress, tb_Medium_Update_Fee.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Staff_id_Update_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Staff_id_Update.TextChanged
        btn_Staff_Search.Enabled = True
    End Sub

    Private Sub tb_Mob_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Mob_no.Leave
        If Mobile_len(tb_Mob_no.TextLength) = 0 Then
            tb_Mob_no.Focus()
        End If
    End Sub

    Private Sub tb_Mobile_Number_Update_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Mobile_Number_Update.Leave
        If Mobile_len(tb_Mobile_Number_Update.TextLength) = 0 Then
            tb_Mobile_Number_Update.Focus()
        End If
    End Sub

    Private Sub tb_Staff_Mob_Number_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Staff_Mob_Number.Leave
        If Mobile_len(tb_Staff_Mob_Number.TextLength) = 0 Then
            tb_Staff_Mob_Number.Focus()
        End If
    End Sub

    Private Sub tb_Staff_Update_Mobile_no_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Staff_Update_Mobile_no.Leave
        If Mobile_len(tb_Staff_Update_Mobile_no.TextLength) = 0 Then
            tb_Staff_Update_Mobile_no.Focus()
        End If
    End Sub

    Private Sub tb_Current_Password_Change_Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Current_Password_Change_Password.Leave
        If Pass_len(tb_Current_Password_Change_Password.TextLength) = 0 Then
            tb_Current_Password_Change_Password.Focus()
        End If
    End Sub

    Private Sub tb_New_Password_Change_Password_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_New_Password_Change_Password.Leave
        If Pass_len(tb_New_Password_Change_Password.TextLength) = 0 Then
            tb_New_Password_Change_Password.Focus()
        End If
    End Sub

    Private Sub tb_Password_New_Add_New_User_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Password_New_Add_New_User.Leave
        If Pass_len(tb_Password_New_Add_New_User.TextLength) = 0 Then
            tb_Password_New_Add_New_User.Focus()
        End If
    End Sub

    Private Sub tb_Password_Confirm_Add_New_User_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Password_Confirm_Add_New_User.Leave
        If Pass_len(tb_Password_Confirm_Add_New_User.TextLength) = 0 Then
            tb_Password_Confirm_Add_New_User.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl2.SelectedIndex = 0
    End Sub
End Class