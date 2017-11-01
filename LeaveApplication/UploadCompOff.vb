'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'Public Class UploadCompOff
'    Public Class Form1
'        Dim ds1 As New DataSet
'        Dim ds2 As New DataSet
'        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'            Dim _filename As String = "C:\new.xls"
'            Dim _conn As String
'            _conn = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & _filename & ";" & "Extended Properties=Excel 8.0;"
'            Dim _connection As OleDbConnection = New OleDbConnection(_conn)
'            Dim da As OleDbDataAdapter = New OleDbDataAdapter()
'            Dim _command As OleDbCommand = New OleDbCommand()
'            _command.Connection = _connection
'            _command.CommandText = "SELECT * FROM [Sheet1$]"
'            da.SelectCommand = _command
'            Try
'                da.Fill(ds1, "sheet1")
'                MessageBox.Show("The import is complete!")
'                Me.DataGridView1.DataSource = ds1
'                Me.DataGridView1.DataMember = "sheet1"
'            Catch e1 As Exception
'                MessageBox.Show("Import Failed, correct Column name in the sheet!")
'            End Try
'        End Sub
'        Dim da As SqlDataAdapter
'        Dim conn As SqlConnection
'        Dim cb As SqlCommandBuilder
'        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
'            conn = New SqlConnection("Data Source=Servername;Initial Catalog=mydb;Integrated Security=True")
'            Dim sel As String = "SELECT * FROM myTable"
'            da = New SqlDataAdapter(sel, conn)
'            cb = New SqlCommandBuilder(da)
'            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
'            da.Fill(ds2, "myTable")
'            Me.DataGridView1.DataSource = ds2
'            Me.DataGridView1.DataMember = "myTable"
'        End Sub

'        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
'            For Each dr As DataRow In ds1.Tables(0).Rows
'                Dim expression As String
'                expression = "myId =" + CType(dr.Item(0), Integer).ToString
'                Dim drs() As DataRow = ds2.Tables(0).Select(expression)
'                If (drs.Length = 1) Then
'                    For i As Integer = 1 To ds2.Tables(0).Columns.Count - 1
'                        drs(0).Item(i) = dr.Item(i)
'                    Next
'                Else
'                    Dim drnew As DataRow = ds2.Tables(0).NewRow
'                    For i As Integer = 0 To ds2.Tables(0).Columns.Count - 1
'                        drnew.Item(i) = dr.Item(i)
'                    Next
'                    ds2.Tables(0).Rows.Add(drnew)
'                End If
'            Next
'            Me.DataGridView1.DataSource = ds2
'            Me.DataGridView1.DataMember = "myTable"
'            da.Update(ds2.Tables(0))
'        End Sub
'    End Class

'    Private Sub UploadCompOff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class