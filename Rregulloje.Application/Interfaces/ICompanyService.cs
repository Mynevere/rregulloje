﻿using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<Company> GetCompanyAsync( int id); 
    }
}
