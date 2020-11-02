using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Application.ViewModels
{
    public class IssueViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ToEmail { get; set; }
        public string City { get; set; }
        public string LivingObject { get; set; }
        public string Floor { get; set; }
        public string LivingEntryNumber { get; set; }
        public string AppartmentNumber { get; set; }
        public string IssueSubject { get; set; }
        public string Message { get; set; }
    }
}
