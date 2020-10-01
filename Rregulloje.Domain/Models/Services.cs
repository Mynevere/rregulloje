using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Domain.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinServiceId { get; set; }
        public MinServices MinService { get; set; } 

    }
}
