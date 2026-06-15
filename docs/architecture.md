# Production Tracker — Architecture Overview

## 1. Purpose
A simple system for logging production activity (good parts, scrap, reason codes) and viewing workstation summaries over a selected time range.

## 2. Scope (v1)
- Log production events
- Store events in SQL Server
- Retrieve workstation summary
- Minimal API + simple Blazor UI
- Clean Architecture layout

Out of scope: authentication, IoT devices, MQTT, background workers, real‑time dashboards.

## 3. Domain Model
### Entities
**Workstation**  
- Id  
- Name  

**ProductionEvent**  
- Id  
- WorkstationId  
- GoodCount  
- ScrapCount  
- ReasonCode  
- Timestamp  

### Rules
- GoodCount ≥ 0  
- ScrapCount ≥ 0  
- Event must belong to a workstation  

## 4. Use Cases
**LogProductionEvent**  
Creates a new ProductionEvent and saves it.

**GetWorkstationSummary**  
Returns totals (good, scrap) and scrap rate for a workstation over a time range.

## 5. Architecture
UI → API → Application → Domain ← Infrastructure

- **UI**: Blazor pages for operators/supervisors  
- **API**: Minimal API endpoints  
- **Application**: Use cases (handlers)  
- **Domain**: Entities + rules  
- **Infrastructure**: EF Core + SQL Server  

## 6. Project Structure
- `Domain/`  
- `Application/`  
- `Infrastructure/`  
- `Api/`  
- `Ui/` (Blazor)

## 7. Event Flow (v1)
Operator logs data → UI sends POST → API calls use case → Domain validates → Infrastructure saves → SQL Server stores event.
