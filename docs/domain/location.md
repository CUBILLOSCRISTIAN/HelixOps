# Location Domain Model

## Purpose

Represents a physical operational site managed by HelixOps.

Examples:

- Retail Store
- Restaurant
- Pharmacy
- Warehouse
- Airport Kiosk Area

---

## Aggregate Root

Location

---

## Identity

LocationId

---

## Attributes

LocationId
Code
Name
Country
Region
City
Address
Status
CreatedAt
UpdatedAt

---

## Status

Active
Inactive
Maintenance
Closed

---

## Invariants

A Location must have a unique Code.

A Closed Location cannot receive new Devices.

A Location must have a Name.

---

## Events

LocationCreated
LocationActivated
LocationClosed

---

## Commands

CreateLocation
ActivateLocation
CloseLocation
