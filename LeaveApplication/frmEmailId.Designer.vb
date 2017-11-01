<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailId
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailId))
        Me.lblUserName = New System.Windows.Forms.Label
        Me.cmdChngEmailId = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtReNewEmailId = New System.Windows.Forms.TextBox
        Me.txtNewEmailId = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(11, 118)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 18)
        Me.lblUserName.TabIndex = 17
        '
        'cmdChngEmailId
        '
        Me.cmdChngEmailId.BackColor = System.Drawing.Color.SlateGray
        Me.cmdChngEmailId.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdChngEmailId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChngEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChngEmailId.ForeColor = System.Drawing.Color.White
        Me.cmdChngEmailId.Location = New System.Drawing.Point(235, 202)
        Me.cmdChngEmailId.Name = "cmdChngEmailId"
        Me.cmdChngEmailId.Size = New System.Drawing.Size(124, 25)
        Me.cmdChngEmailId.TabIndex = 16
        Me.cmdChngEmailId.Text = "Reset Email Id"
        Me.cmdChngEmailId.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Retype New Email ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "New Email ID"
        '
        'txtReNewEmailId
        '
        Me.txtReNewEmailId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReNewEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReNewEmailId.Location = New System.Drawing.Point(177, 173)
        Me.txtReNewEmailId.Name = "txtReNewEmailId"
        Me.txtReNewEmailId.Size = New System.Drawing.Size(182, 20)
        Me.txtReNewEmailId.TabIndex = 11
        Me.txtReNewEmailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewEmailId
        '
        Me.txtNewEmailId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewEmailId.Location = New System.Drawing.Point(177, 147)
        Me.txtNewEmailId.Name = "txtNewEmailId"
        Me.txtNewEmailId.Size = New System.Drawing.Size(182, 20)
        Me.txtNewEmailId.TabIndex = 10
        Me.txtNewEmailId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.emailheader
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmEmailId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(373, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.cmdChngEmailId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReNewEmailId)
        Me.Controls.Add(Me.txtNewEmailId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmailId"
        Me.Text = "Leave Planner :: Email Id Modifier"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents cmdChngEmailId As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReNewEmailId As System.Windows.Forms.TextBox
    Friend WithEvents txtNewEmailId As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
