using System.Threading.Tasks;
using CodeGenerator.Command;
using CodeGenerator.Query;

namespace CodeGenerator
{
    class CodeGenerator
    {
        static async Task Main()
        {
            // var basePath =
            //     @"C:\Users\mahdi\w\seppay-service\src\Wallet\core\Sep.SepPay.Wallet.Application\Wallet\Commands";
            // var baseNamespace = @"Sep.SepPay.Wallet.Application.Wallet.Commands";
            // var commandName = "AddAccountToWallet";
            // await CommandGenerator.Generate(basePath, baseNamespace, commandName);
            
            var basePath =
                @"C:\Users\mahdi\w\seppay-service\src\Wallet\core\Sep.SepPay.Wallet.Application\Wallet\Queries";
            var baseNamespace = @"Sep.SepPay.Wallet.Application.Wallet.Queries";
            var queryName = "TrackRequest";
            await QueryGenerator.Generate(basePath, baseNamespace, queryName);
        }
    }
}