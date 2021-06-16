namespace CodeGenerator.Command
{
    public static class CommandValidatorFileContentGenerator
    {
        private const string FileContent = @"using FluentValidation;

namespace {NAMESPACE}
{
    public class {COMMAND_NAME}CommandValidator : AbstractValidator<{COMMAND_NAME}Command>
    {
        public {COMMAND_NAME}CommandValidator()
        {
            // RuleFor(p => p.)
                // .NotNull();
        }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{COMMAND_NAME}", commandName);
        }
    }
}