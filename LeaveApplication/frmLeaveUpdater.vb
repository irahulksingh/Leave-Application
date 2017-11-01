Imports System.Data.OleDb

Public Class frmLeaveUpdater

    Private Sub btnLeaveSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeaveSearch.Click
        UpdateGrid()
    End Sub

    Private Sub btnUpdateLeaveBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateLeaveBal.Click
        Dim strUserId As String
        strUserId = frmLogin.txtLogin.Text
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        If (txtPLeaveBal.Text = vbNullString) Then
            MsgBox(" Please enter the leave balance to be updated", MsgBoxStyle.Information, "Data Required")
            Exit Sub
        End If
        If CheckUser() = False Then
            MsgBox("User Not Found In Leave Balance Database", MsgBoxStyle.Information, "No User Found")
        ElseIf CheckUser() = True Then
            If (txtPLeaveBal.Text = vbNullString) Then
                Dim cmdComOff As OleDbCommand = New _
                               OleDbCommand("Update tblLeaveBalance SET [CompOffBal] = '" & txtCompOffBal.Text & "',[ActionedBy]='" & strUserId & "',[ActionedOn]='" & Date.Now() & "' where [EmployeeID]='" & txtLeaveEmpId.Text & "'", con)
                cmdComOff.ExecuteNonQuery()
                MsgBox("Comp off Leave balance updated", MsgBoxStyle.Information, "Update")
            ElseIf (txtCompOffBal.Text = vbNullString) Then
                Dim cmdPLeave As OleDbCommand = New _
                               OleDbCommand("Update tblLeaveBalance SET [LeaveBalance] = '" & txtPLeaveBal.Text & "',[ActionedBy]='" & strUserId & "',[ActionedOn]='" & Date.Now() & "'  where [EmployeeID]='" & txtLeaveEmpId.Text & "'", con)
                cmdPLeave.ExecuteNonQuery()
                MsgBox("PL Leave balance updated", MsgBoxStyle.Information, "Update")
            Else
                Dim cmd As OleDbCommand = New _
                   OleDbCommand("Update tblLeaveBalance SET [LeaveBalance] = '" & txtPLeaveBal.Text & "', [CompOffBal] = '" & txtCompOffBal.Text & "',[ActionedBy]='" & strUserId & "',[ActionedOn]='" & Date.Now() & "'  where [EmployeeID]='" & txtLeaveEmpId.Text & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Leave balance updated", MsgBoxStyle.Information, "Update")
            End If
            UpdateGrid()
        End If
        con.Close()
        con.Dispose()
    End Sub
    Public Function CheckUser() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select * from tblLeaveBalance where EmployeeId = '" & txtLeaveEmpId.Text & "'"
        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)
        If (dttable.Rows.Count = 0) Then
            Return False
        Else
            Return True
        End If
        con.Close()
        con.Dispose()
    End Function

    Private Sub frmLeaveUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Public Sub UpdateGrid()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveBalance where EmployeeId = '" & txtLeaveEmpId.Text & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtLeaveBalance.DataSource = dtTable1
        dtLeaveBalance.Columns(0).Visible = False
        dtLeaveBalance.Columns(5).Visible = False
        dtLeaveBalance.Columns(6).Visible = False
        dtLeaveBalance.Columns(7).Visible = False
        dtLeaveBalance.Columns(8).Visible = False
        dtLeaveBalance.Columns(1).HeaderText = "Emp ID"
        dtLeaveBalance.Columns(2).HeaderText = "Name"
        dtLeaveBalance.Columns(3).HeaderText = "Leave (PL) Balance"
        dtLeaveBalance.Columns(4).HeaderText = "Leave (Comp-Off) Balance"
        Resetall()
        con.Close()
        con.Dispose()
    End Sub
    Public Sub Resetall()
        txtCompOffBal.Text = vbNullString
        txtPLeaveBal.Text = vbNullString
    End Sub
End Class