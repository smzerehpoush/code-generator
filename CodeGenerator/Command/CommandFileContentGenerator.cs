namespace CodeGenerator.Command
{
    public static class CommandFileContentGenerator
    {
        private const string FileContent = @"using System.Runtime.Serialization;
using MediatR;

namespace {NAMESPACE}
{
    [DataContract]
    public class {COMMAND_NAME}Command : IRequest<{COMMAND_NAME}CommandResult>
    {
        // [DataMember(Name = "")] public - - { get; }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{COMMAND_NAME}", commandName);
        }
    }
}