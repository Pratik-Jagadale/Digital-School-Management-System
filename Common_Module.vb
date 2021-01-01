Module Common_Module

    Public Sub CharLock(ByVal e)
        Dim ch As Char = e.keychar
        If Not Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Public Sub NumLock(ByVal e)
        Dim ch As Char = e.keychar
        If Char.IsDigit(ch) And Asc(ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Public Function Mobile_len(ByVal len As Integer)
        If len < 10 Then
            MessageBox.Show("Mobile Number Should be 10....")
            Return 0
        End If
        Return 1
    End Function

    Public Function Pass_len(ByVal len As Integer)
        If len < 4 Then
            MessageBox.Show("Password should be More than 4 digit")
            Return 0
        End If
        Return 1
    End Function

End Module
