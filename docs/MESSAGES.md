# Messages - Resource Dictionary

User-facing messages, notifications, and validation templates.

**Total Resources:** 117

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
| AndXMore | and {0} more | e mais {0} |
| AtLeastOneOfTheseParametersShouldBeFilledX | At least one of these parameters should be filled: {0}. | Pelo menos um desses parâmetros deve ser informado: {0}. |
| AtLeastOneTheseParametersShoudBeFilledX | At least one of these parameters should be filled: {0}. | Pelo menos um desses parâmetros deve ser informado: {0}. |
| ConfirmX | Confirm {0}? | Confirmar {0}? |
| CouldNotCommunicateWithX | Could not communicate with {0}. | Não foi possível se comunicar com {0}. |
| CouldNotDeleteXExistYAssociated | Could not delete {0}. There are {1} associated. | Não foi possível excluir {0}. Existem {1} associados(as). |
| CouldNotDeleteXVerifyAssociatedData | Could not delete {0}. Verify if there is associated data. | Não foi possível excluir {0}. Verifique se existem dados associados. |
| CreatedOnXByY | Created on {0} by {1}. | Criado(a) em {0} por {1}. |
| DateXMustBeAfterDateY | Date {0} must be after date {1}. | A data {0} deve ser posterior à data {1}. |
| DateXMustBeOnOrAfterDateY | Date {0} must be on or after date {1}. | A data {0} deve ser igual ou posterior à data {1}. |
| DeleteXQuestion | Delete {0}? | Excluir {0}? |
| DuplicateValuesX | Duplicate values: {0}. | Valores repetidos: {0}. |
| EmailConfirmationContentWithLinkX | Please confirm your account by &lt;a href='{0}'&gt;clicking here&lt;/a&gt;. | Confirme sua conta &lt;a href='{0}'&gt;clicando aqui&lt;/a&gt;. |
| EmailXAlreadyTaken | E-mail {0} is already taken. | E-mail {0} já em uso. |
| EnterAllXDigitsOfTheCode | Enter all {0} digits of the code. | Preencha todos os {0} dígitos do código. |
| FailedToCreateX | Failed to create {0}. | Falha ao cadastrar {0}. |
| FailedToDeleteX | Failed to delete {0}. | Falha ao excluir {0}. |
| FailedToDownloadX | Failed to download {0}. | Falha ao baixar {0}. |
| FailedToGenerateX | Failed to generate {0}. | Falha ao gerar {0}. |
| FailedToUpdateX | Failed to update {0}. | Falha ao atualizar {0}. |
| FileExceedsMaximumSizeOfX | The file exceeds the maximum size of {0}. | O arquivo excede o tamanho máximo de {0}. |
| FileXExceedsMaximumSizeOfY | The file {0} exceeds the maximum size of {1}. | O arquivo {0} excede o tamanho máximo de {1}. |
| InvalidFileNameX | Invalid file name: {0}. | Nome de arquivo inválido: {0}. |
| InvalidFileTypeAcceptedFormatX | Invalid file type. Accepted format: {0}. | Tipo de arquivo inválido. Formato aceito: {0}. |
| LastModifiedOnX | Last modified on {0}. | Última alteração em {0}. |
| MaximumOfXFilesAtOnce | Send at most {0} file(s) at a time. | Envie no máximo {0} arquivo(s) por vez. |
| NoPermissionToDeleteX | No permission to delete {0}. | Sem permissão para excluir {0}. |
| NoXFound | No {0} found. | Nenhum(a) {0} encontrado(a). |
| PageXOfY | Page {0} of {1} | Página {0} de {1} |
| PasswordResetEmailContentWithLinkX | Please reset your password by &lt;a href='{0}'&gt;clicking here&lt;/a&gt;. | Por favor, redefina sua senha &lt;a href='{0}'&gt;clicando aqui&lt;/a&gt;. |
| ProvideAtLeastOneX | Provide at least one {0}. | Informe pelo menos um(a) {0}. |
| ResendCodeInXSeconds | Resend code in {0}s | Reenviar código em {0}s |
| ThereIsNoXRegisteredSoFar | There is no {0} registered so far. | Nenhum(a) {0} cadastrado(a) até o momento. |
| VerificationCodeSentToX | A verification code was sent to {0}. | Um código de verificação foi enviado para {0}. |
| ViewX | View {0} | Ver {0} |
| WelcomeX | Welcome {0}. | Seja bem-vindo(a) {0}. |
| XActivatedSuccessfully | {0} activated successfully. | {0} ativado(a) com sucesso. |
| XAlreadyExists | {0} already exists. | {0} já existe. |
| XAlreadyInList | {0} is already in the list. | {0} já consta na lista. |
| XCanceledSuccessfully | {0} canceled successfully. | {0} cancelado(a) com sucesso. |
| XDeactivatedSuccessfully | {0} deactivated successfully. | {0} desativado(a) com sucesso. |
| XDeletedSuccessfully | {0} deleted successfully. | {0} excluído(a) com sucesso. |
| XDidNotRespondInTime | {0} did not respond in time. | {0} não respondeu a tempo. |
| XGeneratedSuccessfully | {0} generated successfully. | {0} gerado(a) com sucesso. |
| XIncomplete | {0} incomplete. | {0} incompleto(a). |
| XInvalid | {0} is invalid. | {0} inválido(a). |
| XMustBeBetweenYandZ | {0} must be between {1} and {2}. | {0} deve estar entre {1} e {2}. |
| XMustBeEqualY | The {0} must be equal to {1}. | O(A) {0} deve ser igual ao(à) {1}. |
| XMustBeGreaterThanOrEqualToY | {0} must be greater than or equal to {1}. | {0} deve ser maior ou igual a {1}. |
| XMustBeGreaterThanY | {0} must be greater than {1}. | {0} deve ser maior do que {1}. |
| XMustBeLessThanOrEqualToY | {0} must be less than or equal to {1}. | {0} deve ser menor ou igual a {1}. |
| XMustBeLessThanY | {0} must be less than {1}. | {0} deve ser menor do que {1}. |
| XMustContainAtLeastYCapitalLetters | The {0} must contain at least {1} capital letter(s). | O(A) {0} deve conter pelo menos {1} letra(s) maiúscula(s). |
| XMustContainAtLeastYDigits | The {0} must contain at least {1} digit(s). | O(A) {0} deve conter pelo menos {1} dígito(s). |
| XMustContainAtLeastYLowerCaseLetters | The {0} must contain at least {1} lower case letter(s). | O(A) {0} deve conter pelo menos {1} letra(s) minúscula(s). |
| XMustContainAtLeastYSpecialCharacters | The {0} must contain at least {1} special character(s). | O(A) {0} deve conter pelo menos {1} caractere(s) especial(is). |
| XMustContainBetweenYandZCharacters | The {0} must contain between {1} and {2} character(s). | O(A) {0} deve conter entre {1} e {2} caracteres. |
| XMustContainOnlyDigits | {0} must contain only digits. | {0} deve conter apenas dígitos. |
| XMustContainYCharacters | The {0} must contain {1} character(s). | O(A) {0} deve conter {1} caractere(s). |
| XMustHaveAtLeastYCharacters | The {0} must have at least {1} character(s). | O(A) {0} deve ter pelo menos {1} caractere(s). |
| XMustHaveUpToYCharacters | The {0} must have up to {1} character(s). | O(A) {0} deve ter até {1} caractere(s). |
| XNamedYAlreadyExists | A {0} named {1} already exists. | Já existe um(a) {0} com o nome {1}. |
| XNotFound | {0} not found. | {0} não encontrado(a). |
| XNotProvided | {0} not provided. | {0} não informado(a). |
| XRecordsImported | {0} record(s) imported. | {0} registro(s) importado(s). |
| XRegisteredSuccessfully | {0} registered successfully. | {0} cadastrado(a) com sucesso. |
| XRequired | {0} is required. | {0} é obrigatório(a). |
| XSentSuccessfully | {0} sent successfully. | {0} enviado(a) com sucesso. |
| XUnavailableTryAgainLater | {0} is unavailable right now. Try again in a few moments. | {0} está indisponível no momento. Tente novamente em alguns instantes. |
| XUpdatedSuccessfully | {0} updated successfully. | {0} atualizado(a) com sucesso. |
| XYSuccess | {0} {1} successfully. | {0} {1} com sucesso. |

