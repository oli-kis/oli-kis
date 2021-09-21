# LA1200 Random Number Generator
Ich habe im Rahmen des Informatik Lernatelier's einen **Random Number Generator** programmiert, der eine Zufallszahl generiert, welche der User erraten muss.
## Aufgabenstellung
Unsere Aufgabe war, ein Programm zu programmieren welches eine **Zufallszahl** zwischen 1-100 generiert. Der User muss dann die Zahl erraten und bekommt bei jedem falschen Versuch einen Tipp.

### Ziele
###### Hauptziele:
1. Das Programm lässt eine zufällige Zahl generieren.
2. Der Benutzer kann so viel raten wie er will.
3. Das Programm kann mit Fehleingaben umgehen.
4. Für jeden falschen Rateversuch wird ein Tipp ausgegebn.

###### Erweiterte Ziele:
5. Das Programm schreibt mit unterschiedlichen Farben.
6. Der User kann, falls er möchte, das Spiel neustarten.
7. Das Programm spielt während des Spiels Hintergrundmusik ab.
8. Bei der Eingabe gewisser Zahlen erscheint ein Easter Egg.
9. Ein Highscoreboard erstellen.

## Inhalt

### Video

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Video%20Thumbnail.png?raw=true)](https://youtu.be/rmw3Wywplo4)

### Bild
##### Auf diesem Bild wird dargestellt wie die Zufallszahl generiert wird und der User nach seinem Namen gefragt wird.
![Mein Programm!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/CodeImage.png?raw=true "CodeImage")

### Text

Wenn das Programm gestartet wird fängt es automatisch an Musik zu spielen, dafür muss man `using System.Media;` verwenden und eine Extension Downloaden. 

Danach wird der User begrüsst und nach seinem Namen gefragt. Im Hintergrund wird schon eine zufällige Zahl zwischen 1-100 generiert die der User danach erraten kann. 

Jede Eingabe die vom User getätigt wird, wird vom Programm geprüft und erkannt ob die eingegebene Zahl zu gross, zu klein oder eine Fehleingabe ist.
Wenn der User die Zahl errät wird ihm gratuliert und die Anzahl Versuche werden angezeigt. 
Damit die Anzahl Versuche gezählt werden, habe ich eine neue `Variable` erstellt welche bei jedem Rateversuch eins hoch gezählt wird.

So erkennt das Programm Fehleingaben:

```csharp
string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please use an actual number ! ! !");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
```

### Reflektion/Verifikation

| Zielnummer     | Gab es Probleme? | Habe ich das Ziel erreicht? |
| ----------- | ----------- | ------------|
| 1 | Nein       | Ja |
| 2 | Nein       | Ja |
| 3 | Nein       | Ja |
| 4 | Nein       | Ja |
| 5 | Nein       | Ja |
| 6 | Nein       | Ja |
| 7 | Ja, ich habe sehr viel Zeit gebraucht um herauszufinden wie man Musik einfügen kann, nächstes Mal schaue ich mir direkt ein Youtube Video an.        | Ja |
| 8 | Nein       | Ja |
| 9 | Ja, ich hatte zu wenig Zeit ein Highscoreboard zu erstellen, nächstes Mal setze ich mir keine zu Hohe Ziele      | Nein |

###### Was habe ich gut gemacht:
- Mein Programm läuft ohne Probleme und ich kam schnell voran mit dem Programmieren.
- Freie Zeit für Extraziele zu verwenden und das Programm auszubauen.

###### Für nächstes Mal kann ich folgendes besser machen:
- Weniger Zeit für die Hauptziele einplanen
- Öfters Youtube als Informationsquelle verwenden
- Mehr Zeit für Zusatzziele einplanen oder nicht zu grosse Ziele setzten
- Die Testfälle genauer beschreiben und mehr davon schreiben

###### Das hat mir dabei geholfen
- Youtube Video 
