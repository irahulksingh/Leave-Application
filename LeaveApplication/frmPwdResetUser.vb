Imports System.Data.OleDb

Public Class frmPwdResetUser
    Private Sub cmdChngPwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChngPwd.Click
        Dim strLoginId As String
        Dim strPasswordEncrpted As String
        strPasswordEncrpted = getEncryptedCode(txtNewPwd.Text.Trim().ToString)
        strLoginId = frmLogin.txtLogin.Text
        If (txtNewPwd.Text = vbNullString Or txtReNewPwd.Text = vbNullString) Then
            MsgBox("Password field cannot be blank", MsgBoxStyle.Information, "Password Blank")
        ElseIf (txtNewPwd.Text <> txtReNewPwd.Text) Then
            MsgBox("Passwords do not match", MsgBoxStyle.Information, "Passwords not matching")
        Else
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr As New OleDbCommand
            cmdstr.Connection = con
            cmdstr.CommandText = "Update tblLoginDetails SET [Password] = '" & strPasswordEncrpted & "',LastLogin = '" & Now() & "' WHERE EmployeeId = '" & strLoginId & "'"
            cmdstr.ExecuteNonQuery()
            MsgBox("Password Changed", MsgBoxStyle.Information, "Password Changed")
            con.Close()
            con.Dispose()
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub PasswordReset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.CenterToScreen()
        frmLogin.Hide()
        Me.TopMost = True
        Dim strLoginId As String
        strLoginId = frmLogin.txtLogin.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        cmdstr.Connection = con
        cmdstr.CommandText = "Select EmployeeName from tblLoginDetails where EmployeeID = '" & strLoginId & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        Dim Result As String = ""
        Result = dtTable.Rows("0").Item("EmployeeName")
        lblUserName.Text = "Welcome" + " " + Result
        con.Close()
        con.Dispose()
    End Sub
    Public Shared Function getEncryptedCode(ByVal inputString As String) As String
        Dim Hash As Byte() = New System.Security.Cryptography.SHA512Managed().ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(inputString))
        Dim outputString As New System.Text.StringBuilder()
        For i As Integer = 0 To Hash.Length - 1
            outputString.Append(Hash(i).ToString("x2"))
        Next
        Return outputString.ToString()
    End Function
End Class