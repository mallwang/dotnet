# HTML-Speicherung

A small rich text editor that makes the selected text bold and saves the text as .txt/.html. The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/HtmlSpeicherung
```

or publish with `dotnet publish src/HtmlSpeicherung -c Release` and start `HtmlSpeicherung.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/HtmlSpeicherung -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/HtmlSpeicherung.Core` | Pure logic (`net10.0`) |
| `src/HtmlSpeicherung` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/HtmlSpeicherung.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- File writing extracted into `HtmlSpeicherung.Core` (`TextFileSaver`) with an xUnit test; always UTF-8
- Save errors are shown in a message box instead of crashing; writer is disposed reliably
- Desktop folder resolved properly (legacy used the literal string "Desktop")
- Bold formatting keeps other styles; the selection is restored afterwards
- Note: like the legacy version, the plain text is saved, not the formatting
