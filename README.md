# Project TDC 📝
Eine kompetitive To-Do List Android-App, die es Freunden ermöglicht, sich im Abarbeiten ihrer To-Do Lists zu messen.

## Inhaltsverzeichnis
- [Über das Projekt](#über-das-projekt)
- [Vision](#vision)
- [Technologien](#technologien)
- [Team](#team)
- [Scrum-Setup](#scrum-setup)
- [Funktionale Anforderungen](#funktionale-anforderungen)
- [Nichtfunktionale Anforderungen](#nichtfunktionale-anforderungen)
- [UI-Mockup](#ui-mockup)
- [Klassendiagramm](#klassendiagramm)
- [Projektaufbau](#projektaufbau)
- [Abschluss Sprint 1](#abschluss-sprint-1)
- [Abschluss Sprint 2](#abschluss-sprint-2)

## Über das Projekt
Project TDC ist eine Android-App, die das Abarbeiten von To-Do Listen zu einem Wettbewerb unter Freunden macht. Erledigte Aufgaben geben Punkte, die zur Verbesserung eines virtuellen Avatars genutzt werden können. Avatare können anschließend gegeneinander antreten, um den Fortschritt der Benutzer visuell darzustellen.

## Vision
Unsere Vision ist es, eine innovative und benutzerfreundliche App zu liefern, die Stabilität und Leistung bietet. Wir setzen auf agile Entwicklungsmethoden und bewährte Technologien, um die beste User Experience zu gewährleisten.

## Technologien
- **Programmiersprache:** C#
- **Framework:** .NET MAUI für plattformübergreifende Entwicklung
- **Entwicklungsumgebung:** Visual Studio
- **Versionsverwaltung:** Git (Main Branch, Feature-Branches, etc.)
- **CI/CD und Datenbanken:** Docker und Jenkins (Integration in späteren Sprints)
- **Tests:** Unit-Tests und REST-Tests (Integration in späteren Sprints)

## Team
- **Hannah** - Product Owner / Entwickler
- **Christian** - Scrum-Master / Entwickler
- **Julian** - Blog-Master / Entwickler
- **Leo** - Entwickler
- **Nico** - Entwickler

## Scrum-Setup
- **Sprintlänge:** 2 Wochen
- **Meetings:** 
  - Weekly: Jeden Montag von 20-21:30 Uhr
  - Retrospektiven: Alle zwei Wochen
  - Dailys: Nach Bedarf
- **Story Points:** 1 Story Point = 1h (in 2-er Potenzschritten: 2, 4, 8, 16)
- **Plattform:** Jira (Scrum-Board, Backlogs, Aufgabenverfolgung)

## Funktionale Anforderungen
1. **Benutzerkonto-Verwaltung**
   - Registrierung, Anmeldung, Profil bearbeiten, Passwort zurücksetzen
2. **To-Do-Listen-Verwaltung**
   - Listen erstellen, Aufgaben hinzufügen/bearbeiten/löschen/abschließen
3. **Freunde-Verwaltung**
   - Freunde finden, hinzufügen, und anzeigen lassen

## Nichtfunktionale Anforderungen
- **Ladezeiten:** Minimale Wartezeiten für Listenaktionen
- **Benutzerfreundlichkeit:** Intuitive UI für schnelle Einarbeitung
- **Zuverlässigkeit:** Weniger als 1% Abstürze pro 1000 Interaktionen
- **Reaktionsfähigkeit:** Anpassung an verschiedene Bildschirmgrößen

## UI-Mockup
Das Hauptdesign zeigt aktive To-Do Listen. Eine Freundesliste und das Profil sind über den Avatar erreichbar. Verschiedene Ansichten ermöglichen das einfache Wechseln zwischen Listen. Die Punkte der Benutzer sind sichtbar, die Spielfunktion folgt nach den Hauptfunktionen.

## Klassendiagramm
Wir haben ein Klassendiagramm entwickelt, das die notwendigen Klassen und ihre Beziehungen abbildet. Das Design folgt den SOLID-Prinzipien (Single Responsibility und Open-closed) für wartbaren und erweiterbaren Code.
  --> diese sind unter /docs zu finden

## Projektaufbau
Das Projekt ist in Visual Studio mit Git aufgesetzt. Mit .NET MAUI haben wir eine erste Testoberfläche für Android entwickelt, die die App auf Mobilgeräten synchronisiert und debugging ermöglicht.

## Abschluss Sprint 1
Der erste Sprint diente hauptsächlich der Planung und Vorbereitung. Die Entwicklungsumgebungen wurden eingerichtet, und wir haben uns über Projektziele und Anforderungen abgestimmt.

## Abschluss Sprint 2
Nach dem Setup des Projekts haben wir erste Entwicklungsarbeit begonnen und eine „Hello World“-Demo erstellt. Die Entwicklungsumgebung ermöglicht nun die mobile Simulation, und wir sind startklar für die nächsten Features.

---

Falls ihr Fragen zu unserem Projekt oder den Anforderungen habt, schreibt uns gerne in die Kommentare.

