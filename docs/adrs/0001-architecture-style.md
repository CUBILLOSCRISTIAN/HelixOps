# ADR-0001: Adopt Event-Driven Architecture

## Status

Accepted

---

## Date

2026-05-30

---

## Context

HelixOps is being designed as a platform for operating distributed systems.

The platform must support:

- Distributed assets
- Operational monitoring
- Automated remediation
- Deployment orchestration
- Event traceability
- Future cloud-native evolution

Traditional request-response architectures create tight coupling between domains and make operational workflows difficult to observe.

The platform requires a model capable of representing operational facts and enabling asynchronous processing.

---

## Decision

HelixOps will adopt an Event-Driven Architecture (EDA).

All significant operational activities must generate domain events.

Bounded contexts should communicate through events whenever possible.

Events become the primary mechanism for:

- Communication
- Observability
- Automation
- Auditability

---

## Consequences

### Positive

#### Loose Coupling

Bounded contexts can evolve independently.

---

#### Observability

Operational workflows can be reconstructed through event streams.

---

#### Auditability

Historical actions become traceable.

---

#### Automation

Rules and policies can react to events without direct dependencies.

---

#### Cloud Readiness

The architecture naturally supports message brokers and cloud event services.

---

### Negative

#### Increased Complexity

Event-driven systems are harder to understand than synchronous request-response systems.

---

#### Eventual Consistency

Some operations will not complete immediately.

---

#### Debugging Complexity

Troubleshooting requires tracing multiple events across workflows.

---

## Alternatives Considered

### Layered Monolith

Pros:

- Simpler implementation.
- Easier debugging.

Cons:

- Strong coupling between modules.
- Poor support for automation workflows.
- Limited scalability.

Rejected.

---

### Microservices First

Pros:

- Strong isolation.
- Independent deployments.

Cons:

- High operational complexity.
- Premature distribution.
- Slower development velocity.

Rejected for MVP.

---

### Event-Driven Modular Monolith

Pros:

- Preserves event-driven behavior.
- Maintains development simplicity.
- Enables future extraction of services.

Cons:

- Requires discipline around module boundaries.

Accepted.

---

## Architectural Impact

This decision affects:

- Domain Modeling
- Event Design
- Command Design
- Policy Design
- Deployment Strategy
- Observability Strategy

---

## Related Documents

- vision.md
- modules.md
- events.md
- commands.md
- policies.md
