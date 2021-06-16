namespace CodeGenerator.Query
{
    public static class QueryNotificationFileContentGenerator
    {
        private const string FileContent = @"using MediatR;
using Sep.SepPay.Wallet.Domain.Entities;

namespace {NAMESPACE}
{
    public class {QUERY_NAME}QueryNotification : INotification
    {
        public {QUERY_NAME}QueryNotification(Client client)
        {
            Client = client;
        }

        public Client Client { get; }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{QUERY_NAME}", commandName);
        }
    }
}