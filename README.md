# Boutique Shop Platform Prototype

Protoype FE: https://app.kevs-ops.dev

Prototype BE: https://api.kevs-ops.dev/swagger

Ein moderner Webshop-Prototyp mit **React + TypeScript** im Frontend und **ASP.NET Core (C#)** im Backend.
Das Projekt stellt einen hochwertigen Boutique-/Lifestyle-Shop dar und integriert zusätzlich Erlebnisbereiche wie Lounge, Gaming-Corner oder besondere In-Store-Areas.

---

## 🚀 Ziel

Dieses Projekt ist ein **produktnaher Fullstack-Prototyp** für eine moderne Shop- und Experience-Plattform.

Der Fokus liegt auf:

* hochwertiger Produktpräsentation
* neutraler, stilvoller Darstellung von katalogartigen Artikeln
* zusätzlichem Erlebnisbereich für Store-Highlights
* sauberer API-Architektur
* containerisiertem Deployment
* Betrieb auf Kubernetes
* Infrastrukturverwaltung mit Terraform

---

## 🧠 Architektur-Vision

```text
Internet / Tunnel
        ↓
     Ingress
        ↓
   Frontend (React)
        ↓
   Backend (ASP.NET)
        ↓
    PostgreSQL
```

---

## 🖥️ Infrastruktur Setup (Stand: aktueller Fortschritt)

### ✅ Ubuntu Server (Self-Hosted)

* Installation von **Ubuntu Server 24.04 LTS** auf einem dedizierten Host
* System läuft stabil als **24/7 Homeserver**
* Zugriff erfolgt ausschließlich per SSH

Beispiel:

```bash
ssh user@server-ip
```

---

### 🔐 Remote Zugriff & Netzwerk (Tailscale)

Für sicheren Zugriff wurde ein privates Overlay-Netzwerk mit
Tailscale eingerichtet.

**Setup:**

* Server und Main-PC sind im selben privaten Netzwerk
* Verbindung über **Tailscale IP (100.x.x.x Bereich)**
* Kein Port Forwarding notwendig
* End-to-End verschlüsselte Verbindung

Vorteile:

* Zugriff von überall
* Kein öffentlicher SSH-Port nötig
* Einfaches internes Routing zwischen Geräten

---

### 🔧 System Status

* SSH Zugriff erfolgreich eingerichtet
* Server online und erreichbar
* Netzwerkverbindung stabil
* Grundlage für CI/CD & Deployment geschaffen

---

## 🧰 Tech Stack

### Frontend

* React
* TypeScript
* Vite
* React Router
* Tailwind CSS
* TanStack Query
* Zustand / Context API

### Backend

* ASP.NET Core Web API
* C#
* Minimal APIs oder Controller
* Entity Framework Core
* PostgreSQL
* Swagger / OpenAPI

### Infrastruktur

* Docker
* Kubernetes (k3s geplant)
* Helm
* Terraform
* GitHub Actions
* optional Argo CD

---

## ⚙️ Roadmap

### Phase 1: Docker First

* Ubuntu Server vorbereiten ✔
* Docker Engine + Compose installieren
* Frontend mit Dockerfile bauen
* Container lokal deployen
* Anwendung im Browser erreichbar machen

---

### Phase 2: CI/CD

* GitHub Actions einrichten
* Self-hosted Runner auf Ubuntu Server
* Automatisches Deployment:

  * Pull vom Repository
  * Build Docker Image
  * Stop alter Container
  * Start neuer Container

---

### Phase 3: Kubernetes (k3s)

* k3s Cluster installieren
* Traefik als Ingress nutzen
* Deployment + Service erstellen
* Frontend über Ingress erreichbar machen

---

## 🔮 Nächste Schritte

* Docker Setup abschließen
* Frontend containerisieren
* Erste Deployment Pipeline erstellen
* Öffentlichen Zugriff vorbereiten (Domain / Tunnel)
* Migration auf Kubernetes

---

## 💡 Ziel dieses Projekts

Dieses Projekt dient als:

* **Portfolio-Projekt für DevOps / Cloud / Fullstack Rollen**
* Nachweis für:

  * Kubernetes Know-how
  * Containerisierung
  * CI/CD Pipelines
  * Infrastruktur-Design

---

## 🧑‍💻 Autor

Kevin Hübner
Informatik (B.Sc.) – Schwerpunkt Cloud / DevOps / Fullstack
