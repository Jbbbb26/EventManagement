<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateEvent
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
        Me.btn_create = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.DateStart = New System.Windows.Forms.DateTimePicker()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_events = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.LightBlue
        Me.btn_create.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.Color.Black
        Me.btn_create.Location = New System.Drawing.Point(248, 341)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(227, 23)
        Me.btn_create.TabIndex = 14
        Me.btn_create.Text = "Create an event"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(243, 126)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(231, 20)
        Me.txt_name.TabIndex = 12
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.lbl_email.Location = New System.Drawing.Point(243, 218)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(131, 21)
        Me.lbl_email.TabIndex = 11
        Me.lbl_email.Text = "Date start:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.lbl_name.Location = New System.Drawing.Point(243, 102)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(164, 21)
        Me.lbl_name.TabIndex = 10
        Me.lbl_name.Text = "Name of event:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(307, 21)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(93, 30)
        Me.lbl_date.TabIndex = 9
        Me.lbl_date.Text = "Admin"
        '
        'DateStart
        '
        Me.DateStart.Location = New System.Drawing.Point(247, 243)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(227, 20)
        Me.DateStart.TabIndex = 15
        '
        'DateEnd
        '
        Me.DateEnd.Location = New System.Drawing.Point(247, 300)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(227, 20)
        Me.DateEnd.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(243, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Date end:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(243, 182)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 20)
        Me.TextBox1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(243, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Venue:"
        '
        'lb_events
        '
        Me.lb_events.FormattingEnabled = True
        Me.lb_events.Location = New System.Drawing.Point(33, 372)
        Me.lb_events.Name = "lb_events"
        Me.lb_events.Size = New System.Drawing.Size(612, 43)
        Me.lb_events.TabIndex = 20
        '
        'CreateEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(705, 427)
        Me.Controls.Add(Me.lb_events)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateStart)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_date)
        Me.Name = "CreateEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_create As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents DateStart As DateTimePicker
    Friend WithEvents DateEnd As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_events As ListBox
End Class
