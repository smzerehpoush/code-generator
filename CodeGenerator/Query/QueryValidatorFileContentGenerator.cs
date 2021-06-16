namespace CodeGenerator.Query
{
    public static class QueryValidatorFileContentGenerator
    {
        private const string FileContent = @"using FluentValidation;

namespace {NAMESPACE}
{
    public class {QUERY_NAME}QueryValidator : AbstractValidator<{QUERY_NAME}Query>
    {
        public {QUERY_NAME}QueryValidator()
        {
            // RuleFor(p => p.)
                // .NotNull();
        }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{QUERY_NAME}", commandName);
        }
    }
}