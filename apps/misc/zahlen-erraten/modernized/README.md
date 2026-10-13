# Zahlen raten

The computer picks a number between 1 and 100; guess it. Hints say "too low" or "too high". After a correct guess a new round starts. The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/ZahlenErraten
```

or publish with `dotnet publish src/ZahlenErraten -c Release` and start `ZahlenErraten.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/ZahlenErraten -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/ZahlenErraten.Core` | `GuessGame`: pure game logic (`net10.0`) |
| `src/ZahlenErraten` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/ZahlenErraten.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- Game logic separated from the form and unit-tested.
- Fixed: empty or non-numeric input crashed (the number was parsed before the empty check); now it is rejected with a message.
- Fixed: random range was 1-99 despite the text "1 and 100"; now 1-100.
- Form `Gleitzeit` (copy-paste leftover) renamed to `MainForm`.
