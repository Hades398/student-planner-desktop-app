Public Class AddCourseBox
    Public CoursePanel As Panel

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCourseName.Text = "" Then
            MessageBox.Show("Course Name Required")
            Exit Sub
        End If

        CoursePanel = New Panel With {
            .Width = 250,
            .Height = 100,
            .BackColor = Color.CornflowerBlue,
            .BorderStyle = BorderStyle.FixedSingle,
            .Cursor = Cursors.Hand
        }

        Dim name As New Label With {
                    .Text = txtCourseName.Text
                }


        CoursePanel.Controls.Add(name)

        AddHandler CoursePanel.Click, AddressOf CoursePanel_Click

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CoursePanel_Click(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = DirectCast(sender, Panel)
        MessageBox.Show("You clicked the course panel: " & clickedPanel.Controls(0).Text)
    End Sub

End Class