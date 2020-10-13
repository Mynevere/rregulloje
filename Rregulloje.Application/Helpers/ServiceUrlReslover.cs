using AutoMapper;
using Microsoft.Extensions.Configuration;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Application.Helpers
{
    public class ServiceUrlReslover : IValueResolver<Service, ServicesViewModel, string>
    {
        private readonly IConfiguration _config;

        public ServiceUrlReslover(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Service source, ServicesViewModel destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
}
