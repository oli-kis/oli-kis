# LA1300 Workshop-Anmeldungsprogramm
Wir haben im Rahmen des Informatiklernateliers ein **Workshop-Anmeldungsprogramm** in `c#` programmiert.
# Aufgabenstellung
Unsere Aufgabe war es, ein Programm zu programmieren, welches eine **Datei mit E-Mail-Adressen** und **drei Lieblingsworkshops** ausliest und danach mithilfe eines `Algorithmus` so viele Personen wie möglich in ihren Lieblingsworkshop einteilt.

# Ziele
##### Hauptziele:
- Der Leser weiss nach dem Lesen wie unser Algorithmus aufgebaut ist.
- Der Leser weiss danach für was genau der Algorithmus da ist.

# Inhalt

### Text in Form einer Erklärung wie der Algorhitmus funktioniert

Zuerst wird in einer `do-while Schleife` eine zufällige Zahl, zwischen 0 und der Anzahl Teilnehmer, generiert und danach in eine Liste gespeichert, sodass keine Zahl zweimal generiert wird. Danach wird die generierte Zahl und der Name der im Array an der Stelle der generierten Zahl steht geschrieben. Nun geht das Ganze in eine `switch-case`, wenn die erste Priorität Fussball ist geht es durch das `case` "Fussball" und wird dort in den `Array` Fussball einsortiert. Falls dieser voll ist, geht das Ganze in das case mit der 2. Priorität, falls dieser `Array` auch schon voll ist, wird die Person in den `Array` mit der 3. Priorität einsortiert.
Das Ziel dieses Algorithmus ist, die Workshopanmeldung so fair wie möglich zu gestalten.


## Video

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Algorithmen-e1552378144472.jpg?raw=true)](https://youtu.be/Eeao3qKMB2s)

### Bild in Form vom Algorithmus Code
```csharp
for (int i = 0; i < counter-1; i++)
            {
                do
                {
                    number = rnd.Next(0, counter-1);
                } while (listNumbers.Contains(number));

                listNumbers.Add(number);
                Console.WriteLine(number + " " + user[number]);
                string userInput = prio1[number];

                switch (userInput)
                {
                    case "fussball":
                            f++;
                            Array.Copy(user, number, soccer, f, 1);
                        break;

                    case "basketball":
                            b++;
                            Array.Copy(user, number, basketball, b, 1);
                        break;

                    case "hockey":
                            h++;
                            Array.Copy(user, number, hockey, h, 1);
                        break;

                    case "tennis":
                            t++;
                            Array.Copy(user, number, tennis, t, 1);
                        break;

                    default:
                        break;
                }
            }
```

### Reflektion/Verifikation

| Zielnummer     | Gab es Probleme? | Habe ich das Ziel erreicht? |
| ----------- | ----------- | ------------|
| 1 | Nein       | Ja, mein Banknachbar weiss jetzt wie mein Algorithmus funktioniert |
| 2 | Nein       | Ja, mein Banknachbar weiss jetzt für was der Algorithmus verwendet wird |


##### Was habe ich gut gemacht:
- Ich bin gut auf Verbesserungsvorschläge eingegangen und habe versucht meine Arbeit zu verbessern
- Ich habe mir einen guten und spannenden Algorithmus ausgedacht
- Ich habe meine Arbeit nach einigen Startschwierigkeiten sauber und zuverlässig erledigt

##### Was lief nicht so gut
- Wir haben uns bei den Arbeitspaketen teilweise nicht gut genug besprochen und haben ähnliche Dinge programmiert oder konnten gar nicht richtig arbeiten, weil uns noch Code von anderen fehlte.
- Ich haben manchmal aufgrund von fehlender Konzentration meine Arbeit nicht sauber gemacht.

##### Für nächstes Mal kann ich folgendes besser machen:
- Wir sollten uns in der Gruppe am Anfang besser besprechen, welche Arbeitspäckchen miteinander verknüpft sind, um uns die Arbeitspäckchen so besser aufzuteilen.
- Ich sollte mir am Anfang die Anforderungsanalyse und die Testfälle nochmal genau anschauen, um so nochmal zu erkennen was das Programm können sollte. So erledige ich meine Arbeiten schon beim ersten Versuch sauber und korrekt.
