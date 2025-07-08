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

        CourseName = New Label With {
                    .Text = txtCourseName.Text
                }


        CoursePanel.Controls.Add(CourseName)


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class