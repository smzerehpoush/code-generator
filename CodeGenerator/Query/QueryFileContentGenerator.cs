namespace CodeGenerator.Query
{
    public static class QueryFileContentGenerator
    {
        private const string FileContent = @"using System.Runtime.Serialization;
using MediatR;

namespace {NAMESPACE}
{
    [DataContract]
    public class {QUERY_NAME}Query : IRequest<{QUERY_NAME}QueryResult>
    {
        // [DataMember(Name = "")] public - - { get; }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{QUERY_NAME}", commandName);
        }
    }
}