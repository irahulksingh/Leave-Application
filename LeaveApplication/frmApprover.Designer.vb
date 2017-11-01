<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprover))
        Me.dtGridViewLeaveDetails = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTypeOfLeave = New System.Windows.Forms.TextBox
        Me.txtLeaveId = New System.Windows.Forms.TextBox
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNoOfDays = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboDecisionBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.txtLeaveStartDate = New System.Windows.Forms.TextBox
        Me.txtLeaveEnddate = New System.Windows.Forms.TextBox
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblUserHistory = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtApplicantHistory = New System.Windows.Forms.DataGridView
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblRequestInfo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblUserInfo = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetEmailIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LeaveUpdaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblApplicantName = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblCompOffDetails = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblAppName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TestToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeEnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.AddCompOffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LeaveUpdatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetUserPasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dtGridViewLeaveDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtApplicantHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtGridViewLeaveDetails
        '
        Me.dtGridViewLeaveDetails.AllowUserToAddRows = False
        Me.dtGridViewLeaveDetails.AllowUserToDeleteRows = False
        Me.dtGridViewLeaveDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridViewLeaveDetails.BackgroundColor = System.Drawing.Color.White
        Me.dtGridViewLeaveDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtGridViewLeaveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridViewLeaveDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGridViewLeaveDetails.Location = New System.Drawing.Point(6, 18)
        Me.dtGridViewLeaveDetails.Name = "dtGridViewLeaveDetails"
        Me.dtGridViewLeaveDetails.ReadOnly = True
        Me.dtGridViewLeaveDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtGridViewLeaveDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtGridViewLeaveDetails.Size = New System.Drawing.Size(1070, 177)
        Me.dtGridViewLeaveDetails.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Employee Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Leave Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Leave End Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTypeOfLeave)
        Me.GroupBox1.Controls.Add(Me.txtLeaveId)
        Me.GroupBox1.Controls.Add(Me.txtEmpId)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboDecisionBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLeaveStartDate)
        Me.GroupBox1.Controls.Add(Me.txtLeaveEnddate)
        Me.GroupBox1.Controls.Add(Me.txtEmpName)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(79, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 268)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Type Of Leave"
        '
        'txtTypeOfLeave
        '
        Me.txtTypeOfLeave.BackColor = System.Drawing.Color.White
        Me.txtTypeOfLeave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTypeOfLeave.Enabled = False
        Me.txtTypeOfLeave.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeOfLeave.Location = New System.Drawing.Point(187, 123)
        Me.txtTypeOfLeave.Name = "txtTypeOfLeave"
        Me.txtTypeOfLeave.Size = New System.Drawing.Size(253, 23)
        Me.txtTypeOfLeave.TabIndex = 22
        Me.txtTypeOfLeave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeaveId
        '
        Me.txtLeaveId.Location = New System.Drawing.Point(59, 227)
        Me.txtLeaveId.Name = "txtLeaveId"
        Me.txtLeaveId.Size = New System.Drawing.Size(39, 23)
        Me.txtLeaveId.TabIndex = 21
        Me.txtLeaveId.Visible = False
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(14, 227)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(39, 23)
        Me.txtEmpId.TabIndex = 20
        Me.txtEmpId.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "No. Of Days"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.BackColor = System.Drawing.Color.White
        Me.txtNoOfDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfDays.Enabled = False
        Me.txtNoOfDays.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfDays.Location = New System.Drawing.Point(187, 98)
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(253, 23)
        Me.txtNoOfDays.TabIndex = 18
        Me.txtNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.SlateGray
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(347, 223)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(97, 30)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(11, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Approve/ Declined"
        '
        'cboDecisionBox
        '
        Me.cboDecisionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecisionBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDecisionBox.FormattingEnabled = True
        Me.cboDecisionBox.ItemHeight = 16
        Me.cboDecisionBox.Location = New System.Drawing.Point(187, 192)
        Me.cboDecisionBox.Name = "cboDecisionBox"
        Me.cboDecisionBox.Size = New System.Drawing.Size(253, 24)
        Me.cboDecisionBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Comments (If Any)"
        '
        'txtComments
        '
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.Location = New System.Drawing.Point(187, 148)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(253, 42)
        Me.txtComments.TabIndex = 1
        '
        'txtLeaveStartDate
        '
        Me.txtLeaveStartDate.BackColor = System.Drawing.Color.White
        Me.txtLeaveStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeaveStartDate.Enabled = False
        Me.txtLeaveStartDate.Location = New System.Drawing.Point(187, 48)
        Me.txtLeaveStartDate.Name = "txtLeaveStartDate"
        Me.txtLeaveStartDate.Size = New System.Drawing.Size(253, 23)
        Me.txtLeaveStartDate.TabIndex = 8
        Me.txtLeaveStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeaveEnddate
        '
        Me.txtLeaveEnddate.BackColor = System.Drawing.Color.White
        Me.txtLeaveEnddate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeaveEnddate.Enabled = False
        Me.txtLeaveEnddate.Location = New System.Drawing.Point(187, 73)
        Me.txtLeaveEnddate.Name = "txtLeaveEnddate"
        Me.txtLeaveEnddate.Size = New System.Drawing.Size(253, 23)
        Me.txtLeaveEnddate.TabIndex = 7
        Me.txtLeaveEnddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.Color.White
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(187, 23)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(253, 23)
        Me.txtEmpName.TabIndex = 6
        Me.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUserHistory)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtApplicantHistory)
        Me.GroupBox2.Controls.Add(Me.dtGridViewLeaveDetails)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(79, 494)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1082, 381)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leave Application List"
        '
        'lblUserHistory
        '
        Me.lblUserHistory.AutoSize = True
        Me.lblUserHistory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserHistory.ForeColor = System.Drawing.Color.Red
        Me.lblUserHistory.Location = New System.Drawing.Point(173, 206)
        Me.lblUserHistory.Name = "lblUserHistory"
        Me.lblUserHistory.Size = New System.Drawing.Size(65, 16)
        Me.lblUserHistory.TabIndex = 28
        Me.lblUserHistory.Text = "No Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Application History for:"
        '
        'dtApplicantHistory
        '
        Me.dtApplicantHistory.AllowUserToAddRows = False
        Me.dtApplicantHistory.AllowUserToDeleteRows = False
        Me.dtApplicantHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtApplicantHistory.BackgroundColor = System.Drawing.Color.White
        Me.dtApplicantHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtApplicantHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtApplicantHistory.Location = New System.Drawing.Point(6, 227)
        Me.dtApplicantHistory.Name = "dtApplicantHistory"
        Me.dtApplicantHistory.ReadOnly = True
        Me.dtApplicantHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtApplicantHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtApplicantHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtApplicantHistory.Size = New System.Drawing.Size(1070, 148)
        Me.dtApplicantHistory.TabIndex = 26
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblUser.Location = New System.Drawing.Point(75, 196)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 19)
        Me.lblUser.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Number of Request Pending:"
        '
        'lblRequestInfo
        '
        Me.lblRequestInfo.AutoSize = True
        Me.lblRequestInfo.BackColor = System.Drawing.Color.White
        Me.lblRequestInfo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestInfo.ForeColor = System.Drawing.Color.Red
        Me.lblRequestInfo.Location = New System.Drawing.Point(210, 19)
        Me.lblRequestInfo.Name = "lblRequestInfo"
        Me.lblRequestInfo.Size = New System.Drawing.Size(64, 16)
        Me.lblRequestInfo.TabIndex = 19
        Me.lblRequestInfo.Text = "No data"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Manager
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblUserInfo.Font = New System.Drawing.Font("Eras Light ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfo.Location = New System.Drawing.Point(425, 57)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblUserInfo.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblUserInfo)
        Me.GroupBox3.Controls.Add(Me.lblRequestInfo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(535, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 46)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info. Box"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetEmailIDToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.FileToolStripMenuItem.Text = "Options"
        '
        'ResetEmailIDToolStripMenuItem
        '
        Me.ResetEmailIDToolStripMenuItem.Name = "ResetEmailIDToolStripMenuItem"
        Me.ResetEmailIDToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ResetEmailIDToolStripMenuItem.Text = "Reset Email ID"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem1, Me.LeaveUpdaterToolStripMenuItem})
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.CustomizeToolStripMenuItem.Text = "Customize"
        '
        'CustomizeToolStripMenuItem1
        '
        Me.CustomizeToolStripMenuItem1.Name = "CustomizeToolStripMenuItem1"
        Me.CustomizeToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.CustomizeToolStripMenuItem1.Text = "Customize"
        '
        'LeaveUpdaterToolStripMenuItem
        '
        Me.LeaveUpdaterToolStripMenuItem.Name = "LeaveUpdaterToolStripMenuItem"
        Me.LeaveUpdaterToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LeaveUpdaterToolStripMenuItem.Text = "Leave Updater"
        '
        'ResetPasswordToolStripMenuItem
        '
        Me.ResetPasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetPasswordToolStripMenuItem1})
        Me.ResetPasswordToolStripMenuItem.Name = "ResetPasswordToolStripMenuItem"
        Me.ResetPasswordToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.ResetPasswordToolStripMenuItem.Text = "Reset"
        '
        'ResetPasswordToolStripMenuItem1
        '
        Me.ResetPasswordToolStripMenuItem1.Name = "ResetPasswordToolStripMenuItem1"
        Me.ResetPasswordToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ResetPasswordToolStripMenuItem1.Text = "Password Reset"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblApplicantName)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.lblCompOffDetails)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblAppName)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(535, 270)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 82)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Applicant Info."
        '
        'lblApplicantName
        '
        Me.lblApplicantName.AutoSize = True
        Me.lblApplicantName.BackColor = System.Drawing.Color.White
        Me.lblApplicantName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblApplicantName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicantName.ForeColor = System.Drawing.Color.Red
        Me.lblApplicantName.Location = New System.Drawing.Point(134, 19)
        Me.lblApplicantName.Name = "lblApplicantName"
        Me.lblApplicantName.Size = New System.Drawing.Size(65, 16)
        Me.lblApplicantName.TabIndex = 27
        Me.lblApplicantName.Text = "No Data"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Applicant Name:"
        '
        'lblCompOffDetails
        '
        Me.lblCompOffDetails.AutoSize = True
        Me.lblCompOffDetails.BackColor = System.Drawing.Color.White
        Me.lblCompOffDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblCompOffDetails.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompOffDetails.ForeColor = System.Drawing.Color.Red
        Me.lblCompOffDetails.Location = New System.Drawing.Point(195, 60)
        Me.lblCompOffDetails.Name = "lblCompOffDetails"
        Me.lblCompOffDetails.Size = New System.Drawing.Size(65, 16)
        Me.lblCompOffDetails.TabIndex = 25
        Me.lblCompOffDetails.Text = "No Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "No. of Comp-Off Available:"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.BackColor = System.Drawing.Color.White
        Me.lblAppName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAppName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.Red
        Me.lblAppName.Location = New System.Drawing.Point(195, 44)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(65, 16)
        Me.lblAppName.TabIndex = 23
        Me.lblAppName.Text = "No Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No. of PL Available:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem1, Me.CustomizeToolStripMenuItem4, Me.ReportsToolStripMenuItem6})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1446, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem2, Me.ChangeEnToolStripMenuItem, Me.ExitToolStripMenuItem2})
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(42, 20)
        Me.TestToolStripMenuItem1.Text = "File"
        '
        'TestToolStripMenuItem2
        '
        Me.TestToolStripMenuItem2.Name = "TestToolStripMenuItem2"
        Me.TestToolStripMenuItem2.Size = New System.Drawing.Size(205, 22)
        Me.TestToolStripMenuItem2.Text = "Change Password"
        '
        'ChangeEnToolStripMenuItem
        '
        Me.ChangeEnToolStripMenuItem.Name = "ChangeEnToolStripMenuItem"
        Me.ChangeEnToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ChangeEnToolStripMenuItem.Text = "Change Email Id"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(205, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'CustomizeToolStripMenuItem4
        '
        Me.CustomizeToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem5, Me.AddCompOffToolStripMenuItem1, Me.LeaveUpdatToolStripMenuItem, Me.ResetUserPasswordToolStripMenuItem1})
        Me.CustomizeToolStripMenuItem4.Name = "CustomizeToolStripMenuItem4"
        Me.CustomizeToolStripMenuItem4.Size = New System.Drawing.Size(55, 20)
        Me.CustomizeToolStripMenuItem4.Text = "Tools"
        '
        'CustomizeToolStripMenuItem5
        '
        Me.CustomizeToolStripMenuItem5.Name = "CustomizeToolStripMenuItem5"
        Me.CustomizeToolStripMenuItem5.Size = New System.Drawing.Size(227, 22)
        Me.CustomizeToolStripMenuItem5.Text = "Customize"
        '
        'AddCompOffToolStripMenuItem1
        '
        Me.AddCompOffToolStripMenuItem1.Name = "AddCompOffToolStripMenuItem1"
        Me.AddCompOffToolStripMenuItem1.Size = New System.Drawing.Size(227, 22)
        Me.AddCompOffToolStripMenuItem1.Text = "Add Comp-Off"
        '
        'LeaveUpdatToolStripMenuItem
        '
        Me.LeaveUpdatToolStripMenuItem.Name = "LeaveUpdatToolStripMenuItem"
        Me.LeaveUpdatToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.LeaveUpdatToolStripMenuItem.Text = "Leave Updater"
        '
        'ResetUserPasswordToolStripMenuItem1
        '
        Me.ResetUserPasswordToolStripMenuItem1.Name = "ResetUserPasswordToolStripMenuItem1"
        Me.ResetUserPasswordToolStripMenuItem1.Size = New System.Drawing.Size(227, 22)
        Me.ResetUserPasswordToolStripMenuItem1.Text = "Reset User Password"
        '
        'ReportsToolStripMenuItem6
        '
        Me.ReportsToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem7})
        Me.ReportsToolStripMenuItem6.Name = "ReportsToolStripMenuItem6"
        Me.ReportsToolStripMenuItem6.Size = New System.Drawing.Size(70, 20)
        Me.ReportsToolStripMenuItem6.Text = "Reports"
        '
        'ReportsToolStripMenuItem7
        '
        Me.ReportsToolStripMenuItem7.Name = "ReportsToolStripMenuItem7"
        Me.ReportsToolStripMenuItem7.Size = New System.Drawing.Size(139, 22)
        Me.ReportsToolStripMenuItem7.Text = "Reports"
        '
        'frmApprover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1446, 887)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApprover"
        Me.Text = "Manager :: Leave Planner"
        CType(Me.dtGridViewLeaveDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtApplicantHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtGridViewLeaveDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents txtLeaveStartDate As System.Windows.Forms.TextBox
    Friend WithEvents txtLeaveEnddate As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDecisionBox As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfDays As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtLeaveId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblRequestInfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetPasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetEmailIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtApplicantHistory As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUserHistory As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTypeOfLeave As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCompOffDetails As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblApplicantName As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LeaveUpdaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TestToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCompOffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveUpdatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetUserPasswordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeEnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
