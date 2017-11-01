Imports System.Data.OleDb

Public Class frmCustomize

    Private Sub frmAddNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillReportingManager()
        FillUserRole()
        FillDepartment()
        FillReportingManagerEdit()
        FillUserRoleEdit()
        FillDepartmentEdit()
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.CenterToScreen()
        Me.TopMost = True
    End Sub

    Public Sub FillReportingManager()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT EmployeeName FROM tblManagers Where EmployeeName is not null and UserStatus='A' ORDER BY EmployeeName ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboReportingManager.Items.Add("Please Select")
        cboReportingManager.SelectedItem = ("Please Select")
        While sdr.Read()
            cboReportingManager.Items.Add(sdr.Item("EmployeeName").ToString)
        End While
        con.Close()
        con = Nothing

    End Sub

    Public Sub FillUserRole()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Role FROM tblOtherDetails Where Role is not null ORDER BY Role ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboUserRole.Items.Add("Please Select")
        cboUserRole.SelectedItem = ("Please Select")
        While sdr.Read()
            cboUserRole.Items.Add(sdr.Item("Role").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Public Sub FillDepartment()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Department FROM tblDepartments Where Department is not null ORDER BY Department ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboDept.Items.Add("Please Select")
        cboDept.SelectedItem = ("Please Select")
        While sdr.Read()
            cboDept.Items.Add(sdr.Item("Department").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        Dim strDoj As String
        Dim strDefPas As String
        strDefPas = getEncryptedCode("111").Trim().ToString
        Dim strNone As String
        strNone = "none"
        Dim stremail As String
        stremail = "no-email"
        strDoj = DojPicker.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdtxt As New OleDbCommand
        Dim cmdMgr As New OleDbCommand
        Dim cmdOthers As New OleDbCommand

        If (txtEmpId.Text = vbNullString) Then
            MsgBox("Please enter EmployeeID", MsgBoxStyle.Information, "Input required")
        ElseIf (txtEmpName.Text = vbNullString) Then
            MsgBox("Please enter Employee Name", MsgBoxStyle.Information, "Input required")
            'ElseIf (txtPwd.Text = vbNullString Or txtReenterPwd.Text = vbNullString) Then
            '    MsgBox("Password field cannot be blank", MsgBoxStyle.Information, "Password Blank")
            'ElseIf (txtPwd.Text <> txtReenterPwd.Text) Then
            '    MsgBox("Passwords do not match", MsgBoxStyle.Information, "Passwords not matching")
        ElseIf cboUserRole.Items.Count > 0 And cboUserRole.SelectedIndex = 0 Then
            MsgBox("Please select the role", MsgBoxStyle.Information, "Input required")
        ElseIf cboDept.Items.Count > 0 And cboDept.SelectedIndex = 0 Then
            MsgBox("Please select the depatment", MsgBoxStyle.Information, "Input required")
            'ElseIf cboReportingManager.Items.Count > 0 And cboReportingManager.SelectedIndex = 0 Then
            'MsgBox("Please select the reporting manager", MsgBoxStyle.Information, "Input required")
        ElseIf Checkduplicate() = True Then
            MsgBox("Employee ID already exists", MsgBoxStyle.Information, "Info Exists")
            Exit Sub
        Else
            cmdtxt.Connection = con
            cmdtxt.CommandText = "INSERT INTO tblLoginDetails ([EmployeeID],[EmployeeName],[Password], [Role],[Department],[LastLogin],[ReportingManager], [DOJ],[EmailId],[UserStatus]) " & _
                "VALUES ('" & txtEmpId.Text & "','" & txtEmpName.Text & "','" & strDefPas & "','" & cboUserRole.Text & "','" & cboDept.Text & "','" & strNone & "','" & cboReportingManager.Text & "','" & DojPicker.Text & "','" & stremail & "','A')"
            cmdtxt.ExecuteNonQuery()
            If (cboUserRole.Text = "Approver") Then
                cmdMgr.Connection = con
                cmdMgr.CommandText = "Insert into tblManagers ([EmployeeID],[EmployeeName],[UserStatus],[UserActionedStatus]) Values ('" & txtEmpId.Text & "','" & txtEmpName.Text & "','A','none')"
                cmdMgr.ExecuteNonQuery()
            Else
                Dim strUserLoginId As String
                strUserLoginId = frmLogin.txtLogin.Text
                cmdOthers.Connection = con
                cmdOthers.CommandText = "Insert into tblLeaveBalance ([EmployeeID],[EmployeeName],[Department],[LeaveBalance],[CompOffBal],[UserStatus],[ActionedBY],[ActionedOn],[LeaveAddedOn]) Values" & _
                    "('" & txtEmpId.Text & "','" & txtEmpName.Text & "','" & cboDept.SelectedItem & "','" & txtPLBal.Text & "','" & txtCOBal.Text & "','A','" & strUserLoginId & "','" & Date.Now() & "','" & Format(Date.Today(), "MM/yyyy") & "')"
                cmdOthers.ExecuteNonQuery()
            End If
            MsgBox("New User Added", MsgBoxStyle.Information, "User Added")
            con.Close()
            con.Dispose()
            ResetAll()
        End If
    End Sub
    Public Sub ResetAll()
        txtEmpId.Text = vbNullString
        txtEmpName.Text = vbNullString
        'txtPwd.Text = vbNullString
        'txtReenterPwd.Text = vbNullString
        cboDept.SelectedIndex = 0
        cboReportingManager.SelectedIndex = 0
        cboUserRole.SelectedIndex = 0
    End Sub

    Private Sub cmdDeleteEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteEmp.Click
        Dim con As New OleDbConnection
        Dim strUserLogin As String
        strUserLogin = frmLogin.txtLogin.Text
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        If (txtSempId.Text = vbNullString) Then
            MsgBox("Please enter the Employee Id", MsgBoxStyle.Information, "Information Required")

            Exit Sub
        ElseIf (txtSempId.Text = frmLogin.txtLogin.Text) Then
            MsgBox("User cannot delete itself", MsgBoxStyle.Information, "Execution Restricted")
            Exit Sub
        Else
            'Deletion of user changing the status to "D" but not deleting it completely
            Dim cmdtxt As OleDbCommand = New _
                          OleDbCommand("Update tblLoginDetails SET [UserStatus] = 'D',[UserActionedStatus]='" & strUserLogin & "' Where [EmployeeID]='" & txtSempId.Text & "'", con)
            cmdtxt.ExecuteNonQuery()
            Dim cmd As OleDbCommand = New _
                         OleDbCommand("Update tblLeaveBalance SET [UserStatus] = 'D',Where [EmployeeID]='" & txtSempId.Text & "'", con)
        End If
        If CheckManager() = True Then
            Dim cmdDelRepMgr As OleDbCommand = New _
                          OleDbCommand("Update tblManagers SET [UserStatus] = 'D',[UserActionedStatus]='" & strUserLogin & "' Where [EmployeeID]='" & txtSempId.Text & "'", con)
            cmdDelRepMgr.ExecuteNonQuery()
        End If
        MsgBox("User Deleted Successfully", MsgBoxStyle.Information, "User Deleted")
        con.Close()
        con.Dispose()

        ResetEditDelDetails()

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        If (txtSempId.Text = vbNullString) Then
            MsgBox("Please enter an Employee Id", MsgBoxStyle.Information, "Data Required")
            Exit Sub
        End If
        Dim cmdstr As New OleDbCommand
        'Dim strEmpid As String
        'strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & txtSempId.Text & "' and UserStatus = 'A'"
        cmdstr.ExecuteNonQuery()
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        dtAdapter.Fill(dtTable)
        If (dtTable.Rows.Count <= 0) Then
            MsgBox("No User Found", MsgBoxStyle.Information, "No Data Found")
            Exit Sub
        Else
            txtSempName.Text = dtTable.Rows(0).Item(2).ToString
            DojPicker1.Text = Date.Parse(dtTable.Rows(0).Item(8))
            cboDeptEdit.SelectedItem = dtTable.Rows(0).Item(5).ToString
            cboRoleEdit.SelectedItem = dtTable.Rows(0).Item(4).ToString
            cboManagerEdit.SelectedItem = dtTable.Rows(0).Item(7).ToString
        End If

        con.Close()
        con.Dispose()
    End Sub
    Public Sub FillReportingManagerEdit()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT EmployeeName FROM tblManagers where EmployeeName is Not null and UserStatus= 'A' ORDER BY EmployeeName Asc", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboManagerEdit.Items.Add("Please Select")
        cboManagerEdit.SelectedItem = ("Please Select")
        While sdr.Read()
            cboManagerEdit.Items.Add(sdr.Item("EmployeeName").ToString)
        End While
        con.Close()
        con = Nothing

    End Sub

    Public Sub FillUserRoleEdit()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Role FROM tblOtherDetails where Role is Not null ORDER BY Role ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboRoleEdit.Items.Add("Please Select")
        cboRoleEdit.SelectedItem = ("Please Select")
        While sdr.Read()
            cboRoleEdit.Items.Add(sdr.Item("Role").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Public Sub FillDepartmentEdit()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Department FROM tblDepartments where Department is Not null ORDER BY Department ASC ", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboDeptEdit.Items.Add("Please Select")
        cboDeptEdit.SelectedItem = ("Please Select")
        While sdr.Read()
            cboDeptEdit.Items.Add(sdr.Item("Department").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub
    Public Sub ResetEditDelDetails()
        txtSempId.Text = vbNullString
        txtSempName.Text = vbNullString
        DojPicker1.Text = Now()
        cboDeptEdit.SelectedIndex = 0
        cboManagerEdit.SelectedIndex = 0
        cboRoleEdit.SelectedIndex = 0
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        ResetEditDelDetails()
    End Sub

    Private Sub cmdAddDept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddDept.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        If (txtNewDept.Text = vbNullString) Then
            MsgBox("Please enter Department name", MsgBoxStyle.Information, "Info Missing")
            txtNewDept.Focus()
            Exit Sub
        Else
            Dim cmd As OleDbCommand = New _
            OleDbCommand("Insert into tblDepartments (Department) Values ('" & txtNewDept.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("New Department Added", MsgBoxStyle.Information, "Info Added")
            con.Close()
            con = Nothing
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Function Checkduplicate() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT * FROM tblLoginDetails Where EmployeeId = '" & txtEmpId.Text & "' and [UserStatus]='A'", con)
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)

        If dttable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

        con.Close()
        con.Dispose()
    End Function
    Public Shared Function getEncryptedCode(ByVal inputString As String) As String
        Dim Hash As Byte() = New System.Security.Cryptography.SHA512Managed().ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(inputString))
        Dim outputString As New System.Text.StringBuilder()
        For i As Integer = 0 To Hash.Length - 1
            outputString.Append(Hash(i).ToString("x2"))
        Next
        Return outputString.ToString()
    End Function

    'Private Sub btnLeaveSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim con As New OleDbConnection
    '    con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
    '    con.Open()

    '    If (txtLeaveEmpId.Text = vbNullString) Then
    '        MsgBox("Please enter an Employee Id/Name", MsgBoxStyle.Information, "Data Required")
    '        Exit Sub
    '    End If
    '    Dim cmdstr As New OleDbCommand
    '    'Dim strEmpid As String
    '    'strEmpid = frmLogin.txtLogin.Text
    '    cmdstr.Connection = con
    '    cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & txtLeaveEmpId.Text & "'"
    '    cmdstr.ExecuteNonQuery()
    '    Dim dtTable As New DataTable
    '    Dim dtAdapter As New OleDbDataAdapter(cmdstr)
    '    dtAdapter.Fill(dtTable)
    '    If (dtTable.Rows.Count <= 0) Then
    '        MsgBox("No User Found", MsgBoxStyle.Information, "No Data Found")
    '        Exit Sub
    '    Else
    '        txtLeaveEmpName.Text = dtTable.Rows(0).Item(2).ToString
    '        txtCurrentBalance.Text = LeaveBalance()
    '    End If

    '    con.Close()
    '    con.Dispose()
    'End Sub

    'Private Sub btnUpdateLeaveBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim con As New OleDbConnection
    '    con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
    '    con.Open()

    '    If (txtLeaveEmpName.Text = vbNullString) Then
    '        MsgBox("Please enter an Employee Name", MsgBoxStyle.Information, "Data Required")
    '        Exit Sub
    '    ElseIf (txtLeaveBal.Text = vbNullString) Then
    '        MsgBox(" Please enter the leave balance to be updated", MsgBoxStyle.Information, "Data Required")
    '        Exit Sub
    '    End If
    '    If CheckUser() = False Then
    '        MsgBox("User Not Found In Leave Balance Database", MsgBoxStyle.Information, "No User Found")
    '    ElseIf CheckUser() = True Then
    '        Dim cmd As OleDbCommand = New _
    '           OleDbCommand("Update tblLeaveBalance SET [LeaveBalance] = '" & txtLeaveBal.Text & "' Where [EmployeeID]='" & txtLeaveEmpId.Text & "'", con)
    '        cmd.ExecuteNonQuery()
    '        MsgBox("Leave balance updated", MsgBoxStyle.Information, "Update")
    '    ResetLeaveUpdate()
    'End If
    'Dim dtTable As New DataTable
    'Dim dtAdapter As New OleDbDataAdapter(cmd)
    'dtAdapter.Fill(dtTable)
    'If (dtTable.Rows.Count <= 0) Then

    '    Exit Sub
    'Else
    '    txtLeaveEmpName.Text = dtTable.Rows(0).Item(2).ToString
    'End If
    '    con.Close()
    '    con.Dispose()
    ''End Sub
    'Public Function LeaveBalance() As String
    '    Dim con As New OleDbConnection
    '    con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
    '    con.Open()
    '    Dim cmd As New OleDbCommand
    '    cmd.Connection = con
    '    cmd.CommandText = "Select LeaveBalance from tblLeaveBalance where EmployeeId = '" & txtLeaveEmpId.Text & "'"
    '    Dim dttable As New DataTable
    '    Dim dtAdapter As New OleDbDataAdapter(cmd)
    '    dtAdapter.Fill(dttable)
    '    Dim result As String
    '    If (dttable.Rows.Count = 0) Then
    '        MsgBox("Leave Details Not Found", MsgBoxStyle.Information, "No Data Found")
    '    Else
    '        result = dttable.Rows(0).Item(0).ToString
    '    End If
    '    Return result
    '    con.Close()
    '    con.Dispose()
    'End Function

    'Public Sub ResetLeaveUpdate()
    '    txtLeaveEmpId.Text = vbNullString
    '    txtLeaveEmpName.Text = vbNullString
    '    txtLeaveBal.Text = vbNullString
    '    txtCurrentBalance.Text = vbNullString
    'End Sub
    'Public Function CheckUser() As Boolean
    '    Dim con As New OleDbConnection
    '    con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
    '    con.Open()
    '    Dim cmd As New OleDbCommand
    '    cmd.Connection = con
    '    cmd.CommandText = "Select * from tblLeaveBalance where EmployeeId = '" & txtLeaveEmpId.Text & "'"
    '    Dim dttable As New DataTable
    '    Dim dtAdapter As New OleDbDataAdapter(cmd)
    '    dtAdapter.Fill(dttable)
    '    '  Dim Result As Boolean
    '    If (dttable.Rows.Count = 0) Then
    '        Return False
    '    Else
    '        Return True
    '    End If
    '    con.Close()
    '    con.Dispose()
    'End Function
    'Check this function for deleting manager as no value returende from the txtLeaveEMpId.text
    Public Function CheckManager() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select * from tblManagers where EmployeeId = '" & txtSempId.Text & "'"
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        '  Dim Result As Boolean
        If (dttable.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
        con.Close()
        con.Dispose()
    End Function
End Class