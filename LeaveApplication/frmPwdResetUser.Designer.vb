<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPwdResetUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPwdResetUser))
        Me.txtNewPwd = New System.Windows.Forms.TextBox
        Me.txtReNewPwd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdChngPwd = New System.Windows.Forms.Button
        Me.lblUserName = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNewPwd
        '
        Me.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPwd.Location = New System.Drawing.Point(162, 147)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(182, 20)
        Me.txtNewPwd.TabIndex = 0
        Me.txtNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReNewPwd
        '
        Me.txtReNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReNewPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReNewPwd.Location = New System.Drawing.Point(162, 173)
        Me.txtReNewPwd.Name = "txtReNewPwd"
        Me.txtReNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReNewPwd.Size = New System.Drawing.Size(182, 20)
        Me.txtReNewPwd.TabIndex = 1
        Me.txtReNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Retype New Password"
        '
        'cmdChngPwd
        '
        Me.cmdChngPwd.BackColor = System.Drawing.Color.SlateGray
        Me.cmdChngPwd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdChngPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChngPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChngPwd.ForeColor = System.Drawing.Color.White
        Me.cmdChngPwd.Location = New System.Drawing.Point(220, 201)
        Me.cmdChngPwd.Name = "cmdChngPwd"
        Me.cmdChngPwd.Size = New System.Drawing.Size(124, 26)
        Me.cmdChngPwd.TabIndex = 8
        Me.cmdChngPwd.Text = "Reset Password"
        Me.cmdChngPwd.UseVisualStyleBackColor = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(14, 106)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 18)
        Me.lblUserName.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.PwHeader
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmPwdResetUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(377, 268)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.cmdChngPwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReNewPwd)
        Me.Controls.Add(Me.txtNewPwd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPwdResetUser"
        Me.Text = "Password Reset :: Leave Planner"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtReNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmdChngPwd As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
