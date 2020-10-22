using AutoMapper;
using Rregulloje.Application.Helpers;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;

namespace Rregulloje.Application.AutoMapper
{
    internal class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Service, ServicesViewModel>()
                .ForMember(d => d.PictureUrl, o => o.MapFrom<ServiceUrlReslover>());
            CreateMap<ServicesViewModel, Service>();
            CreateMap<UserMessageEmail, UserMessageEmailViewModel>();
            CreateMap<UserMessageEmailViewModel, UserMessageEmail>();
            CreateMap<IssueViewModel, Issue>();
            CreateMap<Issue, IssueViewModel>();
        }
    }
}