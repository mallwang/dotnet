# Lottozahlen

Draws 6 distinct lottery numbers out of 49 plus a random draw date. The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/Lottozahlen
```

or publish with `dotnet publish src/Lottozahlen -c Release` and start `Lottozahlen.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/Lottozahlen -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/Lottozahlen.Core` | Pure logic (`net10.0`) |
| `src/Lottozahlen` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/Lottozahlen.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- Logic extracted into `LottoDraw` and unit-tested (6 distinct sorted numbers, no more index-0 workaround).
- Draw date is now always a valid date; the legacy version could show impossible dates like 30.2. (day 1-30 and month picked independently).
- Removed the unused `Class1` helper and the `Randomize()` calls.
