namespace CodeGenerator.Command
{
    public static class CommandHandlerFileContentGenerator
    {
        private const string FileContent = @"using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Sep.SepPay.Wallet.Application.Common.Commands;
using Sep.SepPay.Wallet.Application.Common.Interfaces;

namespace {NAMESPACE}
{
    public class {COMMAND_NAME}CommandHandler : CommandHandlerBase<{COMMAND_NAME}Command,
        {COMMAND_NAME}CommandHandler, {COMMAND_NAME}CommandResult>
    {
        public {COMMAND_NAME}CommandHandler(ILogger<{COMMAND_NAME}CommandHandler> logger, IMapper mapper,
            IProjectDbContext dbContext, IMediator mediator, IRequestContext requestContext) : base(logger, mapper,
            dbContext, mediator, requestContext)
        {
        }

        public override Task<{COMMAND_NAME}CommandResult> Handle({COMMAND_NAME}Command request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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