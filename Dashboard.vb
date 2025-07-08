Public Class Dashboard
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim courseBox As New AddCourseBox()

        If courseBox.ShowDialog = DialogResult.OK Then
            flowPanelCourses.Controls.Add(courseBox.CoursePanel)
        End If
    End Sub

End Class
