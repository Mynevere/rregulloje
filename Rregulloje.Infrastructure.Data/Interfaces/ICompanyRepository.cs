using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company> GetCompanyAsync(int id);   
    }
}
