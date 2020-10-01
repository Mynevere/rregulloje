using System.ComponentModel.DataAnnotations.Schema;

namespace Rregulloje.Domain.Models
{
    public class MinServices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ServiceTypeId { get; set; }

        [ForeignKey("ServiceTypeId")]
        public ServiceType ServiceType { get; set; } 

    }
}