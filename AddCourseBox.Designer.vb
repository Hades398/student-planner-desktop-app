<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseBox
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
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtCourseTimes = New System.Windows.Forms.TextBox()
        Me.CourseName = New System.Windows.Forms.Label()
        Me.CourseDates = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(12, 56)
        Me.txtCourseName.Multiline = True
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(212, 89)
        Me.txtCourseName.TabIndex = 0
        '
        'txtCourseTimes
        '
        Me.txtCourseTimes.Location = New System.Drawing.Point(576, 56)
        Me.txtCourseTimes.Multiline = True
        Me.txtCourseTimes.Name = "txtCourseTimes"
        Me.txtCourseTimes.Size = New System.Drawing.Size(212, 89)
        Me.txtCourseTimes.TabIndex = 1
        '
        'CourseName
        '
        Me.CourseName.AutoSize = True
        Me.CourseName.Location = New System.Drawing.Point(68, 40)
        Me.CourseName.Name = "CourseName"
        Me.CourseName.Size = New System.Drawing.Size(102, 13)
        Me.CourseName.TabIndex = 2
        Me.CourseName.Text = "Enter Course Name:"
        '
        'CourseDates
        '
        Me.CourseDates.AutoSize = True
        Me.CourseDates.Location = New System.Drawing.Point(640, 40)
        Me.CourseDates.Name = "CourseDates"
        Me.CourseDates.Size = New System.Drawing.Size(102, 13)
        Me.CourseDates.TabIndex = 3
        Me.CourseDates.Text = "Enter Course Dates:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(269, 225)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(251, 47)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'AddCourseBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CourseDates)
        Me.Controls.Add(Me.CourseName)
        Me.Controls.Add(Me.txtCourseTimes)
        Me.Controls.Add(Me.txtCourseName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCourseBox"
        Me.Text = "Course Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCourseTimes As TextBox
    Friend WithEvents CourseName As Label
    Friend WithEvents CourseDates As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
