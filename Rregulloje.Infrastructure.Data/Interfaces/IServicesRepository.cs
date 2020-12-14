using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Interfaces
{
    public interface IServicesRepository
    {
        Task<ICollection<T>> GetAllAsync<T>() where T : class;
        Task<Service> GetServiceById(int serviceId);
        Task<IEnumerable<MinServices>> GetMinServicesByServiceId(int serviceId);
    }
}
