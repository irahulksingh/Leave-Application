<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomize))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboDept = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboUserRole = New System.Windows.Forms.ComboBox
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.DojPicker = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboReportingManager = New System.Windows.Forms.ComboBox
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdReset = New System.Windows.Forms.Button
        Me.cmdDeleteEmp = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboDeptEdit = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboRoleEdit = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DojPicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboManagerEdit = New System.Windows.Forms.ComboBox
        Me.txtSempName = New System.Windows.Forms.TextBox
        Me.txtSempId = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtNewDept = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdAddDept = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.lblUser = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPLBal = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCOBal = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCOBal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPLBal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboDept)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboUserRole)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DojPicker)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboReportingManager)
        Me.GroupBox1.Controls.Add(Me.txtEmpName)
        Me.GroupBox1.Controls.Add(Me.txtEmpId)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 295)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New User"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Department"
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(147, 148)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(260, 24)
        Me.cboDept.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "User Role"
        '
        'cboUserRole
        '
        Me.cboUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserRole.FormattingEnabled = True
        Me.cboUserRole.Location = New System.Drawing.Point(147, 118)
        Me.cboUserRole.Name = "cboUserRole"
        Me.cboUserRole.Size = New System.Drawing.Size(260, 24)
        Me.cboUserRole.TabIndex = 5
        '
        'cmdAddNew
        '
        Me.cmdAddNew.BackColor = System.Drawing.Color.SlateGray
        Me.cmdAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.ForeColor = System.Drawing.Color.White
        Me.cmdAddNew.Location = New System.Drawing.Point(326, 261)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(81, 28)
        Me.cmdAddNew.TabIndex = 8
        Me.cmdAddNew.Text = "Add New"
        Me.cmdAddNew.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Reporting Manager"
        '
        'DojPicker
        '
        Me.DojPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DojPicker.Location = New System.Drawing.Point(147, 88)
        Me.DojPicker.Name = "DojPicker"
        Me.DojPicker.Size = New System.Drawing.Size(115, 23)
        Me.DojPicker.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date Of Joining"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee ID"
        '
        'cboReportingManager
        '
        Me.cboReportingManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportingManager.FormattingEnabled = True
        Me.cboReportingManager.Location = New System.Drawing.Point(147, 180)
        Me.cboReportingManager.Name = "cboReportingManager"
        Me.cboReportingManager.Size = New System.Drawing.Size(260, 24)
        Me.cboReportingManager.TabIndex = 7
        '
        'txtEmpName
        '
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Location = New System.Drawing.Point(147, 59)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(260, 23)
        Me.txtEmpName.TabIndex = 1
        '
        'txtEmpId
        '
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Location = New System.Drawing.Point(147, 30)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(260, 23)
        Me.txtEmpId.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdReset)
        Me.GroupBox2.Controls.Add(Me.cmdDeleteEmp)
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboDeptEdit)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboRoleEdit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DojPicker1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cboManagerEdit)
        Me.GroupBox2.Controls.Add(Me.txtSempName)
        Me.GroupBox2.Controls.Add(Me.txtSempId)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(532, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 289)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search/Delete User"
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.SlateGray
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.White
        Me.cmdReset.Location = New System.Drawing.Point(286, 246)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(116, 28)
        Me.cmdReset.TabIndex = 17
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdDeleteEmp
        '
        Me.cmdDeleteEmp.BackColor = System.Drawing.Color.IndianRed
        Me.cmdDeleteEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeleteEmp.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteEmp.ForeColor = System.Drawing.Color.White
        Me.cmdDeleteEmp.Location = New System.Drawing.Point(408, 246)
        Me.cmdDeleteEmp.Name = "cmdDeleteEmp"
        Me.cmdDeleteEmp.Size = New System.Drawing.Size(72, 28)
        Me.cmdDeleteEmp.TabIndex = 16
        Me.cmdDeleteEmp.Text = "Delete"
        Me.cmdDeleteEmp.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.SlateGray
        Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Location = New System.Drawing.Point(430, 56)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(68, 23)
        Me.cmdSearch.TabIndex = 10
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Department"
        '
        'cboDeptEdit
        '
        Me.cboDeptEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptEdit.FormattingEnabled = True
        Me.cboDeptEdit.Location = New System.Drawing.Point(164, 175)
        Me.cboDeptEdit.Name = "cboDeptEdit"
        Me.cboDeptEdit.Size = New System.Drawing.Size(260, 24)
        Me.cboDeptEdit.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "User Role"
        '
        'cboRoleEdit
        '
        Me.cboRoleEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoleEdit.FormattingEnabled = True
        Me.cboRoleEdit.Location = New System.Drawing.Point(164, 145)
        Me.cboRoleEdit.Name = "cboRoleEdit"
        Me.cboRoleEdit.Size = New System.Drawing.Size(260, 24)
        Me.cboRoleEdit.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Reporting Manager"
        '
        'DojPicker1
        '
        Me.DojPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DojPicker1.Location = New System.Drawing.Point(164, 115)
        Me.DojPicker1.Name = "DojPicker1"
        Me.DojPicker1.Size = New System.Drawing.Size(115, 23)
        Me.DojPicker1.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(27, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Date Of Joining"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Employee Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Employee ID"
        '
        'cboManagerEdit
        '
        Me.cboManagerEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboManagerEdit.FormattingEnabled = True
        Me.cboManagerEdit.Location = New System.Drawing.Point(164, 207)
        Me.cboManagerEdit.Name = "cboManagerEdit"
        Me.cboManagerEdit.Size = New System.Drawing.Size(260, 24)
        Me.cboManagerEdit.TabIndex = 15
        '
        'txtSempName
        '
        Me.txtSempName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSempName.Location = New System.Drawing.Point(164, 86)
        Me.txtSempName.Name = "txtSempName"
        Me.txtSempName.Size = New System.Drawing.Size(260, 23)
        Me.txtSempName.TabIndex = 11
        '
        'txtSempId
        '
        Me.txtSempId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSempId.Location = New System.Drawing.Point(164, 57)
        Me.txtSempId.Name = "txtSempId"
        Me.txtSempId.Size = New System.Drawing.Size(260, 23)
        Me.txtSempId.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 16)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Department Name"
        '
        'txtNewDept
        '
        Me.txtNewDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewDept.Location = New System.Drawing.Point(147, 22)
        Me.txtNewDept.Name = "txtNewDept"
        Me.txtNewDept.Size = New System.Drawing.Size(260, 23)
        Me.txtNewDept.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAddDept)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtNewDept)
        Me.GroupBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 487)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(498, 74)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "New Department"
        '
        'cmdAddDept
        '
        Me.cmdAddDept.BackColor = System.Drawing.Color.SlateGray
        Me.cmdAddDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAddDept.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddDept.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddDept.ForeColor = System.Drawing.Color.White
        Me.cmdAddDept.Location = New System.Drawing.Point(413, 22)
        Me.cmdAddDept.Name = "cmdAddDept"
        Me.cmdAddDept.Size = New System.Drawing.Size(68, 23)
        Me.cmdAddDept.TabIndex = 33
        Me.cmdAddDept.Text = "Add"
        Me.cmdAddDept.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Location = New System.Drawing.Point(944, 516)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(94, 32)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "Close"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblUser.Location = New System.Drawing.Point(19, 134)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 19)
        Me.lblUser.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.CustomizeHeader
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PL Balance"
        '
        'txtPLBal
        '
        Me.txtPLBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLBal.Location = New System.Drawing.Point(147, 210)
        Me.txtPLBal.Name = "txtPLBal"
        Me.txtPLBal.Size = New System.Drawing.Size(105, 23)
        Me.txtPLBal.TabIndex = 16
        Me.txtPLBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CO Balance"
        '
        'txtCOBal
        '
        Me.txtCOBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOBal.Location = New System.Drawing.Point(147, 239)
        Me.txtCOBal.Name = "txtCOBal"
        Me.txtCOBal.Size = New System.Drawing.Size(105, 23)
        Me.txtCOBal.TabIndex = 18
        Me.txtCOBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1062, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomize"
        Me.Text = "Customize :: Leave Planner"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboReportingManager As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents DojPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboUserRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboDeptEdit As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboRoleEdit As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DojPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboManagerEdit As System.Windows.Forms.ComboBox
    Friend WithEvents txtSempName As System.Windows.Forms.TextBox
    Friend WithEvents txtSempId As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtNewDept As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdAddDept As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteEmp As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPLBal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCOBal As System.Windows.Forms.TextBox
End Class
