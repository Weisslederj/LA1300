# LA1300 Projekt-Dokumentation

Honey: Spycher, Bächli, Müller, Nursiwat, Oesch

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 22.11.22      | 0.0.1   | Wir haben uns mit WinForms bekannt gemacht und uns für ein Kartenspiel Projekt entschieden. |
|29/11/22       | 0.0.2   |  Wir haben angefangen das Uno Spiel zu programmieren, vorallem mit dem Visuellen Sachen.          |
|  06/12/22   | 0.0.3   |    Wir haben weiter programmiert und haben die meissten visuellen sachen fertig die spielllogik ist aber noch nicht fertig.       |
|  13/12/22 | 0.0.4   |                                                              |
|       | 0.0.0   |                                                              |


## 1 Informieren

### 1.1 Ihr Projekt

Wir machen ein Uno in Windows Forms.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss   |   Funktional   | Ich will, dass ein Kartendeck auf dem Spieltisch existiert, damit die Karten spielbar sind.|
| 2    |        Muss   |   Funktional   | Ich will, dass am Start des Spiels die Anzahl der Spieler angegeben wird, damit man Variationen hat.  |
| 3    |        Muss   |   Funktional   | Ich will, dass am Start des Spiels jedem Spieler eine Anzahl an Karten ausgeteilt wird, damit er Karten hat.|
| 4    |        Muss   |   Funktional   | Ich will, dass man Karten legen kann, dass das Spiel gespielt werden kann.|
| 5    |        Muss   |   Funktional   | Ich will, dass nach einer gelegten Karte der nächste Spieler dran ist, damit alle spielen können.|
| 6    |        Muss   |   Funktional   | Ich will, dass sobald einer keine Karten mehr hat das Spiel gewinnt, dass es ein Ende gibt.|
| 7    |        Muss   |   Funktional   | Ich will, dass man nach einer Runde gefragt wird ob man nochmals spielen möchte, dass das Programm nicht neugestartet werden muss.|
| 8    |       Muss   |   Funktional   | Ich will, dass man ein Spielmenu vor dem Start des Spiel aufrufen kann, damit man interessantere Spiele hat.|
| 9    |       Kann   |   Funktional   | Ich will, dass ein Rundencounter angezeigt wird, damit man weiss in welcher Runde man gewonnen hat.|
| 10    |       Kann   |   Funktional   | Ich will, dass man eine Karte hat um die Farbe neu zu wählen, dass es Cooler ist  |
| 11    |       Kann   |   Funktional   | Ich will, dass es eine Karte gibt, die den nächsten Gegner aussetzt, damit es cooler ist. |
| 12   |       Kann   |   Funktional   | Ich will, dass es eine karte hat, die die Spielrichtung wechselt, damit es cooler ist. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Spiel wird gestartet | - | Karten werden auf Tisch angezeigt.|
| 1.2  | Spiel wurde gestartet             |  Karten kann gecklickt werden       |   Karte reagiert je nach Typ (eigene Karte,Kartenstapel usw.)            |
| 1.3  |  Spiel wurde gestartet         | - |  Karten an Spieler verteilt  |
| 4.1  | man braucht neue Karten              |Spieldeck wird gedrückt            |    man bekommt eine neue Karte               |
| 5.1  | 1 Karten abgelegt  | nächster Spieler    | Karten vom nächsten Spieler werden angezeigt       |
| 6.1  | Spieler hat keine Karten mehr |    -    | Spieler gewinnt     |
| 7.1 |              |         |                   |
| 2.1 |  Start       |  Ahnzahl der Spieler|   Spiel wird mit x Spieler gestartet |
| 3.1 |  Start des Spieles | - | 7 Karten werden an alle Spieler ausgeteilt  |                  
| 4.1  |  Eigen Karten sind auf dem Screen           |   Karte wird auf den Spiel-stapel gelegt      |    Karte wird gelegt wenn sie auf den Stapel gelegt wird. |
| 5.1  |  Spieler hat eine Karte gelegt            |   nächster-Spieler Button      |   Näschter Spielr kann Spielen                |
| 6.1 |   Spieler hat keine Karten mehr           |  - |   Spiler gewinnt(Gewinner Animation)                 |
| 7.1 |    Nach einer Runde nochmal Spielen          |   Nochmal Spielen      |    Uno Startet auswahl ob man mit gleich viel Personen Spielen will.       |
| 8.1 |    Duplikat ist gleich wie 4.          |         |                   |
| 10.1 |  Vor dem Spiel ein Menü           |   Menü-Button     |   Menü wird vor dem Spiel angezeigt                |
| 11.1 |    Runden counter          |  q Runde vorbei    |      Rundencounter +1             |
| 12.1 |     Karte die Farbe neu wünscht         |  Karte gelegt       |   Alle z.B. (Roten) Karten können auf dies Karte gelegt werden.             |
| 13.1 |     Karte die Richtung Wechselt         |   Karte gelgt      |     Richtung der Spieler-Reihenfolge wird gewechselt.             |
| 11.1 |  Karte die einen Spielr aussetzen lässt            |   Karte gelegt      |   nächster Spieler kann keine Karte legen.                |




### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       | Nursiwat          | Der User werden Karten gegeben             |     30 min          |
| 2.A  |       | Nursiwat          | Der User wird gefragt ob er noch eine Karte ziehen will           |   35 min            |
| 3.A  |       | Nursiwat          | Die Karten sind immer gemischt             |  50 min            |
| 4.A  |       | Nursiwat          | jede Karte hat eine andere Farbe und Nummer        | 60 min              |
| 5.A  |       | Nursiwat          | Wenn man auf den Deck drückt bekommt man eine neue Karte             |  40 min             |
| 6.A  |       | Nursiwat          |  Insgesamt gibt es 40 Karten            |  30 min             |
| 7.A  |       |           |              |               |
| 8.A  |       |           |              |               |
| 9.A  |       |           |              |               |
| 10.A |       |           |              |               |


Total: 


## 3 Entscheiden

Wir mussten entscheiden welche Regeln wir zum Uno hinzufügen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
