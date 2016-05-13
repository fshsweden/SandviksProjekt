Public Class Framsidan

    Private Sub Btn1_Click(sender As System.Object, e As System.EventArgs) Handles Btn1.Click
        Me.Opacity = 0 'här försökte vi med me.hide men av någon anledning fungerade inte det, men me.opacity = 0 funkade lika bra
        MainForm.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click 'här skriver jag instruktionerna till spelet samt att de kan ändra färg på bakgrund
        MsgBox(" Du kommer få upp 4 olika bilder, av dessa 4 bilder ska du lista ut vilken som inte passar in. Klicka på den bilden som du tycker inte passar in. Kom ihåg, temat kan vara om vad som helst så tänk till innan du klickar. Tryck på färgerna ner till höger om du vill ändra färg på spelets bakgrund")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click 'här är de olika knapparna för att ändra färg
        Me.BackColor = Color.Coral

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.BackColor = Color.LawnGreen

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.BackColor = Color.Magenta

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.BackColor = Color.DodgerBlue

    End Sub
End Class