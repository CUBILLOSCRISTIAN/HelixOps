# HelixOps - Policies

## Purpose

This document defines the policies that coordinate behavior across bounded contexts in HelixOps.

Policies react to events and issue commands that continue operational workflows.

Policies do not own business data.

Policies do not persist state.

Policies coordinate actions.

---

# Policy Principles

## Event Driven

Policies are always triggered by events.

---

## Stateless

Policies should not maintain internal state.

They react to events and issue commands.

---

## Single Responsibility

Each policy should coordinate one operational concern.

---

## Domain Oriented

Policies must reflect business behavior rather than technical implementation.

---

# Asset Policies

## Evaluate Device Health Policy

### Trigger

```text
HeartbeatReceived
```

### Action

```text
CalculateDeviceHealth
```

### Flow

```text
HeartbeatReceived
↓
EvaluateDeviceHealthPolicy
↓
CalculateDeviceHealth
```

---

## Evaluate Location Health Policy

### Trigger

```text
DeviceOnline
DeviceOffline
```

### Action

```text
CalculateLocationHealth
```

### Flow

```text
DeviceOffline
↓
EvaluateLocationHealthPolicy
↓
CalculateLocationHealth
```

---

# Monitoring Policies

## Device Offline Detection Policy

### Trigger

```text
DeviceHealthCalculated
```

### Condition

```text
HealthStatus = Critical
```

### Action

```text
MarkDeviceOffline
```

### Flow

```text
DeviceHealthCalculated
↓
DeviceOfflineDetectionPolicy
↓
MarkDeviceOffline
```

---

## Threshold Monitoring Policy

### Trigger

```text
MetricRecorded
```

### Condition

```text
Metric exceeds threshold
```

### Action

```text
EvaluateRule
```

---

# Automation Policies

## Alert Generation Policy

### Trigger

```text
RuleTriggered
```

### Action

```text
RequestAlert
```

### Flow

```text
RuleTriggered
↓
AlertGenerationPolicy
↓
RequestAlert
```

---

## Deployment Recovery Policy

### Trigger

```text
DeploymentFailed
```

### Action

```text
RequestRollback
```

### Flow

```text
DeploymentFailed
↓
DeploymentRecoveryPolicy
↓
RequestRollback
```

---

## Version Drift Policy

### Trigger

```text
DeviceVersionOutdated
```

### Action

```text
RequestDeployment
```

### Flow

```text
DeviceVersionOutdated
↓
VersionDriftPolicy
↓
RequestDeployment
```

---

# Deployment Policies

## Deployment Completion Policy

### Trigger

```text
DeploymentSucceeded
DeploymentFailed
```

### Action

```text
EvaluateHealth
```

### Flow

```text
DeploymentSucceeded
↓
DeploymentCompletionPolicy
↓
EvaluateHealth
```

---

# Alerting Policies

## Notification Policy

### Trigger

```text
AlertGenerated
```

### Action

```text
SendNotification
```

### Flow

```text
AlertGenerated
↓
NotificationPolicy
↓
SendNotification
```

---

# Policy Ownership

| Policy                       | Owning Context            |
| ---------------------------- | ------------------------- |
| EvaluateDeviceHealthPolicy   | Monitoring                |
| EvaluateLocationHealthPolicy | Monitoring                |
| DeviceOfflineDetectionPolicy | Monitoring                |
| ThresholdMonitoringPolicy    | Monitoring                |
| AlertGenerationPolicy        | Automation & Rules Engine |
| DeploymentRecoveryPolicy     | Automation & Rules Engine |
| VersionDriftPolicy           | Automation & Rules Engine |
| DeploymentCompletionPolicy   | Deployment Management     |
| NotificationPolicy           | Alerting                  |

---

# Core Operational Chain

The primary operational chain of HelixOps.

```text
SendHeartbeat
↓
HeartbeatReceived

EvaluateDeviceHealthPolicy
↓
CalculateDeviceHealth

DeviceHealthCalculated

DeviceOfflineDetectionPolicy
↓
EvaluateRule

RuleTriggered

AlertGenerationPolicy
↓
RequestAlert

AlertRequested

GenerateAlert
↓
AlertGenerated

NotificationPolicy
↓
SendNotification

NotificationSent
```

---

# Policy Design Guidelines

## Policies React To Events

Policies must never be triggered directly by users.

---

## Policies Emit Commands

Policies should not directly modify state.

---

## Policies Should Remain Stateless

State belongs to aggregates and bounded contexts.

---

## Policies Should Be Observable

Every policy execution should generate telemetry.

---

# Future Policies

Reserved for future platform evolution.

```text
PredictiveMaintenancePolicy

AutoScalingPolicy

IncidentEscalationPolicy

SelfHealingPolicy

CapacityOptimizationPolicy
```
