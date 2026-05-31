# ADR-0004: Use RabbitMQ as Initial Event Broker

## Status

Accepted

---

## Date

2026-05-30

---

## Context

HelixOps requires asynchronous event processing to support:

- Monitoring
- Automation
- Alerting
- Deployment workflows

The project also aims to provide practical DevOps experience while remaining manageable for a single developer.

Potential technologies considered:

- In-memory event bus
- RabbitMQ
- Apache Kafka
- AWS SNS/SQS
- Floci SNS/SQS simulation

---

## Decision

RabbitMQ will be used as the initial event broker for the MVP.

RabbitMQ provides a balance between:

- Simplicity
- Operational relevance
- Local development experience
- DevOps learning opportunities

---

## Consequences

### Positive

- Easy local execution with Docker.
- Supports queues and exchanges.
- Supports routing patterns.
- Supports retries.
- Supports dead-letter queues.
- Strong ecosystem support.

---

### Positive for Learning

Provides experience with:

- Message brokers
- Queue management
- Consumer patterns
- Retry strategies
- Dead-letter handling
- Event observability

---

### Negative

- Not fully representative of cloud-native messaging services.
- Additional infrastructure component.
- Operational maintenance overhead.

---

## Alternatives Considered

### In-Memory Event Bus

Rejected.

Reason:

Insufficient DevOps learning value.

---

### Apache Kafka

Rejected for MVP.

Reason:

Higher complexity than required.

---

### SNS/SQS via Floci

Deferred.

Reason:

Will be introduced during cloud simulation phases.

---

## Future Evolution

Potential migration path:

RabbitMQ
↓
Floci SNS/SQS
↓
AWS SNS/SQS

without changing domain events.

---

## Related Documents

- ADR-0001
- architecture.md
- events.md
