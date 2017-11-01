Imports System.Data.OleDb

Public Class frmEmailId

    Private Sub frmEmailId_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.CenterToScreen()
    End Sub

    Private Sub cmdChngEmailId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChngEmailId.Click
        VerifyOldEmailId()

        'Dim strLoginId As String
        'strLoginId = frmLogin.txtLogin.Text
        'If (txtNewPwd.Text = vbNullString Or txtReNewPwd.Text = vbNullString) Then
        '    MsgBox("Password field cannot be blank", MsgBoxStyle.Information, "Password Blank")
        'ElseIf (txtNewPwd.Text <> txtReNewPwd.Text) Then
        '    MsgBox("Passwords do not match", MsgBoxStyle.Information, "Passwords not matching")
        'Else
        '    Dim con As New OleDbConnection
        '    con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        '    con.Open()
        '    Dim cmdstr As New OleDbCommand
        '    cmdstr.Connection = con
        '    cmdstr.CommandText = "Update tblLoginDetails SET [Password] = '" & txtNewPwd.Text & "',LastLogin = '" & Now() & "' WHERE EmployeeId = '" & strLoginId & "'"
        '    cmdstr.ExecuteNonQuery()
        '    MsgBox("Password Changed", MsgBoxStyle.Information, "Password Changed")
        '    con.Close()
        '    con.Dispose()
        '    Me.Close()
        'End If
    End Sub

    Public Sub VerifyOldEmailId()
        Dim strLoginId As String
        strLoginId = frmLogin.txtLogin.Text
        If (txtNewEmailId.Text = vbNullString Or txtReNewEmailId.Text = vbNullString) Then
            MsgBox("Email Id field cannot be blank", MsgBoxStyle.Information, "Required Data Blank")
            Exit Sub
        ElseIf (txtNewEmailId.Text <> txtReNewEmailId.Text) Then
            MsgBox("Email Id's do not match", MsgBoxStyle.Information, "Not Matching")
            Exit Sub
        Else
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr As New OleDbCommand
            cmdstr.Connection = con
            cmdstr.CommandText = "Update tblLoginDetails SET [EmailId] = '" & txtNewEmailId.Text & "' WHERE EmployeeId = '" & strLoginId & "'"
            cmdstr.ExecuteNonQuery()
            MsgBox("Email Id Changed", MsgBoxStyle.Information, "Email Id Changed")
            con.Close()
            con.Dispose()
            Me.Close()
        End If
    End Sub
End Class