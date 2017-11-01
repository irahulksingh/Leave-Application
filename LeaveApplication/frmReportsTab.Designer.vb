<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.dtEmpReport = New System.Windows.Forms.DataGridView
        Me.btnEmpSearch = New System.Windows.Forms.Button
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnExtoExcelIndividual = New System.Windows.Forms.Button
        Me.dtIndividualLeaveBal = New System.Windows.Forms.DataGridView
        Me.btnSearchIndividualLeaveBal = New System.Windows.Forms.Button
        Me.txtInvividualLeaveBal = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.cboDeptName = New System.Windows.Forms.ComboBox
        Me.btnExToExcelDepartment = New System.Windows.Forms.Button
        Me.dtDeptReport = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboDateandDept = New System.Windows.Forms.ComboBox
        Me.dtDateAndDept2 = New System.Windows.Forms.DateTimePicker
        Me.dtDateAndDept1 = New System.Windows.Forms.DateTimePicker
        Me.btnExtoExcelPeriodic = New System.Windows.Forms.Button
        Me.dtDateAndDeptGrid = New System.Windows.Forms.DataGridView
        Me.btnSearchByDate = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtEmpReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtIndividualLeaveBal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtDeptReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtDateAndDeptGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1062, 529)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1054, 500)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Employee Report"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.dtEmpReport)
        Me.GroupBox2.Controls.Add(Me.btnEmpSearch)
        Me.GroupBox2.Controls.Add(Me.txtEmpId)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1024, 337)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search By Employee ID :: Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter Employee ID:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SlateGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(887, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Export to Excel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dtEmpReport
        '
        Me.dtEmpReport.AllowUserToAddRows = False
        Me.dtEmpReport.AllowUserToDeleteRows = False
        Me.dtEmpReport.AllowUserToResizeColumns = False
        Me.dtEmpReport.AllowUserToResizeRows = False
        Me.dtEmpReport.BackgroundColor = System.Drawing.Color.White
        Me.dtEmpReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtEmpReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtEmpReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtEmpReport.GridColor = System.Drawing.Color.Gray
        Me.dtEmpReport.Location = New System.Drawing.Point(6, 56)
        Me.dtEmpReport.Name = "dtEmpReport"
        Me.dtEmpReport.ReadOnly = True
        Me.dtEmpReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtEmpReport.Size = New System.Drawing.Size(998, 244)
        Me.dtEmpReport.TabIndex = 11
        '
        'btnEmpSearch
        '
        Me.btnEmpSearch.BackColor = System.Drawing.Color.SlateGray
        Me.btnEmpSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpSearch.ForeColor = System.Drawing.Color.White
        Me.btnEmpSearch.Location = New System.Drawing.Point(327, 26)
        Me.btnEmpSearch.Name = "btnEmpSearch"
        Me.btnEmpSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpSearch.TabIndex = 2
        Me.btnEmpSearch.Text = "Search"
        Me.btnEmpSearch.UseVisualStyleBackColor = False
        '
        'txtEmpId
        '
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(146, 27)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(175, 23)
        Me.txtEmpId.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.PowderBlue
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1054, 500)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Individual Leave Balance"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnExtoExcelIndividual)
        Me.GroupBox4.Controls.Add(Me.dtIndividualLeaveBal)
        Me.GroupBox4.Controls.Add(Me.btnSearchIndividualLeaveBal)
        Me.GroupBox4.Controls.Add(Me.txtInvividualLeaveBal)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(15, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1024, 356)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search By Employee ID :: Report"
        '
        'btnExtoExcelIndividual
        '
        Me.btnExtoExcelIndividual.BackColor = System.Drawing.Color.SlateGray
        Me.btnExtoExcelIndividual.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExtoExcelIndividual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtoExcelIndividual.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtoExcelIndividual.ForeColor = System.Drawing.Color.White
        Me.btnExtoExcelIndividual.Location = New System.Drawing.Point(887, 325)
        Me.btnExtoExcelIndividual.Name = "btnExtoExcelIndividual"
        Me.btnExtoExcelIndividual.Size = New System.Drawing.Size(131, 25)
        Me.btnExtoExcelIndividual.TabIndex = 12
        Me.btnExtoExcelIndividual.Text = "Export to Excel"
        Me.btnExtoExcelIndividual.UseVisualStyleBackColor = False
        '
        'dtIndividualLeaveBal
        '
        Me.dtIndividualLeaveBal.AllowUserToAddRows = False
        Me.dtIndividualLeaveBal.AllowUserToDeleteRows = False
        Me.dtIndividualLeaveBal.AllowUserToResizeColumns = False
        Me.dtIndividualLeaveBal.AllowUserToResizeRows = False
        Me.dtIndividualLeaveBal.BackgroundColor = System.Drawing.Color.White
        Me.dtIndividualLeaveBal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtIndividualLeaveBal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtIndividualLeaveBal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtIndividualLeaveBal.GridColor = System.Drawing.Color.Gray
        Me.dtIndividualLeaveBal.Location = New System.Drawing.Point(26, 75)
        Me.dtIndividualLeaveBal.Name = "dtIndividualLeaveBal"
        Me.dtIndividualLeaveBal.ReadOnly = True
        Me.dtIndividualLeaveBal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtIndividualLeaveBal.Size = New System.Drawing.Size(998, 244)
        Me.dtIndividualLeaveBal.TabIndex = 11
        '
        'btnSearchIndividualLeaveBal
        '
        Me.btnSearchIndividualLeaveBal.BackColor = System.Drawing.Color.SlateGray
        Me.btnSearchIndividualLeaveBal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchIndividualLeaveBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchIndividualLeaveBal.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchIndividualLeaveBal.ForeColor = System.Drawing.Color.White
        Me.btnSearchIndividualLeaveBal.Location = New System.Drawing.Point(446, 46)
        Me.btnSearchIndividualLeaveBal.Name = "btnSearchIndividualLeaveBal"
        Me.btnSearchIndividualLeaveBal.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchIndividualLeaveBal.TabIndex = 2
        Me.btnSearchIndividualLeaveBal.Text = "Search"
        Me.btnSearchIndividualLeaveBal.UseVisualStyleBackColor = False
        '
        'txtInvividualLeaveBal
        '
        Me.txtInvividualLeaveBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvividualLeaveBal.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvividualLeaveBal.Location = New System.Drawing.Point(216, 46)
        Me.txtInvividualLeaveBal.Name = "txtInvividualLeaveBal"
        Me.txtInvividualLeaveBal.Size = New System.Drawing.Size(175, 23)
        Me.txtInvividualLeaveBal.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1054, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Department Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cboDeptName)
        Me.GroupBox1.Controls.Add(Me.btnExToExcelDepartment)
        Me.GroupBox1.Controls.Add(Me.dtDeptReport)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 362)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Department :: Report"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SlateGray
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(165, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cboDeptName
        '
        Me.cboDeptName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptName.FormattingEnabled = True
        Me.cboDeptName.Location = New System.Drawing.Point(26, 49)
        Me.cboDeptName.Name = "cboDeptName"
        Me.cboDeptName.Size = New System.Drawing.Size(133, 24)
        Me.cboDeptName.TabIndex = 5
        '
        'btnExToExcelDepartment
        '
        Me.btnExToExcelDepartment.BackColor = System.Drawing.Color.SlateGray
        Me.btnExToExcelDepartment.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExToExcelDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExToExcelDepartment.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExToExcelDepartment.ForeColor = System.Drawing.Color.White
        Me.btnExToExcelDepartment.Location = New System.Drawing.Point(887, 329)
        Me.btnExToExcelDepartment.Name = "btnExToExcelDepartment"
        Me.btnExToExcelDepartment.Size = New System.Drawing.Size(131, 25)
        Me.btnExToExcelDepartment.TabIndex = 12
        Me.btnExToExcelDepartment.Text = "Export to Excel"
        Me.btnExToExcelDepartment.UseVisualStyleBackColor = False
        '
        'dtDeptReport
        '
        Me.dtDeptReport.AllowUserToAddRows = False
        Me.dtDeptReport.AllowUserToDeleteRows = False
        Me.dtDeptReport.AllowUserToResizeColumns = False
        Me.dtDeptReport.AllowUserToResizeRows = False
        Me.dtDeptReport.BackgroundColor = System.Drawing.Color.White
        Me.dtDeptReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDeptReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDeptReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtDeptReport.GridColor = System.Drawing.Color.Gray
        Me.dtDeptReport.Location = New System.Drawing.Point(26, 79)
        Me.dtDeptReport.Name = "dtDeptReport"
        Me.dtDeptReport.ReadOnly = True
        Me.dtDeptReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDeptReport.Size = New System.Drawing.Size(998, 244)
        Me.dtDeptReport.TabIndex = 11
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1054, 500)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Periodic Report"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboDateandDept)
        Me.GroupBox3.Controls.Add(Me.dtDateAndDept2)
        Me.GroupBox3.Controls.Add(Me.dtDateAndDept1)
        Me.GroupBox3.Controls.Add(Me.btnExtoExcelPeriodic)
        Me.GroupBox3.Controls.Add(Me.dtDateAndDeptGrid)
        Me.GroupBox3.Controls.Add(Me.btnSearchByDate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1024, 367)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By Date :: Report"
        '
        'cboDateandDept
        '
        Me.cboDateandDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateandDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateandDept.FormattingEnabled = True
        Me.cboDateandDept.Location = New System.Drawing.Point(466, 37)
        Me.cboDateandDept.Name = "cboDateandDept"
        Me.cboDateandDept.Size = New System.Drawing.Size(133, 24)
        Me.cboDateandDept.TabIndex = 15
        '
        'dtDateAndDept2
        '
        Me.dtDateAndDept2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateAndDept2.Location = New System.Drawing.Point(228, 38)
        Me.dtDateAndDept2.Name = "dtDateAndDept2"
        Me.dtDateAndDept2.Size = New System.Drawing.Size(110, 22)
        Me.dtDateAndDept2.TabIndex = 14
        '
        'dtDateAndDept1
        '
        Me.dtDateAndDept1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateAndDept1.Location = New System.Drawing.Point(7, 40)
        Me.dtDateAndDept1.Name = "dtDateAndDept1"
        Me.dtDateAndDept1.Size = New System.Drawing.Size(99, 22)
        Me.dtDateAndDept1.TabIndex = 13
        '
        'btnExtoExcelPeriodic
        '
        Me.btnExtoExcelPeriodic.BackColor = System.Drawing.Color.SlateGray
        Me.btnExtoExcelPeriodic.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExtoExcelPeriodic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtoExcelPeriodic.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtoExcelPeriodic.ForeColor = System.Drawing.Color.White
        Me.btnExtoExcelPeriodic.Location = New System.Drawing.Point(873, 318)
        Me.btnExtoExcelPeriodic.Name = "btnExtoExcelPeriodic"
        Me.btnExtoExcelPeriodic.Size = New System.Drawing.Size(131, 25)
        Me.btnExtoExcelPeriodic.TabIndex = 12
        Me.btnExtoExcelPeriodic.Text = "Export to Excel"
        Me.btnExtoExcelPeriodic.UseVisualStyleBackColor = False
        '
        'dtDateAndDeptGrid
        '
        Me.dtDateAndDeptGrid.AllowUserToAddRows = False
        Me.dtDateAndDeptGrid.AllowUserToDeleteRows = False
        Me.dtDateAndDeptGrid.AllowUserToResizeColumns = False
        Me.dtDateAndDeptGrid.AllowUserToResizeRows = False
        Me.dtDateAndDeptGrid.BackgroundColor = System.Drawing.Color.White
        Me.dtDateAndDeptGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDateAndDeptGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDateAndDeptGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtDateAndDeptGrid.GridColor = System.Drawing.Color.Gray
        Me.dtDateAndDeptGrid.Location = New System.Drawing.Point(6, 68)
        Me.dtDateAndDeptGrid.Name = "dtDateAndDeptGrid"
        Me.dtDateAndDeptGrid.ReadOnly = True
        Me.dtDateAndDeptGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDateAndDeptGrid.Size = New System.Drawing.Size(998, 244)
        Me.dtDateAndDeptGrid.TabIndex = 11
        '
        'btnSearchByDate
        '
        Me.btnSearchByDate.BackColor = System.Drawing.Color.SlateGray
        Me.btnSearchByDate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchByDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchByDate.ForeColor = System.Drawing.Color.White
        Me.btnSearchByDate.Location = New System.Drawing.Point(616, 38)
        Me.btnSearchByDate.Name = "btnSearchByDate"
        Me.btnSearchByDate.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchByDate.TabIndex = 2
        Me.btnSearchByDate.Text = "Search"
        Me.btnSearchByDate.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(881, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 25)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Export to Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.Gray
        Me.DataGridView1.Location = New System.Drawing.Point(26, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(998, 244)
        Me.DataGridView1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SlateGray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(446, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(216, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 23)
        Me.TextBox1.TabIndex = 1
        '
        'frmReportsTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmReportsTab"
        Me.Text = "Leave Planner :: Reports"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtEmpReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtIndividualLeaveBal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtDeptReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtDateAndDeptGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtEmpReport As System.Windows.Forms.DataGridView
    Friend WithEvents btnEmpSearch As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cboDeptName As System.Windows.Forms.ComboBox
    Friend WithEvents btnExToExcelDepartment As System.Windows.Forms.Button
    Friend WithEvents dtDeptReport As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtoExcelPeriodic As System.Windows.Forms.Button
    Friend WithEvents dtDateAndDeptGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchByDate As System.Windows.Forms.Button
    Friend WithEvents dtDateAndDept2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateAndDept1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboDateandDept As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtoExcelIndividual As System.Windows.Forms.Button
    Friend WithEvents dtIndividualLeaveBal As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearchIndividualLeaveBal As System.Windows.Forms.Button
    Friend WithEvents txtInvividualLeaveBal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
