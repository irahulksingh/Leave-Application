Imports System.Data.SqlClient
Imports System.Data.OleDb
'Imports Microsoft.Office.Interop.Excel


Public Class frmReportsTab

    Private Sub btnEmpSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpSearch.Click
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
        dtEmpReport.DataSource = dtTable1
        dtEmpReport.Columns(0).Visible = False
        dtEmpReport.Columns(11).Visible = False
        dtEmpReport.Columns(3).Visible = False
        dtEmpReport.Columns(7).Visible = False
        dtEmpReport.Columns(12).Visible = False
        dtEmpReport.Columns(14).Visible = False


        dtEmpReport.Columns(1).HeaderText = "Emp ID"
        dtEmpReport.Columns(2).HeaderText = "Name"
        dtEmpReport.Columns(4).HeaderText = "Reporting Manager"
        dtEmpReport.Columns(5).HeaderText = "Start Date"
        dtEmpReport.Columns(6).HeaderText = "End Date"
        dtEmpReport.Columns(8).HeaderText = "Total Leave"
        dtEmpReport.Columns(9).HeaderText = "Comments"
        dtEmpReport.Columns(13).HeaderText = "App. Comments"
        dtEmpReport.Columns(10).HeaderText = "Status"
        dtEmpReport.Columns(15).HeaderText = "Type Of Leave"

        con.Close()
        con.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


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
        con.Close()
        con.Dispose()
    End Sub


    'Public Sub saveExcelFile(ByVal FileName As String)

    '    Dim Excel As Object

    '    Excel = CreateObject("Excel.Application")
    '    Excel.screenupdating = True
    '    Excel.Visible = True

    '    Dim xlWorkSheet As Object = Excel.workbooks.add
    '    Excel.workbooks(1).worksheets(1).cells(1, 1).value = "Success"

    '    xlWorkSheet.SaveAs(FileName)

    '    Excel.quit()
    '    Excel = Nothing

    'End Sub

    Private Sub frmReportsTab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        FillDepartment()
        FillDeptWithDate()
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where Department = '" & cboDeptName.SelectedItem.ToString() & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtDeptReport.DataSource = dtTable1
        dtDeptReport.DataSource = dtTable1
        dtDeptReport.Columns(0).Visible = False
        dtDeptReport.Columns(11).Visible = False
        dtDeptReport.Columns(3).Visible = False
        dtDeptReport.Columns(7).Visible = False
        dtDeptReport.Columns(12).Visible = False
        dtDeptReport.Columns(14).Visible = False


        dtDeptReport.Columns(1).HeaderText = "Emp ID"
        dtDeptReport.Columns(2).HeaderText = "Name"
        dtDeptReport.Columns(4).HeaderText = "Reporting Manager"
        dtDeptReport.Columns(5).HeaderText = "Start Date"
        dtDeptReport.Columns(6).HeaderText = "End Date"
        dtDeptReport.Columns(8).HeaderText = "Total Leave"
        dtDeptReport.Columns(9).HeaderText = "Comments"
        dtDeptReport.Columns(13).HeaderText = "App. Comments"
        dtDeptReport.Columns(10).HeaderText = "Status"
        dtDeptReport.Columns(15).HeaderText = "Type Of Leave"
        con.Close()
        con.Dispose()
    End Sub
    Public Sub FillDeptWithDate()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT Department FROM tblDepartments Where Department is not null ORDER BY Department ASC", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboDateandDept.Items.Add("All")
        cboDateandDept.SelectedItem = ("All")
        While sdr.Read()
            cboDateandDept.Items.Add(sdr.Item("Department").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Private Sub btnSearchIndividualLeaveBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchIndividualLeaveBal.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveBalance where EmployeeID = '" & txtInvividualLeaveBal.Text & "'"
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtIndividualLeaveBal.DataSource = dtTable1
        dtIndividualLeaveBal.Columns(0).Visible = False
        'dtIndividualLeaveBal.Columns(4).Visible = False
        dtIndividualLeaveBal.Columns(7).Visible = False
        dtIndividualLeaveBal.Columns(8).Visible = False
        dtIndividualLeaveBal.Columns(9).Visible = False
        dtIndividualLeaveBal.Columns(1).HeaderText = "Emp ID"
        dtIndividualLeaveBal.Columns(2).HeaderText = "Name"
        dtIndividualLeaveBal.Columns(3).HeaderText = "Leave Balance"
        dtIndividualLeaveBal.Columns(4).HeaderText = "Comp-Off Balance"
        dtIndividualLeaveBal.Columns(5).HeaderText = "Department"
        con.Close()
        con.Dispose()
    End Sub

    Private Sub btnSearchByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByDate.Click
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        If cboDateandDept.Text = "All" Then
            cmdstr1.CommandText = "Select * from tblLeaveDetails where [LeaveStartDate] BETWEEN '" & dtDateAndDept1.Text & "' AND '" & dtDateAndDept2.Text & "'"
        Else
            cmdstr1.CommandText = "Select * from tblLeaveDetails where [LeaveStartDate] BETWEEN '" & dtDateAndDept1.Text & "' AND '" & dtDateAndDept2.Text & "' AND Department ='" & cboDateandDept.Text & "'"
        End If
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        dtDateAndDeptGrid.DataSource = dtTable1
        dtDateAndDeptGrid.DataSource = dtTable1
        dtDateAndDeptGrid.DataSource = dtTable1
        dtDateAndDeptGrid.Columns(0).Visible = False
        dtDateAndDeptGrid.Columns(11).Visible = False
        dtDateAndDeptGrid.Columns(3).Visible = False
        dtDateAndDeptGrid.Columns(7).Visible = False
        dtDateAndDeptGrid.Columns(12).Visible = False
        dtDateAndDeptGrid.Columns(14).Visible = False


        dtDateAndDeptGrid.Columns(1).HeaderText = "Emp ID"
        dtDateAndDeptGrid.Columns(2).HeaderText = "Name"
        dtDateAndDeptGrid.Columns(4).HeaderText = "Reporting Manager"
        dtDateAndDeptGrid.Columns(5).HeaderText = "Start Date"
        dtDateAndDeptGrid.Columns(6).HeaderText = "End Date"
        dtDateAndDeptGrid.Columns(8).HeaderText = "Total Leave"
        dtDateAndDeptGrid.Columns(9).HeaderText = "Comments"
        dtDateAndDeptGrid.Columns(13).HeaderText = "App. Comments"
        dtDateAndDeptGrid.Columns(10).HeaderText = "Status"
        dtDateAndDeptGrid.Columns(15).HeaderText = "Type Of Leave"
        con.Close()
        con.Dispose()
    End Sub

    Private Sub btnExtoExcelIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtoExcelIndividual.Click

        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveBalance where EmployeeID = '" & txtInvividualLeaveBal.Text & "'"
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
        con.Close()
        con.Dispose()
    End Sub


    Public Sub saveExcelFile(ByVal FileName As String)

        Dim Excel As Object

        Excel = CreateObject("Excel.Application")
        Excel.screenupdating = True
        Excel.Visible = True

        Dim xlWorkSheet As Object = Excel.workbooks.add
        Excel.workbooks(1).worksheets(1).cells(1, 1).value = "Your report has been created and is available in the next excel workbook, Kindly Save It."

        xlWorkSheet.SaveAs(FileName)

        Excel.quit()
        Excel = Nothing

    End Sub

    Private Sub btnExToExcelDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExToExcelDepartment.Click

        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        cmdstr1.CommandText = "Select * from tblLeaveDetails where Department = '" & cboDeptName.SelectedItem.ToString() & "'"
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
        con.Close()
        con.Dispose()
    End Sub

    Private Sub btnExtoExcelPeriodic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtoExcelPeriodic.Click

        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmdstr1 As New OleDbCommand
        cmdstr1.Connection = con
        If cboDateandDept.Text = "All" Then
            cmdstr1.CommandText = "Select * from tblLeaveDetails where [LeaveStartDate] BETWEEN '" & dtDateAndDept1.Text & "' AND '" & dtDateAndDept2.Text & "'"
        Else
            cmdstr1.CommandText = "Select * from tblLeaveDetails where [LeaveStartDate] BETWEEN '" & dtDateAndDept1.Text & "' AND '" & dtDateAndDept2.Text & "' AND Department ='" & cboDateandDept.Text & "'"
        End If
        cmdstr1.ExecuteNonQuery()
        Dim dtTable1 As New DataTable
        Dim dtAdapter1 As New OleDbDataAdapter(cmdstr1)
        dtAdapter1.Fill(dtTable1)
        If (dtTable1.Rows.Count = 0) Then
            MsgBox("No data to be exported", MsgBoxStyle.Exclamation, "No data")
        Else
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
            saveFileDialog1.Title = "Save Report"
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName <> "" Then
                saveExcelFile(saveFileDialog1.FileName)
            End If
        End If
        con.Close()
        con.Dispose()
    End Sub
End Class