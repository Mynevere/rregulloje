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
    public class OperatorSettingsRepository : IOperatorSettingsRepository
    {
        private readonly ApplicationDbContext _ctx;

        public OperatorSettingsRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public OperatorSettings GetOperatorSettings(string description)
        {
            var operatorSettings = _ctx.OperatorSettings.Where(x => x.Description == description).FirstOrDefault();

            return operatorSettings;
        }
        public async Task<OperatorSettings> GetOperatorSettingsAsync(string description)
        {
            var operatorSettings = await _ctx.OperatorSettings.Where(x => x.Description == description).FirstOrDefaultAsync();

            return operatorSettings;
        }
    }
}
