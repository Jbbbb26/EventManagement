﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashBoard
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
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtb_dateEnd = New System.Windows.Forms.TextBox()
        Me.txtb_dateStart = New System.Windows.Forms.TextBox()
        Me.txtb_Venue = New System.Windows.Forms.TextBox()
        Me.lb_Events = New System.Windows.Forms.ListBox()
        Me.btn_Create = New System.Windows.Forms.Button()
        Me.btn_Update = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_feedBack = New System.Windows.Forms.Button()
        Me.btn_Logut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_name.Location = New System.Drawing.Point(25, 46)
        Me.tb_name.Multiline = True
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(228, 30)
        Me.tb_name.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(25, 191)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 30)
        Me.TextBox1.TabIndex = 2
        '
        'txtb_dateEnd
        '
        Me.txtb_dateEnd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtb_dateEnd.Location = New System.Drawing.Point(25, 156)
        Me.txtb_dateEnd.Multiline = True
        Me.txtb_dateEnd.Name = "txtb_dateEnd"
        Me.txtb_dateEnd.Size = New System.Drawing.Size(228, 29)
        Me.txtb_dateEnd.TabIndex = 3
        '
        'txtb_dateStart
        '
        Me.txtb_dateStart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtb_dateStart.Location = New System.Drawing.Point(25, 118)
        Me.txtb_dateStart.Multiline = True
        Me.txtb_dateStart.Name = "txtb_dateStart"
        Me.txtb_dateStart.Size = New System.Drawing.Size(228, 32)
        Me.txtb_dateStart.TabIndex = 4
        '
        'txtb_Venue
        '
        Me.txtb_Venue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtb_Venue.Location = New System.Drawing.Point(25, 82)
        Me.txtb_Venue.Multiline = True
        Me.txtb_Venue.Name = "txtb_Venue"
        Me.txtb_Venue.Size = New System.Drawing.Size(228, 30)
        Me.txtb_Venue.TabIndex = 5
        '
        'lb_Events
        '
        Me.lb_Events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_Events.FormattingEnabled = True
        Me.lb_Events.Location = New System.Drawing.Point(321, 44)
        Me.lb_Events.Name = "lb_Events"
        Me.lb_Events.Size = New System.Drawing.Size(211, 249)
        Me.lb_Events.TabIndex = 6
        '
        'btn_Create
        '
        Me.btn_Create.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Create.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Create.ForeColor = System.Drawing.Color.White
        Me.btn_Create.Location = New System.Drawing.Point(12, 243)
        Me.btn_Create.Name = "btn_Create"
        Me.btn_Create.Size = New System.Drawing.Size(124, 41)
        Me.btn_Create.TabIndex = 7
        Me.btn_Create.Text = "Create"
        Me.btn_Create.UseVisualStyleBackColor = False
        '
        'btn_Update
        '
        Me.btn_Update.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.ForeColor = System.Drawing.Color.White
        Me.btn_Update.Location = New System.Drawing.Point(142, 245)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(124, 39)
        Me.btn_Update.TabIndex = 8
        Me.btn_Update.Text = "Update"
        Me.btn_Update.UseVisualStyleBackColor = False
        '
        'btn_Delete
        '
        Me.btn_Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Delete.ForeColor = System.Drawing.Color.White
        Me.btn_Delete.Location = New System.Drawing.Point(11, 290)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(124, 41)
        Me.btn_Delete.TabIndex = 9
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_feedBack
        '
        Me.btn_feedBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_feedBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_feedBack.ForeColor = System.Drawing.Color.White
        Me.btn_feedBack.Location = New System.Drawing.Point(142, 290)
        Me.btn_feedBack.Name = "btn_feedBack"
        Me.btn_feedBack.Size = New System.Drawing.Size(124, 41)
        Me.btn_feedBack.TabIndex = 10
        Me.btn_feedBack.Text = "Feedback"
        Me.btn_feedBack.UseVisualStyleBackColor = False
        '
        'btn_Logut
        '
        Me.btn_Logut.BackColor = System.Drawing.Color.Red
        Me.btn_Logut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logut.ForeColor = System.Drawing.Color.White
        Me.btn_Logut.Location = New System.Drawing.Point(396, 308)
        Me.btn_Logut.Name = "btn_Logut"
        Me.btn_Logut.Size = New System.Drawing.Size(137, 30)
        Me.btn_Logut.TabIndex = 11
        Me.btn_Logut.Text = "Logout"
        Me.btn_Logut.UseVisualStyleBackColor = False
        '
        'AdminDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 351)
        Me.Controls.Add(Me.btn_Logut)
        Me.Controls.Add(Me.btn_feedBack)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Update)
        Me.Controls.Add(Me.btn_Create)
        Me.Controls.Add(Me.lb_Events)
        Me.Controls.Add(Me.txtb_Venue)
        Me.Controls.Add(Me.txtb_dateStart)
        Me.Controls.Add(Me.txtb_dateEnd)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tb_name)
        Me.Name = "AdminDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashBoard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_name As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtb_dateEnd As TextBox
    Friend WithEvents txtb_dateStart As TextBox
    Friend WithEvents txtb_Venue As TextBox
    Friend WithEvents lb_Events As ListBox
    Friend WithEvents btn_Create As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_feedBack As Button
    Friend WithEvents btn_Logut As Button
End Class
