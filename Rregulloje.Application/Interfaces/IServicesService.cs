﻿using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Interfaces
{
    public interface IServicesService
    {
        Task<IEnumerable<ServicesViewModel>> GetServices();
        Task<Service> GetServiceById(int serviceId);
        Task<IEnumerable<MinServicesViewModel>> GetMinServicesByServiceId(int serviceId); 
        Task<IEnumerable<ServiceTypesViewModel>> GetServiceTypes();   
    }
}
