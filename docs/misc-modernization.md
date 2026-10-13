# Plan: Modernize the misc apps

All apps are VB.NET Windows Forms on .NET Framework 4.0 (~1,700 lines in total). Sources are available, no decompiling needed.
Target: VB.NET + WinForms on .NET 10, same behavior, logic extracted and unit-tested.

## Workflow per app

1. Move to `apps/misc/<app>/legacy/` (done for all apps).
2. Create `modernized/` from `apps/misc/zahlen-erraten/modernized` (Directory.Build.props, `.Core`, tests).
3. Port: SDK-style projects, `Option Strict On`, replace `MsgBox`/`Like`/implicit conversions, validate input, extract logic to `.Core`.
4. English README (structure: see `zahlen-erraten/modernized/README.md`).
5. `dotnet test`, `dotnet publish` (in WSL; the GUI cannot be started there, which is fine).
6. Update this table and `apps/misc/README.md`; one commit per app.

## Final step: check on Windows

After all apps are modernized, clone the repository on Windows (.NET SDK 10 installed) and check **each app**:

1. `dotnet test` in `apps/misc/<app>/modernized` passes.
2. `dotnet run --project src/<App>` starts the GUI; walk through the main functions and compare with the legacy exe in `legacy/`.
3. `dotnet publish src/<App> -c Release` produces a working exe.
4. Record the result in the table below.

| App | Windows check |
|-----|:---:|
| zahlen-erraten | open |
| lottozahlen | open |
| html-speicherung | open |
| kaffeeautomat | open |
| editiersystem | open |

## Status

| App | Moved | Modernized | Notes |
|-----|:---:|:---:|-------|
| zahlen-erraten | yes | yes | Pilot, v2.0 |
| lottozahlen | yes | yes | |
| html-speicherung | yes | yes | |
| kaffeeautomat | yes | yes | project still named `WindowsApplication1` |
| editiersystem | yes | no | largest app (~720 lines), has class diagrams and a .docx |
| `Mein erstes Programm.exe` | in `legacy/` | no | exe only, no sources; decompile with ilspycmd if wanted |

## Log

- Repository restructured, pilot `zahlen-erraten` modernized (5 xUnit tests pass; GUI not run, WSL has no Windows Forms).
- `lottozahlen` modernized (4 tests pass).
- kaffeeautomat: modernized (Order logic in Core, 10 tests)
- html-speicherung: modernized (TextFileSaver in Core, 1 test)
