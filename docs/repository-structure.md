# HelixOps - Repository Structure

## Purpose

Defines the repository layout for HelixOps.

The structure must reinforce domain boundaries and support future extraction into distributed services.

---

# Repository Layout

```text
helixops/

├── docs/
│
├── src/
│
├── tests/
│
├── infrastructure/
│
├── deployments/
│
├── scripts/
│
└── .github/
```

---

# Source Code

```text
src/

├── Api/
│
├── BuildingBlocks/
│
├── Modules/
│
└── Workers/
```

---

# API

```text
src/Api
```

Responsibilities:

- HTTP Endpoints
- Authentication
- OpenAPI
- Request orchestration

---

# Building Blocks

```text
src/BuildingBlocks
```

Shared abstractions.

Examples:

```text
EventBus
DomainEvents
ResultPattern
Messaging
Observability
```

No business logic allowed.

---

# Modules

```text
src/Modules
```

Contains bounded contexts.

---

## Asset Management

```text
src/Modules/AssetManagement
```

---

## Event Platform

```text
src/Modules/EventPlatform
```

---

## Monitoring

```text
src/Modules/Monitoring
```

---

## Automation

```text
src/Modules/Automation
```

---

## Alerting

```text
src/Modules/Alerting
```

---

## Deployment Management

```text
src/Modules/DeploymentManagement
```

---

## Identity & Access

```text
src/Modules/IdentityAccess
```

---

# Workers

```text
src/Workers
```

Future extraction candidates.

Examples:

```text
AutomationWorker
MonitoringWorker
DeploymentWorker
```

---

# Tests

```text
tests/
```

---

## Unit Tests

```text
tests/UnitTests
```

---

## Integration Tests

```text
tests/IntegrationTests
```

Uses:

- PostgreSQL
- RabbitMQ
- Testcontainers

---

# Infrastructure

```text
infrastructure/
```

Contains:

```text
docker/
terraform/
floci/
```

---

# Deployments

```text
deployments/
```

Contains:

```text
local/
staging/
production/
```

---

# Scripts

```text
scripts/
```

Examples:

```text
start-local.sh
seed-data.sh
reset-environment.sh
```

---

# GitHub

```text
.github/
```

Contains:

```text
workflows/
```

Examples:

```text
build.yml
test.yml
release.yml
```

---

# Architectural Rule

Modules communicate through:

Commands
Events
Policies

Never through database access.

---

# Future Evolution

Potential extraction path:

```
Modules
↓
Workers
↓
Independent Services

```

without changing domain contracts.
