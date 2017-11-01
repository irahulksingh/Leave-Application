Imports System.Data.OleDb
Public Class frmApprover

    Dim strUserLoginId As String = frmLogin.txtLogin.Text

    Private Sub frmLeaveApplied_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        dtGridViewLeaveDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CheckEmailID()
        FillDataGrid()
        FillDecision()
        lblRequestInfo.Text = RequestPending()
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
        lblUser.Text = "Welcome" + " " + Result
        con.Close()
        con.Dispose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPwdResetUser.ShowDialog()
        'frmPwdResetUser.TopMost = True
    End Sub
    Private Sub AddNewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCustomize.ShowDialog()
        frmCustomize.Refresh()
    End Sub
    Private Sub ReLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmLogin.Show()
    End Sub


    Private Sub dtGridViewLeaveDetails_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtGridViewLeaveDetails.MouseClick
        If (dtGridViewLeaveDetails.Rows.Count <= 0) Then
            MsgBox("No Applications To Display", MsgBoxStyle.Exclamation, " No Data")
            Exit Sub
        Else
            Dim i As Integer
            i = dtGridViewLeaveDetails.CurrentRow.Index
            Me.txtLeaveId.Text = dtGridViewLeaveDetails.Item(12, i).Value
            Me.txtEmpId.Text = dtGridViewLeaveDetails.Item(1, i).Value
            Me.txtEmpName.Text = dtGridViewLeaveDetails.Item(2, i).Value
            Me.lblAppName.Text = fnLeaveBalance().ToString + " " + "Day/Days" '+ " " + fnLeaveBalance().ToString + " " + "Day/Days"
            Me.lblCompOffDetails.Text = fnCompOffBal().ToString() + " " + "Day/Days" '+ " " + fnCompOffBal().ToString() + " " + "Day/Days"
            Me.lblApplicantName.Text = dtGridViewLeaveDetails.Item(2, i).Value
            Me.txtTypeOfLeave.Text = dtGridViewLeaveDetails.Item(15, i).Value
            'lblUserInfo.Text = 
            Me.lblUserHistory.Text = dtGridViewLeaveDetails.Item(2, i).Value
            Me.txtLeaveStartDate.Text = dtGridViewLeaveDetails.Item(5, i).Value
            Me.txtLeaveEnddate.Text = dtGridViewLeaveDetails.Item(6, i).Value
            Me.txtNoOfDays.Text = dtGridViewLeaveDetails.Item(8, i).Value
            'CalculateDays()
            FillApplicantHistory()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand
        Dim cmdDeductLeave As New OleDbCommand
        Dim cmdDeductCompOff As New OleDbCommand
        Dim strDecision As String
        If (txtEmpId.Text = vbNullString) Then
            MsgBox("Please select an application from the list", MsgBoxStyle.Information, "Selection Requied")
            Exit Sub
        ElseIf (cboDecisionBox.SelectedIndex = 0) Then
            MsgBox("Please select the status", MsgBoxStyle.Information, "Selection Required")
            cboDecisionBox.Focus()
            Exit Sub
        Else
            Dim i As Integer
            i = dtGridViewLeaveDetails.CurrentRow.Index
            Dim iDi As Integer
            iDi = dtGridViewLeaveDetails.Item(0, i).Value
            strDecision = cboDecisionBox.Text
            cmd.Connection = con
            cmd.CommandText = ("Update tblLeaveDetails Set Status = '" & strDecision & "', ApproverComments = '" & txtComments.Text & "', LeaveApprovedby = '" & frmLogin.txtLogin.Text & "' WHERE LeaveID = '" & txtLeaveId.Text & "'")
            cmd.ExecuteNonQuery()
            MsgBox("Leave application status changed", MsgBoxStyle.Information, "Status Changed")
            lblAppName.Text = " "
            lblCompOffDetails.Text = " "
            lblApplicantName.Text = " "
            lblUserHistory.Text = " "
            '/// Testing for updating leave after day cross
            If (cboDecisionBox.Text = "Approved") And txtTypeOfLeave.Text = "PL" Then
                cmdDeductLeave.Connection = con
                cmdDeductLeave.CommandText = "Update tblLeaveBalance SET LeaveBalance = ('" & Convert.ToDouble(fnLeaveBalance()) & "' - '" & Convert.ToDouble(txtNoOfDays.Text) & "') where EMployeeID = '" & txtEmpId.Text & "'"
                cmdDeductLeave.ExecuteNonQuery()
                txtComments.Text = vbNullString
                cboDecisionBox.SelectedItem = "Please Select"
            ElseIf (cboDecisionBox.Text = "Approved") And txtTypeOfLeave.Text = "Comp-Off" Then
                cmdDeductLeave.Connection = con
                cmdDeductLeave.CommandText = "Update tblLeaveBalance SET CompOffBal = ('" & Convert.ToDouble(fnCompOffBal()) & "' - '" & Convert.ToDouble(txtNoOfDays.Text) & "') where EMployeeID = '" & txtEmpId.Text & "'"
                cmdDeductLeave.ExecuteNonQuery()
                txtComments.Text = vbNullString
                cboDecisionBox.SelectedItem = "Please Select"
            End If
            con.Close()
            con = Nothing
            FillDataGrid()
            FillApplicantHistory()
            ResetAll()
            ' RequestPending()
            lblRequestInfo.Text = RequestPending()
        End If
    End Sub

    Public Sub FillDataGrid()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & strEmpid & "'"
        cmdstr.ExecuteNonQuery()
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        dtAdapter.Fill(dtTable)
        Dim strResult As String = ""
        strResult = dtTable.Rows("0").Item("EmployeeName")

        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where ReportingManager = '" & strResult & "' and Delete = 'A' and [Status] is null"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtGridViewLeaveDetails.DataSource = dtTable1

        'INVISIBLE COLUMNS
        dtGridViewLeaveDetails.Columns(0).Visible = False
        dtGridViewLeaveDetails.Columns(7).Visible = False
        dtGridViewLeaveDetails.Columns(10).Visible = False
        dtGridViewLeaveDetails.Columns(11).Visible = False
        dtGridViewLeaveDetails.Columns(12).Visible = False
        dtGridViewLeaveDetails.Columns(14).Visible = False

        'VISIBLE COLUMNS
        dtGridViewLeaveDetails.Columns(1).HeaderText = "Emp ID"
        dtGridViewLeaveDetails.Columns(2).HeaderText = "Name"
        dtGridViewLeaveDetails.Columns(4).HeaderText = "Rpt. Mgr."
        dtGridViewLeaveDetails.Columns(5).HeaderText = "Start Date"
        dtGridViewLeaveDetails.Columns(6).HeaderText = "End Date"
        dtGridViewLeaveDetails.Columns(8).HeaderText = "Number of Leave/s"
        dtGridViewLeaveDetails.Columns(9).HeaderText = "Comments"
        dtGridViewLeaveDetails.Columns(13).HeaderText = "App. Comments"
        dtGridViewLeaveDetails.Columns(15).HeaderText = "Type Of Leave"
        FillApplicantHistory()
        con.Close()
        con.Dispose()
    End Sub
    Public Sub FillDecision()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT [Status] FROM tblOtherDetails Where [Status] is not null ORDER BY [Status] ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboDecisionBox.Items.Add("Please Select")
        cboDecisionBox.SelectedItem = ("Please Select")
        While sdr.Read()
            cboDecisionBox.Items.Add(sdr.Item("Status").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Private Sub ReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReports.ShowDialog()
    End Sub

    Private Sub ResetEmailIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEmailId.ShowDialog()
    End Sub

    Public Function RequestPending() As Integer
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strLoginId As String
        strLoginId = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select EmployeeName from tblLoginDetails where EmployeeID = '" & strLoginId & "'"
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        Dim Result As String = ""
        Result = dtTable.Rows("0").Item("EmployeeName")
        Dim cmdall As OleDbCommand = New _
       OleDbCommand("SELECT [Status] FROM tblLeaveDetails Where [Status] is null and ReportingManager = '" & Result & "' and [Delete]='A' ", con)
        Dim dtTableReq As New DataTable
        Dim dtAdapterReq As New OleDbDataAdapter(cmdall)
        dtAdapterReq.Fill(dtTableReq)
        Return dtTableReq.Rows.Count
        con.Close()
        con.Dispose()

    End Function

    Private Sub ResetPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPwdResetAdmin.ShowDialog()
    End Sub

    Public Function fnLeaveBalance() As Double
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdApplier As New OleDbCommand
        cmdApplier.Connection = con
        cmdApplier.CommandText = "Select LeaveBalance from tblLeaveBalance where EmployeeID = '" & txtEmpId.Text & "'"
        Dim dtLeaveBal As DataTable = New DataTable
        Dim dtLeaveBalAdaptar As New OleDbDataAdapter(cmdApplier)
        cmdApplier.ExecuteNonQuery()
        dtLeaveBalAdaptar.Fill(dtLeaveBal)

        Dim strLeaveBal As String
        strLeaveBal = dtLeaveBal.Rows(0).Item(0).ToString
        Return strLeaveBal
        con.Close()
        con.Dispose()

    End Function
    Public Function fnCompOffBal() As Double
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdApplier As New OleDbCommand
        cmdApplier.Connection = con
        cmdApplier.CommandText = "Select CompOffBal from tblLeaveBalance where EmployeeID = '" & txtEmpId.Text & "'"
        Dim dtLeaveBal As DataTable = New DataTable
        Dim dtLeaveBalAdaptar As New OleDbDataAdapter(cmdApplier)
        cmdApplier.ExecuteNonQuery()
        dtLeaveBalAdaptar.Fill(dtLeaveBal)

        Dim strLeaveBal As String
        strLeaveBal = dtLeaveBal.Rows(0).Item(0).ToString
        Return strLeaveBal
        con.Close()
        con.Dispose()
    End Function

    Private Sub ReportsToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem1.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub ResetPasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem1.Click
        frmPwdResetAdmin.ShowDialog()
    End Sub

    Private Sub CustomizeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeToolStripMenuItem1.Click
        frmCustomize.ShowDialog()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmPwdResetUser.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Public Sub ResetAll()
        txtEmpId.Text = vbNullString
        txtEmpName.Text = vbNullString
        txtLeaveStartDate.Text = vbNullString
        txtLeaveEnddate.Text = vbNullString
        txtComments.Text = vbNullString
        cboDecisionBox.SelectedItem = "Please Select"
        txtNoOfDays.Text = vbNullString
        txtTypeOfLeave.Text = vbNullString
    End Sub

    Private Sub ResetEmailIDToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetEmailIDToolStripMenuItem.Click
        frmEmailId.ShowDialog()
    End Sub

    Public Sub FillApplicantHistory()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr As New OleDbCommand
        Dim strEmpid As String
        strEmpid = frmLogin.txtLogin.Text
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & strEmpid & "'"
        cmdstr.ExecuteNonQuery()
        Dim dtTable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        dtAdapter.Fill(dtTable)
        Dim strResult As String = ""
        strResult = dtTable.Rows("0").Item("EmployeeName")

        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where EmployeeID = '" & txtEmpId.Text & "' and Delete='A'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtApplicantHistory.DataSource = dtTable1

        'INVISIBLE COLUMNS
        dtApplicantHistory.Columns(0).Visible = False
        dtApplicantHistory.Columns(3).Visible = False
        dtApplicantHistory.Columns(7).Visible = False
        dtApplicantHistory.Columns(12).Visible = False
        dtApplicantHistory.Columns(11).Visible = False
        dtApplicantHistory.Columns(14).Visible = False

        'VISIBLE COLUMNS
        dtApplicantHistory.Columns(1).HeaderText = "Emp ID"
        dtApplicantHistory.Columns(2).HeaderText = "Name"
        dtApplicantHistory.Columns(4).HeaderText = "Rpt. Mgr."
        dtApplicantHistory.Columns(5).HeaderText = "Start Date"
        dtApplicantHistory.Columns(6).HeaderText = "End Date"
        dtApplicantHistory.Columns(8).HeaderText = "Number of Leave/s"
        dtApplicantHistory.Columns(10).HeaderText = "Status"
        dtApplicantHistory.Columns(9).HeaderText = "Comments"
        dtApplicantHistory.Columns(13).HeaderText = "App. Comments"
        dtApplicantHistory.Columns(15).HeaderText = "Type Of Leave"

        con.Close()
        con.Dispose()

    End Sub

    Private Sub LeaveUpdaterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveUpdaterToolStripMenuItem.Click
        frmLeaveUpdater.ShowDialog()
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

    Private Sub ChangeEnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeEnToolStripMenuItem.Click
        frmEmailId.Show()
    End Sub

    Private Sub TestToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem2.Click
        frmPwdResetUser.Show()
    End Sub

    Public Sub CheckEmailID()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"

        Dim cmdstr As New OleDbCommand
        con.Open()
        cmdstr.Connection = con
        cmdstr.CommandText = "Select * from tblLoginDetails where EmployeeId = '" & strUserLoginId & "'"
        Dim dtTable As New DataTable

        Dim dtAdapter As New OleDbDataAdapter(cmdstr)
        cmdstr.ExecuteNonQuery()
        dtAdapter.Fill(dtTable)
        If (dtTable.Rows("0").Item("Role")) = "Approver" Then
            If (dtTable.Rows(0).Item("EmailId")) = "no-email" Then
                MsgBox("No Email Id configured. Please set an Email id", MsgBoxStyle.Information, "Info. Required")
            End If
        End If
        con.Close()
        con.Dispose()
    End Sub

End Class