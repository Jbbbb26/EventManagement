<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_DashBoard
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
        Me.lbl_StudID = New System.Windows.Forms.Label()
        Me.lbl_StudName = New System.Windows.Forms.Label()
        Me.lbl_Org = New System.Windows.Forms.Label()
        Me.lbl_Course = New System.Windows.Forms.Label()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.btn_FeedBack = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_StudID
        '
        Me.lbl_StudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StudID.Location = New System.Drawing.Point(30, 40)
        Me.lbl_StudID.Name = "lbl_StudID"
        Me.lbl_StudID.Size = New System.Drawing.Size(100, 23)
        Me.lbl_StudID.TabIndex = 0
        Me.lbl_StudID.Text = "Student ID"
        '
        'lbl_StudName
        '
        Me.lbl_StudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StudName.Location = New System.Drawing.Point(30, 70)
        Me.lbl_StudName.Name = "lbl_StudName"
        Me.lbl_StudName.Size = New System.Drawing.Size(132, 30)
        Me.lbl_StudName.TabIndex = 1
        Me.lbl_StudName.Text = "Student Name"
        '
        'lbl_Org
        '
        Me.lbl_Org.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Org.Location = New System.Drawing.Point(30, 100)
        Me.lbl_Org.Name = "lbl_Org"
        Me.lbl_Org.Size = New System.Drawing.Size(111, 30)
        Me.lbl_Org.TabIndex = 2
        Me.lbl_Org.Text = "Organization"
        '
        'lbl_Course
        '
        Me.lbl_Course.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Course.Location = New System.Drawing.Point(30, 130)
        Me.lbl_Course.Name = "lbl_Course"
        Me.lbl_Course.Size = New System.Drawing.Size(174, 20)
        Me.lbl_Course.TabIndex = 3
        Me.lbl_Course.Text = "Course and Section"
        '
        'lbl_Age
        '
        Me.lbl_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.Location = New System.Drawing.Point(30, 160)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(51, 30)
        Me.lbl_Age.TabIndex = 4
        Me.lbl_Age.Text = "Age"
        '
        'lbl_Gender
        '
        Me.lbl_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.Location = New System.Drawing.Point(30, 190)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(72, 20)
        Me.lbl_Gender.TabIndex = 5
        Me.lbl_Gender.Text = "Gender"
        '
        'btn_Register
        '
        Me.btn_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.Location = New System.Drawing.Point(17, 237)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(124, 41)
        Me.btn_Register.TabIndex = 6
        Me.btn_Register.Text = "Register"
        Me.btn_Register.UseVisualStyleBackColor = True
        '
        'btn_FeedBack
        '
        Me.btn_FeedBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FeedBack.Location = New System.Drawing.Point(149, 237)
        Me.btn_FeedBack.Name = "btn_FeedBack"
        Me.btn_FeedBack.Size = New System.Drawing.Size(124, 41)
        Me.btn_FeedBack.TabIndex = 7
        Me.btn_FeedBack.Text = "Feedback"
        Me.btn_FeedBack.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(305, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(254, 238)
        Me.ListBox1.TabIndex = 8
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(410, 307)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(149, 28)
        Me.btn_Exit.TabIndex = 9
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Student_DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 359)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_FeedBack)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.lbl_Course)
        Me.Controls.Add(Me.lbl_Org)
        Me.Controls.Add(Me.lbl_StudName)
        Me.Controls.Add(Me.lbl_StudID)
        Me.Name = "Student_DashBoard"
        Me.Text = "Student_DashBoard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_StudID As Label
    Friend WithEvents lbl_StudName As Label
    Friend WithEvents lbl_Org As Label
    Friend WithEvents lbl_Course As Label
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents btn_Register As Button
    Friend WithEvents btn_FeedBack As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_Exit As Button
End Class
