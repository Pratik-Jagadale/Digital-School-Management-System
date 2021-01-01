<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Stock_Datewise_Report
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
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.crv_Stock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Start = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(3, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 64)
        Me.btn_Close.TabIndex = 3
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.BackColor = System.Drawing.Color.Indigo
        Me.btn_Search.FlatAppearance.BorderSize = 0
        Me.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Search.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_Search.Location = New System.Drawing.Point(1182, 15)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(144, 39)
        Me.btn_Search.TabIndex = 39
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 43)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Product ID :"
        '
        'crv_Stock
        '
        Me.crv_Stock.ActiveViewIndex = -1
        Me.crv_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_Stock.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_Stock.DisplayStatusBar = False
        Me.crv_Stock.DisplayToolbar = False
        Me.crv_Stock.Location = New System.Drawing.Point(234, 84)
        Me.crv_Stock.Name = "crv_Stock"
        Me.crv_Stock.Size = New System.Drawing.Size(1146, 842)
        Me.crv_Stock.TabIndex = 36
        Me.crv_Stock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(847, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 40)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "To"
        '
        'dtp_End
        '
        Me.dtp_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End.Location = New System.Drawing.Point(930, 17)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(200, 34)
        Me.dtp_End.TabIndex = 41
        '
        'dtp_Start
        '
        Me.dtp_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Start.Location = New System.Drawing.Point(619, 15)
        Me.dtp_Start.Name = "dtp_Start"
        Me.dtp_Start.Size = New System.Drawing.Size(200, 34)
        Me.dtp_Start.TabIndex = 40
        '
        'uc_Stock_Datewise_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.dtp_Start)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.crv_Stock)
        Me.Controls.Add(Me.btn_Close)
        Me.Name = "uc_Stock_Datewise_Report"
        Me.Size = New System.Drawing.Size(1614, 934)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv_Stock As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Start As System.Windows.Forms.DateTimePicker

End Class
