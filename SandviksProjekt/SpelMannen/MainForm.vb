Imports System.IO

Public Class MainForm
    Dim rightanswer As Integer
    Dim poäng As Integer = 0
    Dim questionHistory As New Queue(Of Integer)
    Dim path As String = "."
    Dim lineArray() As String
    Dim num_questions As Integer
    Dim s As String
    Dim unused_question_found As Boolean
    Dim highScore As New SortedDictionary(Of Integer, String)  ' highScore(7) => "KALLE" highScore(4) = "PELLE" etc

    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Framsidan.Show()
        Me.BackColor = Framsidan.BackColor 'här blir bakgrunden lika som den bakgrunden man valde i första formuläret
        reset_form()
        loadHighScore()
        loadQuestions()
        new_question()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If rightanswer = 1 Then 'här kollar den i notepaden vad vi har skrivit som rättsvar, är rättsvar 1 så går den till RättSvar() subrutinen. 
            Rättsvar()
        Else
            felsvar() 'här är svaret fel så jag hoppar ner till subrutinen "felsvar" 
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If rightanswer = 2 Then
            Rättsvar() 'i min textfil har jag skrivit vilken siffra som är rättsvar, så programmet vet vilken siffra som är rättsvar.
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
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        increasePoints() 'ökar poäng med +1
        SenasteSvar.Text = "RÄTT!"
        SenasteSvar.ForeColor = Color.Green
        'MsgBox("Rätt, din poäng just nu är " & poäng)
        KollaOmSlut()
    End Sub

    Private Sub felsvar()
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        decreasePoints()
        SenasteSvar.Text = "FEL!"
        SenasteSvar.ForeColor = Color.Red
        'MsgBox("försök igen, din poäng just nu är " & poäng)
        KollaOmSlut()
    End Sub

    Private Sub KollaOmSlut()
        If questionHistory.Count < num_questions And poäng < num_questions Then 'här kollar vi om questionHistory.count är lika med de totala antal frågor, då är spelet slut. Om det inte är så ska nästa fråga laddas

            Timer1.Start() ' här väntar vi 2 sek på nästa fråga
        Else
            'Inga fler frågor!!!
            EndGame()
        End If
    End Sub

    Private Sub EndGame()
        KollaOmHighScore(poäng)
        SenasteSvar.Text = ""
        poäng = 0
        Points.Text = ""
        questionHistory.Clear()
        Me.Opacity = 0 'här går vi tillbaka till framsidan så man får starta om spelet
        Framsidan.Opacity = 100

    End Sub

    Private Sub KollaOmHighScore(p As Integer) 'här får användaren skriva sitt namn och är poängen top 3 i highscore listan kommer den bytas ut mot det namnet som blivit inskrivet
        Dim namn As String = InputBox("Ange ditt namn")
        If namn <> "" Then 'avbryt
            highScore(-p) = namn
            UppdateraHighScore()
            saveHighScore()
        End If
    End Sub

    Private Sub UppdateraHighScore()
        Dim count As Integer = 0
        For Each xxx In highScore
            'MsgBox(xxx.Key.ToString + " : " + xxx.Value)

            Select Case count
                Case 0
                    HighScore1.Text = (-xxx.Key).ToString + " : " + (xxx.Value)
                Case 1
                    HighScore2.Text = (-xxx.Key).ToString + " : " + (xxx.Value)
                Case 2
                    HighScore3.Text = (-xxx.Key).ToString + " : " + (xxx.Value)
                Case Else
                    'Skip
            End Select
            count += 1
        Next
    End Sub
    Private Sub saveHighScore()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path + "\\highscore.txt", False) 'öppnar textfilen highscore.txt 
        For Each xxx In highScore
            file.WriteLine((xxx.Key).ToString + "," + (xxx.Value))
        Next
        file.Close()
    End Sub

    Public Sub increasePoints()
        poäng += 1
        Points.Text = poäng
    End Sub

    Public Sub decreasePoints()
        poäng -= 1
        Points.Text = poäng
    End Sub

    Public Sub resetPoints()
        poäng = 0
        Points.Text = poäng
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'här rensar jag bort det senaste svaret 
        Timer1.Stop()
        SenasteSvar.Text = ""
        new_question()
    End Sub

    Private Sub Help(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Klicka på 1 av de fyra bilderna som inte passar in! Lycka till!")
    End Sub

    Private Sub reset_form()
        questionHistory.Clear()
    End Sub

    Private Sub loadHighScore()
        'här använde jag mig av https://msdn.microsoft.com/en-us/library/cakac7e6.aspx?f=255&MSPPError=-2147217396

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path + "\\highscore.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim pts As Integer = currentRow(0)
                    Dim name As String = currentRow(1)

                    highScore(pts) = name

                    'Dim currentField As String
                    'For Each currentField In currentRow
                    'MsgBox(currentField)
                    'Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

        UppdateraHighScore()

    End Sub


    Private Sub loadQuestions()
        lineArray = File.ReadAllLines(path + "\\questions.txt")
        num_questions = lineArray.Length / 5
        'MsgBox("We have " + num_questions.ToString + " Questions!")
    End Sub

    Private Sub new_question()
        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        Dim maxnumquestion As Integer = lineArray.Length / 5
        'MsgBox("Number of questions = " & maxnumquestion)

        'här slumpar vi fram en fråga 1, 2, n  (n = antral frågor i questions.txt)
        'kolla att inte frågan redan använts!
        Dim question_base As Integer
        unused_question_found = False
        While (Not unused_question_found)
            Randomize()
            Dim q As Integer = CInt(Math.Floor((maxnumquestion - 1 + 1) * Rnd())) + 1
            'MsgBox("slumpar fram fråga " & q)
            question_base = (q - 1) * 5

            Dim found_in_history As Boolean = False
            For Each i In questionHistory
                If (i = question_base) Then
                    found_in_history = True
                End If
            Next

            unused_question_found = Not found_in_history
        End While

        questionHistory.Enqueue(question_base)

        'MsgBox(lineArray(base))
        'MsgBox(lineArray(base + 1))
        'MsgBox(lineArray(base + 2))
        'MsgBox(lineArray(base + 3))
        'MsgBox(lineArray(base + 4))

        '3) Sätt URL:er på PictureBox1..4

        PictureBox1.Image = Image.FromFile("bilder\\" + lineArray(question_base))
        PictureBox2.Image = Image.FromFile("bilder\\" + lineArray(question_base + 1))
        PictureBox3.Image = Image.FromFile("bilder\\" + lineArray(question_base + 2))
        PictureBox4.Image = Image.FromFile("bilder\\" + lineArray(question_base + 3))

        '4) Sätt right_answer  from questions.txt
        rightanswer = lineArray(question_base + 4)

    End Sub

End Class
