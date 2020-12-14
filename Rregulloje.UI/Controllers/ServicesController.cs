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

        [HttpGet("getService/{serviceId}")]
        public async Task<IActionResult> GetServicesById(int serviceId)
        {
            var services = await _servicesService.GetServiceById(serviceId);
            return Ok(services);
        }

        [HttpGet("getMinServices/{serviceId}")]
        public async Task<IActionResult> GetMinServicesByServiceId(int serviceId)
        {
            var minServices = await _servicesService.GetMinServicesByServiceId(serviceId);
            return Ok(minServices); 
        }

        [HttpGet("getServiceTypes")]
        public async Task<IActionResult> GetServiceTypes()
        {
            var serviceTypes = await _servicesService.GetServiceTypes(); 
            return Ok(serviceTypes); 
        }
    }
}