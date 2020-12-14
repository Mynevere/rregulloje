using Microsoft.EntityFrameworkCore;
using Rregulloje.Domain.Context;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Repositories
{
    public class ServicesRepository : BaseRepository, IServicesRepository 
    {
        private readonly ApplicationDbContext _context;

        public ServicesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<ICollection<T>> GetAllAsync<T>() where T : class
        {
            return await base.GetAllAsync<T>();
        }

        public async Task<Service> GetServiceById(int serviceId)
        {
            var service = await _context.Services.Where(x => x.Id == serviceId).FirstOrDefaultAsync();
            return service;
        }



        public async Task<IEnumerable<MinServices>> GetMinServicesByServiceId(int serviceId)
        {
            var service = await _context.Services.Where(x => x.Id == serviceId).FirstOrDefaultAsync();
            var minServices = await _context.MinServices.Where(x => x.ServiceId == serviceId).ToListAsync();
            minServices.ForEach(x => x.Service = service);

            return minServices;
        }
    }
}
