Imports System.Data.OleDb

Public Class frmLogin

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2


    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub
    Public Sub checklogin()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        cmdstr.Connection = con
        cmdstr.CommandText = "Select LastLogin from tblLoginDetails where EmployeeID = '" & txtLogin.Text & "' and [UserStatus] = 'A'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        Dim Result As String = ""
        Result = dtTable.Rows("0").Item("LastLogin")

        If (Result = "none") Then
            frmPwdResetUser.ShowDialog()
        End If
        Me.Hide()
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
    Public Sub AddLeavePerMonth()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim strUserLoginId As String
        strUserLoginId = txtLogin.Text

        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select EmployeeID,LeaveBalance from tblLeaveBalance where UserStatus = 'A'"
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        'checking the day of the month to add leaves
        If (checkifupdated() = True) Then
            Exit Sub
        ElseIf (checkifupdated() = False) Then
            'running a loop for all returned employee id in the datatable
            For Each row As DataRow In dttable.Rows
                Dim iEmpid As String
                iEmpid = row("EmployeeId")
                Dim dbLeave As Double
                dbLeave = row("LeaveBalance")
                Dim dbLeaveAdded As Double
                dbLeaveAdded = 2.5
                Dim dbNewBal As Double
                dbNewBal = Convert.ToDouble(dbLeave + dbLeaveAdded)
                Dim cmdupdate As New OleDbCommand
                cmdupdate.Connection = con
                cmdupdate.CommandText = "Update tblLeaveBalance SET LeaveBalance = '" & dbNewBal & "',[ActionedBY]= '" & strUserLoginId & "',[ActionedOn] = '" & Date.Now() & "', [LeaveAddedOn] = '" & Format(Date.Today(), "MM/yyyy") & "' Where EmployeeId = '" & iEmpid & "'"
                cmdupdate.ExecuteNonQuery()
            Next row
        End If
        con.Close()
        con.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Public Function checkifupdated() As Boolean
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand

        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select LeaveAddedOn from tblLeaveBalance"
        Dim dtTable As New DataTable
        Dim dtadapter As New OleDbDataAdapter(cmd)
        dtadapter.Fill(dtTable)
        Dim result As String
        result = dtTable.Rows(0).Item(0)

        'checking if the leave last added in same month or differenet

        If (result = Format(Date.Today, "MM/yyy")) Then
            'MsgBox(" Leave Laready added done")
            Return True
        Else
            'MsgBox("notdone")
            Return False
        End If


        'dtLeaveAdded = dtTable.Rows(0).Item(0).ToString()
        'dtLeaveAdded.ToString("MM")
        'format = "MM"
        'result = Date.Parse(dtLeaveAdded, format)


        'Dim mnthToday As Integer
        'mnthToday = Date.Now.Date.Month

        'Dim dayToday As Integer
        'dayToday = Date.Now.Date.Day
        'If (mnthToday <> 1) Then
        'End If

    End Function

    Private Sub cmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim con As New OleDbConnection
        Dim strPasswordEncrypted As String
        strPasswordEncrypted = getEncryptedCode(txtPwd.Text.Trim().ToString)
        Dim strUdlPath = "H:\Kode-Rahul\Connection\Connection.udl"
        If (System.IO.File.Exists(strUdlPath)) Then
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        Else
            MsgBox("Connection file NOT found, closing application", MsgBoxStyle.Information, "File not found")
            Application.Exit()
            Exit Sub

        End If

        Dim cmdstr As New OleDbCommand
        If (txtLogin.Text = vbNullString Or txtPwd.Text = vbNullString) Then
            MsgBox("Employee ID or Password Cannot be blank", MsgBoxStyle.Information, "Info. Required")
        Else
            con.Open()
            cmdstr.Connection = con
            cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & txtLogin.Text & "' and Password ='" & strPasswordEncrypted & "' and UserStatus = 'A'"
            Dim dtTable As New DataTable

            Dim dtAdapter As New OleDbDataAdapter(cmdstr)
            cmdstr.ExecuteNonQuery()
            dtAdapter.Fill(dtTable)

            If (dtTable.Rows.Count = "0") Then
                MsgBox("Incorrect Employee Id Or Password or User not found", MsgBoxStyle.Information, "Incorrect Login Details")

            ElseIf (dtTable.Rows("0").Item("Role")) = "Approver" Then
                If (dtTable.Rows(0).Item("EmailId")) = "no-email" Then
                    MsgBox("No Email Id configured. Please set an Email id", MsgBoxStyle.Information, "Info. Required")
                End If
                'AddLeavePerMonth()
                checklogin()
                frmDecider.Show()
            ElseIf (dtTable.Rows("0").Item("Role")) = "SuperUser" Or dtTable.Rows(0).Item("Role") = "User" Then
                checklogin()
                frmApplier.Show()
            End If
        End If
        con.Close()
        con.Dispose()
        AddLeavePerMonth()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
