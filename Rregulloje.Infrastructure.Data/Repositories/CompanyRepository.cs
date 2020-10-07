using Rregulloje.Domain.Context;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        private readonly ApplicationDbContext _context; 

        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task<Company> GetCompanyAsync(int id) 
        {
            var company = await base.GetAsync<Company>(id);
            return company;

        }
    }
}
