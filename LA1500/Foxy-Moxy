# LA1400 Foxy Moxy Jump and Run Game
Wir haben im Rahmen des Informatiklernateliers ein **Jump and Run Game** in `c#` programmiert, welches in einer tropischen Umgebung spielt.
# Aufgabenstellung
Unsere Aufgabe war es, ein **kreatives Videospiel** zu programmieren und dabei eigene Ideen zu verwenden. Wir haben uns für ein `Jump and Run` Game entschieden indem man einen Fuchs steuert und versucht ihn durch tropische Insellevels zu befördern ohne zu sterben. 

# Ziele
##### Hauptziele:
1- Der Leser weiss nach dem Lesen was das `Ziel` des Spiels ist.
2- Der Leser weiss danach welche `Gedanken` wir uns zum Projekt gemacht haben.
3- Der Leser weiss nach dem Lesen wie wir es gemacht haben, dass man beim `runterfallen stirbt.`
4- Der Leser weiss danach wie der `Code` aussieht, funktioniert und kann ihn auch anwenden.

# Inhalt

## Foxy Moxy Playthrough Video

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Screenshot%202022-04-05%20141739.png?raw=true)](https://youtu.be/SVrGuDo5-Fc)

## Beschreibung zum Video
Im obigen Video sieht man ein kleines `playthrough` von unserem Videospiel. Das Ziel ist dabei den Fuchs den man steuert zum Ziel zu befördern ohne dabei runterzufallen oder von Fröschen getroffen zu werden. Nebenbei kann man auch Juwelen einsammeln. Dazu kommt möglicherweise bald noch ein Update indem man mit den Juwelen auch Upgrades und Skins kaufen kann. Für das Design haben wir im `Unity Asset Store` das Sunny Land Asset heruntergeladen. Unser Spiel hat insgesamt 3 Level und ein Boss Level am Schluss. Die ersten 3 Level sind alle ziemlich ähnlich aufgebaut. Das Boss Level hat ein ganz anderes Design uns spielt in einer dunklen Höhle. Dabei ist es das Ziel 30 Sekunden lang zu überleben währendessen ein Opossum versucht einen zu jagen. Bei jeder Berührung mit dem Opossum verliert man ein Leben. Wenn man 3 Lebel verloren hat stirbt man und muss das Level erneut starten. 

## Video zur Erklärung von Todesmechanismus

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Screenshot%202022-04-05%20141841.png?raw=true)](https://youtu.be/gYgwc6AJwQ8)

## Bild in Form von Code zum Musik abspielen
```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death_script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 3;

        if (LifeTextScript.lifeAmount < 1)
        {
            SceneManager.LoadScene("game_over");
            ScoreTextScript.coinAmount = 0;
            LifeTextScript.lifeAmount = 3;
        }
    }
}
```

## Erklärung zu Video und Code
Wie man im Video erkennen kann stribt man sobald man zu weit von der Plattform herunter fällt. Das haben wir so gemacht indem wir einfach unter den Spielplatformen einen Block hingesetzt haben, welcher sich über die ganze Level-Breite erstreckt. Danach haben wir einen `Box Collider` hinzugefügt. Dieser `Collider` bewirkt, dass der Spieler auch auf diesem "Todesblock" landen kann. Sobald nun der Spieler diesen "Todesblock" berührt wird das Skript (Code oben) ausgeführt. Das erste was passiert ist, dass 3 Leben abgezogen werden. Als nächstes wird in einem `IF-Statement` geprüft ob die Lebensanzahl kleiner als 3 ist, wenn dies erfüllt ist, wird der **Game Over Screen** geöffnet. Zum Schluss werden noch die gesammelten Juwelen auf 0 gesetzt und die Leben wieder auf 3 gesetzt. 

## Verifikation

| Zielnummer     | Gab es Probleme? | Habe ich das Ziel erreicht? |
| ----------- | ----------- | ------------|
| 1 | Nein       | Ein Mitschüler hat die Aufgabenstellung gelesen und den Playthrough angeschaut und danach verstanden, worum es in dem Projekt geht. |
| 2 | Nein       | Nach der Beschreibung des Playthroughs verstand der Leser unsere Gedankengänge beim Projekt.|
| 3 | Nein       | Nach dem Video und dem Text Part, verstand der Leser, wie das Herunterfallen des Spielers funktioniert. |
| 3 | Nein       | Mit Hilfe des Bildes konnte der Leser sehen, wie der Text in der Praxis aussieht und kann ihn jetzt selbst anwenden. |

## Reflektion

#### Was haben wir gut gemacht:
Das Projekt ist sehr **positiv** herausgekommen. Mit Hilfe des Youtube Tutorials konnten wir die Grundlagen des Projektes, zum Beispiel Steuerung und Grafik, schnell lösen und hatten keine Probleme damit. Den `Bosskampf` in das Spiel einzubringen war schon eine grössere Herausforderung. Zuerst wollten wir einen Boss mit Leben erstellen, aber wir mussten leider feststellen, dass dies nicht so einfach wie gedacht ist. Deshalb haben wir uns entschieden einen Boss zu machen, der den `Spieler verfolgt` und unsterblich ist. Man muss nur 30 Sekunden überleben und hat dann gewonnen. Wir haben also schnell realisiert, dass dies eine zu grosse Aufgabe war und haben uns so Arbeit ersparen können.

#### Für nächstes Mal können wir folgendes besser machen:
Unser Verbesserungsvorschlag für nächstes Mal ist auf jeden Fall ein `Backup des Games` zu haben, da dies unser grösstes Problem bei diesem Projekt war. Aufgrund des Einfügen neuer Assets für den Boss funktionierte unser Programm plötzlich nicht mehr. Immer wenn man es gestartet hat, kam eine `Compile Error Meldung` und das Programm startete nicht. Nach 2 Stunden sinnlosem herumprobieren dachten wir schon, dass das Programm für immer verloren ist. Glücklicherweise schickten wir uns am Ende das Programm gezippt, damit man eine Vorlage für das neue Projekt hat. Aus irgendeinem Grund funktionierte das Programm nach dem zippen wieder und es war gerettet. Deshalb sollten wir, jedes Mal nach beenden der Lektion, ein Backup erstellen, damit dies nicht noch einmal passiert. Es wäre ebenfalss eine gute Idee, beim zusammenführen von zweien Projekten ein Backup zu machen, da bei uns dort das Problem aufgetaucht ist.




