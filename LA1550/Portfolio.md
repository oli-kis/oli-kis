# LA1550 JuniorRobot in Robocode programmieren.
Wir haben im Rahmen des Informatiklernateliers einen **Junior Robot** in `JavaScript` programmiert.
# Aufgabenstellung
Unsere Aufgabe war es, einen Roboter zu programmieren, welcher sich durch eine `gute Taktik` auszeichnet und auf einer **1000x1000** Turnierfläche gegen andere Bots möglichst viele Punkte holt.

# Ziele

| Zielnummer     | Beschreibung |
| ----------- | ------------|
| 1 | Der Leser weiss nach dem Lesen welche Taktik mein Bot verfolgt.|
| 2 | Der Leser weiss danach, wie die Taktik funktioniert.|

# Inhalt

## Video

[![Zum Video!](https://github.com/oli-kis/oli-kis/blob/oli-kis/img/Robocode_logo_tanks.png?raw=true)](https://youtu.be/WkD2roB4G58)

### Code, der zeigt wie der Bot die Distanz zu anderen Bots erkennt und die optimale Schussstärke auswählt.
```javascript
	public void onScannedRobot() {
	
		out.println("Your dead!");
		distance = scannedDistance;
		turnGunTo(scannedAngle);
		smartFire(scannedDistance);	
	}

	public void smartFire( int scannedDistance)
	{
	if(distance > 300)
	{
		fire(1);
	}
	if(distance > 100)
	{
		fire(2);
	}
	if(distance < 200)
	{
		fire(3);
	}
	}
```

### Text in Form einer Erklärung der Taktik
In diesem Abschnitt erkläre ich wie die Taktik meines Bots funktioniert:
Zuerst dreht sich der Bot in Richtung Süden und fährt dann gerade aus bis er auf eine Wand trifft. Danach fährt er immer wieder an der Wand entlang und versucht andere Bots ausfindig zu machen und auf sie zu schiessen. 
Sobald er einen Gegner gescannt hat, printed der Bot folgende Nachricht: `Your Dead!`
Dann dreht er seine Gun zu dem Winkel auf dem ein Gegner gescannt wurde. Danach wird das Smartfire aktiviert, der Bot entscheidet je nach gescannter Distanz welche Schussstärke verwendet werden soll. Wenn der Gegner sehr nahe ist schiesst er mit viel Energie und wenn der Gegner weit entfernt ist verwendet er wenig Energie da die Wahrscheinlichkeit zu treffen geringer ist.
Wenn der Bot dann doch mal von einem Gegner getroffen wird, fährt er einfach 40 Felder zurück und der Kreislauf fängt von vorne an.

**Fazit der Taktik**
Die Taktik kann oft sehr gut sein, da der Bot dann nicht mehr von allen Seiten angegriffen werden kann. 
Das Problem liegt allerdings am zufälligen Start. Wenn der Start ganz im Norden der Karte ist fährt der Bot einmal über das ganze Feld um die südliche Wand zu erreichen auf diesem Weg kann er von vielen Seiten attackiert werden was nicht sehr vorteilhaft ist.

### Reflektion/Verifikation

| Zielnummer     | Gab es Probleme? | Habe ich das Ziel erreicht? |
| ----------- | ----------- | ------------|
| 1 | Nein       | Ja, mein Banknachbar weiss jetzt welche Taktik mein Bot verfolgt|
| 2 | Nein       | Ja, mein Banknachbar weiss jetzt wie die Taktik funktioniert |


##### Was habe ich gut gemacht:
- Ich habe jede Stunde versucht neue Taktiken zu finden und diese auszuprobieren
- Ich habe mir im Internet starke Bots herausgesucht und versucht die Taktik zu vereinfachen um eine möglichst gute Taktik zu entwickeln.

##### Was lief nicht so gut
- Ich hatte immer wieder das Gefühl, dass das was ich programmiert habe gar nicht richtig funktioniert hat und je mehr ich versucht habe es hinzubekommen desto schlimmer wurde es.

##### Für nächstes Mal kann ich folgendes besser machen:
- Mir bei der Lehrperson Hilfe holen.
- Mir auch auf anderen Websites als der API Hilfe holen da diese wie ich finde etwas kompliziert geschrieben ist.


