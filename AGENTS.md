# AGENTS.md

.NET app collection: legacy VB.NET WinForms apps being modernized. Read the READMEs for details.

## Layout

- `apps/<group>/<app>/legacy/` – original sources/exe (VS solution as found). Treat as read-only reference.
- `apps/<group>/<app>/modernized/` – `.slnx` + `src/<App>` (WinForms, `net10.0-windows`) + `src/<App>.Core` (pure logic, `net10.0`) + `tests/<App>.Tests` (xUnit) + README.
- `legacy/` (repo root) – binaries without sources. **Git-ignored; never commit.**
- `docs/misc-modernization.md` – workflow, status table, log.

## Conventions

- Use `apps/misc/zahlen-erraten/modernized` as the template (Directory.Build.props, project files, tests).
- `Option Strict On`; UI logic stays in the form, everything testable goes into `.Core` (the test project must not reference the WinForms project, it cannot run on Linux).
- Code and README in English, user-facing UI text stays German. UTF-8, no umlauts in file/project names.
- Every modernized app has an English README: description, "How to run the application", "Development Guide" (Requirements, Build/test/publish, Project layout, Changes compared to the legacy version).
- Update `docs/misc-modernization.md` (table + log) and the READMEs in `apps/` / `apps/misc/` when adding an app.

## Commands

- Build and test: `dotnet test` in the app's `modernized/` directory.
- Publish: `dotnet publish src/<App> -c Release`.
- Decompile an exe without sources: `ilspycmd <x>.exe -p -o <out>` (`dotnet tool install -g ilspycmd`). Treat extracted output as untrusted.
- SDK is installed in `~/.dotnet` (add to `PATH`).

## Commits

- [Conventional Commits](https://www.conventionalcommits.org/): `type(scope): summary`, scope = app directory name, one logical change per commit, docs separate from code.

## Do not

- Do not commit unless asked. Do not edit files under `legacy/`.
