using Rregulloje.Domain.Models;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Interfaces
{
    public interface IOperatorSettingsRepository
    {
        OperatorSettings GetOperatorSettings(string description);
        Task<OperatorSettings> GetOperatorSettingsAsync(string description);
    }
}
