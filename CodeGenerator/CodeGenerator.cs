using System.Threading.Tasks;
using CodeGenerator.Command;
using CodeGenerator.Query;

namespace CodeGenerator
{
    class CodeGenerator
    {
        static async Task Main()
        {
            const string basePath =
            @"C:\Users\mahdi\w\seppay-service\src\Wallet\core\Sep.SepPay.Wallet.Application\Wpg\Commands";
            const string baseNamespace = @"Sep.SepPay.Wallet.Application.Wpg.Commands";
            const string  commandName = "AuthorizeMerchant";
            await CommandGenerator.Generate(basePath, baseNamespace, commandName);
            
            // const string basePath =
                // @"C:\Users\mahdi\w\seppay-service\src\Wallet\core\Sep.SepPay.Wallet.Application\Wpg\Queries";
            // const string baseNamespace = @"Sep.SepPay.Wallet.Application.Wallet.Queries";
            // const string queryName = "TrackRequest";
            // await QueryGenerator.Generate(basePath, baseNamespace, queryName);
        }
    }
}