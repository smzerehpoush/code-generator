namespace CodeGenerator.Command
{
    public static class CommandViewModelFileContentGenerator
    {
        private const string FileContent = @"using System.Runtime.Serialization;
using AutoMapper;
using Sep.SepPay.Wallet.Application.Common.Mappings;

namespace {NAMESPACE}
{
    [DataContract]
    public class {COMMAND_NAME}CommandViewModel : IMapFrom<{COMMAND_NAME}CommandResult>
    {
        // [DataMember(Name = "")] public - -  { get; set; }

        public void Mapping(Profile profile)
        {
            // profile.CreateMap<{COMMAND_NAME}CommandResult, {COMMAND_NAME}CommandViewModel>()
            // .ForMember(d => d., opt => opt.MapFrom(s => s.));
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