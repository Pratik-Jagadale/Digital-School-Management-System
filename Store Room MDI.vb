Imports System.Data.SqlClient

Public Class frm_Store_Room_MDI
    Dim cmd As New SqlCommand
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True")
    Dim sum As Integer = 0
    Dim dr As SqlDataReader

    Public Sub connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub btn_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back_to_Main_menu.Click
        Me.Hide()
        frm_Splash_Screen.Show()
    End Sub

    Private Sub btn_Home_Page_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Home_Page.Click
        TabControl1.SelectedIndex = 0
        lbl.Text = "Digital School Managment System"
    End Sub

    Private Sub btn_Customer_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Customer_Master.Click
        common_class.menu_hide_open(Panel_Customer_Master)

        If Panel_Distributor_Master.Visible = True Then
            Panel_Distributor_Master.Visible = False
        End If
        If panel_Product_Master.Visible = True Then
            panel_Product_Master.Visible = False
        End If
        If Panel_Stock_Master.Visible = True Then
            Panel_Stock_Master.Visible = False
        End If
        lbl.Text = "   Customer Master"
        TabControl1.SelectedIndex = 1
        TabControl2.SelectedIndex = 3
    End Sub

    'Private Sub btn_Customer_Master_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Customer_Master.MouseHover
    '    common_class.menu_hide_open(Panel_Customer_Master)

    '    'TabControl1.SelectedIndex = 1
    '    'TabControl2.SelectedIndex = 3
    'End Sub

    Private Sub btn_Product_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Product_Master.Click
        common_class.menu_hide_open(panel_Product_Master)
        lbl.Text = "Product Master"
        TabControl1.SelectedIndex = 2
        TabControl3.SelectedIndex = 2
        If Panel_Distributor_Master.Visible = True Then
            Panel_Distributor_Master.Visible = False
        End If
        If Panel_Customer_Master.Visible = True Then
            Panel_Customer_Master.Visible = False
        End If
        If Panel_Stock_Master.Visible = True Then
            Panel_Stock_Master.Visible = False
        End If
        
    End Sub

    'Private Sub btn_Product_Master_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Product_Master.MouseHover
    '    common_class.menu_hide_open(panel_Product_Master)

    '    If Panel_Distributor_Master.Visible = True Then
    '        Panel_Distributor_Master.Visible = False
    '    End If
    '    If Panel_Customer_Master.Visible = True Then
    '        Panel_Customer_Master.Visible = False
    '    End If
    '    If Panel_Stock_Master.Visible = True Then
    '        Panel_Stock_Master.Visible = False
    '    End If


    '    'TabControl1.SelectedIndex = 2
    '    'TabControl3.SelectedIndex = 3
    'End Sub

    Private Sub btn_Stock_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stock_Master.Click
        common_class.menu_hide_open(Panel_Stock_Master)
        lbl.Text = "    Stock Master"

        If Panel_Distributor_Master.Visible = True Then
            Panel_Distributor_Master.Visible = False
        End If
        If Panel_Customer_Master.Visible = True Then
            Panel_Customer_Master.Visible = False
        End If
        If panel_Product_Master.Visible = True Then
            panel_Product_Master.Visible = False
        End If
        TabControl1.SelectedIndex = 3
        TabControl4.SelectedIndex = 2
    End Sub

    'Private Sub btn_Stock_Master_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stock_Master.MouseHover
    '    common_class.menu_hide_open(Panel_Stock_Master)

    '    If Panel_Distributor_Master.Visible = True Then
    '        Panel_Distributor_Master.Visible = False
    '    End If
    '    If Panel_Customer_Master.Visible = True Then
    '        Panel_Customer_Master.Visible = False
    '    End If
    '    If panel_Product_Master.Visible = True Then
    '        panel_Product_Master.Visible = False
    '    End If

    '    'TabControl1.SelectedIndex = 3
    '    'TabControl4.SelectedIndex = 2
    'End Sub

    Private Sub btn_Distributor_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Distributor_Master.Click
        common_class.menu_hide_open(Panel_Distributor_Master)
        lbl.Text = "      Distributot Master"
        If Panel_Stock_Master.Visible = True Then
            Panel_Stock_Master.Visible = False
        End If
        If Panel_Customer_Master.Visible = True Then
            Panel_Customer_Master.Visible = False
        End If
        If panel_Product_Master.Visible = True Then
            panel_Product_Master.Visible = False
        End If

        TabControl1.SelectedIndex = 4
        TabControl5.SelectedIndex = 2
    End Sub

    'Private Sub btn_Distributor_Master_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Distributor_Master.MouseHover
    '    common_class.menu_hide_open(Panel_Distributor_Master)

    '    If Panel_Distributor_Master.Visible = True Then
    '        Panel_Distributor_Master.Visible = False
    '    End If
    '    If Panel_Customer_Master.Visible = True Then
    '        Panel_Customer_Master.Visible = False
    '    End If
    '    If panel_Product_Master.Visible = True Then
    '        panel_Product_Master.Visible = False
    '    End If
    '    'TabControl1.SelectedIndex = 4
    '    'TabControl5.SelectedIndex = 2
    'End Sub

    Private Sub btn_Add_New_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Room.Click
        TabControl2.SelectedIndex = 0
        lbl.Text = " Customer Master"
        tb_Student_id_Purchase_Product.Focus()
    End Sub

    Private Sub btn_Update_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Room.Click
        lbl.Text = "        View/Search Purchase Details"
        TabControl2.SelectedIndex = 1

    End Sub

    Private Sub btn_Student_Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Student_Registration.Click
        lbl.Text = "        All Purchase Detail"
        TabControl2.SelectedIndex = 2

        Try
            cmd.Connection = con
            connection()

            cmd = New SqlCommand("select * from stbl_Product_Purchase_Details ", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid__All_Purchase_Details.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Add_New_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Item.Click
        lbl.Text = "        Add New Item"
        TabControl1.SelectedIndex = 2
        TabControl3.SelectedIndex = 0

        Try
            Dim Cnt As Integer
            connection()

            cmd.Connection = con
            cmd.CommandText = "select Count(Product_ID) from stbl_Product_Master"

            Cnt = cmd.ExecuteScalar()

            If Cnt = 0 Then
                Cnt = 1001
            Else
                Cnt = Cnt + 1001
            End If
            tb_Product_id_Add_Product.Text = Cnt
            tb_Category_Add_Product.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        cmd.Dispose()
        con.Close()
    End Sub

    Private Sub btn_Update_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Item.Click
        lbl.Text = "        Update Item"
        TabControl1.SelectedIndex = 2
        TabControl3.SelectedIndex = 1
        tb_Product_ID_Update_Product.Focus()
    End Sub

    Private Sub btn_Add_Update_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Update_Stock.Click
        lbl.Text = "        Add Update Stock"
        TabControl1.SelectedIndex = 3
        TabControl4.SelectedIndex = 0
        tb_Item_id_Add_Update_Stock.Focus()
    End Sub

    Private Sub btn_Check_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Check_Stock.Click
        lbl.Text = "        Check Stock"
        TabControl1.SelectedIndex = 2
        TabControl4.SelectedIndex = 1
    End Sub

    Private Sub btn_Add_New_Distributor_Master_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_New_Distributor_Master.Click
        lbl.Text = "        Add New Distributor"
        TabControl5.SelectedIndex = 0
        connection()
        Dim cnt As Integer
        cmd = New SqlCommand("select count(Distribbutor_ID)from Stbl_Distributor_Master", con)

        cnt = cmd.ExecuteScalar

        If cnt = 0 Then
            cnt = 1001
        Else
            cnt += 1001
        End If
        tb_Distributor_id_Add_Distributor.Text = cnt
        tb_Distributor_id_Add_Distributor.Enabled = False

        tb_Distributor_F_Name_Add_Distributor.Focus()
    End Sub

    Private Sub btn_Update_Distributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_Distributor.Click
        lbl.Text = "        Update Distributor"
        TabControl5.SelectedIndex = 1
        tb_tb_Distributor_id_Update_Distributor.Focus()
    End Sub

    Private Sub frm_Store_Room_MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If common_class.gbl_var = 4 Then
            btn_Exit_StoreRoom.Visible = True
            btn_back_to_Main_menu.Visible = False
            common_class.gbl_var = 0
        End If
    End Sub

    Private Sub btn_Exit_StoreRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit_StoreRoom.Click
        btn_Exit_StoreRoom.Visible = False
        btn_back_to_Main_menu.Visible = True
        Me.Hide()
        frm_Login.Show()
    End Sub

    Private Sub frm_Store_Room_MDI_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If common_class.gbl_var = 4 Then
            btn_Exit_StoreRoom.Visible = True
            btn_back_to_Main_menu.Visible = False
            common_class.gbl_var = 0
        End If
    End Sub

    Private Sub btn_Save_Add_Distributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Add_Distributor.Click
        connection()

        cmd.Connection = con
        If tb_Distributor_id_Add_Distributor.Text <> "" And tb_Distributor_F_Name_Add_Distributor.Text <> "" And tb_Distributor_M_Name_Add_Distributor.Text <> "" And tb_Dis0ributor_L_Name_Add_Distributor.Text <> "" And tb_Distributor_Address_Add_Distributor.Text <> "" And tb_Distributor_Reg_No_Add_Distributor.Text <> "" And dtp_Tie_Up_Date_Add_Distributor.Text <> "" And tb_Distributor_Mob_No_Add_Distributor.Text <> "" And tb_Distributor_Adhaar_No_Add_Distributor.Text <> "" And tb_Distributor_PAN_No_Add_Distributor.Text <> "" And cb_Catategory_Add_Distributorory.Text <> "" Then
            If tb_Distributor_Alt_Cont_No_Add_Distributor.Text <> "" Then
                cmd = New SqlCommand("Insert Into stbl_Distributor_Master values(" & tb_Distributor_id_Add_Distributor.Text & ",'" & tb_Distributor_F_Name_Add_Distributor.Text & "','" & tb_Distributor_M_Name_Add_Distributor.Text & "','" & tb_Dis0ributor_L_Name_Add_Distributor.Text & "','" & tb_Distributor_Address_Add_Distributor.Text & "'," & tb_Distributor_Reg_No_Add_Distributor.Text & ",'" & dtp_Tie_Up_Date_Add_Distributor.Text & "'," & tb_Distributor_Mob_No_Add_Distributor.Text & "," & tb_Distributor_Alt_Cont_No_Add_Distributor.Text & "," & tb_Distributor_Adhaar_No_Add_Distributor.Text & "," & tb_Distributor_PAN_No_Add_Distributor.Text & ",'" & cb_Catategory_Add_Distributorory.Text & "','" & tb_Distributor_product_Name_Add_Distributor.Text & "')", con)
                cmd.ExecuteNonQuery()

                cmd.Dispose()
            Else
                cmd = New SqlCommand("insert into stbl_Distributor_Master (Distribbutor_ID,First_Name,Middle_Name,Last_Name,Address,Registration_No,Tie_Up_Date,Mobile_No,Adhar_No,Pan_No,Category,Product_Name) values(" & tb_Distributor_id_Add_Distributor.Text & ",'" & tb_Distributor_F_Name_Add_Distributor.Text & "','" & tb_Distributor_M_Name_Add_Distributor.Text & "','" & tb_Dis0ributor_L_Name_Add_Distributor.Text & "','" & tb_Distributor_Address_Add_Distributor.Text & "'," & tb_Distributor_Reg_No_Add_Distributor.Text & ",'" & dtp_Tie_Up_Date_Add_Distributor.Text & "'," & tb_Distributor_Mob_No_Add_Distributor.Text & "," & tb_Distributor_Adhaar_No_Add_Distributor.Text & "," & tb_Distributor_PAN_No_Add_Distributor.Text & ",'" & cb_Catategory_Add_Distributorory.Text & "','" & tb_Distributor_product_Name_Add_Distributor.Text & "')", con)

                cmd.ExecuteNonQuery()

                If cmd.ExecuteNonQuery() Then
                    tb_Distributor_id_Add_Distributor.Text = ""
                    tb_Distributor_F_Name_Add_Distributor.Text = ""
                    tb_Distributor_M_Name_Add_Distributor.Text = ""
                    tb_Dis0ributor_L_Name_Add_Distributor.Text = ""
                    tb_Distributor_Address_Add_Distributor.Text = ""
                    tb_Distributor_Reg_No_Add_Distributor.Text = ""
                    dtp_Tie_Up_Date_Add_Distributor.Text = ""
                    tb_Distributor_Mob_No_Add_Distributor.Text = ""
                    tb_Distributor_Adhaar_No_Add_Distributor.Text = ""
                    tb_Distributor_PAN_No_Add_Distributor.Text = ""
                    cb_Catategory_Add_Distributorory.Text = ""
                    tb_Distributor_Alt_Cont_No_Add_Distributor.Text = ""

                    Dim cntr As Integer
                    cmd = New SqlCommand("select count(Distribbutor_ID)from Stbl_Distributor_Master", con)

                    cntr = cmd.ExecuteScalar

                    If cntr = 0 Then
                        cntr = 1001
                    Else
                        cntr += 1001
                    End If
                    tb_Distributor_id_Add_Distributor.Text = cntr

                End If
                MessageBox.Show("Distributor Added Succesfully!!")
                cmd.Dispose()
            End If
            cmd.Dispose()

            MessageBox.Show("Distributor  Added Succesfully!!")

           
            tb_Distributor_id_Add_Distributor.Text = ""
            tb_Distributor_F_Name_Add_Distributor.Text = ""
            tb_Distributor_M_Name_Add_Distributor.Text = ""
            tb_Dis0ributor_L_Name_Add_Distributor.Text = ""
            tb_Distributor_Address_Add_Distributor.Text = ""
            tb_Distributor_Reg_No_Add_Distributor.Text = ""
            dtp_Tie_Up_Date_Add_Distributor.Text = ""
            tb_Distributor_Mob_No_Add_Distributor.Text = ""
            tb_Distributor_Adhaar_No_Add_Distributor.Text = ""
            tb_Distributor_PAN_No_Add_Distributor.Text = ""
            cb_Catategory_Add_Distributorory.Text = ""
            tb_Distributor_Alt_Cont_No_Add_Distributor.Text = ""

            Dim cnt As Integer
            cmd = New SqlCommand("select count(Distribbutor_ID)from Stbl_Distributor_Master", con)

            cnt = cmd.ExecuteScalar

            If cnt = 0 Then
                cnt = 1001
            Else
                cnt += 1001
            End If
            tb_Distributor_id_Add_Distributor.Text = cnt

        Else
            MessageBox.Show("1st Fill all the fields...")
        End If
        
    End Sub

    Private Sub tb_Distributor_product_Name_Add_Distributor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Distributor_product_Name_Add_Distributor.TextChanged
        ' If tb_Distributor_id_Add_Distributor.Text <> "" And tb_Distributor_F_Name_Add_Distributor.Text <> "" And tb_Distributor_M_Name_Add_Distributor.Text <> "" And tb_Dis0ributor_L_Name_Add_Distributor.Text <> "" And tb_Distributor_Address_Add_Distributor.Text <> "" And tb_Distributor_Reg_No_Add_Distributor.Text <> "" And dtp_Tie_Up_Date_Add_Distributor.Text <> "" And tb_Distributor_Mob_No_Add_Distributor.Text <> "" And tb_Distributor_Adhaar_No_Add_Distributor.Text <> "" And tb_Distributor_PAN_No_Add_Distributor.Text <> "" And cb_Catategory_Add_Distributorory.Text <> "" Then
        ' Else
        '   MessageBox.Show(Please Fill the All Fields)
        ' End If   btn_Save_Add_Distributor.Enabled = True

    End Sub

    Private Sub btn_Search_Update_Distributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Update_Distributor.Click
        Dim dr As SqlDataReader
        connection()
        cmd = New SqlCommand("select * from Stbl_Distributor_Master where Distribbutor_ID =" & tb_tb_Distributor_id_Update_Distributor.Text & "", con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            tb_Distributor_F_Name_Update_Distributor.Text = dr("First_Name").ToString
            tb_Distributor_M_Name_Update_Distributor.Text = dr("Middle_Name").ToString
            tb_Dis0ributor_L_Name_Update_Distributor.Text = dr("Last_Name").ToString
            tb_Distributor_Address_Update_Distributor.Text = dr("Address").ToString
            tb_Distributor_Reg_No_Update_Distributor.Text = dr("Registration_No").ToString
            dtp_Tie_Up_Date_Update_Distributor.Text = dr("Tie_Up_Date").ToString
            tb_Distributor_Mob_No_Update_Distributor.Text = dr("Mobile_No").ToString
            tb_Distributor_Alt_Cont_No_Update_Distributor.Text = dr("Alt_Mobile_No").ToString
            tb_Distributor_Adhaar_No_Update_Distributor.Text = dr("Adhar_No").ToString
            tb_Distributor_PAN_No_Update_Distributor.Text = dr("Pan_No").ToString
            cb_Catategory_Update_Distributor.Text = dr("Category").ToString
        Else
            MessageBox.Show("Record Not Found....")
            btn_Search_Update_Distributor.Enabled = False
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub btn_Save_Update_Distributor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Update_Distributor.Click

        connection()
        If tb_Distributor_F_Name_Update_Distributor.Text <> "" Then

            'If tb_Distributor_Alt_Cont_No_Update_Distributor.Text <> "" Then
            cmd = New SqlCommand("Update Stbl_Distributor_Master set First_Name = '" & tb_Distributor_F_Name_Update_Distributor.Text & "',Middle_Name = '" & tb_Distributor_M_Name_Update_Distributor.Text & "',Last_Name = '" & tb_Dis0ributor_L_Name_Update_Distributor.Text & "',Address = '" & tb_Distributor_Address_Update_Distributor.Text & "',Registration_No = " & tb_Distributor_Reg_No_Update_Distributor.Text & ",Tie_Up_Date ='" & dtp_Tie_Up_Date_Update_Distributor.Text & "',Mobile_No = " & tb_Distributor_Mob_No_Update_Distributor.Text & ",Alt_Mobile_No = " & tb_Distributor_Alt_Cont_No_Update_Distributor.Text & ",Adhar_No = " & tb_Distributor_Adhaar_No_Update_Distributor.Text & ",PAN_No = '" & tb_Distributor_PAN_No_Update_Distributor.Text & "' where Distribbutor_ID = " & tb_tb_Distributor_id_Update_Distributor.Text & "", con)

            cmd.ExecuteNonQuery()

            cmd.Dispose()
            'Else

            'cmd = New SqlCommand("Update Stbl_Distributor_Master set First_Name = '" & tb_Distributor_F_Name_Update_Distributor.Text & "',Middle_Name = '" & tb_Distributor_M_Name_Update_Distributor.Text & "',Last_Name = '" & tb_Dis0ributor_L_Name_Update_Distributor.Text & "',Address = '" & tb_Distributor_Address_Update_Distributor.Text & "',Registration_No = " & tb_Distributor_Reg_No_Update_Distributor.Text & ",Tie_Up_Date ='" & dtp_Tie_Up_Date_Update_Distributor.Text & "',Mob_No = " & tb_Distributor_Mob_No_Update_Distributor.Text & ",Alt_Con_No = " & tb_Distributor_Alt_Cont_No_Update_Distributor.Text & ",Adhaar_No = " & tb_Distributor_Adhaar_No_Update_Distributor.Text & ",PAN_No = '" & tb_Distributor_PAN_No_Update_Distributor.Text & "' where Distribbutor_ID = " & tb_tb_Distributor_id_Update_Distributor.Text & "", con)

            ' cmd.ExecuteNonQuery()
            '  End If


        Else
            MessageBox.Show("Please Enter Valid Distributor ID ...")
        End If
        MessageBox.Show(" Distributor Updated Succesfully ...")

        tb_Distributor_F_Name_Update_Distributor.Text = ""
        tb_Distributor_M_Name_Update_Distributor.Text = ""
        tb_Dis0ributor_L_Name_Update_Distributor.Text = ""
        tb_Distributor_Address_Update_Distributor.Text = ""
        tb_Distributor_Reg_No_Update_Distributor.Text = ""
        dtp_Tie_Up_Date_Update_Distributor.Text = ""
        tb_Distributor_Mob_No_Update_Distributor.Text = ""
        tb_Distributor_Alt_Cont_No_Update_Distributor.Text = ""
        tb_Distributor_Adhaar_No_Update_Distributor.Text = ""
        tb_Distributor_PAN_No_Update_Distributor.Text = ""
        cb_Catategory_Update_Distributor.Text = ""

        tb_tb_Distributor_id_Update_Distributor.Focus()
        btn_Save_Update_Distributor.Enabled = False
    End Sub

    Private Sub btn_Add_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Product.Click
       
        If tb_Product_id_Add_Product.Text <> "" And tb_Category_Add_Product.Text <> "" And tb_Product_Name_Add_Product.Text <> "" And tb_Purchase_rate_Add_Product.Text <> "" And tb_Distributor_ID_Add_Product.Text <> "" And tb_Sales_Rate_Add_Product.Text Then

            connection()
            cmd.Connection = con
            cmd.CommandText = "Insert Into stbl_Product_Master Values (" & tb_Product_id_Add_Product.Text & ",'" & tb_Category_Add_Product.Text & "','" & tb_Product_Name_Add_Product.Text & "' ," & tb_Purchase_rate_Add_Product.Text & ",'" & tb_Stock_date_Add_Product.Text & "' ," & tb_Distributor_ID_Add_Product.Text & " , " & tb_Sales_Rate_Add_Product.Text & " ,'" & tb_Specification_Add_Product.Text & "' )"

            cmd.ExecuteNonQuery()

            cmd.Dispose()
            Dim stock As Integer = 0
            cmd.CommandText = "Insert Into stbl_Stock_Master Values (" & tb_Product_id_Add_Product.Text & ",'" & tb_Stock_date_Add_Product.Text & "'," & stock & " )"
            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("New Product Added Successsfully !!!")
                common_class.clear_cb(GroupBox2)
            End If


        Else
            MessageBox.Show("Please Fill the All Fields")
        End If
    End Sub

    Private Sub tb_Product_ID_Update_Product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Product_ID_Update_Product.TextChanged
        btn_Search_Product.Enabled = True
    End Sub

    Private Sub btn_Search_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Product.Click
        Try
            If tb_Product_ID_Update_Product.Text <> "" Then
                Dim dr As SqlDataReader
                connection()
                cmd.Connection = con

                cmd.CommandText = "Select * From stbl_Product_Master where Product_ID = " + tb_Product_ID_Update_Product.Text + ""
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    tb_Category_Update_Product.Text = dr("Category").ToString
                    tb_Product_Name_Update_Product.Text = dr("Product_Name").ToString
                    tb_Purchase_Rate_Update_Product.Text = dr("Purchase_Rate").ToString
                    tb_Distributor_ID_Update_Product.Text = dr("Distributor_ID").ToString
                    tb_Sells_Rate_Update_Product.Text = dr("Sales_Rate").ToString
                    tb_Specification_Update_Product.Text = dr("Speicification").ToString

                    btn_Search_Product.Enabled = False

                    btn_Save_Update_Product.Enabled = True
                    btn_Reset_Update_Product.Enabled = True
                    tb_Product_ID_Update_Product.Enabled = False

                Else
                    MessageBox.Show("Invalid Fees ID!!!")
                    tb_Product_ID_Update_Product.Text = ""

                    tb_Product_ID_Update_Product.Focus()

                End If
                dr.Close()
                con.Close()
                cmd.Dispose()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Save_Update_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Update_Product.Click
        Try
            If tb_Category_Update_Product.Text <> "" Then
                connection()
                cmd.Connection = con


                cmd.CommandText = "Update stbl_Product_Master set Category ='" + tb_Category_Update_Product.Text + "',Product_Name = '" + tb_Product_Name_Update_Product.Text + "',Purchase_Rate =" + tb_Purchase_Rate_Update_Product.Text + ",Distributor_ID =" + tb_Distributor_ID_Update_Product.Text + ",Sales_Rate = " + tb_Sells_Rate_Update_Product.Text + " ,Speicification = '" + tb_Specification_Update_Product.Text + "' where Product_ID = " & tb_Product_ID_Update_Product.Text & ""
                cmd.ExecuteNonQuery()

                MessageBox.Show("Product Updated Succesfully!!!")
                con.Close()
                cmd.Dispose()
            Else
                ' MessageBox.Show("Enter Valid Product ID!!!")

            End If
            tb_Product_ID_Update_Product.Focus()
            tb_Product_ID_Update_Product.Enabled = True
            tb_Category_Update_Product.Text = ""
            tb_Product_Name_Update_Product.Text = ""
            tb_Purchase_Rate_Update_Product.Text = ""
            tb_Distributor_ID_Update_Product.Text = ""
            tb_Sells_Rate_Update_Product.Text = ""
            tb_Specification_Update_Product.Text = ""


            btn_Search_Product.Enabled = False
            btn_Save_Update_Product.Enabled = False
            btn_Reset_Update_Product.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        tb_Product_ID_Update_Product.Focus()
    End Sub

    Private Sub btn_Reset_Update_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reset_Update_Product.Click
        tb_Product_ID_Update_Product.Focus()
        tb_Product_ID_Update_Product.Enabled = True
        tb_Category_Update_Product.Text = ""
        tb_Product_Name_Update_Product.Text = ""
        tb_Purchase_Rate_Update_Product.Text = ""
        tb_Distributor_ID_Update_Product.Text = ""
        tb_Sells_Rate_Update_Product.Text = ""
        tb_Specification_Update_Product.Text = ""


        btn_Search_Product.Enabled = False
        btn_Save_Update_Product.Enabled = False
        btn_Reset_Update_Product.Enabled = False
    End Sub

    Private Sub tb_Item_id_Add_Update_Stock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Item_id_Add_Update_Stock.TextChanged
        btn_Search_Add_Update_Stock.Enabled = True
    End Sub

    Private Sub btn_Search_Add_Update_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Add_Update_Stock.Click
        Try
            If tb_Item_id_Add_Update_Stock.Text <> "" Then
                Dim dr As SqlDataReader
                connection()
                cmd.Connection = con

                cmd.CommandText = "Select * From stbl_Product_Master where Product_ID = " + tb_Item_id_Add_Update_Stock.Text + ""
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    tb_Category_Add_Update_Stock.Text = dr("Category").ToString
                    tb_Item_Name_Add_Update_Stock.Text = dr("Product_Name").ToString

                    tb_Purchase_Rate_Update_Product.Text = dr("Purchase_Rate").ToString
                    tb_Distributor_id_Add_Update_Stock.Text = dr("Distributor_ID").ToString
                    tb_Sells_Rate_Update_Product.Text = dr("Sales_Rate").ToString
                    tb_Specification_Update_Product.Text = dr("Speicification").ToString
                Else
                    MessageBox.Show("Invalid Product ID!!!")
                    tb_Item_id_Add_Update_Stock.Text = ""

                    tb_Item_id_Add_Update_Stock.Focus()

                    btn_Search_Product.Enabled = False
                End If
                cmd.Dispose()
                dr.Close()

                cmd.CommandText = "Select * From stbl_Stock_Master where Product_ID = " + tb_Item_id_Add_Update_Stock.Text + ""
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    tbCurrent_Add_Update_Stock.Text = dr("Stock").ToString
                Else

                End If
                btn_Search_Product.Enabled = False
                tb_Category_Add_Update_Stock.Enabled = False
                tb_Distributor_id_Add_Update_Stock.Enabled = False
                btn_Save_Update_Product.Enabled = True
                btn_Reset_Update_Product.Enabled = True
                tb_Item_id_Add_Update_Stock.Enabled = False

                dr.Close()
                cmd.Dispose()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Save__Add_Update_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save__Add_Update_Stock.Click
        connection()
        cmd.Connection = con

        Dim sum As Integer = 0
        sum = Val(tbCurrent_Add_Update_Stock.Text) + Val(tb_Stock_Added_Add_Update_Stock.Text)
        If tb_Category_Add_Update_Stock.Text <> "" And tb_Item_Name_Add_Update_Stock.Text <> "" And tb_Distributor_id_Add_Update_Stock.Text <> "" And tb_Stock_Added_Add_Update_Stock.Text <> "" Then

            cmd.CommandText = ("update stbl_Stock_Master set Stock_Added_Date = '" & dtp_Stock_Date_Add_Update_Stock.Text & "',Stock = " & sum & " where Product_ID = " & tb_Item_id_Add_Update_Stock.Text & " ")

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            cmd.CommandText = "insert into tbl_Stock_Details values (" & tb_Item_id_Add_Update_Stock.Text & ",'" & tb_Category_Add_Update_Stock.Text & "','" & tb_Item_Name_Add_Update_Stock.Text + "'," & tb_Stock_Added_Add_Update_Stock.Text & "," & sum & " ,'" & dtp_Stock_Date_Add_Update_Stock.Text & "')"
            Dim i As Integer = cmd.ExecuteNonQuery()

            If (i > 0) Then

                MessageBox.Show("Data Updated Successfully..")

                tb_Item_id_Add_Update_Stock.Text = ""
                tb_Category_Add_Update_Stock.Text = ""
                tb_Item_Name_Add_Update_Stock.Text = ""
                tb_Distributor_id_Add_Update_Stock.Text = ""
                tb_Stock_Added_Add_Update_Stock.Text = ""
                dtp_Stock_Date_Add_Update_Stock.Text = ""
                tbCurrent_Add_Update_Stock.Text = "0"
          
            End If
            cmd.Dispose()
            con.Close()
        Else
            MessageBox.Show("Please Fill Correct Product id ")
        End If
    End Sub

    Private Sub btn_Search_Check_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Check_Stock.Click

    End Sub

    Private Sub btn_Search_Student_ID_Purchase_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_Student_ID_Purchase_Product.Click
        connection()
        cmd.Connection = con
        Dim dr As SqlDataReader

        cmd.CommandText = ("select * from tbl_Stud_Master where Student_ID = " + tb_Student_id_Purchase_Product.Text + "")
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            tb_Stud_Name_Purchase_Product.Text = dr("First_Name").ToString
            tb_Standard_Purchase_Product.Text = dr("Standard").ToString
        End If
        tb_Student_id_Purchase_Product.Enabled = False
        btn_Search_Student_ID_Purchase_Product.Enabled = False
        cmd.Dispose()
        con.Close()
        dr.Close()
    End Sub

    Private Sub btn_ADD_Purchase_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ADD_Purchase_Product.Click
        Dim Current_Stock As Integer
        connection()
        cmd = New SqlCommand("select Stock from  stbl_Stock_Master where Product_ID =  " + tb_Product_ID_Purchase_Product.Text + " ", con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            Current_Stock = dr("Stock")
        End If
        cmd.Dispose()
        dr.Close()


        If tb_Product_Quantity_Purchase_Product.Text <> "" And tb_Product_Total_Price_Purchase_Product.Text <> "" Then
            If Current_Stock < tb_Product_Quantity_Purchase_Product.Text Then
                MessageBox.Show("There is Not Enough Stock ... Stock Available is - " & Current_Stock.ToString & "")
                tb_Product_Quantity_Purchase_Product.Focus()
                tb_Product_Quantity_Purchase_Product.Text = ""

            Else
                dgv_Purchase_Product.Rows.Add(tb_Student_id_Purchase_Product.Text, tb_Product_ID_Purchase_Product.Text, tb_Category_Purchase_Product.Text, tb_Product_Name_Purchase_Product.Text, tb_Price_Purchase_Product.Text, tb_Product_Quantity_Purchase_Product.Text, tb_Product_Total_Price_Purchase_Product.Text)

                tb_Total_Bill_Purchase_Product.Text = Val(tb_Total_Bill_Purchase_Product.Text) + Val(tb_Product_Total_Price_Purchase_Product.Text)

                tb_Product_ID_Purchase_Product.Focus()
                tb_Category_Purchase_Product.Text = ""
                tb_Product_Name_Purchase_Product.SelectedIndex = -1
                tb_Product_Name_Purchase_Product.Text = ""
                tb_Price_Purchase_Product.Text = ""
                tb_Product_Quantity_Purchase_Product.Text = ""
                tb_Product_Total_Price_Purchase_Product.Text = ""
                btn_ADD_Purchase_Product.Enabled = False
            End If
            
        End If
        con.Close()
    End Sub

    Private Sub tb_Product_Name_Purchase_Product_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Product_Name_Purchase_Product.Leave
        connection()
        cmd.Connection = con
        Dim dr As SqlDataReader

        cmd.CommandText = ("select * from stbl_Product_Master where Category = '" + tb_Category_Purchase_Product.Text + "' and Product_Name = '" + tb_Product_Name_Purchase_Product.Text + "' ")
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            tb_Price_Purchase_Product.Text = dr("Sales_Rate").ToString
            tb_Product_ID_Purchase_Product.Text = dr("Product_ID").ToString
        End If

        cmd.Dispose()
        con.Close()
        dr.Close()
    End Sub

    Private Sub btn_Refresh_Purchase_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh_Purchase_Product.Click
        dgv_Purchase_Product.Rows.Clear()
    End Sub

    Private Sub tb_Product_Quantity_Purchase_Product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Product_Quantity_Purchase_Product.TextChanged
        btn_ADD_Purchase_Product.Enabled = True
        tb_Product_Total_Price_Purchase_Product.Text = Val(tb_Price_Purchase_Product.Text) * Val(tb_Product_Quantity_Purchase_Product.Text)
    End Sub

    Private Sub btn_Close_Purchase_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close_Purchase_Product.Click

        tb_Product_Name_Purchase_Product.SelectedIndex = -1
        dgv_Purchase_Product.Rows.Clear()

        tb_Student_id_Purchase_Product.Enabled = True
        common_class.clear_tb(Panel4)
        common_class.clear_tb(Panel5)
        common_class.clear_cb(Panel5)
        tb_Student_id_Purchase_Product.Focus()
    End Sub

    Private Sub btn_Save_Purchase_Product_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save_Purchase_Product.Click
        connection()
        If tb_Total_Bill_Purchase_Product.Text > 0 Then
            cmd = New SqlCommand("insert into stbl_Student_Purchase_Details values(" + tb_Student_id_Purchase_Product.Text + ",'" + tb_Stud_Name_Purchase_Product.Text + "'," + tb_Standard_Purchase_Product.Text + ",'" + dtp_DOB_Purchase_Product.Text + "'," + tb_Total_Bill_Purchase_Product.Text + ")", con)

            cmd.ExecuteNonQuery()
            Dim i As Integer = cmd.ExecuteNonQuery
            cmd.Dispose()
            i = 0
            While dgv_Purchase_Product.Rows.Count
                If i = dgv_Purchase_Product.Rows.Count - 1 Then
                    Exit While
                End If
              
                cmd = New SqlCommand("insert into stbl_Product_Purchase_Details values(" & dgv_Purchase_Product.Rows(i).Cells(0).Value & "," & dgv_Purchase_Product.Rows(i).Cells(1).Value & ",'" & dgv_Purchase_Product.Rows(i).Cells(2).Value & "','" & dgv_Purchase_Product.Rows(i).Cells(3).Value & "'," & dgv_Purchase_Product.Rows(i).Cells(4).Value & "," & dgv_Purchase_Product.Rows(i).Cells(5).Value & "," & dgv_Purchase_Product.Rows(i).Cells(6).Value & ")", con)
                
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Dim Current_Stock As Integer

                cmd = New SqlCommand("select Stock from  stbl_Stock_Master where Product_iD =  " + dgv_Purchase_Product.Rows(i).Cells(1).Value + " ", con)
                dr = cmd.ExecuteReader

                If dr.Read Then
                    Current_Stock = dr("Stock")
                End If

                dr.Close()
                Current_Stock = Current_Stock - dgv_Purchase_Product.Rows(i).Cells(5).Value
                cmd.Dispose()

                cmd = New SqlCommand("Update stbl_Stock_Master set Stock = " & Current_Stock & " ", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                i = i + 1
            End While

            If (i > 0) Then
                MessageBox.Show("Record Added Successfully...")
            Else
                MessageBox.Show("SEREVER ERROR")
            End If
        End If
        con.Close()
        tb_Category_Purchase_Product.Text = ""
        tb_Product_Name_Purchase_Product.SelectedIndex = -1
        tb_Product_Name_Purchase_Product.Text = ""
        tb_Price_Purchase_Product.Text = ""
        tb_Product_Quantity_Purchase_Product.Text = ""
        tb_Product_Total_Price_Purchase_Product.Text = ""
        btn_ADD_Purchase_Product.Enabled = False
        tb_Total_Bill_Purchase_Product.Text = ""

        dgv_Purchase_Product.Rows.Clear()

        tb_Student_id_Purchase_Product.Text = ""
        tb_Stud_Name_Purchase_Product.Text = ""
        tb_Standard_Purchase_Product.Text = ""

        tb_Student_id_Purchase_Product.Enabled = True
        tb_Student_id_Purchase_Product.Focus()
    End Sub

    Private Sub tb_Product_ID_Purchase_Product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Product_ID_Purchase_Product.TextChanged
        connection()
        cmd.Connection = con
        Dim dr As SqlDataReader

        cmd.CommandText = ("select * from stbl_Product_Master where Product_ID = '" + tb_Product_ID_Purchase_Product.Text + "'  ")
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            tb_Price_Purchase_Product.Text = dr("Sales_Rate").ToString
            tb_Category_Purchase_Product.Text = dr("Category").ToString
            tb_Product_Name_Purchase_Product.Text = dr("Product_Name").ToString
        End If

        cmd.Dispose()
        con.Close()
        dr.Close()
    End Sub

    Private Sub cb_Search_BY_View_purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Search_BY_View_purchase_Details.Click
        cb_Search_BY_View_purchase_Details.SelectedIndex = -1
        

    End Sub

    Private Sub btn_Search_View_purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search_View_purchase_Details.Click
        Try
            cmd.Connection = con
            connection()
           
            cmd = New SqlCommand("select *from stbl_Product_Purchase_Details where Product_ID = '" & cb_Product_Name_View_purchase_Details.Text & "'", con)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            da.Fill(dt)

            Grid_View_purchase_Details.DataSource = dt
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tb_Stud_Name_Purchase_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Stud_Name_Purchase_Product.KeyPress, tb_Product_Name_Purchase_Product.KeyPress, tb_Category_Purchase_Product.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Category_Add_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Specification_Add_Product.KeyPress, tb_Category_Add_Product.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Category_Update_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Specification_Update_Product.KeyPress, tb_Product_Name_Update_Product.KeyPress, tb_Category_Update_Product.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Category_Add_Update_Stock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Item_Name_Add_Update_Stock.KeyPress, tb_Category_Add_Update_Stock.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub cb_Category_Check_Stock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb_Item_Name_Check_Stock.KeyPress, cb_Category_Check_Stock.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Distributor_F_Name_Add_Distributor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Distributor_product_Name_Add_Distributor.KeyPress, tb_Distributor_M_Name_Add_Distributor.KeyPress, tb_Distributor_F_Name_Add_Distributor.KeyPress, tb_Dis0ributor_L_Name_Add_Distributor.KeyPress, cb_Catategory_Add_Distributorory.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Distributor_PAN_No_Add_Distributor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Distributor_Reg_No_Add_Distributor.KeyPress, tb_Distributor_PAN_No_Add_Distributor.KeyPress, tb_Distributor_Mob_No_Add_Distributor.KeyPress, tb_Distributor_id_Add_Distributor.KeyPress, tb_Distributor_Alt_Cont_No_Add_Distributor.KeyPress, tb_Distributor_Adhaar_No_Add_Distributor.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_tb_Distributor_id_Update_Distributor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_tb_Distributor_id_Update_Distributor.KeyPress, tb_Distributor_Reg_No_Update_Distributor.KeyPress, tb_Distributor_PAN_No_Update_Distributor.KeyPress, tb_Distributor_Mob_No_Update_Distributor.KeyPress, tb_Distributor_Alt_Cont_No_Update_Distributor.KeyPress, tb_Distributor_Adhaar_No_Update_Distributor.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbCurrent_Add_Update_Stock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCurrent_Add_Update_Stock.KeyPress, tb_Stock_Added_Add_Update_Stock.KeyPress, tb_Item_id_Add_Update_Stock.KeyPress, tb_Distributor_id_Add_Update_Stock.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Product_ID_Update_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Sells_Rate_Update_Product.KeyPress, tb_Purchase_Rate_Update_Product.KeyPress, tb_Product_ID_Update_Product.KeyPress, tb_Distributor_ID_Update_Product.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Student_id_All_Purchase_Details_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Student_id_Purchase_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Total_Bill_Purchase_Product.KeyPress, tb_Student_id_Purchase_Product.KeyPress, tb_Standard_Purchase_Product.KeyPress, tb_Product_Total_Price_Purchase_Product.KeyPress, tb_Product_Quantity_Purchase_Product.KeyPress, tb_Product_ID_Purchase_Product.KeyPress, tb_Price_Purchase_Product.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Distributor_Mob_No_Add_Distributor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Distributor_Mob_No_Add_Distributor.Leave
        If Mobile_len(tb_Distributor_Mob_No_Add_Distributor.TextLength) = 0 Then
            tb_Distributor_Mob_No_Add_Distributor.Focus()
        End If
    End Sub

    Private Sub tb_Distributor_Alt_Cont_No_Add_Distributor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Distributor_Alt_Cont_No_Add_Distributor.Leave
        If Mobile_len(tb_Distributor_Alt_Cont_No_Add_Distributor.TextLength) = 0 Then
            tb_Distributor_Alt_Cont_No_Add_Distributor.Focus()
        End If
    End Sub

    Private Sub tb_Student_id_Purchase_Product_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Student_id_Purchase_Product.TextChanged
        btn_Search_Student_ID_Purchase_Product.Enabled = True
    End Sub

    Private Sub btn_Search_All_Purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tb_Product_Name_Add_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Product_Name_Add_Product.KeyPress
        If (e.KeyChar < "A" OrElse e.KeyChar > "Z") AndAlso (e.KeyChar < "a" OrElse e.KeyChar > "z") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Purchase_rate_Add_Product_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Sales_Rate_Add_Product.KeyPress, tb_Purchase_rate_Add_Product.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub cb_Product_Name_View_purchase_Details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Product_Name_View_purchase_Details.Click
        connection()

        Dim cmd As New SqlCommand("select distinct(Product_ID) from stbl_Product_Purchase_Details", con)
        Dim adapter1 As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter1.Fill(table)
        cb_Product_Name_View_purchase_Details.DataSource = table
        cb_Product_Name_View_purchase_Details.DisplayMember = "Product_ID"

        adapter1.Dispose()
        cmd.Dispose()
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Distributor_ID_Add_Product.Click
        connection()

        Dim cmd As New SqlCommand("select distinct(Distribbutor_ID) from Stbl_Distributor_Master", con)
        Dim adapter1 As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter1.Fill(table)
        tb_Distributor_ID_Add_Product.DataSource = table
        tb_Distributor_ID_Add_Product.DisplayMember = "Distribbutor_ID"

        adapter1.Dispose()
        cmd.Dispose()
    End Sub
End Class