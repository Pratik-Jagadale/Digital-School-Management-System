<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Add_Room
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btn_Reset_Add_New_Room = New System.Windows.Forms.Button()
        Me.tb_Add_New_Description = New System.Windows.Forms.TextBox()
        Me.cb_Add_New_Room = New System.Windows.Forms.ComboBox()
        Me.btn_Save_New_Added_Room = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Add_New_Hostel = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Reset_Add_New_Room
        '
        Me.btn_Reset_Add_New_Room.BackColor = System.Drawing.Color.Gray
        Me.btn_Reset_Add_New_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Reset_Add_New_Room.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Reset_Add_New_Room.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Reset_Add_New_Room.Location = New System.Drawing.Point(738, 361)
        Me.btn_Reset_Add_New_Room.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Reset_Add_New_Room.Name = "btn_Reset_Add_New_Room"
        Me.btn_Reset_Add_New_Room.Size = New System.Drawing.Size(256, 59)
        Me.btn_Reset_Add_New_Room.TabIndex = 17
        Me.btn_Reset_Add_New_Room.Text = "RESET"
        Me.btn_Reset_Add_New_Room.UseVisualStyleBackColor = False
        '
        'tb_Add_New_Description
        '
        Me.tb_Add_New_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Add_New_Description.Location = New System.Drawing.Point(1075, 130)
        Me.tb_Add_New_Description.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_Add_New_Description.Multiline = True
        Me.tb_Add_New_Description.Name = "tb_Add_New_Description"
        Me.tb_Add_New_Description.Size = New System.Drawing.Size(363, 128)
        Me.tb_Add_New_Description.TabIndex = 16
        '
        'cb_Add_New_Room
        '
        Me.cb_Add_New_Room.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Add_New_Room.FormattingEnabled = True
        Me.cb_Add_New_Room.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_Add_New_Room.Location = New System.Drawing.Point(381, 238)
        Me.cb_Add_New_Room.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_Add_New_Room.Name = "cb_Add_New_Room"
        Me.cb_Add_New_Room.Size = New System.Drawing.Size(367, 33)
        Me.cb_Add_New_Room.TabIndex = 14
        '
        'btn_Save_New_Added_Room
        '
        Me.btn_Save_New_Added_Room.BackColor = System.Drawing.Color.Gray
        Me.btn_Save_New_Added_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save_New_Added_Room.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save_New_Added_Room.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Save_New_Added_Room.Location = New System.Drawing.Point(450, 361)
        Me.btn_Save_New_Added_Room.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Save_New_Added_Room.Name = "btn_Save_New_Added_Room"
        Me.btn_Save_New_Added_Room.Size = New System.Drawing.Size(250, 59)
        Me.btn_Save_New_Added_Room.TabIndex = 13
        Me.btn_Save_New_Added_Room.Text = "SAVE"
        Me.btn_Save_New_Added_Room.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(811, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Description -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(105, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Room Number -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(99, 129)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hostel Number -"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1573, 82)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(559, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Room"
        '
        'tb_Add_New_Hostel
        '
        Me.tb_Add_New_Hostel.Enabled = False
        Me.tb_Add_New_Hostel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_Add_New_Hostel.Location = New System.Drawing.Point(381, 128)
        Me.tb_Add_New_Hostel.Name = "tb_Add_New_Hostel"
        Me.tb_Add_New_Hostel.Size = New System.Drawing.Size(367, 30)
        Me.tb_Add_New_Hostel.TabIndex = 19
        '
        'uc_Add_Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tb_Add_New_Hostel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Reset_Add_New_Room)
        Me.Controls.Add(Me.tb_Add_New_Description)
        Me.Controls.Add(Me.cb_Add_New_Room)
        Me.Controls.Add(Me.btn_Save_New_Added_Room)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "uc_Add_Room"
        Me.Size = New System.Drawing.Size(1573, 461)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Reset_Add_New_Room As System.Windows.Forms.Button
    Friend WithEvents tb_Add_New_Description As System.Windows.Forms.TextBox
    Friend WithEvents cb_Add_New_Room As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Save_New_Added_Room As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_Add_New_Hostel As System.Windows.Forms.TextBox

End Class
