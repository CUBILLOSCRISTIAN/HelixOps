# HelixOps - Events

## Purpose

This document defines the event taxonomy, naming conventions, metadata standards and domain events used across the HelixOps platform.

HelixOps is an Event-Driven Operations Platform. Events are the primary communication mechanism between bounded contexts and represent facts that have already occurred within the system.

---

# Event Principles

## Events Represent Facts

Events describe something that already happened.

Examples:

- DeviceRegistered
- HeartbeatReceived
- DeploymentFailed
- AlertGenerated

Non-examples:

- RegisterDevice
- GenerateAlert
- DeployVersion

---

## Events Are Immutable

Once published, an event cannot be modified.

Any change must generate a new event.

---

## Events Use Domain Language

Events must be named using the ubiquitous language of HelixOps.

Technical implementation details must not appear in event names.

Bad:

- DatabaseRecordInserted
- RabbitMessagePublished

Good:

- DeviceRegistered
- EventPublished

---

## Events Are Versioned

Every event must include a version identifier.

---

# Event Categories

HelixOps classifies events into seven major categories.

```text
Asset Events
Monitoring Events
Automation Events
Deployment Events
Alert Events
Security Events
System Events
```

---

# Asset Events

## Device Lifecycle

### DeviceRegistered

A device has been registered within HelixOps.

### DeviceActivated

A device became operational.

### DeviceOnline

A device is currently available.

### DeviceOffline

A device is currently unavailable.

### DeviceDecommissioned

A device was permanently removed from operations.

---

## Device Connectivity

### HeartbeatReceived

A heartbeat was received from a device.

---

## Device Versioning

### DeviceVersionReported

A device reported its current software version.

### DeviceVersionOutdated

A device version is below the required baseline.

---

## Location Lifecycle

### LocationCreated

A new location was created.

### LocationActivated

A location became operational.

### LocationDegraded

A location is operating with reduced capacity.

### LocationOffline

A location is unavailable.

### LocationRecovered

A degraded or offline location returned to normal operation.

### LocationClosed

A location was permanently closed.

---

# Monitoring Events

Monitoring events are generated after evaluating operational telemetry.

---

### MetricRecorded

A metric was successfully recorded.

### HealthEvaluated

A health evaluation process completed.

### DeviceHealthCalculated

A device health score was calculated.

### LocationHealthCalculated

A location health score was calculated.

### ServiceHealthCalculated

A service health score was calculated.

### MetricThresholdExceeded

A metric exceeded a configured threshold.

### QueueDepthExceeded

A queue exceeded acceptable limits.

---

# Automation Events

Automation events represent platform decisions and automated responses.

---

### RuleTriggered

A rule condition was satisfied.

### AutomationStarted

An automation workflow started.

### AutomationCompleted

An automation workflow completed successfully.

### AutomationFailed

An automation workflow failed.

---

## Automation Requests

### AlertRequested

An automation requested alert generation.

### DeploymentRequested

An automation requested a deployment.

### RollbackRequested

An automation requested a rollback.

### DeviceMaintenanceRequested

An automation requested device maintenance.

---

# Deployment Events

Deployment events describe software rollout activities.

---

### DeploymentStarted

A deployment execution started.

### DeploymentAssigned

A deployment was assigned to a target.

### DeploymentSucceeded

A deployment completed successfully.

### DeploymentFailed

A deployment failed.

### RollbackStarted

A rollback execution started.

### RollbackCompleted

A rollback completed successfully.

---

# Alert Events

Alert events represent incident communication activities.

---

### AlertGenerated

An alert was generated.

### AlertAcknowledged

An operator acknowledged an alert.

### AlertResolved

An alert was resolved.

### NotificationSent

A notification was delivered.

---

# Security Events

Security-related operational events.

---

### UserCreated

A user account was created.

### UserActivated

A user account became active.

### RoleAssigned

A role was assigned to a user.

### PermissionGranted

A permission was granted.

### AuthenticationSucceeded

An authentication attempt succeeded.

### AuthenticationFailed

An authentication attempt failed.

---

# System Events

Platform internal operational events.

---

### EventStored

An event was persisted.

### EventPublished

An event was published.

### EventReplayed

An event replay operation occurred.

### EventSubscriptionCreated

A subscription was created.

---

# Event Naming Convention

All event names must follow:

```text
<Entity><PastTenseAction>
```

Examples:

```text
DeviceRegistered
HeartbeatReceived
DeploymentFailed
AlertGenerated
RuleTriggered
```

---

# Standard Event Metadata

Every event must contain the following metadata.

```text
EventId
EventType
EventVersion
OccurredAt
Source
CorrelationId
CausationId
```

---

# Metadata Definitions

## EventId

Globally unique event identifier.

---

## EventType

Canonical event name.

Example:

```text
HeartbeatReceived
```

---

## EventVersion

Version of the event schema.

Example:

```text
1.0
```

---

## OccurredAt

Timestamp when the event occurred.

---

## Source

Originating bounded context.

Examples:

```text
AssetManagement
Monitoring
Automation
DeploymentManagement
```

---

## CorrelationId

Identifier used to trace related events across a workflow.

Example:

```text
HeartbeatReceived
↓
DeviceHealthCalculated
↓
RuleTriggered
↓
AlertGenerated
```

All events share the same CorrelationId.

---

## CausationId

Identifies which event caused the current event.

Example:

```text
HeartbeatReceived
```

causes

```text
DeviceHealthCalculated
```

The second event stores the identifier of the first as its CausationId.

---

# MVP Event Flow

```text
HeartbeatReceived
↓
DeviceHealthCalculated
↓
RuleTriggered
↓
AlertRequested
↓
AlertGenerated
```

This flow represents the foundational operational cycle of HelixOps.

Observe
↓
Understand
↓
Decide
↓
Act
↓
Audit

---

# Future Event Categories

Reserved for future platform capabilities.

- Integration Events
- Billing Events
- AI Operations Events
- Predictive Maintenance Events
- Marketplace Events
