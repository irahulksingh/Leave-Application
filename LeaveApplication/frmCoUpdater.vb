Imports System.Data.OleDb
Public Class frmCompOffUpdater

    Dim strUserLoginID As String = frmLogin.txtLogin.Text
    Private Sub btnAddCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCO.Click

        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim strApproved As String
        strApproved = "Approved"

        If (CheckCompOffExists() = True) Then
            MsgBox("Comp-Off already exists", MsgBoxStyle.Information, "Duplicate entry")
            Exit Sub
        Else
            Dim cmd As New OleDbCommand
            cmd.Connection = con
            Dim CurrentYear As Date
            CurrentYear = dtCO1.Text
            cmd.CommandText = "Insert into tblCompOff ([CompOffDate],[Description],[UpdatedOn],[UpdatedBy],[CoYear],[LeaveStatus],[COLeaveID]) Values ('" & dtCO1.Text & "','" & txtCOdesc1.Text & "','" & Date.Now().ToString() & "','" & strUserLoginID & "','" & CurrentYear.Year.ToString() & "','" & strApproved & "','" & strUserLoginID + Now() & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Comp-Off added successfully", MsgBoxStyle.Information, "Confirmation")
            con.Close()
            con.Dispose()
        End If
    End Sub

    Private Sub frmCompOffUpdater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        FillCboYear()
    End Sub
    Public Sub fillDtGridCompOff()
        Dim con As New OleDbConnection
        Dim stYear As String
        stYear = cboYear.Text
        If (stYear = vbNullString) Then
            con.Close()
            con.Dispose()
            Exit Sub
        Else
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmd As New OleDbCommand
            cmd.Connection = con
            cmd.CommandText = "Select CompOffDate,Description,CoLeaveID from tblCompOff where CoYear = '" & stYear & "' And LeaveStatus='Approved'"
            Dim dttable As New DataTable
            Dim dtAdapter As New OleDbDataAdapter(cmd)
            dtAdapter.Fill(dttable)
            dtGridCompOff.DataSource = dttable
            dtGridCompOff.Columns(0).HeaderText = "Comp-Off Dated"
            dtGridCompOff.Columns(1).HeaderText = "Comp-Off Description"
            dtGridCompOff.Columns(2).Visible = False
            con.Close()
            con.Dispose()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Public Sub FillCboYear()
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()
        Dim cmd As OleDbCommand = New _
       OleDbCommand("SELECT DISTINCT CoYear FROM tblCompOff Where CoYear is not null and LeaveStatus = 'Approved' Order By CoYear ASC ", con)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader
        cboYear.Items.Add("Please Select")
        cboYear.SelectedItem = ("Please Select")
        While sdr.Read()
            cboYear.Items.Add(sdr.Item("CoYear").ToString)
        End While
        con.Close()
        con = Nothing
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        fillDtGridCompOff()
    End Sub

    Private Sub DeleteCoRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCoRecord.Click
        If (dtGridCompOff.SelectedRows.Count = 0) Then
            MsgBox("Please select a Comp-Off to delete", MsgBoxStyle.Information, "Selection required")
            Exit Sub
        End If
        Dim i As Integer
        Dim result = MessageBox.Show("Delete Comp-Off", "Delete Comp-Off", MessageBoxButtons.OKCancel)
        If (dtGridCompOff.Rows.Count <= 0) Then
            MsgBox("No records to delete", MsgBoxStyle.Information, "No Data")
            Exit Sub
        ElseIf result = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            i = dtGridCompOff.CurrentRow.Index
            txtCoId.Text = dtGridCompOff.Item(2, i).Value
            Dim con As New OleDbConnection
            con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
            con.Open()
            Dim cmdstr1 As New OleDbCommand
            cmdstr1.Connection = con
            cmdstr1.CommandText = "Update tblCompOff Set [LeaveStatus] = 'Deleted' , [UpdatedBy] = '" & strUserLoginID & "'  where  CoLeaveID = '" & txtCoId.Text & "'"
            cmdstr1.ExecuteNonQuery()
            con.Close()
            con.Dispose()
        End If
        fillDtGridCompOff()
    End Sub

    Public Function CheckCompOffExists() As Boolean
        Dim con As New OleDbConnection
        con.ConnectionString = "File Name=H:\Kode-Rahul\Connection\Connection.udl"
        con.Open()

        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = "Select CompOffDate from tblCompOff where [LeaveStatus] = 'Approved'"

        Dim dttable As New DataTable
        Dim dtAdapter As New OleDbDataAdapter(cmd)
        dtAdapter.Fill(dttable)

        Dim strLeaveStartDate As String
        strLeaveStartDate = dtCO1.Text
        ' Checking if leave applied for the date already "Duplication"
        Dim i As Integer
        i = dttable.Rows.Count
        For k As Integer = 0 To (i - 1)
            If strLeaveStartDate = dttable.Rows(k).Item("CompOffDate").ToString() Then
                Return True
            End If
        Next
    End Function
End Class