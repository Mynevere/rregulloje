using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Application.ViewModels
{
    public class ServiceTypesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? MinServiceId { get; set; }
        public MinServices MinService { get; set; }
    }
}
