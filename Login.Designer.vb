<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_WELCOME = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_User_Name = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.btn_Admin = New System.Windows.Forms.Button()
        Me.tb_User_Category = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Office = New System.Windows.Forms.Button()
        Me.btn_Hostel_Warden = New System.Windows.Forms.Button()
        Me.btn_Store_Room = New System.Windows.Forms.Button()
        Me.lbl_Note = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_WELCOME)
        Me.Panel1.Location = New System.Drawing.Point(417, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 551)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(362, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 91)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DSMS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(25, 251)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log in to access your account."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_WELCOME
        '
        Me.lbl_WELCOME.AutoSize = True
        Me.lbl_WELCOME.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_WELCOME.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_WELCOME.Location = New System.Drawing.Point(17, 169)
        Me.lbl_WELCOME.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_WELCOME.Name = "lbl_WELCOME"
        Me.lbl_WELCOME.Size = New System.Drawing.Size(346, 69)
        Me.lbl_WELCOME.TabIndex = 0
        Me.lbl_WELCOME.Text = "Welcome to"
        Me.lbl_WELCOME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(15, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Digital School Management System"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_User_Name
        '
        Me.lbl_User_Name.AutoSize = True
        Me.lbl_User_Name.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_User_Name.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_User_Name.Location = New System.Drawing.Point(-1, 259)
        Me.lbl_User_Name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_User_Name.Name = "lbl_User_Name"
        Me.lbl_User_Name.Size = New System.Drawing.Size(147, 32)
        Me.lbl_User_Name.TabIndex = 4
        Me.lbl_User_Name.Text = "User Name :"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_Password.Location = New System.Drawing.Point(-1, 348)
        Me.lbl_Password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(128, 32)
        Me.lbl_Password.TabIndex = 5
        Me.lbl_Password.Text = "Password :"
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(79, 302)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(267, 22)
        Me.tb_username.TabIndex = 1
        '
        'tb_Password
        '
        Me.tb_Password.ForeColor = System.Drawing.Color.Indigo
        Me.tb_Password.Location = New System.Drawing.Point(79, 395)
        Me.tb_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_Password.Size = New System.Drawing.Size(267, 22)
        Me.tb_Password.TabIndex = 2
        '
        'btn_Admin
        '
        Me.btn_Admin.BackColor = System.Drawing.Color.Purple
        Me.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Admin.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Admin.Location = New System.Drawing.Point(4, 96)
        Me.btn_Admin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Admin.Name = "btn_Admin"
        Me.btn_Admin.Size = New System.Drawing.Size(107, 38)
        Me.btn_Admin.TabIndex = 6
        Me.btn_Admin.Text = "Admin"
        Me.btn_Admin.UseVisualStyleBackColor = False
        '
        'tb_User_Category
        '
        Me.tb_User_Category.Enabled = False
        Me.tb_User_Category.Location = New System.Drawing.Point(79, 212)
        Me.tb_User_Category.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_User_Category.Name = "tb_User_Category"
        Me.tb_User_Category.Size = New System.Drawing.Size(267, 22)
        Me.tb_User_Category.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(-1, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "User category:"
        '
        'btn_Office
        '
        Me.btn_Office.BackColor = System.Drawing.Color.Purple
        Me.btn_Office.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Office.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Office.Location = New System.Drawing.Point(104, 96)
        Me.btn_Office.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Office.Name = "btn_Office"
        Me.btn_Office.Size = New System.Drawing.Size(107, 38)
        Me.btn_Office.TabIndex = 9
        Me.btn_Office.Text = "Office"
        Me.btn_Office.UseVisualStyleBackColor = False
        '
        'btn_Hostel_Warden
        '
        Me.btn_Hostel_Warden.BackColor = System.Drawing.Color.Purple
        Me.btn_Hostel_Warden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Hostel_Warden.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Hostel_Warden.Location = New System.Drawing.Point(209, 96)
        Me.btn_Hostel_Warden.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Hostel_Warden.Name = "btn_Hostel_Warden"
        Me.btn_Hostel_Warden.Size = New System.Drawing.Size(107, 38)
        Me.btn_Hostel_Warden.TabIndex = 10
        Me.btn_Hostel_Warden.Text = "Hostel"
        Me.btn_Hostel_Warden.UseVisualStyleBackColor = False
        '
        'btn_Store_Room
        '
        Me.btn_Store_Room.BackColor = System.Drawing.Color.Purple
        Me.btn_Store_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Store_Room.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_Store_Room.Location = New System.Drawing.Point(303, 96)
        Me.btn_Store_Room.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Store_Room.Name = "btn_Store_Room"
        Me.btn_Store_Room.Size = New System.Drawing.Size(107, 38)
        Me.btn_Store_Room.TabIndex = 11
        Me.btn_Store_Room.Text = "Store Room"
        Me.btn_Store_Room.UseVisualStyleBackColor = False
        '
        'lbl_Note
        '
        Me.lbl_Note.AutoSize = True
        Me.lbl_Note.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Note.Location = New System.Drawing.Point(39, 519)
        Me.lbl_Note.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Note.Name = "lbl_Note"
        Me.lbl_Note.Size = New System.Drawing.Size(0, 17)
        Me.lbl_Note.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.DSMS.My.Resources.Resources.social_group
        Me.PictureBox1.Location = New System.Drawing.Point(355, 204)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.DSMS.My.Resources.Resources.key
        Me.PictureBox2.Location = New System.Drawing.Point(355, 388)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.DSMS.My.Resources.Resources.std
        Me.PictureBox6.Location = New System.Drawing.Point(355, 294)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(55, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Indigo
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Login.Image = CType(resources.GetObject("btn_Login.Image"), System.Drawing.Image)
        Me.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Login.Location = New System.Drawing.Point(181, 453)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(141, 60)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = " Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.DSMS.My.Resources.Resources.cancel
        Me.Button1.Location = New System.Drawing.Point(628, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 53)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1124, 551)
        Me.Controls.Add(Me.lbl_Note)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btn_Store_Room)
        Me.Controls.Add(Me.btn_Hostel_Warden)
        Me.Controls.Add(Me.btn_Office)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_User_Category)
        Me.Controls.Add(Me.btn_Admin)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_User_Name)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_WELCOME As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_User_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents tb_username As System.Windows.Forms.TextBox
    Friend WithEvents tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents btn_Login As System.Windows.Forms.Button
    Friend WithEvents btn_Admin As System.Windows.Forms.Button
    Friend WithEvents tb_User_Category As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Office As System.Windows.Forms.Button
    Friend WithEvents btn_Hostel_Warden As System.Windows.Forms.Button
    Friend WithEvents btn_Store_Room As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Note As System.Windows.Forms.Label

End Class
