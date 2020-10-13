using System.ComponentModel.DataAnnotations.Schema;

namespace Rregulloje.Domain.Models
{
    public class MinServices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ServiceId { get; set; }

        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
    }
}