# Messages - Resource Dictionary

User-facing messages, notifications, and validation templates.

**Total Resources:** 66

**Usage:**
```csharp
using NuvTools.Resources;

// Direct messages
var successMsg = Messages.OperationPerformedSuccessfully;
var errorMsg = Messages.TheOperationCouldNotBePerformed;

// Parameterized templates
var notFoundMsg = string.Format(Messages.XNotFound, "User");      // "User not found."
var invalidMsg = string.Format(Messages.XInvalid, "E-mail");      // "E-mail is invalid."
var confirmMsg = string.Format(Messages.ConfirmX, "deletion");    // "Confirm deletion?"
```

---

## Template Messages

These parameterized messages replace multiple specific messages. Use `string.Format()` or string interpolation.

| Key | English | Portuguese (pt-BR) |
|-----|---------|-------------------|
| AddXClickingY | Add new {0} by clicking {1}. | Inclua novos(as) {0} clicando em {1}. |
| AtLeastOneTheseParametersShoudBeFilledX | At least one of these parameters should be filled: {0}. | Pelo menos um desses parâmetros deve ser informado: {0}. |
| ConfirmX | Confirm {0}? | Confirmar {0}? |
| CouldNotDeleteXExistYAssociated | Could not delete {0}. There are {1} associated. | Não foi possível excluir {0}. Existem {1} associados(as). |
| CouldNotDeleteXVerifyAssociatedData | Could not delete {0}. Verify if there is associated data. | Não foi possível excluir {0}. Verifique se existem dados associados. |
| DateXMustBeAfterDateY | Date {0} must be after date {1}. | A data {0} deve ser posterior à data {1}. |
| EmailConfirmationContentWithLinkX | Please confirm your account by &lt;a href='{0}'&gt;clicking here&lt;/a&gt;. | Confirme sua conta &lt;a href='{0}'&gt;clicando aqui&lt;/a&gt;. |
| EmailXAlreadyTaken | E-mail {0} is already taken. | E-mail {0} já em uso. |
| FailedToCreateX | Failed to create {0}. | Falha ao cadastrar {0}. |
| FailedToDeleteX | Failed to delete {0}. | Falha ao excluir {0}. |
| FailedToGenerateX | Failed to generate {0}. | Falha ao gerar {0}. |
| FailedToUpdateX | Failed to update {0}. | Falha ao atualizar {0}. |
| InvalidFileTypeAcceptedFormatX | Invalid file type. Accepted format: {0}. | Tipo de arquivo inválido. Formato aceito: {0}. |
| NoPermissionToDeleteX | No permission to delete {0}. | Sem permissão para excluir {0}. |
| PasswordResetEmailContentWithLinkX | Please reset your password by &lt;a href='{0}'&gt;clicking here&lt;/a&gt;. | Por favor, redefina sua senha &lt;a href='{0}'&gt;clicando aqui&lt;/a&gt;. |
| ProvideAtLeastOneX | Provide at least one {0}. | Informe pelo menos um(a) {0}. |
| ThereIsNoXRegisteredSoFar | There is no {0} registered so far. | Nenhum(a) {0} cadastrado(a) até o momento. |
| ViewX | View {0} | Ver {0} |
| WelcomeX | Welcome {0}. | Seja bem-vindo(a) {0}. |
| XAlreadyExists | {0} already exists. | {0} já existe. |
| XDeletedSuccessfully | {0} deleted successfully. | {0} excluído(a) com sucesso. |
| XIncomplete | {0} incomplete. | {0} incompleto(a). |
| XInvalid | {0} is invalid. | {0} inválido(a). |
| XMustBeEqualY | The {0} must be equal {1}. | O(A) {0} deve ser igual ao(à) {1}. |
| XMustBeGreaterThanY | {0} must be greater than {1}. | {0} deve ser maior do que {1}. |
| XMustBeLessThanY | {0} must be less than {1}. | {0} deve ser menor do que {1}. |
| XMustContainAtLeastYCapitalLetters | The {0} must contain at least {1} capital letter(s). | O(A) {0} deve conter pelo menos {1} letra(s) maiúscula(s). |
| XMustContainAtLeastYDigits | The {0} must contain at least {1} digit(s). | O(A) {0} deve conter pelo menos {1} dígito(s). |
| XMustContainAtLeastYLowerCaseLetters | The {0} must contain at least {1} lower case letter(s). | O(A) {0} deve conter pelo menos {1} letra(s) minúscula(s). |
| XMustContainBetweenYandZCharacters | The {0} must contain between {1} and {2} character(s). | O(A) {0} deve conter entre {1} e {2} caracteres. |
| XMustHaveAtLeastYCharacters | The {0} must have at least {1} character(s). | O(A) {0} deve ter pelo menos {1} caracter(s). |
| XMustHaveUpToYCharacters | The {0} must have up to {1} character(s). | O(A) {0} deve ter até {1} caractere(s). |
| XNotFound | {0} not found. | {0} não encontrado(a). |
| XNotProvided | {0} not provided. | {0} não informado(a). |
| XRegisteredSuccessfully | {0} registered successfully. | {0} cadastrado(a) com sucesso. |
| XRequired | {0} is required. | {0} é obrigatório(a). |
| XUpdatedSuccessfully | {0} updated successfully. | {0} atualizado(a) com sucesso. |
| XYSuccess | {0} {1} successfully. | {0} {1} com sucesso. |

