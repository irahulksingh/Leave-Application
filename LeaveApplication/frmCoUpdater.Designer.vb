<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompOffUpdater
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
        Me.btnAddCO = New System.Windows.Forms.Button
        Me.dtCO1 = New System.Windows.Forms.DateTimePicker
        Me.txtCOdesc1 = New System.Windows.Forms.TextBox
        Me.dtGridCompOff = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.DeleteCoRecord = New System.Windows.Forms.Button
        Me.txtCoId = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dtGridCompOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddCO
        '
        Me.btnAddCO.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnAddCO.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAddCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCO.ForeColor = System.Drawing.Color.Khaki
        Me.btnAddCO.Location = New System.Drawing.Point(274, 82)
        Me.btnAddCO.Name = "btnAddCO"
        Me.btnAddCO.Size = New System.Drawing.Size(114, 23)
        Me.btnAddCO.TabIndex = 0
        Me.btnAddCO.Text = "Add Comp-Off"
        Me.btnAddCO.UseVisualStyleBackColor = False
        '
        'dtCO1
        '
        Me.dtCO1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCO1.Location = New System.Drawing.Point(92, 25)
        Me.dtCO1.Name = "dtCO1"
        Me.dtCO1.Size = New System.Drawing.Size(111, 22)
        Me.dtCO1.TabIndex = 1
        '
        'txtCOdesc1
        '
        Me.txtCOdesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCOdesc1.Location = New System.Drawing.Point(92, 54)
        Me.txtCOdesc1.Name = "txtCOdesc1"
        Me.txtCOdesc1.Size = New System.Drawing.Size(296, 22)
        Me.txtCOdesc1.TabIndex = 2
        '
        'dtGridCompOff
        '
        Me.dtGridCompOff.AllowUserToAddRows = False
        Me.dtGridCompOff.AllowUserToDeleteRows = False
        Me.dtGridCompOff.AllowUserToResizeColumns = False
        Me.dtGridCompOff.AllowUserToResizeRows = False
        Me.dtGridCompOff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGridCompOff.BackgroundColor = System.Drawing.Color.White
        Me.dtGridCompOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGridCompOff.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtGridCompOff.GridColor = System.Drawing.Color.Gray
        Me.dtGridCompOff.Location = New System.Drawing.Point(3, 46)
        Me.dtGridCompOff.Name = "dtGridCompOff"
        Me.dtGridCompOff.ReadOnly = True
        Me.dtGridCompOff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtGridCompOff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtGridCompOff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtGridCompOff.Size = New System.Drawing.Size(385, 173)
        Me.dtGridCompOff.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCOdesc1)
        Me.GroupBox1.Controls.Add(Me.dtCO1)
        Me.GroupBox1.Controls.Add(Me.btnAddCO)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 115)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Comp Off"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Date"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Khaki
        Me.Button1.Location = New System.Drawing.Point(337, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(259, 19)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(129, 22)
        Me.cboYear.TabIndex = 25
        '
        'DeleteCoRecord
        '
        Me.DeleteCoRecord.BackColor = System.Drawing.SystemColors.Desktop
        Me.DeleteCoRecord.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DeleteCoRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteCoRecord.ForeColor = System.Drawing.Color.Khaki
        Me.DeleteCoRecord.Location = New System.Drawing.Point(3, 221)
        Me.DeleteCoRecord.Name = "DeleteCoRecord"
        Me.DeleteCoRecord.Size = New System.Drawing.Size(75, 23)
        Me.DeleteCoRecord.TabIndex = 26
        Me.DeleteCoRecord.Text = "Delete"
        Me.DeleteCoRecord.UseVisualStyleBackColor = False
        '
        'txtCoId
        '
        Me.txtCoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCoId.Location = New System.Drawing.Point(364, 12)
        Me.txtCoId.Name = "txtCoId"
        Me.txtCoId.Size = New System.Drawing.Size(10, 20)
        Me.txtCoId.TabIndex = 27
        Me.txtCoId.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DeleteCoRecord)
        Me.GroupBox2.Controls.Add(Me.cboYear)
        Me.GroupBox2.Controls.Add(Me.dtGridCompOff)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 248)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comp-Off Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Select Year"
        '
        'frmCompOffUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 460)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCoId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCompOffUpdater"
        Me.Text = "Leave Planner :: Add Comp Off"
        CType(Me.dtGridCompOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCO As System.Windows.Forms.Button
    Friend WithEvents dtCO1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCOdesc1 As System.Windows.Forms.TextBox
    Friend WithEvents dtGridCompOff As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents DeleteCoRecord As System.Windows.Forms.Button
    Friend WithEvents txtCoId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
