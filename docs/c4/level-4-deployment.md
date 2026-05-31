# C4 Level 4 - Deployment Diagram

## Purpose

Describe runtime deployment environments.

---

# Local Environment

```mermaid
flowchart TB

Developer

DockerHost

WebContainer

ApiContainer

RabbitMQContainer

PostgresContainer

Developer --> DockerHost

DockerHost --> WebContainer

DockerHost --> ApiContainer

DockerHost --> RabbitMQContainer

DockerHost --> PostgresContainer
```

---

# CI Environment

```mermaid
flowchart TB

GitHub

GitHubActions

Build

Tests

DockerImage

GitHub --> GitHubActions

GitHubActions --> Build

GitHubActions --> Tests

GitHubActions --> DockerImage
```

---

# Future Kubernetes Environment

```mermaid
flowchart TB

Ingress

WebPod

ApiPod

RabbitMQPod

PostgresPod

Ingress --> WebPod

WebPod --> ApiPod

ApiPod --> RabbitMQPod

ApiPod --> PostgresPod
```

---

# Future AWS Simulation

Using Floci.

Services:

- SNS
- SQS
- S3

---

# Future Production Environment

Target:

AWS

Potential Services:

- ECS
- EKS
- RDS
- SNS
- SQS
- CloudWatch
