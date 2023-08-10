<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FillingForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FillingForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.rdbHomePhone = New System.Windows.Forms.RadioButton()
        Me.rdbMobilePhone = New System.Windows.Forms.RadioButton()
        Me.mskPhoneNumbers = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkSite = New System.Windows.Forms.LinkLabel()
        Me.grpFillingInfo = New System.Windows.Forms.GroupBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.grpFillingInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Qualy", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(53, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Addie's Equipment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(21, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(21, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(113, 22)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(214, 24)
        Me.txtFullName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtFullName, "Full Name is required.")
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(113, 62)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(58, 24)
        Me.txtAge.TabIndex = 8
        Me.ToolTip2.SetToolTip(Me.txtAge, "Age is required.")
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.PowderBlue
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(113, 106)
        Me.txtAddress.MaxLength = 99
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(276, 63)
        Me.txtAddress.TabIndex = 9
        Me.ToolTip3.SetToolTip(Me.txtAddress, "Address is required.")
        '
        'rdbHomePhone
        '
        Me.rdbHomePhone.AutoSize = True
        Me.rdbHomePhone.BackColor = System.Drawing.Color.Transparent
        Me.rdbHomePhone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbHomePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbHomePhone.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.rdbHomePhone.Location = New System.Drawing.Point(113, 191)
        Me.rdbHomePhone.Name = "rdbHomePhone"
        Me.rdbHomePhone.Size = New System.Drawing.Size(114, 22)
        Me.rdbHomePhone.TabIndex = 10
        Me.rdbHomePhone.TabStop = True
        Me.rdbHomePhone.Text = "Home Phone"
        Me.ToolTip5.SetToolTip(Me.rdbHomePhone, "Select home phone.")
        Me.rdbHomePhone.UseVisualStyleBackColor = False
        '
        'rdbMobilePhone
        '
        Me.rdbMobilePhone.AutoSize = True
        Me.rdbMobilePhone.BackColor = System.Drawing.Color.Transparent
        Me.rdbMobilePhone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdbMobilePhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMobilePhone.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.rdbMobilePhone.Location = New System.Drawing.Point(244, 191)
        Me.rdbMobilePhone.Name = "rdbMobilePhone"
        Me.rdbMobilePhone.Size = New System.Drawing.Size(117, 22)
        Me.rdbMobilePhone.TabIndex = 11
        Me.rdbMobilePhone.TabStop = True
        Me.rdbMobilePhone.Text = "Mobile Phone"
        Me.ToolTip5.SetToolTip(Me.rdbMobilePhone, "Select mobile phone.")
        Me.rdbMobilePhone.UseVisualStyleBackColor = False
        '
        'mskPhoneNumbers
        '
        Me.mskPhoneNumbers.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mskPhoneNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPhoneNumbers.Location = New System.Drawing.Point(113, 227)
        Me.mskPhoneNumbers.Name = "mskPhoneNumbers"
        Me.mskPhoneNumbers.Size = New System.Drawing.Size(186, 26)
        Me.mskPhoneNumbers.TabIndex = 12
        Me.ToolTip4.SetToolTip(Me.mskPhoneNumbers, "Contact No. is required.")
        '
        'btnEnter
        '
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(16, 299)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(124, 43)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "Enter"
        Me.ToolTip5.SetToolTip(Me.btnEnter, "Click enter.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(160, 299)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(124, 43)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.ToolTip5.SetToolTip(Me.btnReset, "Click reset.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(305, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 43)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.ToolTip5.SetToolTip(Me.btnExit, "Click exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(21, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contact:"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Insert Your Full Name"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.backicon
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.Transparent
        Me.btnReturn.Location = New System.Drawing.Point(2, 458)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(55, 54)
        Me.btnReturn.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Select Support")
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "Please Insert Your Age"
        '
        'ToolTip3
        '
        Me.ToolTip3.IsBalloon = True
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip3.ToolTipTitle = "Please insert your address"
        '
        'ToolTip4
        '
        Me.ToolTip4.IsBalloon = True
        Me.ToolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip4.ToolTipTitle = "Please insert your contact"
        '
        'lnkSite
        '
        Me.lnkSite.AutoSize = True
        Me.lnkSite.Cursor = System.Windows.Forms.Cursors.Help
        Me.lnkSite.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSite.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.lnkSite.Location = New System.Drawing.Point(155, 476)
        Me.lnkSite.Name = "lnkSite"
        Me.lnkSite.Size = New System.Drawing.Size(210, 16)
        Me.lnkSite.TabIndex = 17
        Me.lnkSite.TabStop = True
        Me.lnkSite.Text = "Visit our website for more information!"
        Me.lnkSite.VisitedLinkColor = System.Drawing.Color.Transparent
        '
        'grpFillingInfo
        '
        Me.grpFillingInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpFillingInfo.Controls.Add(Me.rdbHomePhone)
        Me.grpFillingInfo.Controls.Add(Me.rdbMobilePhone)
        Me.grpFillingInfo.Controls.Add(Me.btnExit)
        Me.grpFillingInfo.Controls.Add(Me.btnReset)
        Me.grpFillingInfo.Controls.Add(Me.btnEnter)
        Me.grpFillingInfo.Controls.Add(Me.mskPhoneNumbers)
        Me.grpFillingInfo.Controls.Add(Me.txtAddress)
        Me.grpFillingInfo.Controls.Add(Me.txtAge)
        Me.grpFillingInfo.Controls.Add(Me.txtFullName)
        Me.grpFillingInfo.Controls.Add(Me.Label5)
        Me.grpFillingInfo.Controls.Add(Me.Label4)
        Me.grpFillingInfo.Controls.Add(Me.Label3)
        Me.grpFillingInfo.Controls.Add(Me.Label2)
        Me.grpFillingInfo.Location = New System.Drawing.Point(38, 97)
        Me.grpFillingInfo.Name = "grpFillingInfo"
        Me.grpFillingInfo.Size = New System.Drawing.Size(442, 359)
        Me.grpFillingInfo.TabIndex = 18
        Me.grpFillingInfo.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Icon = CType(resources.GetObject("NotifyIcon2.Icon"), System.Drawing.Icon)
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = True
        '
        'FillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.repairworkshoptransparentpng3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(525, 518)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.grpFillingInfo)
        Me.Controls.Add(Me.lnkSite)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addie's Equipment"
        Me.grpFillingInfo.ResumeLayout(False)
        Me.grpFillingInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents rdbHomePhone As RadioButton
    Friend WithEvents rdbMobilePhone As RadioButton
    Friend WithEvents mskPhoneNumbers As MaskedTextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents lnkSite As LinkLabel
    Friend WithEvents grpFillingInfo As GroupBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents btnReturn As Button
End Class
