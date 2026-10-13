# .NET projects

Collection of small VB.NET (Windows Forms) applications, being modernized from .NET Framework 4.0 to .NET 10.

## Prerequisites

- .NET SDK 10
- Building and testing works on Linux/WSL (`EnableWindowsTargeting`); **running the Windows Forms apps needs Windows**.

```bash
cd apps/misc/<app>/modernized
dotnet test
dotnet run --project src/<App>
```

## Repository layout

| Path | Content |
|------|---------|
| [apps/](apps/README.md) | All applications, one directory each with `legacy/` and `modernized/` |
| [apps/misc/](apps/misc/README.md) | Small apps (listed below) |
| `legacy/` | Old binaries without sources (git-ignored, local only) |
| [docs/](docs/misc-modernization.md) | Migration plan and status log |
| [AGENTS.md](AGENTS.md) | Context for coding agents |

## Available applications

See [apps/misc](apps/misc/README.md).
