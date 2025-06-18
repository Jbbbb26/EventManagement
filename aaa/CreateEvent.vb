Public Class CreateEvent

    Private Sub btn_student_Click_1(sender As Object, e As EventArgs) Handles btn_create.Click
        lb_events.Items.Add("Event Name: " & txt_name.Text & vbCrLf &
                            "Event Date: " & DateStart.Value.ToShortDateString() & " to " & DateEnd.Value.ToShortDateString() & vbCrLf &
                            "Venue: " & TextBox1.Text)
        txt_name.Clear()
        TextBox1.Clear()
        DateStart.Value = DateTime.Now
        DateEnd.Value = DateTime.Now.AddDays(1)
        MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
