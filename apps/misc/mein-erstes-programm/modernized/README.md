# Mein erstes Programm

Lists the files of a directory and shows their creation, last access and last write times. The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/MeinErstesProgramm
```

or publish with `dotnet publish src/MeinErstesProgramm -c Release` and start `MeinErstesProgramm.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/MeinErstesProgramm -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/MeinErstesProgramm.Core` | Pure logic (`net10.0`) |
| `src/MeinErstesProgramm` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/MeinErstesProgramm.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- Sources recovered by decompiling the legacy exe (ilspycmd) and ported to VB.NET.
- Logic moved to `FileInfoText` in Core; missing or invalid directories are reported instead of throwing.
- Dropped `SetCurrentDirectory`; the full path is used directly.
