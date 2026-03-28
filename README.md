# Boutique Shop Platform Prototype

Ein moderner Webshop-Prototyp mit **React + TypeScript** im Frontend und **ASP.NET Core (C#)** im Backend.  
Das Projekt soll einen hochwertigen Boutique-/Lifestyle-Shop darstellen und zusätzlich Erlebnisbereiche wie Lounge, Gaming-Corner oder besondere In-Store-Areas präsentieren.

## Ziel

Dieses Projekt ist ein **produktnaher Fullstack-Prototyp** für eine moderne Shop- und Experience-Plattform.

Der Fokus liegt auf:
- hochwertiger Produktpräsentation
- neutraler, stilvoller Darstellung von katalogartigen Artikeln
- zusätzlichem Erlebnisbereich für Store-Highlights
- sauberer API-Architektur
- containerisiertem Deployment
- späterem Betrieb auf Kubernetes
- Infrastrukturverwaltung mit Terraform

## Tech Stack

### Frontend
- React
- TypeScript
- Vite
- React Router
- Tailwind CSS
- TanStack Query
- Zustand oder Context API

### Backend
- ASP.NET Core Web API
- C#
- Minimal APIs oder Controller-basierte API
- Entity Framework Core
- PostgreSQL
- Swagger / OpenAPI

### Infrastruktur
- Docker
- Kubernetes
- Helm
- Terraform
- GitHub Actions
- optional Argo CD

## Geht das mit dem Shop so?

**Ja, absolut.**

React mit TypeScript eignet sich sehr gut für ein modernes, visuell starkes Shop-Frontend. React unterstützt TypeScript offiziell. ASP.NET Core eignet sich sehr gut als performantes, sauberes Backend für APIs und unterstützt OpenAPI/Swagger direkt für API-Dokumentation. Terraform eignet sich für modulare Infrastrukturverwaltung mit State und Backend-Konzept. citeturn745762search0turn745762search2turn959356search1turn959356search2turn959356search9

Für deinen Use Case ist diese Kombination sogar ziemlich stark, weil du damit:
- modernes UI/UX im Frontend bauen kannst
- saubere REST-API in C# bekommst
- später gut containerisieren kannst
- das Ganze sauber Richtung Kubernetes und Terraform erweitern kannst

## Produktidee

Die Plattform soll zwei Hauptbereiche haben:

### 1. Shop-Bereich
Ein stilvoller Katalog-/Shop-Bereich mit:
- Startseite mit Hero-Sektion
- Produktkarten
- Produktdetailseiten
- Kategorien
- Suche und Filter
- optionale Verfügbarkeitsanzeige
- optionaler Warenkorb
- optionaler Checkout für spätere Erweiterung

### 2. Experience-Bereich
Ein Zusatzbereich für Store-Atmosphäre und Attraktionen:
- Chill-Bereich
- Couch-Area
- Gaming-Ecke mit Konsolen
- Community-/Event-Bereich
- besondere Geräte- oder Lounge-Areas
- Galerie / Mood Content
- Standort / Öffnungszeiten / Konzeptseite

## MVP Scope

Für die erste Version reicht folgender Scope:

### Frontend MVP
- Landing Page
- Shop Overview
- Product Detail Page
- Experience Overview
- Experience Detail Sections
- About / Location / Opening Hours
- responsive Navigation
- Admin Login Seite (optional zunächst Dummy)

### Backend MVP
- Produkt-CRUD
- Kategorien-CRUD
- Erlebnisbereiche-CRUD
- Medien-/Bildreferenzen
- einfache Suche/Filter
- Health Endpoint
- OpenAPI / Swagger

### Datenbank MVP
- Products
- Categories
- ProductImages
- ExperienceAreas
- ExperienceImages
- OpeningHours
- Users
- Roles

## Fachliche Module

### Catalog Module
Verantwortlich für:
- Produkte
- Kategorien
- Produktdetails
- Filter / Suche

### Experience Module
Verantwortlich für:
- Erlebnisbereiche
- Textblöcke
- Bilder / Galerien
- Reihenfolge / Darstellung

### Media Module
Verantwortlich für:
- Bildreferenzen
- Dateipfade / Objektstorage-Referenzen
- Alt-Texte

### Auth Module
Verantwortlich für:
- Admin Login
- Rollen
- geschützte Admin-Endpunkte

### Admin Module
Verantwortlich für:
- Pflege von Produkten
- Pflege von Inhalten
- Pflege von Erlebnisbereichen

## Geplante Seiten

- `/`
- `/shop`
- `/shop/:slug`
- `/experience`
- `/experience/:slug`
- `/about`
- `/location`
- `/contact`
- `/admin`

## Beispielhafte Datenbanktabellen

### products
- id
- slug
- title
- short_description
- long_description
- status
- price
- category_id
- created_at
- updated_at

### categories
- id
- name
- slug

### product_images
- id
- product_id
- image_url
- alt_text
- sort_order

### experience_areas
- id
- slug
- title
- description
- icon
- sort_order

### experience_images
- id
- experience_area_id
- image_url
- alt_text
- sort_order

### users
- id
- email
- password_hash
- role_id

### roles
- id
- name

## API-Ideen

### Public Endpoints
- `GET /api/health`
- `GET /api/products`
- `GET /api/products/{slug}`
- `GET /api/categories`
- `GET /api/experience-areas`
- `GET /api/experience-areas/{slug}`

### Admin Endpoints
- `POST /api/admin/products`
- `PUT /api/admin/products/{id}`
- `DELETE /api/admin/products/{id}`
- `POST /api/admin/experience-areas`
- `PUT /api/admin/experience-areas/{id}`
- `DELETE /api/admin/experience-areas/{id}`

ASP.NET Core unterstützt Minimal APIs sowie controller-basierte APIs. Für neue Projekte werden Minimal APIs von Microsoft als vereinfachter, performanter Ansatz empfohlen. OpenAPI-Dokumente können direkt aus Endpunkten generiert werden. citeturn745762search3turn745762search5turn745762search2

## Projektstruktur

```text
boutique-shop-platform/
├─ frontend/
│  ├─ src/
│  │  ├─ app/
│  │  ├─ components/
│  │  ├─ features/
│  │  │  ├─ catalog/
│  │  │  ├─ experience/
│  │  │  └─ shared/
│  │  ├─ pages/
│  │  ├─ hooks/
│  │  ├─ services/
│  │  └─ types/
│  ├─ public/
│  └─ package.json
│
├─ backend/
│  ├─ src/
│  │  ├─ Api/
│  │  ├─ Application/
│  │  ├─ Domain/
│  │  ├─ Infrastructure/
│  │  └─ Persistence/
│  ├─ tests/
│  └─ BoutiqueShop.sln
│
├─ deploy/
│  ├─ docker/
│  ├─ helm/
│  ├─ k8s/
│  └─ terraform/
│
└─ README.md
```

## Architektur

```text
React + TypeScript Frontend
        │
        ▼
ASP.NET Core Web API
        │
        ▼
PostgreSQL
        │
        ├─ Media Storage
        └─ optional Search / Auth / Cache
```

## Deployment-Zielbild

1. Frontend und Backend lokal entwickeln
2. PostgreSQL lokal per Docker starten
3. Beide Anwendungen containerisieren
4. Docker Images in Registry pushen
5. Kubernetes Deployments + Services anlegen
6. Helm Charts für Environments verwenden
7. Infrastruktur mit Terraform verwalten
8. optional GitOps mit Argo CD ergänzen

Terraform nutzt State, um reale Infrastruktur Objekten in der Konfiguration zuzuordnen. Backends definieren, wo dieser State gespeichert wird. Module helfen dabei, Infrastruktur wiederverwendbar zu strukturieren. 

## Containerisierung

### Frontend Container
- Build mit Node
- statische Auslieferung oder React-App-Container

### Backend Container
- Multi-Stage Dockerfile
- .NET Build + Publish
- schlankes Runtime-Image

### Datenbank
- PostgreSQL Container für lokale Entwicklung
- später Managed DB oder separater Betrieb

## Kubernetes Ziel

Später sollen mindestens diese Komponenten laufen:
- frontend deployment
- backend deployment
- postgres deployment oder managed service
- services
- ingress
- configmaps
- secrets
- optional HPA

## Roadmap

### Phase 1 – Planung
- Anforderungen finalisieren
- Branding / Stilrichtung definieren
- Entitäten und Tabellen modellieren
- API-Schnittstellen definieren

### Phase 2 – Frontend MVP
- React Setup
- Routing
- Layout
- Product Grid
- Product Detail
- Experience Pages

### Phase 3 – Backend MVP
- ASP.NET Core API anlegen
- EF Core integrieren
- PostgreSQL anbinden
- CRUD Endpunkte bauen
- Swagger aktivieren

### Phase 4 – Integration
- Frontend mit API verbinden
- Query Layer bauen
- Fehlerzustände und Loading States
- erste Admin-Funktionen

### Phase 5 – Containerisierung
- Dockerfiles schreiben
- docker-compose für lokal
- lokale End-to-End Tests

### Phase 6 – Kubernetes
- Deployments
- Services
- Ingress
- Secrets
- Helm Chart

### Phase 7 – Terraform
- Basis-Infrastruktur definieren
- State Backend festlegen
- K8s Ressourcen / Helm Releases integrieren

## Erste Entwicklungsreihenfolge

1. Datenmodell festlegen
2. Backend Grundprojekt erstellen
3. PostgreSQL + EF Core anbinden
4. Produkte und Erlebnisbereiche als CRUD
5. Frontend Grundlayout bauen
6. Shop- und Experience-Seiten anbinden
7. Bilder und Mock-Daten integrieren
8. Docker Setup
9. K8s Setup
10. Terraform Setup

## Spätere Erweiterungen

- echtes Admin Dashboard
- Auth mit Keycloak oder ASP.NET Identity
- Suche mit Meilisearch
- Warenkorb
- Checkout
- Eventkalender
- Reservierungssystem
- Mehrsprachigkeit
- Analytics
- Observability

## Warum dieser Stack sinnvoll ist

React + TypeScript passt sehr gut für ein modernes, komponentenbasiertes UI. React beschreibt TypeScript ausdrücklich als gängigen Weg, Typdefinitionen in React-Projekten zu nutzen. ASP.NET Core ist laut Microsoft für schnelle, sichere und plattformübergreifende Apps und Services gedacht. OpenAPI/Swagger wird in ASP.NET Core für API-Dokumentation direkt unterstützt. citeturn745762search0turn959356search0turn745762search2turn745762search6

## Nächster sinnvoller Schritt

Als nächstes sollte daraus direkt ein **Monorepo-Grundgerüst** entstehen mit:
- `frontend/` als React + TypeScript App
- `backend/` als ASP.NET Core Web API
- `deploy/` für Docker, Helm, Terraform
- erster PostgreSQL-Docker-Compose Datei

