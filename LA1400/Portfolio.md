# LA1400 Flächenberechnungs-Programm
Wir haben im Rahmen des Informatiklernateliers ein **Programm zur Berechnung von Flächen** in `c#` programmiert.
# Aufgabenstellung
Unsere Aufgabe war es, ein Programm zu programmieren, welches eine **Kreisflächen** und **Kreisumfang** berechnen kann und es dem User möglichst schwer macht etwas falsches einzutippen.

# Ziele
##### Hauptziele:
- Der Leser weiss nach dem Lesen wie man in Win-Forms `Hintergrundmusik` einfügen kann.
- Der Leser weiss danach welchen `Code` man dafür braucht.
- Der Leser kann den Code danach in seinem eigenen Programm anwenden

# Inhalt

## Video

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Algorithmen-e1552378144472.jpg?raw=true)](https://youtu.be/8FYfcvSUqBs)

### Bild in Form von Code zum Musik abspielen
```csharp
private SoundPlayer soundPlayer;

soundPlayer = new SoundPlayer("eigeneMusik.wav")

private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Start";
                soundPlayer.Stop();
            }
```

### Text in Form einer Erklärung wie man die Musik Datei einfügt
Zuerst sucht man sich auf Youtube ein beliebiges Musikvideo welches am besten nicht allzu lange geht, da es sonst zu Ladeschwierigkeiten kommen kann. Wenn man ein Video gefunden hat, kopiert man sich die URL und geht auf einen YT-Video Downloader wie (https://9convert.com/en107). Wenn man dann das Video auf dem PC hat, muss man es noch zu einer .wav Datei konvertieren (https://online-audio-converter.com/de/). Jetzt muss man nur noch den Code einfügen, welcher oben erklärt wurde, und noch den Dateipfad der .wav Datei angeben. Dies macht man am besten indem man auf die Eigenschaften klickt und den einfach den Pfad kopiert und in den Code einfügen. Das einzige Problem bei dieser Methode ist, dass niemand anderes die Musik abspielen kann, da die Datei lokal gespeichert wurde.

### Reflektion/Verifikation

| Zielnummer     | Gab es Probleme? | Habe ich das Ziel erreicht? |
| ----------- | ----------- | ------------|
| 1 | Nein       | Ja, mein Banknachbar weiss jetzt wie man Hintergrundmusik einfügt |
| 2 | Nein       | Ja, mein Banknachbar weiss jetzt welchen Code man dafür braucht |
| 3 | Nein       | Ja, mein Banknachbar kann seinen Code jetzt in seinem Programm benutzen |


##### Was habe ich gut gemacht:
- Die Kommuinkation in der Gruppe war sehr gut.
- Das Pair-Programming ist sehr gut verlaufen und wir kamen schnell vorwärts.

##### Was lief nicht so gut
- Beim verbinden der verschiedenen Forms welche wir erstellt haben kam es zu Problemen und das Programm funktionierte nur teilweise, so verloren wir viel Zeit und konnten nicht mehr alle Funktionen programmieren

##### Für nächstes Mal kann ich folgendes besser machen:
- Wir könnten uns bei grossen Problemen schneller Hilfe von der Lehrperson holen um nicht zu viel Zeit zu verschwenden.
