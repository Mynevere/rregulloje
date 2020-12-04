using AutoMapper;
using Rregulloje.Application.Interfaces;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Services
{
    public class ServicesService : IServicesService
    {
        private readonly IMapper _mapper;
        private readonly IServicesRepository _servicesRepository; 

        public ServicesService(IMapper mapper, IServicesRepository servicesRepository) 
        {
            _servicesRepository = servicesRepository;
            _mapper = mapper;
        }

        public async Task<Service> GetServiceById(int serviceId) 
        {
            var service = await _servicesRepository.GetServiceById(serviceId);
            return service;
        }

        public async Task<IEnumerable<ServicesViewModel>> GetServices() 
        {
            var services = await _servicesRepository.GetAllAsync<Service>(); 
            return _mapper.Map<IEnumerable<ServicesViewModel>>(services);
        }
    }
}
