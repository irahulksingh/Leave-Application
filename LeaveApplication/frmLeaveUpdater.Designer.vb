<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaveUpdater
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtLeaveBalance = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCompOffBal = New System.Windows.Forms.TextBox
        Me.btnUpdateLeaveBal = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPLeaveBal = New System.Windows.Forms.TextBox
        Me.btnLeaveSearch = New System.Windows.Forms.Button
        Me.txtLeaveEmpId = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtLeaveBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtLeaveBalance)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtCompOffBal)
        Me.GroupBox4.Controls.Add(Me.btnUpdateLeaveBal)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtPLeaveBal)
        Me.GroupBox4.Controls.Add(Me.btnLeaveSearch)
        Me.GroupBox4.Controls.Add(Me.txtLeaveEmpId)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(532, 201)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Update Leave Balance"
        '
        'dtLeaveBalance
        '
        Me.dtLeaveBalance.AllowUserToAddRows = False
        Me.dtLeaveBalance.AllowUserToDeleteRows = False
        Me.dtLeaveBalance.AllowUserToResizeColumns = False
        Me.dtLeaveBalance.AllowUserToResizeRows = False
        Me.dtLeaveBalance.BackgroundColor = System.Drawing.Color.White
        Me.dtLeaveBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtLeaveBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtLeaveBalance.Location = New System.Drawing.Point(13, 66)
        Me.dtLeaveBalance.Name = "dtLeaveBalance"
        Me.dtLeaveBalance.ReadOnly = True
        Me.dtLeaveBalance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtLeaveBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtLeaveBalance.Size = New System.Drawing.Size(513, 73)
        Me.dtLeaveBalance.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(252, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 16)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Comp Off Balance"
        '
        'txtCompOffBal
        '
        Me.txtCompOffBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompOffBal.Location = New System.Drawing.Point(249, 170)
        Me.txtCompOffBal.Name = "txtCompOffBal"
        Me.txtCompOffBal.Size = New System.Drawing.Size(179, 23)
        Me.txtCompOffBal.TabIndex = 4
        Me.txtCompOffBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateLeaveBal
        '
        Me.btnUpdateLeaveBal.BackColor = System.Drawing.Color.SlateGray
        Me.btnUpdateLeaveBal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateLeaveBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateLeaveBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateLeaveBal.ForeColor = System.Drawing.Color.White
        Me.btnUpdateLeaveBal.Location = New System.Drawing.Point(434, 169)
        Me.btnUpdateLeaveBal.Name = "btnUpdateLeaveBal"
        Me.btnUpdateLeaveBal.Size = New System.Drawing.Size(69, 23)
        Me.btnUpdateLeaveBal.TabIndex = 5
        Me.btnUpdateLeaveBal.Text = "Update"
        Me.btnUpdateLeaveBal.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(15, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "PL Balance"
        '
        'txtPLeaveBal
        '
        Me.txtPLeaveBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLeaveBal.Location = New System.Drawing.Point(12, 170)
        Me.txtPLeaveBal.Name = "txtPLeaveBal"
        Me.txtPLeaveBal.Size = New System.Drawing.Size(179, 23)
        Me.txtPLeaveBal.TabIndex = 3
        Me.txtPLeaveBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLeaveSearch
        '
        Me.btnLeaveSearch.BackColor = System.Drawing.Color.SlateGray
        Me.btnLeaveSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLeaveSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaveSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaveSearch.ForeColor = System.Drawing.Color.White
        Me.btnLeaveSearch.Location = New System.Drawing.Point(291, 34)
        Me.btnLeaveSearch.Name = "btnLeaveSearch"
        Me.btnLeaveSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnLeaveSearch.TabIndex = 2
        Me.btnLeaveSearch.Text = "Search"
        Me.btnLeaveSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLeaveSearch.UseVisualStyleBackColor = False
        '
        'txtLeaveEmpId
        '
        Me.txtLeaveEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeaveEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaveEmpId.Location = New System.Drawing.Point(108, 35)
        Me.txtLeaveEmpId.Name = "txtLeaveEmpId"
        Me.txtLeaveEmpId.Size = New System.Drawing.Size(179, 22)
        Me.txtLeaveEmpId.TabIndex = 1
        Me.txtLeaveEmpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Employee ID"
        '
        'frmLeaveUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(541, 205)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLeaveUpdater"
        Me.Text = "Leave Planner :: Updater"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtLeaveBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCompOffBal As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateLeaveBal As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPLeaveBal As System.Windows.Forms.TextBox
    Friend WithEvents btnLeaveSearch As System.Windows.Forms.Button
    Friend WithEvents txtLeaveEmpId As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtLeaveBalance As System.Windows.Forms.DataGridView
End Class
