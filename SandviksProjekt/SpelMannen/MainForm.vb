Imports System.IO

Public Class MainForm
    Dim rightanswer As Integer
    Dim poäng As Integer = 0

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If rightanswer = 1 Then 'här kollar den i notepaden vad vi har skrivit som rättsvar, är rättsvar 1 så går den till RättSvar() subrutinen. 
            Rättsvar()

        Else
            felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        If rightanswer = 2 Then
            Rättsvar()

        Else
            felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 
        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If rightanswer = 3 Then
            Rättsvar()

        Else
            felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 
        End If

    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If rightanswer = 4 Then
            Rättsvar()

        Else
            felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 
        End If

    End Sub

    Private Sub Rättsvar()
        poäng += 1
        MsgBox("Rätt, din poäng just nu är " & poäng)
        If poäng = 5 Then
            MsgBox("Grattis, du vann!!")
        Else
            new_question()
        End If



        new_question()


    End Sub
    Private Sub felsvar()
        poäng -= 1
        MsgBox("försök igen, din poäng just nu är " & poäng)
        If poäng = -5 Then
            MsgBox("Du förlorade, försök igen")
            poäng = 0
        Else
            new_question()
        End If

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
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
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

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Label2.Visible = True Then
            Label2.Visible = False
        ElseIf Label2.Visible = False Then
            Label2.Visible = True
        End If
    End Sub

    Private Sub Help(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Välj den bild som inte passar in!")
    End Sub


    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reset_form()
    End Sub


    Private Sub reset_form()
        questionHistory.Clear()
    End Sub

    Dim questionHistory As New Queue(Of Integer)
    Dim path As String = "."
    Dim lineArray() As String = File.ReadAllLines(Path + "\\questions.txt")
    Dim s As String
    Dim found As Boolean

    Private Sub new_question()

        Dim maxnumquestion As Integer = lineArray.Length / 5
        'MsgBox("Number of questions = " & maxnumquestion)

        'här slumpar vi fram en fråga 1, 2, n  (n = antral frågor i questions.txt)
        Randomize()
        Dim q As Integer = CInt(Math.Floor((maxnumquestion - 1 + 1) * Rnd())) + 1
        'MsgBox("slumpar fram fråga " & q)

        Dim base As Integer = (q - 1) * 5

        found = False
        For Each i In questionHistory
            If (i = base) Then
                'MsgBox("Oops we had question " + base)
                found = True
            End If
        Next

        If Not found Then
            'MsgBox("We did not have question " + base)  # Must´convert base to string
        End If

        questionHistory.Enqueue(base)

        'MsgBox(lineArray(base))
        'MsgBox(lineArray(base + 1))
        'MsgBox(lineArray(base + 2))
        'MsgBox(lineArray(base + 3))
        'MsgBox(lineArray(base + 4))

        '3) Sätt URL:er på PictureBox1..4

        PictureBox1.Image = Image.FromFile("bilder\\" + lineArray(base))
        PictureBox2.Image = Image.FromFile("bilder\\" + lineArray(base + 1))
        PictureBox3.Image = Image.FromFile("bilder\\" + lineArray(base + 2))
        PictureBox4.Image = Image.FromFile("bilder\\" + lineArray(base + 3))

        rightanswer = lineArray(base + 4)

        '4) Sätt right_answer  from questions.txt

        ' felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        new_question()
    End Sub
End Class
