using AutoMapper;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;

namespace Rregulloje.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Service, ServicesViewModel>();
            CreateMap<ServicesViewModel, Service>();
        }
    }
}