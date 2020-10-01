using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Core.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int MiniServiceId { get; set; }
    }
}
