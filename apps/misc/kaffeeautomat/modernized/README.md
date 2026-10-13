# Kaffeeautomat

A small drink vending machine: enter a name, pick drink and size, optionally milk and sugar (coffee and tea only). The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/Kaffeeautomat
```

or publish with `dotnet publish src/Kaffeeautomat -c Release` and start `Kaffeeautomat.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/Kaffeeautomat -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/Kaffeeautomat.Core` | Pure logic (`net10.0`) |
| `src/Kaffeeautomat` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/Kaffeeautomat.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- Order logic extracted into `Kaffeeautomat.Core` (`Order`) with xUnit tests
- Radio buttons mapped to enums instead of nested If chains
- Milk/sugar are disabled and cleared for drinks other than coffee and tea
- Removed dead code (`Class1.vb`, `basKaffeZubehör.vb`) and fixed the title typo "Kaffeautomat"
