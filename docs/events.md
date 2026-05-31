# HelixOps - Events

## Purpose

Defines all Domain Events currently recognized by HelixOps.

Events represent facts that already happened.

Events are immutable.

---

# Asset Management Events

## LocationCreated

A new Location has been created.

---

## LocationClosed

A Location has been closed.

---

## DeviceRegistered

A Device has been registered.

---

## DeviceRetired

A Device has been retired.

---

## AgentRegistered

A ManagementAgent has been registered.

---

## AgentRetired

A ManagementAgent has been retired.

---

## AgentVersionReported

A ManagementAgent reported its current version.

---

## AgentHeartbeatReceived

A heartbeat was received from a ManagementAgent.

---

# Monitoring Events

## AgentHealthCalculated

Health evaluation completed.

Possible results:

- Healthy
- Degraded
- Offline

---

## AgentRecovered

An unhealthy ManagementAgent returned to a healthy state.

---

# Automation Events

## RuleTriggered

An automation rule has been activated.

---

## AutomationExecuted

An automation workflow has completed.

---

# Alerting Events

## AlertGenerated

A new operational alert was created.

---

## AlertAcknowledged

An alert was acknowledged.

---

## AlertResolved

An alert was resolved.

---

# Deployment Management Events

## AgentUpdateStarted

A ManagementAgent update has started.

---

## AgentUpdateSucceeded

A ManagementAgent update completed successfully.

---

## AgentUpdateFailed

A ManagementAgent update failed.

---

## RollbackStarted

Rollback execution started.

---

## RollbackSucceeded

Rollback execution completed successfully.

---

# Event Naming Rules

Events must:

- Be written in past tense
- Represent facts
- Be immutable
- Avoid technical implementation details

---

# Correlation

Every event must contain:

CorrelationId

CausationId

OccurredAt

EventVersion

AggregateId

---

# Example Event

```json
{
  "eventId": "evt-001",
  "eventType": "AgentHeartbeatReceived",
  "aggregateId": "agent-123",
  "correlationId": "corr-789",
  "causationId": "cmd-456",
  "occurredAt": "2026-05-30T15:30:00Z",
  "version": 1
}
```
