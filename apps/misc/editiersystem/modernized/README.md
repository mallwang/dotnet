# Editiersystem (MarkTED)

A small text editor with bold, underline, superscript, size, color and font; it loads text, counts characters and exports the formatted text as a two-column HTML page (also as print preview). The UI is German.

## How to run the application

Windows only (Windows Forms):

```
dotnet run --project src/Editiersystem
```

or publish with `dotnet publish src/Editiersystem -c Release` and start `Editiersystem.exe`.

## Development Guide

### Requirements

- .NET SDK 10 (building and testing also works on Linux/WSL)

### Build, test, publish

```
dotnet test
dotnet publish src/Editiersystem -c Release
```

### Project layout

| Path | Content |
|------|---------|
| `src/Editiersystem.Core` | Pure logic (`net10.0`) |
| `src/Editiersystem` | Windows Forms UI (`MainForm`, `Program`) |
| `tests/Editiersystem.Tests` | xUnit tests for the logic |

### Changes compared to the legacy version

- .NET Framework 4.0 -> .NET 10, SDK-style projects, `Option Strict On`.
- HTML generation extracted into `Editiersystem.Core` (`HtmlExporter`) with xUnit tests; the hidden `txt` RichTextBox is gone
- Text is HTML-escaped, the malformed `<p style=...>` attribute is fixed, UTF-8 charset declared
- Column break can no longer be emitted twice
- Print preview uses the temp folder and the shell via `Process.Start` instead of hard-coded `C:\temp` and the Shell32 COM reference
- Dead code removed (`ApplicationEvents.vb`, unused ToolStripButton1, commented-out code)
- Resources (toolbar images, icon) kept in `MainForm.resx`
