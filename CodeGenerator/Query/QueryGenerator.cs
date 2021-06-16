using System.IO;
using System.Threading.Tasks;

namespace CodeGenerator.Query
{
    public static class QueryGenerator
    {
        public static async Task Generate(string basePath, string namespaceValue, string commandName)
        {
            var commandFilesPath = $"{basePath}{Path.DirectorySeparatorChar}{commandName}";
            namespaceValue = $"{namespaceValue}.{commandName}";
            Directory.CreateDirectory(commandFilesPath);
            var commandFileContent = QueryFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}Query.cs", commandFileContent);
            var commandHandlerFileContent = QueryHandlerFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryHandler.cs",
                commandHandlerFileContent);
            var commandResultFileContent = QueryResultFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryResult.cs",
                commandResultFileContent);
            var commandValidatorFileContent =
                QueryValidatorFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryValidator.cs",
                commandValidatorFileContent);
            var commandViewModelFileContent =
                QueryViewModelFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryViewModel.cs",
                commandViewModelFileContent);
            var commandNotificationFileContent =
                QueryNotificationFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryNotification.cs",
                commandNotificationFileContent);
            var commandNotificationHandlerFileContent =
                QueryNotificationHandlerFileContentGenerator.Generate(namespaceValue, commandName);
            await File.WriteAllTextAsync($"{commandFilesPath}{Path.DirectorySeparatorChar}{commandName}QueryNotificationHandler.cs",
                commandNotificationHandlerFileContent);
        }
    }
}