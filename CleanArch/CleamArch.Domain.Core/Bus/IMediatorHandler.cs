using System.Threading.Tasks;
using CleamArch.Domain.Core.Commands;

namespace CleamArch.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}