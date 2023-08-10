<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinalReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalReceipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalFR = New System.Windows.Forms.Label()
        Me.lblDiscountFR = New System.Windows.Forms.Label()
        Me.lblNetTotalFR = New System.Windows.Forms.Label()
        Me.lstViewReceipt = New System.Windows.Forms.ListBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Qualy", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Addie's Equipment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(27, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Full Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(312, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(27, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(29, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact:"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.Color.DarkGray
        Me.lblFullName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(117, 92)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(169, 29)
        Me.lblFullName.TabIndex = 32
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.DarkGray
        Me.lblAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAge.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAge.Location = New System.Drawing.Point(358, 92)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(50, 29)
        Me.lblAge.TabIndex = 33
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.DarkGray
        Me.lblAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(117, 134)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(245, 51)
        Me.lblAddress.TabIndex = 34
        '
        'lblContact
        '
        Me.lblContact.BackColor = System.Drawing.Color.DarkGray
        Me.lblContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblContact.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(117, 198)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(143, 29)
        Me.lblContact.TabIndex = 35
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotal.Location = New System.Drawing.Point(500, 98)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 20)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "Total:"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(550, 290)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(131, 53)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(550, 379)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 53)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(471, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Discount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(471, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Net Total:"
        '
        'lblTotalFR
        '
        Me.lblTotalFR.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotalFR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTotalFR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotalFR.Location = New System.Drawing.Point(564, 94)
        Me.lblTotalFR.Name = "lblTotalFR"
        Me.lblTotalFR.Size = New System.Drawing.Size(115, 29)
        Me.lblTotalFR.TabIndex = 41
        '
        'lblDiscountFR
        '
        Me.lblDiscountFR.BackColor = System.Drawing.Color.DarkGray
        Me.lblDiscountFR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDiscountFR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountFR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiscountFR.Location = New System.Drawing.Point(564, 138)
        Me.lblDiscountFR.Name = "lblDiscountFR"
        Me.lblDiscountFR.Size = New System.Drawing.Size(115, 29)
        Me.lblDiscountFR.TabIndex = 42
        '
        'lblNetTotalFR
        '
        Me.lblNetTotalFR.BackColor = System.Drawing.Color.DarkGray
        Me.lblNetTotalFR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNetTotalFR.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetTotalFR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNetTotalFR.Location = New System.Drawing.Point(564, 181)
        Me.lblNetTotalFR.Name = "lblNetTotalFR"
        Me.lblNetTotalFR.Size = New System.Drawing.Size(115, 29)
        Me.lblNetTotalFR.TabIndex = 43
        '
        'lstViewReceipt
        '
        Me.lstViewReceipt.AccessibleName = "lstViewReceipt"
        Me.lstViewReceipt.BackColor = System.Drawing.Color.DarkGray
        Me.lstViewReceipt.FormattingEnabled = True
        Me.lstViewReceipt.HorizontalScrollbar = True
        Me.lstViewReceipt.Location = New System.Drawing.Point(12, 253)
        Me.lstViewReceipt.Name = "lstViewReceipt"
        Me.lstViewReceipt.Size = New System.Drawing.Size(513, 264)
        Me.lstViewReceipt.TabIndex = 44
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AccessibleName = "lnkProblem"
        Me.LinkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray
        Me.LinkLabel1.Location = New System.Drawing.Point(73, 525)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(270, 15)
        Me.LinkLabel1.TabIndex = 45
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Any problem? Please reach out to us for support!"
        '
        'FinalReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.repairworkshoptransparentpng3
        Me.ClientSize = New System.Drawing.Size(708, 559)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lstViewReceipt)
        Me.Controls.Add(Me.lblNetTotalFR)
        Me.Controls.Add(Me.lblDiscountFR)
        Me.Controls.Add(Me.lblTotalFR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FinalReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalFR As Label
    Friend WithEvents lblDiscountFR As Label
    Friend WithEvents lblNetTotalFR As Label
    Friend WithEvents lstViewReceipt As ListBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
