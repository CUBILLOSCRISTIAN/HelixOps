# Agent Domain Model

## Purpose

Represents a managed software component running on a Device.

Agents are the primary operational units monitored and controlled by HelixOps.

Examples:

- Helix Agent
- POS Application
- Inventory Service
- Payment Service
- Self Checkout Application

---

# Aggregate Root

Agent

---

# Identity

AgentId

---

# Relationships

Agent
↓
Device

Device
↓
Location

---

# Attributes

AgentId

DeviceId

Name

Type

CurrentVersion

DesiredVersion

Status

LastHeartbeatAt

InstalledAt

UpdatedAt

---

# Agent Types

ManagementAgent

POSApplication

InventoryService

PaymentService

SelfCheckoutApplication

Custom

---

# Status

Provisioning

Running

Stopped

Degraded

Offline

Retired

---

# Invariants

An Agent must belong to a Device.

An Agent must have a Name.

An Agent must have a CurrentVersion.

A Retired Agent cannot receive deployments.

---

# Commands

RegisterAgent

SendAgentHeartbeat

ReportAgentVersion

StartAgent

StopAgent

MarkAgentOffline

RequestDeployment

RequestRollback

---

# Events

AgentRegistered

AgentHeartbeatReceived

AgentVersionReported

AgentStarted

AgentStopped

AgentOffline

AgentDeploymentRequested

AgentRollbackRequested

---

# Ownership

Owned by:

Asset Management

Consumed by:

Monitoring
Automation
Deployment Management

---

# Operational Importance

Agent is considered a primary operational entity.

Most automation, deployment and monitoring workflows are expected to target Agents rather than Devices.
