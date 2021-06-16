namespace CodeGenerator.Query
{
    public static class QueryViewModelFileContentGenerator
    {
        private const string FileContent = @"using System.Runtime.Serialization;
using AutoMapper;
using Sep.SepPay.Wallet.Application.Common.Mappings;

namespace {NAMESPACE}
{
    [DataContract]
    public class {QUERY_NAME}QueryViewModel : IMapFrom<{QUERY_NAME}QueryResult>
    {
        // [DataMember(Name = "")] public - -  { get; set; }

        public void Mapping(Profile profile)
        {
            // profile.CreateMap<{QUERY_NAME}QueryResult, {QUERY_NAME}QueryViewModel>()
            // .ForMember(d => d., opt => opt.MapFrom(s => s.));
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