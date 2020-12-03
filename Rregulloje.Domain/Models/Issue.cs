using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rregulloje.Domain.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ToEmail { get; } = "myneverehyseni@gmail.com"; 
        public string City { get; set; }
        public string LivingObject { get; set; }
        public string Floor { get; set; }
        public string LivingEntryNumber { get; set; }
        public string ApartmentNumber { get; set; } 
        //public string IssueSubject { get; set; }
        public string Message { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
