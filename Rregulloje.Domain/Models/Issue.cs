using System;
using System.Collections.Generic;
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
        public string LivingObject { get; set; }
        public string LivingEntryNumber { get; set; }
        public string AppartmentNumber { get; set; }
        public string IssueSubject { get; set; }
        public string Message { get; set; }
    }
}
