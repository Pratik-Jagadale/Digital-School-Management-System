<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Student_Puchase_Reports
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
        Me.tb_Student_id = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crv_student_Purchase = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_Student_id
        '
        Me.tb_Student_id.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Student_id.Location = New System.Drawing.Point(932, 93)
        Me.tb_Student_id.Name = "tb_Student_id"
        Me.tb_Student_id.Size = New System.Drawing.Size(201, 34)
        Me.tb_Student_id.TabIndex = 36
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.Location = New System.Drawing.Point(1539, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 64)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Indigo
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Search.Location = New System.Drawing.Point(1229, 90)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(144, 39)
        Me.btn_Search.TabIndex = 37
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(670, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 43)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Student ID :"
        '
        'crv_student_Purchase
        '
        Me.crv_student_Purchase.ActiveViewIndex = -1
        Me.crv_student_Purchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_student_Purchase.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_student_Purchase.DisplayStatusBar = False
        Me.crv_student_Purchase.DisplayToolbar = False
        Me.crv_student_Purchase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crv_student_Purchase.Location = New System.Drawing.Point(0, 148)
        Me.crv_student_Purchase.Name = "crv_student_Purchase"
        Me.crv_student_Purchase.Size = New System.Drawing.Size(1614, 786)
        Me.crv_student_Purchase.TabIndex = 34
        Me.crv_student_Purchase.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(647, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Purchase Report"
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
        Me.Panel1.TabIndex = 33
        '
        'uc_Student_Puchase_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tb_Student_id)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.crv_student_Purchase)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Student_Puchase_Reports"
        Me.Size = New System.Drawing.Size(1614, 934)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_Student_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv_student_Purchase As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
