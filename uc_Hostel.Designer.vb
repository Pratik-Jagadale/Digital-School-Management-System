<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Hostel
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
        Me.btn_add_Hostel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_add_Hostel
        '
        Me.btn_add_Hostel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_add_Hostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_Hostel.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_Hostel.ForeColor = System.Drawing.Color.Indigo
        Me.btn_add_Hostel.Location = New System.Drawing.Point(0, 0)
        Me.btn_add_Hostel.Name = "btn_add_Hostel"
        Me.btn_add_Hostel.Size = New System.Drawing.Size(329, 241)
        Me.btn_add_Hostel.TabIndex = 0
        Me.btn_add_Hostel.Text = "H1"
        Me.btn_add_Hostel.UseVisualStyleBackColor = True
        '
        'uc_Hostel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_add_Hostel)
        Me.Name = "uc_Hostel"
        Me.Size = New System.Drawing.Size(329, 241)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_add_Hostel As System.Windows.Forms.Button

End Class
