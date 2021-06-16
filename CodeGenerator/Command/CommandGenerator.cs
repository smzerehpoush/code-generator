using System.IO;
using System.Threading.Tasks;

namespace CodeGenerator.Command
{
    public static class CommandGenerator
    {
        public static async Task Generate(string basePath, string namespaceValue, string commandName)
        {
            var commandFilesPath = $"{basePath}{Path.DirectorySeparatorChar}{commandName}";
            namespaceValue = $"{namespaceValue}.{commandName}";
            Directory.CreateDirectory(commandFilesPath);
            var commandFileContent = CommandFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}Command.cs", commandFileContent);
            var commandHandlerFileContent = CommandHandlerFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandHandler.cs",
                commandHandlerFileContent);
            var commandResultFileContent = CommandResultFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandResult.cs",
                commandResultFileContent);
            var commandValidatorFileContent =
                CommandValidatorFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandValidator.cs",
                commandValidatorFileContent);
            var commandViewModelFileContent =
                CommandViewModelFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandViewModel.cs",
                commandViewModelFileContent);
            var commandNotificationFileContent =
                CommandNotificationFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandNotification.cs",
                commandNotificationFileContent);
            var commandNotificationHandlerFileContent =
                CommandNotificationHandlerFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}CommandNotificationHandler.cs",
                commandNotificationHandlerFileContent);
        }
    }
}