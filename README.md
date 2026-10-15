# Nuv Tools Resources for .NET

A comprehensive localization library providing common UI resources (fields, actions, messages, and validation messages) for .NET applications in English and Portuguese (pt-BR).

[![NuGet](https://img.shields.io/nuget/v/NuvTools.Resources.svg)](https://www.nuget.org/packages/NuvTools.Resources/)
[![License](https://img.shields.io/github/license/nuvtools/nuvtools-resources.svg)](LICENSE)

## Features

- **Bilingual Support**: English and Portuguese (pt-BR)
- **Four Resource Types**: Actions, Fields, Messages, and FluentValidation Messages
- **477+ Localized Resources**: 49 actions, 311 fields, 117 messages
- **Strongly-Typed Access**: Static properties with compile-time safety
- **ResourceManager Support**: Runtime key lookup for dynamic scenarios
- **.NET Multi-targeting**: Supports .NET 8, 9, and 10
- **FluentValidation Integration**: Dedicated resources for FluentValidation messages

## What's New in v10.0.0

- **Actions Resources Separated**: Action verbs (Add, Edit, Delete, Save, etc.) moved from Fields to dedicated Actions.resx for better organization
- **Messages Cleanup**: Removed 51 redundant messages that can be replaced by parameterized templates (e.g., use `XNotFound` with parameter instead of `UserNotFound`, `TokenNotFound`, etc.)
- **New Template Messages**: Added `ConfirmX` template for generic confirmations
- **Enhanced Documentation**: Interactive dictionary pages for browsing all resources with translations
- **Modern Solution Format**: Using .slnx (XML-based) solution file format

## Installation

```bash
dotnet add package NuvTools.Resources
```

Or via NuGet Package Manager:

```
Install-Package NuvTools.Resources
```

## Resource Types

### Actions
User interface action verbs and commands (49 resources)

```csharp
using NuvTools.Resources;

var addButton = Actions.Add;              // "Add" / "Adicionar"
var saveButton = Actions.Save;            // "Save" / "Salvar"
var deleteButton = Actions.Delete;        // "Delete" / "Excluir"
var cancelButton = Actions.Cancel;        // "Cancel" / "Cancelar"
```

> **Note:** Actions were separated from Fields in v10.0.0 for better semantic organization.

### Fields
Common UI field labels and terms (311 resources)

```csharp
using NuvTools.Resources;

var accountLabel = Fields.Account;        // "Account" / "Conta"
var emailLabel = Fields.Email;            // "E-mail"
var nameLabel = Fields.Name;              // "Name" / "Nome"
var addressLabel = Fields.Address;        // "Address" / "Logradouro"
```

### Messages
User-facing notifications and validation messages (117 resources)

```csharp
using NuvTools.Resources;

var successMsg = Messages.OperationPerformedSuccessfully;  // "Operation performed successfully."
var notFoundMsg = string.Format(Messages.XNotFound, "User"); // "User not found."
var confirmMsg = string.Format(Messages.ConfirmX, "deletion"); // "Confirm deletion?"
```

### FluentValidation Messages
Validation error messages for FluentValidation integration

```csharp
using NuvTools.Resources;

// FluentValidation-specific messages (accessed via ResourceManager)
var notEmptyMsg = FluentValidationMessages.ResourceManager.GetString("NotEmpty");
var emailMsg = FluentValidationMessages.ResourceManager.GetString("EmailValidator");
```

## Localization

Resources automatically adapt to the current UI culture:

```csharp
using System.Globalization;
using NuvTools.Resources;

// Set culture to Portuguese
CultureInfo.CurrentUICulture = new CultureInfo("pt-BR");
Console.WriteLine(Fields.Name);  // Output: "Nome"

// Set culture to English
CultureInfo.CurrentUICulture = new CultureInfo("en");
Console.WriteLine(Fields.Name);  // Output: "Name"
```

## Resource Access

The library provides two ways to access resources:

### Static Properties (Recommended)
Strongly-typed properties with compile-time safety:

```csharp
using NuvTools.Resources;

// Actions, Fields, and Messages provide static properties
var addAction = Actions.Add;           // "Add" / "Adicionar"
var nameField = Fields.Name;           // "Name" / "Nome"
var successMsg = Messages.Success;     // "Success!" / "Sucesso!"
```

### ResourceManager (Runtime Lookup)
Use ResourceManager when you need to look up resources by string keys at runtime:

```csharp
using System.Globalization;
using NuvTools.Resources;

// All resource classes expose a ResourceManager property
var action = Actions.ResourceManager.GetString("Add");
var field = Fields.ResourceManager.GetString("Name");
var message = Messages.ResourceManager.GetString("Success");

// Specify culture explicitly
var localizedField = Fields.ResourceManager.GetString("Name", new CultureInfo("pt-BR"));  // "Nome"
var localizedAction = Actions.ResourceManager.GetString("Add", new CultureInfo("pt-BR")); // "Adicionar"

// FluentValidation messages
var notEmptyMsg = FluentValidationMessages.ResourceManager.GetString("NotEmpty");
```

## Building the Project

```bash
# Build
dotnet build

# Build for Release
dotnet build -c Release

# Create NuGet package
dotnet pack -c Release
```

## Documentation

### Complete Resource Dictionaries

Browse searchable dictionaries with all available resources and their English/Portuguese translations:

| Dictionary | Resources | Description |
|------------|-----------|-------------|
| **[Actions](docs/ACTIONS.md)** | 49 | Action verbs and commands (Add, Edit, Delete, Save, Search, etc.) |
| **[Fields](docs/FIELDS.md)** | 311 | Form field labels and UI elements (Account, Name, Email, Address, etc.) |
| **[Messages](docs/MESSAGES.md)** | 117 | User messages and validation templates (XNotFound, XInvalid, XRequired, etc.) |

These dictionaries are perfect for:
- Finding the right resource key before coding
- Browsing available translations
- Ensuring consistency across your application

## Target Frameworks

- .NET 8
- .NET 9
- .NET 10

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Releasing

Publishing to nuget.org is irreversible per version, so the workflow makes it the last and smallest
step.

The package has its own workflow, and the steps live in the reusable `package-publish.yml`, the
same layout as the other NuvTools repositories.

| Package | Workflow | Release tag |
|---|---|---|
| `NuvTools.Resources` | `resources-publish.yml` | `resources-vX.Y.Z` |

1. Set the package's `<Version>` in its `.csproj` and merge it. That is the version that gets
   published; the workflow reads it and never computes one.
2. Run the library's workflow by hand (*Actions → Resources Publish → Run workflow*) with *push*
   checked.
3. The workflow builds the solution with `-warnaserror`, runs the tests, takes **that package only**
   from the build output, verifies it carries its README, licence, icon, symbols and every target
   framework, and then waits for approval on the `nuget` GitHub Environment before pushing.
4. **After the push succeeds, the workflow tags the commit** with the tag in the table above. The tag is a
   record of what is on nuget.org, never what starts a release, so it cannot exist for a version
   that did not get there. A run whose tag already exists stops before building: the version has
   been released and `<Version>` needs a bump.

**Versions published by hand are refused.** Releases made before these workflows exist on nuget.org
with no tag. Pushing one again would skip the duplicate and then tag the current commit as a
release it is not, so a version that is already on nuget.org stops the run. The exception is a
re-run of the same run, which is how a push that succeeded and a tag that failed gets finished.

**No API key is stored.** The push uses nuget.org's trusted publishing: the job presents a GitHub
OIDC token, nuget.org checks it against the policy registered for this repository and answers with a
key that lives for one hour. The repository needs one secret, `NUGET_USER` — the nuget.org profile
name the policy belongs to — and the policy itself, registered under *Trusted Publishing* on
nuget.org with the owner `nuvtools`, the repository `nuvtools-resources`, the workflow file and the
environment `nuget`.

Run a library's workflow by hand with *push* unchecked for a dry run that stops after the
verification.

## License

This project is licensed under the terms specified in the [LICENSE](LICENSE) file.

## Links

- [NuGet Package](https://www.nuget.org/packages/NuvTools.Resources/)
- [GitHub Repository](https://github.com/nuvtools/nuvtools-resources)
- [Nuv Tools](https://nuvtools.com)