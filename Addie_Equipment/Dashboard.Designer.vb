<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWeb = New System.Windows.Forms.Button()
        Me.btnSup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.picTools = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Qualy", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Location = New System.Drawing.Point(333, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Addie's Equipment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnWeb
        '
        Me.btnWeb.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.websitepng1
        Me.btnWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeb.FlatAppearance.BorderSize = 0
        Me.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeb.ForeColor = System.Drawing.Color.White
        Me.btnWeb.Location = New System.Drawing.Point(130, 5)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(35, 35)
        Me.btnWeb.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnWeb, "Select website")
        Me.btnWeb.UseVisualStyleBackColor = True
        '
        'btnSup
        '
        Me.btnSup.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.supporticon
        Me.btnSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSup.FlatAppearance.BorderSize = 0
        Me.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSup.ForeColor = System.Drawing.Color.White
        Me.btnSup.Location = New System.Drawing.Point(181, 5)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(35, 35)
        Me.btnSup.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnSup, "Select Support")
        Me.btnSup.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.delete_318_10512
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(515, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(257, 244)
        Me.btnExit.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnExit, "Select Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRent
        '
        Me.btnRent.BackgroundImage = Global.Addie_Equipment.My.Resources.Resources.renticon
        Me.btnRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRent.FlatAppearance.BorderSize = 0
        Me.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRent.ForeColor = System.Drawing.Color.White
        Me.btnRent.Location = New System.Drawing.Point(245, 128)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(257, 244)
        Me.btnRent.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnRent, "Select Rent")
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'picTools
        '
        Me.picTools.BackColor = System.Drawing.Color.White
        Me.picTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTools.Image = Global.Addie_Equipment.My.Resources.Resources.repairworkshoptransparentpng4
        Me.picTools.Location = New System.Drawing.Point(-322, -8)
        Me.picTools.Name = "picTools"
        Me.picTools.Size = New System.Drawing.Size(547, 592)
        Me.picTools.TabIndex = 5
        Me.picTools.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(772, 489)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.btnSup)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.picTools)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mainpage"
        CType(Me.picTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRent As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picTools As PictureBox
    Friend WithEvents btnSup As Button
    Friend WithEvents btnWeb As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
