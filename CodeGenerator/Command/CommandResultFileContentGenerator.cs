namespace CodeGenerator.Command
{
    public static class CommandResultFileContentGenerator
    {
        private const string FileContent = @"using AutoMapper;
using Sep.SepPay.Wallet.Application.Common.Mappings;

namespace {NAMESPACE}
{
    public class {COMMAND_NAME}CommandResult : IMapFrom<object>
    {
        public void Mapping(Profile profile)
        {
            // profile.CreateMap<, {COMMAND_NAME}CommandResult>()
            // .ForMember(d=> d. , opt=> opt.MapFrom(s=> s.))
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