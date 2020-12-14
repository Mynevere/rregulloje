using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Application.ViewModels
{
    public class MinServicesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public List<ServiceType> ServiceType { get; set; }
    }
}