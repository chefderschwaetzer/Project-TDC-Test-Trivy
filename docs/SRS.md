# Project-TDC
## Softwareanforderungen

### 1. Einleitung

#### 1.1 Übersicht
(Was sind die Verkaufsargumente bzw. Alleinstellungsmerkmale Ihrer Software?)

#### 1.2 Geltungsbereich
(Was wird in diesem Dokument behandelt (nicht behandelt)? Ist es für Ihr gesamtes System oder ein Subsystem? Deckt es sowohl funktionale als auch nichtfunktionale Anforderungen ab? (Werden Sie einige Anforderungen in ein anderes Dokument auslagern?))

#### 1.3 Definitionen, Akronyme und Abkürzungen
(Definitionen aller Begriffe, Akronyme und Abkürzungen, die für die ordnungsgemäße Interpretation dieses Dokuments erforderlich sind.)

#### 1.4 Referenzen
(Eine vollständige Liste aller referenzierten Dokumente. Jedes Dokument sollte anhand von Titel, Datum und Veröffentlichungsorganisation identifiziert werden. Sie können auch Hyperlinks einfügen, um die Referenzen bequem zu öffnen.)


### 2. Funktionale Anforderungen
Dieser Abschnitt beschreibt die funktionalen Anforderungen für die To-Do-Competition-App. Es soll als Grundlage für die Entwicklung, das Testen und die Wartung des Systems dienen.
#### 2.1 Benutzerkonto-Verwaltung [(UML)](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/UserAccountManager.pdf)

##### 2.1.1 Registrierung und Anmeldung
Benutzer können sich registrieren oder anmelden, um auf die App zuzugreifen.
##### 2.1.2 Profil bearbeiten
Benutzer können ihr Profil bearbeiten (z. B. Benutzername, Passwort, Profilbild, E-Mail).
Ergebnis: Aktualisierung der Benutzerdaten im System.
##### 2.1.3 Passwort zurücksetzen
Benutzer können ihr Passwort zurücksetzen, falls sie es vergessen haben.
Ergebnis: E-Mail mit Link zum Zurücksetzen des Passworts wird versendet.

[Aktivitäts-Diagramm  - Login](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/LoginActivity.pdf)

[Mockup - User profile](https://github.com/Ninetilt/Project-TDC/blob/main/docs/ui/profile.png)



#### 2.2 To-Do-Listen-Verwaltung [(UML)](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/ToDoListManagement.pdf)

##### 2.2.1 To-Do-Liste erstellen
Benutzer können neue To-Do-Listen erstellen und diese benennen.
##### 2.2.2 To-Do-Item hinzufügen
Benutzer können Aufgaben zu ihren To-Do-Listen hinzufügen.
##### 2.2.3 To-Do-Item bearbeiten
Benutzer können vorhandene Aufgaben bearbeiten (Titel, Beschreibung, etc.).
##### 2.2.4 To-Do-Item löschen
Benutzer können Aufgaben aus einer To-Do-Liste löschen.
##### 2.2.5 To-Do-Item als erledigt markieren
Benutzer können Aufgaben als erledigt markieren und erhalten dafür Punkte.

[Aktivitäts-Diagramm - CreateListActivity](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/CreateListActivity.pdf) 

[Aktivitäts-Diagramm - ListRewarding](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/RewardingActivity.pdf)

[Sequenz-Diagramm - FinishList](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/FinishListSequence.pdf)

[Mockup - Main page](https://github.com/Ninetilt/Project-TDC/blob/main/docs/ui/main_page.png)

[Mockup - List view](https://github.com/Ninetilt/Project-TDC/blob/main/docs/ui/list_view.png)



#### 2.3 Freunde-Verwaltung [(UML)](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/FriendListManager.pdf)

##### 2.3.1 Freunde finden
Benutzer können nach Freunden suchen
##### 2.3.2 Freunde hinzufügen
Benutzer können Freundesanfragen versenden
##### 2.3.3 Freunde anzeigen
Benutzer können sich ihre Freundesliste anzeigen lassen

[Aktivitäts-Diagramm  - FriendRequest](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/FriendRequestActivity.pdf)
[Sequenz-Diagramm - AddFriend](https://github.com/Ninetilt/Project-TDC/blob/main/docs/uml/PDF/AddFriendSequence.pdf)

[Mockup - Friendlist](https://github.com/Ninetilt/Project-TDC/blob/main/docs/ui/friendlist.png)



### 3. Nichtfunktionale Anforderungen
Dieser Abschnitt beschreibt die nicht-funktionalen Anforderungen für die To-Do-Competition-App. Es soll als Grundlage für die Entwicklung, das Testen und die Wartung des Systems dienen.
#### 3.1 Ladezeiten/Performance
Das Öffnen und Abhaken von Aufgaben in den Listen soll nur wenige Augenblicke benötigen, damit nach dem Erledigen einer Aufgabe die App nur kurz geöffnet werden muss.

#### 3.2 Benutzerfreundlichkeit
Die Benutzeroberfläche sollte intuitiv und einfach zu bedienen sein, sodass sich neuen Nutzern die grundlegende Funktionalität innerhalb weniger Minuten erschließt.

#### 3.3 Zuverlässigkeit
Die App sollte stabil laufen und weniger als 1% Abstürze pro 1000 Benutzerinteraktionen aufweisen.

#### 3.4 Reaktionsfähigkeit: 
Das User-Interface sollte sich an verschiedene Bildschirmgrößen (verschiedene Smartphone-Modelle, Tablets, etc.) anpassen.


### 4. Technische Einschränkungen
(Geben Sie alle wichtigen Einschränkungen, Annahmen oder Abhängigkeiten an, z. B. alle Einschränkungen darüber, welcher Servertyp verwendet werden soll, welche Art von Open-Source-Lizenz eingehalten werden muss usw.)
