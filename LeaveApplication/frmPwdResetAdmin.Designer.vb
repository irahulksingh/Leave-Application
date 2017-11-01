<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPwdResetAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdReset = New System.Windows.Forms.Button
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.txtNewPwd = New System.Windows.Forms.TextBox
        Me.txtNewPwdRe = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Employee ID"
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.SlateGray
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.White
        Me.cmdReset.Location = New System.Drawing.Point(224, 228)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(89, 26)
        Me.cmdReset.TabIndex = 8
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'txtEmpName
        '
        Me.txtEmpName.BackColor = System.Drawing.Color.White
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(130, 129)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(182, 22)
        Me.txtEmpName.TabIndex = 7
        Me.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmpId
        '
        Me.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(130, 103)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(183, 22)
        Me.txtEmpId.TabIndex = 1
        Me.txtEmpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewPwd
        '
        Me.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPwd.Location = New System.Drawing.Point(130, 172)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(182, 22)
        Me.txtNewPwd.TabIndex = 12
        Me.txtNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewPwdRe
        '
        Me.txtNewPwdRe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPwdRe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPwdRe.Location = New System.Drawing.Point(131, 200)
        Me.txtNewPwdRe.Name = "txtNewPwdRe"
        Me.txtNewPwdRe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwdRe.Size = New System.Drawing.Size(182, 22)
        Me.txtNewPwdRe.TabIndex = 13
        Me.txtNewPwdRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ReenterPassword"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.PwHeader
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Employee Name"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SlateGray
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(315, 101)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmPwdResetUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPwdRe)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.txtEmpId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPwdResetUser"
        Me.Text = "Reset Password :: Leave Planner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPwdRe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
