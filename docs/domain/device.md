# Device Domain Model

## Purpose

Represents an operational asset connected to HelixOps.

Examples:

- POS
- Self Checkout
- Kiosk
- Receipt Printer
- Barcode Scanner

---

## Aggregate Root

Device

---

## Identity

DeviceId

---

## Attributes

DeviceId

LocationId

SerialNumber

DeviceType

CurrentVersion

Status

LastHeartbeatAt

CreatedAt

UpdatedAt

---

## Device Types

POS

Kiosk

Printer

Scanner

SelfCheckout

---

## Device Status

Provisioning

Online

Offline

Maintenance

Retired

---

## Invariants

A Device must belong to a Location.

A Device must have a unique SerialNumber.

A Retired Device cannot send heartbeats.

---

## Commands

RegisterDevice

ActivateDevice

DeactivateDevice

MarkDeviceOffline

ReportDeviceVersion

SendHeartbeat

---

## Events

DeviceRegistered

DeviceActivated

DeviceOffline

HeartbeatReceived

DeviceVersionReported
