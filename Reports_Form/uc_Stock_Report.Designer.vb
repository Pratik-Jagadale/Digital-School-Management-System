<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Stock_Report
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
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.tb_Student_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crv_Stock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Indigo
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Search.Location = New System.Drawing.Point(1118, 61)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(144, 39)
        Me.btn_Search.TabIndex = 36
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'tb_Student_id
        '
        Me.tb_Student_id.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Student_id.Location = New System.Drawing.Point(821, 67)
        Me.tb_Student_id.Name = "tb_Student_id"
        Me.tb_Student_id.Size = New System.Drawing.Size(201, 34)
        Me.tb_Student_id.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(559, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 43)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Product ID :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1614, 52)
        Me.Panel1.TabIndex = 33
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.Location = New System.Drawing.Point(1539, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 52)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(666, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Report"
        '
        'crv_Stock
        '
        Me.crv_Stock.ActiveViewIndex = -1
        Me.crv_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Stock.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_Stock.DisplayStatusBar = False
        Me.crv_Stock.DisplayToolbar = False
        Me.crv_Stock.Location = New System.Drawing.Point(184, 110)
        Me.crv_Stock.Name = "crv_Stock"
        Me.crv_Stock.Size = New System.Drawing.Size(1289, 805)
        Me.crv_Stock.TabIndex = 37
        '
        'uc_Stock_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.crv_Stock)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.tb_Student_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc_Stock_Report"
        Me.Size = New System.Drawing.Size(1614, 934)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents tb_Student_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crv_Stock As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