---

## Generic Messages

Direct messages without parameters.

| Key | English | Portuguese (pt-BR) |
|-----|---------|-------------------|
| AccessDenied | Access denied. | Acesso negado. |
| CancelDeletion | Cancel Deletion | Cancelar Exclusão |
| CodeExpired | Code expired. | Código expirado. |
| DoYouReallyLogout | Do you really want to logout? | Deseja realmente sair? |
| EmailConfirmed | E-mail confirmed. | E-mail confirmado. |
| EmailMustBeConfirmed | E-mail must be confirmed. | E-mail precisa estar confirmado. |
| EndDateMustBeGreaterThanStartDate | End date must be greater than start date. | A data de término deve ser maior que a data de início. |
| ErrorInProvidedParameters | Error in provided parameters. | Erro nos parâmetros informados. |
| IdObjectNotMatchUrl | The ID in the object does not match the ID in the URL. | O ID no objeto não corresponde ao ID no URL. |
| InactiveUser | Inactive user. | Usuário inativo. |
| InvalidExpiredToken | Invalid or expired token. | Token inválido ou expirado. |
| LoginSuccessful | Login successful. | Login bem sucedido. |
| LogoutConfirmation | Logout Confirmation | Confirmação de Saída |
| NoneParameterInformed | None parameter informed. | Nenhum parâmetro informado. |
| NotAllowed | Not Allowed. | Não permitido. |
| OperationPerformedSuccessfully | Operation performed successfully. | Operação realizada com sucesso. |
| PasswordResetFailed | Password reset failed. | Falha ao redefinir senha. |
| PasswordResetMailWasSent | Password Reset Mail was sent. | E-mail para redefinição de senha enviado. |
| PasswordResetSuccessful | Password Reset Successful! | Senha redefinida com sucesso! |
| ProcessingCompleted | Processing completed. | Processamento concluído. |
| ProvideAtLeastOneParameter | Provide at least one parameter. | Informe pelo menos um parâmetro. |
| TextCopied | Text copied. | Texto copiado. |
| TheOperationCouldNotBePerformed | The operation could not be performed. | Não foi possível realizar a operação. |
| ToConfirmDeletion | To confirm deletion | Para confirmar a exclusão |
| UploadedFileIsEmpty | The uploaded file is empty. | O arquivo enviado está vazio. |
| ValidationProblemsFound | Validation problems were found. | Problemas de validação encontrados. |
| ValidVerificationCode | Valid verification code. | Código de verificação válido. |
| ValueOutsideRange | Value outside range | Valor fora da faixa |

---

## Migration Guide

If you were using any of the removed specific messages, replace them with the parameterized templates:

| Old (Removed) | New (Template) |
|---------------|----------------|
| `Messages.InvalidEmail` | `string.Format(Messages.XInvalid, "E-mail")` |
| `Messages.UserNotFound` | `string.Format(Messages.XNotFound, "User")` |
| `Messages.TokenNotFound` | `string.Format(Messages.XNotFound, "Token")` |
| `Messages.RecordNotFound` | `string.Format(Messages.XNotFound, "Record")` |
| `Messages.RoleAlreadyExists` | `string.Format(Messages.XAlreadyExists, "Role")` |
| `Messages.EmailAlreadyRegistered` | `string.Format(Messages.XAlreadyExists, "E-mail")` |
| `Messages.UserCreatedSuccessfully` | `string.Format(Messages.XRegisteredSuccessfully, "User")` |
| `Messages.ConfirmDeletion` | `string.Format(Messages.ConfirmX, "deletion")` |
| `Messages.ConfirmActivation` | `string.Format(Messages.ConfirmX, "activation")` |

---

## Related Dictionaries

- [Actions Dictionary](ACTIONS.md) - Action labels and commands
- [Fields Dictionary](FIELDS.md) - Form field labels and UI elements
- [Back to README](../README.md)
