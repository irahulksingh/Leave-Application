<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmdLogin = New System.Windows.Forms.Button
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SlateGray
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(249, 250)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 26)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.SlateGray
        Me.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.ForeColor = System.Drawing.Color.White
        Me.cmdLogin.Location = New System.Drawing.Point(396, 250)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(89, 26)
        Me.cmdLogin.TabIndex = 8
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(249, 222)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(236, 22)
        Me.txtPwd.TabIndex = 7
        Me.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLogin
        '
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(248, 187)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(237, 22)
        Me.txtLogin.TabIndex = 6
        Me.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LMS_Login3
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(650, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(652, 302)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Login :: Leave Planner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
