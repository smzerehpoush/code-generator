namespace CodeGenerator.Query
{
    public static class QueryResultFileContentGenerator
    {
        private const string FileContent = @"using AutoMapper;
using Sep.SepPay.Wallet.Application.Common.Mappings;

namespace {NAMESPACE}
{
    public class {QUERY_NAME}QueryResult : IMapFrom<object>
    {
        public void Mapping(Profile profile)
        {
            // profile.CreateMap<, {QUERY_NAME}QueryResult>()
            // .ForMember(d=> d. , opt=> opt.MapFrom(s=> s.))
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