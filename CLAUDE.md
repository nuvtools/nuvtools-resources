# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

NuvTools.Resources is a .NET library containing common localized resources (fields, messages, and validation messages) for Nuv Tools libraries and projects. It provides bilingual support (English and Portuguese pt-BR) for UI strings and validation messages.

## Build & Development Commands

### Build
```bash
dotnet build
```

### Build for Release (generates NuGet package)
```bash
dotnet build -c Release
```

### Clean
```bash
dotnet clean
```

### Pack (create NuGet package)
```bash
dotnet pack -c Release
```

## Architecture & Structure

### Target Frameworks
The project multi-targets:
- .NET 8 (net8)
- .NET 9 (net9)
- .NET 10 (net10.0)

### Resource Organization

The library provides **four types of resources**:

1. **Actions** - UI action verbs (Add, Edit, Delete, Save, etc.) - **Separated from Fields in v10.0.0**
2. **Fields** - UI field labels and common terms (Account, Name, Email, etc.)
3. **Messages** - User-facing messages and notifications
4. **FluentValidationMessages** - Validation error messages for FluentValidation integration

Each resource type is accessible via:
- **Static properties** - Strongly-typed compile-time properties (e.g., `Actions.Add`, `Fields.Account`, `Messages.Success`)
- **ResourceManager** - Runtime key lookup (e.g., `Actions.ResourceManager.GetString("Add")`)

The library includes four `.resx` files:
- `Actions.resx` - 33 action verbs
- `Fields.resx` - 162 field labels
- `Messages.resx` - 48 user messages
- `FluentValidationMessages.resx` - FluentValidation-specific messages

### Localization

All resources support Portuguese (Brazil) via `*.pt-BR.resx` companion files. The .NET runtime automatically selects the appropriate culture-specific resource based on `CurrentUICulture`.

**Important:** Only the base `.resx` files (e.g., `Fields.resx`) use `PublicResXFileCodeGenerator` to generate Designer.cs files. The `pt-BR.resx` files have empty `<Generator>` tags and do not generate code.

### Auto-Generated Files

**Do not manually edit** the `*.Designer.cs` files:
- `Actions.Designer.cs`
- `Fields.Designer.cs`
- `Messages.Designer.cs`
- `FluentValidationMessages.Designer.cs`

These are regenerated from `.resx` files by `dotnet build` via the `PublicResXFileCodeGenerator` tool.

### Adding/Modifying Resources

1. **Edit the `.resx` file** in Visual Studio or a text editor
2. For bilingual support, **add the same entry** to the corresponding `pt-BR.resx` file with translated value
3. **Run `dotnet build`** to regenerate the Designer.cs file
4. The new resource will be accessible as a static property (e.g., `Fields.NewField`) or via ResourceManager for dynamic resources

### Package Metadata

The project auto-generates NuGet packages on build (`GeneratePackageOnBuild = true`). Key metadata:
- **Package ID:** NuvTools.Resources
- **Version:** 10.0.0 (update in .csproj)
- **Authors:** Nuv Tools
- **Repository:** https://github.com/nuvtools/nuvtools-resources
- **Documentation:**
  - [Actions Dictionary](docs/ACTIONS.md) - 33 action verbs
  - [Fields Dictionary](docs/FIELDS.md) - 162 field labels
  - [Messages Dictionary](docs/MESSAGES.md) - 48 user messages

### Important Notes

- **Actions.resx was separated from Fields.resx** in version 10.0.0 to better organize action verbs vs data field labels
- **Solution file is .slnx format** (XML-based) instead of traditional .sln - this is the modern format for .NET solutions
- All dictionary markdown files are in the `docs/` folder for easy GitHub browsing
