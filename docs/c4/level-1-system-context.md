# C4 Level 1 - System Context

## Purpose

Describe how HelixOps interacts with users, devices and external systems.

---

# System Context Diagram

```mermaid
flowchart LR

Operator[Platform Operator]

StoreManager[Store Manager]

POS[POS Terminal]

Kiosk[Kiosk]

Printer[Receipt Printer]

Scanner[Barcode Scanner]

HelixOps[HelixOps Platform]

Operator --> HelixOps

StoreManager --> HelixOps

POS --> HelixOps

Kiosk --> HelixOps

Printer --> HelixOps

Scanner --> HelixOps
```

---

# Actors

## Platform Operator

Responsible for monitoring and operating the platform.

---

## Store Manager

Responsible for supervising retail locations.

---

# External Devices

## POS Terminal

Produces operational events.

---

## Kiosk

Produces operational events.

---

## Receipt Printer

Reports status and health.

---

## Barcode Scanner

Reports connectivity and operational telemetry.

---

# System Responsibilities

HelixOps provides:

- Asset visibility
- Monitoring
- Automation
- Alerting
- Deployment management
- Operational observability
