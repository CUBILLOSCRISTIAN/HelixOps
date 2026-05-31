# HelixOps - Commands

## Purpose

This document defines the commands used across the HelixOps platform.

Commands represent intentions to perform actions within the system.

Unlike events, commands do not describe facts that already occurred. They express requests for behavior that may succeed or fail.

---

# Command Principles

## Commands Express Intent

Commands request that something should happen.

Examples:

- RegisterDevice
- SendHeartbeat
- EvaluateDeviceHealth
- GenerateAlert

---

## Commands Target One Capability

A command must have a single clear responsibility.

Bad:

```text
RegisterDeviceAndAssignDeployment
```

Good:

```text
RegisterDevice
AssignDeployment
```

---

## Commands Are Imperative

Commands use verbs.

Examples:

```text
RegisterDevice
ActivateLocation
GenerateAlert
StartDeployment
```

---

## Commands May Fail

A command can be rejected.

Examples:

- RegisterDevice rejected because Location does not exist.
- StartDeployment rejected because Device is Offline.

---

# Command Categories

HelixOps classifies commands into:

```text
Asset Commands
Monitoring Commands
Automation Commands
Deployment Commands
Alert Commands
Identity Commands
System Commands
```

---

# Asset Commands

Commands related to devices and locations.

## Device Commands

```text
RegisterDevice
ActivateDevice
DeactivateDevice
MarkDeviceOffline
DecommissionDevice

SendHeartbeat

ReportDeviceVersion
```

---

## Location Commands

```text
CreateLocation
ActivateLocation
CloseLocation

CalculateLocationHealth
```

---

# Monitoring Commands

Commands related to telemetry and health evaluation.

```text
RecordMetric

EvaluateHealth

CalculateDeviceHealth

CalculateLocationHealth

CalculateServiceHealth
```

---

# Automation Commands

Commands executed by the Automation & Rules Engine.

```text
EvaluateRule

StartAutomation

CompleteAutomation

FailAutomation
```

---

## Automated Actions

```text
RequestAlert

RequestDeployment

RequestRollback

RequestDeviceMaintenance
```

---

# Deployment Commands

Commands related to software distribution.

```text
StartDeployment

AssignDeployment

CompleteDeployment

FailDeployment

StartRollback

CompleteRollback
```

---

# Alert Commands

Commands related to incident management.

```text
GenerateAlert

AcknowledgeAlert

ResolveAlert

SendNotification
```

---

# Identity Commands

Commands related to access management.

```text
CreateUser

ActivateUser

AssignRole

GrantPermission
```

---

# System Commands

Internal platform commands.

```text
StoreEvent

PublishEvent

ReplayEvent

CreateSubscription
```

---

# Command Ownership

| Command Category    | Owning Context            |
| ------------------- | ------------------------- |
| Asset Commands      | Asset Management          |
| Monitoring Commands | Monitoring                |
| Automation Commands | Automation & Rules Engine |
| Deployment Commands | Deployment Management     |
| Alert Commands      | Alerting                  |
| Identity Commands   | Identity & Access         |
| System Commands     | Event Platform            |

---

# Command → Event Mapping

## Device Registration

```text
RegisterDevice
↓
DeviceRegistered
```

---

## Heartbeat Processing

```text
SendHeartbeat
↓
HeartbeatReceived
```

---

## Device Health Evaluation

```text
CalculateDeviceHealth
↓
DeviceHealthCalculated
```

---

## Rule Evaluation

```text
EvaluateRule
↓
RuleTriggered
```

---

## Alert Generation

```text
RequestAlert
↓
AlertRequested

GenerateAlert
↓
AlertGenerated
```

---

## Deployment Flow

```text
StartDeployment
↓
DeploymentStarted

CompleteDeployment
↓
DeploymentSucceeded

FailDeployment
↓
DeploymentFailed
```

---

## Rollback Flow

```text
StartRollback
↓
RollbackStarted

CompleteRollback
↓
RollbackCompleted
```

---

# Core Operational Flow

The primary HelixOps workflow.

```text
SendHeartbeat
↓
HeartbeatReceived

CalculateDeviceHealth
↓
DeviceHealthCalculated

EvaluateRule
↓
RuleTriggered

RequestAlert
↓
AlertRequested

GenerateAlert
↓
AlertGenerated
```

---

# Command Design Guidelines

## Commands Should Be Explicit

Bad:

```text
ProcessDevice
```

Good:

```text
RegisterDevice
MarkDeviceOffline
SendHeartbeat
```

---

## Commands Should Not Leak Infrastructure

Bad:

```text
PublishRabbitMessage
```

Good:

```text
PublishEvent
```

---

## Commands Should Reflect Domain Language

Bad:

```text
InsertDeviceRecord
```

Good:

```text
RegisterDevice
```

---

# Future Commands

Reserved for future platform capabilities.

```text
PredictFailure

RecommendDeployment

AutoScaleWorkers

GenerateOperationalInsight
```
