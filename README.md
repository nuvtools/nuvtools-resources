# Nuv Tools Resources for .NET

A comprehensive localization library providing common UI resources (fields, actions, messages, and validation messages) for .NET applications in English and Portuguese (pt-BR).

[![NuGet](https://img.shields.io/nuget/v/NuvTools.Resources.svg)](https://www.nuget.org/packages/NuvTools.Resources/)
[![License](https://img.shields.io/github/license/nuvtools/nuvtools-resources.svg)](LICENSE)

## Features

- **Bilingual Support**: English and Portuguese (pt-BR)
- **Four Resource Types**: Actions, Fields, Messages, and FluentValidation Messages
- **243+ Localized Resources**: 33 actions, 162 fields, 48 messages
- **Strongly-Typed Access**: Static properties with compile-time safety
- **ResourceManager Support**: Runtime key lookup for dynamic scenarios
- **.NET Multi-targeting**: Supports .NET 8, 9, and 10
- **FluentValidation Integration**: Dedicated resources for FluentValidation messages

## What's New in v10.0.0

- **Actions Resources Separated**: Action verbs (Add, Edit, Delete, Save, etc.) moved from Fields to dedicated Actions.resx for better organization
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
User interface action verbs and commands (33 resources)

```csharp
using NuvTools.Resources;

var addButton = Actions.Add;              // "Add" / "Adicionar"
var saveButton = Actions.Save;            // "Save" / "Salvar"
var deleteButton = Actions.Delete;        // "Delete" / "Excluir"
var cancelButton = Actions.Cancel;        // "Cancel" / "Cancelar"
```

> **Note:** Actions were separated from Fields in v10.0.0 for better semantic organization.

### Fields
Common UI field labels and terms (162 resources)

```csharp
using NuvTools.Resources;

var accountLabel = Fields.Account;        // "Account" / "Conta"
var emailLabel = Fields.Email;            // "E-mail"
var nameLabel = Fields.Name;              // "Name" / "Nome"
var addressLabel = Fields.Address;        // "Address" / "Logradouro"
```

### Messages
User-facing notifications and messages (48 resources)

```csharp
using NuvTools.Resources;

var successMsg = Messages.Success;        // "Success!" / "Sucesso!"
var confirmMsg = Messages.ConfirmDeletion; // "Confirm the deletion?" / "Confirmar a exclusão?"
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
| **[Actions](docs/ACTIONS.md)** | 33 | Action verbs and commands (Add, Edit, Delete, Save, Search, etc.) |
| **[Fields](docs/FIELDS.md)** | 162 | Form field labels and UI elements (Account, Name, Email, Address, etc.) |
| **[Messages](docs/MESSAGES.md)** | 48 | User messages and notifications (Success, Error, Confirmations, etc.) |

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

## License

This project is licensed under the terms specified in the [LICENSE](LICENSE) file.

## Links

- [NuGet Package](https://www.nuget.org/packages/NuvTools.Resources/)
- [GitHub Repository](https://github.com/nuvtools/nuvtools-resources)
- [Nuv Tools](https://nuvtools.com)