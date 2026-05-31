# HelixOps - Technology Stack

## Purpose

This document defines the approved technologies for the HelixOps platform.

Technology choices must support:

- Event-driven architecture
- DevOps learning objectives
- Cloud-native evolution
- Operational observability
- Maintainability

---

# Backend

## Platform

.NET 10

Reason:

- Strong ecosystem
- Long-term support
- Excellent performance
- Native OpenTelemetry support
- Enterprise adoption

---

## API Framework

ASP.NET Core

Reason:

- Mature ecosystem
- Minimal APIs support
- OpenAPI integration
- Authentication support

---

# Frontend

## Initial Phase

Swagger UI

Reason:

- Fast validation
- No frontend overhead
- Focus on domain and DevOps

---

## Future Phase

Next.js

Reason:

- Modern React ecosystem
- SSR support
- Dashboard-friendly

---

# Database

## PostgreSQL

Reason:

- Open source
- Reliable
- Strong ecosystem
- JSON support
- Production proven

---

# Event Broker

## RabbitMQ

Reason:

- Operational relevance
- Docker friendly
- Excellent learning platform
- Supports queues, exchanges and routing

---

# Observability

## OpenTelemetry

Purpose:

- Traces
- Metrics
- Logs correlation

---

## Prometheus

Purpose:

- Metrics collection

---

## Grafana

Purpose:

- Dashboards
- Visualization

---

## Loki

Purpose:

- Log aggregation

---

## Tempo

Purpose:

- Distributed tracing

---

# Containerization

## Docker

Purpose:

- Local development
- Consistent environments

---

## Docker Compose

Purpose:

- Multi-container orchestration

---

# CI/CD

## GitHub Actions

Purpose:

- Automated testing
- Build pipelines
- Deployment workflows

---

# Cloud Simulation

## Floci

Purpose:

- Simulate AWS services locally

Planned Services:

- SQS
- SNS
- S3

---

# Infrastructure as Code

## Terraform

Future Phase

Purpose:

- Environment provisioning
- Infrastructure reproducibility

---

# Testing

## Unit Testing

xUnit

---

## Integration Testing

Testcontainers

Reason:

- Real RabbitMQ
- Real PostgreSQL
- Realistic testing

---

# Source Control

Git

GitHub

---

# Security

JWT

RBAC

Future:

OAuth2
OIDC

---

# Architecture Rules

Approved communication:

API → Commands

Commands → Events

Events → Policies

Policies → Commands

---

Forbidden:

Context → Context direct database access

Shared mutable state

Synchronous domain coupling
