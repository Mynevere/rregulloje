using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rregulloje.Application.Interfaces;

namespace Rregulloje.UI.Controllers
{
    public class ServicesController : BaseApiController
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [HttpGet("getServices")] 
        public async Task<IActionResult> GetServices() 
        {
            var services = await _servicesService.GetServices(); 
            return Ok(services);
        }
    }
}