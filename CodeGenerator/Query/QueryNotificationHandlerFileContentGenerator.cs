namespace CodeGenerator.Query
{
    public static class QueryNotificationHandlerFileContentGenerator
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
    public class {QUERY_NAME}QueryNotificationHandler : NotificationHandlerBase<
        {QUERY_NAME}QueryNotification,
        {QUERY_NAME}QueryNotificationHandler>
    {
        private readonly IProjectDbContext _dbContext;

        public {QUERY_NAME}QueryNotificationHandler(
            ILogger<{QUERY_NAME}QueryNotificationHandler> logger,
            IProjectDbContext dbContext) : base(logger)
        {
            _dbContext = dbContext;
        }

        public override async Task Handle({QUERY_NAME}QueryNotification notification,
            CancellationToken cancellationToken)
        {
            var clientTransaction =
                new ClientTransaction(notification.Client, ClientTransactionType.{QUERY_NAME});
            await _dbContext.ClientTransactions.AddAsync(clientTransaction, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
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