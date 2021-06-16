namespace CodeGenerator.Query
{
    public static class QueryHandlerFileContentGenerator
    {
        private const string FileContent = @"using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Sep.SepPay.Wallet.Application.Common.Queries;
using Sep.SepPay.Wallet.Application.Common.Interfaces;

namespace {NAMESPACE}
{
    public class {QUERY_NAME}QueryHandler : QueryHandlerBase<{QUERY_NAME}Query,
        {QUERY_NAME}QueryHandler, {QUERY_NAME}QueryResult>
    {
        public {QUERY_NAME}QueryHandler(ILogger<{QUERY_NAME}QueryHandler> logger, IMapper mapper,
            IProjectDbContext dbContext, IMediator mediator, IRequestContext requestContext) : base(logger, mapper,
            dbContext, mediator, requestContext)
        {
        }

        public override Task<{QUERY_NAME}QueryResult> Handle({QUERY_NAME}Query request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
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