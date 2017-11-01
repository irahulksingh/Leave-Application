
Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class frmReports

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.CenterToScreen()
        Me.TopMost = True

        rbutEmpId.Enabled = True
        txtEmpId.Enabled = True
        cboDeptName.Enabled = False
        btnSearch.Enabled = True
        btnSearchTeam.Enabled = False
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where EmployeeId = '" & txtEmpId.Text & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtReports.DataSource = dtTable1
        dtReports.Columns(0).Visible = False
        dtReports.Columns(11).Visible = False
        dtReports.Columns(3).Visible = False
        dtReports.Columns(7).Visible = False
        dtReports.Columns(12).Visible = False
        dtReports.Columns(14).Visible = False


        dtReports.Columns(1).HeaderText = "Emp ID"
        dtReports.Columns(2).HeaderText = "Name"
        dtReports.Columns(4).HeaderText = "Reporting Manager"
        dtReports.Columns(5).HeaderText = "Start Date"
        dtReports.Columns(6).HeaderText = "End Date"
        dtReports.Columns(8).HeaderText = "Total Leave"
        dtReports.Columns(9).HeaderText = "Comments"
        dtReports.Columns(13).HeaderText = "App. Comments"
        dtReports.Columns(10).HeaderText = "Status"
        dtReports.Columns(15).HeaderText = "Type Of Leave"

        con.Close()
        con.Dispose()
    End Sub


    Private Sub btnExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToExcel.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where EmployeeId = '" & txtEmpId.Text & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)

        'setting the path to save excel file

        Dim deskDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        'Saving file to excel
        Dim _excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet


        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dtTable1
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            _excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Excel File|*.xlsx"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            saveExcelFile(saveFileDialog1.FileName)
        End If
        'wSheet.Columns.AutoFit()
        '' Dim Path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & ""
        'Dim strFileName As String = deskDir + "\LeaveReport" + dtTable1.Rows(0).Item(2)
        ''If System.IO.File.Exists(strFileName) Then
        ''    System.IO.File.Delete(strFileName)
        ''End If
        'wBook.SaveAs(strFileName)
        'wBook.Close()
        '_excel.Quit()
        'MsgBox(" Your report has been saved on your Desktop", MsgBoxStyle.OkOnly, "Confirmation")
        con.Close()
        con.Dispose()
    End Sub


    Public Sub saveExcelFile(ByVal FileName As String)

        Dim Excel As Object

        Excel = CreateObject("Excel.Application")
        Excel.screenupdating = True
        Excel.Visible = True

        Dim xlWorkSheet As Object = Excel.workbooks.add
        Excel.workbooks(1).worksheets(1).cells(1, 1).value = "Success"

        xlWorkSheet.SaveAs(FileName)

        Excel.quit()
        Excel = Nothing

    End Sub

    'Private Sub btnSearchDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim con As New OleDbConnection
    'con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
    'con.Open()
    'Dim cmdstr1 As New OleDbCommand
    'cmdstr1.Connection = con
    'cmdstr1.CommandText = "Select * from tblLeaveDetails where LeaveStartDate Between LeaveStartDate = '" & dtPicker1.Text & "'  and LeaveEndDate = '" & dtPicker2.Text & "'"
    'cmdstr1.ExecuteNonQuery()
    'Dim dtTable1 As New DataTable
    'Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
    'dtAdapter1.Fill(dtTable1)
    'dtReports.DataSource = dtTable1
    'dtReports.Columns(0).Visible = False
    'dtReports.Columns(10).Visible = False
    'dtReports.Columns(11).Visible = False
    'dtReports.Columns(1).HeaderText = "Emp ID"
    'dtReports.Columns(2).HeaderText = "Name"
    'dtReports.Columns(4).HeaderText = "Reporting Manager"
    'dtReports.Columns(5).HeaderText = "Start Date"
    'dtReports.Columns(6).HeaderText = "End Date"
    'dtReports.Columns(7).HeaderText = "Total Leave"
    'dtReports.Columns(8).HeaderText = "Comments"
    'dtReports.Columns(12).HeaderText = "App. Comments"
    'dtReports.Columns(9).HeaderText = "Status"

    ' End Sub

    Private Sub rbutEmpId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbutEmpId.CheckedChanged
        txtEmpId.Enabled = True
        cboDeptName.Enabled = False
        btnSearch.Enabled = True
        btnSearchTeam.Enabled = False

    End Sub

    Private Sub rbutTeamWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbutTeamWise.CheckedChanged
        txtEmpId.Enabled = False
        cboDeptName.Enabled = True
        btnSearch.Enabled = False
        btnSearchTeam.Enabled = True
        FillDepartment()
    End Sub

    Private Sub btnSearchTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchTeam.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveBalance where Department = '" & cboDeptName.SelectedItem.ToString() & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtReports.DataSource = dtTable1
        dtReports.Columns(0).Visible = False
        dtReports.Columns(4).Visible = False
        dtReports.Columns(1).HeaderText = "Emp ID"
        dtReports.Columns(2).HeaderText = "Name"
        dtReports.Columns(3).HeaderText = "Leave Balance"
        dtReports.Columns(5).HeaderText = "Department"
        con.Close()
        con.Dispose()
    End Sub

    Public Sub FillDepartment()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Department FROM tblDepartments Where Department is not null ORDER BY Department ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboDeptName.Items.Add("Please Select")
        cboDeptName.SelectedItem = ("Please Select")
        While sdr.Read()
            cboDeptName.Items.Add(sdr.Item("Department").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub
End Class