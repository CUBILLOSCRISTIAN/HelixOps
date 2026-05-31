# HelixOps - Commands

## Purpose

Defines all Commands accepted by HelixOps.

Commands represent requests to perform an action.

Commands are mutable requests.

Commands may succeed or fail.

---

# Asset Management Commands

## CreateLocation

Create a new Location.

---

## CloseLocation

Close an existing Location.

---

## RegisterDevice

Register a Device.

---

## RetireDevice

Retire a Device.

---

## RegisterAgent

Register a ManagementAgent.

---

## RetireAgent

Retire a ManagementAgent.

---

## ReportAgentVersion

Report the currently installed version.

---

## SendAgentHeartbeat

Send operational heartbeat information.

---

# Monitoring Commands

## EvaluateAgentHealth

Calculate ManagementAgent health.

Input:

- LastHeartbeatAt
- HeartbeatInterval
- ConnectivityData

Output:

- Healthy
- Degraded
- Offline

---

# Automation Commands

## EvaluateRule

Evaluate an automation rule.

---

## ExecuteAutomation

Execute an automation workflow.

---

# Alerting Commands

## GenerateAlert

Generate a new operational alert.

---

## AcknowledgeAlert

Acknowledge an alert.

---

## ResolveAlert

Resolve an alert.

---

# Deployment Management Commands

## AssignDeployment

Assign a deployment to a ManagementAgent.

---

## StartAgentUpdate

Start software update execution.

---

## CompleteAgentUpdate

Complete an update successfully.

---

## FailAgentUpdate

Register deployment failure.

---

## ExecuteRollback

Execute rollback procedure.

---

# Command Naming Rules

Commands must:

- Start with a verb
- Express intent
- Be written in imperative form

Examples:

Good:

CreateLocation

RegisterAgent

SendAgentHeartbeat

StartAgentUpdate

Bad:

LocationCreated

AgentHeartbeatReceived

AgentUpdated

---

# Command Metadata

Every command should contain:

CommandId

CorrelationId

RequestedBy

RequestedAt

TargetAggregateId
