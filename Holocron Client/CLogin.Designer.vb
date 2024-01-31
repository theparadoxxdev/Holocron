<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        chkWinCred = New CheckBox()
        txtOrch = New TextBox()
        Label1 = New Label()
        txtUser = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPass = New TextBox()
        lblOrchStatus = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(15, 291)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(417, 45)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' chkWinCred
        ' 
        chkWinCred.AutoSize = True
        chkWinCred.Location = New Point(91, 258)
        chkWinCred.Margin = New Padding(4)
        chkWinCred.Name = "chkWinCred"
        chkWinCred.Size = New Size(261, 25)
        chkWinCred.TabIndex = 1
        chkWinCred.Text = "Login using Windows Credentials"
        chkWinCred.UseVisualStyleBackColor = True
        ' 
        ' txtOrch
        ' 
        txtOrch.Location = New Point(13, 47)
        txtOrch.Name = "txtOrch"
        txtOrch.Size = New Size(418, 29)
        txtOrch.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 21)
        Label1.TabIndex = 3
        Label1.Text = "Orchestrator"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(15, 166)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(417, 29)
        txtUser.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 5
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(15, 222)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(417, 29)
        txtPass.TabIndex = 6
        ' 
        ' lblOrchStatus
        ' 
        lblOrchStatus.AutoSize = True
        lblOrchStatus.Location = New Point(12, 79)
        lblOrchStatus.Name = "lblOrchStatus"
        lblOrchStatus.Size = New Size(0, 21)
        lblOrchStatus.TabIndex = 8
        lblOrchStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(443, 345)
        Controls.Add(lblOrchStatus)
        Controls.Add(Label3)
        Controls.Add(txtPass)
        Controls.Add(Label2)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Controls.Add(txtOrch)
        Controls.Add(chkWinCred)
        Controls.Add(btnLogin)
        Font = New Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "CLogin"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Holocron Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents chkWinCred As CheckBox
    Friend WithEvents txtOrch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblOrchStatus As Label

End Class
