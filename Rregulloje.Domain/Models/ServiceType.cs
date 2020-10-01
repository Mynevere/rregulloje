using System.ComponentModel.DataAnnotations.Schema;

namespace Rregulloje.Domain.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? MinServiceId { get; set; }

        [ForeignKey("MinServiceId")]
        public MinServices MinService { get; set; }
    }
}