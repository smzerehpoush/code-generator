namespace CodeGenerator.Command
{
    public static class CommandNotificationFileContentGenerator
    {
        private const string FileContent = @"using MediatR;
using Sep.SepPay.Wallet.Domain.Entities;

namespace {NAMESPACE}
{
    public class {COMMAND_NAME}CommandNotification : INotification
    {
        public {COMMAND_NAME}CommandNotification(Client client)
        {
            Client = client;
        }

        public Client Client { get; }
    }
}";

        public static string Generate(string commandNamespace, string commandName)
        {
            return FileContent.Replace("{NAMESPACE}", commandNamespace)
                .Replace("{COMMAND_NAME}", commandName);
        }
    }
}