Public Class common_class
    Public Shared gbl_var As Integer = 0

    Public Shared Sub menu_hide_open(ByRef pan As Panel)
        If pan.Visible = True Then
            pan.Visible = False
        Else
            pan.Visible = True
        End If
    End Sub

    Public Shared Sub clear_tb(ByVal obj As Object)
        For Each item As Control In obj.Controls
            If item.GetType Is GetType(TextBox) Then
                item.Text = ""
            End If
        Next
    End Sub

    Public Shared Sub clear_cb(ByVal obj As Object)
        For Each item As Control In obj.Controls
            If item.GetType Is GetType(ComboBox) Then
                item.Text = ""
            End If
        Next
    End Sub

End Class
