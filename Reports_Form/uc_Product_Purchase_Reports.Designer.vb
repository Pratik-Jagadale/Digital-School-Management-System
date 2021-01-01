<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Product_Purchase_Reports
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
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.crv_Product_Pruchase_Report = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.tb_Student_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(0, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 64)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'crv_Product_Pruchase_Report
        '
        Me.crv_Product_Pruchase_Report.ActiveViewIndex = -1
        Me.crv_Product_Pruchase_Report.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.crv_Product_Pruchase_Report.DisplayStatusBar = False
        Me.crv_Product_Pruchase_Report.DisplayToolbar = False
        Me.crv_Product_Pruchase_Report.Location = New System.Drawing.Point(280, 89)
        Me.crv_Product_Pruchase_Report.Name = "crv_Product_Pruchase_Report"
        Me.crv_Product_Pruchase_Report.Size = New System.Drawing.Size(1146, 842)
        Me.crv_Product_Pruchase_Report.TabIndex = 3
        Me.crv_Product_Pruchase_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Indigo
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Search.Location = New System.Drawing.Point(950, 20)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(144, 39)
        Me.btn_Search.TabIndex = 35
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'tb_Student_id
        '
        Me.tb_Student_id.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Student_id.Location = New System.Drawing.Point(702, 23)
        Me.tb_Student_id.Name = "tb_Student_id"
        Me.tb_Student_id.Size = New System.Drawing.Size(201, 34)
        Me.tb_Student_id.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(440, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 43)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Product ID :"
        '
        'uc_Product_Purchase_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.tb_Student_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.crv_Product_Pruchase_Report)
        Me.Controls.Add(Me.btn_Close)
        Me.Name = "uc_Product_Purchase_Reports"
        Me.Size = New System.Drawing.Size(1614, 934)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents crv_Product_Pruchase_Report As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents tb_Student_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
