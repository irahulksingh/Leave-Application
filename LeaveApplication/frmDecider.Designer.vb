<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecider
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
        Me.btnManagerLogin = New System.Windows.Forms.Button
        Me.btnSuserLogin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnManagerLogin
        '
        Me.btnManagerLogin.BackColor = System.Drawing.Color.White
        Me.btnManagerLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnManagerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagerLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagerLogin.Location = New System.Drawing.Point(74, 37)
        Me.btnManagerLogin.Name = "btnManagerLogin"
        Me.btnManagerLogin.Size = New System.Drawing.Size(245, 30)
        Me.btnManagerLogin.TabIndex = 1
        Me.btnManagerLogin.Text = "Manager"
        Me.btnManagerLogin.UseVisualStyleBackColor = False
        '
        'btnSuserLogin
        '
        Me.btnSuserLogin.BackColor = System.Drawing.Color.White
        Me.btnSuserLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnSuserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuserLogin.Location = New System.Drawing.Point(74, 76)
        Me.btnSuserLogin.Name = "btnSuserLogin"
        Me.btnSuserLogin.Size = New System.Drawing.Size(243, 30)
        Me.btnSuserLogin.TabIndex = 2
        Me.btnSuserLogin.Text = "Super User"
        Me.btnSuserLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login As :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSuserLogin)
        Me.Panel1.Controls.Add(Me.btnManagerLogin)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 127)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.x2
        Me.PictureBox1.Location = New System.Drawing.Point(349, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmDecider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(370, 131)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDecider"
        Me.Text = "Manager/Superuser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnManagerLogin As System.Windows.Forms.Button
    Friend WithEvents btnSuserLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
