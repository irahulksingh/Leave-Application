Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32

Public Enum MSApplications1
    Outlook
End Enum

Public Class frmApplier
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        grpApplyLeave.Enabled = False
        grpHalfDay.Enabled = False
        grpCompOff.Enabled = False
        rbPlLeave.Checked = False
        rbCompOff.Checked = False
        rbHalfDay.Checked = False

        FillReportingManager()
        FillDataGridLeaveDetails()
        FillHalfDayReportingManager()
        FillCompOffReportingManager()
        LeaveBalance()
        CompOffBalance()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        lblEmpId.Text = dtTable.Rows("0").Item("EmployeeID")
        lblEmpName.Text = dtTable.Rows("0").Item("EmployeeName")
        lblDept.Text = dtTable.Rows("0").Item("Department")
        lblUser.Text = "Welcome" + " " + dtTable.Rows("0").Item("EmployeeName")
        If (dtTable.Rows(0).Item("Role") = "User") Then
            CustomizeToolStripMenuItem4.Visible = False
            ReportsToolStripMenuItem6.Visible = False
            'ResetPasswordToolStripMenuItem.Visible = False

        End If
        con.Close()
        con.Dispose()
    End Sub

    Public Sub FillReportingManager()
        Dim strUserName As String
        strUserName = frmLogin.txtLogin.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT EmployeeName FROM tblManagers Where EmployeeID <> '" & strUserName & "' and EmployeeName is not null and UserStatus ='A' ORDER BY EmployeeName ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboReportingManager.Items.Add("Please Select")
        cboReportingManager.SelectedItem = ("Please Select")
        While sdr.Read()
            cboReportingManager.Items.Add(sdr.Item("EmployeeName").ToString)
        End While
        con.Close()
        con = Nothing

    End Sub

    Public Sub FillDataGridLeaveDetails()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where [EmployeeId] = '" & strEmpid & "' and [Delete] <> 'D' "
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtGridLeavedetails.DataSource = dtTable1
        dtGridLeavedetails.AutoGenerateColumns = False
        dtGridLeavedetails.Columns(0).Visible = False
        dtGridLeavedetails.Columns(14).Visible = False
        dtGridLeavedetails.Columns(15).Visible = False
        dtGridLeavedetails.Columns(11).Visible = False
        dtGridLeavedetails.Columns(12).Visible = False
        dtGridLeavedetails.Columns(1).HeaderText = "Emp ID"
        dtGridLeavedetails.Columns(2).HeaderText = "Name"
        dtGridLeavedetails.Columns(3).HeaderText = "Dept."
        dtGridLeavedetails.Columns(4).HeaderText = "Rpt. Mgr."
        dtGridLeavedetails.Columns(5).HeaderText = "Start-Date"
        dtGridLeavedetails.Columns(6).HeaderText = "End-Date"
        dtGridLeavedetails.Columns(7).HeaderText = "CO-for Date"
        dtGridLeavedetails.Columns(8).HeaderText = "Total-Leave"
        dtGridLeavedetails.Columns(9).HeaderText = "Comments"
        dtGridLeavedetails.Columns(10).HeaderText = "Status"
        dtGridLeavedetails.Columns(13).HeaderText = "App.Comments"
        con.Close()
        con.Dispose()
    End Sub
    Public Sub ResetAll()
        txtComment.Text = vbNullString
        txtTotalLeave.Text = vbNullString
        cboReportingManager.SelectedIndex = 0
    End Sub

    Private Sub cmdApplyLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyLeave.Click
        Dim strStartDate As String
        Dim strEndDate As String
        strStartDate = DateTimePicker1.Text
        strEndDate = DateTimePicker2.Text

        ' CHECK THIS CODE FOR VALIDATIN OF MORE THEN 5 DAYS APPLICATION
        Dim dtStartDate, dtEndDate As Date
        dtStartDate = DateTimePicker1.Text
        dtEndDate = DateTimePicker2.Text

        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdtxt As New OleDbCommand
        If (((dtEndDate.Subtract(dtStartDate).TotalDays) + 1) > 5) Then
            MsgBox("Leave's more than 5 days cannot be applied in continuity, Please Break your leaves and exclude your week off's", MsgBoxStyle.Exclamation, "Leaves more than 5 day's")
            Exit Sub
        End If
        If CheckLeaveDates() = True Then
            MsgBox("Leave already applied for dates choosen,Please review", MsgBoxStyle.Information, "Duplicate Request")
            Exit Sub
        End If
        If (txtTotalLeave.Text <= 0) Then
            MsgBox("Incorrect start day and end day of leaves", MsgBoxStyle.Information, "Incorrect Dates")
            Exit Sub
        ElseIf txtTotalLeave.Text = vbNullString Then
            MsgBox("Please select the start day and end day of your leave", MsgBoxStyle.Information, "Selection required")
        ElseIf cboReportingManager.Items.Count > 0 And cboReportingManager.SelectedIndex = 0 Then
            MsgBox("Please select your reporting manager", MsgBoxStyle.Information, "Selection required")
        Else
            cmdtxt.Connection = con
            cmdtxt.CommandText = "INSERT INTO tblLeaveDetails ([EmployeeID],[EmployeeName],[Department],[ReportingManager],[LeaveStartDate], [LeaveEndDate],[NoOfLeaveDays],[Comments],[LeaveID],[Delete],[TypeOfLeave])" & _
               "VALUES ('" & lblEmpId.Text & "','" & lblEmpName.Text & "','" & lblDept.Text & "','" & cboReportingManager.Text & "','" & strStartDate & "','" & strEndDate & "','" & txtTotalLeave.Text & "','" & txtComment.Text & "','" & lblEmpId.Text + Now() & "','A','PL')"

            cmdtxt.ExecuteNonQuery()
            MsgBox("Leave applied successfully", MsgBoxStyle.Information, "Leave Applied")
            con.Close()
            con.Dispose()
            sendmail()
            FillDataGridLeaveDetails()
            ResetAll()
        End If
        con.Close()
        con.Dispose()

    End Sub

    Private Sub cmdDeleteLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteLeave.Click
        If (dtGridLeavedetails.SelectedRows.Count = 0) Then
            MsgBox("Please select an application to delete", MsgBoxStyle.Information, "Selection required")
            Exit Sub
        End If
        Dim i As Integer
        Dim result = MessageBox.Show("Delete Leave Application", "Delete Application", MessageBoxButtons.OKCancel)
        If (dtGridLeavedetails.Rows.Count <= 0) Then
            MsgBox("No records to delete", MsgBoxStyle.Information, "No Data")
            Exit Sub

        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else

            i = dtGridLeavedetails.CurrentRow.Index
            txtLeaveId.Text = dtGridLeavedetails.Item(12, i).Value
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr1 As New OleDbCommand
            cmdstr1.Connection = con
            If LeaveStatus() = "Approved" Or LeaveStatus() = "Declined" Or LeaveStatus() = "Cancelled" Then
                MsgBox("Leave STATUS changed,cannot be deleted", MsgBoxStyle.Information, "Not allowed")
            ElseIf LeaveStatus() = "" Then
                cmdstr1.CommandText = "Update tblLeaveDetails Set [Delete] = 'D' where  LeaveID = '" & txtLeaveId.Text & "'"
                cmdstr1.ExecuteNonQuery()
            End If
            con.Close()
            con.Dispose()
            FillDataGridLeaveDetails()

            con.Close()
            con.Dispose()
        End If
    End Sub
    Public Sub sendmail()
        'Checking the email id of reporting manager
        Dim conrep As New OleDbConnection
        Dim strEmailId As String
        conrep.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        conrep.Open()
        Dim cmd As OleDbCommand = New OleDbCommand
        cmd.Connection = conrep
        cmd.CommandText = "Select [Emailid] from tblLogindetails where EmployeeName = '" & cboReportingManager.SelectedItem & "'"
        Dim dtEmailId As New DataTable
        Dim dtEmailAdapter As New OleDbDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        dtEmailAdapter.Fill(dtEmailId)
        If Process.GetProcessesByName("Outlook").Length < 1 Then
            MsgBox("Outlook not running, No mail sent, Please start outlook next time before applying for leave, Kindly inform your manager about your leave application", MsgBoxStyle.Information, "No mail send")
            Exit Sub
        End If
        If (dtEmailId.Rows(0).Item(0) = "no-email") Then
            MsgBox("Manager email id not available, Kindly contact your manager and inform him", MsgBoxStyle.Information, "Data un-available")
            Exit Sub
        Else
            strEmailId = dtEmailId.Rows(0).Item(0)
        End If
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLeaveDetails where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)

        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        oApp = New Microsoft.Office.Interop.Outlook.Application
        Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem

        oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        oMsg.Subject = "Leave Application from" + " " + dtTable.Rows(0).Item(2) + " " + "for" + " " + txtTotalLeave.Text + " " + "days."
        If (txtTotalLeave.Text > 1) Then
            oMsg.Body = dtTable.Rows(0).Item(2) + " " + "has applied for '" & txtTotalLeave.Text & "' days of leaves from '" & DateTimePicker1.Text & "' to '" & DateTimePicker2.Text & "'. Kindly review it on the leave tracker application"
        Else
            oMsg.Body = dtTable.Rows(0).Item(2) + " " + "has applied for '" & txtTotalLeave.Text & "' day of leave for '" & DateTimePicker1.Text & "'. Kindly review it on the leave tracker application"
        End If

        oMsg.To = strEmailId
        oMsg.Send()
        MsgBox("Mail Sent to manager", MsgBoxStyle.Information, "Confirmation")
        oApp = Nothing
        oMsg = Nothing
        con.Close()
        con.Dispose()

    End Sub

    Public Sub LeaveBalance()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLeaveBalance where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        If (dtTable.Rows.Count = 0) Then
            Exit Sub
        End If
        'ElseIf (TypeOfLeaveAppliedfor() = "PL") Then
        lblLeaveBalance.Text = dtTable.Rows(0).Item(3).ToString
        ' ElseIf (TypeOfLeaveAppliedfor() = "Comp-Off") Then
        lblCompOff.Text = dtTable.Rows(0).Item(4).ToString
        'End If
        con.Close()
        con.Dispose()
    End Sub
    Public Sub CompOffBalance()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select CompOffBal from tblLeaveBalance where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        If (dtTable.Rows.Count = 0) Then
            Exit Sub
        Else
            lblCompOff.Text = dtTable.Rows(0).Item(0).ToString
        End If
        con.Close()
        con.Dispose()
    End Sub

    Private Sub btnApplyHalfDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyHalfDay.Click
        Dim strHalfDayDate As String
        strHalfDayDate = dtPickerHalfDay.Text
        Dim con As New OleDbConnection
        Dim dHalfDay As Double
        dHalfDay = "0.5"
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdtxt As New OleDbCommand
        If CheckIfHalfDayAlreadyApplied() = True Then
            MsgBox("Leave already applied for dates choosen, Please Review", MsgBoxStyle.Information, "Duplicate Request")
            Exit Sub
        End If
        If cboHalfDayRepMgr.Items.Count > 0 And cboHalfDayRepMgr.SelectedIndex = 0 Then
            MsgBox("Please select your reporting manager", MsgBoxStyle.Information, "Selection required")
        Else
            cmdtxt.Connection = con
            cmdtxt.CommandText = "INSERT INTO tblLeaveDetails ([EmployeeID],[EmployeeName],[Department],[ReportingManager],[LeaveStartDate], [LeaveEndDate],[NoOfLeaveDays],[Comments],[LeaveID],[Delete],[TypeOfLeave])" & _
               "VALUES ('" & lblEmpId.Text & "','" & lblEmpName.Text & "','" & lblDept.Text & "','" & cboHalfDayRepMgr.Text & "','" & strHalfDayDate & "','" & strHalfDayDate & "','" & dHalfDay & " ','" & txtComment.Text & "','" & lblEmpId.Text + Now() & "','A','HD')"

            cmdtxt.ExecuteNonQuery()
            MsgBox("Leave applied successfully", MsgBoxStyle.Information, "Leave Applied")
            con.Close()
            con.Dispose()
            SendmailHalfDay()
            FillDataGridLeaveDetails()
            ResetAll()
        End If
        con.Close()
        con.Dispose()

    End Sub
    Public Sub FillHalfDayReportingManager()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT EmployeeName FROM tblManagers Where EmployeeName is not null and UserStatus ='A' ORDER BY EmployeeName ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboHalfDayRepMgr.Items.Add("Please Select")
        cboHalfDayRepMgr.SelectedItem = ("Please Select")
        While sdr.Read()
            cboHalfDayRepMgr.Items.Add(sdr.Item("EmployeeName").ToString)
        End While
        con.Close()
        con = Nothing

    End Sub
    Public Sub SendmailHalfDay()
        'Checking the email id of reporting manager
        Dim conrep As New OleDbConnection
        Dim strEmailId As String
        conrep.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        conrep.Open()
        Dim cmd As OleDbCommand = New OleDbCommand
        cmd.Connection = conrep
        cmd.CommandText = "Select [Emailid] from tblLoginDetails where EmployeeName = '" & cboHalfDayRepMgr.SelectedItem & "'"
        Dim dtEmailId As New DataTable
        Dim dtEmailAdapter As New OleDbDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        dtEmailAdapter.Fill(dtEmailId)
        If Process.GetProcessesByName("Outlook").Length < 1 Then
            MsgBox("Outlook not running, No mail sent, Please start outlook next time before applying for leave, Kindly inform your manager about your leave application", MsgBoxStyle.Information, "No mail send")
            Exit Sub
        End If
        If (dtEmailId.Rows(0).Item("EmailID") = "no-email") Then
            MsgBox("Manager email id not available, Kindly contact your manager and inform him", MsgBoxStyle.Information, "Data un-available")
            Exit Sub
        Else
            strEmailId = dtEmailId.Rows(0).Item(0)
        End If
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLeaveDetails where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)

        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        oApp = New Microsoft.Office.Interop.Outlook.Application
        Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem

        oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        oMsg.Subject = "Leave Application from" + " " + dtTable.Rows(0).Item(2) + " " + "for half day."
        'If (chkHalfDay.Checked = True) Then
        oMsg.Body = dtTable.Rows(0).Item(2) + " " + "has applied for Half day of leaves on '" & dtPickerHalfDay.Text & "'. Kindly review it on the leave tracker application"

        'End If
        oMsg.To = strEmailId
        oMsg.Send()
        MsgBox("Mail Sent to manager", MsgBoxStyle.Information, "Confirmation")
        oApp = Nothing
        oMsg = Nothing
        con.Close()
        con.Dispose()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If (dtGridLeavedetails.SelectedRows.Count = 0) Then
            MsgBox("Please select an application to Cancel", MsgBoxStyle.Information, "Selection Required")
            Exit Sub
        End If
        Dim i As Integer
        Dim strEmpId As String
        strEmpId = frmLogin.txtLogin.Text
        Dim result = MessageBox.Show("Cancel Leave Application", "Cancel Application", MessageBoxButtons.OKCancel)
        If (dtGridLeavedetails.Rows.Count <= 0) Then
            MsgBox("No records to Cancel", MsgBoxStyle.Information, "No Data")
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            i = dtGridLeavedetails.CurrentRow.Index
            txtLeaveId.Text = dtGridLeavedetails.Item(12, i).Value
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr1 As New OleDbCommand
            'Updating the Leaves Table that the leave is cancelled
            cmdstr1.Connection = con
            'If LeaveStatus() = "not-allowed" Then
            '    MsgBox("Leave status changed cannot be deleted", MsgBoxStyle.Information, "Not allowed")
            If LeaveStatus() = "" Then
                MsgBox("Leave status not updated, Try deleting the application", MsgBoxStyle.Information, "Cannot Cancel")
                Exit Sub
            ElseIf LeaveStatus() = "Declined" Or LeaveStatus() = "Cancelled" Then
                MsgBox("Leave declined/cancelled cannot be cancelled", MsgBoxStyle.Information, "Cannot cancel")
                Exit Sub
                'ElseIf LeaveStatus() = "Cancelled" Then
                '    MsgBox("Leave already 'Cancelled' cannot be cancelled", MsgBoxStyle.Information, "Cannot cancel")
                '    Exit Sub
            End If
            If Checkdate() = True Then
                MsgBox("Cancellation allowed 2 days before leave,Cancellation not allowed", MsgBoxStyle.Information, "Action Not Allowed")
                Exit Sub
            End If
            If LeaveStatus() = "Approved" Then
                cmdstr1.CommandText = "Update tblLeaveDetails Set [Delete] = 'C',[Status]='Cancelled' where  LeaveID = '" & txtLeaveId.Text & "'"
                cmdstr1.ExecuteNonQuery()
                'Updating the Balance table and reverting the number of leaves applied for
                Dim cmdstr2 As New OleDbCommand
                Dim cmdstr3 As New OleDbCommand
                Dim RevertLeave As Double
                RevertLeave = RevertBalanceLeave()
                Dim TotalLeaveBal As Double
                TotalLeaveBal = TotalLeave()
                Dim intTotalLeave As Double
                intTotalLeave = Convert.ToDouble(RevertLeave + TotalLeaveBal)
                cmdstr2.Connection = con
                If (TypeOfLeaveAppliedfor() = "PL") Then
                    cmdstr2.CommandText = "Update tblLeaveBalance Set [LeaveBalance] = '" & intTotalLeave & "' where  EmployeeID = '" & strEmpId & "'"
                    cmdstr2.ExecuteNonQuery()
                    MsgBox("Leave Application Cancelled", MsgBoxStyle.Information, "Application Cancelled")
                ElseIf (TypeOfLeaveAppliedfor() = "Comp-Off") Then
                    cmdstr3.Connection = con
                    cmdstr3.CommandText = "Update tblLeaveBalance Set [CompOffBal] = '" & intTotalLeave & "' where  EmployeeID = '" & strEmpId & "'"
                    cmdstr3.ExecuteNonQuery()
                    MsgBox("Leave Application Cancelled", MsgBoxStyle.Information, "Application Cancelled")
                End If
                con.Close()
                con.Dispose()
                LeaveBalance()
            ElseIf LeaveStatus() = "Declined" Then
                MsgBox("Leave declined, cannot be cancelled", MsgBoxStyle.Information, "Cannot Action")
            End If
            FillDataGridLeaveDetails()
        End If
    End Sub


    Public Function LeaveStatus() As String
        Dim Con As OleDbConnection = New OleDbConnection
        Con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        Con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand
        cmd.Connection = Con
        cmd.CommandText = "Select * from tblLeaveDetails where LeaveID='" & txtLeaveId.Text & "'"
        Dim dtTable As New DataTable
        Dim dtAdaptor As New OleDbDataAdapter(cmd)
        dtAdaptor.Fill(dtTable)
        Dim result As String
        result = dtTable.Rows(0).Item(10).ToString
        Return result
        Con.Close()
        Con.Dispose()
    End Function
    Public Function RevertBalanceLeave() As Double
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select * from tblLeaveDetails where [LeaveId] = '" & txtLeaveId.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        Dim Result As Double
        Result = dttable.Rows(0).Item(8)
        Return Result
        con.Close()
        con.Dispose()
    End Function

    Public Function TotalLeave() As Double
        Dim strEmpID As String
        strEmpID = frmLogin.txtLogin.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select * from tblLeaveBalance where [EmployeeID] = '" & strEmpID & "'"
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        Dim Result As Double
        If (TypeOfLeave() = "PL") Then
            Result = dttable.Rows(0).Item(3)
        ElseIf (TypeOfLeave() = "Comp-Off") Then
            Result = dttable.Rows(0).Item(4)
        End If
        Return Result
        con.Close()
        con.Dispose()
    End Function

    Public Function Checkdate() As Boolean
        Dim strEmpID As String
        strEmpID = frmLogin.txtLogin.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select LeaveStartDate from tblLeaveDetails where [LeaveID] = '" & txtLeaveId.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        Dim Result As Date
        Result = Date.Parse(dttable.Rows(0).Item(0))
        If (Result.AddDays(-1) <= Date.Now.ToString) Then
            Return True
        Else
            Return False
        End If
        con.Close()
        con.Dispose()
    End Function

    Private Sub btnApplyCompOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyCompOff.Click
        Dim strCompOffDate As String
        Dim strCompOffAvailed As String
        Dim dCompOff As String
        Dim con As New OleDbConnection
        Dim cmdtxt As New OleDbCommand
        Dim cmd As New OleDbCommand


        strCompOffDate = CompOffDtPk.Text
        strCompOffAvailed = CompOffDtPk2.Text
        dCompOff = "1"
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        If cboCompOffRepMgr.Items.Count > 0 And cboCompOffRepMgr.SelectedIndex = 0 Then
            MsgBox("Please select your reporting manager", MsgBoxStyle.Information, "Selection required")
        ElseIf (Date.Today.ToString() < Convert.ToDateTime(CompOffDtPk.Text)) Then
            MsgBox("You cannot apply for comp-off before earning it", MsgBoxStyle.Exclamation, "Leave not available")
            Exit Sub
        ElseIf (CheckDateExists() = False) Then
            MsgBox("Compoff date applied for does not exists, Please review", MsgBoxStyle.Exclamation, "Incorrect date")
            Exit Sub
        ElseIf (CheckiFTaken() = False) Then
            MsgBox("Leave already applied for dates choosen,Please review", MsgBoxStyle.Exclamation, "Duplicate Request")
            Exit Sub
        Else
            cmdtxt.Connection = con
            cmdtxt.CommandText = "INSERT INTO tblLeaveDetails ([EmployeeID],[EmployeeName],[Department],[ReportingManager],[LeaveStartDate], [LeaveEndDate],[CompOffFor],[NoOfLeaveDays],[Comments],[LeaveID],[Delete],[TypeOfLeave])" & _
            "VALUES ('" & lblEmpId.Text & "','" & lblEmpName.Text & "','" & lblDept.Text & "','" & cboCompOffRepMgr.Text & "','" & strCompOffAvailed & "','" & strCompOffAvailed & "','" & strCompOffDate & "','" & dCompOff & " ','" & txtCompOffCom.Text & "','" & lblEmpId.Text + Now() & "','A','Comp-Off')"
            cmdtxt.ExecuteNonQuery()
            MsgBox("Leave applied successfully", MsgBoxStyle.Information, "Leave Applied")
            SendmailCompOff()
            FillDataGridLeaveDetails()
            ResetAll()
        End If
        con.Close()
        con.Dispose()
    End Sub
    Public Sub FillCompOffReportingManager()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT EmployeeName FROM tblManagers Where EmployeeName is not null and UserStatus ='A' ORDER BY EmployeeName ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboCompOffRepMgr.Items.Add("Please Select")
        cboCompOffRepMgr.SelectedItem = ("Please Select")
        While sdr.Read()
            cboCompOffRepMgr.Items.Add(sdr.Item("EmployeeName").ToString)
        End While
        con.Close()
        con = Nothing

    End Sub
    Public Sub SendmailCompOff()
        'Checking the email id of reporting manager
        Dim conrep As New OleDbConnection
        Dim strEmailId As String
        conrep.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        conrep.Open()
        Dim cmd As OleDbCommand = New OleDbCommand
        cmd.Connection = conrep
        cmd.CommandText = "Select [Emailid] from tblLoginDetails where EmployeeName = '" & cboCompOffRepMgr.SelectedItem & "'"
        Dim dtEmailId As New DataTable
        Dim dtEmailAdapter As New OleDbDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        dtEmailAdapter.Fill(dtEmailId)
        If Process.GetProcessesByName("Outlook").Length < 1 Then
            MsgBox("Outlook not running, No mail sent, Please start outlook next time before applying for leave, Kindly inform your manager about your leave application", MsgBoxStyle.Information, "No Mail Send")
            Exit Sub
        End If
        If (dtEmailId.Rows(0).Item(0) = "no-email") Then
            MsgBox("Manager email id not available, Kindly contact your manager and inform him", MsgBoxStyle.Information, "Data un-available")
            Exit Sub
        Else
            strEmailId = dtEmailId.Rows(0).Item(0)
        End If
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLeaveDetails where EmployeeId = '" & strEmpid & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)

        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        oApp = New Microsoft.Office.Interop.Outlook.Application
        Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem

        oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        oMsg.Subject = "Leave Application from" + " " + dtTable.Rows(0).Item(2) + " " + "for a day."
        oMsg.Body = dtTable.Rows(0).Item(2) + " " + "has applied for a leave on '" & CompOffDtPk1.Text & "'. Kindly review it on the leave tracker application"
        oMsg.To = strEmailId
        oMsg.Send()
        MsgBox("Mail Sent to manager", MsgBoxStyle.Information, "Confirmation")
        oApp = Nothing
        oMsg = Nothing
        con.Close()
        con.Dispose()

    End Sub

    'Checking if that date applied by user exists as a comp off or not.
    Public Function CheckDateExists() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT CompOffDate FROM tblCompOff where compoffdate ='" & CompOffDtPk.Text & "'", con)
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdaptor As New OleDbDataAdapter(cmd)
        dtAdaptor.Fill(dttable)
        If (dttable.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
        con.Close()
        con = Nothing
    End Function

    'Checking that if the user has already taken leave for that comp off or not.
    Public Function CheckiFTaken() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT * FROM tblLeaveDetails where CompOffFor ='" & CompOffDtPk.Text & "' and [Status] IS NULL and EmployeeID = '" & frmLogin.txtLogin.Text & "'", con)
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdaptor As New OleDbDataAdapter(cmd)
        dtAdaptor.Fill(dttable)
        If (dttable.Rows.Count = 0) Then
            Return True
        Else
            Return False
        End If
        con.Close()
        con = Nothing
    End Function

    Public Function TypeOfLeaveAppliedfor() As String
        ' Check this code for error's
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT TypeOfLeave FROM tblLeaveDetails where LeaveId ='" & txtLeaveId.Text & "'", con)
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdaptor As New OleDbDataAdapter(cmd)
        dtAdaptor.Fill(dttable)
        Dim strTypeOfLeave
        strTypeOfLeave = dttable.Rows(0).Item(0).ToString
        Return strTypeOfLeave
        con.Close()
        con = Nothing
    End Function
    Public Function TypeOfLeave() As String
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT TypeOfLeave FROM tblLeaveDetails where LeaveId ='" & txtLeaveId.Text & "'", con)
        cmd.ExecuteNonQuery()
        Dim dttable As New DataTable
        Dim dtAdaptor As New OleDbDataAdapter(cmd)
        dtAdaptor.Fill(dttable)
        Dim strTypeOfLeave
        strTypeOfLeave = dttable.Rows(0).Item(0).ToString
        Return strTypeOfLeave
        con.Close()
        con = Nothing
    End Function

    Public Function CheckLeaveDates() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select LeaveStartDate,LeaveEndDate from tblLeaveDetails where EmployeeID = '" & lblEmpId.Text & "' AND [Delete] = 'A'"

        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)

        Dim strLeaveStartDate, strLeaveEndDate As String
        strLeaveEndDate = DateTimePicker2.Text
        strLeaveStartDate = DateTimePicker1.Text
        ' Checking if leave applied for the date already "Duplication"
        Dim i As Integer
        i = dttable.Rows.Count
        For k As Integer = 0 To (i - 1)
            If strLeaveStartDate <= dttable.Rows(k).Item("LeaveStartDate").ToString() And strLeaveEndDate >= dttable.Rows(k).Item("LeaveEndDate").ToString() Then
                Return True
            End If
        Next
    End Function

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim EndDate As Date
        Dim Startdate As Date
        Startdate = DateTimePicker1.Text
        EndDate = DateTimePicker2.Text

        Dim iDifference As Integer

        iDifference = (EndDate.Subtract(Startdate).TotalDays) + 1
        txtTotalLeave.Text = iDifference
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim EndDate As Date
        Dim Startdate As Date
        Startdate = DateTimePicker1.Text
        EndDate = DateTimePicker2.Text

        Dim iDifference As Integer

        iDifference = (EndDate.Subtract(Startdate).TotalDays) + 1
        txtTotalLeave.Text = iDifference
    End Sub
    Public Function CheckIfHalfDayAlreadyApplied() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select LeaveStartDate from tblLeaveDetails where EmployeeID = '" & lblEmpId.Text & "' AND [Delete] = 'A' And [TypeOfLeave] = 'HD'"

        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)

        Dim strLeaveStartDate As String
        strLeaveStartDate = dtPickerHalfDay.Text
        ' Checking if leave applied for the date already "Duplication"
        Dim i As Integer
        i = dttable.Rows.Count
        For k As Integer = 0 To (i - 1)
            If strLeaveStartDate = dttable.Rows(k).Item("LeaveStartDate").ToString() Then
                Return True
            End If
        Next
    End Function

    Private Sub rbPlLeave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPlLeave.CheckedChanged
        grpApplyLeave.Enabled = True
        grpHalfDay.Enabled = False
        grpCompOff.Enabled = False
    End Sub

    Private Sub rbHalfDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHalfDay.CheckedChanged
        grpApplyLeave.Enabled = False
        grpHalfDay.Enabled = True
        grpCompOff.Enabled = False
    End Sub

    Private Sub rbCompOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCompOff.CheckedChanged
        grpApplyLeave.Enabled = False
        grpHalfDay.Enabled = False
        grpCompOff.Enabled = True
    End Sub

    Private Sub TestToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem2.Click
        frmPwdResetUser.Show()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub CustomizeToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem5.Click
        frmCustomize.Show()
    End Sub

    Private Sub AddCompOffToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCompOffToolStripMenuItem1.Click
        frmCompOffUpdater.Show()
    End Sub

    Private Sub LeaveUpdatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveUpdatToolStripMenuItem.Click
        frmLeaveUpdater.Show()
    End Sub

    Private Sub ResetUserPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPwdResetAdmin.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem7.Click
        frmReportsTab.Show()
    End Sub

    Private Sub ResetUserPasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetUserPasswordToolStripMenuItem1.Click
        frmPwdResetAdmin.Show()
    End Sub
End Class