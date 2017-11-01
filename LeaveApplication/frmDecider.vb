Public Class frmDecider

    Private Sub frmDecider_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Label1.Focus()
    End Sub

    Private Sub btnManagerLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManagerLogin.Click
        frmApprover.Show()
        Me.Hide()
    End Sub

    Private Sub btnSuserLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuserLogin.Click
        frmApplier.Show()
        Me.Hide()
    End Sub

    Private Sub frmDecider_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class