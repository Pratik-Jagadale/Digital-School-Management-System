Public Class frm_Splash_Screen
    Public sf As DSMS.frm_Splash_Screen
    Public ul As DSMS.frm_Login

    Private Sub frm_Splash_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer_Splash_Screen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar2.PerformStep()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Timer1.Enabled = False
        Timer2.Enabled = False
        System.Threading.Thread.Sleep(1000)
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Opacity -= 0.02
        If Me.Opacity <= 0 Then
            sf = Me
            Me.Hide()
            ul = New frm_Login
            ul.Show()
        End If
        
    End Sub
End Class



'    Private Sub Timer_Splash_Screen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Splash_Screen.Tick

'        'Timer_Splash_Screen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Splash_Screen.Tick
'        '       ProgressBar2.

'        '       'If ProgressBar2 > 545 Then
'        '       '    Timer_Splash_Screen.Stop()
'        '       'End If

'        '   End Sub
'End Class