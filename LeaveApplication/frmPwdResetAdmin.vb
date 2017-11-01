Imports System.Data.OleDb

Public Class frmPwdResetAdmin

    Private Sub frmPwdResetUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Dim strLoginId As String
        Dim strPasswordEncrpted As String
        strPasswordEncrpted = getEncryptedCode(txtNewPwd.Text.Trim().ToString)
        strLoginId = frmLogin.txtLogin.Text
        If (txtEmpName.Text = vbNullString Or txtEmpId.Text = vbNullString) Then
            MsgBox("Employee Id or Name Blank", MsgBoxStyle.Information, "No Data")
            Exit Sub
        ElseIf (txtNewPwd.Text = vbNullString Or txtNewPwdRe.Text = vbNullString) Then
            MsgBox("Password field cannot be blank", MsgBoxStyle.Information, "Password Blank")
            Exit Sub
        ElseIf (txtNewPwd.Text <> txtNewPwdRe.Text) Then
            MsgBox("Passwords do not match", MsgBoxStyle.Information, "Passwords not matching")
            Exit Sub
        Else
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr As New OleDbCommand
            cmdstr.Connection = con
            cmdstr.CommandText = "Update tblLoginDetails SET [Password] = '" & strPasswordEncrpted & "',LastLogin = '" & Now() & "' WHERE EmployeeId = '" & txtEmpId.Text & "'"
            cmdstr.ExecuteNonQuery()
            MsgBox("Password Reset", MsgBoxStyle.Information, "Password Reset")
            con.Close()
            con.Dispose()
            Me.Close()
        End If
    End Sub
    Public Shared Function getEncryptedCode(ByVal inputString As String) As String
        Dim Hash As Byte() = New System.Security.Cryptography.SHA512Managed().ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(inputString))
        Dim outputString As New System.Text.StringBuilder()
        For i As Integer = 0 To Hash.Length - 1
            outputString.Append(Hash(i).ToString("x2"))
        Next
        Return outputString.ToString()
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        If (txtEmpId.Text = vbNullString) Then
            MsgBox("Please enter an Employee Id", MsgBoxStyle.Information, "Data Required")
            Exit Sub
        End If
        Dim cmdstr As New OleDbCommand
        'Dim strEmpid As String
        'strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & txtEmpId.Text & "'"
        cmdstr.ExecuteNonQuery()
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        dtAdapter.Fill(dtTable)
        If (dtTable.Rows.Count <= 0) Then
            MsgBox("No User Found", MsgBoxStyle.Information, "No Data Found")
            Exit Sub
        Else
            txtEmpName.Text = dtTable.Rows(0).Item(2).ToString
        End If
        con.Close()
        con.Dispose()

    End Sub
End Class