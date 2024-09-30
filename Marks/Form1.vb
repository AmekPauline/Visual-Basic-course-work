Public Class Form1


    Private Sub btnevaluate_Click(sender As Object, e As EventArgs) Handles btnevaluate.Click

        Dim marks As Integer = CInt(txtmarks.Text)
        Dim grades As String = txtgrade.Text

        If marks > 100 Or marks < 0 Then
            MessageBox.Show("wrong entry")
        End If

        If marks >= 90 And marks <= 100 Then
            MessageBox.Show("excellent")
            txtgrade.Text = "excellent"
        ElseIf marks >= 80 And marks <= 89 Then
            txtgrade.Text = "very good"

        ElseIf marks >= 70 And marks <= 79 Then
            txtgrade.Text = "good"
        ElseIf marks >= 60 And marks <= 69 Then
            txtgrade.Text = "medium"
        ElseIf marks >= 50 And marks <= 59 Then
            txtgrade.Text = "pass"
        ElseIf marks >= 0 And marks <= 49 Then
            txtgrade.Text = "fail"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblGRADINGSCALECALCULATOR_Click(sender As Object, e As EventArgs) Handles lblGRADINGSCALECALCULATOR.Click

    End Sub
End Class
