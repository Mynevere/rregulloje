using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rregulloje.Application.Interfaces;

namespace Rregulloje.UI.Controllers
{
    public class CompanyController : BaseApiController
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("getCompany/{id}")]
        public async Task<IActionResult> GetCompany(int id)   
        {
            var result = await _companyService.GetCompanyAsync(id);
            return Ok(result);
        }
    }
}