<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Student_Bill_Datewise_Reports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crv_Datewise_student_fee = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1614, 64)
        Me.Panel1.TabIndex = 30
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.Location = New System.Drawing.Point(1539, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 64)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(540, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Date Wise Bill Report"
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Indigo
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Search.Location = New System.Drawing.Point(1164, 90)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(144, 39)
        Me.btn_Search.TabIndex = 36
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 43)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Student ID :"
        '
        'crv_Datewise_student_fee
        '
        Me.crv_Datewise_student_fee.ActiveViewIndex = -1
        Me.crv_Datewise_student_fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Datewise_student_fee.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_Datewise_student_fee.DisplayStatusBar = False
        Me.crv_Datewise_student_fee.DisplayToolbar = False
        Me.crv_Datewise_student_fee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crv_Datewise_student_fee.Location = New System.Drawing.Point(0, 148)
        Me.crv_Datewise_student_fee.Name = "crv_Datewise_student_fee"
        Me.crv_Datewise_student_fee.Size = New System.Drawing.Size(1614, 786)
        Me.crv_Datewise_student_fee.TabIndex = 33
        Me.crv_Datewise_student_fee.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'dtp_Start
        '
        Me.dtp_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Start.Location = New System.Drawing.Point(603, 90)
        Me.dtp_Start.Name = "dtp_Start"
        Me.dtp_Start.Size = New System.Drawing.Size(200, 34)
        Me.dtp_Start.TabIndex = 37
        '
        'dtp_End
        '
        Me.dtp_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End.Location = New System.Drawing.Point(914, 92)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(200, 34)
        Me.dtp_End.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(831, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 40)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "To"
        '
        'uc_Student_Bill_Datewise_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.dtp_Start)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.crv_Datewise_student_fee)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Student_Bill_Datewise_Reports"
        Me.Size = New System.Drawing.Size(1614, 934)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv_Datewise_student_fee As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
