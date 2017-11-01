<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.dtReports = New System.Windows.Forms.DataGridView
        Me.btnExportToExcel = New System.Windows.Forms.Button
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.rbutEmpId = New System.Windows.Forms.RadioButton
        Me.rbutTeamWise = New System.Windows.Forms.RadioButton
        Me.cboDeptName = New System.Windows.Forms.ComboBox
        Me.btnSearchTeam = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.dtReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtReports
        '
        Me.dtReports.AllowUserToAddRows = False
        Me.dtReports.AllowUserToDeleteRows = False
        Me.dtReports.AllowUserToResizeColumns = False
        Me.dtReports.AllowUserToResizeRows = False
        Me.dtReports.BackgroundColor = System.Drawing.Color.White
        Me.dtReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtReports.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtReports.GridColor = System.Drawing.Color.Gray
        Me.dtReports.Location = New System.Drawing.Point(13, 135)
        Me.dtReports.Name = "dtReports"
        Me.dtReports.ReadOnly = True
        Me.dtReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtReports.Size = New System.Drawing.Size(998, 244)
        Me.dtReports.TabIndex = 11
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.BackColor = System.Drawing.Color.SlateGray
        Me.btnExportToExcel.Enabled = False
        Me.btnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportToExcel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportToExcel.Location = New System.Drawing.Point(881, 388)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(131, 25)
        Me.btnExportToExcel.TabIndex = 12
        Me.btnExportToExcel.Text = "Export to Excel"
        Me.btnExportToExcel.UseVisualStyleBackColor = False
        '
        'txtEmpId
        '
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(20, 38)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(175, 23)
        Me.txtEmpId.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.SlateGray
        Me.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(949, 589)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 24)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "Close"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SlateGray
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(201, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'rbutEmpId
        '
        Me.rbutEmpId.AutoSize = True
        Me.rbutEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbutEmpId.Location = New System.Drawing.Point(20, 15)
        Me.rbutEmpId.Name = "rbutEmpId"
        Me.rbutEmpId.Size = New System.Drawing.Size(173, 20)
        Me.rbutEmpId.TabIndex = 0
        Me.rbutEmpId.TabStop = True
        Me.rbutEmpId.Text = "Search with Employee Id"
        Me.rbutEmpId.UseVisualStyleBackColor = True
        '
        'rbutTeamWise
        '
        Me.rbutTeamWise.AutoSize = True
        Me.rbutTeamWise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbutTeamWise.Location = New System.Drawing.Point(321, 17)
        Me.rbutTeamWise.Name = "rbutTeamWise"
        Me.rbutTeamWise.Size = New System.Drawing.Size(170, 20)
        Me.rbutTeamWise.TabIndex = 4
        Me.rbutTeamWise.TabStop = True
        Me.rbutTeamWise.Text = "Search with Deptartment"
        Me.rbutTeamWise.UseVisualStyleBackColor = True
        '
        'cboDeptName
        '
        Me.cboDeptName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptName.FormattingEnabled = True
        Me.cboDeptName.Location = New System.Drawing.Point(321, 40)
        Me.cboDeptName.Name = "cboDeptName"
        Me.cboDeptName.Size = New System.Drawing.Size(133, 24)
        Me.cboDeptName.TabIndex = 5
        '
        'btnSearchTeam
        '
        Me.btnSearchTeam.BackColor = System.Drawing.Color.SlateGray
        Me.btnSearchTeam.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearchTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchTeam.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchTeam.ForeColor = System.Drawing.Color.White
        Me.btnSearchTeam.Location = New System.Drawing.Point(460, 40)
        Me.btnSearchTeam.Name = "btnSearchTeam"
        Me.btnSearchTeam.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchTeam.TabIndex = 6
        Me.btnSearchTeam.Text = "Search"
        Me.btnSearchTeam.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Reports
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1600, 150)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchTeam)
        Me.GroupBox1.Controls.Add(Me.cboDeptName)
        Me.GroupBox1.Controls.Add(Me.btnExportToExcel)
        Me.GroupBox1.Controls.Add(Me.rbutTeamWise)
        Me.GroupBox1.Controls.Add(Me.dtReports)
        Me.GroupBox1.Controls.Add(Me.rbutEmpId)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtEmpId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 425)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1058, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReports"
        Me.Text = "Reports :: Leave Planner"
        CType(Me.dtReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents dtReports As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportToExcel As System.Windows.Forms.Button
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbutEmpId As System.Windows.Forms.RadioButton
    Friend WithEvents rbutTeamWise As System.Windows.Forms.RadioButton
    Friend WithEvents cboDeptName As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchTeam As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
