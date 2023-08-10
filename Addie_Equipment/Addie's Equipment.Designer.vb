<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddiesEquipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddiesEquipment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEquipmentType = New System.Windows.Forms.ComboBox()
        Me.lstEquipmentType = New System.Windows.Forms.ListBox()
        Me.cboRentalDays = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDailyRate = New System.Windows.Forms.Label()
        Me.lblDaysRate = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstRentalDays = New System.Windows.Forms.ListBox()
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.lstSubtotal = New System.Windows.Forms.ListBox()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Qualy", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(79, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 46)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Addie's Equipment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Honeydew
        Me.btnBack.Location = New System.Drawing.Point(682, 515)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 43)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.ToolTip3.SetToolTip(Me.btnBack, "Click Back.")
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Azure
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label4.Location = New System.Drawing.Point(32, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Equipment Type:"
        '
        'cboEquipmentType
        '
        Me.cboEquipmentType.BackColor = System.Drawing.Color.White
        Me.cboEquipmentType.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.cboEquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEquipmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEquipmentType.FormattingEnabled = True
        Me.cboEquipmentType.Location = New System.Drawing.Point(169, 112)
        Me.cboEquipmentType.Name = "cboEquipmentType"
        Me.cboEquipmentType.Size = New System.Drawing.Size(234, 26)
        Me.cboEquipmentType.TabIndex = 22
        Me.ToolTip2.SetToolTip(Me.cboEquipmentType, "Please choose a equipment.")
        '
        'lstEquipmentType
        '
        Me.lstEquipmentType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstEquipmentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstEquipmentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEquipmentType.FormattingEnabled = True
        Me.lstEquipmentType.ItemHeight = 16
        Me.lstEquipmentType.Location = New System.Drawing.Point(39, 232)
        Me.lstEquipmentType.Name = "lstEquipmentType"
        Me.lstEquipmentType.Size = New System.Drawing.Size(359, 258)
        Me.lstEquipmentType.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.lstEquipmentType, "List of equipments that are added here.")
        '
        'cboRentalDays
        '
        Me.cboRentalDays.BackColor = System.Drawing.Color.White
        Me.cboRentalDays.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.cboRentalDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRentalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRentalDays.FormattingEnabled = True
        Me.cboRentalDays.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"})
        Me.cboRentalDays.Location = New System.Drawing.Point(537, 112)
        Me.cboRentalDays.Name = "cboRentalDays"
        Me.cboRentalDays.Size = New System.Drawing.Size(61, 26)
        Me.cboRentalDays.TabIndex = 25
        Me.ToolTip2.SetToolTip(Me.cboRentalDays, "Please choose the days.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Azure
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label2.Location = New System.Drawing.Point(423, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Rental Day(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(29, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTotal.Font = New System.Drawing.Font("Gobold Thin", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(121, 509)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(131, 40)
        Me.lblTotal.TabIndex = 27
        Me.ToolTip3.SetToolTip(Me.lblTotal, "Display Total.")
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Honeydew
        Me.btnAdd.Location = New System.Drawing.Point(388, 515)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 43)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.ToolTip3.SetToolTip(Me.btnAdd, "Click Add.")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Azure
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label5.Location = New System.Drawing.Point(627, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Daily Rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Azure
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label6.Location = New System.Drawing.Point(627, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Days Rate:"
        '
        'lblDailyRate
        '
        Me.lblDailyRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDailyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDailyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDailyRate.Location = New System.Drawing.Point(718, 90)
        Me.lblDailyRate.Name = "lblDailyRate"
        Me.lblDailyRate.Size = New System.Drawing.Size(88, 31)
        Me.lblDailyRate.TabIndex = 31
        Me.ToolTip3.SetToolTip(Me.lblDailyRate, "Display Daily Rate.")
        '
        'lblDaysRate
        '
        Me.lblDaysRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDaysRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDaysRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDaysRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysRate.Location = New System.Drawing.Point(718, 125)
        Me.lblDaysRate.Name = "lblDaysRate"
        Me.lblDaysRate.Size = New System.Drawing.Size(88, 31)
        Me.lblDaysRate.TabIndex = 32
        Me.ToolTip3.SetToolTip(Me.lblDaysRate, "Display Days Rate.")
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Honeydew
        Me.btnClear.Location = New System.Drawing.Point(535, 515)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 43)
        Me.btnClear.TabIndex = 35
        Me.btnClear.Text = "Clear"
        Me.ToolTip3.SetToolTip(Me.btnClear, "Click Clear.")
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lstRentalDays
        '
        Me.lstRentalDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstRentalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRentalDays.FormattingEnabled = True
        Me.lstRentalDays.ItemHeight = 16
        Me.lstRentalDays.Location = New System.Drawing.Point(419, 232)
        Me.lstRentalDays.Name = "lstRentalDays"
        Me.lstRentalDays.Size = New System.Drawing.Size(106, 260)
        Me.lstRentalDays.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.lstRentalDays, "List of rental days that are added here.")
        '
        'lstRates
        '
        Me.lstRates.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 16
        Me.lstRates.Location = New System.Drawing.Point(549, 232)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(106, 260)
        Me.lstRates.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.lstRates, "List of daily rate or days rate that are added here.")
        '
        'lstSubtotal
        '
        Me.lstSubtotal.BackColor = System.Drawing.Color.MediumPurple
        Me.lstSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubtotal.FormattingEnabled = True
        Me.lstSubtotal.ItemHeight = 16
        Me.lstSubtotal.Location = New System.Drawing.Point(675, 232)
        Me.lstSubtotal.Name = "lstSubtotal"
        Me.lstSubtotal.Size = New System.Drawing.Size(131, 260)
        Me.lstSubtotal.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.lstSubtotal, "List of subtotals that are added here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lblNetTotal
        '
        Me.lblNetTotal.BackColor = System.Drawing.Color.Crimson
        Me.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNetTotal.Font = New System.Drawing.Font("Gobold Thin", 18.0!)
        Me.lblNetTotal.ForeColor = System.Drawing.Color.Pink
        Me.lblNetTotal.Location = New System.Drawing.Point(121, 615)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(131, 40)
        Me.lblNetTotal.TabIndex = 40
        Me.ToolTip3.SetToolTip(Me.lblNetTotal, "Display Net Total.")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(30, 623)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Net Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(146, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 21)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Equipment Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(422, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 21)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Rental Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(557, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 42)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Daily Rate/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Days Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(704, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 21)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Subtotal"
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDiscount.Font = New System.Drawing.Font("Gobold Thin", 18.0!)
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(121, 563)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(131, 40)
        Me.lblDiscount.TabIndex = 46
        Me.ToolTip3.SetToolTip(Me.lblDiscount, "Display Discount.")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(29, 569)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 20)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Discount:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.rsz_11rsz_submit_button_png_transparent_image
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Transparent
        Me.btnSubmit.Location = New System.Drawing.Point(642, 576)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(212, 80)
        Me.btnSubmit.TabIndex = 48
        Me.ToolTip3.SetToolTip(Me.btnSubmit, "Click submit.")
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "View Receipts"
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ToolTip2.ToolTipTitle = "Selecting option"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'AddiesEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.repairworkshoptransparentpng2
        Me.ClientSize = New System.Drawing.Size(851, 673)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblNetTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstSubtotal)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.lstRentalDays)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDaysRate)
        Me.Controls.Add(Me.lblDailyRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboRentalDays)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstEquipmentType)
        Me.Controls.Add(Me.cboEquipmentType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddiesEquipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addie's Equipment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEquipmentType As ComboBox
    Friend WithEvents lstEquipmentType As ListBox
    Friend WithEvents cboRentalDays As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDailyRate As Label
    Friend WithEvents lblDaysRate As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lstRentalDays As ListBox
    Friend WithEvents lstRates As ListBox
    Friend WithEvents lstSubtotal As ListBox
    Friend WithEvents lblNetTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
