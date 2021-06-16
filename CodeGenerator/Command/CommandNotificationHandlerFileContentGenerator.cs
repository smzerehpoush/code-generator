namespace CodeGenerator.Command
{
    public static class CommandNotificationHandlerFileContentGenerator
    {
        private const string FileContent = @"using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Sep.SepPay.Wallet.Application.Common.Interfaces;
using Sep.SepPay.Wallet.Application.Common.Notifications;
using Sep.SepPay.Wallet.Domain.Entities;
using Sep.SepPay.Wallet.Domain.Shared.Enums;

namespace {NAMESPACE}
{
    public class {COMMAND_NAME}CommandNotificationHandler : NotificationHandlerBase<
        {COMMAND_NAME}CommandNotification,
        {COMMAND_NAME}CommandNotificationHandler>
    {
        private readonly IProjectDbContext _dbContext;

        public {COMMAND_NAME}CommandNotificationHandler(
            ILogger<{COMMAND_NAME}CommandNotificationHandler> logger,
            IProjectDbContext dbContext) : base(logger)
        {
            _dbContext = dbContext;
        }

        public override async Task Handle({COMMAND_NAME}CommandNotification notification,
            CancellationToken cancellationToken)
        {
            var clientTransaction =
                new ClientTransaction(notification.Client, ClientTransactionType.{COMMAND_NAME});
            await _dbContext.ClientTransactions.AddAsync(clientTransaction, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
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