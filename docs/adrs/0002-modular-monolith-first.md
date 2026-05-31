# ADR-0002: Adopt Modular Monolith as Initial Architecture

## Status

Accepted

---

## Date

2026-05-30

---

## Context

HelixOps aims to provide operational monitoring, automation, deployment management and event processing for distributed systems.

The platform contains multiple bounded contexts:

- Asset Management
- Event Platform
- Monitoring
- Automation & Rules Engine
- Alerting
- Deployment Management
- Identity & Access

A key architectural decision is determining whether these contexts should initially be deployed as independent microservices or as a single deployable application.

---

## Decision

HelixOps will start as a Modular Monolith.

Each bounded context will maintain:

- Clear ownership
- Internal boundaries
- Independent domain logic
- Explicit contracts

However, all contexts will initially be deployed as a single application.

---

## Consequences

### Positive

- Faster development velocity.
- Simpler deployment pipeline.
- Easier debugging.
- Lower infrastructure cost.
- Reduced operational overhead.
- Easier local development.

---

### Positive for Learning

Allows focus on:

- Event-driven architecture
- Automation workflows
- Observability
- DevOps practices

without introducing premature distributed system complexity.

---

### Negative

- Single deployment unit.
- Shared runtime process.
- Reduced fault isolation.

---

## Alternatives Considered

### Microservices First

Rejected.

Reasons:

- Premature complexity.
- Higher operational cost.
- Additional networking concerns.
- Slower iteration speed.

---

### Layered Monolith

Rejected.

Reasons:

- Weak domain boundaries.
- Increased coupling.
- Difficult future extraction.

---

## Evolution Strategy

Future versions may extract:

1. Automation Worker
2. Monitoring Worker
3. Deployment Worker

without changing the domain model.

---

## Related Documents

- ADR-0001
- modules.md
- architecture.md
