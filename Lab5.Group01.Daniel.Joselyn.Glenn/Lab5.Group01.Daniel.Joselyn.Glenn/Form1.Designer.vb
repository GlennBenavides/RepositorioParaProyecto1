<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSingIn = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.ckbxManager = New System.Windows.Forms.CheckBox()
        Me.ckbxAllmightyAdmin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnSingIn
        '
        Me.btnSingIn.Location = New System.Drawing.Point(220, 365)
        Me.btnSingIn.Name = "btnSingIn"
        Me.btnSingIn.Size = New System.Drawing.Size(75, 23)
        Me.btnSingIn.TabIndex = 0
        Me.btnSingIn.Text = "Sing In"
        Me.btnSingIn.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(504, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(266, 78)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(196, 31)
        Me.txtUserName.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(266, 179)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(196, 29)
        Me.txtPassword.TabIndex = 3
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(322, 47)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 13)
        Me.lblUserName.TabIndex = 4
        Me.lblUserName.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(324, 144)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'ckbxManager
        '
        Me.ckbxManager.AutoSize = True
        Me.ckbxManager.Location = New System.Drawing.Point(294, 247)
        Me.ckbxManager.Name = "ckbxManager"
        Me.ckbxManager.Size = New System.Drawing.Size(83, 17)
        Me.ckbxManager.TabIndex = 6
        Me.ckbxManager.Text = "Administrate"
        Me.ckbxManager.UseVisualStyleBackColor = True
        '
        'ckbxAllmightyAdmin
        '
        Me.ckbxAllmightyAdmin.AutoSize = True
        Me.ckbxAllmightyAdmin.Location = New System.Drawing.Point(294, 286)
        Me.ckbxAllmightyAdmin.Name = "ckbxAllmightyAdmin"
        Me.ckbxAllmightyAdmin.Size = New System.Drawing.Size(99, 17)
        Me.ckbxAllmightyAdmin.TabIndex = 7
        Me.ckbxAllmightyAdmin.Text = "Allmighty Admin"
        Me.ckbxAllmightyAdmin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(769, 424)
        Me.Controls.Add(Me.ckbxAllmightyAdmin)
        Me.Controls.Add(Me.ckbxManager)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSingIn)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSingIn As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents ckbxManager As System.Windows.Forms.CheckBox
    Friend WithEvents ckbxAllmightyAdmin As System.Windows.Forms.CheckBox

End Class
