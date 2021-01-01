Imports System.Data.SqlClient

Public Class frm_Login


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Admin.Click
        tb_User_Category.Text = "Admin"
        tb_username.Focus()
    End Sub

    Private Sub btn_Office_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Office.Click
        tb_User_Category.Text = "Office"
        tb_username.Focus()
    End Sub

    Private Sub btn_Hostel_Mess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hostel_Warden.Click
        tb_User_Category.Text = "Hostel"
        tb_username.Focus()
    End Sub

    Private Sub btn_Store_Room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Store_Room.Click
        tb_User_Category.Text = "Store Room"
        tb_username.Focus()
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim name As String

        con.connectionstring = "Data Source=.\SQLEXPRESS;Initial Catalog=DSMS_DB;Integrated Security=True"
        con.open()

        cmd.Connection = con
        cmd.CommandText = "select * from tb_login where User_Category='" + tb_User_Category.Text + "' and User_Name='" + tb_username.Text + "' and Password='" + tb_Password.Text + "'"

        name = cmd.ExecuteScalar()
        If name <> "" Then
            If (tb_User_Category.Text = "Admin") Then
                common_class.gbl_var = 3
                MessageBox.Show("Welcome Admin", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                frm_Main_Menu.Show()
                Me.Hide()
            ElseIf (tb_User_Category.Text = "Office") Then
                MessageBox.Show("Welcome Office Manager", "Office", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                common_class.gbl_var = 1
                frm_Main_Menu.Show()
                Me.Hide()
            ElseIf (tb_User_Category.Text = "Hostel") Then
                MessageBox.Show("Welcome Hostel Warden", "Hostel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                common_class.gbl_var = 2
                frm_Hostel_MDI.Show()
                Me.Hide()
            ElseIf (tb_User_Category.Text = "Store Room") Then
                MessageBox.Show("Welcome Store Room Incharge", "Store Room", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                common_class.gbl_var = 4
                frm_Store_Room_MDI.Show()
                Me.Hide()
            Else
                MessageBox.Show("Welcome User", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Else
            MessageBox.Show("Please Enter Valid Username or Password...")
            lbl_Note.Enabled = True
        End If
        tb_User_Category.Text = ""
        tb_username.Text = ""
        tb_Password.Text = ""
        btn_Login.Enabled = False
        tb_username.Focus()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_username.Focus()
    End Sub

    Private Sub tb_Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_Password.TextChanged
        btn_Login.Enabled = True
    End Sub
End Class
