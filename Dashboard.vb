Public Class Dashboard
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim courseBox As New AddCourseBox()

        If courseBox.ShowDialog = DialogResult.OK Then
            flowPanelCourses.Controls.Add(courseBox.CoursePanel)
            AddHandler courseBox.CoursePanel.Click, AddressOf CoursePanel_Click
        End If


    End Sub


    Private Sub CoursePanel_Click(sender As Object, e As EventArgs)
        Dim manager As New CourseManager()
    End Sub

End Class