---

## Generic Messages

Direct messages without parameters.

| Key | English | Portuguese (pt-BR) |
|-----|---------|-------------------|
| AccessDenied | Access denied. | Acesso negado. |
| CancelDeletion | Cancel deletion | Cancelar exclusão |
| CodeExpired | Code expired. | Código expirado. |
| ConfirmYouAreNotARobot | Confirm you are not a robot before continuing. | Confirme que você não é um robô antes de continuar. |
| CouldNotCopy | Could not copy automatically. Select the text and copy it manually. | Não foi possível copiar automaticamente. Selecione o texto e copie manualmente. |
| DoYouReallyLogout | Do you really want to logout? | Deseja realmente sair? |
| EmailConfirmed | E-mail confirmed. | E-mail confirmado. |
| EmailMustBeConfirmed | E-mail must be confirmed. | E-mail precisa estar confirmado. |
| EndDateMustBeGreaterThanStartDate | End date must be greater than start date. | A data de término deve ser maior que a data de início. |
| ErrorInProvidedParameters | Error in provided parameters. | Erro nos parâmetros informados. |
| IdObjectNotMatchUrl | The ID in the object does not match the ID in the URL. | O ID no objeto não corresponde ao ID no URL. |
| InactiveUser | Inactive user. | Usuário inativo. |
| InvalidCredentials | Invalid credentials. | Credenciais inválidas. |
| InvalidExpiredToken | Invalid or expired token. | Token inválido ou expirado. |
| InvalidFileContent | The file content is invalid. | O conteúdo do arquivo é inválido. |
| LoginSuccessful | Login successful. | Login bem-sucedido. |
| LogoutConfirmation | Logout confirmation | Confirmação de saída |
| NoFileProvided | No file was provided. | Nenhum arquivo informado. |
| NoneParameterInformed | No parameter was provided. | Nenhum parâmetro informado. |
| NoPermissionToAccessResource | You do not have permission to access this resource. Ask an administrator if you need access. | Você não tem permissão para acessar este recurso. Se necessário, solicite acesso ao administrador. |
| NotAllowed | Not allowed. | Não permitido. |
| OperationPerformedSuccessfully | Operation performed successfully. | Operação realizada com sucesso. |
| PageNotFound | Page not found. | Página não encontrada. |
| PasswordResetFailed | Password reset failed. | Falha ao redefinir senha. |
| PasswordResetLinkSentIfRegistered | If that address is registered, a link to reset the password has been sent. Check your inbox and your spam folder. | Se o endereço estiver cadastrado, um link para redefinir a senha foi enviado. Verifique sua caixa de entrada e a pasta de spam. |
| PasswordResetMailWasSent | Password reset e-mail sent. | E-mail para redefinição de senha enviado. |
| PasswordResetSuccessful | Password reset successfully. | Senha redefinida com sucesso. |
| ProcessingCompleted | Processing completed. | Processamento concluído. |
| ProvideAtLeastOneParameter | Provide at least one parameter. | Informe pelo menos um parâmetro. |
| ReceivedWillBeProcessedShortly | Received. It will be processed shortly. | Recebido. O processamento ocorrerá em breve. |
| SearchNoResultsRedefineFilters | No results. Try widening the filters. | Pesquisa sem resultado. Redefina os filtros. |
| SelectAnOption | Select an option. | Selecione uma opção. |
| TextCopied | Text copied. | Texto copiado. |
| TheOperationCouldNotBePerformed | The operation could not be performed. | Não foi possível realizar a operação. |
| ThisActionCannotBeUndone | This action cannot be undone. | Esta ação não pode ser desfeita. |
| ToConfirmDeletion | To confirm deletion | Para confirmar a exclusão |
| TooManyRequestsTryAgainLater | Too many requests. Try again in a few minutes. | Muitas requisições. Tente novamente em alguns minutos. |
| UnexpectedError | Something went wrong. Try again in a few moments. | Ocorreu um erro inesperado. Tente novamente em alguns instantes. |
| UnsavedChangesWillBeLost | There are unsaved changes. If you leave now, they will be lost. Do you really want to leave? | Há alterações não salvas. Se você sair agora, elas serão perdidas. Deseja realmente sair? |
| UploadedFileIsEmpty | The uploaded file is empty. | O arquivo enviado está vazio. |
| ValidationProblemsFound | Validation problems were found. | Problemas de validação encontrados. |
| ValidVerificationCode | Valid verification code. | Código de verificação válido. |
| ValueOutsideRange | Value outside range. | Valor fora da faixa. |
| ValueShownOnlyOnce | This value is shown only once. Copy it and store it somewhere safe before closing. | Este valor será exibido apenas uma vez. Copie e guarde em local seguro antes de fechar. |
| YouCannotChangeYourOwnPermissions | You cannot change your own permissions. Ask another administrator. | Você não pode alterar as próprias permissões. Solicite a outro administrador. |

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
| `Messages.AtLeastOneTheseParametersShoudBeFilledX` (misspelled; still present, to be removed in the next major version) | `Messages.AtLeastOneOfTheseParametersShouldBeFilledX` |

---

## Related Dictionaries

- [Actions Dictionary](ACTIONS.md) - Action labels and commands
- [Fields Dictionary](FIELDS.md) - Form field labels and UI elements
- [Back to README](../README.md)
