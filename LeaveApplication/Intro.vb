Public Class Intro

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer2.Enabled = True
        Timer1.Enabled = False
        frmLogin.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Opacity = Me.Opacity - 0.1
        Me.Visible = False
    End Sub
End Class