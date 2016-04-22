Public Class Form4

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        rättsvar()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        felsvar()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        felsvar()
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        felsvar()
    End Sub
    Private Sub felsvar()
        MsgBox("tyvärr, det var inte rätt svar. Försök igen SOPA HAHAHAHAHA")
    End Sub
    Private Sub rättsvar()
        MsgBox("Hur fan fick du rätt svar")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.ForeColor = Color.Black Then
            Label1.ForeColor = Color.Red
        ElseIf Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.Blue
        ElseIf Label1.ForeColor = Color.Blue Then
            Label1.ForeColor = Color.Pink
        ElseIf Label1.ForeColor = Color.Pink Then
            Label1.ForeColor = Color.Yellow
        ElseIf Label1.ForeColor = Color.Yellow Then
            Label1.ForeColor = Color.Green
        ElseIf Label1.ForeColor = Color.Green Then
            Label1.ForeColor = Color.Aquamarine
        ElseIf Label1.ForeColor = Color.Aquamarine Then
            Label1.ForeColor = Color.Magenta
        ElseIf Label1.ForeColor = Color.Magenta Then
            Label1.ForeColor = Color.Black
        End If

        If Label2.ForeColor = Color.Black Then
            Label2.ForeColor = Color.Red
        ElseIf Label2.ForeColor = Color.Red Then
            Label2.ForeColor = Color.Blue
        ElseIf Label2.ForeColor = Color.Blue Then
            Label2.ForeColor = Color.Pink
        ElseIf Label2.ForeColor = Color.Pink Then
            Label2.ForeColor = Color.Yellow
        ElseIf Label2.ForeColor = Color.Yellow Then
            Label2.ForeColor = Color.Green
        ElseIf Label2.ForeColor = Color.Green Then
            Label2.ForeColor = Color.Aquamarine
        ElseIf Label2.ForeColor = Color.Aquamarine Then
            Label2.ForeColor = Color.Magenta
        ElseIf Label2.ForeColor = Color.Magenta Then
            Label2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
        End If

        If Label2.Visible = True Then
            Label2.Visible = False
        ElseIf Label2.Visible = False Then
            Label2.Visible = True
        End If
    End Sub
End Class