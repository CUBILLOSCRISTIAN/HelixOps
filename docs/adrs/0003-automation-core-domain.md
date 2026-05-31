# ADR-0003: Treat Automation as a Core Domain

## Status

Accepted

---

## Date

2026-05-30

---

## Context

HelixOps was initially conceived as a monitoring and operational platform.

During domain discovery it became clear that monitoring alone does not provide sufficient value.

Modern operational platforms are expected to:

- Detect issues.
- Evaluate conditions.
- Execute responses.
- Assist operators.

The platform vision evolved from:

Observe → Alert

to

Observe → Understand → Decide → Act

---

## Decision

Automation & Rules Engine is classified as a Core Domain.

Automation is considered a primary business capability rather than a supporting feature.

---

## Responsibilities

- Rule evaluation
- Automation orchestration
- Incident response workflows
- Automated remediation
- Operational decision execution

---

## Consequences

### Positive

- Strong alignment with DevOps practices.
- Enables self-healing workflows.
- Enables future AIOps capabilities.
- Creates differentiation from monitoring-only platforms.

---

### Negative

- Additional architectural complexity.
- Requires policy and rule management.
- Increases testing requirements.

---

## Alternatives Considered

### Monitoring Generates Alerts Directly

Rejected.

Reason:

Monitoring should focus on understanding system health.

---

### Alerting Owns Automation

Rejected.

Reason:

Alerting communicates incidents.

Automation decides actions.

---

## Architectural Impact

Automation becomes a central participant in:

- Event processing
- Incident management
- Deployment orchestration
- Operational workflows

---

## Related Documents

- ADR-0001
- modules.md
- policies.md
