<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.flowPanelCourses = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnAddCourse)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1020, 100)
        Me.pnlHeader.TabIndex = 0
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.Honeydew
        Me.btnAddCourse.FlatAppearance.BorderSize = 0
        Me.btnAddCourse.Location = New System.Drawing.Point(436, 0)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(119, 100)
        Me.btnAddCourse.TabIndex = 0
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'flowPanelCourses
        '
        Me.flowPanelCourses.BackColor = System.Drawing.Color.OldLace
        Me.flowPanelCourses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowPanelCourses.Location = New System.Drawing.Point(0, 100)
        Me.flowPanelCourses.Name = "flowPanelCourses"
        Me.flowPanelCourses.Size = New System.Drawing.Size(1020, 523)
        Me.flowPanelCourses.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 623)
        Me.Controls.Add(Me.flowPanelCourses)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "Dashboard"
        Me.Text = "DashBoard"
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents flowPanelCourses As FlowLayoutPanel
End Class
